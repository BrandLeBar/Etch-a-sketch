
Option Compare Text
Option Explicit On
Option Strict On

Imports System.ComponentModel
Imports System.IO.Ports
Imports System.Threading.Thread

Public Class EtchASketch

    'Buttons //////////////////////////////////////////////////////////////////////////////////////
    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click, ClearMenuItem.Click, ClearMenuItem1.Click
        Dim g As Graphics = DrawBox.CreateGraphics
        ShakeIt()
        g.Clear(DrawBox.BackColor)
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click, ExitMenuItem.Click, ExitMenuItem1.Click
        Me.Close()
    End Sub

    Private Sub SelectColorButton_Click(sender As Object, e As EventArgs) Handles SelectColorButton.Click, SelectColorMenuItem.Click, SelectColorMenuItem1.Click
        SelectColor(False)
    End Sub

    Private Sub DrawWaveformsButton_Click(sender As Object, e As EventArgs) Handles DrawWaveformsButton.Click, DrawWaveformsMenuItem.Click, DrawWaveformsMenuItem1.Click
        Dim g As Graphics = DrawBox.CreateGraphics
        ShakeIt()
        g.Clear(DrawBox.BackColor)
        Graticules()
        DrawWaveforms()
    End Sub

    'Subs //////////////////////////////////////////////////////////////////////////////////////////

    ''' <summary>
    ''' This tracks the cursor and draws a line following it
    ''' </summary>
    ''' <param name="oldX"></param>
    ''' <param name="oldY"></param>
    ''' <param name="currentX"></param>
    ''' <param name="currentY"></param>
    Sub DrawWithMouse(oldX As Integer, oldY As Integer, currentX As Integer, currentY As Integer)
        Dim g As Graphics = DrawBox.CreateGraphics
        Dim pen As New Pen(SelectColor(), 3)

        g.DrawLine(pen, oldX, oldY, currentX, currentY)

        g.Dispose()
    End Sub

    Sub DrawWithPots(oldX As Integer, oldY As Integer, currentX As Integer, currentY As Integer)
        Dim g As Graphics = DrawBox.CreateGraphics
        Dim pen As New Pen(SelectColor(), 3)

        g.DrawLine(pen, oldX, oldY, currentX, currentY)

        g.Dispose()
    End Sub

    ''' <summary>
    ''' This handels the mouse button click events
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub GraphicExamplesForm_MouseMove(sender As Object, e As MouseEventArgs) Handles DrawBox.MouseMove, DrawBox.MouseDown
        Static oldX, oldY As Integer

        If NormalRadioButton.Checked Then
            Select Case e.Button.ToString
                Case "Left"
                    DrawWithMouse(oldX, oldY, e.X, e.Y)
                Case "Right"
                'opens option menu
                Case "Middle"
                    SelectColor(False)
            End Select
            oldX = e.X
            oldY = e.Y
        End If

    End Sub

    ''' <summary>
    ''' Draws some waveforms 90 degress out of phase
    ''' </summary>
    Sub DrawWaveforms()
        Dim g As Graphics = DrawBox.CreateGraphics
        Dim penBlue As New Pen(Color.Blue, 3)
        Dim penRed As New Pen(Color.Red, 3)
        Dim penYellow As New Pen(Color.Yellow, 3)
        Dim ymax As Integer = CInt(DrawBox.Height / 2)
        Dim oldX, oldY, newY As Integer
        Dim yOffset As Integer = CInt(DrawBox.Height / 2)
        Dim degreesPerPoint As Double = 360 / DrawBox.Width

        oldY = yOffset
        ymax = yOffset
        ymax *= -1

        For x = 0 To DrawBox.Width
            newY = CInt(ymax * Math.Sin((Math.PI / 180) * (x * degreesPerPoint))) + yOffset
            g.DrawLine(penRed, oldX, oldY, x, newY)
            oldX = x
            oldY = newY
        Next

        oldX = 0
        oldY = 0

        For x = 0 To DrawBox.Width
            newY = CInt(ymax * Math.Cos((Math.PI / 180) * (x * degreesPerPoint))) + yOffset
            g.DrawLine(penBlue, oldX, oldY, x, newY)
            oldX = x
            oldY = newY
        Next

        oldX = 0
        oldY = yOffset

        For x = 0 To DrawBox.Width
            newY = CInt(ymax * Math.Tan((Math.PI / 180) * (x * degreesPerPoint))) + yOffset
            g.DrawLine(penYellow, oldX, oldY, x, newY)
            oldX = x
            oldY = newY
        Next

        g.Dispose()
    End Sub

    ''' <summary>
    ''' Draws the grid pattern
    ''' </summary>
    Sub Graticules()
        Dim g As Graphics = DrawBox.CreateGraphics
        Dim pen As New Pen(Color.Black)
        Dim currentY As Integer = 0
        Dim currentX As Integer = 0

        Do Until currentY > DrawBox.Height
            currentY += (DrawBox.Height \ 10)
            g.DrawLine(pen, 0, currentY, DrawBox.Width, currentY)
        Loop

        Do Until currentX > DrawBox.Width
            currentX += (DrawBox.Width \ 10)
            g.DrawLine(pen, currentX, 0, currentX, DrawBox.Height)
        Loop

    End Sub

    ''' <summary>
    ''' Shakes the form when cleared like a real etch-a-sketch
    ''' </summary>
    Sub ShakeIt()
        Dim shakeyness As Integer = 10

        For i = 1 To 10
            Me.Top += shakeyness
            Me.Left += shakeyness
            Sleep(100)
            shakeyness *= -1
        Next


    End Sub

    'Functions ////////////////////////////////////////////////////////////////////////////////////

    ''' <summary>
    ''' This Function allows the user to choose a color for thier pen and the program to reference it without reprompting
    ''' </summary>
    ''' <param name="doNotChange"> Optional boolean indicating is user should be reprompt for color</param>
    ''' <returns>The color selected by user </returns>
    Function SelectColor(Optional doNotChange As Boolean = True) As Color
        Static _selectColor As Color

        If doNotChange = True Then
            'don't change
        ElseIf doNotChange = False Then
            ColorDialog1.ShowDialog()
            _selectColor = ColorDialog1.Color
        End If

        If _selectColor = Nothing Then
            _selectColor = Color.Black
        Else
            'keep the color
        End If

        Return _selectColor
    End Function

    Function Connect() As SerialPort
        Dim lePort As New SerialPort
        lePort.BaudRate = 115200 'Q@ Board Default
        lePort.Parity = IO.Ports.Parity.None
        lePort.StopBits = IO.Ports.StopBits.One
        lePort.DataBits = 8
        lePort.PortName = GetPorts() 'This will change often
        Return lePort
    End Function

    Function GetPorts() As String
        Dim ports() = SerialPort.GetPortNames()
        Dim test As Boolean = False

        For Each port In ports
            test = True
            Console.WriteLine($"Current active port: {port}")
            Return port
        Next

        If test = False Then
            Console.WriteLine("Bro Has No Ports lol")
        End If
        Return Nothing
    End Function

    Function Read() As List(Of Byte)
        Dim result As New List(Of Byte)
        Do Until result.Count >= 5
            Write()
            Write()
            Write()
            Dim data(SerialPort1.BytesToRead) As Byte

            SerialPort1.Read(data, 0, data.Count)

            For i = 0 To UBound(data)

                result.Add(data(i))

            Next
        Loop

        Try
            Console.WriteLine()
            For i = 0 To 3
                Select Case i
                    Case 0
                        Console.WriteLine($"Upper Bit AN1: {result.Item(i)}")
                    Case 1
                        Console.WriteLine($"Lower Bit AN1: {result.Item(i)}")
                    Case 2
                        Console.WriteLine($"Upper Bit AN2: {result.Item(i)}")
                    Case 3
                        Console.WriteLine($"Lower Bit AN2: {result.Item(i)}")
                End Select
            Next
            Console.WriteLine()
        Catch ex As Exception
            MsgBox(ErrorToString)
        End Try
        Return result
    End Function

    Function WeightY(upperByte As Byte, lowerByte As Byte) As Integer
        Dim value As Integer = ((CInt(upperByte) << 2) Or (lowerByte >> 6)) And &H3FF
        Dim scaled As Double = (value / 1023) * DrawBox.Height
        Console.WriteLine($"Y {value}")
        Console.WriteLine($"Y {scaled}")
        Return CInt(scaled)
    End Function

    Function WeightX(upperByte As Byte, lowerByte As Byte) As Integer
        Dim value As Integer = ((CInt(upperByte) << 2) Or (lowerByte >> 6)) And &H3FF
        Dim scaled As Double = (value / 1023) * DrawBox.Width
        Console.WriteLine($"X {value}")
        Console.WriteLine($"X {scaled}")
        Return CInt(scaled)
    End Function

    Sub Write()
        Dim data(0) As Byte 'put bytes into array
        data(0) = &H53
        SerialPort1.Write(data, 0, 1) 'send bytes as an array, start at index 0,
    End Sub

    Private Sub AboutToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem1.Click, AboutToolStripMenuItem.Click
        Me.Hide()
        AboutForm.Show()
    End Sub

    Private Sub EtchASketch_Load(sender As Object, e As EventArgs) Handles Me.Load
        NormalRadioButton.Checked = True
        SerialPort1 = Connect()
        Timer1.Enabled = True
        Try
            SerialPort1.Open()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub EtchASketch_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        SerialPort1.Close()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Static oldX1, oldY1 As Integer
        Dim xy As (Integer, Integer)
        Dim tempList As New List(Of Byte)

        If QRadioButton.Checked Then
            tempList = Read()


            xy = (WeightX(tempList.Item(0), tempList(1)), WeightY(tempList.Item(2), tempList.Item(3)))


            If oldX1 = 0 Or oldY1 = 0 Or xy.Item1 = 0 Or xy.Item2 = 0 Then

            Else
                If Math.Abs(xy.Item1 - oldX1) >= 50 Then
                    xy.Item1 = oldX1
                End If
                If Math.Abs(xy.Item2 - oldY1) >= 50 Then
                    xy.Item2 = oldY1
                End If
                DrawWithPots(oldX1, oldY1, xy.Item1, xy.Item2)

            End If

            oldX1 = xy.Item1
            oldY1 = xy.Item2
        End If
    End Sub

End Class

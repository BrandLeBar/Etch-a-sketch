'Brandon Barrera
'RCET 0226 
'Spring 2025
'Etch-a-sketch
'https://github.com/BrandLeBar/Etch-a-sketch.git

Option Compare Text
Option Explicit On
Option Strict On

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

    ''' <summary>
    ''' This handels the mouse button click events
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub GraphicExamplesForm_MouseMove(sender As Object, e As MouseEventArgs) Handles DrawBox.MouseMove, DrawBox.MouseDown
        Static oldX, oldY As Integer

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
    End Sub

    ''' <summary>
    ''' Draws some waveforms 90 degress out of phase
    ''' </summary>
    Sub DrawWaveforms()
        Dim g As Graphics = DrawBox.CreateGraphics
        Dim pen As New Pen(SelectColor(), 3)
        Dim ymax As Integer = CInt(DrawBox.Height / 2)
        Dim oldX, oldY, newY As Integer
        Dim yOffset As Integer = CInt(DrawBox.Height / 2)
        Dim degreesPerPoint As Double = 360 / DrawBox.Width

        oldY = yOffset
        ymax = yOffset
        ymax *= -1

        For x = 0 To DrawBox.Width
            newY = CInt(ymax * Math.Sin((Math.PI / 180) * (x * degreesPerPoint))) + yOffset
            g.DrawLine(pen, oldX, oldY, x, newY)
            oldX = x
            oldY = newY
        Next

        oldX = 0
        oldY = 0

        For x = 0 To DrawBox.Width
            newY = CInt(ymax * Math.Cos((Math.PI / 180) * (x * degreesPerPoint))) + yOffset
            g.DrawLine(pen, oldX, oldY, x, newY)
            oldX = x
            oldY = newY
        Next

        oldX = 0
        oldY = yOffset

        For x = 0 To DrawBox.Width
            newY = CInt(ymax * Math.Tan((Math.PI / 180) * (x * degreesPerPoint))) + yOffset
            g.DrawLine(pen, oldX, oldY, x, newY)
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

End Class

'Brandon Barrera
'RCET 0226 
'Spring 2025
'Etch-a-sketch
'

Option Compare Text
Option Explicit On
Option Strict On

Public Class EtchASketch
    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click, ClearMenuItem.Click, ClearMenuItem1.Click
        Dim g As Graphics = DrawBox.CreateGraphics
        g.Clear(DrawBox.BackColor)
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click, ExitMenuItem.Click, ExitMenuItem1.Click
        Me.Close()
    End Sub

    Private Sub SelectColorButton_Click(sender As Object, e As EventArgs) Handles SelectColorButton.Click, SelectColorMenuItem.Click, SelectColorMenuItem1.Click

    End Sub

    Private Sub DrawWaveformsButton_Click(sender As Object, e As EventArgs) Handles DrawWaveformsButton.Click, DrawWaveformsMenuItem.Click, DrawWaveformsMenuItem1.Click

    End Sub

End Class

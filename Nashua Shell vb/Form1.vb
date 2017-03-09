Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ContextMenuStrip1.Show()
    End Sub

    Private Sub NotepadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NotepadToolStripMenuItem.Click
        System.Diagnostics.Process.Start("notepad.exe")
    End Sub

    Private Sub PaintToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PaintToolStripMenuItem.Click
        System.Diagnostics.Process.Start("mspaint.exe")
    End Sub
End Class

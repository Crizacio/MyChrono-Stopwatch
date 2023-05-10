Imports System.Runtime.InteropServices
Public Class Main
    Dim StopWatch As New Diagnostics.Stopwatch
    Dim isFirst As Boolean = True

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Controls.Add(Label2)
    End Sub
    Private Sub Main_HelpRequested(sender As Object, hlpevent As HelpEventArgs) Handles Me.HelpRequested
        If MessageBox.Show("Programado por Urfenox" &
               vbCrLf &
               vbCrLf &
               vbCrLf & "¿Desea visitar el repositorio en GitHub?", "Ayuda", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            MsgBox("Too bad, it doesn't exists")
            'Process.Start("")
        End If
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        End
    End Sub

    Private Sub INICIARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles INICIARToolStripMenuItem.Click
        Timer1.Start()
        Me.StopWatch.Start()
        If isFirst Then
            Label3.Text = DateTime.Now.ToString("dd/MM/yyyy") & " " & Now.Hour & ":" & Now.Minute & ":" & Now.Second
            isFirst = False
        End If
    End Sub
    Private Sub DETENERToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DETENERToolStripMenuItem.Click
        Timer1.Stop()
        Me.StopWatch.Stop()
    End Sub


    Private Sub NuevoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoToolStripMenuItem.Click
        Me.StopWatch.Reset()
        Timer1.Stop()
        Label1.Text = "00:00:00"
        Label2.Text = ".000"
        Label3.Text = "00/00/0000 00:00:00"
        isFirst = True
    End Sub


    Private Sub NingunoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NingunoToolStripMenuItem.Click
        Me.FormBorderStyle = FormBorderStyle.None
        NingunoToolStripMenuItem.Checked = Not NingunoToolStripMenuItem.Checked
        AjustableToolStripMenuItem.Checked = Not NingunoToolStripMenuItem.Checked
    End Sub
    Private Sub AjustableToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AjustableToolStripMenuItem.Click
        Me.FormBorderStyle = FormBorderStyle.Sizable
        AjustableToolStripMenuItem.Checked = Not AjustableToolStripMenuItem.Checked
        NingunoToolStripMenuItem.Checked = Not AjustableToolStripMenuItem.Checked
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim elapsed As TimeSpan = Me.StopWatch.Elapsed
        Label1.Text = String.Format("{0:00}:{1:00}:{2:00}", Math.Floor(elapsed.TotalHours), elapsed.Minutes, elapsed.Seconds)
        Label2.Text = String.Format(".{0:00}", elapsed.Milliseconds)
    End Sub

    Private Sub SiempreVisibleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SiempreVisibleToolStripMenuItem.Click
        If SiempreVisibleToolStripMenuItem.Checked Then
            Me.TopMost = False
            SiempreVisibleToolStripMenuItem.Checked = False
        Else
            Me.TopMost = True
            SiempreVisibleToolStripMenuItem.Checked = True
        End If
    End Sub

    Private Sub TipoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TipoToolStripMenuItem.Click
        Dim fontDialog As New FontDialog
        fontDialog.Font = Label1.Font
        If fontDialog.ShowDialog() = DialogResult.OK Then
            Label1.Font = fontDialog.Font
            Label2.Font = New Font(fontDialog.Font.FontFamily, 24, FontStyle.Regular)
        End If
    End Sub
    Private Sub ColorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ColorToolStripMenuItem.Click
        Dim colorDialog As New ColorDialog
        colorDialog.Color = Label1.ForeColor
        If colorDialog.ShowDialog() = DialogResult.OK Then
            Label1.ForeColor = colorDialog.Color
            Label2.ForeColor = colorDialog.Color
        End If
    End Sub

    Public Const WM_NCLBUTTONDOWN As Integer = &HA1
    Public Const HT_CAPTION As Integer = &H2
    <DllImportAttribute("user32.dll")>
    Public Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal Msg As Integer, ByVal wParam As Integer, ByVal lParam As Integer) As Integer
    End Function
    <DllImportAttribute("user32.dll")>
    Public Shared Function ReleaseCapture() As Boolean
    End Function
    Private Sub PictureBox1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label1.MouseDown, Label2.MouseDown, Label3.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            ReleaseCapture()
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0)
        End If
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class

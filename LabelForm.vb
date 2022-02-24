Imports System.Deployment.Application
Public Class LabelForm
    Private Sub PrintLabelBtn_Click(sender As Object, e As EventArgs) Handles PrintLabelBtn.Click
        DymoForm.ShowDialog()
    End Sub
    Private Function GetFileVersionInfo(ByVal filename As String) As Version
        Return Version.Parse(FileVersionInfo.GetVersionInfo(filename).FileVersion)
    End Function
    Private Sub LabelForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If (ApplicationDeployment.IsNetworkDeployed) Then
            PubVer.Text = ApplicationDeployment.CurrentDeployment.CurrentVersion.ToString
        End If

        AutoPrint.Checked = True

        'In case you want to check for Dymo Software first
        Dim DymoPath As String = "C:\Program Files (x86)\DYMO\DYMO Label Software\DLS.exe"
        Dim DymoPath2 As String = "C:\Program Files (x86)\DYMO\DYMO Connect\DYMOConnect.exe"
        If Not System.IO.File.Exists(DymoPath) And Not System.IO.File.Exists(DymoPath2) Then
            MsgBox("You need the Dymo software installed first")
            Exit Sub
        End If

    End Sub

    Private Sub TimeLimit_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TimeLimit.SelectedIndexChanged
        'CureStart.Text = Now.ToString("M/d/yyyy h:mm tt")
        If TimeLimit.Text = "" Then
            Exit Sub
        End If

        Dim HoursCount As Double = Me.TimeLimit.Text
        Dim CureStartDT As Date = CureStart.Text
        Dim EndDate As Date = CureStartDT.AddHours(HoursCount)
        CureEnd.Text = EndDate.ToString("M/d/yyyy h:mm tt")
    End Sub

    Private Sub ButtonUpdate_Click(sender As Object, e As EventArgs) Handles ButtonUpdate.Click
        If TimeLimit.Text = "" Then
            Exit Sub
        End If
        CureStart.ResetText()
        Dim HoursCount As Double = Me.TimeLimit.Text
        Dim CureStartDT As Date = CureStart.Text
        Dim EndDate As Date = CureStartDT.AddHours(HoursCount)
        CureEnd.Text = EndDate.ToString("M/d/yyyy h:mm tt")
    End Sub
End Class

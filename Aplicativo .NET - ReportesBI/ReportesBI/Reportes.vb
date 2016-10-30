Public Class Reportes
    Public reporte As Integer
    Private Sub Reportes_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Me.ReportViewer1.RefreshReport()
        Me.ReportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Remote
        Dim SERVERREPORT As Microsoft.Reporting.WinForms.ServerReport

        SERVERREPORT = Me.ReportViewer1.ServerReport
        SERVERREPORT.ReportServerUrl = New Uri("http://hp14-u185la/ReportServer")
        If reporte = 0 Then
            SERVERREPORT.ReportPath = ("/REPORTES/Reporte01")
        Else
            SERVERREPORT.ReportPath = ("/REPORTES/Reporte02")
        End If
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class

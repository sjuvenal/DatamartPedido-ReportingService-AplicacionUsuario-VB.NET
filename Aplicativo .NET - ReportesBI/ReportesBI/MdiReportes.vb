Public Class MdiReportes



    Private Sub TipoPrendaMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles TipoPrendaMenuItem.Click
 
        Dim frm As New Reportes
        frm.reporte = 0
        frm.MdiParent = Me
        frm.Show()

    End Sub

    Private Sub ClaseMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ClaseMenuItem.Click
        Dim frm As New Reportes
        frm.reporte = 1
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub MdiReportes_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
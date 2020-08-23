Public Class frmMain

    Private Sub btnOpenReadForm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpenReadForm.Click
        frmRead.Show()

    End Sub

    Private Sub btnOpenWriteForm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpenWriteForm.Click
        frmWrite.Show()

    End Sub

    Private Sub frmOpenSingleMonitoringForm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpenSingleMonitoringForm.Click
        frmMonitorSingle.Show()
    End Sub

    Private Sub btnOpenSingleConnectionForm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpenSingleConnectionForm.Click
        frmConnectSingle.Show()
    End Sub

    Private Sub btnOpenMultiConnectionForm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpenMultiConnectionForm.Click
        frmConnectingMultiItems.Show()

    End Sub

    Private Sub btnOpenDataGridConnectionForm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpenDataGridConnectionForm.Click
        frmConnectDataGrid.Show()

    End Sub

    Private Sub btnOpenMultiMonitoringForm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpenMultiMonitoringForm.Click
        frmMonitoringMulti.Show()
    End Sub

    Private Sub btnOpenAsyncReadForm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpenAsyncReadForm.Click
        frmAsynchronousRead.Show()
    End Sub

    Private Sub btnOpenAsyncWriteForm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpenAsyncWriteForm.Click
        frmAsynchronousWrite.Show()
    End Sub
End Class
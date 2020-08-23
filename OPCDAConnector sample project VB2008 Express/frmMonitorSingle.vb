Public Class frmMonitorSingle

    Private Sub btnMonitorOneItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMonitorOneItem.Click

        '1. Define group and update rate
        Dim group_name As String = "my_monitor_group"
        Dim update_rate As Integer = 1000 ' milisecond

        '2. Define monitoring object and set properties
        Dim monitor_object As New GelecekOPCDAConnector.gMonitorObject
        monitor_object.itemID = txtMonitoredItem.Text

        '3. Define function result
        Dim function_result As GelecekOPCDAConnector.gFunctionResult

        '4. Call Monitoring method
        function_result = GOPCDAConnector1.gMonitorOneItem(group_name, monitor_object, update_rate)
        'Or directly CALL method like below:
        'GOPCDAConnector1.gMonitorOneItem(group_name, monitor_object, update_rate)

        '5. Check Result codes
        txtFunctionResult.Text = function_result.ToString
        txtResultID.Text = monitor_object.resultID.ToString

        ' İf function result is "OK" and result ID is "S_OK" then this is a successful monitoring definition
        ' A monitorign definition is live until you kill it.
        ' Monitoring gives values with "gMonitoredItemsValueChanged" event.



    End Sub

    Private Sub GOPCDAConnector1_gMonitoredItemsValueChanged(ByVal sender As System.Object, ByVal group As System.Object, ByVal gresultObjects() As GelecekOPCDAConnector.gOpcDaObject) Handles GOPCDAConnector1.gMonitoredItemsValueChanged

        txtValue.Text = gresultObjects(0).value

    End Sub


    Private Sub btnPause_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPause.Click
        Dim function_result As GelecekOPCDAConnector.gFunctionResult = GOPCDAConnector1.gPauseGroup("my_monitor_group")
        'Or directly CALL method like below:
        'GOPCDAConnector1.gPauseGroup("my_connect_group")

    End Sub

    Private Sub btnResume_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnResume.Click
        Dim function_result As GelecekOPCDAConnector.gFunctionResult = GOPCDAConnector1.gResumeGroup("my_monitor_group")
        'Or directly CALL method like below:
        'GOPCDAConnector1.gResumeGroup("my_connect_group")
    End Sub

    Private Sub btnKill_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKill.Click

        Dim function_result As GelecekOPCDAConnector.gFunctionResult = GOPCDAConnector1.gKillMonitoringGroup("my_monitor_group")
        'Or directly CALL method like below:
        'GOPCDAConnector1.gKillConnectionGroup("my_connect_group")
    End Sub


    Private Sub btnGetActiveState_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGetActiveState.Click
        Dim function_result As GelecekOPCDAConnector.gFunctionResult = GOPCDAConnector1.gGetActiveState("my_monitor_group")
        'If there is no error, Possible results are: "ACTIVE" or "INACTIVE"

    End Sub

    Private Sub btnGetGroupInfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGetGroupInfo.Click
        Dim all_groups_info() As GelecekOPCDAConnector.gGroup = GOPCDAConnector1.gGetGroupInfo
        'This method gives all groups info
        'For each group you can get :
        '  -activate : if group is active, TRUE
        '  -groupName
        '  -itemsNames array added to group
        '  -updateRate of group in milisecond


    End Sub

   
End Class
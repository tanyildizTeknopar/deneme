Public Class frmMonitoringMulti

    Private Sub btnClearValuesAndResuldIDs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClearValuesAndResuldIDs.Click
        txtValue1.Text = ""
        txtValue2.Text = ""
        txtValue3.Text = ""

        txtResultID1.Text = ""
        txtResultID2.Text = ""
        txtResultID3.Text = ""

    End Sub

    Private Sub btnMonitorItems_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMonitorItems.Click
        '1. Define group and update rate
        Dim group_name As String = "my_monitor_group"
        Dim update_rate As Integer = 1000 ' milisecond

        '2. Define monitoring object and set properties
        Dim monitor_objects(2) As GelecekOPCDAConnector.gMonitorObject
        For i As Integer = 0 To 2
            monitor_objects(i) = New GelecekOPCDAConnector.gMonitorObject
        Next
        monitor_objects(0).itemID = txtMonitoredItem1.Text
        monitor_objects(1).itemID = txtMonitoredItem2.Text
        monitor_objects(2).itemID = txtMonitoredItem3.Text

        '3. Define function result
        Dim function_result As GelecekOPCDAConnector.gFunctionResult

        '4. Call Monitoring method
        function_result = GOPCDAConnector1.gMonitorItems(group_name, monitor_objects, update_rate)
        'Or directly CALL method like below:
        'GOPCDAConnector1.gMonitorItems(group_name, monitor_objects, update_rate)

        '5. Check Result codes
        txtFunctionResult.Text = function_result.ToString
        txtResultID1.Text = monitor_objects(0).resultID.ToString
        txtResultID2.Text = monitor_objects(1).resultID.ToString
        txtResultID3.Text = monitor_objects(2).resultID.ToString

        ' İf function result is "OK" and result IDs is "S_OK" then this is a successful monitoring definition
        ' A monitorign definition is live until you kill it.
        ' Monitoring gives values with "gMonitoredItemsValueChanged" event.


    End Sub

    Private Sub GOPCDAConnector1_gMonitoredItemsValueChanged(ByVal sender As System.Object, ByVal group As System.Object, ByVal gresultObjects() As GelecekOPCDAConnector.gOpcDaObject) Handles GOPCDAConnector1.gMonitoredItemsValueChanged

        'In this event only changing items new values come, not all items of the group.
        Dim number_of_items As Integer = gresultObjects.Length

        If group = "my_monitor_group" Then
            For i As Integer = 0 To number_of_items - 1
                If gresultObjects(i).itemID = txtMonitoredItem1.Text Then
                    txtValue1.Text = gresultObjects(i).value
                End If

                If gresultObjects(i).itemID = txtMonitoredItem2.Text Then
                    txtValue2.Text = gresultObjects(i).value
                End If

                If gresultObjects(i).itemID = txtMonitoredItem3.Text Then
                    txtValue3.Text = gresultObjects(i).value
                End If
            Next

        End If

       

    End Sub

    Private Sub btnRemove1Item_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemove1Item.Click


        Dim itemID_to_remove As String = txtMonitoredItem1.Text

        Dim function_result As GelecekOPCDAConnector.gFunctionResult
        function_result = GOPCDAConnector1.gRemoveOneItemFromMonitorGroup("my_monitor_group", itemID_to_remove)
        'Or directly CALL method like below:
        'GOPCDAConnector1.gRemoveOneItemFromMonitorGroup("my_monitor_group", txtMonitoredItem1.Text)

    End Sub

    Private Sub btnRemove2Items_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemove2Items.Click

        'First create array of itemIDs to be removed
        Dim itemIDs_to_remove() As String = {txtMonitoredItem2.Text, txtMonitoredItem3.Text}

        Dim function_result As GelecekOPCDAConnector.gFunctionResult
        function_result = GOPCDAConnector1.gRemoveItemsFromMonitorGroup("my_monitor_group", itemIDs_to_remove)
        'Or directly CALL method like below:
        'GOPCDAConnector1.gRemoveItemsFromMonitorGroup("my_monitor_group", itemIDs_to_remove)


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
        'GOPCDAConnector1.gKillMonitoringGroup("my_connect_group")
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










    Private Sub btnSetUpdateRate1000_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSetUpdateRate1000.Click
        Dim function_result As GelecekOPCDAConnector.gFunctionResult
        function_result = GOPCDAConnector1.gSetGroupUpdateRate("my_monitor_group", 1000)
        'Or directly CALL method like below:
        'GOPCDAConnector1.gSetGroupUpdateRate("my_monitor_group", 1000)


    End Sub


    Private Sub btnSetUpdateRate5000_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSetUpdateRate5000.Click
        Dim function_result As GelecekOPCDAConnector.gFunctionResult
        function_result = GOPCDAConnector1.gSetGroupUpdateRate("my_monitor_group", 5000)
        'Or directly CALL method like below:
        'GOPCDAConnector1.gSetGroupUpdateRate("my_monitor_group", 5000)

    End Sub

   
    Private Sub frmMonitoringMulti_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
Public Class frmConnectingMultiItems


    Private Sub btnConnectItems_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConnectItems.Click

        '1. Define group and update rate
        Dim group_name As String = "my_connect_group"
        Dim update_rate As Integer = 1000 ' milisecond


        '2. Define connection object and set properties
        Dim connect_objects(2) As GelecekOPCDAConnector.gConnectionObject
        For i As Integer = 0 To 2
            connect_objects(i) = New GelecekOPCDAConnector.gConnectionObject
        Next
        connect_objects(0).itemID = txtItem1.Text
        connect_objects(0).control = txtValue1
        connect_objects(0).property = "Text"

        connect_objects(1).itemID = txtItem2.Text
        connect_objects(1).control = txtValue2
        connect_objects(1).property = "Text"

        connect_objects(2).itemID = txtItem3.Text
        connect_objects(2).control = txtValue3
        connect_objects(2).property = "Text"

        '3. Define function result
        Dim function_result As GelecekOPCDAConnector.gFunctionResult

        '4. Call Connection method
        function_result = GOPCDAConnector1.gConnectItemsAndObjects(group_name, update_rate, connect_objects)
        'Or directly CALL method like below:
        'GOPCDAConnector1.gConnectItemsAndObjects(group_name, update_rate, connect_objects)

        '5. Check Result codes
        txtFunctionResult.Text = function_result.ToString

        txtResultID1.Text = connect_objects(0).resultID.ToString
        txtResultID2.Text = connect_objects(1).resultID.ToString
        txtResultID3.Text = connect_objects(2).resultID.ToString





        ' İf function result is "OK" and result ID is "S_OK" then this is a successful connection definition
        ' A connection is live until you kill it.



    End Sub







    Private Sub btnRemove1Item_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemove1Item.Click


        Dim itemID_to_remove As String = txtItem1.Text

        Dim function_result As GelecekOPCDAConnector.gFunctionResult
        function_result = GOPCDAConnector1.gRemoveOneItemAndObjectFromConnectionGroup("my_connect_group", itemID_to_remove, txtValue1)
        'Or directly CALL method like below:
        'GOPCDAConnector1.gRemoveOneItemFromMonitorGroup("my_connect_group", txtMonitoredItem1.Text)

    End Sub

    Private Sub btnRemove2Items_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemove2Items.Click

        'First create array of itemIDs to be removed
        Dim itemIDs_to_remove() As String = {txtItem2.Text, txtItem3.Text}

        'create array of objects to be removed
        Dim objects_to_remove() As Object = {txtValue2, txtValue3}

        Dim function_result As GelecekOPCDAConnector.gFunctionResult
        function_result = GOPCDAConnector1.gRemoveItemsAndObjectsFromConnectionGroup("my_connect_group", itemIDs_to_remove, objects_to_remove)
        'Or directly CALL method like below:
        'GOPCDAConnector1.gRemoveItemsFromMonitorGroup("my_connect_group", itemIDs_to_remove)


    End Sub


    Private Sub btnPause_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPause.Click
        Dim function_result As GelecekOPCDAConnector.gFunctionResult = GOPCDAConnector1.gPauseGroup("my_connect_group")
        'Or directly CALL method like below:
        'GOPCDAConnector1.gPauseGroup("my_connect_group")

    End Sub

    Private Sub btnResume_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnResume.Click
        Dim function_result As GelecekOPCDAConnector.gFunctionResult = GOPCDAConnector1.gResumeGroup("my_connect_group")
        'Or directly CALL method like below:
        'GOPCDAConnector1.gResumeGroup("my_connect_group")
    End Sub

    Private Sub btnKill_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKill.Click

        Dim function_result As GelecekOPCDAConnector.gFunctionResult = GOPCDAConnector1.gKillConnectionGroup("my_connect_group")
        'Or directly CALL method like below:
        'GOPCDAConnector1.gKillConnectionGroup("my_connect_group")
    End Sub


    Private Sub btnGetActiveState_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGetActiveState.Click
        Dim function_result As GelecekOPCDAConnector.gFunctionResult = GOPCDAConnector1.gGetActiveState("my_connect_group")
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
        function_result = GOPCDAConnector1.gSetGroupUpdateRate("my_connect_group", 1000)
        'Or directly CALL method like below:
        'GOPCDAConnector1.gSetGroupUpdateRate("my_connect_group", 1000)


    End Sub


    Private Sub btnSetUpdateRate5000_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSetUpdateRate5000.Click
        Dim function_result As GelecekOPCDAConnector.gFunctionResult
        function_result = GOPCDAConnector1.gSetGroupUpdateRate("my_connect_group", 5000)
        'Or directly CALL method like below:
        'GOPCDAConnector1.gSetGroupUpdateRate("my_connect_group", 5000)

    End Sub









    
    Private Sub btnClearValuesAndResuldIDs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClearValuesAndResuldIDs.Click
        txtValue1.Text = ""
        txtValue2.Text = ""
        txtValue3.Text = ""

        txtResultID1.Text = ""
        txtResultID2.Text = ""
        txtResultID3.Text = ""
    End Sub

    Private Sub txtFunctionResult_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFunctionResult.TextChanged

    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub
End Class
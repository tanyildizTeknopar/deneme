Public Class frmConnectSingle

    Private Sub btnConnectOneItemAndObject_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConnectOneItemAndObject.Click
        '1. Define group and update rate
        Dim group_name As String = "my_connect_group"
        Dim update_rate As Integer = 1000 ' milisecond

        '2. Define connectin object and set properties
        Dim connect_object As New GelecekOPCDAConnector.gConnectionObject
        connect_object.itemID = txtItem.Text
        connect_object.control = txtObject
        connect_object.property = "Text"

        '3. Define function result
        Dim function_result As GelecekOPCDAConnector.gFunctionResult

        '4. Call Connection method
        function_result = GOPCDAConnector1.gConnectOneItemAndObject(group_name, update_rate, connect_object)
        'Or directly CALL method like below:
        'GOPCDAConnector1.gConnectOneItemAndObject(group_name, update_rate, connect_object)

        '5. Check Result codes
        txtFunctionResult.Text = function_result.ToString

        txtResultID.Text = connect_object.resultID.ToString

        ' İf function result is "OK" and result ID is "S_OK" then this is a successful connection definition
        ' A connection is live until you kill it.

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

    
    Private Sub frmConnectSingle_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
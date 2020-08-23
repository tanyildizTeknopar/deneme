Public Class frmWrite

    Private Sub btnWriteSimplestWay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnWriteSimplestWay.Click
        '1. First create an OpcObject
        Dim opc_write_object As New GelecekOPCDAConnector.gOpcDaObject

        '2. Set ItemID to write
        opc_write_object.itemID = txtItemToBeWritten.Text

        '3. Set value
        opc_write_object.value = txtValue.Text


        '4. Call gWriteOneItem method
        GOPCDAConnector1.gWriteOneItem(opc_write_object)

        
    End Sub

    Private Sub btnWriteWithErrorCheck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnWriteWithErrorCheck.Click

        '1. First create an OpcObject
        Dim opc_write_object As New GelecekOPCDAConnector.gOpcDaObject

        '2. Set ItemID to be read
        opc_write_object.itemID = txtItemToBeWritten.Text

        '3. Set value
        opc_write_object.value = txtValue.Text


        '4. Create function result object
        Dim opc_write_function_result As GelecekOPCDAConnector.gFunctionResult

        '5. Call gWriteOneItem method
        opc_write_function_result = GOPCDAConnector1.gWriteOneItem(opc_write_object)

        '5. Get function result 
        txtFunctionResult.Text = opc_write_function_result.ToString

        '6 Check if Function result is "OK". IF "OK", check result ID
        If opc_write_function_result = GelecekOPCDAConnector.gFunctionResult.OK Then
            txtResultID.Text = opc_write_object.resultID.ToString

        End If


        'If Function result is "OK" and resultID is "S_OK" then this is a successful write.


    End Sub

    Private Sub btnWriteMultiSimplestWay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnWriteMultiSimplestWay.Click

        '1. First create  OpcObjects
        Dim opc_write_objects(2) As GelecekOPCDAConnector.gOpcDaObject
        For i As Integer = 0 To 2
            opc_write_objects(i) = New GelecekOPCDAConnector.gOpcDaObject
        Next


        '2. Set ItemIDs to write. Start with index 1
        opc_write_objects(0).itemID = txtItem1ToBeRead.Text
        opc_write_objects(1).itemID = txtItem2ToBeRead.Text
        opc_write_objects(2).itemID = txtItem3ToBeRead.Text

        '3. Set values
        opc_write_objects(0).value = txtValue1.Text
        opc_write_objects(1).value = txtValue2.Text
        opc_write_objects(2).value = txtValue3.Text

        '4. Call gReadOneItem method
        GOPCDAConnector1.gWriteItems(opc_write_objects)

    End Sub

    Private Sub btnWriteMultiWithErrorCheck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnWriteMultiWithErrorCheck.Click

        '1. First create  OpcObjects
        Dim opc_write_objects(2) As GelecekOPCDAConnector.gOpcDaObject
        For i As Integer = 0 To 2
            opc_write_objects(i) = New GelecekOPCDAConnector.gOpcDaObject
        Next


        '2. Set ItemIDs to write. 
        opc_write_objects(0).itemID = txtItem1ToBeRead.Text
        opc_write_objects(1).itemID = txtItem2ToBeRead.Text
        opc_write_objects(2).itemID = txtItem3ToBeRead.Text

        '3. Set values
        opc_write_objects(0).value = txtValue1.Text
        opc_write_objects(1).value = txtValue2.Text
        opc_write_objects(2).value = txtValue3.Text




        '4. Create function result object
        Dim opc_read_function_result As GelecekOPCDAConnector.gFunctionResult

        '5. Call gWriteItems method
        opc_read_function_result = GOPCDAConnector1.gWriteItems(opc_write_objects)

        '5. Get function result 
        txtMultiWriteFunctionResult.Text = opc_read_function_result.ToString

        '6 Check if Function result is "OK". IF "OK", get all values
        If opc_read_function_result = GelecekOPCDAConnector.gFunctionResult.OK Then
            txtResultID1.Text = opc_write_objects(0).resultID.ToString
            
            txtResultID2.Text = opc_write_objects(1).resultID.ToString
            
            txtResultID3.Text = opc_write_objects(2).resultID.ToString
           
        End If


       






    End Sub

    
End Class
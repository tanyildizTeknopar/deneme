Public Class frmAsynchronousWrite

    Dim cancel_id_for_async_write_multi As Integer



    Private Sub btnWriteWithErrorCheck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnWriteWithErrorCheck.Click
        '1. First define transaction ID
        Dim transaction_ID As Integer = 1 'transaction ID should be unique
        'transaction ID will be used in gAsynchReadOneItemCompleted event.

        '2. create an OpcObject
        Dim opc_write_object As New GelecekOPCDAConnector.gOpcDaObject

        '3. Set ItemID
        opc_write_object.itemID = txtItemToBeWritten.Text

        '4. Set value
        opc_write_object.value = txtValue.Text

        '5. Create function result object
        Dim opc_read_function_result As GelecekOPCDAConnector.gFunctionResult

        '6. Call gAsyncWriteOneItem method
        opc_read_function_result = GOPCDAConnector1.gAsyncWriteOneItem(opc_write_object, transaction_ID)

        '7. Get function result 
        txtFunctionResult.Text = opc_read_function_result.ToString

        'Value of item will come with gAsynchReadOneItemCompleted event.

    End Sub






    Private Sub btnWriteSimplestWay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnWriteSimplestWay.Click
       
        '1. create an OpcObject
        Dim opc_write_object As New GelecekOPCDAConnector.gOpcDaObject

        '2. Set ItemID
        opc_write_object.itemID = txtItemToBeWritten.Text

        '3. Set value
        opc_write_object.value = txtValue.Text

       
        '4. Call gAsyncWriteOneItem method
        GOPCDAConnector1.gAsyncWriteOneItem(opc_write_object, 1)

      
        'Value of item will come with gAsynchReadOneItemCompleted event.

    End Sub

  
   

    Private Sub GOPCDAConnector1_gAsyncWriteOneItemCompleted(ByVal sender As Object, ByVal gtransactionID As Object, ByVal gresultObject As GelecekOPCDAConnector.gOpcDaObject) Handles GOPCDAConnector1.gAsyncWriteOneItemCompleted
        'We will get value information if transaction ID is 1
        If gtransactionID = 1 Then ' Because our AsyncWrite requests transactionID is 1

            txtResultID.Text = gresultObject.resultID.ToString

            'if resultID is "S_OK" then this is a successful write

        End If

    End Sub

    
    Private Sub btnWriteMultiWithErrorCheck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnWriteMultiWithErrorCheck.Click

        '1. First define transaction ID
        Dim transaction_ID As Integer = 2 'transaction ID should be unique
        'transaction ID will be used in gAsynchReadOneItemCompleted event.


        '2. First create  OpcObjects
        Dim opc_write_objects(2) As GelecekOPCDAConnector.gOpcDaObject
        For i As Integer = 0 To 2
            opc_write_objects(i) = New GelecekOPCDAConnector.gOpcDaObject
        Next


        '3. Set ItemIDs to write. 
        opc_write_objects(0).itemID = txtItem1ToBeRead.Text
        opc_write_objects(1).itemID = txtItem2ToBeRead.Text
        opc_write_objects(2).itemID = txtItem3ToBeRead.Text

        '4. Set values
        opc_write_objects(0).value = txtValue1.Text
        opc_write_objects(1).value = txtValue2.Text
        opc_write_objects(2).value = txtValue3.Text

        '5. Create function result object
        Dim opc_read_function_result As GelecekOPCDAConnector.gFunctionResult

        '6. Call gAsyncWriteItems method
        opc_read_function_result = GOPCDAConnector1.gAsyncWriteItems(opc_write_objects, transaction_ID, cancel_id_for_async_write_multi)

        '7. Get function result 
        txtMultiWriteFunctionResult.Text = opc_read_function_result.ToString

        ''8 Check if Function result is "OK". IF "OK", get all values
        'If opc_read_function_result = GelecekOPCDAConnector.gFunctionResult.OK Then
        '    txtResultID1.Text = opc_write_objects(0).resultID.ToString

        '    txtResultID2.Text = opc_write_objects(1).resultID.ToString

        '    txtResultID3.Text = opc_write_objects(2).resultID.ToString

        'End If


    End Sub

    Private Sub btnWriteMultiSimplestWay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnWriteMultiSimplestWay.Click


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

        '4. Call gAsyncWriteItems method
        GOPCDAConnector1.gAsyncWriteItems(opc_write_objects, 2, cancel_id_for_async_write_multi)

    End Sub

    Private Sub GOPCDAConnector1_gAsyncWriteItemsCompleted(ByVal sender As Object, ByVal gtransactionID As Object, ByVal gresultObjects() As GelecekOPCDAConnector.gOpcDaObject) Handles GOPCDAConnector1.gAsyncWriteItemsCompleted

        'We will get value information if transaction ID is 2
        If gtransactionID = 2 Then ' Because our AsyncWrite requests transactionID is 2

            'if resultID is "S_OK" then this is a successful write

            Dim number_of_items As Integer = gresultObjects.Length

            For i As Integer = 0 To number_of_items - 1
                If gresultObjects(i).itemID = txtItem1ToBeRead.Text Then
                    txtResultID1.Text = gresultObjects(i).resultID.ToString
                End If

                If gresultObjects(i).itemID = txtItem2ToBeRead.Text Then
                    txtResultID2.Text = gresultObjects(i).resultID.ToString
                End If

                If gresultObjects(i).itemID = txtItem3ToBeRead.Text Then
                    txtResultID3.Text = gresultObjects(i).resultID.ToString
                End If
            Next
        End If


    End Sub







   

    Private Sub btnCancelAsyncWrite_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelAsyncWrite.Click
        '1. Create function result object
        Dim opc_read_function_result As GelecekOPCDAConnector.gFunctionResult

        '2. Call gCancelAsyncReadWrite method
        opc_read_function_result = GOPCDAConnector1.gCancelAsyncReadWrite(cancel_id_for_async_write_multi)
        'This Cancel Method should be called before async read-write completes,
        'Otherwise function result will be "INVALID_CANCEL_ID"

        txtCancelResult.Text = opc_read_function_result.ToString






    End Sub
End Class
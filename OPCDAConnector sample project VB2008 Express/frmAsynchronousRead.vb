Public Class frmAsynchronousRead

    Dim cancel_id_for_async_read_multi As Integer



    Private Sub btnReadWithErrorCheck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReadWithErrorCheck.Click

        '1. First define itemID and transaction ID
        Dim item_ID As String = txtItemToBeRead.Text
        Dim transaction_ID As Integer = 1 'transaction ID should be unique
        'transaction ID will be used in gAsynchReadOneItemCompleted event.

        '2. Create function result object
        Dim opc_read_function_result As GelecekOPCDAConnector.gFunctionResult

        '3. Call gAsyncReadOneItem method
        opc_read_function_result = GOPCDAConnector1.gAsyncReadOneItem(item_ID, transaction_ID)

        '5. Get function result 
        txtFunctionResult.Text = opc_read_function_result.ToString

        'Value of item will come with gAsynchReadOneItemCompleted event.

    End Sub

   

    Private Sub GOPCDAConnector1_gAsyncReadOneItemCompleted(ByVal sender As Object, ByVal gtransactionID As Object, ByVal gresultObject As GelecekOPCDAConnector.gOpcDaObject) Handles GOPCDAConnector1.gAsyncReadOneItemCompleted
        'We will get value information if transaction ID is 1
        If gtransactionID = 1 Then ' Because our AsyncRead requests transactionID is 1

            txtResultID.Text = gresultObject.resultID.ToString
            txtQuality.Text = gresultObject.quality.ToString

            'if resultID and Quality good, get value
            If gresultObject.resultID.ToString = "S_OK" And gresultObject.quality.ToString = "good" Then
                txtValue.Text = gresultObject.value
            End If
        End If

    End Sub


    Private Sub btnReadSimplestWay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReadSimplestWay.Click

        GOPCDAConnector1.gAsyncReadOneItem(txtItemToBeRead.Text, 1)

    End Sub

   


    
    Private Sub btnReadMultiWithErrorCheck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReadMultiWithErrorCheck.Click

        '1. First define transaction ID and cancel ID
        Dim transaction_ID As Integer = 2 'transaction ID should be unique
        'transaction ID will be used in gAsynchReadOneItemCompleted event.

        'If you want to cancel a Asynchronous Read- Write "cancel_id_for_async_read_multi" will be used.

        '2. Define array of Item_IDs
        Dim item_IDs() As String = {txtItem1ToBeRead.Text, txtItem2ToBeRead.Text, txtItem3ToBeRead.Text}


        '3. Create function result object
        Dim opc_read_function_result As GelecekOPCDAConnector.gFunctionResult

        '4. Call gAsyncReadItems method
        opc_read_function_result = GOPCDAConnector1.gAsyncReadItems(item_IDs, transaction_ID, cancel_id_for_async_read_multi)
        'When this method runs, "cancel_id_for_async_read_multi" gets a value

        '5. Get function result and cancel ID
        txtMultiReadFunctionResult.Text = opc_read_function_result.ToString
        txtCancelID.Text = cancel_id_for_async_read_multi

        'Values of items will come with gAsynchReadItemsCompleted event.



    End Sub

    Private Sub btnReadMultiSimplestWay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReadMultiSimplestWay.Click
        '1. Define array of Item_IDs
        Dim item_IDs() As String = {txtItem1ToBeRead.Text, txtItem2ToBeRead.Text, txtItem3ToBeRead.Text}
        '2. Call gAsyncReadItems method
        GOPCDAConnector1.gAsyncReadItems(item_IDs, 2, cancel_id_for_async_read_multi)




    End Sub




    Private Sub GOPCDAConnector1_gAsyncReadItemsCompleted(ByVal sender As Object, ByVal gtransactionID As Object, ByVal gresultObjects() As GelecekOPCDAConnector.gOpcDaObject) Handles GOPCDAConnector1.gAsyncReadItemsCompleted

        'We will get value information if transaction ID is 1
        If gtransactionID = 2 Then ' Because our AsyncReadMulti requests transactionID is 2

            Dim number_of_items As Integer = gresultObjects.Length

            For i As Integer = 0 To number_of_items - 1
                If gresultObjects(i).itemID = txtItem1ToBeRead.Text Then
                    txtValue1.Text = gresultObjects(i).value
                    txtResultID1.Text = gresultObjects(i).resultID.ToString
                    txtQuality1.Text = gresultObjects(i).quality.ToString
                End If

                If gresultObjects(i).itemID = txtItem2ToBeRead.Text Then
                    txtValue2.Text = gresultObjects(i).value
                    txtResultID2.Text = gresultObjects(i).resultID.ToString
                    txtQuality2.Text = gresultObjects(i).quality.ToString

                End If

                If gresultObjects(i).itemID = txtItem3ToBeRead.Text Then
                    txtValue3.Text = gresultObjects(i).value
                    txtResultID3.Text = gresultObjects(i).resultID.ToString
                    txtQuality3.Text = gresultObjects(i).quality.ToString

                End If
            Next

        End If

    End Sub







   
   
    Private Sub btnCancelAsyncRead_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelAsyncRead.Click
        '1. Create function result object
        Dim opc_read_function_result As GelecekOPCDAConnector.gFunctionResult

        '2. Call gCancelAsyncReadWrite method
        opc_read_function_result = GOPCDAConnector1.gCancelAsyncReadWrite(cancel_id_for_async_read_multi)
        'This Cancel Method should be called before async read-write completes,
        'Otherwise function result will be "INVALID_CANCEL_ID"

        txtCancelResult.Text = opc_read_function_result.ToString


    End Sub

    Private Sub frmAsynchronousRead_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
Imports Opc

Public Class frmRead

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub btnReadWithErrorCheck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReadWithErrorCheck.Click
        '1. First create an OpcObject
        Dim opc_read_object As New GelecekOPCDAConnector.gOpcDaObject

        '2. Set ItemID to be read
        opc_read_object.itemID = txtItemToBeRead.Text

        '3. Create function result object
        Dim opc_read_function_result As GelecekOPCDAConnector.gFunctionResult

        '4. Call gReadOneItem method
        opc_read_function_result = GOPCDAConnector1.gReadOneItem(opc_read_object)

        '5. Get function result 
        txtFunctionResult.Text = opc_read_function_result.ToString

        '6 Check if Function result is "OK". IF "OK", get all values
        If opc_read_function_result = GelecekOPCDAConnector.gFunctionResult.OK Then
            txtResultID.Text = opc_read_object.resultID.ToString
            txtQuality.Text = opc_read_object.quality.ToString

            'if resultID and Quality good, get value
            If opc_read_object.resultID.ToString = "S_OK" And opc_read_object.quality.ToString = "good" Then
                txtValue.Text = opc_read_object.value

            End If


        End If



    End Sub

    Private Sub btnReadSimplestWay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReadSimplestWay.Click
        '1. First create an OpcObject
        Dim opc_read_object As New GelecekOPCDAConnector.gOpcDaObject

        '2. Set ItemID to be read
        opc_read_object.itemID = txtItemToBeRead.Text

        '3. Call gReadOneItem method
        GOPCDAConnector1.gReadOneItem(opc_read_object)

        '4. Get value
        txtValue.Text = opc_read_object.value


    End Sub

    Private Sub btnReadMultiSimplestWay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReadMultiSimplestWay.Click
        '1. First create  OpcObjects
        Dim opc_read_objects(2) As GelecekOPCDAConnector.gOpcDaObject
        For i As Integer = 0 To 2
            opc_read_objects(i) = New GelecekOPCDAConnector.gOpcDaObject
        Next


        '2. Set ItemIDs to be read. Start with index 1
        opc_read_objects(0).itemID = txtItem1ToBeRead.Text
        opc_read_objects(1).itemID = txtItem2ToBeRead.Text
        opc_read_objects(2).itemID = txtItem3ToBeRead.Text


        '3. Call gReadOneItem method
        GOPCDAConnector1.gReadItems(opc_read_objects)

        '4. Get values
        txtValue1.Text = opc_read_objects(0).value
        txtValue2.Text = opc_read_objects(1).value
        txtValue3.Text = opc_read_objects(2).value





    End Sub

    Private Sub btnReadMultiWithErrorCheck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReadMultiWithErrorCheck.Click
        '1. First create  OpcObjects
        Dim opc_read_objects(2) As GelecekOPCDAConnector.gOpcDaObject
        For i As Integer = 0 To 2
            opc_read_objects(i) = New GelecekOPCDAConnector.gOpcDaObject
        Next


        '2. Set ItemIDs to be read. Start with index 1
        opc_read_objects(0).itemID = txtItem1ToBeRead.Text
        opc_read_objects(1).itemID = txtItem2ToBeRead.Text
        opc_read_objects(2).itemID = txtItem3ToBeRead.Text

        '3. Create function result object
        Dim opc_read_function_result As GelecekOPCDAConnector.gFunctionResult

        '4. Call gReadItems method
        opc_read_function_result = GOPCDAConnector1.gReadItems(opc_read_objects)

        '5. Get function result 
        txtMultiReadFunctionResult.Text = opc_read_function_result.ToString

        '6 Check if Function result is "OK". IF "OK", get all values
        If opc_read_function_result = GelecekOPCDAConnector.gFunctionResult.OK Then
            txtResultID1.Text = opc_read_objects(0).resultID.ToString
            txtQuality1.Text = opc_read_objects(0).quality.ToString

            txtResultID2.Text = opc_read_objects(1).resultID.ToString
            txtQuality2.Text = opc_read_objects(1).quality.ToString

            txtResultID3.Text = opc_read_objects(2).resultID.ToString
            txtQuality3.Text = opc_read_objects(2).quality.ToString



            'if resultID and Quality good, get value


            If opc_read_objects(0).resultID.ToString = "S_OK" And opc_read_objects(0).quality.ToString = "good" Then
                txtValue1.Text = opc_read_objects(0).value
            End If

            If opc_read_objects(1).resultID.ToString = "S_OK" And opc_read_objects(1).quality.ToString = "good" Then
                txtValue2.Text = opc_read_objects(1).value
            End If

            If opc_read_objects(2).resultID.ToString = "S_OK" And opc_read_objects(2).quality.ToString = "good" Then
                txtValue3.Text = opc_read_objects(2).value
            End If



        End If



    End Sub

    Private Sub frmRead_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
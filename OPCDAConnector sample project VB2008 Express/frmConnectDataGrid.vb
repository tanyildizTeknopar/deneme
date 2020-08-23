Public Class frmConnectDataGrid

    Private Sub frmConnectDataGrid_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'add rows to datagrid
        DataGridView1.Rows.Add(3)

        'set item IDs to view on data grid
        DataGridView1.Rows(0).Cells("colItemIDs").Value = "Dynamic/Analog Types/Int"
        DataGridView1.Rows(1).Cells("colItemIDs").Value = "Dynamic/Analog Types/Double"
        DataGridView1.Rows(2).Cells("colItemIDs").Value = "Dynamic/Enumerated Types/Gems"




    End Sub

    Private Sub btnConnectItems_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConnectItems.Click
        '1. Define group and update rate
        Dim group_name As String = "my_connect_group"
        Dim update_rate As Integer = 1000 ' milisecond


        '2. Define connection object and set properties
        Dim connect_objects(2) As GelecekOPCDAConnector.gConnectionObject
        For i As Integer = 0 To 2
            connect_objects(i) = New GelecekOPCDAConnector.gConnectionObject
        Next
        connect_objects(0).itemID = DataGridView1.Rows(0).Cells("colItemIDs").Value.ToString
        connect_objects(0).control = DataGridView1.Rows(0).Cells("colValues")
        connect_objects(0).property = "Value"

        connect_objects(1).itemID = DataGridView1.Rows(1).Cells("colItemIDs").Value.ToString
        connect_objects(1).control = DataGridView1.Rows(1).Cells("colValues")
        connect_objects(1).property = "Value"

        connect_objects(2).itemID = DataGridView1.Rows(2).Cells("colItemIDs").Value.ToString
        connect_objects(2).control = DataGridView1.Rows(2).Cells("colValues")
        connect_objects(2).property = "Value"

        '3. Define function result
        Dim function_result As GelecekOPCDAConnector.gFunctionResult

        '4. Call Connection method
        function_result = GOPCDAConnector1.gConnectItemsAndObjects(group_name, update_rate, connect_objects)
        'Or directly CALL method like below:
        'GOPCDAConnector1.gConnectItemsAndObjects(group_name, update_rate, connect_objects)

        '5. Check Result codes
        txtFunctionResult.Text = function_result.ToString

        'txtResultID1.Text = connect_objects(0).resultID.ToString
        'txtResultID2.Text = connect_objects(1).resultID.ToString
        'txtResultID3.Text = connect_objects(2).resultID.ToString



    End Sub
End Class
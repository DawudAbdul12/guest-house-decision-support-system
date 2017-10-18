Imports System.Data.OleDb
Public Class expenses_frm
#Region "Variable"
    Dim id As Integer
#End Region

#Region "CLLOSE BUTTON"
    Private Sub bttnCancel_Click(sender As Object, e As EventArgs) Handles bttnCancel.Click
        Me.Close()
    End Sub
#End Region

#Region "SAVE AND UPDATE RECORD"
    Private Sub bttnSave_Click(sender As Object, e As EventArgs) Handles bttnSave.Click

        Dim errors As String

        If Cmb_type.Text = "" Then
            errors = "Please Select Expense Type"
        ElseIf txt_amount.Text = "" Then
            errors = "Please Enter Amount"
        End If

        If bttnSave.Text = "&Save" Then

            If errors = "" Then
                ' SQL COMMAND FOR INSERTING VALUES 
                Dim objCommand As OleDbCommand = New OleDbCommand()
                objCommand.Connection = con

                objCommand.CommandText = " INSERT INTO expenses_tb(type,amount,receipt_desc,description,entry_date)" & _
                 "VALUES(@type,@amount,@receipt_desc,@description,@entry_date)"

                ' CONTROLS BINDING
                objCommand.Parameters.AddWithValue("@type", Trim(Cmb_type.Text))
                objCommand.Parameters.AddWithValue("@amount", Decimal.Parse(txt_amount.Text))
                objCommand.Parameters.AddWithValue("@receipt_desc", Trim(txt_receipt.Text))
                objCommand.Parameters.AddWithValue("@description", txt_desc.Text)
                objCommand.Parameters.AddWithValue("@entry_date", Today)

                'OPEN CONNECTION
                con.Open()
                'EXECUTE CONNECTION
                objCommand.ExecuteNonQuery()

                'CLOSE CONNECTION 
                con.Close()

                'RESET THE FORM
                Call reset()

                ' REFRESH RECORDS
                Call display_room()

                'SUCCESS MESSAGE
                MsgBox("Saved Successfully!", vbExclamation, "Expense")

            Else
                ' ERROR MESSAGE
                MsgBox(errors, vbExclamation, "Expense")
            End If

        ElseIf bttnSave.Text = "&Update" Then
            ''''''' UPDATE RECORDS -----
            If errors = "" Then
                ' SQL COMMAND FOR INSERTING VALUES 
                Dim objCommand As OleDbCommand = New OleDbCommand()
                objCommand.Connection = con

                objCommand.CommandText = " UPDATE expenses_tb SET type = @type, amount = @amount, receipt_desc = @receipt_desc, description = @description WHERE id = @id"

                ' CONTROLS BINDING
                objCommand.Parameters.AddWithValue("@type", Trim(Cmb_type.Text))
                objCommand.Parameters.AddWithValue("@amount", Decimal.Parse(txt_amount.Text))
                objCommand.Parameters.AddWithValue("@receipt_desc", Trim(txt_receipt.Text))
                objCommand.Parameters.AddWithValue("@description", txt_desc.Text)
                objCommand.Parameters.AddWithValue("@id", id)

                'OPEN CONNECTION
                con.Open()
                'EXECUTE CONNECTION
                objCommand.ExecuteNonQuery()

                'CLOSE CONNECTION 
                con.Close()

                'RESET THE FORM
                Call reset()

                'SUCCESS MESSAGE
                MsgBox("Update Successfully!", vbExclamation, "Expense")

                ' REFRESH RECORDS
                Call display_room()
                'SET THE BUTTON BACK TO SAVE
                bttnSave.Text = "&Save"
                ' destroy id
                id = vbEmpty
            Else
                ' ERROR MESSAGE
                MsgBox(errors, vbExclamation, "Expense")
            End If
            '------------ END OF UPDATE RECORD -------------
        End If
    End Sub
#End Region

#Region "Reset"
    Private Sub reset()

        Cmb_type.SelectedIndex = -1
        txt_amount.Text = 0.0
        txt_receipt.Text = ""
        txt_desc.Text = ""
        Cmb_type.Select()
    End Sub
#End Region

#Region "ONLOAD"
    Private Sub expenses_frm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'INITIATE THE FORM
        Call reset()

        'DEFAULT GRID DATA
        Call display_room()
    End Sub
#End Region

#Region "VALIDATION FOR ONLY NUMBERS"

    Private Sub txtAmount_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_amount.KeyPress

        e.Handled = onlyCurrency(e.KeyChar, CType(sender, TextBox).Text)
     
    End Sub
    
    ' FUNCTION FOR NUMERIC AND DECIMAL VALUES ONLY
    Public Shared Function onlyCurrency(ByVal KeyChar As Char, CurrentText As String) As Boolean
        Dim allowedChars As String
        allowedChars = "0123456789.,"
        Dim singleChars As String
        singleChars = "."
        If KeyChar = singleChars Then
            If CurrentText.Contains(singleChars) Then
                Return True
            End If
        End If
        If allowedChars.IndexOf(KeyChar) = -1 And (Asc(KeyChar)) <> 8 Then
            Return True
        End If
        Return False
    End Function

#End Region

#Region "GRID DATA"
    Private Sub display_room()
        con.Open()
        Dim Dt As New DataTable("expenses_tb")
        Dim rs As OleDbDataAdapter

        rs = New OleDbDataAdapter("Select * from expenses_tb order by id desc", con)

        rs.Fill(Dt)
        Dim indx As Integer
        lvExp.Items.Clear()
        For indx = 0 To Dt.Rows.Count - 1
            Dim lv As New ListViewItem
            lv.Text = Dt.Rows(indx).Item("ID")
            lv.SubItems.Add(Dt.Rows(indx).Item("entry_date"))
            lv.SubItems.Add(Dt.Rows(indx).Item("type"))
            lv.SubItems.Add(Dt.Rows(indx).Item("amount"))
            lv.SubItems.Add(Dt.Rows(indx).Item("receipt_desc"))
            lv.SubItems.Add(Dt.Rows(indx).Item("Description"))
            lvExp.Items.Add(lv)
        Next
        rs.Dispose()
        con.Close()
    End Sub
#End Region


#Region "DOUBLE CLICK ON GRID"
    Private Sub lvRoom_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvExp.DoubleClick
        Dim a As String = MsgBox("Update selected Item?", vbQuestion + vbYesNo, "Update Room")
        If a = vbYes Then
            id = lvExp.SelectedItems(0).Text
            ' Cmb_type.Text = lvExp.SelectedItems(0).SubItems(1).Text
            Cmb_type.Text = lvExp.SelectedItems(0).SubItems(2).Text
            txt_amount.Text = lvExp.SelectedItems(0).SubItems(3).Text
            txt_receipt.Text = lvExp.SelectedItems(0).SubItems(4).Text
            txt_desc.Text = lvExp.SelectedItems(0).SubItems(5).Text

            TabControl1.SelectTab(0)
            bttnSave.Text = "&Update"
        End If
    End Sub
#End Region

   
End Class
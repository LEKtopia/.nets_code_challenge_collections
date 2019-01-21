Option Explicit On
Option Strict On

Public Class Form1
    Dim nameEntered As String

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        ' Prevent Duplicates in the listBox
        If Not lstNameList.Items.Contains(txtNameEntered.Text) Then
            lstNameList.Items.Add(txtNameEntered.Text)
        Else
            MessageBox.Show("This philosopher is already listed.  Try again.")
        End If

        ' Automatically clear the textBox
        txtNameEntered.Clear()

        ' Reset focus
        txtNameEntered.Focus()
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        ' Remove the selected name.
        lstNameList.Items.Remove(lstNameList.SelectedItem)
    End Sub

    Private Sub btnClearList_Click(sender As Object, e As EventArgs) Handles btnClearList.Click
        ' Clear the list.
        lstNameList.Items.Clear()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' Close the form.
        Me.Close()
    End Sub

End Class

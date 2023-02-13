Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Tab

Public Class Form1
    ' Quando o utilizador clicar no botão 'Adicionar', esta subrotina é chamada
    Private Sub btnAdicionar_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        cbxList.Items.Add(txtItem.Text) ' adiciona à combobox o texto presente na texbox
        txtNItens.Text = cbxList.Items.Count ' visualiza na texbox o n ̇mero de linhas/itens presentes na ComboBox
    End Sub
    ' Quando o utilizador clicar no botao Remover esta subrotina é chamada
    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        cbxList.Items.Remove(txtItem.Text) 'remove da combobox o item/linha/texto presente na textbox
        txtNItens.Text = cbxList.Items.Count
    End Sub
    ' Quando o utilizador selecionar na combobox uma nova linha esta subrotina é chamada
    Private Sub cbxList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxList.SelectedIndexChanged
        txtSelected.Text = cbxList.SelectedItem 'Visualiza a linha/item selecionado pelo utilizador
    End Sub
    'Esta subrotina é chamada quando o utilizador selecionar o botao Sair
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        End 'Esta instrução termina a execução do programa
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub
End Class

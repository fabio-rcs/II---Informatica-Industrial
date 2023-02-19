Imports System.Reflection.Emit
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Tab

Public Class Form1

    ' Quando o utilizador clicar no botão 'Adicionar', esta subrotina é chamada
    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        cbx_list.Items.Add(txtbx_item.Text) ' adiciona à combobox o texto presente na texbox
        txtbx_nitems.Text = cbx_list.Items.Count ' visualiza na texbox o número de linhas/itens presentes na ComboBox
    End Sub

    ' Quando o utilizador clicar no botao Remover esta subrotina é chamada
    Private Sub BtnRemove_Click(sender As Object, e As EventArgs) Handles btn_remove.Click
        cbx_list.Items.Remove(txtbx_item.Text) 'remove da combobox o item/linha/texto presente na textbox
        txtbx_nitems.Text = cbx_list.Items.Count
    End Sub

    ' Quando o utilizador selecionar na combobox uma nova linha esta subrotina é chamada
    Private Sub CbxList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_list.SelectedIndexChanged
        txtbx_selected.Text = cbx_list.SelectedItem 'Visualiza a linha/item selecionado pelo utilizador
    End Sub

    'Esta subrotina é chamada quando o utilizador selecionar o botao Sair
    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        End 'Esta instrução termina a execução do programa
    End Sub

    'This function is executed at the start of the app
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Window properties
        Text = "String List" 'The word 'Calculadora' appears in the top of the window
        BackgroundImage = Image.FromFile("..\..\..\..\..\..\docs\ua-top-1.jpg") 'Background image of the window
        Height = 500 'Window size in screen
        Width = 700
        Icon = New Icon("..\..\..\..\..\..\docs\ua-favicon.ico") 'Icon of the window in the top left
        label_item.Text = "Item (TextBox)"
        label_cbx.Text = "Combo Box"
        label_nitems.Text = "Number of items in list"
        label_selected.Text = "Selected Item"
        btn_add.Text = "Add to list"
        btn_remove.Width = 150
        btn_remove.Text = "Remove of list"
        btn_close.Text = "Exit"
    End Sub
End Class
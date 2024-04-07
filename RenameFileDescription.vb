Imports System.Windows.Forms

Public Class RenameFileDescription

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        If TextBox1.Text <> "" Then
            Select Case Game
                Case 0
                    BKmodelini.WriteString("models", NoExt(CurrModel), TextBox1.Text)
                Case 1
                    BTmodelini.WriteString("models", NoExt(CurrModel), TextBox1.Text)
            End Select
            If Main.TreeView1.SelectedNodes.Count > 0 Then
                If Main.TreeView1.SelectedNodes(0).Text = Main.FileTree.SelectedNodes(0).Text Then
                    Main.TreeView1.SelectedNodes(0).Text = TextBox1.Text
                End If
            End If
            Main.FileTree.SelectedNodes(0).Text = TextBox1.Text
        Else
            Select Case Game
                Case 0
                    BKmodelini.WriteString("models", NoExt(CurrModel), CurrModel)
                Case 1
                    BTmodelini.WriteString("models", NoExt(CurrModel), CurrModel)
            End Select
            If Main.TreeView1.SelectedNodes.Count > 0 Then
                If Main.TreeView1.SelectedNodes(0).Text = Main.FileTree.SelectedNodes(0).Text Then
                    Main.TreeView1.SelectedNodes(0).Text = CurrModel
                End If
            End If
            Main.FileTree.SelectedNodes(0).Text = CurrModel
            End If
            Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.Close()
    End Sub

    Private Sub RenameFileDescription_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Select Case game
            Case 0
                TextBox1.Text = BKmodelini.GetString("models", NoExt(CurrModel), Nothing)
            Case 1
                TextBox1.Text = BTmodelini.GetString("models", NoExt(CurrModel), Nothing)
        End Select
    End Sub
End Class

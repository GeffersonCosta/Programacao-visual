Public Class Form1
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Num1.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Num2.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Num3.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BtnSair.Click
        End
    End Sub

    Private Sub BtnJogar_Click(sender As Object, e As EventArgs) Handles BtnJogar.Click
        imgResultado.Visible = False
        Randomize()
        Num1.Text = CStr(Int(Rnd() * 10))
        Num2.Text = CStr(Int(Rnd() * 10))
        Num3.Text = CStr(Int(Rnd() * 10))
        'Se todos os números forem iguais a 7'
        If (Num1.Text = "7") And (Num2.Text = "7") And (Num3.Text = "7") Then
            imgResultado.Image = Image.FromFile("E:\Faculdade\21_programacao_visual\aula2-desenvolvimento-de-aplicacoes-windows-com-uso-de-conceitos-visuais\aula-pratica\jogo-7-da-sorte\JogoSetedaSorteSln\ganhoumax.jpg")
            imgResultado.Visible = True
            Beep()
        ElseIf (Num1.Text = "7") Or (Num2.Text = "7") Or (Num3.Text = "7") Then
            imgResultado.Image = Image.FromFile("E:\Faculdade\21_programacao_visual\aula2-desenvolvimento-de-aplicacoes-windows-com-uso-de-conceitos-visuais\aula-pratica\jogo-7-da-sorte\JogoSetedaSorteSln\ganhou.png")
            imgResultado.Visible = True
            Beep()
        Else
            imgResultado.Image = Image.FromFile("E:\Faculdade\21_programacao_visual\aula2-desenvolvimento-de-aplicacoes-windows-com-uso-de-conceitos-visuais\aula-pratica\jogo-7-da-sorte\JogoSetedaSorteSln\perdeu.jpg")
            imgResultado.Visible = True
            Beep()
        End If
    End Sub
End Class

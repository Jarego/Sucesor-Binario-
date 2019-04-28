Public Class Form1
    Dim res As String
    Dim cont = 0
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text = TextBox1.Text + " "
        S1()

    End Sub
    Sub S1()
        If TextBox1.Text(cont) = "1" Then
            res += "1"
            cont += 1
            Label1.Text = res
            PictureBox1.Image = ImageList1.Images(1)
            MsgBox("Encuentra 1, se mantiene igual, se mueve a la dercha")
            S1()

        ElseIf TextBox1.Text(cont) = "0" Then
            res += "0"
            cont += 1
            Label1.Text = res
            PictureBox1.Image = ImageList1.Images(1)
            MsgBox("Encuentra 0, se mantiene igual, se mueve a la dercha")
            S1()
        ElseIf TextBox1.Text(cont) = " " Then
            res += " "
            cont -= 1
            Label1.Text = res
            PictureBox1.Image = ImageList1.Images(2)
            MsgBox("Encuentra b, se mantiene igual, se mueve a la izquierda")
            S2()
        End If
    End Sub
    Sub S2()
        If TextBox1.Text(cont) = "1" Then
            res = res.Remove(cont, 1).Insert(cont, "0")
            cont -= 1
            Label1.Text = res
            PictureBox1.Image = ImageList1.Images(2)
            MsgBox("Encuentra 1, se cambia a 0, se mueve a la izquierda")
            S2()
        ElseIf TextBox1.Text(cont) = "0" Then
            res = res.Remove(cont, 1).Insert(cont, "1")
            cont -= 1
            Label1.Text = res
            PictureBox1.Image = ImageList1.Images(3)
            MsgBox("Encuentra 0, se cambia a 1, se mueve a la izquierda")
            S3()
        ElseIf TextBox1.Text(cont) = " " Then
            res = res.Remove(cont, 1).Insert(cont, "1")
            PictureBox1.Image = ImageList1.Images(1)
            Label1.Text = res
            cont = 0
            PictureBox1.Image = ImageList1.Images(4)
            MsgBox("Estado final")
            PictureBox1.Image = ImageList1.Images(0)
        End If
    End Sub

    Sub S3()
        If cont >= 0 Then
            If TextBox1.Text(cont) = "0" Then
                res = res.Remove(cont, 1).Insert(cont, "0")

                cont -= 1
                Label1.Text = res
                PictureBox1.Image = ImageList1.Images(3)
                MsgBox("Encuentra 0, se mantiene igual, se mueve a la izquierda")
                S3()
            ElseIf TextBox1.Text(cont) = "1" Then
                res = res.Remove(cont, 1).Insert(cont, "1")
                cont -= 1
                Label1.Text = res
                PictureBox1.Image = ImageList1.Images(3)
                MsgBox("Encuentra 1, se mantiene igual, se mueve a la izquierda")
                S3()
            ElseIf TextBox1.Text(cont) = "" Then
                Label1.Text = res
                cont = 0

                MsgBox("Estado final")
            End If
        Else
            Label1.Text = res
            cont = 0
            PictureBox1.Image = ImageList1.Images(4)
            MsgBox("Estado final")
        End If
    End Sub

End Class

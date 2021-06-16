Imports Mono.Cecil

Public Class Form1
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim myAssembly As AssemblyDefinition = AssemblyDefinition.ReadAssembly(TextBox1.Text)
            Dim rcaTemp As New EmbeddedResource(TextBox4.Text, ManifestResourceAttributes.Public, IO.File.ReadAllBytes(TextBox2.Text))
            myAssembly.MainModule.Resources.Add(rcaTemp)
            myAssembly.Write(TextBox3.Text)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub
End Class

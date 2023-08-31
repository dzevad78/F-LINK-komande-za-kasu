Public Class DuplDnevnog

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click


        'kreiranje fajla

        Dim file As System.IO.FileStream
        file = System.IO.File.Create("c:\PP\duplikatdnevnog.inp")

        file.Close()

        'upisivanje komande za otvaranje ladice u fajl

        Dim FILE_NAME As String = "c:\PP\duplikatdnevnog.inp"

        If System.IO.File.Exists(FILE_NAME) = True Then

            Dim objWriter As New System.IO.StreamWriter(FILE_NAME)

            objWriter.Write("D,1,______,_,__;1;4;" & TextBox1.Text & ";")
            objWriter.Close()

        End If

        'premjestanje fajla iz direktorija u direktorij 

        My.Computer.FileSystem.MoveFile("C:\PP\duplikatdnevnog.inp", "C:\Temp\duplikatdnevnog.inp")

        Me.Close()

    End Sub
End Class
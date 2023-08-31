Public Class periodični

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'kreiranje fajla

        Dim file As System.IO.FileStream
        file = System.IO.File.Create("c:\PP\periodicni.inp")

        file.Close()

        'upisivanje komande za otvaranje ladice u fajl

        Dim FILE_NAME As String = "c:\PP\periodicni.inp"

        If System.IO.File.Exists(FILE_NAME) = True Then

            Dim objWriter As New System.IO.StreamWriter(FILE_NAME)

            objWriter.Write("R,1,______,_,__;5;" & TextBox1.Text & TextBox2.Text & TextBox3.Text & ";" & TextBox4.Text & TextBox5.Text & TextBox6.Text)
            objWriter.Close()

        End If

        'premjestanje fajla iz direktorija u direktorij 

        My.Computer.FileSystem.MoveFile("C:\PP\periodicni.inp", "C:\Temp\periodicni.inp")

        Me.Close()


    End Sub
End Class
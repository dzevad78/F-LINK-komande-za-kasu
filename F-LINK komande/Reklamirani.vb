Public Class Reklamirani

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click


        'ako odabere se stopa A onda 

        Dim stopa As String

        stopa = ComboBox1.Text

        If stopa = "A" Then



            'kreiranje fajla za REKLAMIRANI račun

            Dim file As System.IO.FileStream
            file = System.IO.File.Create("c:\PP\reklamirani.inp")

            file.Close()

            'upisivanje komande za otvaranje ladice u fajl

            Dim FILE_NAME As String = "c:\PP\reklamirani.inp"

            If System.IO.File.Exists(FILE_NAME) = True Then

                Dim objWriter As New System.IO.StreamWriter(FILE_NAME)

                objWriter.WriteLine("K,1,______,_,__;" & TextBox1.Text & ";0;;")
                objWriter.WriteLine("S,1,______,_,__;Test;0.10;1;1;1;1;0;1;")
                objWriter.WriteLine("T,1,______,_,__;0")
                objWriter.Close()

            End If

            'premjestanje fajla iz direktorija u direktorij 

            My.Computer.FileSystem.MoveFile("c:\PP\reklamirani.inp", "C:\Temp\reklamirani.inp")
            Me.Close()


        End If


        If stopa = "E" Then


            'kreiranje fajla za REKLAMIRANI račun

            Dim file As System.IO.FileStream
            file = System.IO.File.Create("c:\PP\reklamirani.inp")

            file.Close()

            'upisivanje komande za otvaranje ladice u fajl

            Dim FILE_NAME As String = "c:\PP\reklamirani.inp"

            If System.IO.File.Exists(FILE_NAME) = True Then

                Dim objWriter As New System.IO.StreamWriter(FILE_NAME)

                objWriter.WriteLine("K,1,______,_,__;" & TextBox1.Text & ";0;;")
                objWriter.WriteLine("S,1,______,_,__;Test;0.10;1;1;1;2;0;1;")
                objWriter.WriteLine("T,1,______,_,__;0")
                objWriter.Close()

            End If

            'premjestanje fajla iz direktorija u direktorij 

            My.Computer.FileSystem.MoveFile("c:\PP\reklamirani.inp", "C:\Temp\reklamirani.inp")
            Me.Close()


        End If


        If stopa = "K" Then

            'kreiranje fajla za REKLAMIRANI račun

            Dim file As System.IO.FileStream
            file = System.IO.File.Create("c:\PP\reklamirani.inp")

            file.Close()

            'upisivanje komande za otvaranje ladice u fajl

            Dim FILE_NAME As String = "c:\PP\reklamirani.inp"

            If System.IO.File.Exists(FILE_NAME) = True Then

                Dim objWriter As New System.IO.StreamWriter(FILE_NAME)

                objWriter.WriteLine("K,1,______,_,__;" & TextBox1.Text & ";0;;")
                objWriter.WriteLine("S,1,______,_,__;Test;0.10;1;1;1;4;0;1;")
                objWriter.WriteLine("T,1,______,_,__;0")
                objWriter.Close()

            End If

            'premjestanje fajla iz direktorija u direktorij 

            My.Computer.FileSystem.MoveFile("c:\PP\reklamirani.inp", "C:\Temp\reklamirani.inp")
            Me.Close()

        End If


    End Sub



End Class
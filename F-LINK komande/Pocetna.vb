Imports System.Drawing.Drawing2D
Imports System.IO
Imports System.Reflection.Emit
Imports System.Windows.Forms.VisualStyles
Imports System.Windows.Forms.VisualStyles.VisualStyleElement




Public Class Pocetna

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        'kreiranje direktorija PP ako ne postoji




        'kreiranje fajla

        Dim file As System.IO.FileStream
        file = System.IO.File.Create("c:\PP\zatvaranjedana.inp")

        file.Close()

        'upisivanje komande za ZI u fajl

        Dim FILE_NAME As String = "c:\PP\zatvaranjedana.inp"

        If System.IO.File.Exists(FILE_NAME) = True Then

            Dim objWriter As New System.IO.StreamWriter(FILE_NAME)

            objWriter.Write("Z,1,______,_,__;")
            objWriter.Close()

        End If

        'premjestanje fajla iz direktorija u direktorij 

        My.Computer.FileSystem.MoveFile("c:\PP\zatvaranjedana.inp", "C:\Temp\zatvaranjedana.inp")


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        'kreiranje fajla presjek stanja

        Dim file As System.IO.FileStream
        file = System.IO.File.Create("c:\PP\presjekstanja.inp")

        file.Close()

        'upisivanje komande za presjek stanja u fajl

        Dim FILE_NAME As String = "c:\PP\presjekstanja.inp"

        If System.IO.File.Exists(FILE_NAME) = True Then

            Dim objWriter As New System.IO.StreamWriter(FILE_NAME)

            objWriter.Write("X,1,______,_,__;")
            objWriter.Close()

        End If

        'premjestanje fajla iz direktorija u direktorij 

        My.Computer.FileSystem.MoveFile("c:\PP\presjekstanja.inp", "C:\Temp\presjekstanja.inp")



    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        'kreiranje fajla

        Dim file As System.IO.FileStream
        file = System.IO.File.Create("c:\PP\otvaranjeladice.inp")

        file.Close()

        'upisivanje komande za otvaranje ladice u fajl

        Dim FILE_NAME As String = "c:\PP\otvaranjeladice.inp"

        If System.IO.File.Exists(FILE_NAME) = True Then

            Dim objWriter As New System.IO.StreamWriter(FILE_NAME)

            objWriter.Write("V,1,______,_,__;[43]")
            objWriter.Close()

        End If

        'premjestanje fajla iz direktorija u direktorij 

        My.Computer.FileSystem.MoveFile("c:\PP\otvaranjeladice.inp", "C:\Temp\otvaranjeladice.inp")

    End Sub


    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click

        'otvaranje forme za unos BF

        Unos_BF.Show()

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click

        'otvaranje forme za unos DI

        DuplDnevnog.Show()

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click

        periodični.Show()

    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click

        'kreiranje fajla

        Dim file As System.IO.FileStream
        file = System.IO.File.Create("c:\PP\ispisartikala.inp")

        file.Close()

        'upisivanje komande za ispis artikala u fajl

        Dim FILE_NAME As String = "c:\PP\ispisartikala.inp"

        If System.IO.File.Exists(FILE_NAME) = True Then

            Dim objWriter As New System.IO.StreamWriter(FILE_NAME)

            objWriter.Write("V,1,______,_,__;[2C]")
            objWriter.Close()

        End If

        'premjestanje fajla iz direktorija u direktorij 

        My.Computer.FileSystem.MoveFile("c:\PP\ispisartikala.inp", "C:\Temp\ispisartikala.inp")

    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click

        'kreiranje fajla

        Dim file As System.IO.FileStream
        file = System.IO.File.Create("c:\PP\gprspostavke.inp")

        file.Close()

        'upisivanje komande za otvaranje ladice u fajl

        Dim FILE_NAME As String = "c:\PP\gprspostavke.inp"

        If System.IO.File.Exists(FILE_NAME) = True Then

            Dim objWriter As New System.IO.StreamWriter(FILE_NAME)

            objWriter.Write("V,1,______,_,__;[70][01]")
            objWriter.Close()

        End If

        'premjestanje fajla iz direktorija u direktorij 

        My.Computer.FileSystem.MoveFile("c:\PP\gprspostavke.inp", "C:\Temp\gprspostavke.inp")

    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click

        Dim brisanje As String

        For Each brisanje In System.IO.Directory.GetFiles("C:\Temp\Printed")

            System.IO.File.Delete(brisanje)

        Next brisanje

    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click

        'ako odabere se stopa A onda 

        Dim stopa As String

        stopa = ComboBox1.Text

        If stopa = "A" Then

            Dim file As System.IO.FileStream
            file = System.IO.File.Create("C:\PP\testniracun.inp")

            file.Close()

            'upisivanje komande za testni racun u fajl

            Dim FILE_NAME As String = "c:\PP\testniracun.inp"

            If System.IO.File.Exists(FILE_NAME) = True Then

                Dim objWriter As New System.IO.StreamWriter(FILE_NAME)

                objWriter.WriteLine("K,1,______,_,__;;0;;")
                objWriter.WriteLine("S,1,______,_,__;Test;0.10;1;1;1;1;0;1;")
                objWriter.WriteLine("T,1,______,_,__;0;0.10;")
                objWriter.Close()

            End If

            'premjestanje fajla iz direktorija u direktorij 

            My.Computer.FileSystem.MoveFile("c:\PP\testniracun.inp", "C:\Temp\testniracun.inp")

        End If


        If stopa = "E" Then

            Dim file As System.IO.FileStream
            file = System.IO.File.Create("c:\PP\testniracun.inp")

            file.Close()

            'upisivanje komande za testni racun u fajl

            Dim FILE_NAME As String = "c:\PP\testniracun.inp"

            If System.IO.File.Exists(FILE_NAME) = True Then

                Dim objWriter As New System.IO.StreamWriter(FILE_NAME)

                objWriter.WriteLine("K,1,______,_,__;;;;")
                objWriter.WriteLine("S,1,______,_,__;Test;0.10;1;1;1;2;0;1;")
                objWriter.WriteLine("T,1,______,_,__;0;0.10;")
                objWriter.Close()

            End If

            'premjestanje fajla iz direktorija u direktorij 

            My.Computer.FileSystem.MoveFile("c:\PP\testniracun.inp", "C:\Temp\testniracun.inp")


        End If

        If stopa = "K" Then

            Dim file As System.IO.FileStream
            file = System.IO.File.Create("c:\PP\testniracun.inp")

            file.Close()

            'upisivanje komande za testni racun u fajl

            Dim FILE_NAME As String = "c:\PP\testniracun.inp"

            If System.IO.File.Exists(FILE_NAME) = True Then

                Dim objWriter As New System.IO.StreamWriter(FILE_NAME)

                objWriter.WriteLine("K,1,______,_,__;;0;;")
                objWriter.WriteLine("S,1,______,_,__;Test;0.10;1;1;1;4;0;1;")
                objWriter.WriteLine("T,1,______,_,__;0;0.10;")
                objWriter.Close()

            End If

            'premjestanje fajla iz direktorija u direktorij 

            My.Computer.FileSystem.MoveFile("c:\PP\testniracun.inp", "C:\Temp\testniracun.inp")


        End If



    End Sub


    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click

        Reklamirani.Show()

    End Sub

    'Kad se program pokrene provjeri i kreira folder PP
    Private Sub Pocetna_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not Directory.Exists("C:\PP") Then
            Directory.CreateDirectory("C:\PP")
        End If
    End Sub
End Class

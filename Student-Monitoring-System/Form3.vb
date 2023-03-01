Imports System.Diagnostics.Eventing
Imports MySqlConnector

Public Class Form3

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            TextBoxPassword.UseSystemPasswordChar = False
        Else
            TextBoxPassword.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub ButtonLogin_Click(sender As Object, e As EventArgs) Handles ButtonLogin.Click
        Dim Connection As New MySqlConnection("server=localhost; user=root; password=; database=project")

        Try
            Connection.Open()
        Catch ex As Exception
            MessageBox.Show("Connection failed !!!" & vbCrLf & "Please check that the server is ready !!!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End Try

        Dim MySQLCMD As New MySqlCommand("SELECT * FROM admin WHERE username=@username AND password=@password", Connection)
        MySQLCMD.Parameters.AddWithValue("@username", TextBoxUsername.Text)
        MySQLCMD.Parameters.AddWithValue("@password", TextBoxPassword.Text)

        Dim reader As MySqlDataReader = MySQLCMD.ExecuteReader

        If reader.Read Then
            Form1.Show()
            Me.Hide()
        Else
            MsgBox("Wrong Username or Password")
        End If
    End Sub
End Class
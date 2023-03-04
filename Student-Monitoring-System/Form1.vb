Imports System.Timers
Imports MySqlConnector

Public Class Form1
    'server=localhost; user=yout_database_user; password=your_database_password; database=your_database_name
    Dim Connection As New MySqlConnection("server=localhost; user=root; password=; database=project")
    Dim MySQLCMD As New MySqlCommand
    Dim MySQLDA As New MySqlDataAdapter
    Dim DT As New DataTable
    Dim Table_Name As String = "student_list"
    Dim Table_Name2 As String = "attendance"

    Dim Data As Integer
    Dim IDRam As String
    Dim StatusInput As String = "Save"
    Dim SqlCmdSearchstr As String

    Public Shared StrSerialIn As String
    Dim GetID As Boolean = False
    Dim ViewUserData As Boolean = False


    Private WithEvents dataTimer As New Timer()
    Public Property Cancel As Boolean

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        PanelDashboard.Visible = True
        PanelConnection.Visible = False
        PanelUserData.Visible = False
        PanelRegistration.Visible = False
        PanelSearch.Visible = False
        ComboBoxBaudRate.SelectedIndex = 3
        Timer1.Interval = 1000 ' 1 second
        Timer1.Enabled = True
    End Sub


    'Show data in DatagridView1 in Dashboard Panel'
    Private Function GetData() As DataTable
        Dim connectionString As String = "server=localhost; user=root; password=; database=project"
        Dim query As String = "SELECT `ID`, `RFID_UID`, `Student_ID`, `Name`, `Department`, `Course`, `Status`, `Year`, `Date`, `Time` FROM " & Table_Name2 & " ORDER BY ID DESC"

        Dim dataTable As New DataTable()
        Using connection As New MySqlConnection(connectionString)
            connection.Open()
            Using command As New MySqlCommand(query, connection)
                Using adapter As New MySqlDataAdapter(command)
                    adapter.Fill(dataTable)
                End Using
            End Using
        End Using

        Return dataTable
    End Function


    'Show data in DatagridView3 in Registration Panel'
    Private Sub ShowDataInRegistration()
        Try
            Connection.Open()
        Catch ex As Exception
            MessageBox.Show("Connection failed !!!" & vbCrLf & "Please check that the server is ready !!!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End Try

        Try
            MySQLCMD.CommandType = CommandType.Text
            MySQLCMD.CommandText = "SELECT `ID`,`Student_ID`, `Firstname`, `Middlename`, `Lastname`, `Age`, `Department`, `Course`, `Year`, `Parent_Number`, `RFID_UID` FROM " & Table_Name & " ORDER BY ID"
            MySQLDA = New MySqlDataAdapter(MySQLCMD.CommandText, Connection)
            DT = New DataTable
            Data = MySQLDA.Fill(DT)
            If Data > 0 Then
                DataGridView3.DataSource = Nothing
                DataGridView3.DataSource = DT
                DataGridView3.Columns(2).DefaultCellStyle.Format = "c"
                DataGridView3.DefaultCellStyle.ForeColor = Color.Black
                DataGridView3.ClearSelection()
                DataGridView3.ColumnHeadersDefaultCellStyle.Font = New Font("Arial", 9, FontStyle.Bold)
            Else
                DataGridView3.DataSource = DT
            End If
        Catch ex As Exception
            MsgBox("Failed to load Database !!!" & vbCr & ex.Message, MsgBoxStyle.Critical, "Error Message")
            Connection.Close()
            Return
        End Try

        DT = Nothing
        Connection.Close()
    End Sub

    'Show data in DatagridView2 in Search Panel'
    Private Sub ShowDataInSearch()
        Try
            Connection.Open()
        Catch ex As Exception
            MessageBox.Show("Connection failed !!!" & vbCrLf & "Please check that the server is ready !!!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End Try

        Try
            MySQLCMD.CommandType = CommandType.Text
            MySQLCMD.CommandText = "SELECT `ID`, `RFID_UID`, `Student_ID`, `Name`, `Department`, `Course`, `Year`, `Status`, `Date`, `Time` FROM `attendance` FROM" & Table_Name2 & " ORDER BY ID DESC"
            MySQLDA = New MySqlDataAdapter(MySQLCMD.CommandText, Connection)
            DT = New DataTable
            Data = MySQLDA.Fill(DT)
            If Data > 0 Then
                DataGridView2.DataSource = Nothing
                DataGridView2.DataSource = DT
                DataGridView2.Columns(2).DefaultCellStyle.Format = "c"
                DataGridView2.DefaultCellStyle.ForeColor = Color.Black
                DataGridView2.ClearSelection()
                DataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
                DataGridView2.ColumnHeadersDefaultCellStyle.Font = New Font("Arial", 9, FontStyle.Bold)
            Else
                DataGridView2.DataSource = DT
            End If
        Catch ex As Exception
            MsgBox("Failed to load Database !!!" & vbCr & ex.Message, MsgBoxStyle.Critical, "Error Message")
            Connection.Close()
            Return
        End Try

        DT = Nothing
        Connection.Close()
    End Sub

    'Show data in UserDetails Panel'
    'You can check the UserDetails via RFID Card and display the user information'
    Private Sub ShowDataUser()
        Try
            Connection.Open()
        Catch ex As Exception
            MessageBox.Show("Connection failed !!!" & vbCrLf & "Please check that the server is ready !!!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End Try

        Try
            MySQLCMD.CommandType = CommandType.Text
            MySQLCMD.CommandText = "SELECT * FROM " & Table_Name & " WHERE RFID_UID ='" & LabelID.Text & "'"
            MySQLDA = New MySqlDataAdapter(MySQLCMD.CommandText, Connection)
            DT = New DataTable
            Data = MySQLDA.Fill(DT)
            If Data > 0 Then
                LabelID.Text = DT.Rows(0).Item("RFID_UID")
                LabelFirstname.Text = DT.Rows(0).Item("Firstname")
                LabelLastname.Text = DT.Rows(0).Item("Lastname")
                LabelMiddlename.Text = DT.Rows(0).Item("Middlename")
                LabelAge.Text = DT.Rows(0).Item("Age")
                LabelDepartment.Text = DT.Rows(0).Item("Department")
                LabelCourse.Text = DT.Rows(0).Item("Course")
                LabelYear.Text = DT.Rows(0).Item("Year")
                LabelParent_Number.Text = DT.Rows(0).Item("Parent_Number")
            Else
                MsgBox("RFID_UID not found !!!" & vbCr & "Please register your RFID_UID.", MsgBoxStyle.Information, "Information Message")
            End If
        Catch ex As Exception
            MsgBox("Failed to load Database !!!" & vbCr & ex.Message, MsgBoxStyle.Critical, "Error Message")
            Connection.Close()
            Return
        End Try

        DT = Nothing
        Connection.Close()
    End Sub

    Private Sub ButtonDashboard_Click(sender As Object, e As EventArgs) Handles ButtonDashboard.Click
        PictureBoxSelect.Top = ButtonDashboard.Top
        PanelDashboard.Visible = True
        PanelConnection.Visible = False
        PanelUserData.Visible = False
        PanelRegistration.Visible = False
        PanelSearch.Visible = False

    End Sub

    Private Sub ButtonConnection_Click(sender As Object, e As EventArgs) Handles ButtonConnection.Click
        PictureBoxSelect.Top = ButtonConnection.Top
        PanelDashboard.Visible = False
        PanelConnection.Visible = True
        PanelUserData.Visible = False
        PanelRegistration.Visible = False
        PanelSearch.Visible = False
    End Sub

    Private Sub ButtonUserData_Click(sender As Object, e As EventArgs) Handles ButtonUserData.Click
        If TimerSerialIn.Enabled = False Then
            MsgBox("Failed to open User Details !!!" & vbCr & "Click the Connection menu then click the Connect button.", MsgBoxStyle.Information, "Information")
            Return
        Else
            StrSerialIn = ""
            ViewUserData = True
            PictureBoxSelect.Top = ButtonUserData.Top
            PanelDashboard.Visible = False
            PanelConnection.Visible = False
            PanelUserData.Visible = True
            PanelRegistration.Visible = False
            PanelSearch.Visible = False
        End If
    End Sub

    Private Sub ButtonRegistration_Click(sender As Object, e As EventArgs) Handles ButtonRegistration.Click
        StrSerialIn = ""
        ViewUserData = False
        PictureBoxSelect.Top = ButtonRegistration.Top
        PanelDashboard.Visible = False
        PanelConnection.Visible = False
        PanelUserData.Visible = False
        PanelRegistration.Visible = True
        PanelSearch.Visible = False
        ShowDataInRegistration()
    End Sub

    Private Sub ButtonSearch_Click(sender As Object, e As EventArgs) Handles ButtonSearch.Click
        PictureBoxSelect.Top = ButtonSearch.Top
        PanelDashboard.Visible = False
        PanelConnection.Visible = False
        PanelUserData.Visible = False
        PanelRegistration.Visible = False
        PanelSearch.Visible = True
        ShowDataInSearch()
    End Sub

    Private Sub PanelDashboard_Resize(sender As Object, e As EventArgs) Handles PanelDashboard.Resize
        PanelConnection.Invalidate()
    End Sub

    Private Sub PanelDashboard_Paint(sender As Object, e As PaintEventArgs) Handles PanelDashboard.Paint
        e.Graphics.DrawRectangle(New Pen(Color.LightGray, 2), PanelDashboard.ClientRectangle)
    End Sub

    Private Sub PanelConnection_Resize(sender As Object, e As EventArgs) Handles PanelConnection.Resize
        PanelConnection.Invalidate()
    End Sub

    Private Sub PanelConnection_Paint(sender As Object, e As PaintEventArgs) Handles PanelConnection.Paint
        e.Graphics.DrawRectangle(New Pen(Color.LightGray, 2), PanelConnection.ClientRectangle)
    End Sub

    Private Sub PanelUserData_Resize(sender As Object, e As EventArgs) Handles PanelUserData.Resize
        PanelUserData.Invalidate()
    End Sub

    Private Sub PanelUserData_Paint(sender As Object, e As PaintEventArgs) Handles PanelUserData.Paint
        e.Graphics.DrawRectangle(New Pen(Color.LightGray, 2), PanelUserData.ClientRectangle)
    End Sub

    Private Sub PanelRegistration_Resize(sender As Object, e As EventArgs) Handles PanelRegistration.Resize
        PanelRegistration.Invalidate()
    End Sub

    Private Sub PanelRegistration_Paint(sender As Object, e As PaintEventArgs) Handles PanelRegistration.Paint
        e.Graphics.DrawRectangle(New Pen(Color.LightGray, 2), PanelRegistration.ClientRectangle)
    End Sub

    'Scan the available port'
    'First Plug In the Arduino to the USB port'
    Private Sub ButtonScanPort_Click(sender As Object, e As EventArgs) Handles ButtonScanPort.Click
        ComboBoxPort.Items.Clear()
        Dim myPort As Array
        Dim i As Integer
        myPort = IO.Ports.SerialPort.GetPortNames()
        ComboBoxPort.Items.AddRange(myPort)
        i = ComboBoxPort.Items.Count
        i = i - i
        Try
            ComboBoxPort.SelectedIndex = i
        Catch ex As Exception
            MsgBox("Com port not detected", MsgBoxStyle.Critical, "Error Message")
            ComboBoxPort.Text = ""
            ComboBoxPort.Items.Clear()
            Return
        End Try
        ComboBoxPort.DroppedDown = True
    End Sub

    'To Connect the application to the arduino'
    Private Sub ButtonConnect_Click(sender As Object, e As EventArgs) Handles ButtonConnect.Click
        If ButtonConnect.Text = "Connect" Then
            SerialPort1.BaudRate = ComboBoxBaudRate.SelectedItem
            SerialPort1.PortName = ComboBoxPort.SelectedItem
            Try
                SerialPort1.Open()
                TimerSerialIn.Start()
                ButtonConnect.Text = "Disconnect"
                PictureBoxStatusConnect.Image = My.Resources.Connected
            Catch ex As Exception
                MsgBox("Failed to connect !!!" & vbCr & "Arduino is not detected.", MsgBoxStyle.Critical, "Error Message")
                PictureBoxStatusConnect.Image = My.Resources.Disconnect
            End Try
        ElseIf ButtonConnect.Text = "Disconnect" Then
            PictureBoxStatusConnect.Image = My.Resources.Disconnect
            ButtonConnect.Text = "Connect"
            LabelConnectionStatus.Text = "Connection Status : Disconnect"
            TimerSerialIn.Stop()
            SerialPort1.Close()
        End If
    End Sub

    Private Sub ButtonClear_Click(sender As Object, e As EventArgs) Handles ButtonClear.Click
        LabelID.Text = "______________"
        LabelFirstname.Text = "Waiting..."
        LabelMiddlename.Text = "Waiting..."
        LabelLastname.Text = "Waiting..."
        LabelAge.Text = "Waiting..."
        LabelDepartment.Text = "Waiting..."
        LabelCourse.Text = "Waiting..."
        LabelYear.Text = "Waiting..."
        LabelParent_Number.Text = "Waiting..."
    End Sub

    'Save the user information'
    Private Sub ButtonSave_Click(sender As Object, e As EventArgs) Handles ButtonSave.Click

        If TextBoxStudent_ID.Text = "" Then
            MessageBox.Show("Student ID cannot be empty !!!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If TextBoxFirstname.Text = "" Then
            MessageBox.Show("Firstname cannot be empty !!!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If TextBoxMiddlename.Text = "" Then
            MessageBox.Show("Middlename cannot be empty !!!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If TextBoxLastname.Text = "" Then
            MessageBox.Show("Lastname cannot be empty !!!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If TextBoxAge.Text = "" Then
            MessageBox.Show("Age cannot be empty !!!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If ComboBoxDepartment.Text = "" Then
            MessageBox.Show("Department cannot be empty !!!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If ComboBoxCourse.Text = "" Then
            MessageBox.Show("Course cannot be empty !!!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If ComboBoxYear.Text = "" Then
            MessageBox.Show("Year cannot be empty !!!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If TextBoxParent_Number.Text = "" Then
            MessageBox.Show("Parent Phone Number cannot be empty !!!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If StatusInput = "Save" Then

            Try
                Connection.Open()
            Catch ex As Exception
                MessageBox.Show("Connection failed !!!" & vbCrLf & "Please check that the server is ready !!!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End Try

            Try
                MySQLCMD = New MySqlCommand
                With MySQLCMD
                    .CommandText = "INSERT INTO " & Table_Name & " (`Student_ID`, `Firstname`, `Middlename`, `Lastname`, `Age`, `Department`, `Course`, `Year`, `Parent_Number`, `RFID_UID`) VALUES (@Student_ID,@Firstname,@Middlename,@Lastname,@Age,@Department,@Course,@Year,@Parent_Number,@RFID_UID)"
                    .Connection = Connection
                    .Parameters.AddWithValue("@RFID_UID", LabelGetID.Text)
                    .Parameters.AddWithValue("@Student_ID", TextBoxStudent_ID.Text)
                    .Parameters.AddWithValue("@Firstname", TextBoxFirstname.Text)
                    .Parameters.AddWithValue("@Middlename", TextBoxMiddlename.Text)
                    .Parameters.AddWithValue("@Lastname", TextBoxLastname.Text)
                    .Parameters.AddWithValue("@Age", TextBoxAge.Text)
                    .Parameters.AddWithValue("@Department", ComboBoxDepartment.Text)
                    .Parameters.AddWithValue("@Course", ComboBoxCourse.Text)
                    .Parameters.AddWithValue("@Year", ComboBoxYear.Text)
                    .Parameters.AddWithValue("@Parent_Number", TextBoxParent_Number.Text)

                    .ExecuteNonQuery()
                End With
                MsgBox("Data saved successfully", MsgBoxStyle.Information, "Information")
                ClearInputUpdateData()
            Catch ex As Exception
                MsgBox("Data failed to save !!!" & vbCr & ex.Message, MsgBoxStyle.Critical, "Error Message")
                Connection.Close()
                Return
            End Try
            Connection.Close()

        Else

            Try
                Connection.Open()
            Catch ex As Exception
                MessageBox.Show("Connection failed !!!" & vbCrLf & "Please check that the server is ready !!!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End Try

            Try
                MySQLCMD = New MySqlCommand
                With MySQLCMD
                    .CommandText = "UPDATE " & Table_Name & " SET  Student_ID=@Student_ID,Firstname=@Firstname,Middlename=@Middlename,Lastname=@Lastname,Age=@Age,Department=@Department,Course=@Course,Year=@Year,Parent_Number=@Parent_Number,RFID_UID=@RFID_UID WHERE RFID_UID=@RFID_UID "
                    .Connection = Connection
                    .Parameters.AddWithValue("@Student_ID", TextBoxStudent_ID.Text)
                    .Parameters.AddWithValue("@Firstname", TextBoxFirstname.Text)
                    .Parameters.AddWithValue("@Middlename", TextBoxMiddlename.Text)
                    .Parameters.AddWithValue("@Lastname", TextBoxLastname.Text)
                    .Parameters.AddWithValue("@Age", TextBoxAge.Text)
                    .Parameters.AddWithValue("@Department", ComboBoxDepartment.Text)
                    .Parameters.AddWithValue("@Course", ComboBoxCourse.Text)
                    .Parameters.AddWithValue("@Year", ComboBoxYear.Text)
                    .Parameters.AddWithValue("@Parent_Number", TextBoxParent_Number.Text)
                    .Parameters.AddWithValue("@RFID_UID", LabelGetID.Text)
                    .ExecuteNonQuery()
                End With
                MsgBox("Data updated successfully", MsgBoxStyle.Information, "Information")
                ButtonSave.Text = "Save"
                ClearInputUpdateData()
            Catch ex As Exception
                MsgBox("Data failed to Update !!!" & vbCr & ex.Message, MsgBoxStyle.Critical, "Error Message")
                Connection.Close()
                Return
            End Try
            Connection.Close()
            StatusInput = "Save"
        End If
        ShowDataInRegistration()
    End Sub

    Private Sub ButtonClearForm_Click(sender As Object, e As EventArgs) Handles ButtonClearForm.Click
        ClearInputUpdateData()
    End Sub

    Private Sub ClearInputUpdateData()
        TextBoxStudent_ID.Text = ""
        TextBoxFirstname.Text = ""
        TextBoxMiddlename.Text = ""
        TextBoxLastname.Text = ""
        LabelGetID.Text = "____________"
        TextBoxAge.Text = ""
        ComboBoxDepartment.Text = ""
        ComboBoxCourse.Text = ""
        ComboBoxYear.Text = ""
        TextBoxParent_Number.Text = ""
    End Sub

    'To scan the RFID card'
    Private Sub ButtonScanID_Click(sender As Object, e As EventArgs) Handles ButtonScanID.Click
        If TimerSerialIn.Enabled = True Then
            PanelReadingTagProcess.Visible = True
            GetID = True
            ButtonScanID.Enabled = False
        Else
            MsgBox("Failed to open User Data !!!" & vbCr & "Click the Connection menu then click the Connect button.", MsgBoxStyle.Critical, "Error Message")
        End If
    End Sub

    Private Sub CheckBoxByName_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxByName.CheckedChanged
        If CheckBoxByName.Checked = True Then
            CheckBoxByID.Checked = False
        End If
        If CheckBoxByName.Checked = False Then
            CheckBoxByID.Checked = True
        End If
    End Sub

    Private Sub CheckBoxByID_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxByID.CheckedChanged
        If CheckBoxByID.Checked = True Then
            CheckBoxByName.Checked = False
        End If
        If CheckBoxByID.Checked = False Then
            CheckBoxByName.Checked = True
        End If
    End Sub

    Private Sub CheckBoxSearchName_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxSearchName.CheckedChanged
        If CheckBoxSearchName.Checked = True Then
            CheckBoxSearchID.Checked = False
        End If
        If CheckBoxSearchName.Checked = False Then
            CheckBoxSearchID.Checked = True
        End If
    End Sub

    Private Sub CheckBoxSearchID_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxSearchID.CheckedChanged
        If CheckBoxSearchID.Checked = True Then
            CheckBoxSearchName.Checked = False
        End If
        If CheckBoxSearchID.Checked = False Then
            CheckBoxSearchName.Checked = True
        End If
    End Sub

    'Search in Search Panel'
    Private Sub SearchTextBox_TextChanged(sender As Object, e As EventArgs) Handles SearchTextBox.TextChanged
        If CheckBoxSearchID.Checked = True Then
            If SearchTextBox.Text = Nothing Then
                SqlCmdSearchstr = "SELECT `ID`, `RFID_UID`, `Student_ID`, `Name`, `Department`, `Course`, `Year`, `Status`, `Date`, `Time` FROM " & Table_Name2 & " ORDER BY Student_ID"
            Else
                SqlCmdSearchstr = "SELECT `ID`, `RFID_UID`, `Student_ID`, `Name`, `Department`, `Course`, `Year`, `Status`, `Date`, `Time` FROM " & Table_Name2 & " WHERE Student_ID LIKE '" & SearchTextBox.Text & "%'"
            End If
        End If
        If CheckBoxSearchName.Checked = True Then
            If SearchTextBox.Text = Nothing Then
                SqlCmdSearchstr = "SELECT `ID`, `RFID_UID`, `Student_ID`, `Name`, `Department`, `Course`, `Year`, `Status`, `Date`, `Time` FROM " & Table_Name2 & " ORDER BY Name"
            Else
                SqlCmdSearchstr = "SELECT `ID`, `RFID_UID`, `Student_ID`, `Name`, `Department`, `Course`, `Year`, `Status`, `Date`, `Time` FROM " & Table_Name2 & " WHERE Name LIKE '" & SearchTextBox.Text & "%'"
            End If
        End If

        Try
            Connection.Open()
        Catch ex As Exception
            MessageBox.Show("Connection failed !!!" & vbCrLf & "Please check that the server is ready !!!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End Try

        Try
            MySQLDA = New MySqlDataAdapter(SqlCmdSearchstr, Connection)
            DT = New DataTable
            Data = MySQLDA.Fill(DT)
            If Data > 0 Then
                DataGridView2.DataSource = Nothing
                DataGridView2.DataSource = DT
                DataGridView2.DefaultCellStyle.ForeColor = Color.Black
                DataGridView2.ClearSelection()
            Else
                DataGridView2.DataSource = DT
            End If
        Catch ex As Exception
            MsgBox("Failed to search" & vbCr & ex.Message, MsgBoxStyle.Critical, "Error Message")
            Connection.Close()
        End Try
        Connection.Close()
    End Sub

    'Search in Registration Panel'
    Private Sub TextBoxSearch_TextChanged(sender As Object, e As EventArgs) Handles TextBoxSearch.TextChanged
        If CheckBoxByID.Checked = True Then
            If TextBoxSearch.Text = Nothing Then
                SqlCmdSearchstr = "SELECT `ID`, `Student_ID`, `Firstname`, `Middlename`, `Lastname`, `Age`, `Department`, `Course`, `Year`, `Parent_Number`, `RFID_UID` FROM " & Table_Name & " ORDER BY Student_ID"
            Else
                SqlCmdSearchstr = "SELECT `ID`, `Student_ID`, `Firstname`, `Middlename`, `Lastname`, `Age`, `Department`, `Course`, `Year`, `Parent_Number`, `RFID_UID` FROM " & Table_Name & " WHERE Student_ID LIKE'" & TextBoxSearch.Text & "%'"
            End If
        End If
        If CheckBoxByName.Checked = True Then
            If TextBoxSearch.Text = Nothing Then
                SqlCmdSearchstr = "SELECT `ID`, `Student_ID`, `Firstname`, `Middlename`, `Lastname`, `Age`, `Department`, `Course`, `Year`, `Parent_Number`, `RFID_UID` FROM " & Table_Name & " ORDER BY Firstname"
            Else
                SqlCmdSearchstr = "SELECT `ID`, `Student_ID`, `Firstname`, `Middlename`, `Lastname`, `Age`, `Department`, `Course`, `Year`, `Parent_Number`, `RFID_UID` FROM " & Table_Name & " WHERE Firstname LIKE '" & TextBoxSearch.Text & "%' " & "OR " & "Lastname LIKE '" & TextBoxSearch.Text & "%' "
            End If
        End If

        Try
            Connection.Open()
        Catch ex As Exception
            MessageBox.Show("Connection failed !!!" & vbCrLf & "Please check that the server is ready !!!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End Try

        Try
            MySQLDA = New MySqlDataAdapter(SqlCmdSearchstr, Connection)
            DT = New DataTable
            Data = MySQLDA.Fill(DT)
            If Data > 0 Then
                DataGridView3.DataSource = Nothing
                DataGridView3.DataSource = DT
                DataGridView3.DefaultCellStyle.ForeColor = Color.Black
                DataGridView3.ClearSelection()
            Else
                DataGridView3.DataSource = DT
            End If
        Catch ex As Exception
            MsgBox("Failed to search" & vbCr & ex.Message, MsgBoxStyle.Critical, "Error Message")
            Connection.Close()
        End Try
        Connection.Close()
    End Sub

    Private Sub DataGridView3_CellMouseDown(sender As Object, e As DataGridViewCellMouseEventArgs)
        Try
            If AllCellsSelected(DataGridView3) = False Then
                If e.Button = MouseButtons.Left Then
                    DataGridView3.CurrentCell = DataGridView3(e.ColumnIndex, e.RowIndex)
                    Dim i As Integer
                    With DataGridView3
                        If e.RowIndex >= 0 Then
                            i = .CurrentRow.Index
                            IDRam = .Rows(i).Cells("ID").Value.ToString
                            ShowDataInRegistration()
                        End If
                    End With
                End If
            End If
        Catch ex As Exception
            Return
        End Try
    End Sub

    Private Sub DataGridView2_CellMouseDown(sender As Object, e As DataGridViewCellMouseEventArgs)
        Try
            If AllCellsSelected2(DataGridView2) = False Then
                If e.Button = MouseButtons.Left Then
                    DataGridView2.CurrentCell = DataGridView2(e.ColumnIndex, e.RowIndex)
                    Dim i As Integer
                    With DataGridView2
                        If e.RowIndex >= 0 Then
                            i = .CurrentRow.Index
                            IDRam = .Rows(i).Cells("ID").Value.ToString
                            ShowDataInSearch()
                        End If
                    End With
                End If
            End If
        Catch ex As Exception
            Return
        End Try
    End Sub

    Private Sub DataGridView1_CellMouseDown(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView3.CellMouseDown
        Try
            If AllCellsSelected(DataGridView1) = False Then
                If e.Button = MouseButtons.Left Then
                    DataGridView1.CurrentCell = DataGridView1(e.ColumnIndex, e.RowIndex)
                    Dim i As Integer
                    With DataGridView1
                        If e.RowIndex >= 0 Then
                            i = .CurrentRow.Index
                            IDRam = .Rows(i).Cells("ID").Value.ToString

                        End If
                    End With
                End If
            End If
        Catch ex As Exception
            Return
        End Try
    End Sub

    Private Function AllCellsSelected(dgv As DataGridView) As Boolean
        AllCellsSelected = (DataGridView3.SelectedCells.Count = (DataGridView3.RowCount * DataGridView3.Columns.GetColumnCount(DataGridViewElementStates.Visible)))
    End Function

    Private Function AllCellsSelected2(dgv As DataGridView) As Boolean
        AllCellsSelected2 = (DataGridView2.SelectedCells.Count = (DataGridView3.RowCount * DataGridView3.Columns.GetColumnCount(DataGridViewElementStates.Visible)))
    End Function

    Private Sub TimerTimeDate_Tick(sender As Object, e As EventArgs) Handles TimerTimeDate.Tick
        LabelDateTime.Text = "Time " & DateTime.Now.ToString("HH:mm:ss") & "  Date " & DateTime.Now.ToString("dd MMM, yyyy")
    End Sub

    'Delete the user data in Registration Panel'
    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        If DataGridView3.RowCount = 0 Then
            MsgBox("Cannot delete, table data is empty", MsgBoxStyle.Critical, "Error Message")
            Return
        End If

        If DataGridView3.SelectedRows.Count = 0 Then
            MsgBox("Cannot delete, select the table data to be deleted", MsgBoxStyle.Critical, "Error Message")
            Return
        End If

        If MsgBox("Delete record?", MsgBoxStyle.Question + MsgBoxStyle.OkCancel, "Confirmation") = MsgBoxResult.Cancel Then Return

        Try
            Connection.Open()
        Catch ex As Exception
            MessageBox.Show("Connection failed !!!" & vbCrLf & "Please check that the server is ready !!!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End Try

        Try
            If AllCellsSelected(DataGridView3) = True Then
                MySQLCMD.CommandType = CommandType.Text
                MySQLCMD.CommandText = "DELETE FROM " & Table_Name
                MySQLCMD.Connection = Connection
                MySQLCMD.ExecuteNonQuery()
            End If

            For Each row As DataGridViewRow In DataGridView3.SelectedRows
                If row.Selected = True Then
                    MySQLCMD.CommandType = CommandType.Text
                    MySQLCMD.CommandText = "DELETE FROM " & Table_Name & " WHERE RFID_UID = '" & row.DataBoundItem(1).ToString & "'"
                    MySQLCMD.Connection = Connection
                    MySQLCMD.ExecuteNonQuery()
                End If
            Next
        Catch ex As Exception
            MsgBox("Failed to delete" & vbCr & ex.Message, MsgBoxStyle.Critical, "Error Message")
            Connection.Close()
        End Try
        Connection.Close()
        ShowDataInRegistration()
    End Sub

    'Delete in Search Panel'
    Private Sub DeleteToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem1.Click
        If DataGridView2.RowCount = 0 Then
            MsgBox("Cannot delete, table data is empty", MsgBoxStyle.Critical, "Error Message")
            Return
        End If

        If DataGridView2.SelectedRows.Count = 0 Then
            MsgBox("Cannot delete, select the table data to be deleted", MsgBoxStyle.Critical, "Error Message")
            Return
        End If

        If MsgBox("Delete record?", MsgBoxStyle.Question + MsgBoxStyle.OkCancel, "Confirmation") = MsgBoxResult.Cancel Then Return

        Try
            Connection.Open()
        Catch ex As Exception
            MessageBox.Show("Connection failed !!!" & vbCrLf & "Please check that the server is ready !!!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End Try

        Try
            If AllCellsSelected2(DataGridView2) = True Then
                MySQLCMD.CommandType = CommandType.Text
                MySQLCMD.CommandText = "DELETE FROM " & Table_Name2
                MySQLCMD.Connection = Connection
                MySQLCMD.ExecuteNonQuery()
            End If

            For Each row As DataGridViewRow In DataGridView2.SelectedRows
                If row.Selected = True Then
                    MySQLCMD.CommandType = CommandType.Text
                    MySQLCMD.CommandText = "DELETE FROM " & Table_Name2 & " WHERE RFID_UID = '" & row.DataBoundItem(1).ToString & "'"
                    MySQLCMD.Connection = Connection
                    MySQLCMD.ExecuteNonQuery()
                End If
            Next
        Catch ex As Exception
            MsgBox("Failed to delete" & vbCr & ex.Message, MsgBoxStyle.Critical, "Error Message")
            Connection.Close()
        End Try
        Connection.Close()
        ShowDataInSearch()
    End Sub

    Private Sub SelectALlToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectALlToolStripMenuItem.Click
        DataGridView3.SelectAll()

    End Sub

    Private Sub SelectAllToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles SelectAllToolStripMenuItem2.Click
        DataGridView2.SelectAll()
    End Sub

    Private Sub ClearSelectionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearSelectionToolStripMenuItem.Click
        DataGridView3.ClearSelection()

    End Sub

    Private Sub ClearSelectToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ClearSelectToolStripMenuItem3.Click
        DataGridView2.ClearSelection()
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshToolStripMenuItem.Click
        ShowDataInRegistration()

    End Sub

    Private Sub RefreshToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles RefreshToolStripMenuItem4.Click
        ShowDataInSearch()
    End Sub

    'To Read the RFID card'
    'Display the connected status'
    Private Sub TimerSerialIn_Tick(sender As Object, e As EventArgs) Handles TimerSerialIn.Tick
        Try
            StrSerialIn = SerialPort1.ReadExisting
            LabelConnectionStatus.Text = "Connection Status : Connected"
            If StrSerialIn <> "" Then
                If GetID = True Then
                    LabelGetID.Text = StrSerialIn
                    GetID = False
                    If LabelGetID.Text <> "____________" Then
                        PanelReadingTagProcess.Visible = False
                        IDCheck()
                    End If
                End If
                If ViewUserData = True Then
                    ViewData()
                End If
            End If
        Catch ex As Exception
            TimerSerialIn.Stop()
            SerialPort1.Close()
            LabelConnectionStatus.Text = "Connection Status : Disconnect"
            PictureBoxStatusConnect.Image = My.Resources.Disconnect
            MsgBox("Failed to connect !!!" & vbCr & "Arduino is not detected.", MsgBoxStyle.Critical, "Error Message")
            ButtonConnect_Click(sender, e)
            Return
        End Try

        If PictureBoxStatusConnect.Visible = True Then
            PictureBoxStatusConnect.Visible = False
        ElseIf PictureBoxStatusConnect.Visible = False Then
            PictureBoxStatusConnect.Visible = True
        End If
    End Sub

    'Check the RFID card if already exist in database'
    Private Sub IDCheck()
        Try
            Connection.Open()
        Catch ex As Exception
            MessageBox.Show("Connection failed !!!" & vbCrLf & "Please check that the server is ready !!!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End Try

        Try
            MySQLCMD.CommandType = CommandType.Text
            MySQLCMD.CommandText = "SELECT * FROM " & Table_Name & " WHERE RFID_UID ='" & LabelGetID.Text & "'"
            MySQLDA = New MySqlDataAdapter(MySQLCMD.CommandText, Connection)
            DT = New DataTable
            Data = MySQLDA.Fill(DT)
            If Data > 0 Then
                If MsgBox("RFID_UID registered !" & vbCr & "Do you want to edit the data ?", MsgBoxStyle.Question + MsgBoxStyle.OkCancel, "Confirmation") = MsgBoxResult.Cancel Then
                    DT = Nothing
                    Connection.Close()
                    ButtonScanID.Enabled = True
                    GetID = False
                    LabelGetID.Text = "________"
                    Return
                Else
                    TextBoxStudent_ID.Text = DT.Rows(0).Item("Student_ID")
                    TextBoxFirstname.Text = DT.Rows(0).Item("Firstname")
                    TextBoxMiddlename.Text = DT.Rows(0).Item("Middlename")
                    TextBoxLastname.Text = DT.Rows(0).Item("Lastname")
                    TextBoxAge.Text = DT.Rows(0).Item("Age")
                    ComboBoxDepartment.Text = DT.Rows(0).Item("Department")
                    ComboBoxCourse.Text = DT.Rows(0).Item("Course")
                    ComboBoxYear.Text = DT.Rows(0).Item("Year")
                    TextBoxParent_Number.Text = DT.Rows(0).Item("Parent_Number")
                    StatusInput = "Update"
                End If
            End If
        Catch ex As Exception
            MsgBox("Failed to load Database !!!" & vbCr & ex.Message, MsgBoxStyle.Critical, "Error Message")
            Connection.Close()
            Return
        End Try

        DT = Nothing
        Connection.Close()

        ButtonScanID.Enabled = True
        GetID = False
    End Sub

    'To display the RFID_UID in UserDetails'
    Private Sub ViewData()
        LabelID.Text = StrSerialIn
        If LabelID.Text = "" Then
            ViewData()
        Else
            ShowDataUser()
        End If
    End Sub

    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        PanelReadingTagProcess.Location = New Point((PanelRegistration.Width / 2) - (PanelReadingTagProcess.Width / 2), 106)
    End Sub

    Private Sub ButtonCloseReadingTag_Click(sender As Object, e As EventArgs) Handles ButtonCloseReadingTag.Click
        PanelReadingTagProcess.Visible = False
        ButtonScanID.Enabled = True
    End Sub

    Private Sub ComboBoxDepartment_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxDepartment.SelectedIndexChanged

        Select Case ComboBoxDepartment.SelectedItem.ToString()
            Case "College"
                ComboBoxCourse.Items.Clear()
                ComboBoxYear.Items.Clear()
                ComboBoxCourse.Items.Add("BSA")
                ComboBoxCourse.Items.Add("BSMA")
                ComboBoxCourse.Items.Add("BSAIS")
                ComboBoxCourse.Items.Add("BSENT")
                ComboBoxCourse.Items.Add("BSIS")
                ComboBoxCourse.Items.Add("BSDC")
                ComboBoxCourse.Items.Add("BSIT")
                ComboBoxCourse.Items.Add("BSHM")
                ComboBoxYear.Items.Add("1st Year")
                ComboBoxYear.Items.Add("2nd Year")
                ComboBoxYear.Items.Add("3rd Year")
                ComboBoxYear.Items.Add("4th Year")
            Case "Senior High"
                ComboBoxCourse.Items.Clear()
                ComboBoxYear.Items.Clear()
                ComboBoxCourse.Items.Add("ABM")
                ComboBoxCourse.Items.Add("HUMSS")
                ComboBoxCourse.Items.Add("STEM")
                ComboBoxYear.Items.Add("Grade 11")
                ComboBoxYear.Items.Add("Grade 12")
        End Select

    End Sub

    'Refresh DataGridView1 in every 1 second in Dashboard Panel'
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ' Retrieve new data from your data source (e.g. a SQL Server database)
        Dim newData As DataTable = GetData()

        ' Update the DataGridView with the new data
        DataGridView1.DataSource = newData

        DataGridView1.DefaultCellStyle.ForeColor = Color.Black
        DataGridView1.ClearSelection()
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
        DataGridView1.ColumnHeadersDefaultCellStyle.Font = New Font("Arial", 9, FontStyle.Bold)
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim dialog As DialogResult

        dialog = MessageBox.Show("Do you really want to close the app?", "Exit", MessageBoxButtons.YesNo)
        If dialog = DialogResult.No Then
            e.Cancel = True
        Else
            Application.ExitThread()
        End If
    End Sub

    'Search using DateTimePicker with Range'
    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click
        Dim selectedDateTime As DateTime = DateTimePicker1.Value
        Dim selectedDateTime2 As DateTime = DateTimePicker2.Value

        Dim selectedDateTimeString As String = selectedDateTime.ToString("yyyy-MM-dd")
        Dim selectedDateTimeString2 As String = selectedDateTime2.ToString("yyyy-MM-dd")

        ' Define the timestamp value to search for
        Dim searchTimestamp As DateTime = DateTime.Parse(selectedDateTimeString)
        Dim searchTimestamp2 As DateTime = DateTime.Parse(selectedDateTimeString2)

        ' Define the SQL query with a WHERE clause that filters by the timestamp field
        Dim query As String = "SELECT * FROM attendance WHERE Date BETWEEN @Date1 AND @Date2"

        ' Create a MySQL command object with the query and connection
        Dim command As New MySqlCommand(query, Connection)

        ' Set the value of the timestamp parameter in the query
        command.Parameters.AddWithValue("@Date1", searchTimestamp)
        command.Parameters.AddWithValue("@Date2", searchTimestamp2)

        ' Open the MySQL connection
        Connection.Open()

        ' Execute the query and retrieve the results
        Dim adapter As New MySqlDataAdapter(command)
        Dim results As New DataTable()
        adapter.Fill(results)

        ' Bind the DataTable results to the DataGridView
        DataGridView2.DataSource = results

        ' Close the MySQL connection
        Connection.Close()

    End Sub

    'Exit'
    Private Sub ButtonLogout_Click(sender As Object, e As EventArgs) Handles ButtonLogout.Click
        Dim dialog As DialogResult

        dialog = MessageBox.Show("Do you really want to Exit the app?", "Exit", MessageBoxButtons.YesNo)
        If dialog = DialogResult.No Then
            Me.Cancel = True
        Else
            Me.Hide() 'hide the current form
            Dim Form3 As New Form3() 'create an instance of the login form
            Form3.Show() 'show the login form
        End If

    End Sub
End Class

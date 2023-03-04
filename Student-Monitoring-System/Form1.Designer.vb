<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ButtonLogout = New System.Windows.Forms.Button()
        Me.ButtonSearch = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PictureBoxSelect = New System.Windows.Forms.PictureBox()
        Me.ButtonRegistration = New System.Windows.Forms.Button()
        Me.ButtonUserData = New System.Windows.Forms.Button()
        Me.ButtonConnection = New System.Windows.Forms.Button()
        Me.ButtonDashboard = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LabelConnectionStatus = New System.Windows.Forms.Label()
        Me.LabelDateTime = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PanelDashboard = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.PanelConnection = New System.Windows.Forms.Panel()
        Me.ButtonConnect = New System.Windows.Forms.Button()
        Me.ComboBoxBaudRate = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBoxPort = New System.Windows.Forms.ComboBox()
        Me.ButtonScanPort = New System.Windows.Forms.Button()
        Me.PanelUserData = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ButtonClear = New System.Windows.Forms.Button()
        Me.LabelID = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LabelYear = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.LabelParent_Number = New System.Windows.Forms.Label()
        Me.LabelCourse = New System.Windows.Forms.Label()
        Me.LabelDepartment = New System.Windows.Forms.Label()
        Me.LabelAge = New System.Windows.Forms.Label()
        Me.LabelLastname = New System.Windows.Forms.Label()
        Me.LabelMiddlename = New System.Windows.Forms.Label()
        Me.LabelFirstname = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PanelRegistration = New System.Windows.Forms.Panel()
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SelectALlToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearSelectionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RefreshToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PanelReadingTagProcess = New System.Windows.Forms.Panel()
        Me.ButtonCloseReadingTag = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.ComboBoxYear = New System.Windows.Forms.ComboBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.ComboBoxCourse = New System.Windows.Forms.ComboBox()
        Me.CheckBoxByID = New System.Windows.Forms.CheckBox()
        Me.CheckBoxByName = New System.Windows.Forms.CheckBox()
        Me.TextBoxSearch = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.LabelGetID = New System.Windows.Forms.Label()
        Me.ButtonScanID = New System.Windows.Forms.Button()
        Me.ButtonClearForm = New System.Windows.Forms.Button()
        Me.ButtonSave = New System.Windows.Forms.Button()
        Me.ComboBoxDepartment = New System.Windows.Forms.ComboBox()
        Me.TextBoxParent_Number = New System.Windows.Forms.TextBox()
        Me.TextBoxAge = New System.Windows.Forms.TextBox()
        Me.TextBoxLastname = New System.Windows.Forms.TextBox()
        Me.TextBoxMiddlename = New System.Windows.Forms.TextBox()
        Me.TextBoxFirstname = New System.Windows.Forms.TextBox()
        Me.TextBoxStudent_ID = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.FileSystemWatcher1 = New System.IO.FileSystemWatcher()
        Me.TimerTimeDate = New System.Windows.Forms.Timer(Me.components)
        Me.TimerSerialIn = New System.Windows.Forms.Timer(Me.components)
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.MySqlDataAdapter1 = New MySqlConnector.MySqlDataAdapter()
        Me.FileSystemWatcher2 = New System.IO.FileSystemWatcher()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.DirectoryEntry1 = New System.DirectoryServices.DirectoryEntry()
        Me.PanelSearch = New System.Windows.Forms.Panel()
        Me.BtnSearch = New System.Windows.Forms.Button()
        Me.CheckBoxSearchID = New System.Windows.Forms.CheckBox()
        Me.CheckBoxSearchName = New System.Windows.Forms.CheckBox()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.SearchTextBox = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.ContextMenuStrip2 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DeleteToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SelectAllToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearSelectToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.RefreshToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBoxStatusConnect = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBoxSelect, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelDashboard.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelConnection.SuspendLayout()
        Me.PanelUserData.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.PanelRegistration.SuspendLayout()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.PanelReadingTagProcess.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FileSystemWatcher2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelSearch.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip2.SuspendLayout()
        CType(Me.PictureBoxStatusConnect, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Panel1.Controls.Add(Me.ButtonLogout)
        Me.Panel1.Controls.Add(Me.ButtonSearch)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.PictureBoxSelect)
        Me.Panel1.Controls.Add(Me.ButtonRegistration)
        Me.Panel1.Controls.Add(Me.ButtonUserData)
        Me.Panel1.Controls.Add(Me.ButtonConnection)
        Me.Panel1.Controls.Add(Me.ButtonDashboard)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(239, 580)
        Me.Panel1.TabIndex = 0
        '
        'ButtonLogout
        '
        Me.ButtonLogout.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonLogout.Image = Global.Student_Monitoring_System.My.Resources.Resources._618316_arrow_exit_logout_sign_out_icon
        Me.ButtonLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonLogout.Location = New System.Drawing.Point(48, 500)
        Me.ButtonLogout.Name = "ButtonLogout"
        Me.ButtonLogout.Size = New System.Drawing.Size(182, 45)
        Me.ButtonLogout.TabIndex = 8
        Me.ButtonLogout.Text = "Logout"
        Me.ButtonLogout.UseVisualStyleBackColor = True
        '
        'ButtonSearch
        '
        Me.ButtonSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSearch.Image = Global.Student_Monitoring_System.My.Resources.Resources._314689_search_icon
        Me.ButtonSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonSearch.Location = New System.Drawing.Point(48, 220)
        Me.ButtonSearch.Name = "ButtonSearch"
        Me.ButtonSearch.Size = New System.Drawing.Size(182, 45)
        Me.ButtonSearch.TabIndex = 7
        Me.ButtonSearch.Text = "Search"
        Me.ButtonSearch.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.Location = New System.Drawing.Point(239, 19)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(200, 100)
        Me.Panel3.TabIndex = 5
        '
        'PictureBoxSelect
        '
        Me.PictureBoxSelect.Image = Global.Student_Monitoring_System.My.Resources.Resources._1564490_arrow_music_play_arrows_audio_icon
        Me.PictureBoxSelect.Location = New System.Drawing.Point(3, 150)
        Me.PictureBoxSelect.Name = "PictureBoxSelect"
        Me.PictureBoxSelect.Size = New System.Drawing.Size(42, 45)
        Me.PictureBoxSelect.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBoxSelect.TabIndex = 6
        Me.PictureBoxSelect.TabStop = False
        '
        'ButtonRegistration
        '
        Me.ButtonRegistration.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonRegistration.Image = Global.Student_Monitoring_System.My.Resources.Resources._1814113_add_more_plus_icon
        Me.ButtonRegistration.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonRegistration.Location = New System.Drawing.Point(48, 430)
        Me.ButtonRegistration.Name = "ButtonRegistration"
        Me.ButtonRegistration.Size = New System.Drawing.Size(182, 45)
        Me.ButtonRegistration.TabIndex = 5
        Me.ButtonRegistration.Text = "Registration/ Edit User"
        Me.ButtonRegistration.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonRegistration.UseVisualStyleBackColor = True
        '
        'ButtonUserData
        '
        Me.ButtonUserData.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonUserData.Image = Global.Student_Monitoring_System.My.Resources.Resources._1814089_account_user_person_profile_avatar_icon
        Me.ButtonUserData.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonUserData.Location = New System.Drawing.Point(48, 360)
        Me.ButtonUserData.Name = "ButtonUserData"
        Me.ButtonUserData.Size = New System.Drawing.Size(182, 45)
        Me.ButtonUserData.TabIndex = 4
        Me.ButtonUserData.Text = "User Details"
        Me.ButtonUserData.UseVisualStyleBackColor = True
        '
        'ButtonConnection
        '
        Me.ButtonConnection.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonConnection.Image = Global.Student_Monitoring_System.My.Resources.Resources._4064143_usb_connection_port_hardware_icon
        Me.ButtonConnection.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonConnection.Location = New System.Drawing.Point(48, 290)
        Me.ButtonConnection.Name = "ButtonConnection"
        Me.ButtonConnection.Size = New System.Drawing.Size(182, 45)
        Me.ButtonConnection.TabIndex = 3
        Me.ButtonConnection.Text = "Connection"
        Me.ButtonConnection.UseVisualStyleBackColor = True
        '
        'ButtonDashboard
        '
        Me.ButtonDashboard.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonDashboard.Image = Global.Student_Monitoring_System.My.Resources.Resources._4696652_analytics_dashboard_performance_speed_icon
        Me.ButtonDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonDashboard.Location = New System.Drawing.Point(48, 150)
        Me.ButtonDashboard.Name = "ButtonDashboard"
        Me.ButtonDashboard.Size = New System.Drawing.Size(182, 45)
        Me.ButtonDashboard.TabIndex = 7
        Me.ButtonDashboard.Text = "Dashboard"
        Me.ButtonDashboard.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Student_Monitoring_System.My.Resources.Resources.NBSPI_logo
        Me.PictureBox1.Location = New System.Drawing.Point(48, 20)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(142, 99)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'LabelConnectionStatus
        '
        Me.LabelConnectionStatus.AutoSize = True
        Me.LabelConnectionStatus.Location = New System.Drawing.Point(246, 0)
        Me.LabelConnectionStatus.Name = "LabelConnectionStatus"
        Me.LabelConnectionStatus.Size = New System.Drawing.Size(157, 13)
        Me.LabelConnectionStatus.TabIndex = 1
        Me.LabelConnectionStatus.Text = "Connection Status : Disconnect"
        '
        'LabelDateTime
        '
        Me.LabelDateTime.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelDateTime.AutoSize = True
        Me.LabelDateTime.Location = New System.Drawing.Point(1130, 0)
        Me.LabelDateTime.Name = "LabelDateTime"
        Me.LabelDateTime.Size = New System.Drawing.Size(168, 13)
        Me.LabelDateTime.TabIndex = 3
        Me.LabelDateTime.Text = "Time 00:00:00  Date 00 mm, 0000"
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.SystemColors.Highlight
        Me.Panel2.Location = New System.Drawing.Point(240, 14)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1071, 5)
        Me.Panel2.TabIndex = 4
        '
        'PanelDashboard
        '
        Me.PanelDashboard.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelDashboard.Controls.Add(Me.DataGridView1)
        Me.PanelDashboard.Location = New System.Drawing.Point(243, 22)
        Me.PanelDashboard.Name = "PanelDashboard"
        Me.PanelDashboard.Size = New System.Drawing.Size(1077, 560)
        Me.PanelDashboard.TabIndex = 5
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(9, 17)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowTemplate.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(1046, 529)
        Me.DataGridView1.TabIndex = 0
        '
        'PanelConnection
        '
        Me.PanelConnection.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelConnection.Controls.Add(Me.ButtonConnect)
        Me.PanelConnection.Controls.Add(Me.ComboBoxBaudRate)
        Me.PanelConnection.Controls.Add(Me.Label1)
        Me.PanelConnection.Controls.Add(Me.ComboBoxPort)
        Me.PanelConnection.Controls.Add(Me.ButtonScanPort)
        Me.PanelConnection.Location = New System.Drawing.Point(243, 22)
        Me.PanelConnection.Name = "PanelConnection"
        Me.PanelConnection.Size = New System.Drawing.Size(1068, 560)
        Me.PanelConnection.TabIndex = 2
        '
        'ButtonConnect
        '
        Me.ButtonConnect.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonConnect.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonConnect.Location = New System.Drawing.Point(50, 104)
        Me.ButtonConnect.Name = "ButtonConnect"
        Me.ButtonConnect.Size = New System.Drawing.Size(711, 34)
        Me.ButtonConnect.TabIndex = 11
        Me.ButtonConnect.Text = "Connect"
        Me.ButtonConnect.UseVisualStyleBackColor = True
        '
        'ComboBoxBaudRate
        '
        Me.ComboBoxBaudRate.FormattingEnabled = True
        Me.ComboBoxBaudRate.Items.AddRange(New Object() {"1200", "1400", "4800", "9600", "14400", "19200", "38400", "57600", "115200"})
        Me.ComboBoxBaudRate.Location = New System.Drawing.Point(619, 42)
        Me.ComboBoxBaudRate.Name = "ComboBoxBaudRate"
        Me.ComboBoxBaudRate.Size = New System.Drawing.Size(131, 21)
        Me.ComboBoxBaudRate.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(514, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 18)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Baud Rate :"
        '
        'ComboBoxPort
        '
        Me.ComboBoxPort.FormattingEnabled = True
        Me.ComboBoxPort.Location = New System.Drawing.Point(213, 42)
        Me.ComboBoxPort.Name = "ComboBoxPort"
        Me.ComboBoxPort.Size = New System.Drawing.Size(215, 21)
        Me.ComboBoxPort.TabIndex = 8
        '
        'ButtonScanPort
        '
        Me.ButtonScanPort.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonScanPort.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonScanPort.Location = New System.Drawing.Point(50, 33)
        Me.ButtonScanPort.Name = "ButtonScanPort"
        Me.ButtonScanPort.Size = New System.Drawing.Size(144, 34)
        Me.ButtonScanPort.TabIndex = 7
        Me.ButtonScanPort.Text = "Scan Port"
        Me.ButtonScanPort.UseVisualStyleBackColor = True
        '
        'PanelUserData
        '
        Me.PanelUserData.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelUserData.Controls.Add(Me.Label2)
        Me.PanelUserData.Controls.Add(Me.ButtonClear)
        Me.PanelUserData.Controls.Add(Me.LabelID)
        Me.PanelUserData.Controls.Add(Me.GroupBox1)
        Me.PanelUserData.Location = New System.Drawing.Point(243, 22)
        Me.PanelUserData.Name = "PanelUserData"
        Me.PanelUserData.Size = New System.Drawing.Size(1068, 560)
        Me.PanelUserData.TabIndex = 12
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(336, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 20)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "RFID_UID : "
        '
        'ButtonClear
        '
        Me.ButtonClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonClear.Location = New System.Drawing.Point(789, 459)
        Me.ButtonClear.Name = "ButtonClear"
        Me.ButtonClear.Size = New System.Drawing.Size(144, 34)
        Me.ButtonClear.TabIndex = 8
        Me.ButtonClear.Text = "Clear"
        Me.ButtonClear.UseVisualStyleBackColor = True
        '
        'LabelID
        '
        Me.LabelID.AutoSize = True
        Me.LabelID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelID.Location = New System.Drawing.Point(431, 81)
        Me.LabelID.Name = "LabelID"
        Me.LabelID.Size = New System.Drawing.Size(135, 20)
        Me.LabelID.TabIndex = 1
        Me.LabelID.Text = "______________"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LabelYear)
        Me.GroupBox1.Controls.Add(Me.Label22)
        Me.GroupBox1.Controls.Add(Me.LabelParent_Number)
        Me.GroupBox1.Controls.Add(Me.LabelCourse)
        Me.GroupBox1.Controls.Add(Me.LabelDepartment)
        Me.GroupBox1.Controls.Add(Me.LabelAge)
        Me.GroupBox1.Controls.Add(Me.LabelLastname)
        Me.GroupBox1.Controls.Add(Me.LabelMiddlename)
        Me.GroupBox1.Controls.Add(Me.LabelFirstname)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(128, 123)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(651, 355)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "User Details :"
        '
        'LabelYear
        '
        Me.LabelYear.AutoSize = True
        Me.LabelYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelYear.Location = New System.Drawing.Point(183, 277)
        Me.LabelYear.Name = "LabelYear"
        Me.LabelYear.Size = New System.Drawing.Size(74, 20)
        Me.LabelYear.TabIndex = 17
        Me.LabelYear.Text = "Waiting..."
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(18, 277)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(51, 20)
        Me.Label22.TabIndex = 16
        Me.Label22.Text = "Year :"
        '
        'LabelParent_Number
        '
        Me.LabelParent_Number.AutoSize = True
        Me.LabelParent_Number.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelParent_Number.Location = New System.Drawing.Point(183, 312)
        Me.LabelParent_Number.Name = "LabelParent_Number"
        Me.LabelParent_Number.Size = New System.Drawing.Size(74, 20)
        Me.LabelParent_Number.TabIndex = 15
        Me.LabelParent_Number.Text = "Waiting..."
        '
        'LabelCourse
        '
        Me.LabelCourse.AutoSize = True
        Me.LabelCourse.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCourse.Location = New System.Drawing.Point(183, 234)
        Me.LabelCourse.Name = "LabelCourse"
        Me.LabelCourse.Size = New System.Drawing.Size(74, 20)
        Me.LabelCourse.TabIndex = 14
        Me.LabelCourse.Text = "Waiting..."
        '
        'LabelDepartment
        '
        Me.LabelDepartment.AutoSize = True
        Me.LabelDepartment.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDepartment.Location = New System.Drawing.Point(183, 196)
        Me.LabelDepartment.Name = "LabelDepartment"
        Me.LabelDepartment.Size = New System.Drawing.Size(74, 20)
        Me.LabelDepartment.TabIndex = 13
        Me.LabelDepartment.Text = "Waiting..."
        '
        'LabelAge
        '
        Me.LabelAge.AutoSize = True
        Me.LabelAge.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelAge.Location = New System.Drawing.Point(183, 157)
        Me.LabelAge.Name = "LabelAge"
        Me.LabelAge.Size = New System.Drawing.Size(74, 20)
        Me.LabelAge.TabIndex = 12
        Me.LabelAge.Text = "Waiting..."
        '
        'LabelLastname
        '
        Me.LabelLastname.AutoSize = True
        Me.LabelLastname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelLastname.Location = New System.Drawing.Point(183, 114)
        Me.LabelLastname.Name = "LabelLastname"
        Me.LabelLastname.Size = New System.Drawing.Size(74, 20)
        Me.LabelLastname.TabIndex = 11
        Me.LabelLastname.Text = "Waiting..."
        '
        'LabelMiddlename
        '
        Me.LabelMiddlename.AutoSize = True
        Me.LabelMiddlename.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelMiddlename.Location = New System.Drawing.Point(183, 70)
        Me.LabelMiddlename.Name = "LabelMiddlename"
        Me.LabelMiddlename.Size = New System.Drawing.Size(74, 20)
        Me.LabelMiddlename.TabIndex = 10
        Me.LabelMiddlename.Text = "Waiting..."
        '
        'LabelFirstname
        '
        Me.LabelFirstname.AutoSize = True
        Me.LabelFirstname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelFirstname.Location = New System.Drawing.Point(183, 27)
        Me.LabelFirstname.Name = "LabelFirstname"
        Me.LabelFirstname.Size = New System.Drawing.Size(74, 20)
        Me.LabelFirstname.TabIndex = 9
        Me.LabelFirstname.Text = "Waiting..."
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(18, 312)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(124, 20)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "Parent Number :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(18, 234)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(68, 20)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Course :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(18, 196)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(102, 20)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Department :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(18, 157)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 20)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Age :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(18, 114)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 20)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Lastname :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(18, 70)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(103, 20)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Middlename :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(18, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 20)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Firstname :"
        '
        'PanelRegistration
        '
        Me.PanelRegistration.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelRegistration.Controls.Add(Me.DataGridView3)
        Me.PanelRegistration.Controls.Add(Me.PanelReadingTagProcess)
        Me.PanelRegistration.Controls.Add(Me.ComboBoxYear)
        Me.PanelRegistration.Controls.Add(Me.Label21)
        Me.PanelRegistration.Controls.Add(Me.ComboBoxCourse)
        Me.PanelRegistration.Controls.Add(Me.CheckBoxByID)
        Me.PanelRegistration.Controls.Add(Me.CheckBoxByName)
        Me.PanelRegistration.Controls.Add(Me.TextBoxSearch)
        Me.PanelRegistration.Controls.Add(Me.Label18)
        Me.PanelRegistration.Controls.Add(Me.GroupBox2)
        Me.PanelRegistration.Controls.Add(Me.ButtonClearForm)
        Me.PanelRegistration.Controls.Add(Me.ButtonSave)
        Me.PanelRegistration.Controls.Add(Me.ComboBoxDepartment)
        Me.PanelRegistration.Controls.Add(Me.TextBoxParent_Number)
        Me.PanelRegistration.Controls.Add(Me.TextBoxAge)
        Me.PanelRegistration.Controls.Add(Me.TextBoxLastname)
        Me.PanelRegistration.Controls.Add(Me.TextBoxMiddlename)
        Me.PanelRegistration.Controls.Add(Me.TextBoxFirstname)
        Me.PanelRegistration.Controls.Add(Me.TextBoxStudent_ID)
        Me.PanelRegistration.Controls.Add(Me.Label17)
        Me.PanelRegistration.Controls.Add(Me.Label16)
        Me.PanelRegistration.Controls.Add(Me.Label15)
        Me.PanelRegistration.Controls.Add(Me.Label14)
        Me.PanelRegistration.Controls.Add(Me.Label13)
        Me.PanelRegistration.Controls.Add(Me.Label12)
        Me.PanelRegistration.Controls.Add(Me.Label11)
        Me.PanelRegistration.Controls.Add(Me.Label10)
        Me.PanelRegistration.Location = New System.Drawing.Point(243, 22)
        Me.PanelRegistration.Name = "PanelRegistration"
        Me.PanelRegistration.Size = New System.Drawing.Size(1068, 560)
        Me.PanelRegistration.TabIndex = 13
        '
        'DataGridView3
        '
        Me.DataGridView3.AllowUserToAddRows = False
        Me.DataGridView3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.ContextMenuStrip = Me.ContextMenuStrip1
        Me.DataGridView3.Location = New System.Drawing.Point(6, 380)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.ReadOnly = True
        Me.DataGridView3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView3.Size = New System.Drawing.Size(1040, 166)
        Me.DataGridView3.TabIndex = 29
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DeleteToolStripMenuItem, Me.SelectALlToolStripMenuItem, Me.ClearSelectionToolStripMenuItem, Me.RefreshToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(153, 92)
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Image = Global.Student_Monitoring_System.My.Resources.Resources._2303123_bin_delete_garbage_remove_trash_icon
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'SelectALlToolStripMenuItem
        '
        Me.SelectALlToolStripMenuItem.Image = Global.Student_Monitoring_System.My.Resources.Resources._1055094_check_select_icon
        Me.SelectALlToolStripMenuItem.Name = "SelectALlToolStripMenuItem"
        Me.SelectALlToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SelectALlToolStripMenuItem.Text = "Select All"
        '
        'ClearSelectionToolStripMenuItem
        '
        Me.ClearSelectionToolStripMenuItem.Image = Global.Student_Monitoring_System.My.Resources.Resources._2303198_delete_email_junk_mail_spam_icon
        Me.ClearSelectionToolStripMenuItem.Name = "ClearSelectionToolStripMenuItem"
        Me.ClearSelectionToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ClearSelectionToolStripMenuItem.Text = "Clear Selection"
        '
        'RefreshToolStripMenuItem
        '
        Me.RefreshToolStripMenuItem.Image = Global.Student_Monitoring_System.My.Resources.Resources._9027543_rotate_refresh_icon
        Me.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem"
        Me.RefreshToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.RefreshToolStripMenuItem.Text = "Refresh"
        '
        'PanelReadingTagProcess
        '
        Me.PanelReadingTagProcess.BackColor = System.Drawing.Color.White
        Me.PanelReadingTagProcess.Controls.Add(Me.ButtonCloseReadingTag)
        Me.PanelReadingTagProcess.Controls.Add(Me.PictureBox2)
        Me.PanelReadingTagProcess.Controls.Add(Me.Label19)
        Me.PanelReadingTagProcess.Location = New System.Drawing.Point(323, 170)
        Me.PanelReadingTagProcess.Name = "PanelReadingTagProcess"
        Me.PanelReadingTagProcess.Size = New System.Drawing.Size(280, 159)
        Me.PanelReadingTagProcess.TabIndex = 25
        Me.PanelReadingTagProcess.Visible = False
        '
        'ButtonCloseReadingTag
        '
        Me.ButtonCloseReadingTag.Image = Global.Student_Monitoring_System.My.Resources.Resources._1398919_close_cross_incorrect_invalid_x_icon
        Me.ButtonCloseReadingTag.Location = New System.Drawing.Point(243, 6)
        Me.ButtonCloseReadingTag.Name = "ButtonCloseReadingTag"
        Me.ButtonCloseReadingTag.Size = New System.Drawing.Size(34, 23)
        Me.ButtonCloseReadingTag.TabIndex = 2
        Me.ButtonCloseReadingTag.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Student_Monitoring_System.My.Resources.Resources._5
        Me.PictureBox2.Location = New System.Drawing.Point(91, 63)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(113, 64)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(3, 6)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(96, 16)
        Me.Label19.TabIndex = 0
        Me.Label19.Text = "Reading Tag..."
        '
        'ComboBoxYear
        '
        Me.ComboBoxYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxYear.FormattingEnabled = True
        Me.ComboBoxYear.Location = New System.Drawing.Point(605, 144)
        Me.ComboBoxYear.Name = "ComboBoxYear"
        Me.ComboBoxYear.Size = New System.Drawing.Size(174, 24)
        Me.ComboBoxYear.TabIndex = 28
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(442, 147)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(51, 20)
        Me.Label21.TabIndex = 27
        Me.Label21.Text = "Year :"
        '
        'ComboBoxCourse
        '
        Me.ComboBoxCourse.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxCourse.FormattingEnabled = True
        Me.ComboBoxCourse.Location = New System.Drawing.Point(605, 100)
        Me.ComboBoxCourse.Name = "ComboBoxCourse"
        Me.ComboBoxCourse.Size = New System.Drawing.Size(174, 24)
        Me.ComboBoxCourse.TabIndex = 26
        '
        'CheckBoxByID
        '
        Me.CheckBoxByID.AutoSize = True
        Me.CheckBoxByID.Location = New System.Drawing.Point(435, 359)
        Me.CheckBoxByID.Name = "CheckBoxByID"
        Me.CheckBoxByID.Size = New System.Drawing.Size(131, 17)
        Me.CheckBoxByID.TabIndex = 24
        Me.CheckBoxByID.Text = "Search by Student_ID"
        Me.CheckBoxByID.UseVisualStyleBackColor = True
        '
        'CheckBoxByName
        '
        Me.CheckBoxByName.AutoSize = True
        Me.CheckBoxByName.Checked = True
        Me.CheckBoxByName.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBoxByName.Location = New System.Drawing.Point(323, 359)
        Me.CheckBoxByName.Name = "CheckBoxByName"
        Me.CheckBoxByName.Size = New System.Drawing.Size(105, 17)
        Me.CheckBoxByName.TabIndex = 23
        Me.CheckBoxByName.Text = "Search by Name"
        Me.CheckBoxByName.UseVisualStyleBackColor = True
        '
        'TextBoxSearch
        '
        Me.TextBoxSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxSearch.Location = New System.Drawing.Point(136, 355)
        Me.TextBoxSearch.Name = "TextBoxSearch"
        Me.TextBoxSearch.Size = New System.Drawing.Size(164, 23)
        Me.TextBoxSearch.TabIndex = 22
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(33, 357)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(107, 20)
        Me.Label18.TabIndex = 21
        Me.Label18.Text = "Search Here :"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label20)
        Me.GroupBox2.Controls.Add(Me.LabelGetID)
        Me.GroupBox2.Controls.Add(Me.ButtonScanID)
        Me.GroupBox2.Location = New System.Drawing.Point(666, 237)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(202, 123)
        Me.GroupBox2.TabIndex = 19
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Get UID :"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(6, 84)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(46, 20)
        Me.Label20.TabIndex = 11
        Me.Label20.Text = "UID :"
        '
        'LabelGetID
        '
        Me.LabelGetID.AutoSize = True
        Me.LabelGetID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelGetID.Location = New System.Drawing.Point(58, 84)
        Me.LabelGetID.Name = "LabelGetID"
        Me.LabelGetID.Size = New System.Drawing.Size(117, 20)
        Me.LabelGetID.TabIndex = 10
        Me.LabelGetID.Text = "____________"
        '
        'ButtonScanID
        '
        Me.ButtonScanID.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonScanID.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonScanID.Location = New System.Drawing.Point(31, 19)
        Me.ButtonScanID.Name = "ButtonScanID"
        Me.ButtonScanID.Size = New System.Drawing.Size(144, 34)
        Me.ButtonScanID.TabIndex = 9
        Me.ButtonScanID.Text = "Scan"
        Me.ButtonScanID.UseVisualStyleBackColor = True
        '
        'ButtonClearForm
        '
        Me.ButtonClearForm.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonClearForm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonClearForm.Location = New System.Drawing.Point(255, 204)
        Me.ButtonClearForm.Name = "ButtonClearForm"
        Me.ButtonClearForm.Size = New System.Drawing.Size(144, 34)
        Me.ButtonClearForm.TabIndex = 18
        Me.ButtonClearForm.Text = "Clear"
        Me.ButtonClearForm.UseVisualStyleBackColor = True
        '
        'ButtonSave
        '
        Me.ButtonSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonSave.Location = New System.Drawing.Point(48, 204)
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.Size = New System.Drawing.Size(144, 34)
        Me.ButtonSave.TabIndex = 17
        Me.ButtonSave.Text = "Save"
        Me.ButtonSave.UseVisualStyleBackColor = True
        '
        'ComboBoxDepartment
        '
        Me.ComboBoxDepartment.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxDepartment.FormattingEnabled = True
        Me.ComboBoxDepartment.Items.AddRange(New Object() {"College", "Senior High"})
        Me.ComboBoxDepartment.Location = New System.Drawing.Point(605, 52)
        Me.ComboBoxDepartment.Name = "ComboBoxDepartment"
        Me.ComboBoxDepartment.Size = New System.Drawing.Size(174, 24)
        Me.ComboBoxDepartment.TabIndex = 16
        '
        'TextBoxParent_Number
        '
        Me.TextBoxParent_Number.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxParent_Number.Location = New System.Drawing.Point(605, 181)
        Me.TextBoxParent_Number.MaxLength = 11
        Me.TextBoxParent_Number.Name = "TextBoxParent_Number"
        Me.TextBoxParent_Number.Size = New System.Drawing.Size(251, 23)
        Me.TextBoxParent_Number.TabIndex = 15
        '
        'TextBoxAge
        '
        Me.TextBoxAge.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxAge.Location = New System.Drawing.Point(605, 15)
        Me.TextBoxAge.MaxLength = 2
        Me.TextBoxAge.Name = "TextBoxAge"
        Me.TextBoxAge.Size = New System.Drawing.Size(174, 23)
        Me.TextBoxAge.TabIndex = 12
        '
        'TextBoxLastname
        '
        Me.TextBoxLastname.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxLastname.Location = New System.Drawing.Point(146, 144)
        Me.TextBoxLastname.Name = "TextBoxLastname"
        Me.TextBoxLastname.Size = New System.Drawing.Size(251, 23)
        Me.TextBoxLastname.TabIndex = 11
        '
        'TextBoxMiddlename
        '
        Me.TextBoxMiddlename.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxMiddlename.Location = New System.Drawing.Point(146, 100)
        Me.TextBoxMiddlename.Name = "TextBoxMiddlename"
        Me.TextBoxMiddlename.Size = New System.Drawing.Size(251, 23)
        Me.TextBoxMiddlename.TabIndex = 10
        '
        'TextBoxFirstname
        '
        Me.TextBoxFirstname.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxFirstname.Location = New System.Drawing.Point(148, 56)
        Me.TextBoxFirstname.Name = "TextBoxFirstname"
        Me.TextBoxFirstname.Size = New System.Drawing.Size(251, 23)
        Me.TextBoxFirstname.TabIndex = 9
        '
        'TextBoxStudent_ID
        '
        Me.TextBoxStudent_ID.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxStudent_ID.Location = New System.Drawing.Point(146, 15)
        Me.TextBoxStudent_ID.Name = "TextBoxStudent_ID"
        Me.TextBoxStudent_ID.Size = New System.Drawing.Size(251, 23)
        Me.TextBoxStudent_ID.TabIndex = 8
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(442, 181)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(124, 20)
        Me.Label17.TabIndex = 7
        Me.Label17.Text = "Parent Number :"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(442, 100)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(68, 20)
        Me.Label16.TabIndex = 6
        Me.Label16.Text = "Course :"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(442, 56)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(102, 20)
        Me.Label15.TabIndex = 5
        Me.Label15.Text = "Department :"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(442, 15)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(46, 20)
        Me.Label14.TabIndex = 4
        Me.Label14.Text = "Age :"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(21, 147)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(88, 20)
        Me.Label13.TabIndex = 3
        Me.Label13.Text = "Lastname :"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(21, 100)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(103, 20)
        Me.Label12.TabIndex = 2
        Me.Label12.Text = "Middlename :"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(21, 56)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(88, 20)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "Firstname :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(21, 15)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(95, 20)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Student ID :"
        '
        'FileSystemWatcher1
        '
        Me.FileSystemWatcher1.EnableRaisingEvents = True
        Me.FileSystemWatcher1.SynchronizingObject = Me
        '
        'TimerTimeDate
        '
        Me.TimerTimeDate.Enabled = True
        '
        'TimerSerialIn
        '
        '
        'MySqlDataAdapter1
        '
        Me.MySqlDataAdapter1.DeleteCommand = Nothing
        Me.MySqlDataAdapter1.InsertCommand = Nothing
        Me.MySqlDataAdapter1.SelectCommand = Nothing
        Me.MySqlDataAdapter1.UpdateBatchSize = 0
        Me.MySqlDataAdapter1.UpdateCommand = Nothing
        '
        'FileSystemWatcher2
        '
        Me.FileSystemWatcher2.EnableRaisingEvents = True
        Me.FileSystemWatcher2.SynchronizingObject = Me
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'PanelSearch
        '
        Me.PanelSearch.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelSearch.Controls.Add(Me.BtnSearch)
        Me.PanelSearch.Controls.Add(Me.CheckBoxSearchID)
        Me.PanelSearch.Controls.Add(Me.CheckBoxSearchName)
        Me.PanelSearch.Controls.Add(Me.DateTimePicker2)
        Me.PanelSearch.Controls.Add(Me.DateTimePicker1)
        Me.PanelSearch.Controls.Add(Me.SearchTextBox)
        Me.PanelSearch.Controls.Add(Me.Label23)
        Me.PanelSearch.Controls.Add(Me.DataGridView2)
        Me.PanelSearch.Location = New System.Drawing.Point(243, 22)
        Me.PanelSearch.Name = "PanelSearch"
        Me.PanelSearch.Size = New System.Drawing.Size(1068, 560)
        Me.PanelSearch.TabIndex = 1
        '
        'BtnSearch
        '
        Me.BtnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSearch.Location = New System.Drawing.Point(631, 38)
        Me.BtnSearch.Name = "BtnSearch"
        Me.BtnSearch.Size = New System.Drawing.Size(87, 38)
        Me.BtnSearch.TabIndex = 7
        Me.BtnSearch.Text = "Search"
        Me.BtnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BtnSearch.UseVisualStyleBackColor = True
        '
        'CheckBoxSearchID
        '
        Me.CheckBoxSearchID.AutoSize = True
        Me.CheckBoxSearchID.Location = New System.Drawing.Point(572, 100)
        Me.CheckBoxSearchID.Name = "CheckBoxSearchID"
        Me.CheckBoxSearchID.Size = New System.Drawing.Size(132, 17)
        Me.CheckBoxSearchID.TabIndex = 6
        Me.CheckBoxSearchID.Text = "Search By Student_ID"
        Me.CheckBoxSearchID.UseVisualStyleBackColor = True
        '
        'CheckBoxSearchName
        '
        Me.CheckBoxSearchName.AutoSize = True
        Me.CheckBoxSearchName.Checked = True
        Me.CheckBoxSearchName.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBoxSearchName.Location = New System.Drawing.Point(460, 100)
        Me.CheckBoxSearchName.Name = "CheckBoxSearchName"
        Me.CheckBoxSearchName.Size = New System.Drawing.Size(106, 17)
        Me.CheckBoxSearchName.TabIndex = 5
        Me.CheckBoxSearchName.Text = "Search By Name"
        Me.CheckBoxSearchName.UseVisualStyleBackColor = True
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.CustomFormat = "yyyy-MM-dd"
        Me.DateTimePicker2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker2.Location = New System.Drawing.Point(414, 48)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(200, 24)
        Me.DateTimePicker2.TabIndex = 4
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "yyyy-MM-dd"
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(185, 48)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 24)
        Me.DateTimePicker1.TabIndex = 3
        '
        'SearchTextBox
        '
        Me.SearchTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchTextBox.Location = New System.Drawing.Point(276, 94)
        Me.SearchTextBox.Name = "SearchTextBox"
        Me.SearchTextBox.Size = New System.Drawing.Size(169, 23)
        Me.SearchTextBox.TabIndex = 2
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(202, 97)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(68, 20)
        Me.Label23.TabIndex = 1
        Me.Label23.Text = "Search :"
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.ContextMenuStrip = Me.ContextMenuStrip2
        Me.DataGridView2.Location = New System.Drawing.Point(9, 123)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView2.Size = New System.Drawing.Size(1046, 423)
        Me.DataGridView2.TabIndex = 0
        '
        'ContextMenuStrip2
        '
        Me.ContextMenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DeleteToolStripMenuItem1, Me.SelectAllToolStripMenuItem2, Me.ClearSelectToolStripMenuItem3, Me.RefreshToolStripMenuItem4})
        Me.ContextMenuStrip2.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip2.Size = New System.Drawing.Size(153, 92)
        '
        'DeleteToolStripMenuItem1
        '
        Me.DeleteToolStripMenuItem1.Image = Global.Student_Monitoring_System.My.Resources.Resources._2303123_bin_delete_garbage_remove_trash_icon
        Me.DeleteToolStripMenuItem1.Name = "DeleteToolStripMenuItem1"
        Me.DeleteToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.DeleteToolStripMenuItem1.Text = "Delete"
        '
        'SelectAllToolStripMenuItem2
        '
        Me.SelectAllToolStripMenuItem2.Image = Global.Student_Monitoring_System.My.Resources.Resources._1055094_check_select_icon
        Me.SelectAllToolStripMenuItem2.Name = "SelectAllToolStripMenuItem2"
        Me.SelectAllToolStripMenuItem2.Size = New System.Drawing.Size(152, 22)
        Me.SelectAllToolStripMenuItem2.Text = "Select All"
        '
        'ClearSelectToolStripMenuItem3
        '
        Me.ClearSelectToolStripMenuItem3.Image = Global.Student_Monitoring_System.My.Resources.Resources._2303198_delete_email_junk_mail_spam_icon
        Me.ClearSelectToolStripMenuItem3.Name = "ClearSelectToolStripMenuItem3"
        Me.ClearSelectToolStripMenuItem3.Size = New System.Drawing.Size(152, 22)
        Me.ClearSelectToolStripMenuItem3.Text = "Clear Selection"
        '
        'RefreshToolStripMenuItem4
        '
        Me.RefreshToolStripMenuItem4.Image = Global.Student_Monitoring_System.My.Resources.Resources._9027543_rotate_refresh_icon
        Me.RefreshToolStripMenuItem4.Name = "RefreshToolStripMenuItem4"
        Me.RefreshToolStripMenuItem4.Size = New System.Drawing.Size(152, 22)
        Me.RefreshToolStripMenuItem4.Text = "Refresh"
        '
        'PictureBoxStatusConnect
        '
        Me.PictureBoxStatusConnect.Image = Global.Student_Monitoring_System.My.Resources.Resources.Disconnect
        Me.PictureBoxStatusConnect.Location = New System.Drawing.Point(409, 0)
        Me.PictureBoxStatusConnect.Name = "PictureBoxStatusConnect"
        Me.PictureBoxStatusConnect.Size = New System.Drawing.Size(20, 13)
        Me.PictureBoxStatusConnect.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxStatusConnect.TabIndex = 2
        Me.PictureBoxStatusConnect.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1310, 580)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.LabelDateTime)
        Me.Controls.Add(Me.PictureBoxStatusConnect)
        Me.Controls.Add(Me.LabelConnectionStatus)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PanelDashboard)
        Me.Controls.Add(Me.PanelRegistration)
        Me.Controls.Add(Me.PanelUserData)
        Me.Controls.Add(Me.PanelConnection)
        Me.Controls.Add(Me.PanelSearch)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Student Monitoring System"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBoxSelect, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelDashboard.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelConnection.ResumeLayout(False)
        Me.PanelConnection.PerformLayout()
        Me.PanelUserData.ResumeLayout(False)
        Me.PanelUserData.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.PanelRegistration.ResumeLayout(False)
        Me.PanelRegistration.PerformLayout()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.PanelReadingTagProcess.ResumeLayout(False)
        Me.PanelReadingTagProcess.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FileSystemWatcher2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelSearch.ResumeLayout(False)
        Me.PanelSearch.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip2.ResumeLayout(False)
        CType(Me.PictureBoxStatusConnect, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ButtonDashboard As Button
    Friend WithEvents ButtonUserData As Button
    Friend WithEvents ButtonConnection As Button
    Friend WithEvents ButtonRegistration As Button
    Friend WithEvents PictureBoxSelect As PictureBox
    Friend WithEvents LabelConnectionStatus As Label
    Friend WithEvents PictureBoxStatusConnect As PictureBox
    Friend WithEvents LabelDateTime As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PanelDashboard As Panel
    Friend WithEvents PanelConnection As Panel
    Friend WithEvents ButtonConnect As Button
    Friend WithEvents ComboBoxBaudRate As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBoxPort As ComboBox
    Friend WithEvents ButtonScanPort As Button
    Friend WithEvents PanelUserData As Panel
    Friend WithEvents LabelID As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents LabelParent_Number As Label
    Friend WithEvents LabelCourse As Label
    Friend WithEvents LabelDepartment As Label
    Friend WithEvents LabelAge As Label
    Friend WithEvents LabelLastname As Label
    Friend WithEvents LabelMiddlename As Label
    Friend WithEvents LabelFirstname As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ButtonClear As Button
    Friend WithEvents PanelRegistration As Panel
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents LabelGetID As Label
    Friend WithEvents ButtonScanID As Button
    Friend WithEvents ButtonClearForm As Button
    Friend WithEvents ButtonSave As Button
    Friend WithEvents ComboBoxDepartment As ComboBox
    Friend WithEvents TextBoxParent_Number As TextBox
    Friend WithEvents TextBoxAge As TextBox
    Friend WithEvents TextBoxLastname As TextBox
    Friend WithEvents TextBoxMiddlename As TextBox
    Friend WithEvents TextBoxFirstname As TextBox
    Friend WithEvents TextBoxStudent_ID As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents CheckBoxByID As CheckBox
    Friend WithEvents CheckBoxByName As CheckBox
    Friend WithEvents TextBoxSearch As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents FileSystemWatcher1 As IO.FileSystemWatcher
    Friend WithEvents PanelReadingTagProcess As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label19 As Label
    Friend WithEvents ButtonCloseReadingTag As Button
    Friend WithEvents TimerTimeDate As Timer
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents DeleteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SelectALlToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClearSelectionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RefreshToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TimerSerialIn As Timer
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents Label20 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents MySqlDataAdapter1 As MySqlConnector.MySqlDataAdapter
    Friend WithEvents FileSystemWatcher2 As IO.FileSystemWatcher
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ComboBoxCourse As ComboBox
    Friend WithEvents ComboBoxYear As ComboBox
    Friend WithEvents Label21 As Label
    Friend WithEvents LabelYear As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents DataGridView3 As DataGridView
    Friend WithEvents Timer1 As Timer
    Friend WithEvents DirectoryEntry1 As DirectoryServices.DirectoryEntry
    Friend WithEvents ButtonSearch As Button
    Friend WithEvents PanelSearch As Panel
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents CheckBoxSearchID As CheckBox
    Friend WithEvents CheckBoxSearchName As CheckBox
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents SearchTextBox As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents BtnSearch As Button
    Friend WithEvents ButtonLogout As Button
    Friend WithEvents ContextMenuStrip2 As ContextMenuStrip
    Friend WithEvents DeleteToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents SelectAllToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ClearSelectToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents RefreshToolStripMenuItem4 As ToolStripMenuItem
End Class

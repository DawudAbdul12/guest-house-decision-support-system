<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class menu
    Inherits MetroFramework.Forms.MetroForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(menu))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.status = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel4 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel5 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel6 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewCheckInToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewReservationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.CheckOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CheckedInListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReservedListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CheckedOutListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.RoomStatusToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DiscountToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RoomToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GuestToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExpensesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AccountToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangePasswordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.dtOut = New System.Windows.Forms.DateTimePicker()
        Me.dtIn = New System.Windows.Forms.DateTimePicker()
        Me.lvlcheckin = New System.Windows.Forms.ListView()
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader12 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader13 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader14 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.lvRoom = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Lbl_month_reserved = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.progressBar_month = New Bunifu.Framework.UI.BunifuProgressBar()
        Me.Lbl_month_room = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Lbl_month_amt = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Lbl_reserve_room = New System.Windows.Forms.Label()
        Me.Lbl_week_amt = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.btnProgressBarWeek = New Bunifu.Framework.UI.BunifuCircleProgressbar()
        Me.Lbl_week_room = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Lbl_yest_reserved = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Lbl_yest_room = New System.Windows.Forms.Label()
        Me.progress_bar_yest = New Bunifu.Framework.UI.BunifuProgressBar()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Lbl_yest_amt = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Lbl_total_reserved = New System.Windows.Forms.Label()
        Me.btnDonald = New Bunifu.Framework.UI.BunifuCircleProgressbar()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Lbl_room_occupation = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Lbl_todays_book_amt = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.Panel1.SuspendLayout()
        Me.status.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Panel1.Controls.Add(Me.status)
        Me.Panel1.Controls.Add(Me.MenuStrip1)
        Me.Panel1.Controls.Add(Me.Panel7)
        Me.Panel1.Controls.Add(Me.Panel6)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(20, 60)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1394, 666)
        Me.Panel1.TabIndex = 1
        '
        'status
        '
        Me.status.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.status.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel4, Me.ToolStripStatusLabel5, Me.ToolStripStatusLabel6})
        Me.status.Location = New System.Drawing.Point(0, 637)
        Me.status.Name = "status"
        Me.status.Padding = New System.Windows.Forms.Padding(1, 0, 19, 0)
        Me.status.Size = New System.Drawing.Size(1394, 29)
        Me.status.Stretch = False
        Me.status.TabIndex = 16
        Me.status.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel4
        '
        Me.ToolStripStatusLabel4.AutoSize = False
        Me.ToolStripStatusLabel4.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ToolStripStatusLabel4.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right
        Me.ToolStripStatusLabel4.Name = "ToolStripStatusLabel4"
        Me.ToolStripStatusLabel4.Size = New System.Drawing.Size(458, 24)
        Me.ToolStripStatusLabel4.Spring = True
        Me.ToolStripStatusLabel4.Text = "Login as :"
        '
        'ToolStripStatusLabel5
        '
        Me.ToolStripStatusLabel5.AutoSize = False
        Me.ToolStripStatusLabel5.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ToolStripStatusLabel5.Name = "ToolStripStatusLabel5"
        Me.ToolStripStatusLabel5.Size = New System.Drawing.Size(458, 24)
        Me.ToolStripStatusLabel5.Spring = True
        Me.ToolStripStatusLabel5.Text = "Hotel Billing and Reservation System"
        '
        'ToolStripStatusLabel6
        '
        Me.ToolStripStatusLabel6.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ToolStripStatusLabel6.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left
        Me.ToolStripStatusLabel6.Name = "ToolStripStatusLabel6"
        Me.ToolStripStatusLabel6.Size = New System.Drawing.Size(458, 24)
        Me.ToolStripStatusLabel6.Spring = True
        Me.ToolStripStatusLabel6.Text = "Date and Time :"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem1, Me.SettingsToolStripMenuItem, Me.SettingsToolStripMenuItem1, Me.AccountToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(8, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(1394, 28)
        Me.MenuStrip1.TabIndex = 17
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem1
        '
        Me.FileToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewCheckInToolStripMenuItem, Me.NewReservationToolStripMenuItem, Me.ToolStripSeparator1, Me.CheckOutToolStripMenuItem, Me.ToolStripMenuItem1, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem1.Name = "FileToolStripMenuItem1"
        Me.FileToolStripMenuItem1.Size = New System.Drawing.Size(44, 24)
        Me.FileToolStripMenuItem1.Text = "&File"
        '
        'NewCheckInToolStripMenuItem
        '
        Me.NewCheckInToolStripMenuItem.Name = "NewCheckInToolStripMenuItem"
        Me.NewCheckInToolStripMenuItem.Size = New System.Drawing.Size(195, 26)
        Me.NewCheckInToolStripMenuItem.Text = "New Check In"
        '
        'NewReservationToolStripMenuItem
        '
        Me.NewReservationToolStripMenuItem.Name = "NewReservationToolStripMenuItem"
        Me.NewReservationToolStripMenuItem.Size = New System.Drawing.Size(195, 26)
        Me.NewReservationToolStripMenuItem.Text = "New Reservation"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(192, 6)
        '
        'CheckOutToolStripMenuItem
        '
        Me.CheckOutToolStripMenuItem.Name = "CheckOutToolStripMenuItem"
        Me.CheckOutToolStripMenuItem.Size = New System.Drawing.Size(195, 26)
        Me.CheckOutToolStripMenuItem.Text = "Check Out"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(192, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(195, 26)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CheckedInListToolStripMenuItem, Me.ReservedListToolStripMenuItem, Me.CheckedOutListToolStripMenuItem, Me.ToolStripMenuItem2, Me.RoomStatusToolStripMenuItem})
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(95, 24)
        Me.SettingsToolStripMenuItem.Text = "&Monitoring"
        '
        'CheckedInListToolStripMenuItem
        '
        Me.CheckedInListToolStripMenuItem.Name = "CheckedInListToolStripMenuItem"
        Me.CheckedInListToolStripMenuItem.Size = New System.Drawing.Size(194, 26)
        Me.CheckedInListToolStripMenuItem.Text = "&Checked In List"
        '
        'ReservedListToolStripMenuItem
        '
        Me.ReservedListToolStripMenuItem.Name = "ReservedListToolStripMenuItem"
        Me.ReservedListToolStripMenuItem.Size = New System.Drawing.Size(194, 26)
        Me.ReservedListToolStripMenuItem.Text = "&Reserved List"
        '
        'CheckedOutListToolStripMenuItem
        '
        Me.CheckedOutListToolStripMenuItem.Name = "CheckedOutListToolStripMenuItem"
        Me.CheckedOutListToolStripMenuItem.Size = New System.Drawing.Size(194, 26)
        Me.CheckedOutListToolStripMenuItem.Text = "Checked &Out List"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(191, 6)
        '
        'RoomStatusToolStripMenuItem
        '
        Me.RoomStatusToolStripMenuItem.Name = "RoomStatusToolStripMenuItem"
        Me.RoomStatusToolStripMenuItem.Size = New System.Drawing.Size(194, 26)
        Me.RoomStatusToolStripMenuItem.Text = "&Room Status"
        '
        'SettingsToolStripMenuItem1
        '
        Me.SettingsToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DiscountToolStripMenuItem, Me.RoomToolStripMenuItem, Me.GuestToolStripMenuItem, Me.ExpensesToolStripMenuItem})
        Me.SettingsToolStripMenuItem1.Name = "SettingsToolStripMenuItem1"
        Me.SettingsToolStripMenuItem1.Size = New System.Drawing.Size(74, 24)
        Me.SettingsToolStripMenuItem1.Text = "&Settings"
        '
        'DiscountToolStripMenuItem
        '
        Me.DiscountToolStripMenuItem.Name = "DiscountToolStripMenuItem"
        Me.DiscountToolStripMenuItem.Size = New System.Drawing.Size(144, 26)
        Me.DiscountToolStripMenuItem.Text = "&Discount"
        '
        'RoomToolStripMenuItem
        '
        Me.RoomToolStripMenuItem.Name = "RoomToolStripMenuItem"
        Me.RoomToolStripMenuItem.Size = New System.Drawing.Size(144, 26)
        Me.RoomToolStripMenuItem.Text = "&Room"
        '
        'GuestToolStripMenuItem
        '
        Me.GuestToolStripMenuItem.Name = "GuestToolStripMenuItem"
        Me.GuestToolStripMenuItem.Size = New System.Drawing.Size(144, 26)
        Me.GuestToolStripMenuItem.Text = "&Guest"
        '
        'ExpensesToolStripMenuItem
        '
        Me.ExpensesToolStripMenuItem.Name = "ExpensesToolStripMenuItem"
        Me.ExpensesToolStripMenuItem.Size = New System.Drawing.Size(144, 26)
        Me.ExpensesToolStripMenuItem.Text = "Expenses"
        '
        'AccountToolStripMenuItem
        '
        Me.AccountToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ChangePasswordToolStripMenuItem, Me.LogoutToolStripMenuItem, Me.ExitToolStripMenuItem1})
        Me.AccountToolStripMenuItem.Name = "AccountToolStripMenuItem"
        Me.AccountToolStripMenuItem.Size = New System.Drawing.Size(75, 24)
        Me.AccountToolStripMenuItem.Text = "Account"
        '
        'ChangePasswordToolStripMenuItem
        '
        Me.ChangePasswordToolStripMenuItem.Name = "ChangePasswordToolStripMenuItem"
        Me.ChangePasswordToolStripMenuItem.Size = New System.Drawing.Size(199, 26)
        Me.ChangePasswordToolStripMenuItem.Text = "Change Password"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(199, 26)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'ExitToolStripMenuItem1
        '
        Me.ExitToolStripMenuItem1.Name = "ExitToolStripMenuItem1"
        Me.ExitToolStripMenuItem1.Size = New System.Drawing.Size(199, 26)
        Me.ExitToolStripMenuItem1.Text = "Exit"
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.White
        Me.Panel7.Controls.Add(Me.Panel9)
        Me.Panel7.Controls.Add(Me.Label9)
        Me.Panel7.Location = New System.Drawing.Point(475, 244)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(897, 390)
        Me.Panel7.TabIndex = 5
        '
        'Panel9
        '
        Me.Panel9.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel9.Controls.Add(Me.dtOut)
        Me.Panel9.Controls.Add(Me.dtIn)
        Me.Panel9.Controls.Add(Me.lvlcheckin)
        Me.Panel9.Location = New System.Drawing.Point(3, 47)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(891, 340)
        Me.Panel9.TabIndex = 10
        '
        'dtOut
        '
        Me.dtOut.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtOut.Location = New System.Drawing.Point(56, 406)
        Me.dtOut.Margin = New System.Windows.Forms.Padding(4)
        Me.dtOut.Name = "dtOut"
        Me.dtOut.Size = New System.Drawing.Size(137, 22)
        Me.dtOut.TabIndex = 46
        '
        'dtIn
        '
        Me.dtIn.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtIn.Location = New System.Drawing.Point(-77, 406)
        Me.dtIn.Margin = New System.Windows.Forms.Padding(4)
        Me.dtIn.Name = "dtIn"
        Me.dtIn.Size = New System.Drawing.Size(124, 22)
        Me.dtIn.TabIndex = 45
        '
        'lvlcheckin
        '
        Me.lvlcheckin.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader10, Me.ColumnHeader11, Me.ColumnHeader12, Me.ColumnHeader13, Me.ColumnHeader14})
        Me.lvlcheckin.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvlcheckin.FullRowSelect = True
        Me.lvlcheckin.GridLines = True
        Me.lvlcheckin.Location = New System.Drawing.Point(0, 0)
        Me.lvlcheckin.Margin = New System.Windows.Forms.Padding(4)
        Me.lvlcheckin.Name = "lvlcheckin"
        Me.lvlcheckin.Size = New System.Drawing.Size(891, 340)
        Me.lvlcheckin.TabIndex = 3
        Me.lvlcheckin.UseCompatibleStateImageBehavior = False
        Me.lvlcheckin.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "TransID"
        Me.ColumnHeader4.Width = 100
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Guest Name"
        Me.ColumnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader5.Width = 200
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Room #"
        Me.ColumnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Checkin Date"
        Me.ColumnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader7.Width = 100
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Checkout Date"
        Me.ColumnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader8.Width = 100
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "No. of Days"
        Me.ColumnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader9.Width = 80
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Children"
        Me.ColumnHeader10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "Adults"
        Me.ColumnHeader11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "Advance Payment"
        Me.ColumnHeader12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader12.Width = 120
        '
        'ColumnHeader13
        '
        Me.ColumnHeader13.Text = "Discount"
        Me.ColumnHeader13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader13.Width = 80
        '
        'ColumnHeader14
        '
        Me.ColumnHeader14.Text = "Total"
        Me.ColumnHeader14.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader14.Width = 80
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(12, 12)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(267, 32)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Daily Booking Record(s)"
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.White
        Me.Panel6.Controls.Add(Me.Panel8)
        Me.Panel6.Controls.Add(Me.Label8)
        Me.Panel6.Location = New System.Drawing.Point(21, 242)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(435, 390)
        Me.Panel6.TabIndex = 4
        '
        'Panel8
        '
        Me.Panel8.Controls.Add(Me.lvRoom)
        Me.Panel8.Location = New System.Drawing.Point(0, 47)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(432, 340)
        Me.Panel8.TabIndex = 9
        '
        'lvRoom
        '
        Me.lvRoom.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.lvRoom.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvRoom.FullRowSelect = True
        Me.lvRoom.GridLines = True
        Me.lvRoom.Location = New System.Drawing.Point(0, 0)
        Me.lvRoom.Margin = New System.Windows.Forms.Padding(4)
        Me.lvRoom.Name = "lvRoom"
        Me.lvRoom.Size = New System.Drawing.Size(432, 340)
        Me.lvRoom.TabIndex = 63
        Me.lvRoom.UseCompatibleStateImageBehavior = False
        Me.lvRoom.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Room #"
        Me.ColumnHeader1.Width = 70
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Room Type"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader2.Width = 150
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Room Rate"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader3.Width = 80
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(6, 12)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(204, 32)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Room(s) Available"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.Controls.Add(Me.Lbl_month_reserved)
        Me.Panel4.Controls.Add(Me.Label17)
        Me.Panel4.Controls.Add(Me.Label18)
        Me.Panel4.Controls.Add(Me.progressBar_month)
        Me.Panel4.Controls.Add(Me.Lbl_month_room)
        Me.Panel4.Controls.Add(Me.Label22)
        Me.Panel4.Controls.Add(Me.Label20)
        Me.Panel4.Controls.Add(Me.Lbl_month_amt)
        Me.Panel4.Location = New System.Drawing.Point(1045, 49)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(327, 173)
        Me.Panel4.TabIndex = 3
        '
        'Lbl_month_reserved
        '
        Me.Lbl_month_reserved.AutoSize = True
        Me.Lbl_month_reserved.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_month_reserved.Location = New System.Drawing.Point(174, 116)
        Me.Lbl_month_reserved.Name = "Lbl_month_reserved"
        Me.Lbl_month_reserved.Size = New System.Drawing.Size(29, 20)
        Me.Lbl_month_reserved.TabIndex = 23
        Me.Lbl_month_reserved.Text = "No"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(3, 4)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(235, 32)
        Me.Label17.TabIndex = 19
        Me.Label17.Text = "This Month Statistics"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(21, 116)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(132, 20)
        Me.Label18.TabIndex = 22
        Me.Label18.Text = "Room(s) Reserved:"
        '
        'progressBar_month
        '
        Me.progressBar_month.BackColor = System.Drawing.Color.Silver
        Me.progressBar_month.BorderRadius = 5
        Me.progressBar_month.Location = New System.Drawing.Point(20, 148)
        Me.progressBar_month.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.progressBar_month.MaximumValue = 100
        Me.progressBar_month.Name = "progressBar_month"
        Me.progressBar_month.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.progressBar_month.Size = New System.Drawing.Size(290, 12)
        Me.progressBar_month.TabIndex = 1
        Me.progressBar_month.Value = 50
        '
        'Lbl_month_room
        '
        Me.Lbl_month_room.AutoSize = True
        Me.Lbl_month_room.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_month_room.Location = New System.Drawing.Point(175, 87)
        Me.Lbl_month_room.Name = "Lbl_month_room"
        Me.Lbl_month_room.Size = New System.Drawing.Size(29, 20)
        Me.Lbl_month_room.TabIndex = 21
        Me.Lbl_month_room.Text = "No"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(14, 46)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(61, 32)
        Me.Label22.TabIndex = 19
        Me.Label22.Text = "GHS"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(22, 87)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(135, 20)
        Me.Label20.TabIndex = 20
        Me.Label20.Text = "Room(s) Occupied:"
        '
        'Lbl_month_amt
        '
        Me.Lbl_month_amt.AutoSize = True
        Me.Lbl_month_amt.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_month_amt.Location = New System.Drawing.Point(81, 46)
        Me.Lbl_month_amt.Name = "Lbl_month_amt"
        Me.Lbl_month_amt.Size = New System.Drawing.Size(98, 32)
        Me.Lbl_month_amt.TabIndex = 18
        Me.Lbl_month_amt.Text = "100,000"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.White
        Me.Panel5.Controls.Add(Me.Label27)
        Me.Panel5.Controls.Add(Me.Lbl_reserve_room)
        Me.Panel5.Controls.Add(Me.Lbl_week_amt)
        Me.Panel5.Controls.Add(Me.Label3)
        Me.Panel5.Controls.Add(Me.Label24)
        Me.Panel5.Controls.Add(Me.btnProgressBarWeek)
        Me.Panel5.Controls.Add(Me.Lbl_week_room)
        Me.Panel5.Controls.Add(Me.Label26)
        Me.Panel5.Location = New System.Drawing.Point(704, 49)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(327, 173)
        Me.Panel5.TabIndex = 2
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(137, 69)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(61, 32)
        Me.Label27.TabIndex = 12
        Me.Label27.Text = "GHS"
        '
        'Lbl_reserve_room
        '
        Me.Lbl_reserve_room.AutoSize = True
        Me.Lbl_reserve_room.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_reserve_room.Location = New System.Drawing.Point(284, 139)
        Me.Lbl_reserve_room.Name = "Lbl_reserve_room"
        Me.Lbl_reserve_room.Size = New System.Drawing.Size(29, 20)
        Me.Lbl_reserve_room.TabIndex = 21
        Me.Lbl_reserve_room.Text = "No"
        '
        'Lbl_week_amt
        '
        Me.Lbl_week_amt.AutoSize = True
        Me.Lbl_week_amt.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_week_amt.Location = New System.Drawing.Point(204, 69)
        Me.Lbl_week_amt.Name = "Lbl_week_amt"
        Me.Lbl_week_amt.Size = New System.Drawing.Size(98, 32)
        Me.Lbl_week_amt.TabIndex = 11
        Me.Lbl_week_amt.Text = "100,000"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 4)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(222, 32)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "This Week Statistics"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(135, 139)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(132, 20)
        Me.Label24.TabIndex = 20
        Me.Label24.Text = "Room(s) Reserved:"
        '
        'btnProgressBarWeek
        '
        Me.btnProgressBarWeek.animated = False
        Me.btnProgressBarWeek.animationIterval = 5
        Me.btnProgressBarWeek.animationSpeed = 300
        Me.btnProgressBarWeek.BackColor = System.Drawing.SystemColors.HighlightText
        Me.btnProgressBarWeek.BackgroundImage = CType(resources.GetObject("btnProgressBarWeek.BackgroundImage"), System.Drawing.Image)
        Me.btnProgressBarWeek.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProgressBarWeek.ForeColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btnProgressBarWeek.LabelVisible = True
        Me.btnProgressBarWeek.LineProgressThickness = 8
        Me.btnProgressBarWeek.LineThickness = 5
        Me.btnProgressBarWeek.Location = New System.Drawing.Point(1, 38)
        Me.btnProgressBarWeek.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.btnProgressBarWeek.MaxValue = 100
        Me.btnProgressBarWeek.Name = "btnProgressBarWeek"
        Me.btnProgressBarWeek.ProgressBackColor = System.Drawing.Color.Gainsboro
        Me.btnProgressBarWeek.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btnProgressBarWeek.Size = New System.Drawing.Size(130, 130)
        Me.btnProgressBarWeek.TabIndex = 1
        Me.btnProgressBarWeek.Value = 40
        '
        'Lbl_week_room
        '
        Me.Lbl_week_room.AutoSize = True
        Me.Lbl_week_room.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_week_room.Location = New System.Drawing.Point(283, 113)
        Me.Lbl_week_room.Name = "Lbl_week_room"
        Me.Lbl_week_room.Size = New System.Drawing.Size(29, 20)
        Me.Lbl_week_room.TabIndex = 19
        Me.Lbl_week_room.Text = "No"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(135, 113)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(135, 20)
        Me.Label26.TabIndex = 18
        Me.Label26.Text = "Room(s) Occupied:"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.Lbl_yest_reserved)
        Me.Panel3.Controls.Add(Me.Label10)
        Me.Panel3.Controls.Add(Me.Label11)
        Me.Panel3.Controls.Add(Me.Lbl_yest_room)
        Me.Panel3.Controls.Add(Me.progress_bar_yest)
        Me.Panel3.Controls.Add(Me.Label14)
        Me.Panel3.Controls.Add(Me.Lbl_yest_amt)
        Me.Panel3.Controls.Add(Me.Label15)
        Me.Panel3.Location = New System.Drawing.Point(362, 49)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(327, 173)
        Me.Panel3.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(4, 4)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(230, 32)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Yesterday's Statistics"
        '
        'Lbl_yest_reserved
        '
        Me.Lbl_yest_reserved.AutoSize = True
        Me.Lbl_yest_reserved.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_yest_reserved.Location = New System.Drawing.Point(161, 116)
        Me.Lbl_yest_reserved.Name = "Lbl_yest_reserved"
        Me.Lbl_yest_reserved.Size = New System.Drawing.Size(29, 20)
        Me.Lbl_yest_reserved.TabIndex = 17
        Me.Lbl_yest_reserved.Text = "No"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(-76, 129)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(53, 20)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "Room "
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(8, 116)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(132, 20)
        Me.Label11.TabIndex = 16
        Me.Label11.Text = "Room(s) Reserved:"
        '
        'Lbl_yest_room
        '
        Me.Lbl_yest_room.AutoSize = True
        Me.Lbl_yest_room.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_yest_room.Location = New System.Drawing.Point(162, 90)
        Me.Lbl_yest_room.Name = "Lbl_yest_room"
        Me.Lbl_yest_room.Size = New System.Drawing.Size(29, 20)
        Me.Lbl_yest_room.TabIndex = 15
        Me.Lbl_yest_room.Text = "No"
        '
        'progress_bar_yest
        '
        Me.progress_bar_yest.BackColor = System.Drawing.Color.Silver
        Me.progress_bar_yest.BorderRadius = 5
        Me.progress_bar_yest.Location = New System.Drawing.Point(6, 148)
        Me.progress_bar_yest.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.progress_bar_yest.MaximumValue = 100
        Me.progress_bar_yest.Name = "progress_bar_yest"
        Me.progress_bar_yest.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.progress_bar_yest.Size = New System.Drawing.Size(313, 12)
        Me.progress_bar_yest.TabIndex = 0
        Me.progress_bar_yest.Value = 90
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(9, 90)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(135, 20)
        Me.Label14.TabIndex = 14
        Me.Label14.Text = "Room(s) Occupied:"
        '
        'Lbl_yest_amt
        '
        Me.Lbl_yest_amt.AutoSize = True
        Me.Lbl_yest_amt.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_yest_amt.Location = New System.Drawing.Point(74, 46)
        Me.Lbl_yest_amt.Name = "Lbl_yest_amt"
        Me.Lbl_yest_amt.Size = New System.Drawing.Size(98, 32)
        Me.Lbl_yest_amt.TabIndex = 12
        Me.Lbl_yest_amt.Text = "100,000"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(7, 46)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(61, 32)
        Me.Label15.TabIndex = 13
        Me.Label15.Text = "GHS"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.Lbl_total_reserved)
        Me.Panel2.Controls.Add(Me.btnDonald)
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Controls.Add(Me.Lbl_room_occupation)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Lbl_todays_book_amt)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(21, 49)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(327, 173)
        Me.Panel2.TabIndex = 0
        '
        'Lbl_total_reserved
        '
        Me.Lbl_total_reserved.AutoSize = True
        Me.Lbl_total_reserved.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_total_reserved.Location = New System.Drawing.Point(277, 141)
        Me.Lbl_total_reserved.Name = "Lbl_total_reserved"
        Me.Lbl_total_reserved.Size = New System.Drawing.Size(29, 20)
        Me.Lbl_total_reserved.TabIndex = 10
        Me.Lbl_total_reserved.Text = "No"
        '
        'btnDonald
        '
        Me.btnDonald.animated = False
        Me.btnDonald.animationIterval = 5
        Me.btnDonald.animationSpeed = 300
        Me.btnDonald.BackColor = System.Drawing.Color.White
        Me.btnDonald.BackgroundImage = CType(resources.GetObject("btnDonald.BackgroundImage"), System.Drawing.Image)
        Me.btnDonald.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDonald.ForeColor = System.Drawing.Color.SeaGreen
        Me.btnDonald.LabelVisible = True
        Me.btnDonald.LineProgressThickness = 8
        Me.btnDonald.LineThickness = 5
        Me.btnDonald.Location = New System.Drawing.Point(5, 38)
        Me.btnDonald.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.btnDonald.MaxValue = 100
        Me.btnDonald.Name = "btnDonald"
        Me.btnDonald.ProgressBackColor = System.Drawing.Color.Gainsboro
        Me.btnDonald.ProgressColor = System.Drawing.Color.SeaGreen
        Me.btnDonald.Size = New System.Drawing.Size(130, 130)
        Me.btnDonald.TabIndex = 2
        Me.btnDonald.Value = 40
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(143, 141)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(132, 20)
        Me.Label12.TabIndex = 9
        Me.Label12.Text = "Room(s) Reserved:"
        '
        'Lbl_room_occupation
        '
        Me.Lbl_room_occupation.AutoSize = True
        Me.Lbl_room_occupation.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_room_occupation.Location = New System.Drawing.Point(278, 113)
        Me.Lbl_room_occupation.Name = "Lbl_room_occupation"
        Me.Lbl_room_occupation.Size = New System.Drawing.Size(29, 20)
        Me.Lbl_room_occupation.TabIndex = 8
        Me.Lbl_room_occupation.Text = "No"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(141, 113)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(135, 20)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Room(s) Occupied:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(139, 69)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 32)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "GHS"
        '
        'Lbl_todays_book_amt
        '
        Me.Lbl_todays_book_amt.AutoSize = True
        Me.Lbl_todays_book_amt.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_todays_book_amt.Location = New System.Drawing.Point(206, 69)
        Me.Lbl_todays_book_amt.Name = "Lbl_todays_book_amt"
        Me.Lbl_todays_book_amt.Size = New System.Drawing.Size(98, 32)
        Me.Lbl_todays_book_amt.TabIndex = 5
        Me.Lbl_todays_book_amt.Text = "100,000"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(192, 32)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Today's Statistics"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me
        '
        'menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1434, 746)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "menu"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.status.ResumeLayout(False)
        Me.status.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel9.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents progressBar_month As Bunifu.Framework.UI.BunifuProgressBar
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents btnDonald As Bunifu.Framework.UI.BunifuCircleProgressbar
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents progress_bar_yest As Bunifu.Framework.UI.BunifuProgressBar
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnProgressBarWeek As Bunifu.Framework.UI.BunifuCircleProgressbar
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Lbl_todays_book_amt As System.Windows.Forms.Label
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewCheckInToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewReservationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SettingsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CheckedInListToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReservedListToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CheckedOutListToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents RoomStatusToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SettingsToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DiscountToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RoomToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GuestToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AccountToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChangePasswordToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents lvRoom As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CheckOutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents lvlcheckin As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader11 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader12 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader13 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader14 As System.Windows.Forms.ColumnHeader
    Friend WithEvents dtOut As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtIn As System.Windows.Forms.DateTimePicker
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents status As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel4 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel5 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel6 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Lbl_room_occupation As System.Windows.Forms.Label
    Friend WithEvents Lbl_total_reserved As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents ExpensesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Lbl_yest_reserved As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Lbl_yest_room As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Lbl_yest_amt As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Lbl_month_reserved As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Lbl_month_room As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Lbl_month_amt As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Lbl_reserve_room As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Lbl_week_room As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Lbl_week_amt As System.Windows.Forms.Label
End Class

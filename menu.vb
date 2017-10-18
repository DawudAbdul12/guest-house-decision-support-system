Imports System.Data.OleDb
Public Class menu

    Private Sub NewCheckInToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewCheckInToolStripMenuItem.Click
        frmCheckin.ShowDialog()
        Call loaded_functions()
    End Sub

    Private Sub NewReservationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewReservationToolStripMenuItem.Click
        frmReserve.ShowDialog()
        Call loaded_functions()
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoutToolStripMenuItem.Click
        Dim out_app As String = MsgBox("Logout from application?", vbQuestion + vbYesNo, "Logout")
        If out_app = vbYes Then
            Me.Hide()
            frmLogin.Show()
        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub SettingsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SettingsToolStripMenuItem.Click

    End Sub

    Private Sub FileToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FileToolStripMenuItem1.Click

    End Sub

    Private Sub CheckedInListToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckedInListToolStripMenuItem.Click
        frmCheckinListMonitor.ShowDialog()
    End Sub

    Private Sub RoomStatusToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RoomStatusToolStripMenuItem.Click
        frmRoomListMonitor.ShowDialog()
    End Sub

    Private Sub ReservedListToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReservedListToolStripMenuItem.Click
        frmReserveListMonitor.ShowDialog()
    End Sub

    Private Sub CheckedOutListToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckedOutListToolStripMenuItem.Click
        frmCheckOutList.ShowDialog()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim datenow As Date = Now
        status.Items(2).Text = "Date and Time : " & datenow.ToString("MMMM dd, yyyy") & " " & TimeOfDay
    End Sub

    Private Sub DiscountToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DiscountToolStripMenuItem.Click
        frmDiscount.ShowDialog()
    End Sub

    Private Sub RoomToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RoomToolStripMenuItem.Click
        frmRoom.ShowDialog()
        frmRoom.TabPage2.Select()
    End Sub

    Private Sub GuestToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GuestToolStripMenuItem.Click
        frmGuest.ShowDialog()
    End Sub

    Private Sub ExitToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem1.Click
        Dim exit_app As String = MsgBox("Exit application?", vbQuestion + vbYesNo, "Exit")
        If exit_app = vbYes Then
            End
        End If
    End Sub

    ' FUNCTION FOR AVAILABLE ROOMS 
    Private Sub availables_rooms()


        con.Open()
        Dim Dt As New DataTable("tblRoom")
        Dim rs As OleDbDataAdapter

        rs = New OleDbDataAdapter("Select * from tblRoom where Status = 'Available' ", con)

        rs.Fill(Dt)
        Dim indx As Integer
        lvRoom.Items.Clear()
        For indx = 0 To Dt.Rows.Count - 1
            Dim lv As New ListViewItem
            lv.Text = Dt.Rows(indx).Item("RoomNumber")
            lv.SubItems.Add(Dt.Rows(indx).Item("RoomType"))
            lv.SubItems.Add(Dt.Rows(indx).Item("RoomRate"))
            'lv.SubItems.Add(Dt.Rows(indx).Item("Status"))
            lvRoom.Items.Add(lv)
        Next
        rs.Dispose()
        con.Close()
    End Sub

    ' FUNCTION FOR DAILY BOOKING RECORDS
    Private Sub daily_booking()
        con.Open()

        Dim Dt As New DataTable("tblTransaction")
        ' Dim todaysDate As String = Today
        ' Dim sql_query As String = "Select * from tblTransaction, tblGuest, tblDiscount, tblRoom WHERE tblTransaction.GuestID = tblGuest.ID AND tblTransaction.DiscountID = tblDiscount.ID AND tblTransaction.RoomNum = tblRoom.RoomNumber AND tblTransaction.Remarks = 'Checkin' AND tblTransaction.Status = 'Active' AND tblTransaction.CheckInDate BETWEEN " & Today & " AND " & Today
        ' Dim sql_query As String = "Select * from tblTransaction, tblGuest, tblDiscount, tblRoom WHERE tblTransaction.CheckOutDate = " & Today
        Dim objCommand As OleDbCommand = New OleDbCommand()


        objCommand.Connection = con
        objCommand.CommandType = CommandType.Text
        objCommand.CommandText = "Select * from tblTransaction, tblGuest, tblDiscount, tblRoom WHERE tblTransaction.GuestID = tblGuest.ID AND tblTransaction.DiscountID = tblDiscount.ID AND tblTransaction.RoomNum = tblRoom.RoomNumber AND tblTransaction.CheckInDate = @todaysDate AND tblTransaction.Remarks <> 'Cancelled' "
        objCommand.Parameters.AddWithValue("@todaysDate", Today)

        rs = New OleDbDataAdapter
        rs.SelectCommand = objCommand


        rs.Fill(Dt)

        Dim indx As Integer
        lvlcheckin.Items.Clear()

        For indx = 0 To Dt.Rows.Count - 1
            Dim lv As New ListViewItem
            Dim getdate As TimeSpan
            Dim days, rate As Integer
            Dim subtotal, total, advance As Double
            Dim discount As Double
            ' Dim dtIn_r As DateTimePicker
            ' Dim dtOut_r As DateTimePicker

            Dim value As Integer = Val(Dt.Rows(indx).Item("TransID"))

            lv.Text = "TransID - " & value.ToString("0000")
            lv.SubItems.Add(Dt.Rows(indx).Item("GuestFName") & " " & Dt.Rows(indx).Item("GuestLName"))
            lv.SubItems.Add(Dt.Rows(indx).Item("RoomNum"))

            rate = Dt.Rows(indx).Item("RoomRate")

            lv.SubItems.Add(Dt.Rows(indx).Item("CheckInDate"))
            lv.SubItems.Add(Dt.Rows(indx).Item("CheckOutDate"))

            dtIn.Value = Dt.Rows(indx).Item("CheckOutDate")
            dtOut.Value = Dt.Rows(indx).Item("CheckInDate")

            getdate = dtIn.Value - dtOut.Value
            days = getdate.Days

            lv.SubItems.Add(days)
            lv.SubItems.Add(Dt.Rows(indx).Item("NoOfChild"))
            lv.SubItems.Add(Dt.Rows(indx).Item("NoOfAdult"))
            advance = Dt.Rows(indx).Item("AdvancePayment")
            lv.SubItems.Add("GHs " & (advance).ToString("N"))
            lv.SubItems.Add(Dt.Rows(indx).Item("DiscountType"))

            discount = Val(Dt.Rows(indx).Item("DiscountRate"))

            subtotal = (days * rate) - ((days * rate) * discount)
            total = (Val(subtotal) - Val(Dt.Rows(indx).Item("AdvancePayment"))).ToString("N")

            If Val(subtotal) > Val(Dt.Rows(indx).Item("AdvancePayment")) Then
                lv.SubItems.Add("GHs " & Val(total).ToString("N"))
            Else
                lv.SubItems.Add("GHs 0.00")
            End If

            lvlcheckin.Items.Add(lv)
        Next
        rs.Dispose()
        con.Close()

        ' MsgBox(sql_query)
    End Sub

    Private Sub daily_sales()

        'ROOMS VARIABLES
        Dim total_room As Integer
        Dim total_room_available As Integer
        Dim total_reserved As Integer
        Dim total_percentage As Integer

        'ROOMS VARIABLES
        Dim total_Amount As Double

        Dim cmd As OleDbCommand
        ' Dim reader As OleDbDataReader
        'ROOM OCCUPIED
        Dim sql As String
        con.Open()

        'TOTAL ROOM
        sql = "SELECT count(RoomNumber) FROM tblRoom"
        cmd = New OleDbCommand(sql, con)
        'cmd.Parameters.AddWithValue("@SEARCH", edu_id)
        total_room = cmd.ExecuteScalar

        'ROOM OCCUPIED
        ' sql = "SELECT count(RoomNumber) FROM tblRoom where Status = 'Occupied'"
        sql = "SELECT count(AdvancePayment) FROM tblTransaction WHERE  tblTransaction.Status = 'Active' AND tblTransaction.Remarks = 'Checkin' AND CheckInDate = @todaysDate "
        cmd = New OleDbCommand(sql, con)
        cmd.Parameters.AddWithValue("@todaysDate", Today)
        total_room_available = cmd.ExecuteScalar

        'RESERVED OCCUPIED
        'sql = "SELECT count(RoomNumber) FROM tblRoom where Status = 'Reserve'"
        sql = "SELECT count(AdvancePayment) FROM tblTransaction WHERE  tblTransaction.Status = 'Active' AND ReservationDate = @todaysDate AND tblTransaction.Remarks = 'Reserve' "
        cmd = New OleDbCommand(sql, con)
        cmd.Parameters.AddWithValue("@todaysDate", Today)
        total_reserved = cmd.ExecuteScalar

        'AMOUNT
        'Dim todays As String = "7/11/2017"

        sql = "SELECT sum(AdvancePayment) FROM tblTransaction WHERE  tblTransaction.Status = 'Active' AND CheckInDate = @todaysDate AND tblTransaction.Remarks <> 'Cancelled'"
        cmd = New OleDbCommand(sql, con)
        cmd.Parameters.AddWithValue("@todaysDate", Today)

        If IsDBNull(cmd.ExecuteScalar) Then

        Else

            total_Amount = cmd.ExecuteScalar

        End If

        cmd.Dispose()
        con.Close()


        'OCCUPIED ROOMS
        Lbl_room_occupation.Text = total_room_available
        'OCCUPIED ROOMS PERCENTAGE
        total_percentage = (total_room_available / total_room) * 100
        'RESERVED ROOMS
        Lbl_total_reserved.Text = total_reserved
        'PROGRESSIVE BAR
        ' btnProgressBarDaily.Value = total_percentage
        btnDonald.Value = total_percentage

        Dim value As Decimal = CDec(total_Amount)
        Dim formattedValue As String = String.Format("{0:n}", value)
        Lbl_todays_book_amt.Text = formattedValue
        '  MsgBox(total_room_available)




    End Sub

    Private Sub yesterday_sales()

        'ROOMS VARIABLES
        Dim total_room As Integer
        Dim total_room_available As Integer
        Dim total_reserved As Integer
        Dim total_percentage As Integer
        ' YESTERDAY'S DATE
        Dim yesterday As DateTime = Today.AddDays(-1)
        'ROOMS VARIABLES
        Dim total_Amount As Double

        Dim cmd As OleDbCommand
        ' Dim reader As OleDbDataReader
        'ROOM OCCUPIED
        Dim sql As String
        con.Open()

        'TOTAL ROOM
        sql = "SELECT count(RoomNumber) FROM tblRoom"
        cmd = New OleDbCommand(sql, con)
        'cmd.Parameters.AddWithValue("@SEARCH", edu_id)
        total_room = cmd.ExecuteScalar

        'ROOM OCCUPIED
        ' sql = "SELECT count(RoomNumber) FROM tblRoom where Status = 'Occupied'"
        sql = "SELECT count(AdvancePayment) FROM tblTransaction WHERE  tblTransaction.Status = 'Active' AND CheckInDate = @todaysDate AND tblTransaction.Remarks = 'Checkin'"
        cmd = New OleDbCommand(sql, con)
        cmd.Parameters.AddWithValue("@todaysDate", yesterday)
        total_room_available = cmd.ExecuteScalar

        'RESERVED OCCUPIED
        'sql = "SELECT count(RoomNumber) FROM tblRoom where Status = 'Reserve'"
        sql = "SELECT count(AdvancePayment) FROM tblTransaction WHERE  tblTransaction.Status = 'Active' AND ReservationDate = @todaysDate AND tblTransaction.Remarks = 'Reserve'"
        cmd = New OleDbCommand(sql, con)
        cmd.Parameters.AddWithValue("@todaysDate", yesterday)
        total_reserved = cmd.ExecuteScalar

        'AMOUNT
        'Dim todays As String = "7/11/2017"

        sql = "SELECT sum(AdvancePayment) FROM tblTransaction WHERE  tblTransaction.Status = 'Active' AND CheckInDate = @todaysDate AND tblTransaction.Remarks <> 'Cancelled' "
        cmd = New OleDbCommand(sql, con)
        cmd.Parameters.AddWithValue("@todaysDate", yesterday)

        If IsDBNull(cmd.ExecuteScalar) Then

        Else

            total_Amount = cmd.ExecuteScalar

        End If

        cmd.Dispose()
        con.Close()


        'OCCUPIED ROOMS
        Lbl_yest_room.Text = total_room_available
        'OCCUPIED ROOMS PERCENTAGE
        total_percentage = (total_room_available / total_room) * 100
        'RESERVED ROOMS
        Lbl_yest_reserved.Text = total_reserved
        'PROGRESSIVE BAR
        ' btnProgressBarDaily.Value = total_percentage
        progress_bar_yest.Value = total_percentage

        Dim value As Decimal = CDec(total_Amount)
        Dim formattedValue As String = String.Format("{0:n}", value)
        Lbl_yest_amt.Text = formattedValue

        ' YESTERDAY'S DATE
        'Dim thisweek As String = FirstDayOfWeek.Sunday
        Dim sunday As DateTime = Today.AddDays((Today.DayOfWeek - DayOfWeek.Sunday) * -1)
        Dim saturday As DateTime = Today.AddDays((Today.DayOfWeek - DayOfWeek.Saturday) * -1)
        'MsgBox(saturday)

    End Sub


    Private Sub thisweek_sales()

        'ROOMS VARIABLES
        Dim total_room As Integer
        Dim total_room_available As Integer
        Dim total_reserved As Integer
        Dim total_percentage As Integer
        Dim sunday_date As DateTime = Today.AddDays((Today.DayOfWeek - DayOfWeek.Sunday) * -1)
        Dim saturday_date As DateTime = Today.AddDays((Today.DayOfWeek - DayOfWeek.Saturday) * -1)

        'Dim yesterday As DateTime = Today.AddDays(-1)
        'ROOMS VARIABLES
        Dim total_Amount As Double

        Dim cmd As OleDbCommand
        ' Dim reader As OleDbDataReader
        'ROOM OCCUPIED
        Dim sql As String
        con.Open()

        'TOTAL ROOM
        sql = "SELECT count(RoomNumber) FROM tblRoom"
        cmd = New OleDbCommand(sql, con)
        'cmd.Parameters.AddWithValue("@SEARCH", edu_id)
        total_room = cmd.ExecuteScalar

        'ROOM OCCUPIED
        ' sql = "SELECT count(RoomNumber) FROM tblRoom where Status = 'Occupied'"
        sql = "SELECT count(AdvancePayment) FROM tblTransaction WHERE  tblTransaction.Status = 'Active' AND CheckInDate Between @sunday AND @saturday AND tblTransaction.Remarks = 'Checkin' AND tblTransaction.Remarks <> 'Checkout' "
        cmd = New OleDbCommand(sql, con)
        cmd.Parameters.AddWithValue("@sunday", sunday_date)
        cmd.Parameters.AddWithValue("@saturday", saturday_date)
        total_room_available = cmd.ExecuteScalar

        'RESERVED OCCUPIED
        'sql = "SELECT count(RoomNumber) FROM tblRoom where Status = 'Reserve'"
        sql = "SELECT count(AdvancePayment) FROM tblTransaction WHERE  tblTransaction.Status = 'Active' AND ReservationDate Between @sunday AND @saturday AND tblTransaction.Remarks = 'Reserve'"
        cmd = New OleDbCommand(sql, con)
        cmd.Parameters.AddWithValue("@sunday", sunday_date)
        cmd.Parameters.AddWithValue("@saturday", saturday_date)
        total_reserved = cmd.ExecuteScalar

        'AMOUNT
        'Dim todays As String = "7/11/2017"

        sql = "SELECT sum(AdvancePayment) FROM tblTransaction WHERE  tblTransaction.Status = 'Active' AND CheckInDate Between @sunday AND @saturday AND tblTransaction.Remarks <> 'Cancelled' "
        cmd = New OleDbCommand(sql, con)
        cmd.Parameters.AddWithValue("@sunday", sunday_date)
        cmd.Parameters.AddWithValue("@saturday", saturday_date)

        If IsDBNull(cmd.ExecuteScalar) Then

        Else

            total_Amount = cmd.ExecuteScalar

        End If

        cmd.Dispose()
        con.Close()

      
        'OCCUPIED ROOMS
        Lbl_week_room.Text = total_room_available
        'OCCUPIED ROOMS PERCENTAGE
        total_percentage = (total_room_available / (total_room * 7)) * 100
        'RESERVED ROOMS
        Lbl_reserve_room.Text = total_reserved
        'PROGRESSIVE BAR
        ' btnProgressBarDaily.Value = total_percentage
        btnProgressBarWeek.Value = total_percentage

        Dim value As Decimal = CDec(total_Amount)
        Dim formattedValue As String = String.Format("{0:n}", value)
        Lbl_week_amt.Text = formattedValue
        'Get the first day of the month
   
        'LastDay = DateSerial(Year(Of Date), Month(Of Date), 0)
        ' FirstDay = LastDay - Day(LastDay) + 1
        '  MsgBox(total_room_available)

        
        'MsgBox(LastDay)

    End Sub
#Region "MONTH DAY FUNCTION"

    ' function FOR FIRST DAY OF MONTH
    Public Function FirstDayOfMonth(ByVal sourceDate As DateTime) As DateTime
        Return New DateTime(sourceDate.Year, sourceDate.Month, 1)
    End Function

    'Get the last day of the month
    Public Function LastDayOfMonth(ByVal sourceDate As DateTime) As DateTime
        Dim lastDay As DateTime = New DateTime(sourceDate.Year, sourceDate.Month, 1)
        Return lastDay.AddMonths(1).AddDays(-1)
    End Function

#End Region
    Private Sub thisMonth_sales()

        'ROOMS VARIABLES
        Dim total_room As Integer
        Dim total_room_available As Integer
        Dim total_reserved As Integer
        Dim total_percentage As Integer
        Dim sunday_date As DateTime = Today.AddDays((Today.DayOfWeek - DayOfWeek.Sunday) * -1)
        Dim saturday_date As DateTime = Today.AddDays((Today.DayOfWeek - DayOfWeek.Saturday) * -1)
        ' FUNCTION FOR MONTH
        Dim FirstDay As DateTime = FirstDayOfMonth(Today)
        Dim LastDay As DateTime = LastDayOfMonth(Today)

        'Dim yesterday As DateTime = Today.AddDays(-1)
        'ROOMS VARIABLES
        Dim total_Amount As Double

        Dim cmd As OleDbCommand
        ' Dim reader As OleDbDataReader
        'ROOM OCCUPIED
        Dim sql As String
        con.Open()

        'TOTAL ROOM
        sql = "SELECT count(RoomNumber) FROM tblRoom"
        cmd = New OleDbCommand(sql, con)
        'cmd.Parameters.AddWithValue("@SEARCH", edu_id)
        total_room = cmd.ExecuteScalar

        'ROOM OCCUPIED
        ' sql = "SELECT count(RoomNumber) FROM tblRoom where Status = 'Occupied'"
        sql = "SELECT count(AdvancePayment) FROM tblTransaction WHERE  tblTransaction.Status = 'Active' AND CheckInDate Between @first_month AND @last_month AND tblTransaction.Remarks = 'Checkin'"
        cmd = New OleDbCommand(sql, con)
        cmd.Parameters.AddWithValue("@first_month", FirstDay)
        cmd.Parameters.AddWithValue("@last_month", LastDay)
        total_room_available = cmd.ExecuteScalar

        'RESERVED OCCUPIED
        'sql = "SELECT count(RoomNumber) FROM tblRoom where Status = 'Reserve'"
        sql = "SELECT count(AdvancePayment) FROM tblTransaction WHERE  tblTransaction.Status = 'Active' AND ReservationDate Between @first_month AND @last_month AND tblTransaction.Remarks = 'Reserve' "
        cmd = New OleDbCommand(sql, con)
        cmd.Parameters.AddWithValue("@first_month", FirstDay)
        cmd.Parameters.AddWithValue("@last_month", LastDay)
        total_reserved = cmd.ExecuteScalar

        'AMOUNT
        'Dim todays As String = "7/11/2017"

        sql = "SELECT sum(AdvancePayment) FROM tblTransaction WHERE  tblTransaction.Status = 'Active' AND CheckInDate Between @first_month AND @last_month AND tblTransaction.Remarks <> 'Cancelled' "
        cmd = New OleDbCommand(sql, con)
        cmd.Parameters.AddWithValue("@first_month", FirstDay)
        cmd.Parameters.AddWithValue("@last_month", LastDay)

        If IsDBNull(cmd.ExecuteScalar) Then

        Else

            total_Amount = cmd.ExecuteScalar

        End If

        cmd.Dispose()
        con.Close()


        'OCCUPIED ROOMS
        Lbl_month_room.Text = total_room_available
        'OCCUPIED ROOMS PERCENTAGE
        total_percentage = (total_room_available / (total_room * 28)) * 100
        'RESERVED ROOMS
        Lbl_month_reserved.Text = total_reserved
        'PROGRESSIVE BAR
        ' btnProgressBarDaily.Value = total_percentage
        progressBar_month.Value = total_percentage

        Dim value As Decimal = CDec(total_Amount)
        Dim formattedValue As String = String.Format("{0:n}", value)
        Lbl_month_amt.Text = formattedValue
        '  MsgBox(total_room_available)

    End Sub

    Private Sub menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Call loaded_functions()

    End Sub

    Private Sub loaded_functions()
        'call rooms function
        Call availables_rooms()

        'Call daily check in records
        Call daily_booking()

        'call daily sales
        Call daily_sales()

        'YESTERDAY'S STATISTICS
        Call yesterday_sales()

        'THIS WEEK STATISTICS
        Call thisweek_sales()

        'THIS MONTH STATISTICS
        Call thisMonth_sales()

    End Sub
    Private Sub CheckOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CheckOutToolStripMenuItem.Click
        frmCheckout.ShowDialog()
    End Sub

    Private Sub ExpensesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExpensesToolStripMenuItem.Click
        expenses_frm.ShowDialog()
    End Sub


    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class
Imports System.Threading
Imports System.Timers
Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbDefaulted()  ' 初始化 combobox
        MyVar = GetVar
        APP = Application.StartupPath
        dmDefaulted()   ' 初始化 大漠
        scriptStart()   ' 初始化 腳本
        RunTimeThread.Start()

    End Sub

    Private Sub Form1_Closing(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Shell("regsvr32 /u /s " & APP & "\1.dll")
        MessageBox.Show("本次運作時間 : " & RunTimeH & "時" & RunTimeM & "分" & RunTimeS & "秒")
        End
    End Sub

    Private Sub scriptStart()  ' 初始化 腳本
        Dim 蓋亞 = New 蓋亞
        Dim Thread蓋亞 As New Thread(AddressOf 蓋亞.start)
        Thread蓋亞.Start()

    End Sub

    ' HotKey
    Dim HotKey = New HotKey
    Private Sub TmrHotKey_Tick(sender As Object, e As EventArgs) Handles tmrHotKey.Tick
        If chk蓋亞.Checked And rdb蓋亞1.Checked Then
            HotKey.Press(cmb蓋亞key.Text, o蓋亞)
        ElseIf chk蓋亞.Checked And rdb蓋亞2.Checked Then
            HotKey.OnOff(cmb蓋亞key.Text, o蓋亞)
        End If


    End Sub

    Private Sub TmrUpdate_Tick(sender As Object, e As EventArgs) Handles tmrUpdate.Tick
        'c = 腳本子選項位置  e.g.  蓋亞 = 0  or  蓋亞刀戰 = 1
        't = 延遲
        c蓋亞 = cmb蓋亞.SelectedIndex
        t蓋亞1 = txt蓋亞1.Text
        t蓋亞2 = txt蓋亞2.Text

        lblRunTime.Text = "運作時間: " & vbCrLf & RunTimeH & "時" & RunTimeM & "分" & RunTimeS & "秒"
    End Sub

















    Dim RunTimeThread As New Thread(AddressOf RunTImeT)
    Sub RunTimeT()
        Do
            RunTimeS += 1
            If RunTimeS = 60 Then
                RunTimeM += 1
                RunTimeS = 0
            End If
            If RunTimeM = 60 Then
                RunTimeH += 1
                RunTimeM = 0
            End If
            Threading.Thread.Sleep(1000)
        Loop
    End Sub


    Private Sub dmDefaulted()  ' 初始化 大漠
        Try
            Shell("regsvr32 /s " & APP & "\1.dll")
            dm = CreateObject("dm.dmsoft")
        Catch exx As Exception
            MsgBox("Error ： dll defaulted fail " & vbCrLf & "請確保資料夾內有 1.dll 和資料夾名稱沒有空格",, "Error")
            Shell("regsvr32 /u /s " & APP & "\1.dll")
            End
        End Try

        Dim ver
        ver = dm.ver()

        If ver = 0 Then
            MsgBox("当前大漠插件未能正常调用")
            Shell("regsvr32 /u /s " & APP & "\1.dll")
            End
        Else
            MsgBox("此程式供免費使用" & vbCrLf & "切勿轉售" & vbCrLf & "使用任何輔助都有風險" & vbCrLf & "如使用此程式而被封鎖" & vbCrLf & "本人不負任何責任", MsgBoxStyle.Information)
        End If

        hwnd = dm.FindWindow("", "Counter-Strike Online")
        If hwnd = 0 Then
            MsgBox("CSO未開啟 程式關閉")
            Shell("regsvr32 /u /s " & APP & "\1.dll")
            End
        Else
            dm.BindWindow(hwnd, "gdi2", "normal", "windows", 4)
            dm.SetKeypadDelay("normal", 0)
            dm.SetKeypadDelay("windows", 0)
            dm.SetKeypadDelay("dx", 0)
        End If

    End Sub


    Private Sub rdb_CheckedChanged(sender As Object, e As EventArgs) Handles rdb前台.CheckedChanged, rdb後台.CheckedChanged
        If rdb前台.Checked Then
            kmode = 1
            lbl模式.Text = "模式 : 前台"
        ElseIf rdb後台.Checked Then
            kmode = 2
            lbl模式.Text = "模式 : 後台"
        End If
    End Sub

    'line
    '=========================================================================================
    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        Dim webAddress As String
        webAddress = "https://bingfeng.tw/thread-545178-1-1.html"
        Process.Start(webAddress)
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Dim webAddress2 As String
        webAddress2 = "https://www.facebook.com/yutinglia"
        Process.Start(webAddress2)
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim webAddress3 As String
        webAddress3 = "https://www.youtube.com/user/lyutinglial/videos?view_as=subscriber"
        Process.Start(webAddress3)
    End Sub

    Private Sub LinkLabel4_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel4.LinkClicked
        Dim webAddress4 As String
        webAddress4 = "https://sites.google.com/view/yutinglia/home/drscript"
        Process.Start(webAddress4)
    End Sub
    '=========================================================================================









    '=========================================================================================

    '                                        UI

    '=========================================================================================
    Private Sub cmbDefaulted() ' 初始化 combobox
        AddKeyItem_LA(cmb蓋亞key)

        cmbStyle.SelectedIndex = 0
        For Each tp In SkinTabControl1.TabPages
            For Each ctrl In tp.Controls
                If TypeOf ctrl Is ComboBox Then
                    ctrl.selectedIndex = 0
                End If
            Next
            For Each ctrl2 In tp.Controls
                If TypeOf ctrl2 Is GroupBox Then
                    For Each ctrl3 In ctrl2.Controls
                        If TypeOf ctrl3 Is ComboBox Then
                            ctrl3.selectedIndex = 0
                        End If
                    Next
                End If
            Next
        Next
        For Each tp2 In Me.Controls
            If TypeOf tp2 Is ComboBox Then
                tp2.selectedIndex = 0
            End If
        Next

    End Sub

    ' Light Theme
    Private Sub MetroTile1_Click(sender As Object, e As EventArgs) Handles tileLight.Click
        Dim txtColor = Color.Black
        Dim backColor = Color.White
        Dim themeColor = MetroFramework.MetroThemeStyle.Light

        Me.Theme = themeColor
        SkinTabControl1.PageNormlTxtColor = txtColor
        SkinTabControl1.PageDown = My.Resources.w123
        SkinTabControl1.PageHover = My.Resources.w1234

        cmbStyle.Theme = themeColor
        For Each tp0 In Controls
            If TypeOf tp0 Is MetroFramework.Controls.MetroTextBox Or TypeOf tp0 Is MetroFramework.Controls.MetroCheckBox Or TypeOf tp0 Is MetroFramework.Controls.MetroComboBox Or TypeOf tp0 Is MetroFramework.Controls.MetroRadioButton Then
                tp0.Theme = themeColor
            ElseIf TypeOf tp0 Is CCWin.SkinControl.SkinGroupBox Then
                tp0.TitleRectBackColor = backColor
                tp0.ForeColor = txtColor
                For Each txt2 In tp0.Controls
                    If TypeOf txt2 Is MetroFramework.Controls.MetroTextBox Or TypeOf txt2 Is MetroFramework.Controls.MetroCheckBox Or TypeOf txt2 Is MetroFramework.Controls.MetroComboBox Or TypeOf txt2 Is MetroFramework.Controls.MetroRadioButton Then
                        txt2.Theme = themeColor
                    End If
                Next
            End If
            For Each tp In SkinTabControl1.TabPages
                For Each txt In tp.Controls
                    If TypeOf txt Is MetroFramework.Controls.MetroTextBox Or TypeOf txt Is MetroFramework.Controls.MetroCheckBox Or TypeOf txt Is MetroFramework.Controls.MetroComboBox Or TypeOf txt Is MetroFramework.Controls.MetroRadioButton Then
                        txt.Theme = themeColor
                    ElseIf TypeOf txt Is CCWin.SkinControl.SkinGroupBox Then
                        txt.TitleRectBackColor = backColor
                        txt.ForeColor = txtColor
                        For Each txt2 In txt.Controls
                            If TypeOf txt2 Is MetroFramework.Controls.MetroTextBox Or TypeOf txt2 Is MetroFramework.Controls.MetroCheckBox Or TypeOf txt2 Is MetroFramework.Controls.MetroComboBox Or TypeOf txt2 Is MetroFramework.Controls.MetroRadioButton Then
                                txt2.Theme = themeColor
                            End If
                        Next
                    End If
                Next
            Next
        Next

        Select Case cmbStyle.Text
            Case "Blue"
                SkinTabControl1.PageDown = My.Resources.w123
                SkinTabControl1.PageHover = My.Resources.w1234
            Case "Orange"
                SkinTabControl1.PageDown = My.Resources.wo123
                SkinTabControl1.PageHover = My.Resources.wo1234
            Case "Pink"
                SkinTabControl1.PageDown = My.Resources.wp123
                SkinTabControl1.PageHover = My.Resources.wp1234
            Case "Red"
                SkinTabControl1.PageDown = My.Resources.wr123
                SkinTabControl1.PageHover = My.Resources.wr1234
        End Select

        Me.Refresh()
    End Sub

    ' Dark Theme
    Private Sub TileDark_Click(sender As Object, e As EventArgs) Handles tileDark.Click
        Dim txtColor = Color.White
        Dim backColor = Color.Black
        Dim themeColor = MetroFramework.MetroThemeStyle.Dark

        Me.Theme = themeColor
        SkinTabControl1.PageNormlTxtColor = txtColor
        SkinTabControl1.PageDown = My.Resources._123
        SkinTabControl1.PageHover = My.Resources._1234

        cmbStyle.Theme = themeColor
        For Each tp0 In Controls
            If TypeOf tp0 Is MetroFramework.Controls.MetroTextBox Or TypeOf tp0 Is MetroFramework.Controls.MetroCheckBox Or TypeOf tp0 Is MetroFramework.Controls.MetroComboBox Or TypeOf tp0 Is MetroFramework.Controls.MetroRadioButton Then
                tp0.Theme = themeColor
            ElseIf TypeOf tp0 Is CCWin.SkinControl.SkinGroupBox Then
                tp0.TitleRectBackColor = backColor
                tp0.ForeColor = txtColor
                For Each txt2 In tp0.Controls
                    If TypeOf txt2 Is MetroFramework.Controls.MetroTextBox Or TypeOf txt2 Is MetroFramework.Controls.MetroCheckBox Or TypeOf txt2 Is MetroFramework.Controls.MetroComboBox Or TypeOf txt2 Is MetroFramework.Controls.MetroRadioButton Then
                        txt2.Theme = themeColor
                    End If
                Next
            End If
            For Each tp In SkinTabControl1.TabPages
                For Each txt In tp.Controls
                    If TypeOf txt Is MetroFramework.Controls.MetroTextBox Or TypeOf txt Is MetroFramework.Controls.MetroCheckBox Or TypeOf txt Is MetroFramework.Controls.MetroComboBox Or TypeOf txt Is MetroFramework.Controls.MetroRadioButton Then
                        txt.Theme = themeColor
                    ElseIf TypeOf txt Is CCWin.SkinControl.SkinGroupBox Then
                        txt.TitleRectBackColor = backColor
                        txt.ForeColor = txtColor
                        For Each txt2 In txt.Controls
                            If TypeOf txt2 Is MetroFramework.Controls.MetroTextBox Or TypeOf txt2 Is MetroFramework.Controls.MetroCheckBox Or TypeOf txt2 Is MetroFramework.Controls.MetroComboBox Or TypeOf txt2 Is MetroFramework.Controls.MetroRadioButton Then
                                txt2.Theme = themeColor
                            End If
                        Next
                    End If
                Next
            Next
        Next
        Select Case cmbStyle.Text
            Case "Blue"
                SkinTabControl1.PageDown = My.Resources._123
                SkinTabControl1.PageHover = My.Resources._1234
            Case "Orange"
                SkinTabControl1.PageDown = My.Resources.o123
                SkinTabControl1.PageHover = My.Resources.o1234
            Case "Pink"
                SkinTabControl1.PageDown = My.Resources.p123
                SkinTabControl1.PageHover = My.Resources.p1234
            Case "Red"
                SkinTabControl1.PageDown = My.Resources.r123
                SkinTabControl1.PageHover = My.Resources.r1234
        End Select

        Me.Refresh()
    End Sub

    ' set style
    Private Sub CmbStyle_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbStyle.SelectedIndexChanged
        Select Case cmbStyle.Text
            Case "Blue"
                Me.Style = MetroFramework.MetroColorStyle.Blue
                If Me.Theme = MetroFramework.MetroThemeStyle.Dark Then
                    SkinTabControl1.PageDown = My.Resources._123
                    SkinTabControl1.PageHover = My.Resources._1234
                ElseIf Me.Theme = MetroFramework.MetroThemeStyle.Light Then
                    SkinTabControl1.PageDown = My.Resources.w123
                    SkinTabControl1.PageHover = My.Resources.w1234
                End If
                chStyle(MetroFramework.MetroColorStyle.Blue, Color.DeepSkyBlue, {192, 255, 255})
            Case "Orange"
                Me.Style = MetroFramework.MetroColorStyle.Orange
                If Me.Theme = MetroFramework.MetroThemeStyle.Dark Then
                    SkinTabControl1.PageDown = My.Resources.o123
                    SkinTabControl1.PageHover = My.Resources.o1234
                ElseIf Me.Theme = MetroFramework.MetroThemeStyle.Light Then
                    SkinTabControl1.PageDown = My.Resources.wo123
                    SkinTabControl1.PageHover = My.Resources.wo1234
                End If
                chStyle(MetroFramework.MetroColorStyle.Orange, Color.Orange, {255, 222, 0})
            Case "Pink"
                Me.Style = MetroFramework.MetroColorStyle.Pink
                If Me.Theme = MetroFramework.MetroThemeStyle.Dark Then
                    SkinTabControl1.PageDown = My.Resources.p123
                    SkinTabControl1.PageHover = My.Resources.p1234
                ElseIf Me.Theme = MetroFramework.MetroThemeStyle.Light Then
                    SkinTabControl1.PageDown = My.Resources.wp123
                    SkinTabControl1.PageHover = My.Resources.wp1234
                End If
                chStyle(MetroFramework.MetroColorStyle.Pink, Color.FromArgb(249, 153, 245), {255, 200, 255})
            Case "Red"
                Me.Style = MetroFramework.MetroColorStyle.Red
                If Me.Theme = MetroFramework.MetroThemeStyle.Dark Then
                    SkinTabControl1.PageDown = My.Resources.r123
                    SkinTabControl1.PageHover = My.Resources.r1234
                ElseIf Me.Theme = MetroFramework.MetroThemeStyle.Light Then
                    SkinTabControl1.PageDown = My.Resources.wr123
                    SkinTabControl1.PageHover = My.Resources.wr1234
                End If
                chStyle(MetroFramework.MetroColorStyle.Red, Color.Red, {255, 100, 100})
        End Select
    End Sub

    ' set style
    Sub chStyle(ByVal m, ByVal c, ByVal f)
        Dim mstyle = m
        Dim cstyle = c

        slabDr.ForeColor = Color.FromArgb(f(0), f(1), f(2))
        slabDr.BorderColor = c

        SkinTabControl1.PageDownTxtColor = c
        SkinTabControl1.PageHoverTxtColor = Color.FromArgb(f(0), f(1), f(2))

        tabp_1.BorderColor = c
        tabp_2.BorderColor = c
        tabp_3.BorderColor = c
        tabp_4.BorderColor = c
        tabp_5.BorderColor = c
        tabp_6.BorderColor = c
        tabp_7.BorderColor = c
        tabp_8.BorderColor = c
        tabp_9.BorderColor = c
        tabp_10.BorderColor = c

        tileDark.Style = m
        tileLight.Style = m
        cmbStyle.Style = m


        For Each tp0 In Controls
            If TypeOf tp0 Is MetroFramework.Controls.MetroCheckBox Or TypeOf tp0 Is MetroFramework.Controls.MetroComboBox Or TypeOf tp0 Is MetroFramework.Controls.MetroRadioButton Then
                tp0.style = mstyle
            ElseIf TypeOf tp0 Is CCWin.SkinControl.SkinGroupBox Then
                tp0.TitleBorderColor = cstyle
                tp0.BorderColor = cstyle
                For Each txt2 In tp0.Controls
                    If TypeOf txt2 Is MetroFramework.Controls.MetroCheckBox Or TypeOf txt2 Is MetroFramework.Controls.MetroComboBox Or TypeOf txt2 Is MetroFramework.Controls.MetroRadioButton Then
                        txt2.style = mstyle
                    End If
                Next
            End If
            For Each tp In SkinTabControl1.TabPages
                For Each txt In tp.Controls
                    If TypeOf txt Is MetroFramework.Controls.MetroCheckBox Or TypeOf txt Is MetroFramework.Controls.MetroComboBox Or TypeOf txt Is MetroFramework.Controls.MetroRadioButton Then
                        txt.style = mstyle
                    ElseIf TypeOf txt Is CCWin.SkinControl.SkinGroupBox Then
                        txt.TitleBorderColor = cstyle
                        txt.BorderColor = cstyle
                        For Each txt2 In txt.Controls
                            If TypeOf txt2 Is MetroFramework.Controls.MetroCheckBox Or TypeOf txt2 Is MetroFramework.Controls.MetroComboBox Or TypeOf txt2 Is MetroFramework.Controls.MetroRadioButton Then
                                txt2.style = mstyle
                            End If
                        Next
                    End If
                Next
            Next
        Next
        Me.Refresh()
    End Sub

    '=========================================================================================



    '=========================================================================================





End Class

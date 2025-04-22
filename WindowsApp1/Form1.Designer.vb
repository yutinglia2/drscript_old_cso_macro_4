<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits MetroFramework.Forms.MetroForm

    'Form 覆寫 Dispose 以清除元件清單。
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

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請勿使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.SkinTabControl1 = New CCWin.SkinControl.SkinTabControl()
        Me.tabp_1 = New CCWin.SkinControl.SkinTabPage()
        Me.tabp_2 = New CCWin.SkinControl.SkinTabPage()
        Me.SkinGroupBox1 = New CCWin.SkinControl.SkinGroupBox()
        Me.rdb蓋亞2 = New MetroFramework.Controls.MetroRadioButton()
        Me.rdb蓋亞1 = New MetroFramework.Controls.MetroRadioButton()
        Me.cmb蓋亞key = New MetroFramework.Controls.MetroComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt蓋亞2 = New MetroFramework.Controls.MetroTextBox()
        Me.txt蓋亞1 = New MetroFramework.Controls.MetroTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmb蓋亞 = New MetroFramework.Controls.MetroComboBox()
        Me.chk蓋亞 = New MetroFramework.Controls.MetroCheckBox()
        Me.tabp_3 = New CCWin.SkinControl.SkinTabPage()
        Me.tabp_4 = New CCWin.SkinControl.SkinTabPage()
        Me.tabp_5 = New CCWin.SkinControl.SkinTabPage()
        Me.tabp_6 = New CCWin.SkinControl.SkinTabPage()
        Me.tabp_7 = New CCWin.SkinControl.SkinTabPage()
        Me.tabp_8 = New CCWin.SkinControl.SkinTabPage()
        Me.tabp_9 = New CCWin.SkinControl.SkinTabPage()
        Me.tabp_10 = New CCWin.SkinControl.SkinTabPage()
        Me.SkinGroupBox3 = New CCWin.SkinControl.SkinGroupBox()
        Me.LinkLabel4 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel3 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.slabDr = New CCWin.SkinControl.SkinLabel()
        Me.tileLight = New MetroFramework.Controls.MetroTile()
        Me.tileDark = New MetroFramework.Controls.MetroTile()
        Me.cmbStyle = New MetroFramework.Controls.MetroComboBox()
        Me.tmrHotKey = New System.Windows.Forms.Timer(Me.components)
        Me.rdb前台 = New MetroFramework.Controls.MetroRadioButton()
        Me.rdb後台 = New MetroFramework.Controls.MetroRadioButton()
        Me.SkinGroupBox2 = New CCWin.SkinControl.SkinGroupBox()
        Me.lbl模式 = New System.Windows.Forms.Label()
        Me.lblRunTime = New System.Windows.Forms.Label()
        Me.tmrUpdate = New System.Windows.Forms.Timer(Me.components)
        Me.SkinTabControl1.SuspendLayout()
        Me.tabp_2.SuspendLayout()
        Me.SkinGroupBox1.SuspendLayout()
        Me.tabp_10.SuspendLayout()
        Me.SkinGroupBox3.SuspendLayout()
        Me.SkinGroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'SkinTabControl1
        '
        Me.SkinTabControl1.Alignment = System.Windows.Forms.TabAlignment.Left
        Me.SkinTabControl1.AnimatorType = CCWin.SkinControl.AnimationType.HorizSlide
        Me.SkinTabControl1.CloseRect = New System.Drawing.Rectangle(2, 2, 12, 12)
        Me.SkinTabControl1.Controls.Add(Me.tabp_1)
        Me.SkinTabControl1.Controls.Add(Me.tabp_2)
        Me.SkinTabControl1.Controls.Add(Me.tabp_3)
        Me.SkinTabControl1.Controls.Add(Me.tabp_4)
        Me.SkinTabControl1.Controls.Add(Me.tabp_5)
        Me.SkinTabControl1.Controls.Add(Me.tabp_6)
        Me.SkinTabControl1.Controls.Add(Me.tabp_7)
        Me.SkinTabControl1.Controls.Add(Me.tabp_8)
        Me.SkinTabControl1.Controls.Add(Me.tabp_9)
        Me.SkinTabControl1.Controls.Add(Me.tabp_10)
        Me.SkinTabControl1.HeadBack = Nothing
        Me.SkinTabControl1.ImgTxtOffset = New System.Drawing.Point(0, 0)
        Me.SkinTabControl1.ItemSize = New System.Drawing.Size(40, 150)
        Me.SkinTabControl1.Location = New System.Drawing.Point(-6, 30)
        Me.SkinTabControl1.Multiline = True
        Me.SkinTabControl1.Name = "SkinTabControl1"
        Me.SkinTabControl1.PageArrowDown = CType(resources.GetObject("SkinTabControl1.PageArrowDown"), System.Drawing.Image)
        Me.SkinTabControl1.PageArrowHover = CType(resources.GetObject("SkinTabControl1.PageArrowHover"), System.Drawing.Image)
        Me.SkinTabControl1.PageCloseHover = CType(resources.GetObject("SkinTabControl1.PageCloseHover"), System.Drawing.Image)
        Me.SkinTabControl1.PageCloseNormal = CType(resources.GetObject("SkinTabControl1.PageCloseNormal"), System.Drawing.Image)
        Me.SkinTabControl1.PageDown = Global.WindowsApp1.My.Resources.Resources._123
        Me.SkinTabControl1.PageDownTxtColor = System.Drawing.Color.DeepSkyBlue
        Me.SkinTabControl1.PageHover = Global.WindowsApp1.My.Resources.Resources._1234
        Me.SkinTabControl1.PageHoverTxtColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SkinTabControl1.PageImagePosition = CCWin.SkinControl.SkinTabControl.ePageImagePosition.Left
        Me.SkinTabControl1.PageNorml = Nothing
        Me.SkinTabControl1.PageNormlTxtColor = System.Drawing.Color.White
        Me.SkinTabControl1.SelectedIndex = 0
        Me.SkinTabControl1.Size = New System.Drawing.Size(891, 493)
        Me.SkinTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.SkinTabControl1.TabIndex = 0
        '
        'tabp_1
        '
        Me.tabp_1.BackColor = System.Drawing.Color.Transparent
        Me.tabp_1.BorderColor = System.Drawing.Color.DeepSkyBlue
        Me.tabp_1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabp_1.Location = New System.Drawing.Point(150, 0)
        Me.tabp_1.Name = "tabp_1"
        Me.tabp_1.Size = New System.Drawing.Size(741, 493)
        Me.tabp_1.TabIndex = 0
        Me.tabp_1.TabItemImage = Nothing
        Me.tabp_1.Text = "主頁"
        '
        'tabp_2
        '
        Me.tabp_2.BackColor = System.Drawing.Color.Transparent
        Me.tabp_2.BorderColor = System.Drawing.Color.DeepSkyBlue
        Me.tabp_2.Controls.Add(Me.SkinGroupBox1)
        Me.tabp_2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabp_2.Location = New System.Drawing.Point(150, 0)
        Me.tabp_2.Name = "tabp_2"
        Me.tabp_2.Size = New System.Drawing.Size(741, 493)
        Me.tabp_2.TabIndex = 1
        Me.tabp_2.TabItemImage = Nothing
        Me.tabp_2.Text = "腳本一"
        '
        'SkinGroupBox1
        '
        Me.SkinGroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.SkinGroupBox1.BorderColor = System.Drawing.Color.DeepSkyBlue
        Me.SkinGroupBox1.Controls.Add(Me.rdb蓋亞2)
        Me.SkinGroupBox1.Controls.Add(Me.rdb蓋亞1)
        Me.SkinGroupBox1.Controls.Add(Me.cmb蓋亞key)
        Me.SkinGroupBox1.Controls.Add(Me.Label2)
        Me.SkinGroupBox1.Controls.Add(Me.txt蓋亞2)
        Me.SkinGroupBox1.Controls.Add(Me.txt蓋亞1)
        Me.SkinGroupBox1.Controls.Add(Me.Label1)
        Me.SkinGroupBox1.Controls.Add(Me.cmb蓋亞)
        Me.SkinGroupBox1.Controls.Add(Me.chk蓋亞)
        Me.SkinGroupBox1.ForeColor = System.Drawing.Color.White
        Me.SkinGroupBox1.Location = New System.Drawing.Point(19, 3)
        Me.SkinGroupBox1.Name = "SkinGroupBox1"
        Me.SkinGroupBox1.RectBackColor = System.Drawing.Color.Transparent
        Me.SkinGroupBox1.RoundStyle = CCWin.SkinClass.RoundStyle.All
        Me.SkinGroupBox1.Size = New System.Drawing.Size(701, 132)
        Me.SkinGroupBox1.TabIndex = 0
        Me.SkinGroupBox1.TabStop = False
        Me.SkinGroupBox1.Text = "蓋亞"
        Me.SkinGroupBox1.TitleBorderColor = System.Drawing.Color.DeepSkyBlue
        Me.SkinGroupBox1.TitleRectBackColor = System.Drawing.Color.Black
        Me.SkinGroupBox1.TitleRoundStyle = CCWin.SkinClass.RoundStyle.All
        '
        'rdb蓋亞2
        '
        Me.rdb蓋亞2.AutoSize = True
        Me.rdb蓋亞2.FontSize = MetroFramework.MetroCheckBoxSize.Tall
        Me.rdb蓋亞2.Location = New System.Drawing.Point(354, 90)
        Me.rdb蓋亞2.Name = "rdb蓋亞2"
        Me.rdb蓋亞2.Size = New System.Drawing.Size(66, 25)
        Me.rdb蓋亞2.TabIndex = 8
        Me.rdb蓋亞2.Text = "開關"
        Me.rdb蓋亞2.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.rdb蓋亞2.UseSelectable = True
        '
        'rdb蓋亞1
        '
        Me.rdb蓋亞1.AutoSize = True
        Me.rdb蓋亞1.Checked = True
        Me.rdb蓋亞1.FontSize = MetroFramework.MetroCheckBoxSize.Tall
        Me.rdb蓋亞1.Location = New System.Drawing.Point(287, 90)
        Me.rdb蓋亞1.Name = "rdb蓋亞1"
        Me.rdb蓋亞1.Size = New System.Drawing.Size(66, 25)
        Me.rdb蓋亞1.TabIndex = 7
        Me.rdb蓋亞1.TabStop = True
        Me.rdb蓋亞1.Text = "按住"
        Me.rdb蓋亞1.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.rdb蓋亞1.UseSelectable = True
        '
        'cmb蓋亞key
        '
        Me.cmb蓋亞key.DropDownHeight = 200
        Me.cmb蓋亞key.ForeColor = System.Drawing.Color.White
        Me.cmb蓋亞key.FormattingEnabled = True
        Me.cmb蓋亞key.IntegralHeight = False
        Me.cmb蓋亞key.ItemHeight = 23
        Me.cmb蓋亞key.Items.AddRange(New Object() {"蓋亞", "蓋亞刀戰", "蓋亞購買區"})
        Me.cmb蓋亞key.Location = New System.Drawing.Point(88, 88)
        Me.cmb蓋亞key.Name = "cmb蓋亞key"
        Me.cmb蓋亞key.Size = New System.Drawing.Size(189, 29)
        Me.cmb蓋亞key.TabIndex = 6
        Me.cmb蓋亞key.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.cmb蓋亞key.UseSelectable = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("新細明體", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label2.Location = New System.Drawing.Point(29, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 21)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "熱鍵"
        '
        'txt蓋亞2
        '
        '
        '
        '
        Me.txt蓋亞2.CustomButton.Image = Nothing
        Me.txt蓋亞2.CustomButton.Location = New System.Drawing.Point(36, 2)
        Me.txt蓋亞2.CustomButton.Name = ""
        Me.txt蓋亞2.CustomButton.Size = New System.Drawing.Size(23, 23)
        Me.txt蓋亞2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txt蓋亞2.CustomButton.TabIndex = 1
        Me.txt蓋亞2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txt蓋亞2.CustomButton.UseSelectable = True
        Me.txt蓋亞2.CustomButton.Visible = False
        Me.txt蓋亞2.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txt蓋亞2.Lines = New String() {"280"}
        Me.txt蓋亞2.Location = New System.Drawing.Point(409, 27)
        Me.txt蓋亞2.MaxLength = 6
        Me.txt蓋亞2.Name = "txt蓋亞2"
        Me.txt蓋亞2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt蓋亞2.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt蓋亞2.SelectedText = ""
        Me.txt蓋亞2.SelectionLength = 0
        Me.txt蓋亞2.SelectionStart = 0
        Me.txt蓋亞2.ShortcutsEnabled = True
        Me.txt蓋亞2.Size = New System.Drawing.Size(62, 28)
        Me.txt蓋亞2.TabIndex = 5
        Me.txt蓋亞2.Text = "280"
        Me.txt蓋亞2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txt蓋亞2.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.txt蓋亞2.UseSelectable = True
        Me.txt蓋亞2.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txt蓋亞2.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txt蓋亞1
        '
        '
        '
        '
        Me.txt蓋亞1.CustomButton.Image = Nothing
        Me.txt蓋亞1.CustomButton.Location = New System.Drawing.Point(36, 2)
        Me.txt蓋亞1.CustomButton.Name = ""
        Me.txt蓋亞1.CustomButton.Size = New System.Drawing.Size(23, 23)
        Me.txt蓋亞1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txt蓋亞1.CustomButton.TabIndex = 1
        Me.txt蓋亞1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txt蓋亞1.CustomButton.UseSelectable = True
        Me.txt蓋亞1.CustomButton.Visible = False
        Me.txt蓋亞1.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txt蓋亞1.Lines = New String() {"370"}
        Me.txt蓋亞1.Location = New System.Drawing.Point(341, 27)
        Me.txt蓋亞1.MaxLength = 6
        Me.txt蓋亞1.Name = "txt蓋亞1"
        Me.txt蓋亞1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt蓋亞1.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt蓋亞1.SelectedText = ""
        Me.txt蓋亞1.SelectionLength = 0
        Me.txt蓋亞1.SelectionStart = 0
        Me.txt蓋亞1.ShortcutsEnabled = True
        Me.txt蓋亞1.Size = New System.Drawing.Size(62, 28)
        Me.txt蓋亞1.TabIndex = 4
        Me.txt蓋亞1.Text = "370"
        Me.txt蓋亞1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txt蓋亞1.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.txt蓋亞1.UseSelectable = True
        Me.txt蓋亞1.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txt蓋亞1.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("新細明體", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.Location = New System.Drawing.Point(283, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 21)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "延遲"
        '
        'cmb蓋亞
        '
        Me.cmb蓋亞.DropDownHeight = 200
        Me.cmb蓋亞.ForeColor = System.Drawing.Color.White
        Me.cmb蓋亞.FormattingEnabled = True
        Me.cmb蓋亞.IntegralHeight = False
        Me.cmb蓋亞.ItemHeight = 23
        Me.cmb蓋亞.Items.AddRange(New Object() {"蓋亞", "蓋亞刀戰", "蓋亞購買區"})
        Me.cmb蓋亞.Location = New System.Drawing.Point(88, 26)
        Me.cmb蓋亞.Name = "cmb蓋亞"
        Me.cmb蓋亞.Size = New System.Drawing.Size(189, 29)
        Me.cmb蓋亞.TabIndex = 1
        Me.cmb蓋亞.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.cmb蓋亞.UseSelectable = True
        '
        'chk蓋亞
        '
        Me.chk蓋亞.AutoSize = True
        Me.chk蓋亞.FontSize = MetroFramework.MetroCheckBoxSize.Tall
        Me.chk蓋亞.ForeColor = System.Drawing.Color.White
        Me.chk蓋亞.Location = New System.Drawing.Point(16, 30)
        Me.chk蓋亞.Name = "chk蓋亞"
        Me.chk蓋亞.Size = New System.Drawing.Size(66, 25)
        Me.chk蓋亞.TabIndex = 0
        Me.chk蓋亞.Text = "啟用"
        Me.chk蓋亞.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.chk蓋亞.UseSelectable = True
        '
        'tabp_3
        '
        Me.tabp_3.BackColor = System.Drawing.Color.Transparent
        Me.tabp_3.BorderColor = System.Drawing.Color.DeepSkyBlue
        Me.tabp_3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabp_3.Location = New System.Drawing.Point(150, 0)
        Me.tabp_3.Name = "tabp_3"
        Me.tabp_3.Size = New System.Drawing.Size(741, 493)
        Me.tabp_3.TabIndex = 2
        Me.tabp_3.TabItemImage = Nothing
        Me.tabp_3.Text = "腳本二"
        '
        'tabp_4
        '
        Me.tabp_4.BackColor = System.Drawing.Color.Transparent
        Me.tabp_4.BorderColor = System.Drawing.Color.DeepSkyBlue
        Me.tabp_4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabp_4.Location = New System.Drawing.Point(150, 0)
        Me.tabp_4.Name = "tabp_4"
        Me.tabp_4.Size = New System.Drawing.Size(741, 493)
        Me.tabp_4.TabIndex = 3
        Me.tabp_4.TabItemImage = Nothing
        Me.tabp_4.Text = "跳躍腳本"
        '
        'tabp_5
        '
        Me.tabp_5.BackColor = System.Drawing.Color.Transparent
        Me.tabp_5.BorderColor = System.Drawing.Color.DeepSkyBlue
        Me.tabp_5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabp_5.Location = New System.Drawing.Point(150, 0)
        Me.tabp_5.Name = "tabp_5"
        Me.tabp_5.Size = New System.Drawing.Size(741, 493)
        Me.tabp_5.TabIndex = 4
        Me.tabp_5.TabItemImage = Nothing
        Me.tabp_5.Text = "可編腳本"
        '
        'tabp_6
        '
        Me.tabp_6.BackColor = System.Drawing.Color.Transparent
        Me.tabp_6.BorderColor = System.Drawing.Color.DeepSkyBlue
        Me.tabp_6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabp_6.Location = New System.Drawing.Point(150, 0)
        Me.tabp_6.Name = "tabp_6"
        Me.tabp_6.Size = New System.Drawing.Size(741, 493)
        Me.tabp_6.TabIndex = 5
        Me.tabp_6.TabItemImage = Nothing
        Me.tabp_6.Text = "後台掛機"
        '
        'tabp_7
        '
        Me.tabp_7.BackColor = System.Drawing.Color.Transparent
        Me.tabp_7.BorderColor = System.Drawing.Color.DeepSkyBlue
        Me.tabp_7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabp_7.Location = New System.Drawing.Point(150, 0)
        Me.tabp_7.Name = "tabp_7"
        Me.tabp_7.Size = New System.Drawing.Size(741, 493)
        Me.tabp_7.TabIndex = 6
        Me.tabp_7.TabItemImage = Nothing
        Me.tabp_7.Text = "掛機設定"
        '
        'tabp_8
        '
        Me.tabp_8.BackColor = System.Drawing.Color.Transparent
        Me.tabp_8.BorderColor = System.Drawing.Color.DeepSkyBlue
        Me.tabp_8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabp_8.Location = New System.Drawing.Point(150, 0)
        Me.tabp_8.Name = "tabp_8"
        Me.tabp_8.Size = New System.Drawing.Size(741, 493)
        Me.tabp_8.TabIndex = 7
        Me.tabp_8.TabItemImage = Nothing
        Me.tabp_8.Text = "其他功能"
        '
        'tabp_9
        '
        Me.tabp_9.BackColor = System.Drawing.Color.Transparent
        Me.tabp_9.BorderColor = System.Drawing.Color.DeepSkyBlue
        Me.tabp_9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabp_9.Location = New System.Drawing.Point(150, 0)
        Me.tabp_9.Name = "tabp_9"
        Me.tabp_9.Size = New System.Drawing.Size(741, 493)
        Me.tabp_9.TabIndex = 8
        Me.tabp_9.TabItemImage = Nothing
        Me.tabp_9.Text = "腳本設定"
        '
        'tabp_10
        '
        Me.tabp_10.BackColor = System.Drawing.Color.Transparent
        Me.tabp_10.BorderColor = System.Drawing.Color.DeepSkyBlue
        Me.tabp_10.Controls.Add(Me.SkinGroupBox3)
        Me.tabp_10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabp_10.Location = New System.Drawing.Point(150, 0)
        Me.tabp_10.Name = "tabp_10"
        Me.tabp_10.Size = New System.Drawing.Size(741, 493)
        Me.tabp_10.TabIndex = 9
        Me.tabp_10.TabItemImage = Nothing
        Me.tabp_10.Text = "關於"
        '
        'SkinGroupBox3
        '
        Me.SkinGroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.SkinGroupBox3.BorderColor = System.Drawing.Color.DeepSkyBlue
        Me.SkinGroupBox3.Controls.Add(Me.LinkLabel4)
        Me.SkinGroupBox3.Controls.Add(Me.LinkLabel3)
        Me.SkinGroupBox3.Controls.Add(Me.LinkLabel2)
        Me.SkinGroupBox3.Controls.Add(Me.LinkLabel1)
        Me.SkinGroupBox3.Controls.Add(Me.Label3)
        Me.SkinGroupBox3.ForeColor = System.Drawing.Color.White
        Me.SkinGroupBox3.Location = New System.Drawing.Point(-12, -9)
        Me.SkinGroupBox3.Name = "SkinGroupBox3"
        Me.SkinGroupBox3.RectBackColor = System.Drawing.Color.Transparent
        Me.SkinGroupBox3.RoundStyle = CCWin.SkinClass.RoundStyle.All
        Me.SkinGroupBox3.Size = New System.Drawing.Size(768, 512)
        Me.SkinGroupBox3.TabIndex = 2
        Me.SkinGroupBox3.TabStop = False
        Me.SkinGroupBox3.TitleBorderColor = System.Drawing.Color.DeepSkyBlue
        Me.SkinGroupBox3.TitleRectBackColor = System.Drawing.Color.Black
        Me.SkinGroupBox3.TitleRoundStyle = CCWin.SkinClass.RoundStyle.All
        '
        'LinkLabel4
        '
        Me.LinkLabel4.ActiveLinkColor = System.Drawing.Color.White
        Me.LinkLabel4.AutoSize = True
        Me.LinkLabel4.Font = New System.Drawing.Font("微軟正黑體", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LinkLabel4.LinkColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LinkLabel4.Location = New System.Drawing.Point(682, 458)
        Me.LinkLabel4.Name = "LinkLabel4"
        Me.LinkLabel4.Size = New System.Drawing.Size(54, 27)
        Me.LinkLabel4.TabIndex = 170
        Me.LinkLabel4.TabStop = True
        Me.LinkLabel4.Text = "網站"
        '
        'LinkLabel3
        '
        Me.LinkLabel3.ActiveLinkColor = System.Drawing.Color.White
        Me.LinkLabel3.AutoSize = True
        Me.LinkLabel3.Font = New System.Drawing.Font("微軟正黑體", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LinkLabel3.LinkColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LinkLabel3.Location = New System.Drawing.Point(323, 458)
        Me.LinkLabel3.Name = "LinkLabel3"
        Me.LinkLabel3.Size = New System.Drawing.Size(54, 27)
        Me.LinkLabel3.TabIndex = 169
        Me.LinkLabel3.TabStop = True
        Me.LinkLabel3.Text = "冰楓"
        '
        'LinkLabel2
        '
        Me.LinkLabel2.ActiveLinkColor = System.Drawing.Color.White
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.Font = New System.Drawing.Font("微軟正黑體", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LinkLabel2.LinkColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LinkLabel2.Location = New System.Drawing.Point(409, 458)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(107, 27)
        Me.LinkLabel2.TabIndex = 168
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "Facebook"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.ActiveLinkColor = System.Drawing.Color.White
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("微軟正黑體", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LinkLabel1.LinkColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LinkLabel1.Location = New System.Drawing.Point(551, 458)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(100, 27)
        Me.LinkLabel1.TabIndex = 167
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "YouTube"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label3.Location = New System.Drawing.Point(28, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(321, 240)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = resources.GetString("Label3.Text")
        '
        'slabDr
        '
        Me.slabDr.AutoSize = True
        Me.slabDr.BackColor = System.Drawing.Color.Transparent
        Me.slabDr.BorderColor = System.Drawing.Color.DeepSkyBlue
        Me.slabDr.BorderSize = 2
        Me.slabDr.Font = New System.Drawing.Font("Brush Script MT", 48.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.slabDr.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.slabDr.Location = New System.Drawing.Point(891, 30)
        Me.slabDr.Name = "slabDr"
        Me.slabDr.Size = New System.Drawing.Size(117, 79)
        Me.slabDr.TabIndex = 1
        Me.slabDr.Text = "DR"
        '
        'tileLight
        '
        Me.tileLight.ActiveControl = Nothing
        Me.tileLight.Location = New System.Drawing.Point(64, 364)
        Me.tileLight.Name = "tileLight"
        Me.tileLight.Size = New System.Drawing.Size(50, 50)
        Me.tileLight.TabIndex = 2
        Me.tileLight.Text = "亮"
        Me.tileLight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.tileLight.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tileLight.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall
        Me.tileLight.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold
        Me.tileLight.UseSelectable = True
        '
        'tileDark
        '
        Me.tileDark.ActiveControl = Nothing
        Me.tileDark.Location = New System.Drawing.Point(8, 364)
        Me.tileDark.Name = "tileDark"
        Me.tileDark.Size = New System.Drawing.Size(50, 50)
        Me.tileDark.TabIndex = 3
        Me.tileDark.Text = "暗"
        Me.tileDark.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.tileDark.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.tileDark.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall
        Me.tileDark.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold
        Me.tileDark.UseCustomForeColor = True
        Me.tileDark.UseSelectable = True
        '
        'cmbStyle
        '
        Me.cmbStyle.DropDownHeight = 150
        Me.cmbStyle.ForeColor = System.Drawing.Color.White
        Me.cmbStyle.FormattingEnabled = True
        Me.cmbStyle.IntegralHeight = False
        Me.cmbStyle.ItemHeight = 23
        Me.cmbStyle.Items.AddRange(New Object() {"Blue", "Orange", "Pink", "Red"})
        Me.cmbStyle.Location = New System.Drawing.Point(8, 329)
        Me.cmbStyle.Name = "cmbStyle"
        Me.cmbStyle.Size = New System.Drawing.Size(106, 29)
        Me.cmbStyle.TabIndex = 7
        Me.cmbStyle.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.cmbStyle.UseSelectable = True
        '
        'tmrHotKey
        '
        Me.tmrHotKey.Enabled = True
        Me.tmrHotKey.Interval = 50
        '
        'rdb前台
        '
        Me.rdb前台.AutoSize = True
        Me.rdb前台.Checked = True
        Me.rdb前台.FontSize = MetroFramework.MetroCheckBoxSize.Tall
        Me.rdb前台.Location = New System.Drawing.Point(8, 269)
        Me.rdb前台.Name = "rdb前台"
        Me.rdb前台.Size = New System.Drawing.Size(66, 25)
        Me.rdb前台.TabIndex = 8
        Me.rdb前台.TabStop = True
        Me.rdb前台.Text = "前台"
        Me.rdb前台.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.rdb前台.UseSelectable = True
        '
        'rdb後台
        '
        Me.rdb後台.AutoSize = True
        Me.rdb後台.FontSize = MetroFramework.MetroCheckBoxSize.Tall
        Me.rdb後台.Location = New System.Drawing.Point(8, 300)
        Me.rdb後台.Name = "rdb後台"
        Me.rdb後台.Size = New System.Drawing.Size(66, 25)
        Me.rdb後台.TabIndex = 9
        Me.rdb後台.Text = "後台"
        Me.rdb後台.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.rdb後台.UseSelectable = True
        '
        'SkinGroupBox2
        '
        Me.SkinGroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.SkinGroupBox2.BorderColor = System.Drawing.Color.DeepSkyBlue
        Me.SkinGroupBox2.Controls.Add(Me.lbl模式)
        Me.SkinGroupBox2.Controls.Add(Me.lblRunTime)
        Me.SkinGroupBox2.Controls.Add(Me.tileLight)
        Me.SkinGroupBox2.Controls.Add(Me.rdb後台)
        Me.SkinGroupBox2.Controls.Add(Me.tileDark)
        Me.SkinGroupBox2.Controls.Add(Me.rdb前台)
        Me.SkinGroupBox2.Controls.Add(Me.cmbStyle)
        Me.SkinGroupBox2.ForeColor = System.Drawing.Color.White
        Me.SkinGroupBox2.Location = New System.Drawing.Point(889, 102)
        Me.SkinGroupBox2.Name = "SkinGroupBox2"
        Me.SkinGroupBox2.RectBackColor = System.Drawing.Color.Transparent
        Me.SkinGroupBox2.RoundStyle = CCWin.SkinClass.RoundStyle.All
        Me.SkinGroupBox2.Size = New System.Drawing.Size(119, 421)
        Me.SkinGroupBox2.TabIndex = 1
        Me.SkinGroupBox2.TabStop = False
        Me.SkinGroupBox2.TitleBorderColor = System.Drawing.Color.DeepSkyBlue
        Me.SkinGroupBox2.TitleRectBackColor = System.Drawing.Color.Black
        Me.SkinGroupBox2.TitleRoundStyle = CCWin.SkinClass.RoundStyle.All
        '
        'lbl模式
        '
        Me.lbl模式.AutoSize = True
        Me.lbl模式.Font = New System.Drawing.Font("微軟正黑體", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lbl模式.Location = New System.Drawing.Point(6, 242)
        Me.lbl模式.Name = "lbl模式"
        Me.lbl模式.Size = New System.Drawing.Size(101, 24)
        Me.lbl模式.TabIndex = 16
        Me.lbl模式.Text = "模式 : 前台"
        '
        'lblRunTime
        '
        Me.lblRunTime.AutoSize = True
        Me.lblRunTime.Font = New System.Drawing.Font("微軟正黑體", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblRunTime.Location = New System.Drawing.Point(6, 197)
        Me.lblRunTime.Name = "lblRunTime"
        Me.lblRunTime.Size = New System.Drawing.Size(21, 19)
        Me.lblRunTime.TabIndex = 15
        Me.lblRunTime.Text = "rt"
        '
        'tmrUpdate
        '
        Me.tmrUpdate.Enabled = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(1033, 548)
        Me.Controls.Add(Me.SkinGroupBox2)
        Me.Controls.Add(Me.slabDr)
        Me.Controls.Add(Me.SkinTabControl1)
        Me.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Resizable = False
        Me.Style = MetroFramework.MetroColorStyle.[Default]
        Me.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.SkinTabControl1.ResumeLayout(False)
        Me.tabp_2.ResumeLayout(False)
        Me.SkinGroupBox1.ResumeLayout(False)
        Me.SkinGroupBox1.PerformLayout()
        Me.tabp_10.ResumeLayout(False)
        Me.SkinGroupBox3.ResumeLayout(False)
        Me.SkinGroupBox3.PerformLayout()
        Me.SkinGroupBox2.ResumeLayout(False)
        Me.SkinGroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Public WithEvents SkinTabControl1 As CCWin.SkinControl.SkinTabControl
    Public WithEvents tabp_1 As CCWin.SkinControl.SkinTabPage
    Public WithEvents tabp_2 As CCWin.SkinControl.SkinTabPage
    Public WithEvents tabp_3 As CCWin.SkinControl.SkinTabPage
    Public WithEvents tabp_4 As CCWin.SkinControl.SkinTabPage
    Public WithEvents tabp_5 As CCWin.SkinControl.SkinTabPage
    Public WithEvents tabp_6 As CCWin.SkinControl.SkinTabPage
    Public WithEvents tabp_7 As CCWin.SkinControl.SkinTabPage
    Public WithEvents slabDr As CCWin.SkinControl.SkinLabel
    Public WithEvents tabp_8 As CCWin.SkinControl.SkinTabPage
    Public WithEvents tabp_9 As CCWin.SkinControl.SkinTabPage
    Public WithEvents SkinGroupBox1 As CCWin.SkinControl.SkinGroupBox
    Public WithEvents chk蓋亞 As MetroFramework.Controls.MetroCheckBox
    Public WithEvents cmb蓋亞 As MetroFramework.Controls.MetroComboBox
    Public WithEvents Label1 As Label
    Public WithEvents txt蓋亞1 As MetroFramework.Controls.MetroTextBox
    Public WithEvents txt蓋亞2 As MetroFramework.Controls.MetroTextBox
    Public WithEvents tileLight As MetroFramework.Controls.MetroTile
    Public WithEvents tileDark As MetroFramework.Controls.MetroTile
    Public WithEvents Label2 As Label
    Public WithEvents cmbStyle As MetroFramework.Controls.MetroComboBox
    Public WithEvents tabp_10 As CCWin.SkinControl.SkinTabPage
    Public WithEvents rdb蓋亞2 As MetroFramework.Controls.MetroRadioButton
    Public WithEvents rdb蓋亞1 As MetroFramework.Controls.MetroRadioButton
    Public WithEvents tmrHotKey As Timer
    Public WithEvents rdb前台 As MetroFramework.Controls.MetroRadioButton
    Public WithEvents rdb後台 As MetroFramework.Controls.MetroRadioButton
    Public WithEvents SkinGroupBox2 As CCWin.SkinControl.SkinGroupBox
    Public WithEvents cmb蓋亞key As MetroFramework.Controls.MetroComboBox
    Friend WithEvents tmrUpdate As Timer
    Friend WithEvents lblRunTime As Label
    Public WithEvents SkinGroupBox3 As CCWin.SkinControl.SkinGroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents LinkLabel4 As LinkLabel
    Friend WithEvents LinkLabel3 As LinkLabel
    Friend WithEvents LinkLabel2 As LinkLabel
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents lbl模式 As Label
End Class

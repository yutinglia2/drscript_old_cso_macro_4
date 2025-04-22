Module ModuleKey

    Public dm As Object

    Public strKey() As String = {"熱鍵選擇", "Enter", "Shift", "Ctrl", "Alt", "Space", "PageUp", "PageDown", "Insert", "Delete", "Home", "End", "Left", "Up", "Right", "Down", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "F1", "F2", "F3", "F4", "F5", "F6", "F7", "F8", "F9", "F10", "F11", "F12", "ESCAPE", "滑鼠中鍵", "滑鼠側鍵1", "滑鼠側鍵2"}

    Public MyVar, APP

    Public Declare Function GetAsyncKeyState Lib "user32" (ByVal vKey As UInt32) As Short
    Public Declare Function GetKeyState Lib "user32" (ByVal vKey As Integer) As Short

    Public o蓋亞, oDesperado, o湛盧BUG, o極道滅殺, o瞬狙, o閃擊斯特恩, o刷1槍, o雙王者, o卡空, oGS, oSGS As Boolean
    Public c蓋亞, cDesperado, c湛盧BUG, c極道滅殺, c瞬狙, c閃擊斯特恩, c刷1槍, c雙王者, c卡空, cGS, cSGS As Integer

    Public t蓋亞1, t蓋亞2 As Integer

    Public rndNum As New Random()
    Public kmode As String
    Public hwnd

    Public RunTimeS, RunTimeM, RunTimeH As Integer

    Public mkeyL As String = "["
    Public mkeyR As String = "]"
    Public afk護甲Key As String = "]"


    Public ReadOnly Property GetVar()
        Get
            Return My.Application.Info.Version.Major & "." & My.Application.Info.Version.Minor & "." & My.Application.Info.Version.Build '取得版本號碼
        End Get
    End Property

    Public Sub AddKeyItem_LA(ByVal cbo As ComboBox)
        cbo.Items.Clear()
        For i = 0 To strKey.Length - 1
            cbo.Items.Add(strKey(i))
        Next
        cbo.SelectedIndex = 0
    End Sub

    Public Sub MouseKey(ByVal LR As String, ByVal DU As String)
        If kmode = 1 Then
            Select Case LR
                Case "L"
                    Select Case DU
                        Case "Down"
                            dm.LeftDown
                        Case "Up"
                            dm.LeftUp
                    End Select
                Case "R"
                    Select Case DU
                        Case "Down"
                            dm.RightDown
                        Case "Up"
                            dm.RightUp
                    End Select
            End Select
        End If
        If kmode = 2 Then
            Select Case LR
                Case "L"
                    Select Case DU
                        Case "Down"
                            dm.KeyDownChar(mkeyL)
                        Case "Up"
                            dm.KeyUpChar(mkeyL)
                    End Select
                Case "R"
                    Select Case DU
                        Case "Down"
                            dm.KeyDownChar(mkeyR)
                        Case "Up"
                            dm.KeyUpChar(mkeyR)
                    End Select
            End Select
        End If
    End Sub




End Module

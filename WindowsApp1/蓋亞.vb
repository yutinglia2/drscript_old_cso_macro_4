Public Class 蓋亞

    Dim form1 = New Form1
    Public Sub start()
        Do
            If o蓋亞 Then
                Select Case c蓋亞
                    Case 0  '蓋亞
                        dm.KeyDownChar("q")
                        dm.KeyDownChar(3)
                        dm.KeyUpChar("q")
                        dm.KeyUpChar(3)
                        dm.KeyDownChar(3)
                        MouseKey("R", "Down")
                        Threading.Thread.Sleep(t蓋亞1)
                        MouseKey("R", "Up")
                        dm.KeyUpChar(3)
                        Threading.Thread.Sleep(t蓋亞2)
                    Case 1 '蓋亞刀戰
                        dm.KeyDownChar("j")
                        Threading.Thread.Sleep(t蓋亞1 / 2)
                        dm.KeyUpChar("j")
                        Threading.Thread.Sleep(t蓋亞1 / 2)
                        dm.KeyDownChar(3)
                        MouseKey("R", "Down")
                        Threading.Thread.Sleep(t蓋亞2)
                        MouseKey("R", "Up")
                        dm.KeyUpChar(3)
                    Case 2 '蓋亞購買區
                        dm.KeyPressChar("F2")
                        dm.KeyDownChar(3)
                        MouseKey("R", "Down")
                        Threading.Thread.Sleep(t蓋亞1)
                        MouseKey("R", "Up")
                        dm.KeyUpChar(3)
                        Threading.Thread.Sleep(t蓋亞2)
                End Select
            Else
                Threading.Thread.Sleep(100)
            End If
        Loop
    End Sub



End Class

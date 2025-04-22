Public Class HotKey

    Public Function OnOff(ByVal KeyCode As String, ByRef Vel As String)
        If GetKeyState(toKeyValue(KeyCode)) Then
            Vel = True
        Else
            Vel = False
        End If
        Return 1
    End Function

    Public Function Press(ByVal KeyCode As String, ByRef Vel As String)
        If GetAsyncKeyState(toKeyValue(KeyCode)) Then
            Vel = True
        Else
            Vel = False
        End If
        Return 1
    End Function

    Private Function toKeyValue(ByVal KeyCode As String) As Integer
        Dim intKey() As Integer = {0, &HD, &H10, &H11, &H12, &H20, &H21, &H22, &H2D, &H2E, &H24, &H23, &H25, &H26, &H27, &H28, &H30, &H31, &H32, &H33, &H34, &H35, &H36, &H37, &H38, &H39, &H41, &H42, &H43, &H44, &H45, &H46, &H47, &H48, &H49, &H4A, &H4B, &H4C, &H4D, &H4E, &H4F, &H50, &H51, &H52, &H53, &H54, &H55, &H56, &H57, &H58, &H59, &H5A, &H70, &H71, &H72, &H73, &H74, &H75, &H76, &H77, &H78, &H79, &H7A, &H7B, &H1B, &H4, &H5, &H6, &HDB, &HDD, &H1, &H2}
        For i = 0 To strKey.Length - 1
            If strKey(i) = KeyCode Then Return intKey(i)
        Next
        Return False
    End Function

End Class

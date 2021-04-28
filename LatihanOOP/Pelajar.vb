Public Class Pelajar
    Private strNoMatrik As String

    Sub New(ByVal strNoMatrik As String)
        Me.strNoMatrik = strNoMatrik
    End Sub

    Public Function Politeknik() As String
        Dim strKodPoli As String = strNoMatrik.Substring(0, 2)
        If strKodPoli = "18" Then
            Return "Politeknik Tuanku Syed Sirajuddin"
        Else
            Return "Bukan PTSS"
        End If
    End Function


End Class

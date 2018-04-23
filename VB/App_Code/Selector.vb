Imports System
Imports System.Collections.Generic
Imports System.Web.UI

Public Class Selector
    Public Shared Function GetEditorsInContainer(Of T As Control)(ByVal container As Control) As List(Of T)
        If container Is Nothing Then
            Throw New ArgumentNullException("Container is not specified.")
        End If

        Dim res As New List(Of T)()

        GetControls(Of T)(container, res)

        Return res
    End Function

    Private Shared Sub GetControls(Of T As Control)(ByVal container As Control, ByVal lst As List(Of T))
        For Each ctrl As Control In container.Controls
            If ctrl.HasControls() Then
                GetControls(Of T)(ctrl, lst)
            End If

            If TypeOf ctrl Is T Then
                lst.Add(CType(ctrl, T))
            End If
        Next ctrl
    End Sub
End Class
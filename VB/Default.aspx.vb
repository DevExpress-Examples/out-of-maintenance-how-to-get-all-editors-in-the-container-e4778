Imports System
Imports System.Collections.Generic
Imports System.Web.UI
Imports DevExpress.Web.ASPxEditors
Imports System.Text

Partial Public Class _Default
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)

    End Sub

    Protected Sub ASPxButton1_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim sb As New StringBuilder()

        sb.Append("<b>Total controls count</b><br>")
        sb.Append(CountControls(pnlTest1))
        sb.Append("<br><br><b>Controls in Panel 2</b><br>")
        sb.Append(CountControls(pnlTest2))

        PopupLabel.Text = sb.ToString()

        PopupControl.ShowOnPageLoad = True
    End Sub

    Private Function CountControls(ByVal container As Control) As String
        Dim sb As New StringBuilder()

        Dim txt As List(Of ASPxTextBox) = Selector.GetEditorsInContainer(Of ASPxTextBox)(container)
        Dim spin As List(Of ASPxSpinEdit) = Selector.GetEditorsInContainer(Of ASPxSpinEdit)(container)
        Dim cmb As List(Of ASPxComboBox) = Selector.GetEditorsInContainer(Of ASPxComboBox)(container)

        sb.Append("ASPxTextBox count: ")
        sb.Append(txt.Count.ToString())
        sb.Append("<br>ASPxSpinEdit count: ")
        sb.Append(spin.Count.ToString())
        sb.Append("<br>ASPxComboBox count: ")
        sb.Append(cmb.Count.ToString())

        Return sb.ToString()
    End Function
End Class
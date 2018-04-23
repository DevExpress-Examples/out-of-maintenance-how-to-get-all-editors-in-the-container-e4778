using System;
using System.Collections.Generic;
using System.Web.UI;
using DevExpress.Web.ASPxEditors;
using System.Text;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void ASPxButton1_Click(object sender, EventArgs e) {
        StringBuilder sb = new StringBuilder();

        sb.Append("<b>Total controls count</b><br>");
        sb.Append(CountControls(pnlTest1));
        sb.Append("<br><br><b>Controls in Panel 2</b><br>");
        sb.Append(CountControls(pnlTest2));

        PopupLabel.Text = sb.ToString();

        PopupControl.ShowOnPageLoad = true;
    }

    private String CountControls(Control container) {
        StringBuilder sb = new StringBuilder();

        List<ASPxTextBox> txt = Selector.GetEditorsInContainer<ASPxTextBox>(container);
        List<ASPxSpinEdit> spin = Selector.GetEditorsInContainer<ASPxSpinEdit>(container);
        List<ASPxComboBox> cmb = Selector.GetEditorsInContainer<ASPxComboBox>(container);

        sb.Append("ASPxTextBox count: ");
        sb.Append(txt.Count.ToString());
        sb.Append("<br>ASPxSpinEdit count: ");
        sb.Append(spin.Count.ToString());
        sb.Append("<br>ASPxComboBox count: ");
        sb.Append(cmb.Count.ToString());

        return sb.ToString();
    }
}
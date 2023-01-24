<%@ Page Language="vb" AutoEventWireup="true" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<%@ Register Assembly="DevExpress.Web.v13.1, Version=13.1.14.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web" TagPrefix="dx" %>



<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>How to get all editors in the container</title>
</head>
<body>
    <form id="form1" runat="server">
    <dx:ASPxRoundPanel ID="pnlTest1" runat="server" Width="200px" HeaderText="Panel 1">
        <PanelCollection>
            <dx:PanelContent runat="server" SupportsDisabledAttribute="True">
                <dx:ASPxTextBox ID="ASPxTextBox1" runat="server" Width="170px">
                </dx:ASPxTextBox>
                <dx:ASPxTextBox ID="ASPxTextBox2" runat="server" Width="170px">
                </dx:ASPxTextBox>
                <dx:ASPxSpinEdit ID="ASPxSpinEdit1" runat="server" Height="21px" Number="0" />
                <dx:ASPxSpinEdit ID="ASPxSpinEdit2" runat="server" Height="21px" Number="0" />
                <dx:ASPxComboBox ID="ASPxComboBox1" runat="server" ValueType="System.String">
                </dx:ASPxComboBox>
                <dx:ASPxRoundPanel ID="pnlTest2" runat="server" Width="200px" HeaderText="Panel 2">
                    <PanelCollection>
                        <dx:PanelContent ID="PanelContent1" runat="server" SupportsDisabledAttribute="True">
                            <dx:ASPxTextBox ID="ASPxTextBox3" runat="server" Width="170px">
                            </dx:ASPxTextBox>
                            <dx:ASPxSpinEdit ID="ASPxSpinEdit3" runat="server" Height="21px" Number="0" />
                            <dx:ASPxComboBox ID="ASPxComboBox2" runat="server" ValueType="System.String">
                            </dx:ASPxComboBox>
                        </dx:PanelContent>
                    </PanelCollection>
                </dx:ASPxRoundPanel>
            </dx:PanelContent>
        </PanelCollection>
    </dx:ASPxRoundPanel>
    <dx:ASPxButton ID="ASPxButton1" runat="server" Text="Count controls" Width="224px"
        OnClick="ASPxButton1_Click" Height="24px">
    </dx:ASPxButton>
    <dx:ASPxPopupControl ID="PopupControl" runat="server" ClientInstanceName="popup"
        Modal="true" HeaderText="Controls count" PopupHorizontalAlign="WindowCenter"
        PopupVerticalAlign="WindowCenter" Width="270px">
        <ContentCollection>
            <dx:PopupControlContentControl runat="server" SupportsDisabledAttribute="True">
                <dx:ASPxLabel ID="PopupLabel" runat="server" ClientInstanceName="popupLabel" Text="ASPxLabel"
                    EncodeHtml="False">
                </dx:ASPxLabel>
            </dx:PopupControlContentControl>
        </ContentCollection>
    </dx:ASPxPopupControl>
    </form>
</body>
</html>
<%@ Page Title="" Language="C#" MasterPageFile="~/Plantilla.Master" AutoEventWireup="true" CodeBehind="editor.aspx.cs" Inherits="TallerAjax.editor" %>

<%@ Register Assembly="TallerAjax" Namespace="TallerAjax.modeloeditor" TagPrefix="cc2" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit.HTMLEditor" TagPrefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     
    <div class="col-md-2"></div>
    <div class="col-md-8">

        <cc2:editorsimple ID="Editorsimple1" runat="server" />
        <br />
        <br />
        <asp:Button ID="btnmostrar" runat="server" Text="Mostrar Mensaje" OnClick="btnmostrar_Click" class="btn btn-success btn-lg btn-block" Width="100%" />
        <br />
        <br /> 
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <asp:Label ID="lbmostrar" runat="server" Text=""></asp:Label>
            </ContentTemplate>
            <Triggers>
                <asp:AsyncPostBackTrigger ControlID="btnmostrar" EventName="Click"/>
            </Triggers>
        </asp:UpdatePanel>

    </div>
    <div class="col-md-2"></div>
</asp:Content>

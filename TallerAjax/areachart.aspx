<%@ Page Title="" Language="C#" MasterPageFile="~/Plantilla.Master" AutoEventWireup="true" CodeBehind="areachart.aspx.cs" Inherits="TallerAjax.areachart" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="col-md-2">
        <br />        
        <asp:Button ID="btnformulario" runat="server" Text="Formulario" class="btn btn-primary" Width="120px" OnClick="btnformulario_Click" />
        <br />
        <br />
        <asp:Button ID="btnreporte" runat="server" Text="Reporte" class="btn btn-primary" Width="120px" OnClick="btnreporte_Click"/>
    </div>
    <div class="col-md-10">
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <asp:MultiView ID="MultiView1" runat="server">
                    
                    <asp:View ID="view0_inicio" runat="server">
                        <h3>AreaChart</h3>
                    </asp:View>

                    <asp:View ID="view1_formulario" runat="server">                                             
                        <br />
                        <asp:Label ID="Label1" runat="server" Text="Nombre:"></asp:Label>
                        <br />
                        <asp:TextBox ID="txtnombre" runat="server" placeholder="Nombre" class="form-control" Width="30%"></asp:TextBox>
                        <br />                       
                        <asp:Label ID="Label2" runat="server" Text="Categoria:"></asp:Label>
                        <br />
                        <asp:TextBox ID="txtcategoria" runat="server" placeholder="Categoria" class="form-control" Width="30%"></asp:TextBox>
                        <br />                        
                        <asp:Label ID="Label3" runat="server" Text="Cantidad:"></asp:Label>
                        <br />
                        <asp:TextBox ID="txtcantidad" runat="server" placeholder="Cantidad" class="form-control" Width="30%"></asp:TextBox>
                        <br />                        
                        <asp:Button ID="btnagregar" runat="server" Text="Agregar" class="btn btn-primary btn-lg btn-block" Width="30%" OnClick="btnagregar_Click" />
                        <br />                        
                        <asp:GridView ID="GridView1" runat="server" class="table table-bordered" BackColor="#2E9AFE"></asp:GridView>

                    </asp:View>

                    <asp:View ID="view2_reporte" runat="server">
                        <asp:AreaChart ID="AreaChart1" runat="server" ChartWidth="850" ChartHeight="500" ChartTitle="Reporte" ChartTitleColor="#0E426C" CategoryAxisLineColor="#0101DF"  
                         ValueAxisLineColor="#0101DF" BaseLineColor="#0101DF" ChartType="Stacked">
                           
                        </asp:AreaChart>
                    </asp:View>

                </asp:MultiView>
            </ContentTemplate>
            <Triggers>
                <asp:AsyncPostBackTrigger ControlID="btnformulario" EventName="Click" />
                <asp:AsyncPostBackTrigger ControlID="btnreporte" EventName="Click"/>
            </Triggers>
        </asp:UpdatePanel>
    </div>
</asp:Content>

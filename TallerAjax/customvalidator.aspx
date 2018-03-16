<%@ Page Title="" Language="C#" MasterPageFile="~/Plantilla.Master" AutoEventWireup="true" CodeBehind="customvalidator.aspx.cs" Inherits="TallerAjax.customvalidator" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="col-md-2">
        <h2>Validar Contraseñas en registro</h2>
    </div>
    <div class="col-md-6">
     <asp:Label ID="Label1" runat="server" Text="Rut:"></asp:Label>
        <br />
     <asp:TextBox ID="txtrut" runat="server" class="form-control" Width="50%"></asp:TextBox>
     <br />
     <br />
     <asp:Label ID="Label2" runat="server" Text="Nombre:"></asp:Label>
     <br />
     <asp:TextBox ID="txtnombre" runat="server" class="form-control" Width="50%"></asp:TextBox>
     <br />
     <asp:Label ID="Label3" runat="server" Text="Contraseña:"></asp:Label>
     <br />
     <asp:TextBox ID="txtcontraseña" runat="server" class="form-control" Width="50%" TextMode="Password"></asp:TextBox>
     <br />
     <asp:Label ID="Label4" runat="server" Text="Confirmar Contraseña"></asp:Label>
     <br />
     <asp:TextBox ID="txtconfirmarcontraseña" runat="server" class="form-control" Width="50%" TextMode="Password"></asp:TextBox>
     <br />
     <asp:Label ID="Label5" runat="server" Text="Ocupacion:"></asp:Label>
     <br />
     <asp:TextBox ID="txtocupacion" runat="server" class="form-control" Width="50%"></asp:TextBox>
     <br />
     <asp:CustomValidator ID="CustomValidator2" runat="server" ErrorMessage="Las contraseñas no coinciden"
          OnServerValidate="CustomValidator2_ServerValidate"></asp:CustomValidator>
     <br />
     <asp:Button ID="btnagregar" runat="server" Text="Registrar" OnClick="btnagregar_Click" class="btn btn-primary btn-lg btn-block" Width="50%" />
     <br />
     <asp:Label ID="lbregistro" runat="server" Text=""></asp:Label>
     <br />
     
    </div>
    <div class="col-md-4">
     <asp:GridView ID="GridView1" runat="server" class="table table-bordered" BackColor="#A9D0F5" ></asp:GridView>
    </div>
   

</asp:Content>

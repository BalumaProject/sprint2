﻿<%@ Page Title="" Language="C#" MasterPageFile="~/admin/Administrador.Master" AutoEventWireup="true" CodeBehind="Seguimiento.aspx.cs" Inherits="BalumaProject_Plantilla_Frontend.admin.Seguimiento" %>
<asp:Content ID="Content1" ContentPlaceHolderID="headAdmin" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form runat="server">
        <div class="container">
    <p>
    Seguimiento para los pedidos del cliente <span class="label label-info"><%= _cliente.Nombre %></span>
    </p>
        <table class="table table-bordered">
            <tr>
                <th>Id</th>
                <th>Fecha</th>
                <th>Estado</th>
                <th>Tipo de Pago</th>
            </tr>
            <% var pedidos = ObtenerPedidos(); %>
            <% foreach (var p in pedidos) %>
            <% { %>
            <tr>
                <td><%= p.IdPedido %></td>
                <td><%= p.Fecha.ToString() %></td>
                <td><%= p.Estado.ToString() %></td>
                <td><%= p.TipoPago.ToString() %></td>
            </tr>                
            <% } %>
        </table>
        <asp:Button ID="Button1" Text="Volver a clientes" OnClick="VolverClientes" CssClass="btn btn-default" runat="server" />
    </div>
    </form>
    
</asp:Content>

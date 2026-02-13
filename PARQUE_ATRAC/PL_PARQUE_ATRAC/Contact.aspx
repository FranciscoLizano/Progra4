<%@ Page Title="Contacto" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="PL_PARQUE_ATRAC.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <main aria-labelledby="title">
        <h2 id="title"><%: Title %>.</h2>
        <h3>Página de contactos</h3>
        <address>
<%--            One Microsoft Way<br />
            Redmond, WA 98052-6399<br />--%>
            <abbr title="Telefono">Teléfono:</abbr>
            506.8836-0036
        </address>

        <address>
            <strong>Soporte:</strong>   <a href="mailto:Soporte@patrac.com">Soporte@patrac.com</a><br />
            <strong>Consultas:</strong> <a href="mailto:Consulta@patrac.com">Consulta@patrac.com</a>
        </address>
    </main>
</asp:Content>

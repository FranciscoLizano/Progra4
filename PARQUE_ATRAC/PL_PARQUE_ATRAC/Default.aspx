<%@ Page Title="Página de inicio" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="PL_PARQUE_ATRAC._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>
        <section class="row" aria-labelledby="aspnetTitle">
            <h1 id="aspnetTitle">PARQUE DE ATRACCIONES</h1>
            <p class="lead">En esta pagina usted va a encontrar las mejores atracciones</p>
            <p><a href="/frmParqueAtrac" class="btn btn-primary btn-md">Ver atracciones &raquo;</a></p>
        </section>

        <div class="row">
            <section class="col-md-4" aria-labelledby="gettingStartedTitle">
                <h2 id="gettingStartedTitle">Diversión</h2>
                <p>
                    En este parque de atracciones va a encontrar las mejores atracciones para toda la familia. 
                    Se tienen atracciones para la diversión de niños, adolescentes y adultos.
                <p>
                    <%--<a class="btn btn-default" href="https://go.microsoft.com/fwlink/?LinkId=301948">Learn more &raquo;</a>--%>
                </p>
            </section>
            <section class="col-md-4" aria-labelledby="librariesTitle">
                <h2 id="librariesTitle">Boletos</h2>
                <p>
                    Los boletos para el parque de atracciones los puede comprar en línea o en la boletería del parque. 
                    Se pueden comprar boletos solo para el ingreso al parque o pases especiales para disfrutar de todas las atracciones.
                </p>
                <p>
                    <%--<a class="btn btn-default" href="https://go.microsoft.com/fwlink/?LinkId=301949">Learn more &raquo;</a>--%>
                </p>
            </section>
            <section class="col-md-4" aria-labelledby="hostingTitle">
                <h2 id="hostingTitle">Horario del parque</h2>
                <p>
                    La boletería del parque abre de martes a domingo de 8 de la mañana a 4 de la tarde. 
                    Las atracciones inician la actividad a partir de las 9 de la mañana. 
                    Y cierran al publico a las 5 de la tarde.
                </p>
                <p>
                    <%--<a class="btn btn-default" href="https://go.microsoft.com/fwlink/?LinkId=301950">Learn more &raquo;</a>--%>
                </p>
            </section>
        </div>
    </main>

</asp:Content>

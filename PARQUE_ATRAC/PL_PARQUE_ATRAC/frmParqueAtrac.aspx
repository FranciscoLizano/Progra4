<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="frmParqueAtrac.aspx.cs" Inherits="PL_PARQUE_ATRAC.frmParqueAtrac" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <main>
        <section class="row" aria-labelledby="aspnetTitle">
            <h1 id="aspnetTitle">Parque de Atracciones</h1>
            <p class="lead">En este parque usted encuentra las mejores atracciones para su familia.</p>
        </section>

        <div class="row">
            <section class="col-md-4" aria-labelledby="gettingStartedTitle">
                <img src="Imagenes/Carrusel.png" class="imgParqueAtrac"/>
                <h2 id="gettingStartedTitle">Caballitos mágicos</h2>
                <p>
                    Caballitos mágicos, Carresul, En operación
                </p>
                <p>
                    <asp:Button Text="Seleccionar Atracción" id="btnCaballitos" runat="server" CssClass="btn btn-primary btn-md" OnClick="btnCaballitos_Click"/>
                </p>
            </section>
            <section class="col-md-4" aria-labelledby="gettingStartedTitle">
                <img src="Imagenes/Chocones.png" class="imgParqueAtrac"/>
                <h2 id="gettingStartedTitle">Los Chocadores</h2>
                <p>
                    Los Chocadores, Carros chocones, En operación
                </p>
                <p>
                    <asp:Button Text="Seleccionar Atracción" id="btnChocadores" runat="server" CssClass="btn btn-primary btn-md" OnClick="btnChocadores_Click"/>
                </p>
            </section>
            <section class="col-md-4" aria-labelledby="gettingStartedTitle">
                <img src="Imagenes/La torre.png" class="imgParqueAtrac"/>
                <h2 id="gettingStartedTitle">Al abismo</h2>
                <p>
                    Al abismo, Torre, En operación
                </p>
                <p>
                    <asp:Button Text="Seleccionar Atracción" id="btnAbismo" runat="server" CssClass="btn btn-primary btn-md" OnClick="btnAbismo_Click"/>
                </p>
            </section>
        </div>

        <div class="row">
            <section class="col-md-4" aria-labelledby="gettingStartedTitle">
                <img src="Imagenes/Montaña rusa.png" class="imgParqueAtrac"/>
                <h2 id="gettingStartedTitle">Serpiente</h2>
                <p>
                    Serpiente, Montaña rusa, Fuera de Servicio
                </p>
                <p>
                    <asp:Button Text="Seleccionar Atracción" id="btnSerpiente" runat="server" CssClass="btn btn-primary btn-md" OnClick="btnSerpiente_Click"/>
                </p>
            </section>
            <section class="col-md-4" aria-labelledby="gettingStartedTitle">
                <img src="Imagenes/Rueda de chicago.png" class="imgParqueAtrac"/>
                <h2 id="gettingStartedTitle">Los giros</h2>
                <p>
                    Los giros, Rueda de chicago, En operación
                </p>
                <p>
                    <asp:Button Text="Seleccionar Atracción" id="btnGiros" runat="server" CssClass="btn btn-primary btn-md" OnClick="btnGiros_Click"/>
                </p>
            </section>
            <section class="col-md-4" aria-labelledby="gettingStartedTitle">
                <img src="Imagenes/Sky Master.png" class="imgParqueAtrac"/>
                <h2 id="gettingStartedTitle">Sky Master</h2>
                <p>
                    Sky Master, Rueda de chicago, En operación
                </p>
                <p>
                    <asp:Button Text="Seleccionar Atracción" id="btnSkyMaster" runat="server" CssClass="btn btn-primary btn-md" OnClick="btnSkyMaster_Click"/>
                </p>
            </section>
        </div>

        <div class="row">
            <section class="col-md-4" aria-labelledby="gettingStartedTitle">
                <img src="Imagenes/Star Flyer.png" class="imgParqueAtrac"/>
                <h2 id="gettingStartedTitle">Caballitos mágicos</h2>
                <p>
                    Caballitos mágicos, Carresul, En operación
                </p>
                <p>
                    <asp:Button Text="Seleccionar Atracción" id="Button1" runat="server" CssClass="btn btn-primary btn-md" OnClick="btnCaballitos_Click"/>
                </p>
            </section>
            <section class="col-md-4" aria-labelledby="gettingStartedTitle">
                <img src="Imagenes/Tarántula.png" class="imgParqueAtrac"/>
                <h2 id="gettingStartedTitle">Los Chocadores</h2>
                <p>
                    Los Chocadores, Carros chocones, En operación
                </p>
                <p>
                    <asp:Button Text="Seleccionar Atracción" id="Button2" runat="server" CssClass="btn btn-primary btn-md" OnClick="btnChocadores_Click"/>
                </p>
            </section>
            <section class="col-md-4" aria-labelledby="gettingStartedTitle">
                <img src="Imagenes/Tornado.png" class="imgParqueAtrac"/>
                <h2 id="gettingStartedTitle">Al abismo</h2>
                <p>
                    Al abismo, Torre, En operación
                </p>
                <p>
                    <asp:Button Text="Seleccionar Atracción" id="Button3" runat="server" CssClass="btn btn-primary btn-md" OnClick="btnAbismo_Click"/>
                </p>
            </section>
        </div>

        <div class="row">
            <h3>Información de la Atracción Seleccionada</h3>
            <div id="divTablaInfoAtraccion" runat="server">


            </div>
        </div>
        <link href="css/EstilosParqueAtrac.css" rel="stylesheet" />
    </main>

</asp:Content>

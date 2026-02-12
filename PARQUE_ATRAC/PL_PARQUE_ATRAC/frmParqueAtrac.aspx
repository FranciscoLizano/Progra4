<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="frmParqueAtrac.aspx.cs" Inherits="PL_PARQUE_ATRAC.frmParqueAtrac" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <main>
        <section class="row" aria-labelledby="aspnetTitle">
            <h1 id="aspnetTitle">Parque de Atracciones</h1>
            <p class="lead">En este parque usted encuentra las mejores atracciones para su familia.</p>
        </section>

        <div class="row">
            <section class="col-md-4" aria-labelledby="gettingStartedTitle">
                <img src="Imagenes/Caballitos.png" class="imgParqueAtrac"/>
                <h2 id="gettingStartedTitle">Caballitos</h2>
                <p>
                    Caballitos, Carresul, En operación
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
                <h2 id="gettingStartedTitle">Star Flyer</h2>
                <p>
                    Star Flyer, Torre, En operación
                </p>
                <p>
                    <asp:Button Text="Seleccionar Atracción" id="btnStarFlyer" runat="server" CssClass="btn btn-primary btn-md" OnClick="btnStarFlyer_Click"/>
                </p>
            </section>
            <section class="col-md-4" aria-labelledby="gettingStartedTitle">
                <img src="Imagenes/Tarántula.png" class="imgParqueAtrac"/>
                <h2 id="gettingStartedTitle">Tarántula</h2>
                <p>
                    Tarántula, Montaña rusa, En operación
                </p>
                <p>
                    <asp:Button Text="Seleccionar Atracción" id="btnTarantula" runat="server" CssClass="btn btn-primary btn-md" OnClick="btnTarantula_Click"/>
                </p>
            </section>
            <section class="col-md-4" aria-labelledby="gettingStartedTitle">
                <img src="Imagenes/Tornado.png" class="imgParqueAtrac"/>
                <h2 id="gettingStartedTitle">Tornado</h2>
                <p>
                    Tornado, Montaña rusa, En operación
                </p>
                <p>
                    <asp:Button Text="Seleccionar Atracción" id="btnTornado" runat="server" CssClass="btn btn-primary btn-md" OnClick="btnTornado_Click"/>
                </p>
            </section>
        </div>

        <div class="row">
            <h3>Información de la Atracción Seleccionada</h3>
            <div id="divTablaInfoAtraccion" runat="server">


            </div>
        </div>
        
        <section class="row" aria-labelledby="aspnetTitle" style="margin-top:40px;">
            <h1 id="aspnetTitle">Acciones de las atracciones</h1>
        </section>
        <div class="row">
        
            <section class="col-md-2" aria-labelledby="gettingStartedTitle">
                <p>
                    <asp:Button Text="Iniciar atracción" ID="btnIniciar" runat="server" CssClass="btn btn-primary btn-md" OnClick="btnIniciar_Click" />
                </p>
            </section>
        
            <section class="col-md-2" aria-labelledby="gettingStartedTitle">
                <p>
                    <asp:Button Text="Detener atracción" ID="btnDetener" runat="server" CssClass="btn btn-primary btn-md" OnClick="btnDetener_Click" />
                </p>
            </section>
        
            <section class="col-md-2" aria-labelledby="gettingStartedTitle">
                <p>
                    <asp:Button Text="Realizar mantenimiento" ID="btnMantenimiento" runat="server" CssClass="btn btn-primary btn-md" OnClick="btnMantenimiento_Click" />
                </p>
            </section>
        
            <section class="col-md-2" aria-labelledby="gettingStartedTitle">
                <p>
                    <asp:Button Text="Abrir atracción" ID="btnAbrir" runat="server" CssClass="btn btn-primary btn-md" OnClick="btnAbrir_Click" />
                </p>
            </section>
        
            <section class="col-md-2" aria-labelledby="gettingStartedTitle">
                <p>
                    <asp:Button Text="Cerrar atracción" ID="btnCerrar" runat="server" CssClass="btn btn-primary btn-md" OnClick="btnCerrar_Click" />
                </p>
            </section>
        
            <section class="col-md-2" aria-labelledby="gettingStartedTitle">
                <p>
                    <asp:Button Text="Consultar disponibilidad" ID="btnDisponibilidad" runat="server" CssClass="btn btn-primary btn-md" OnClick="btnDisponibilidad_Click" />
                </p>
            </section>
        
        </div>

        <div class="row">
            <h3>Información del Estado de la Atracción</h3>
            <div id="divTablaEstadoAtraccion" runat="server">


            </div>
        </div>
    </main>
        <link href="css/EstilosParqueAtrac.css" rel="stylesheet" />

</asp:Content>

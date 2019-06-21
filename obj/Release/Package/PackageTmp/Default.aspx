<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebAruTest1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>PRUEBA DE .NET en AZURE</h1>
        <p class="lead">Esta es una página de prueba de -NET para instalarlo en AZure.</p>
        <p><a href="#" class="btn btn-primary btn-lg">Aprenda mas y mas.. &raquo;</a></p>
    </div>

    <div class="row">
        <div class="col-md-4">
            <h2>Comenzando ....</h2>
            <p>
                Aqui va un texto adicional mas largo........ la idea es probar esta herramienta .....            </p>
            <p>
                <a class="btn btn-default" href="#">Aprenda más &raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2>>Obtenga más libraries</h2>
            <p>
                NuGet es gratis como herramienta de VS Code (Traducido por ARU) Visual Studio projects.
            </p>
            <p>
                <a class="btn btn-default" href="V">Aprenda más &raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2>Datos de BD</h2>
            <p>
                Datos obtenidos de BD Azure<br /><input runat="server" type="text" id="Text1" value=""><br />
                <input runat="server" type="text" id="Text2" value=""><br /><input runat="server" type="text" id="Text3" value="">
            </p>
            <p>
                <a class="btn btn-default" href="#">Learn more &raquo;</a>
            </p>
        </div>
    </div>

</asp:Content>

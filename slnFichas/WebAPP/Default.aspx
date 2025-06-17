<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebAPP._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>ASP.NET</h1>
        <p class="lead">ASP.NET is a free web framework for building great Web sites and Web applications using HTML, CSS, and JavaScript.</p>
        <p><a href="http://www.asp.net" class="btn btn-primary btn-lg">Learn more &raquo;</a></p>
    </div>

    <div class="row">
        <div class="col-md-4">
            <h2>HEMPOS EMPEZADO</h2>
            <p>
                ASP.NET Web Forms lets you build dynamic websites using a familiar drag-and-drop, event-driven model.
            A design surface and hundreds of controls and components let you rapidly build sophisticated, powerful UI-driven sites with data access.
            </p>
            <p>
                <a class="btn btn-default" href="https://go.microsoft.com/fwlink/?LinkId=301948">Learn more &raquo;</a>
            </p>
            <p>
                
                <asp:Button ID="btnCreateEntidad" runat="server" 
                    Text="Crear Entidad" OnClick="btnCreateEntidad_Click" />
            
            </p>
        </div>
        <p>
            <asp:Button ID="btnRead" runat="server" 
                    Text="LEER" OnClick="btnRead_Click" />

        </p>
        <p>
            <asp:Button ID="btnActualizar" runat="server" 
                    Text="Actualizar" OnClick="btnActualizar_Click" />

        </p>
        <p>
            <asp:Button ID="btnDelete" runat="server" 
                    Text="Eliminar" OnClick="btnDelete_Click" />

        </p>
        <p>
            <asp:Label ID="lblResultado" runat="server" Visible="true" Text="Etiqueta resultado"></asp:Label>

        </p>
        <div class="col-md-4">
            <h2>Get more libraries</h2>
            <p>
                NuGet is a free Visual Studio extension that makes it easy to add, remove, and update libraries and tools in Visual Studio projects.
            </p>
            <p>
                <a class="btn btn-default" href="https://go.microsoft.com/fwlink/?LinkId=301949">Learn more &raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2>Web Hosting</h2>
            <p>
                You can easily find a web hosting company that offers the right mix of features and price for your applications.
            </p>
            <p>
                <a class="btn btn-default" href="https://go.microsoft.com/fwlink/?LinkId=301950">Learn more &raquo;</a>
            </p>
        </div>
    </div>

</asp:Content>

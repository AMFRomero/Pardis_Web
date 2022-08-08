<%@ Page Language="C#" AutoEventWireup="true"  MasterPageFile="~/Site.Master"  CodeBehind="WebForm1.aspx.cs" Inherits="Pardis_Web.fonts.WebForm1" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">


<div class="login-form">
  <form>
    <h1><strong>Registrarte</strong></h1>
    <p><i>Es rápido y fácil.</i></p>
    <div class="content">
      <div class="input-field">
         <input type="text" placeholder="Nombre">
             <input type="text" placeholder="Primer Apellido ">
             <input type="text" placeholder="Segundo Apellido " >
             <input type="text" placeholder="Email">
             <input type="email" placeholder="Password" autocomplete="nope">
            <input type="password" placeholder="Repetir Password" autocomplete="new-password" >
            <input type="text" placeholder="DNI" >
    </div>
    <p> <input class="in1" id="checkboxid" type="checkbox"> Al registrarse, acepta nuestros <a href="WebForm3.aspx">Términos de uso y Política de privacidad</a></p>
    <div class="action">
      <button onclick="change()">Registrate</button>
    </div>
  </form>
    <script>
    function change(){
        if (document.getElementById("checkboxid").checked === true) {

             

        } else {
     alert("Error" ,1);
      }
    }
    </script>
</div>




</asp:Content>
<%@ Page Language="C#" AutoEventWireup="true"  MasterPageFile="~/Site.Master"  CodeBehind="WebForm1.aspx.cs" Inherits="Pardis_Web.fonts.WebForm1" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">


<div class="login-form">
  <form>
    <h1>Pardis</h1>
    <div class="content">
      <div class="camposLogin">
        <input type="email" placeholder="Email" autocomplete="nope">
        <input type="password" placeholder="Password" autocomplete="new-password">
      </div>
      <a href="#" class="link">Forgot Your Password?</a>
    </div>
    <div class="action">
      <button>Sign in</button>
    </div>
  </form>
</div>
<!-- partial -->
  <script  src="./script.js"></script>


</span></asp:Content>
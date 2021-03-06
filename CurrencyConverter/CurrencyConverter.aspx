﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CurrencyConverter.aspx.cs" Inherits="CurrencyConverter.CurrencyConverter" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">

 <head>
    <title>Currency Converter</title>
 </head>
  <body>
    <form runat="server">
      <div>
        Convert: &nbsp;
        <input type="text" id="US" runat="server" />
        &nbsp; U.S. dollars to &nbsp;
        <select id="Currency" runat="server" />
        <br /><br />
        <input type="submit" value="OK" id="Convert" OnServerClick="Convert_ServerClick" runat="server" />
        <input type="submit" value="Show Graph" id="ShowGraph" OnServerClick="ShowGraph_ServerClick" runat="server" />
        <br /><br />
        <img id="Graph" src="pic0.png" alt="Currency Graph" runat="server" />
        <br /><br />
        <p style="font-weight: bold" id="Result" runat="server"></p>
      </div>
    </form>
 </body>
</html>


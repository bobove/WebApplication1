<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StartPage.aspx.cs" Inherits="WebApplication1.StartPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Erik WebApplication1</title>
    <script>
        function myFunction() {
            document.getElementById("demo").innerHTML = "Hello World";
        }
</script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h1 style="text-align :center">Erik testar AppHarbor</h1>
    </div>
        <div>
        <a href="#"  onclick="myFunction();" style="text-align :center">Click me!</a> 
            </div>
<p id="demo"></p>
        <asp:GridView ID="GridView1" runat="server" Width="586px">
        </asp:GridView>
    </form>
</body>
</html>

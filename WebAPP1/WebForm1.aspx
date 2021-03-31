<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebAPP1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Shujja 2093</title>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css" integrity="sha384-Gn5384xqQ1aoWXA+058RXPxPg6fy4IWvTNh0E263XmFcJlSAwiGgFAW/dAiS6JXm" crossorigin="anonymous">

</head>
<body>
    <form id="form1" runat="server">
        <div class="row">
              <div class="col-4">
                  <h3>ID</h3>
              </div>
            <div class="col-8">
                <asp:TextBox ID="id" runat="server"></asp:TextBox>
            </div>
            <div class="col-4">
                  <h3>Name</h3>
              </div>
            <div class="col-8">
                <asp:TextBox ID="name" runat="server"></asp:TextBox>
            </div>
            <div class="col-4">
                  <h3>Email</h3>
              </div>
            <div class="col-8">
                <asp:TextBox ID="email" runat="server"></asp:TextBox>
            </div>
            <div class="col-4 offset-2">
                  <!-- <button class="btn btn-success">Save</button> !-->
                <asp:Button ID="saveBtn" runat="server" Text="Save" CssClass="btn btn-success" OnClick="saveBtn_Click" />
                <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
            </div>
        </div>
    </form>
</body>
</html> 

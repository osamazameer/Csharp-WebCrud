<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="WebAPP1.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Shujja | Products </title>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css" integrity="sha384-Gn5384xqQ1aoWXA+058RXPxPg6fy4IWvTNh0E263XmFcJlSAwiGgFAW/dAiS6JXm" crossorigin="anonymous">
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
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
                  <h3>Description</h3>
              </div>
            <div class="col-8">
                <asp:TextBox ID="description" runat="server"></asp:TextBox>
            </div>
             <div class="col-4">
                  <h3>Price</h3>
              </div>
            <div class="col-8">
                <asp:TextBox ID="price" runat="server"></asp:TextBox>
            </div>
             <div class="col-4">
                  <h3>Cost</h3>
              </div>
            <div class="col-8">
                <asp:TextBox ID="cost" runat="server"></asp:TextBox>
            </div>
             <div class="col-4">
                  <h3>Sales Price</h3>
              </div>
            <div class="col-8">
                <asp:TextBox ID="sales_price" runat="server"></asp:TextBox>
            </div>

             <div class="col-4">
                  <h3>Tax</h3>
              </div>
            <div class="col-8">
                <asp:TextBox ID="tax" runat="server"></asp:TextBox>
            </div>
            <div class="col-12 offset-2 my-5">
                  <!-- <button class="btn btn-success">Save</button> !-->
                <asp:Button ID="saveBtn" runat="server" Text="Save" CssClass="btn btn-success" OnClick="saveBtn_Click" />
                <asp:Button ID="searchBtn" runat="server" Text="Search" CssClass="btn btn-warning" OnClick="searchBtn_Click" />
                <asp:Button ID="deleteBtn" runat="server" Text="Delete" CssClass="btn btn-danger" OnClick="deleteBtn_Click" />
                <asp:Button ID="clearBtn" runat="server" Text="Clear"  CssClass="btn btn-primary" OnClick="clearBtn_Click" />
                <asp:Button ID="updateBtn" runat="server" Text="Update" CssClass="btn btn-dark" OnClick="updateBtn_Click" />
                <asp:Button ID="refreshBtn" runat="server" Text="Refresh" CssClass="btn btn-warning" OnClick="refreshBtn_Click" />
                </div>
                <asp:Label ID="Label1" runat="server" CssClass="m-auto" Text=""></asp:Label>
        </div>
            <asp:GridView ID="GridView1" runat="server"></asp:GridView>
     </div>
    </form>
</body>
</html>

<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Site1.Master" AutoEventWireup="true" CodeBehind="customer.aspx.cs" Inherits="WebApplication8.Views.customer" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MyContent" runat="server">
       <div class="container-fluid">
       <div class="row">
           
           <div class="col"> 
               <h3 class="text-center">Manage Customer</h3>
           </div>
       </div>
       <div class="row">
           <div class="col-md-4">
               <div class="mb-3">
                   <label for="" class="form-label text-success">Customer Name</label>
                    <input type="text" placeholder="customer name" autocomplete="off" class="form-control" runat="server" id="cname"/>
               </div>
                <div class="mb-3">
     <label for="" class="form-label text-success">Customer Email</label>
      <input type="email" placeholder="email" autocomplete="off" class="form-control" runat="server" id="email"/>
 </div>
                <div class="mb-3">
     <label for="" class="form-label text-success">Gender</label>
                    <asp:DropDownList runat="server" class="form-control" id="gender">
                        <asp:ListItem>Female</asp:ListItem>
                        <asp:ListItem>Male</asp:ListItem>
                        <asp:ListItem>Other</asp:ListItem>
                    </asp:DropDownList>
 </div>
                <div class="mb-3">
     <label for="" class="form-label text-success">Address</label>
      <input type="text" name="address" placeholder="address" autocomplete="off" class="form-control" runat="server" id="address"/>
 </div>
                <div class="mb-3">
     <label for="" class="form-label text-success">Country</label>
      <!--<input type="text" name="country" placeholder="country" autocomplete="off" class="form-control"/>-->
                    <asp:DropDownList ID="country" runat="server" class="form-control">
    <asp:ListItem>India</asp:ListItem>
    <asp:ListItem>USA</asp:ListItem>
    <asp:ListItem>France</asp:ListItem>
    <asp:ListItem>UK</asp:ListItem> 
    <asp:ListItem>Other</asp:ListItem>

</asp:DropDownList>
</div>
<div class="mb-3">
    <label for="" class="form-label text-success">Contact</label>
     <input type="number" placeholder="contact" autocomplete="off" class="form-control"  runat="server" id="contact"/>

 </div>
               
               <div class="row" aria-selected="undefined">
                  <asp:Label runat="server" ID="ErrMsg" class="text-danger"></asp:Label>
                   <br></br>
                   </div>
               
                   <div class="row">
                   <div class="col d-grid"><asp:Button Text="Add" runat="server" id="add" CssClass="btn-success btn-block btn" OnClick="add_Click"/></div>
                    <div class="col d-grid"><asp:Button Text="Update" runat="server" id="update" CssClass="btn-warning btn-block btn" OnClick="update_Click"/></div>
                    <div class="col d-grid"><asp:Button Text="Delete" runat="server" id="delete" CssClass="btn-danger btn-block btn" OnClick="delete_Click"/></div>
                   
               </div>
</div>
 <div class="col-md-8">
     <asp:GridView ID="CustomerList" runat="server" class="table" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="4" ForeColor="#333333" GridLines="Vertical" AutoGenerateSelectButton="True" OnSelectedIndexChanged="CustomerList_SelectedIndexChanged">
         <AlternatingRowStyle BackColor="#CCCCCC" />
         <FooterStyle BackColor="#CCCCCC" />
         <HeaderStyle BackColor="teal" Font-Bold="False" ForeColor="White" />
         <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
         <SelectedRowStyle BackColor="gray" Font-Bold="True" ForeColor="White" />
         <SortedAscendingCellStyle BackColor="#F1F1F1" />
         <SortedAscendingHeaderStyle BackColor="#808080" />
         <SortedDescendingCellStyle BackColor="#CAC9C9" />
         <SortedDescendingHeaderStyle BackColor="#383838" />
     </asp:GridView>
</div>
       </div>
       </div>
</asp:Content>

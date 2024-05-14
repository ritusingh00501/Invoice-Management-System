<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Site1.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication8.Views.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MyContent" runat="server">    
   <div class="container-fluid">
       <div class="row">
           
           <div class="col"> 
               <h3 class="text-center">Manage Invoice</h3>
           </div>
       </div>
       <div class="row">
           <div class="col-md-4">
               <div class="mb-3">
                   <label for="" class="form-label text-success">Customer Name</label>
                    <!--<input type="text" placeholder="customer name" autocomplete="off" class="form-control" runat="server" id="custname"/>-->
                   <asp:DropDownList id="cust_name" runat="server" class="form-control"></asp:DropDownList>
               </div>
                <div class="mb-3">
     <label for="" class="form-label text-success">Customer Email</label>
      <input type="text" placeholder="email" autocomplete="off" class="form-control" runat="server" id="custemail"/>
 </div>
                    <div class="mb-3">
     <label for="" class="form-label text-success">Invoice Date</label>
      <input type="date" placeholder="" autocomplete="off" class="form-control" runat="server" id="date"/>
 </div>

                <div class="mb-3">
     <label for="" class="form-label text-success">Item</label>
      <input type="text" name="item" placeholder="item" autocomplete="off" class="form-control" runat="server" id="item"/>
 </div>
                <div class="mb-3">
     <label for="" class="form-label text-success">Quantity</label>
      <input type="number" name="quantity[]" placeholder="quantity" autocomplete="off" class="form-control" runat="server" id="quantity"/>
 </div>
                <div class="mb-3">
     <label for="" class="form-label text-success">Price</label>
      <input type="number" name="price[]" placeholder="price" autocomplete="off" class="form-control" runat="server" id="price"/>
 </div>
               
                <div class="row" aria-selected="undefined">
    <asp:Label runat="server" ID="ErrMsg" class="text-danger"></asp:Label>
     <br></br>
     </div>
               <div class="row">
                   <div class="col d-grid"><asp:Button Text="Add" runat="server" id="add" CssClass="btn-success btn-block btn" OnClick="add_Click"/></div>
                    <div class="col d-grid"><asp:Button Text="Update" runat="server" id="update" CssClass="btn-warning btn-block btn" OnClick="update_Click"/></div>
                    <div class="col d-grid"><asp:Button Text="Delete" runat="server" ID="delete" CssClass="btn-danger btn-block btn" OnClick="delete_Click"/></div>
                   
               </div>
 </div>
  <div class="col-md-8">
     <asp:GridView ID="InvoiceList" runat="server" class="table" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="4" ForeColor="#333333" GridLines="Vertical" AutoGenerateSelectButton="True" OnSelectedIndexChanged="InvoiceList_SelectedIndexChanged">
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


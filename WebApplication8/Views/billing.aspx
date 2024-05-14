<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Site1.Master" AutoEventWireup="true" CodeBehind="billing.aspx.cs" Inherits="WebApplication8.Views.billing" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MyContent" runat="server">
    <div class="container-fluid">
        <div class="row">
         
        </div>
        <div class="row">
            <div class="col-md-5">
                <h3 class="text-center" style="color:teal;">Invoice Details</h3>
                <div class="row">
                    <div class="col">
                        <div class="mt-3">
    <label for="" class="form-label text-success">Customer Name</label>
     <input type="text" placeholder="customer name" autocomplete="off" class="form-control" runat="server" id="cname"/>
</div>
                    </div>
                    <div class="col">
                        <div class="mt-3">
    <label for="" class="form-label text-success">Date Time</label>
     <input type="text" placeholder="date" autocomplete="off" class="form-control" runat="server" id="date"/>
</div>
                    </div>
                                        <div class="col">
                        <div class="mt-3">
    <label for="" class="form-label text-success">Item</label>
     <input type="text" placeholder="item" autocomplete="off" class="form-control" runat="server" id="item"/>
</div>
                    </div>

                </div>
                                <div class="row">
                    <div class="col">
                        <div class="mt-3">
    <label for="" class="form-label text-success">Quantity</label>
     <input type="text" placeholder="quantity" autocomplete="off" class="form-control" runat="server" id="qty"/>
</div>
                    </div>
                                        <div class="col">
                        <div class="mt-3">
    <label for="" class="form-label text-success">Price</label>
     <input type="text" placeholder="price" autocomplete="off" class="form-control" runat="server" id="price"/>
</div>
                    </div>
                                    </div>
                                    <div class="row" aria-selected="undefined">
   <asp:Label runat="server" ID="ErrMsg" class="text-danger"></asp:Label>
    <br></br>
    </div>
                <div class="row">
                    <div class="col d-grid">
                        <asp:Button Text="Add" runat="server" id="Addbill" CssClass="btn-warning btn-block btn" OnClick="Addbill_Click" />
                    </div>

                </div>
                
                <div class="row mt-5">
                    <h4 class="text-center" style="color:teal;">Invoice List</h4>
                    <div class="col">
                        <asp:GridView ID="InvoiceList" runat="server" class="table" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="4" ForeColor="#333333" GridLines="Vertical" AutoGenerateSelectButton="True" OnSelectedIndexChanged="CustomerList_SelectedIndexChanged">
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
            <div class="col-md-7">

             <h4 class="text-center" style="color:crimson;">Cutomer's Bill</h4>
                    <div class="col">
                        <asp:GridView ID="BillList" runat="server" class="table" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="4" ForeColor="#333333" GridLines="Vertical" AutoGenerateSelectButton="True" OnSelectedIndexChanged="CustomerList_SelectedIndexChanged">
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
                         <div class="col d-grid">
                              <asp:Label runat="server" ID="Grdtotaltb" class="text-danger text-center"></asp:Label>
                             <asp:Button Text="Print" runat="server" id="print" CssClass="btn-warning btn-block btn" OnClick="print_Click" /></div>
                </div>
           

        </div>
    </div>
    </div>
</asp:Content>

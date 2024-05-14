<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Site1.Master" AutoEventWireup="true" CodeBehind="report.aspx.cs" Inherits="WebApplication8.Views.report" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MyContent" runat="server">
    <div class="container-fluid" >
        <div class="row">
       
        </div>
        <div class="row ">
            <div class="col-md-5">
                <h3 class="text-center" style="color:teal;">Invoice Details</h3>
                <div class="row">
                    <div class="col">
                        <div class="mt-3">
    <label for="" class="form-label text-success">Enter Name to search</label>
     <input type="text" placeholder="" autocomplete="off" class="form-control" runat="server" id="name"/>
</div>
                    </div>
                    </div>
                <br></br>
       <div class="row">
                <div class="col d-grid"><asp:Button Text="Search" runat="server" id="search" CssClass="btn-success btn-block btn" OnClick="search_Click"/></div>
            </div>
                </div>
             <div class="col-md-8">
                 <div class="col"><br></br>
                 <h3 class="text-center">View Report</h3>
                 </div>
                 <asp:GridView ID="searchlist" runat="server" class="table" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="4" ForeColor="#333333" GridLines="Vertical" AutoGenerateSelectButton="True" OnSelectedIndexChanged="searchlist_SelectedIndexChanged"> 

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

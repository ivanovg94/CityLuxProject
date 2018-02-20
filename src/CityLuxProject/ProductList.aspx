<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ProductList.aspx.cs" Inherits="CityLuxProject.ProductList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Списък с продукти</h1>
    <asp:GridView
        runat="server"
        ID="ProductsGrid"
        AutoGenerateColumns="false"
        ItemType="CityLuxProject.ProductListGridViewModel"
        CssClass="table  table-bordered table-condensed table-hover">

        <Columns>
            <asp:TemplateField HeaderText="Име на Продукта">
                <ItemTemplate>
                    <asp:Label runat="server" Text='<%#: Item.ProductName %>'> </asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Тип на продукта">
                <ItemTemplate>
                    <asp:Label runat="server" Text='<%#: Item.MerchandiseGroup %>'> </asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Цена">
                <ItemTemplate>
                    <asp:Label runat="server" Text='<%#: Item.Price %>'> </asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
</asp:Content>

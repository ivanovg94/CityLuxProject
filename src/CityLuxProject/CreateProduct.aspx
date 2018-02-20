<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CreateProduct.aspx.cs" Inherits="CityLuxProject.CreateProduct" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Създаване на продукт</h1>
    <div class="form-group">
        <asp:Label runat="server" AssociatedControlID="CreateProductTextBox" CssClass="col-md-2 control-label">Име на продукта</asp:Label>
        <div class="col-md-10">
            <asp:TextBox runat="server" ID="CreateProductTextBox" CssClass="form-control"> </asp:TextBox>
            <br />
        </div>
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="ProductTypeDropDown" CssClass="col-md-2 control-label">Тип на продукта</asp:Label>
            <div class="col-md-10">
                <asp:DropDownList
                    runat="server"
                    ID="ProductTypeDropDown"
                    CssClass="form-control"
                    Width="300px"
                    DataValueField="Id"
                    DataTextField="Name">
                </asp:DropDownList>
                <br />
            </div>
        </div>
        <div class="form-group">
            <div class="col-lg-10 col-lg-offset-2">
                <asp:CheckBoxList
                    ID="ComponentsList"
                    CssClass="control-checkbox "
                    RepeatDirection="Vertical"
                    RepeatColumns="3"
                    RepeatLayout="Table"
                    runat="server"
                    DataValueField="Id"
                    DataTextField="Name">
                </asp:CheckBoxList>
            </div>
        </div>
        <div class="form-group">
            <div class="col-lg-10 col-lg-offset-2">
                <asp:Button ID="CreateProductBtn"
                    runat="server"
                    Text="Създай"
                    OnClick="CreateProductBtn_Click" />
            </div>
        </div>
    </div>
</asp:Content>

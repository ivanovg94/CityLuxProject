<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CreateComponent.aspx.cs" Inherits="CityLuxProject.CreateComponent" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Създаване на компонент</h1>
    <div class="form-group">
        <asp:Label runat="server" AssociatedControlID="ComponentNameTextBox" CssClass="col-md-2 control-label">Име на компонента</asp:Label>
        <div class="col-md-10">
            <asp:TextBox runat="server" ID="ComponentNameTextBox" CssClass="form-control"> </asp:TextBox>
            <br />
        </div>
    </div>
    <div class="form-group">
        <asp:Label runat="server" AssociatedControlID="ComponentNameTextBox" CssClass="col-md-2 control-label">Тип на компонента</asp:Label>
        <div class="col-md-10">
            <asp:DropDownList
                runat="server"
                ID="ComponentTypeDropDown"
                CssClass="form-control"
                Width="300px"
                DataValueField="Id"
                DataTextField="Name">
            </asp:DropDownList>
            <br />
        </div>
    </div>
    <div class="form-group">
        <asp:Label runat="server" AssociatedControlID="PriceTextBox" CssClass="col-md-2 control-label">Цена на компонента</asp:Label>
        <div class="col-md-10">
            <asp:TextBox runat="server" ID="PriceTextBox" CssClass="form-control"> </asp:TextBox>
            <br />
        </div>
    </div>

    <div class="form-group">
        <div class="col-md-10">
            <asp:Button runat="server" ID="CreateComponentBtn" Text="Създай компонент" OnClick="CreateComponentBtn_Click" />
            <br />
        </div>
    </div>
</asp:Content>

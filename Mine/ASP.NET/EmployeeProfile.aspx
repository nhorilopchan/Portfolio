<%@ Page Title="" Language="C#" MasterPageFile="~/SiteMaster.Master" AutoEventWireup="true" CodeBehind="EmployeeProfile.aspx.cs" Inherits="Mine.ASP.NET.EmployeeProfile" %>

<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">

    <asp:Panel runat="server" ID="pnlEmployeeProfile" CssClass="container">
        <div class="text-center">
            <asp:DropDownList runat="server" ID="ddlKeywordList" CssClass="btn btn-default dropdown-toggle" AutoPostBack="True" OnSelectedIndexChanged="ddlKeywordList_OnSelectedIndexChanged" />
            <asp:DropDownList runat="server" ID="ddlKeywordValueList" CssClass="btn btn-default dropdown-toggle"/>
<%--            <asp:TextBox runat="server" ID="txtKeywordSearch" placeholder="Enter Keyword" CssClass="input-sm"></asp:TextBox>--%>
            <asp:Button runat="server" ID="btnKeywordSearch" OnClick="btnKeywordSearch_OnClick" Text="Search" CssClass="btn btn-primary" />
        </div>
        <ul>
            <asp:Repeater runat="server" ID="rptEmployee">
                <ItemTemplate>
                    <li>
                        <h4>
                            <%#Eval("FirstName")%>&nbsp;<%#Eval("LastName") %>
                        </h4>
                        <div>
                            <ul>
                                <li>Position:&nbsp;<%#Eval("Position") %></li>
                                <li>Status:&nbsp;<%#Eval("Status") %></li>
                                <li>Projects:&nbsp;<%#Eval("Projects") %></li>
                            </ul>
                        </div>
                    </li>
                    <hr />
                </ItemTemplate>
            </asp:Repeater>
        </ul>
        <div class="container-fluid text-center">
            <asp:GridView runat="server" ID="gvEmployee">
            </asp:GridView>
        </div>
    </asp:Panel>
</asp:Content>

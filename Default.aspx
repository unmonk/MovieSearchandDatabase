<%@ Page Title="Home" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication2._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div align="center" class="jumbotron">
        
        <p>
        <h1>Search For A Movie:</h1>
            </p>
        <p>
            <asp:TextBox ID="searchQuery" runat="server" OnTextChanged="searchQuery_TextChanged"></asp:TextBox><asp:Button ID="searchButton" runat="server" Text="Search" UseSubmitBehavior="True" OnClick="searchButton_Click" BackColor="#CC3300" BorderColor="Maroon" />
            <p>
                <h3><asp:Label ID="noFoundLabel" runat="server" Text="No Results Found"></asp:Label></h3></p>
        </p>
    </div>
    <div runat="server" id="searchResults">
    <div class="row" align="center">

        <div class="col-md-4">
            <h2>Result 1:</h2>
            <p>
                <asp:Image ID="Image1" runat="server"/>
                </p>
            <center>
                <table style="width: 100%;">
                    <tr>
                        <td>Title:   </td>
                        <td><asp:Label ID="movieTitle1" runat="server" Text=""></asp:Label></td>
                    </tr>
                    <tr>
                        <td>MovieID:   </td>
                        <<td><asp:Label ID="movieID1" runat="server" Text=""></asp:Label></td>
                    </tr>
                    <tr>
                        <td>Release Date:   </td>
                        <td><asp:Label ID="movieDate1" runat="server" Text=""></asp:Label></td>
                    </tr>
                    <tr>
                        <td>Popularity:   </td>
                        <td><asp:Label ID="moviePop1" runat="server" Text=""></asp:Label></td>
                    </tr>
                 
                </table>    
                </center>
            <p>
                <asp:Button ID="LibraryButton1" runat="server" Text="Add to Library" BackColor="#66FFCC" BorderColor="#33CC33" OnClick="LibraryButton1_Click" Visible="false" />
            </p>
        </div>

        <div class="col-md-4">
            <h2>Result 2:</h2>
            <p>
                <asp:Image ID="Image2" runat="server"/>
                </p>
                <table style="width: 100%;">
                    <tr>
                        <td>Title:   </td>
                        <td><asp:Label ID="movieTitle2" runat="server" Text=""></asp:Label></td>
                    </tr>
                    <tr>
                        <td>MovieID:   </td>
                        <<td><asp:Label ID="movieID2" runat="server" Text=""></asp:Label></td>
                    </tr>
                    <tr>
                        <td>Release Date:   </td>
                        <td><asp:Label ID="movieDate2" runat="server" Text=""></asp:Label></td>
                    </tr>
                    <tr>
                        <td>Popularity:   </td>
                        <td><asp:Label ID="moviePop2" runat="server" Text=""></asp:Label></td>
                    </tr>
                   
                </table>
            <p>
                <asp:Button ID="LibraryButton2" runat="server" Text="Add To Library" BackColor="#66FFCC" BorderColor="#33CC33" OnClick="LibraryButton2_Click" Visible="false" />
            </p>
        </div>

        <div class="col-md-4">
            <h2>Result 3:</h2>
            <p>
                <asp:Image ID="Image3" runat="server"/>
                </p>
                <table style="width: 100%;">
                    <tr>
                        <td>Title:   </td>
                        <td><asp:Label ID="movieTitle3" runat="server" Text=""></asp:Label></td>
                    </tr>
                    <tr>
                        <td>MovieID:   </td>
                        <<td><asp:Label ID="movieID3" runat="server" Text=""></asp:Label></td>
                    </tr>
                    <tr>
                        <td>Release Date:   </td>
                        <td><asp:Label ID="movieDate3" runat="server" Text=""></asp:Label></td>
                    </tr>
                    <tr>
                        <td>Popularity:   </td>
                        <td><asp:Label ID="moviePop3" runat="server" Text=""></asp:Label></td>
                    </tr>
                   
                </table>
            <p>
                <asp:Button ID="LibraryButton3" runat="server" Text="Add To Library" BackColor="#66FFCC" BorderColor="#33CC33" OnClick="LibraryButton3_Click" Visible="false" />
            </p>
        </div>
    </div>
        </div>
</asp:Content>

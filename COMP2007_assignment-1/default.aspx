<%@ Page Title="" Language="C#" MasterPageFile="~/default.Master" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="COMP2007_assignment_1._default1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="col-sm-5 col-md-5">
    <div class="well">
        <div class="panel panel-primary">
            <div class="panel-heading">
                <h3 class="panel-title">Game 1</h3>
            </div>
            <div class="panel-body">
                <div class="form-group">
                    <asp:Label class="col-lg-10 control-label" for="rblResult_1" ID="lblResult_1" runat="server" Text="Result"></asp:Label>
                    <div class="radio">
                        <div class="radio-inline">
                            <asp:RadioButtonList ID="rblResult_1" runat="server">
                                <asp:ListItem  Text="Lose" Value="0"></asp:ListItem>
                                <asp:ListItem  Text="Win" Value="1"></asp:ListItem>
                            </asp:RadioButtonList>
                        </div>
                    </div>
                 </div>

                <div class="form-group">
                    <asp:Label class="control-label" for="txtPointScore_1" ID="lblPointScore_1" runat="server" Text="Points Scored"></asp:Label>
                    <asp:TextBox CssClass="form-control" ID="txtPointScore_1" runat="server" ></asp:TextBox>

                </div>
                
                <div class="form-group">
                    <asp:Label class="control-label" for="txtAllowedPoints_1" ID="lblAllowedPoints_1" runat="server" Text="Allowed Points"></asp:Label>
                    <asp:TextBox CssClass="form-control" ID="txtAllowedPoints_1" runat="server" ></asp:TextBox>

                </div>

                <div class="form-group">
                    <asp:Label class="control-label" for="txtSpectators_1" ID="lblSpectators_1" runat="server" Text="Spectators"></asp:Label>
                    <asp:TextBox CssClass="form-control" ID="txtSpectators_1" runat="server" ></asp:TextBox>
                </div>
            </div>
        </div>
    </div>
    </div>

</asp:Content>



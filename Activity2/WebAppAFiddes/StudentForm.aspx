<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="StudentForm.aspx.cs" Inherits="WebAppAFiddes.StudentForm" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server" Type="con">
    <div class="page-header">
        <h1>StudentForm</h1>
    </div>

    <div class="row col-md-12">
        <div class="alert alert-info">
            <blockquote style="font-style: italic">
                This assessment will test web form construction, validation, data collection and display. 
            </blockquote>
        </div>
    </div>

    <asp:RequiredFieldValidator ID="RequiredFieldStudentID" runat="server"
        ErrorMessage="Student ID is required." Display="None"
        SetFocusOnError="true" ForeColor="Firebrick"
        ControlToValidate="StudentID">
    </asp:RequiredFieldValidator>
    <asp:RequiredFieldValidator ID="RequiredFieldName" runat="server"
        ErrorMessage="Name is required." Display="None"
        SetFocusOnError="true" ForeColor="Firebrick"
        ControlToValidate="Name">
    </asp:RequiredFieldValidator>
    <asp:RequiredFieldValidator ID="RequiredFieldCredits" runat="server"
        ErrorMessage="Credits are required." Display="None"
        SetFocusOnError="true" ForeColor="Firebrick"
        ControlToValidate="Credits">
    </asp:RequiredFieldValidator>
    <asp:RequiredFieldValidator ID="RequiredFieldEmergencyPhoneNumber" runat="server"
        ErrorMessage="Emergency phone number is required." Display="None"
        SetFocusOnError="true" ForeColor="Firebrick"
        ControlToValidate="EmergencyPhoneNumber">
    </asp:RequiredFieldValidator>

    <asp:RangeValidator ID="" runat="server" ErrorMessage="Student ID is a number greaten than 0" Display="None"
        SetFocusOnError="true" ForeColor="Firebrick"
        ControlToValidate="StudentID"
        MaximumValue="20" MinimumValue="1" Type="Integer">
    </asp:RangeValidator>

    <asp:RangeValidator ID="RegularExpressionName" runat="server"
        ErrorMessage="Name is a minimum string of 3 letters." Display="None"
        SetFocusOnError="true" ForeColor="Firebrick"
        ControlToValidate="PostalCode"
        MaximumValue="25" MinimumValue="3" Type="String">
    </asp:RangeValidator>

    <asp:RangeValidator ID="RegularExpressionCredits" runat="server" ErrorMessage="Credits are of range (0.0 - 40.0)" Display="None"
        SetFocusOnError="true" ForeColor="Firebrick"
        ControlToValidate="Credits"
        MaximumValue="20" MinimumValue="1" Type="Integer">
    </asp:RangeValidator>

    <asp:RegularExpressionValidator ID="RegularExpressionEmergencyPhoneNumber" runat="server"
        ErrorMessage="Emergency phone number is invalid (ex. 780.102.0123)" Display="None"
        SetFocusOnError="true" ForeColor="Firebrick"
        ControlToValidate="EmergencyPhoneNumber"
        ValidationExpression="[7-9][.][1-9][.][1-9]">
    </asp:RegularExpressionValidator>



    <asp:ValidationSummary ID="ValidationSummary1" runat="server"
        HeaderText="Correct the following concerns and resubmit."
        CssClass="alert alert-danger" />

    <div class="row">
        <div class="col-md-6">
            <fieldset class="form-horizontal">
                <legend>Student Form</legend>

                <asp:Label ID="Label1" runat="server" Text="StudentID"
                    AssociatedControlID="StudentID"></asp:Label>
                <asp:TextBox ID="StudentID" runat="server"
                    ToolTip="Enter Student ID." MaxLength="20"></asp:TextBox>

                <asp:Label ID="Label6" runat="server" Text="Name"
                    AssociatedControlID="Name"></asp:Label>
                <asp:TextBox ID="Name" runat="server"
                    ToolTip="Enter your name." MaxLength="25"></asp:TextBox>

                <asp:Label ID="Label2" runat="server" Text="Credits"
                    AssociatedControlID="Credits"></asp:Label>
                <asp:TextBox ID="Credits" runat="server"
                    ToolTip="Enter Credits." MaxLength="20"></asp:TextBox>

                <asp:Label ID="Label7" runat="server" Text="EmergencyPhoneNumber"
                    AssociatedControlID="EmergencyPhoneNumber"></asp:Label>
                <asp:TextBox ID="EmergencyPhoneNumber" runat="server"
                    ToolTip="Enter an emergency phone number" MaxLength="75"></asp:TextBox>
                <br />
            </fieldset>
            <div class="col-md-6">
                <div class="col-md-offset-2">
                    <p>
                        <asp:Button ID="Submit" runat="server" Text="Add Student" OnClick="Submit_Click" />&nbsp;&nbsp;
                    <asp:Button ID="Clear" runat="server" Text="Clear" CausesValidation="true" OnClick="Clear_Click" />
                    </p>
                    <asp:Label ID="Message" runat="server"></asp:Label>
                    <br />
                    <hr style="width: 5px;" />
                    <asp:GridView ID="Student" runat="server"></asp:GridView>
                </div>
            </div>
        </div>
    </div>
    <script src="../Scripts/bootwrap-freecode.js"></script>
</asp:Content>

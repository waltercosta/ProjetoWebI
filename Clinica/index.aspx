<%@ Page Title="" Language="C#" MasterPageFile="~/MasterIndex.Master" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="Clinica.index" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" DataObjectTypeName="Clinica.MEDICO" DeleteMethod="deletarMedico" InsertMethod="adcionarMedico" OldValuesParameterFormatString="original_{0}" SelectMethod="selectMedico" TypeName="Clinica.Controllers.MedicoController" UpdateMethod="atualizarMedico">
        <SelectParameters>
            <asp:Parameter Name="id" Type="Int32" />
        </SelectParameters>
    </asp:ObjectDataSource>
    <asp:FormView ID="FormView1" runat="server" DataSourceID="ObjectDataSource1">
        <EditItemTemplate>
            med_id:
            <asp:TextBox ID="med_idTextBox" runat="server" Text='<%# Bind("med_id") %>' />
            <br />
            med_nom:
            <asp:TextBox ID="med_nomTextBox" runat="server" Text='<%# Bind("med_nom") %>' />
            <br />
            med_end:
            <asp:TextBox ID="med_endTextBox" runat="server" Text='<%# Bind("med_end") %>' />
            <br />
            med_cpf:
            <asp:TextBox ID="med_cpfTextBox" runat="server" Text='<%# Bind("med_cpf") %>' />
            <br />
            med_fone:
            <asp:TextBox ID="med_foneTextBox" runat="server" Text='<%# Bind("med_fone") %>' />
            <br />
            med_crm:
            <asp:TextBox ID="med_crmTextBox" runat="server" Text='<%# Bind("med_crm") %>' />
            <br />
            med_cidade:
            <asp:TextBox ID="med_cidadeTextBox" runat="server" Text='<%# Bind("med_cidade") %>' />
            <br />
            med_estado:
            <asp:TextBox ID="med_estadoTextBox" runat="server" Text='<%# Bind("med_estado") %>' />
            <br />
            med_qtd_atend:
            <asp:TextBox ID="med_qtd_atendTextBox" runat="server" Text='<%# Bind("med_qtd_atend") %>' />
            <br />
            CONSULTA:
            <asp:TextBox ID="CONSULTATextBox" runat="server" Text='<%# Bind("CONSULTA") %>' />
            <br />
            <asp:LinkButton ID="UpdateButton" runat="server" CausesValidation="True" CommandName="Update" Text="Update" />
            &nbsp;<asp:LinkButton ID="UpdateCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
        </EditItemTemplate>
        <InsertItemTemplate>
            med_id:
            <asp:TextBox ID="med_idTextBox" runat="server" Text='<%# Bind("med_id") %>' />
            <br />
            med_nom:
            <asp:TextBox ID="med_nomTextBox" runat="server" Text='<%# Bind("med_nom") %>' />
            <br />
            med_end:
            <asp:TextBox ID="med_endTextBox" runat="server" Text='<%# Bind("med_end") %>' />
            <br />
            med_cpf:
            <asp:TextBox ID="med_cpfTextBox" runat="server" Text='<%# Bind("med_cpf") %>' />
            <br />
            med_fone:
            <asp:TextBox ID="med_foneTextBox" runat="server" Text='<%# Bind("med_fone") %>' />
            <br />
            med_crm:
            <asp:TextBox ID="med_crmTextBox" runat="server" Text='<%# Bind("med_crm") %>' />
            <br />
            med_cidade:
            <asp:TextBox ID="med_cidadeTextBox" runat="server" Text='<%# Bind("med_cidade") %>' />
            <br />
            med_estado:
            <asp:TextBox ID="med_estadoTextBox" runat="server" Text='<%# Bind("med_estado") %>' />
            <br />
            med_qtd_atend:
            <asp:TextBox ID="med_qtd_atendTextBox" runat="server" Text='<%# Bind("med_qtd_atend") %>' />
            <br />
            CONSULTA:
            <asp:TextBox ID="CONSULTATextBox" runat="server" Text='<%# Bind("CONSULTA") %>' />
            <br />
            <asp:LinkButton ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="Insert" />
            &nbsp;<asp:LinkButton ID="InsertCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
        </InsertItemTemplate>
        <ItemTemplate>
            med_id:
            <asp:Label ID="med_idLabel" runat="server" Text='<%# Bind("med_id") %>' />
            <br />
            med_nom:
            <asp:Label ID="med_nomLabel" runat="server" Text='<%# Bind("med_nom") %>' />
            <br />
            med_end:
            <asp:Label ID="med_endLabel" runat="server" Text='<%# Bind("med_end") %>' />
            <br />
            med_cpf:
            <asp:Label ID="med_cpfLabel" runat="server" Text='<%# Bind("med_cpf") %>' />
            <br />
            med_fone:
            <asp:Label ID="med_foneLabel" runat="server" Text='<%# Bind("med_fone") %>' />
            <br />
            med_crm:
            <asp:Label ID="med_crmLabel" runat="server" Text='<%# Bind("med_crm") %>' />
            <br />
            med_cidade:
            <asp:Label ID="med_cidadeLabel" runat="server" Text='<%# Bind("med_cidade") %>' />
            <br />
            med_estado:
            <asp:Label ID="med_estadoLabel" runat="server" Text='<%# Bind("med_estado") %>' />
            <br />
            med_qtd_atend:
            <asp:Label ID="med_qtd_atendLabel" runat="server" Text='<%# Bind("med_qtd_atend") %>' />
            <br />
            CONSULTA:
            <asp:Label ID="CONSULTALabel" runat="server" Text='<%# Bind("CONSULTA") %>' />
            <br />
            <asp:LinkButton ID="EditButton" runat="server" CausesValidation="False" CommandName="Edit" Text="Edit" />
            &nbsp;<asp:LinkButton ID="DeleteButton" runat="server" CausesValidation="False" CommandName="Delete" Text="Delete" />
            &nbsp;<asp:LinkButton ID="NewButton" runat="server" CausesValidation="False" CommandName="New" Text="New" />
        </ItemTemplate>
    </asp:FormView>

    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="ObjectDataSource1">
        <Columns>
            <asp:BoundField DataField="med_id" HeaderText="med_id" SortExpression="med_id" />
            <asp:BoundField DataField="med_nom" HeaderText="med_nom" SortExpression="med_nom" />
            <asp:BoundField DataField="med_end" HeaderText="med_end" SortExpression="med_end" />
            <asp:BoundField DataField="med_cpf" HeaderText="med_cpf" SortExpression="med_cpf" />
            <asp:BoundField DataField="med_fone" HeaderText="med_fone" SortExpression="med_fone" />
            <asp:BoundField DataField="med_crm" HeaderText="med_crm" SortExpression="med_crm" />
            <asp:BoundField DataField="med_cidade" HeaderText="med_cidade" SortExpression="med_cidade" />
            <asp:BoundField DataField="med_estado" HeaderText="med_estado" SortExpression="med_estado" />
            <asp:BoundField DataField="med_qtd_atend" HeaderText="med_qtd_atend" SortExpression="med_qtd_atend" />
        </Columns>
    </asp:GridView>
    </asp:Content>

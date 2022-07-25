Imports System.Data.SqlClient

Public Class CustomerOrders
    Inherits Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        If Not IsPostBack Then
            LoadGridData()
        End If
    End Sub

    Private Sub LoadGridData()
        Dim connString As String = ConfigurationManager.ConnectionStrings("WebFormsAppConnectionString").ConnectionString
        Dim conn As New SqlConnection(connString)
        Dim sqlSelectString = "SELECT C.Name as CustomerName, C.Address as CustomerAddress, O.OrderNumber as OrderNumber, O.OrderDate as OrderDate, O.OrderDescription as OrderDescription, O.OrderAmount as OrderAmount FROM CUSTOMERS C INNER JOIN ORDERS O ON C.ID = O.CustomerId"
        Dim cmd As New SqlCommand(sqlSelectString, conn)
        Dim ds As DataSet
        Dim da As New SqlDataAdapter(sqlSelectString, conn)
        ds = New DataSet()
        da.Fill(ds)
        GridView1.DataSource = ds
        GridView1.DataBind()
    End Sub

    Protected Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        LoadGridData()
    End Sub
End Class
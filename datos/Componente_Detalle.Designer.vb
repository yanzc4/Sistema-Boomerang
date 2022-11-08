Partial Class Componente_Detalle
    Inherits System.ComponentModel.Component

    <System.Diagnostics.DebuggerNonUserCode()> _
    Public Sub New(ByVal container As System.ComponentModel.IContainer)
        MyClass.New()

        'Requerido para la compatibilidad con el Diseñador de composiciones de clases Windows.Forms
        If (container IsNot Nothing) Then
            container.Add(Me)
        End If

    End Sub

    <System.Diagnostics.DebuggerNonUserCode()> _
    Public Sub New()
        MyBase.New()

        'El Diseñador de componentes requiere esta llamada.
        InitializeComponent()

    End Sub

    'Component reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de componentes
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de componentes requiere el siguiente procedimiento
    'Se puede modificar usando el Diseñador de componentes.
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Componente_Detalle))
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlDataAdapter1 = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection()
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT       venta_detalle.*" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM            venta_detalle"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = resources.GetString("SqlInsertCommand1.CommandText")
        Me.SqlInsertCommand1.Connection = Me.SqlConnection1
        Me.SqlInsertCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@id_venta", System.Data.SqlDbType.Int, 0, "id_venta"), New System.Data.SqlClient.SqlParameter("@id_plato", System.Data.SqlDbType.Int, 0, "id_plato"), New System.Data.SqlClient.SqlParameter("@decripcion", System.Data.SqlDbType.VarChar, 0, "decripcion"), New System.Data.SqlClient.SqlParameter("@cantidad", System.Data.SqlDbType.Int, 0, "cantidad"), New System.Data.SqlClient.SqlParameter("@precio", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(2, Byte), "precio", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@cliente", System.Data.SqlDbType.VarChar, 0, "cliente"), New System.Data.SqlClient.SqlParameter("@usuario", System.Data.SqlDbType.NChar, 0, "usuario"), New System.Data.SqlClient.SqlParameter("@fecha", System.Data.SqlDbType.[Date], 0, "fecha")})
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = resources.GetString("SqlUpdateCommand1.CommandText")
        Me.SqlUpdateCommand1.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@id_venta", System.Data.SqlDbType.Int, 0, "id_venta"), New System.Data.SqlClient.SqlParameter("@id_plato", System.Data.SqlDbType.Int, 0, "id_plato"), New System.Data.SqlClient.SqlParameter("@decripcion", System.Data.SqlDbType.VarChar, 0, "decripcion"), New System.Data.SqlClient.SqlParameter("@cantidad", System.Data.SqlDbType.Int, 0, "cantidad"), New System.Data.SqlClient.SqlParameter("@precio", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(2, Byte), "precio", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@cliente", System.Data.SqlDbType.VarChar, 0, "cliente"), New System.Data.SqlClient.SqlParameter("@usuario", System.Data.SqlDbType.NChar, 0, "usuario"), New System.Data.SqlClient.SqlParameter("@fecha", System.Data.SqlDbType.[Date], 0, "fecha"), New System.Data.SqlClient.SqlParameter("@Original_id_venta_detalle", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_venta_detalle", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_id_venta", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_venta", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_id_plato", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_plato", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_decripcion", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "decripcion", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_decripcion", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "decripcion", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_cantidad", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cantidad", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_precio", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "precio", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_precio", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(2, Byte), "precio", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_cliente", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "cliente", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_cliente", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cliente", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_usuario", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "usuario", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_usuario", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "usuario", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_fecha", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "fecha", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_fecha", System.Data.SqlDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "fecha", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@id_venta_detalle", System.Data.SqlDbType.Int, 4, "id_venta_detalle")})
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = resources.GetString("SqlDeleteCommand1.CommandText")
        Me.SqlDeleteCommand1.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_id_venta_detalle", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_venta_detalle", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_id_venta", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_venta", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_id_plato", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_plato", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_decripcion", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "decripcion", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_decripcion", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "decripcion", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_cantidad", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cantidad", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_precio", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "precio", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_precio", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(2, Byte), "precio", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_cliente", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "cliente", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_cliente", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cliente", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_usuario", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "usuario", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_usuario", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "usuario", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_fecha", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "fecha", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_fecha", System.Data.SqlDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "fecha", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlDataAdapter1
        '
        Me.SqlDataAdapter1.DeleteCommand = Me.SqlDeleteCommand1
        Me.SqlDataAdapter1.InsertCommand = Me.SqlInsertCommand1
        Me.SqlDataAdapter1.SelectCommand = Me.SqlSelectCommand1
        Me.SqlDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "venta_detalle", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_venta_detalle", "id_venta_detalle"), New System.Data.Common.DataColumnMapping("id_venta", "id_venta"), New System.Data.Common.DataColumnMapping("id_plato", "id_plato"), New System.Data.Common.DataColumnMapping("decripcion", "decripcion"), New System.Data.Common.DataColumnMapping("cantidad", "cantidad"), New System.Data.Common.DataColumnMapping("precio", "precio"), New System.Data.Common.DataColumnMapping("cliente", "cliente"), New System.Data.Common.DataColumnMapping("usuario", "usuario"), New System.Data.Common.DataColumnMapping("fecha", "fecha")})})
        Me.SqlDataAdapter1.UpdateCommand = Me.SqlUpdateCommand1
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "Data Source=boomerang.mssql.somee.com;Initial Catalog=boomerang;Persist Security " &
    "Info=True;User ID=yanzc_SQLLogin_1;Password=imursqu4lm"
        Me.SqlConnection1.FireInfoMessageEventOnUserErrors = False

    End Sub

    Friend WithEvents SqlSelectCommand1 As SqlClient.SqlCommand
    Friend WithEvents SqlConnection1 As SqlClient.SqlConnection
    Friend WithEvents SqlInsertCommand1 As SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As SqlClient.SqlCommand
    Friend WithEvents SqlDataAdapter1 As SqlClient.SqlDataAdapter
End Class

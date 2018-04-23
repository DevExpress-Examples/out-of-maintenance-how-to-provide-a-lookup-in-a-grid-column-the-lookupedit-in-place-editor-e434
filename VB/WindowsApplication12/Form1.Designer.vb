Imports Microsoft.VisualBasic
Imports System
Namespace WindowsApplication12
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
			Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.dataSet1 = New System.Data.DataSet()
			Me.dataTable1 = New System.Data.DataTable()
			Me.dataTable2 = New System.Data.DataTable()
			Me.dataColumn1 = New System.Data.DataColumn()
			Me.dataColumn2 = New System.Data.DataColumn()
			Me.dataColumn3 = New System.Data.DataColumn()
			Me.dataColumn4 = New System.Data.DataColumn()
			Me.dataColumn5 = New System.Data.DataColumn()
			Me.ProductsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
			Me.OrdersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
			Me.colOrderID = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colProductID = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colNotes = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.repositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.dataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.dataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.dataTable2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.ProductsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.OrdersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' gridControl1
			' 
			Me.gridControl1.DataSource = Me.OrdersBindingSource
			Me.gridControl1.EmbeddedNavigator.Name = ""
			Me.gridControl1.Location = New System.Drawing.Point(107, 33)
			Me.gridControl1.MainView = Me.gridView1
			Me.gridControl1.Name = "gridControl1"
			Me.gridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.repositoryItemLookUpEdit1})
			Me.gridControl1.Size = New System.Drawing.Size(493, 318)
			Me.gridControl1.TabIndex = 0
			Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView1})
			' 
			' gridView1
			' 
			Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.colOrderID, Me.colProductID, Me.colNotes})
			Me.gridView1.GridControl = Me.gridControl1
			Me.gridView1.Name = "gridView1"
			' 
			' dataSet1
			' 
			Me.dataSet1.DataSetName = "NewDataSet"
			Me.dataSet1.Tables.AddRange(New System.Data.DataTable() { Me.dataTable1, Me.dataTable2})
			' 
			' dataTable1
			' 
			Me.dataTable1.Columns.AddRange(New System.Data.DataColumn() { Me.dataColumn1, Me.dataColumn2})
			Me.dataTable1.TableName = "Products"
			' 
			' dataTable2
			' 
			Me.dataTable2.Columns.AddRange(New System.Data.DataColumn() { Me.dataColumn3, Me.dataColumn4, Me.dataColumn5})
			Me.dataTable2.TableName = "Orders"
			' 
			' dataColumn1
			' 
			Me.dataColumn1.ColumnName = "ProductID"
			Me.dataColumn1.DataType = GetType(Integer)
			' 
			' dataColumn2
			' 
			Me.dataColumn2.ColumnName = "Name"
			' 
			' dataColumn3
			' 
			Me.dataColumn3.ColumnName = "OrderID"
			' 
			' dataColumn4
			' 
			Me.dataColumn4.ColumnName = "ProductID"
			Me.dataColumn4.DataType = GetType(Integer)
			' 
			' dataColumn5
			' 
			Me.dataColumn5.ColumnName = "Notes"
			' 
			' ProductsBindingSource
			' 
			Me.ProductsBindingSource.DataMember = "Products"
			Me.ProductsBindingSource.DataSource = Me.dataSet1
			' 
			' OrdersBindingSource
			' 
			Me.OrdersBindingSource.DataMember = "Orders"
			Me.OrdersBindingSource.DataSource = Me.dataSet1
			' 
			' colOrderID
			' 
			Me.colOrderID.Caption = "OrderID"
			Me.colOrderID.FieldName = "OrderID"
			Me.colOrderID.Name = "colOrderID"
			Me.colOrderID.Visible = True
			Me.colOrderID.VisibleIndex = 0
			' 
			' colProductID
			' 
			Me.colProductID.Caption = "ProductID"
			Me.colProductID.ColumnEdit = Me.repositoryItemLookUpEdit1
			Me.colProductID.FieldName = "ProductID"
			Me.colProductID.Name = "colProductID"
			Me.colProductID.Visible = True
			Me.colProductID.VisibleIndex = 1
			' 
			' colNotes
			' 
			Me.colNotes.Caption = "Notes"
			Me.colNotes.FieldName = "Notes"
			Me.colNotes.Name = "colNotes"
			Me.colNotes.Visible = True
			Me.colNotes.VisibleIndex = 2
			' 
			' repositoryItemLookUpEdit1
			' 
			Me.repositoryItemLookUpEdit1.AutoHeight = False
			Me.repositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.repositoryItemLookUpEdit1.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() { New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name", 33, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
			Me.repositoryItemLookUpEdit1.DataSource = Me.ProductsBindingSource
			Me.repositoryItemLookUpEdit1.DisplayMember = "Name"
			Me.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1"
			Me.repositoryItemLookUpEdit1.ValueMember = "ProductID"
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(676, 363)
			Me.Controls.Add(Me.gridControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.dataSet1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.dataTable1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.dataTable2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.ProductsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.OrdersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private gridControl1 As DevExpress.XtraGrid.GridControl
		Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
		Private dataSet1 As System.Data.DataSet
		Private dataTable1 As System.Data.DataTable
		Private dataTable2 As System.Data.DataTable
		Private dataColumn1 As System.Data.DataColumn
		Private dataColumn2 As System.Data.DataColumn
		Private dataColumn3 As System.Data.DataColumn
		Private dataColumn4 As System.Data.DataColumn
		Private dataColumn5 As System.Data.DataColumn
		Private ProductsBindingSource As System.Windows.Forms.BindingSource
		Private OrdersBindingSource As System.Windows.Forms.BindingSource
		Private colOrderID As DevExpress.XtraGrid.Columns.GridColumn
		Private colProductID As DevExpress.XtraGrid.Columns.GridColumn
		Private repositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
		Private colNotes As DevExpress.XtraGrid.Columns.GridColumn
	End Class
End Namespace


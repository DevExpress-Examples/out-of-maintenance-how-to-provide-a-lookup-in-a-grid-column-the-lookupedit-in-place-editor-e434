Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms

Namespace WindowsApplication12
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			For i As Integer = 0 To 4
				dataTable1.Rows.Add(New Object() { i, "Product" & i})
			Next i
			For i As Integer = 0 To 29
				dataTable2.Rows.Add(New Object() { i, i Mod 5, "details"})
			Next i
		End Sub
	End Class
End Namespace
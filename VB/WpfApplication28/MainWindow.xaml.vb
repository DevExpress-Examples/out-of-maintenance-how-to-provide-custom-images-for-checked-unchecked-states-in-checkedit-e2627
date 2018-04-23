Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Data
Imports System.Windows.Documents
Imports System.Windows.Input
Imports System.Windows.Media
Imports System.Windows.Media.Imaging
Imports System.Windows.Navigation
Imports System.Windows.Shapes
Imports System.Data

Namespace WpfApplication28
	''' <summary>
	''' Interaction logic for MainWindow.xaml
	''' </summary>
	Partial Public Class MainWindow
		Inherits Window
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Window_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
			Dim table As New DataTable()
			table.Columns.Add("Subject", GetType(String))
			table.Columns.Add("IsRead", GetType(Boolean))
			table.Rows.Add(New Object() {"Mail1", True})
			table.Rows.Add(New Object() {"Mail2", False})

			gridControl1.DataSource = table
		End Sub
	End Class
End Namespace

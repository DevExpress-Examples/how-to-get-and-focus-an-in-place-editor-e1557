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
Imports DevExpress.Wpf.Bars

Namespace FocusEditorEx
	''' <summary>
	''' Interaction logic for Window1.xaml
	''' </summary>
	Partial Public Class Window1
		Inherits Window
		Public Sub New()
			InitializeComponent()
		End Sub

		#Region "#2"
		Private Sub btn_ItemClick(ByVal sender As Object, ByVal e As DevExpress.Wpf.Bars.ItemClickEventArgs)
			TryCast(beiEditor.Links(0), BarEditItemLink).Editor.Focus()
		End Sub
		#End Region ' #2
	End Class
End Namespace

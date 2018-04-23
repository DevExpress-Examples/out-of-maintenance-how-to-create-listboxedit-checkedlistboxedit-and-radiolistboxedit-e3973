Imports Microsoft.VisualBasic
Imports System.Windows

Namespace WpfApplication21
	''' <summary>
	''' Interaction logic for MainWindow.xaml
	''' </summary>
	Partial Public Class MainWindow
		Inherits Window
		Public Sub New()
			InitializeComponent()
			InitSources()
		End Sub

		Private Sub InitSources()
			Dim source As New ProductList()
			listBoxEdit1.ItemsSource = source
			checkedListBoxEdit.ItemsSource = source
			radioListBoxEdit.ItemsSource = source
		End Sub
	End Class
End Namespace

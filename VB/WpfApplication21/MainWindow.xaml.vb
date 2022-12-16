Imports System.Windows

Namespace WpfApplication21

    ''' <summary>
    ''' Interaction logic for MainWindow.xaml
    ''' </summary>
    Public Partial Class MainWindow
        Inherits Window

        Public Sub New()
            Me.InitializeComponent()
            InitSources()
        End Sub

        Private Sub InitSources()
            Dim source As ProductList = New ProductList()
            Me.listBoxEdit1.ItemsSource = source
            Me.checkedListBoxEdit.ItemsSource = source
            Me.radioListBoxEdit.ItemsSource = source
        End Sub
    End Class
End Namespace

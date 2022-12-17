Imports System.Collections.ObjectModel
Imports DevExpress.Mvvm

Namespace DXSample

    Public Class GridViewModel
        Inherits ViewModelBase

        Public Property Items As ObservableCollection(Of ItemViewModel)
            Get
                Return GetValue(Of ObservableCollection(Of ItemViewModel))()
            End Get

            Set(ByVal value As ObservableCollection(Of ItemViewModel))
                SetValue(value)
            End Set
        End Property

        Public Sub New()
            Items = New ObservableCollection(Of ItemViewModel)()
            For i As Integer = 0 To 10 - 1
                Items.Add(New ItemViewModel() With {.Subject = $"Mail{i}", .IsRead = i Mod 3 = 0})
            Next
        End Sub
    End Class

    Public Class ItemViewModel
        Inherits ViewModelBase

        Public Property Subject As String
            Get
                Return GetValue(Of String)()
            End Get

            Set(ByVal value As String)
                SetValue(value)
            End Set
        End Property

        Public Property IsRead As Boolean
            Get
                Return GetValue(Of Boolean)()
            End Get

            Set(ByVal value As Boolean)
                SetValue(value)
            End Set
        End Property
    End Class
End Namespace

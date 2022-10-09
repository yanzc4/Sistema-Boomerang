Imports System.Runtime.InteropServices
Imports System.Windows.Forms
Imports System.Drawing
Public Class PowerTextBox
    Inherits TextBox

    'Codigo para el color de los bordes
    '---------------------------------------------------------
    Public Const WM_NCPAINT As Integer = &H85

    <Flags()>
    Private Enum RedrawWindowFlags As UInteger
        Invalidate = &H1
        InternalPaint = &H2
        [Erase] = &H4
        Validate = &H8
        NoInternalPaint = &H10
        NoErase = &H20
        NoChildren = &H40
        AllChildren = &H80
        UpdateNow = &H100
        EraseNow = &H200
        Frame = &H400
        NoFrame = &H800
    End Enum

    <DllImport("User32.dll")>
    Public Shared Function GetWindowDC(ByVal hWnd As IntPtr) As IntPtr
    End Function

    <DllImport("user32.dll")>
    Private Shared Function ReleaseDC(ByVal hWnd As IntPtr, ByVal hDC As IntPtr) As Boolean
    End Function

    <DllImport("user32.dll")>
    Private Shared Function RedrawWindow(hWnd As IntPtr, lprcUpdate As IntPtr, hrgnUpdate As IntPtr, flags As RedrawWindowFlags) As Boolean
    End Function


    Protected Overrides Sub OnResize(e As System.EventArgs)
        MyBase.OnResize(e)
        RedrawWindow(Me.Handle, IntPtr.Zero, IntPtr.Zero, RedrawWindowFlags.Frame Or RedrawWindowFlags.UpdateNow Or RedrawWindowFlags.Invalidate)
    End Sub

    Protected Overrides Sub WndProc(ByRef m As Message)
        MyBase.WndProc(m)

        If m.Msg = WM_NCPAINT Then
            Dim hDC As IntPtr = GetWindowDC(m.HWnd)
            Using g As Graphics = Graphics.FromHdc(hDC)
                If Me.Focused Then
                    g.DrawRectangle(Pens.Transparent, New Rectangle(0, 0, Me.Width - 1, Me.Height - 1))
                Else
                    g.DrawRectangle(Pens.Transparent, New Rectangle(0, 0, Me.Width - 1, Me.Height - 1)) 'Aqui cambiamos el color del borde
                End If
                g.DrawRectangle(SystemPens.Window, New Rectangle(1, 1, Me.Width - 3, Me.Height - 3))
            End Using
            ReleaseDC(m.HWnd, hDC)
        End If

    End Sub

    'Hasta aquí para el color de los bordes
    '-----------------------------------------------------------
    Public Sub TomarFoco(sender As Object, e As EventArgs) Handles Me.GotFocus
        Me.BackColor = Color.Black
    End Sub

    Public Sub SalirFoco(sender As Object, e As EventArgs) Handles Me.LostFocus
        Me.BackColor = Color.Black
    End Sub

    Public Sub PresionarEnter(sender As Object, e As Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            SendKeys.Send("{TAB}")
            e.Handled = True
        End If
    End Sub

    Public Sub New()
        MyBase.New()
        MyBase.BorderStyle = Windows.Forms.BorderStyle.None

        Me.Font = New Font("Roboto", 10)
    End Sub

End Class

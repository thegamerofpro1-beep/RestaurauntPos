Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices
Imports System.Runtime.CompilerServices

Namespace RestaurantPOS14
    <Microsoft.VisualBasic.CompilerServices.StandardModuleAttribute>
    Friend Module modPanelExtension
        <Extension()>
        Public Sub ScrollDown(p As System.Windows.Forms.Panel, pos As Integer)
            Using control As System.Windows.Forms.Control = New System.Windows.Forms.Control With {
        .Parent = p,
        .Height = 1,
        .Top = p.ClientSize.Height + pos
    }
                p.ScrollControlIntoView(control)
            End Using
        End Sub

        <Extension()>
        Public Sub ScrollUp(p As System.Windows.Forms.Panel, pos As Integer)
            Using control As System.Windows.Forms.Control = New System.Windows.Forms.Control With {
        .Parent = p,
        .Height = 1,
        .Top = pos
    }
                p.ScrollControlIntoView(control)
            End Using
        End Sub
    End Module
End Namespace

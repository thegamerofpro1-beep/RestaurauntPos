Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Drawing.Text
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports CButtonLib
Imports Microsoft.VisualBasic.CompilerServices
Imports RestaurantPOS14.My

Namespace RestaurantPOS14

    <Microsoft.VisualBasic.CompilerServices.DesignerGeneratedAttribute>
    Public Class frmOnscreenKeyboard
        Inherits System.Windows.Forms.Form

        Private Shared __ENCList As System.Collections.Generic.List(Of System.WeakReference) = New System.Collections.Generic.List(Of System.WeakReference)()

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("TableLayoutPanel1")>
        Private _TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("P")>
        Private _P As CButtonLib.CButton

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("O")>
        Private _O As CButtonLib.CButton

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("I")>
        Private _I As CButtonLib.CButton

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("U")>
        Private _U As CButtonLib.CButton

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Y")>
        Private _Y As CButtonLib.CButton

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("T")>
        Private _T As CButtonLib.CButton

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("R")>
        Private _R As CButtonLib.CButton

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnE")>
        Private _btnE As CButtonLib.CButton

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("W")>
        Private _W As CButtonLib.CButton

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Q")>
        Private _Q As CButtonLib.CButton

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("TableLayoutPanel2")>
        Private _TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("L")>
        Private _L As CButtonLib.CButton

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("K")>
        Private _K As CButtonLib.CButton

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("J")>
        Private _J As CButtonLib.CButton

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("H")>
        Private _H As CButtonLib.CButton

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("G")>
        Private _G As CButtonLib.CButton

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("F")>
        Private _F As CButtonLib.CButton

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("D")>
        Private _D As CButtonLib.CButton

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("S")>
        Private _S As CButtonLib.CButton

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("A")>
        Private _A As CButtonLib.CButton

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("TableLayoutPanel3")>
        Private _TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("M")>
        Private _M As CButtonLib.CButton

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("N")>
        Private _N As CButtonLib.CButton

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("B")>
        Private _B As CButtonLib.CButton

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("V")>
        Private _V As CButtonLib.CButton

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("C")>
        Private _C As CButtonLib.CButton

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("X")>
        Private _X As CButtonLib.CButton

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Z")>
        Private _Z As CButtonLib.CButton

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("TableLayoutPanel4")>
        Private _TableLayoutPanel4 As System.Windows.Forms.TableLayoutPanel

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnSearch")>
        Private _btnSearch As CButtonLib.CButton

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnBackspace")>
        Private _btnBackspace As CButtonLib.CButton

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnSpaceBar")>
        Private _btnSpaceBar As CButtonLib.CButton

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("TableLayoutPanel5")>
        Private _TableLayoutPanel5 As System.Windows.Forms.TableLayoutPanel

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btn3")>
        Private _btn3 As CButtonLib.CButton

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btn2")>
        Private _btn2 As CButtonLib.CButton

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btn1")>
        Private _btn1 As CButtonLib.CButton

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btn6")>
        Private _btn6 As CButtonLib.CButton

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btn5")>
        Private _btn5 As CButtonLib.CButton

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btn4")>
        Private _btn4 As CButtonLib.CButton

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btn9")>
        Private _btn9 As CButtonLib.CButton

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btn8")>
        Private _btn8 As CButtonLib.CButton

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btn7")>
        Private _btn7 As CButtonLib.CButton

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("TableLayoutPanel6")>
        Private _TableLayoutPanel6 As System.Windows.Forms.TableLayoutPanel

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnX")>
        Private _btnX As CButtonLib.CButton

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btn0")>
        Private _btn0 As CButtonLib.CButton

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnCapsLock")>
        Private _btnCapsLock As System.Windows.Forms.CheckBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("lblSet")>
        Private _lblSet As System.Windows.Forms.Label

        Private sx As String

        Private xx As String

        Private components As System.ComponentModel.IContainer

        Friend Overridable Property TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._TableLayoutPanel1
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TableLayoutPanel)
                Me._TableLayoutPanel1 = value
            End Set
        End Property

        Friend Overridable Property P As CButtonLib.CButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._P
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As CButtonLib.CButton)
                Dim value2 As System.EventHandler = AddressOf Me.Q_Click
                If Me._P IsNot Nothing Then
                    RemoveHandler Me._P.Click, value2
                End If

                Me._P = value
                If Me._P IsNot Nothing Then
                    AddHandler Me._P.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property O As CButtonLib.CButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._O
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As CButtonLib.CButton)
                Dim value2 As System.EventHandler = AddressOf Me.Q_Click
                If Me._O IsNot Nothing Then
                    RemoveHandler Me._O.Click, value2
                End If

                Me._O = value
                If Me._O IsNot Nothing Then
                    AddHandler Me._O.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property I As CButtonLib.CButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._I
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As CButtonLib.CButton)
                Dim value2 As System.EventHandler = AddressOf Me.Q_Click
                If Me._I IsNot Nothing Then
                    RemoveHandler Me._I.Click, value2
                End If

                Me._I = value
                If Me._I IsNot Nothing Then
                    AddHandler Me._I.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property U As CButtonLib.CButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._U
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As CButtonLib.CButton)
                Dim value2 As System.EventHandler = AddressOf Me.Q_Click
                If Me._U IsNot Nothing Then
                    RemoveHandler Me._U.Click, value2
                End If

                Me._U = value
                If Me._U IsNot Nothing Then
                    AddHandler Me._U.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property Y As CButtonLib.CButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Y
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As CButtonLib.CButton)
                Dim value2 As System.EventHandler = AddressOf Me.Q_Click
                If Me._Y IsNot Nothing Then
                    RemoveHandler Me._Y.Click, value2
                End If

                Me._Y = value
                If Me._Y IsNot Nothing Then
                    AddHandler Me._Y.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property T As CButtonLib.CButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._T
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As CButtonLib.CButton)
                Dim value2 As System.EventHandler = AddressOf Me.Q_Click
                If Me._T IsNot Nothing Then
                    RemoveHandler Me._T.Click, value2
                End If

                Me._T = value
                If Me._T IsNot Nothing Then
                    AddHandler Me._T.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property R As CButtonLib.CButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._R
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As CButtonLib.CButton)
                Dim value2 As System.EventHandler = AddressOf Me.Q_Click
                If Me._R IsNot Nothing Then
                    RemoveHandler Me._R.Click, value2
                End If

                Me._R = value
                If Me._R IsNot Nothing Then
                    AddHandler Me._R.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property btnE As CButtonLib.CButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnE
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As CButtonLib.CButton)
                Dim value2 As System.EventHandler = AddressOf Me.Q_Click
                If Me._btnE IsNot Nothing Then
                    RemoveHandler Me._btnE.Click, value2
                End If

                Me._btnE = value
                If Me._btnE IsNot Nothing Then
                    AddHandler Me._btnE.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property W As CButtonLib.CButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._W
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As CButtonLib.CButton)
                Dim value2 As System.EventHandler = AddressOf Me.Q_Click
                If Me._W IsNot Nothing Then
                    RemoveHandler Me._W.Click, value2
                End If

                Me._W = value
                If Me._W IsNot Nothing Then
                    AddHandler Me._W.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property Q As CButtonLib.CButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Q
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As CButtonLib.CButton)
                Dim value2 As System.EventHandler = AddressOf Me.Q_Click
                If Me._Q IsNot Nothing Then
                    RemoveHandler Me._Q.Click, value2
                End If

                Me._Q = value
                If Me._Q IsNot Nothing Then
                    AddHandler Me._Q.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._TableLayoutPanel2
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TableLayoutPanel)
                Me._TableLayoutPanel2 = value
            End Set
        End Property

        Friend Overridable Property L As CButtonLib.CButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._L
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As CButtonLib.CButton)
                Dim value2 As System.EventHandler = AddressOf Me.Q_Click
                If Me._L IsNot Nothing Then
                    RemoveHandler Me._L.Click, value2
                End If

                Me._L = value
                If Me._L IsNot Nothing Then
                    AddHandler Me._L.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property K As CButtonLib.CButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._K
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As CButtonLib.CButton)
                Dim value2 As System.EventHandler = AddressOf Me.Q_Click
                If Me._K IsNot Nothing Then
                    RemoveHandler Me._K.Click, value2
                End If

                Me._K = value
                If Me._K IsNot Nothing Then
                    AddHandler Me._K.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property J As CButtonLib.CButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._J
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As CButtonLib.CButton)
                Dim value2 As System.EventHandler = AddressOf Me.Q_Click
                If Me._J IsNot Nothing Then
                    RemoveHandler Me._J.Click, value2
                End If

                Me._J = value
                If Me._J IsNot Nothing Then
                    AddHandler Me._J.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property H As CButtonLib.CButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._H
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As CButtonLib.CButton)
                Dim value2 As System.EventHandler = AddressOf Me.Q_Click
                If Me._H IsNot Nothing Then
                    RemoveHandler Me._H.Click, value2
                End If

                Me._H = value
                If Me._H IsNot Nothing Then
                    AddHandler Me._H.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property G As CButtonLib.CButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._G
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As CButtonLib.CButton)
                Dim value2 As System.EventHandler = AddressOf Me.Q_Click
                If Me._G IsNot Nothing Then
                    RemoveHandler Me._G.Click, value2
                End If

                Me._G = value
                If Me._G IsNot Nothing Then
                    AddHandler Me._G.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property F As CButtonLib.CButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._F
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As CButtonLib.CButton)
                Dim value2 As System.EventHandler = AddressOf Me.Q_Click
                If Me._F IsNot Nothing Then
                    RemoveHandler Me._F.Click, value2
                End If

                Me._F = value
                If Me._F IsNot Nothing Then
                    AddHandler Me._F.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property D As CButtonLib.CButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._D
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As CButtonLib.CButton)
                Dim value2 As System.EventHandler = AddressOf Me.Q_Click
                If Me._D IsNot Nothing Then
                    RemoveHandler Me._D.Click, value2
                End If

                Me._D = value
                If Me._D IsNot Nothing Then
                    AddHandler Me._D.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property S As CButtonLib.CButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._S
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As CButtonLib.CButton)
                Dim value2 As System.EventHandler = AddressOf Me.Q_Click
                If Me._S IsNot Nothing Then
                    RemoveHandler Me._S.Click, value2
                End If

                Me._S = value
                If Me._S IsNot Nothing Then
                    AddHandler Me._S.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property A As CButtonLib.CButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._A
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As CButtonLib.CButton)
                Dim value2 As System.EventHandler = AddressOf Me.Q_Click
                If Me._A IsNot Nothing Then
                    RemoveHandler Me._A.Click, value2
                End If

                Me._A = value
                If Me._A IsNot Nothing Then
                    AddHandler Me._A.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._TableLayoutPanel3
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TableLayoutPanel)
                Me._TableLayoutPanel3 = value
            End Set
        End Property

        Friend Overridable Property M As CButtonLib.CButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._M
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As CButtonLib.CButton)
                Dim value2 As System.EventHandler = AddressOf Me.Q_Click
                If Me._M IsNot Nothing Then
                    RemoveHandler Me._M.Click, value2
                End If

                Me._M = value
                If Me._M IsNot Nothing Then
                    AddHandler Me._M.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property N As CButtonLib.CButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._N
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As CButtonLib.CButton)
                Dim value2 As System.EventHandler = AddressOf Me.Q_Click
                If Me._N IsNot Nothing Then
                    RemoveHandler Me._N.Click, value2
                End If

                Me._N = value
                If Me._N IsNot Nothing Then
                    AddHandler Me._N.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property B As CButtonLib.CButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._B
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As CButtonLib.CButton)
                Dim value2 As System.EventHandler = AddressOf Me.Q_Click
                If Me._B IsNot Nothing Then
                    RemoveHandler Me._B.Click, value2
                End If

                Me._B = value
                If Me._B IsNot Nothing Then
                    AddHandler Me._B.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property V As CButtonLib.CButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._V
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As CButtonLib.CButton)
                Dim value2 As System.EventHandler = AddressOf Me.Q_Click
                If Me._V IsNot Nothing Then
                    RemoveHandler Me._V.Click, value2
                End If

                Me._V = value
                If Me._V IsNot Nothing Then
                    AddHandler Me._V.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property C As CButtonLib.CButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._C
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As CButtonLib.CButton)
                Dim value2 As System.EventHandler = AddressOf Me.Q_Click
                If Me._C IsNot Nothing Then
                    RemoveHandler Me._C.Click, value2
                End If

                Me._C = value
                If Me._C IsNot Nothing Then
                    AddHandler Me._C.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property X As CButtonLib.CButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._X
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As CButtonLib.CButton)
                Dim value2 As System.EventHandler = AddressOf Me.Q_Click
                If Me._X IsNot Nothing Then
                    RemoveHandler Me._X.Click, value2
                End If

                Me._X = value
                If Me._X IsNot Nothing Then
                    AddHandler Me._X.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property Z As CButtonLib.CButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Z
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As CButtonLib.CButton)
                Dim value2 As System.EventHandler = AddressOf Me.Q_Click
                If Me._Z IsNot Nothing Then
                    RemoveHandler Me._Z.Click, value2
                End If

                Me._Z = value
                If Me._Z IsNot Nothing Then
                    AddHandler Me._Z.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property TableLayoutPanel4 As System.Windows.Forms.TableLayoutPanel
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._TableLayoutPanel4
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TableLayoutPanel)
                Me._TableLayoutPanel4 = value
            End Set
        End Property

        Friend Overridable Property btnSearch As CButtonLib.CButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnSearch
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As CButtonLib.CButton)
                Dim value2 As System.EventHandler = AddressOf Me.btnEnter_Click
                If Me._btnSearch IsNot Nothing Then
                    RemoveHandler Me._btnSearch.Click, value2
                End If

                Me._btnSearch = value
                If Me._btnSearch IsNot Nothing Then
                    AddHandler Me._btnSearch.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property btnBackspace As CButtonLib.CButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnBackspace
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As CButtonLib.CButton)
                Dim value2 As System.EventHandler = AddressOf Me.btnBackspace_Click
                If Me._btnBackspace IsNot Nothing Then
                    RemoveHandler Me._btnBackspace.Click, value2
                End If

                Me._btnBackspace = value
                If Me._btnBackspace IsNot Nothing Then
                    AddHandler Me._btnBackspace.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property btnSpaceBar As CButtonLib.CButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnSpaceBar
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As CButtonLib.CButton)
                Dim value2 As System.EventHandler = AddressOf Me.btnSpaceBar_Click
                If Me._btnSpaceBar IsNot Nothing Then
                    RemoveHandler Me._btnSpaceBar.Click, value2
                End If

                Me._btnSpaceBar = value
                If Me._btnSpaceBar IsNot Nothing Then
                    AddHandler Me._btnSpaceBar.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property TableLayoutPanel5 As System.Windows.Forms.TableLayoutPanel
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._TableLayoutPanel5
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TableLayoutPanel)
                Me._TableLayoutPanel5 = value
            End Set
        End Property

        Friend Overridable Property btn3 As CButtonLib.CButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btn3
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As CButtonLib.CButton)
                Dim value2 As System.EventHandler = AddressOf Me.Q_Click
                If Me._btn3 IsNot Nothing Then
                    RemoveHandler Me._btn3.Click, value2
                End If

                Me._btn3 = value
                If Me._btn3 IsNot Nothing Then
                    AddHandler Me._btn3.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property btn2 As CButtonLib.CButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btn2
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As CButtonLib.CButton)
                Dim value2 As System.EventHandler = AddressOf Me.Q_Click
                If Me._btn2 IsNot Nothing Then
                    RemoveHandler Me._btn2.Click, value2
                End If

                Me._btn2 = value
                If Me._btn2 IsNot Nothing Then
                    AddHandler Me._btn2.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property btn1 As CButtonLib.CButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btn1
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As CButtonLib.CButton)
                Dim value2 As System.EventHandler = AddressOf Me.Q_Click
                If Me._btn1 IsNot Nothing Then
                    RemoveHandler Me._btn1.Click, value2
                End If

                Me._btn1 = value
                If Me._btn1 IsNot Nothing Then
                    AddHandler Me._btn1.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property btn6 As CButtonLib.CButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btn6
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As CButtonLib.CButton)
                Dim value2 As System.EventHandler = AddressOf Me.Q_Click
                If Me._btn6 IsNot Nothing Then
                    RemoveHandler Me._btn6.Click, value2
                End If

                Me._btn6 = value
                If Me._btn6 IsNot Nothing Then
                    AddHandler Me._btn6.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property btn5 As CButtonLib.CButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btn5
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As CButtonLib.CButton)
                Dim value2 As System.EventHandler = AddressOf Me.Q_Click
                If Me._btn5 IsNot Nothing Then
                    RemoveHandler Me._btn5.Click, value2
                End If

                Me._btn5 = value
                If Me._btn5 IsNot Nothing Then
                    AddHandler Me._btn5.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property btn4 As CButtonLib.CButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btn4
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As CButtonLib.CButton)
                Dim value2 As System.EventHandler = AddressOf Me.Q_Click
                If Me._btn4 IsNot Nothing Then
                    RemoveHandler Me._btn4.Click, value2
                End If

                Me._btn4 = value
                If Me._btn4 IsNot Nothing Then
                    AddHandler Me._btn4.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property btn9 As CButtonLib.CButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btn9
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As CButtonLib.CButton)
                Dim value2 As System.EventHandler = AddressOf Me.Q_Click
                If Me._btn9 IsNot Nothing Then
                    RemoveHandler Me._btn9.Click, value2
                End If

                Me._btn9 = value
                If Me._btn9 IsNot Nothing Then
                    AddHandler Me._btn9.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property btn8 As CButtonLib.CButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btn8
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As CButtonLib.CButton)
                Dim value2 As System.EventHandler = AddressOf Me.Q_Click
                If Me._btn8 IsNot Nothing Then
                    RemoveHandler Me._btn8.Click, value2
                End If

                Me._btn8 = value
                If Me._btn8 IsNot Nothing Then
                    AddHandler Me._btn8.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property btn7 As CButtonLib.CButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btn7
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As CButtonLib.CButton)
                Dim value2 As System.EventHandler = AddressOf Me.Q_Click
                If Me._btn7 IsNot Nothing Then
                    RemoveHandler Me._btn7.Click, value2
                End If

                Me._btn7 = value
                If Me._btn7 IsNot Nothing Then
                    AddHandler Me._btn7.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property TableLayoutPanel6 As System.Windows.Forms.TableLayoutPanel
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._TableLayoutPanel6
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TableLayoutPanel)
                Me._TableLayoutPanel6 = value
            End Set
        End Property

        Friend Overridable Property btnX As CButtonLib.CButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnX
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As CButtonLib.CButton)
                Dim value2 As System.EventHandler = AddressOf Me.btnX_Click
                If Me._btnX IsNot Nothing Then
                    RemoveHandler Me._btnX.Click, value2
                End If

                Me._btnX = value
                If Me._btnX IsNot Nothing Then
                    AddHandler Me._btnX.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property btn0 As CButtonLib.CButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btn0
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As CButtonLib.CButton)
                Dim value2 As System.EventHandler = AddressOf Me.Q_Click
                If Me._btn0 IsNot Nothing Then
                    RemoveHandler Me._btn0.Click, value2
                End If

                Me._btn0 = value
                If Me._btn0 IsNot Nothing Then
                    AddHandler Me._btn0.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property btnCapsLock As System.Windows.Forms.CheckBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnCapsLock
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.CheckBox)
                Dim value2 As System.EventHandler = AddressOf Me.btnCapsLock_CheckedChanged
                If Me._btnCapsLock IsNot Nothing Then
                    RemoveHandler Me._btnCapsLock.CheckedChanged, value2
                End If

                Me._btnCapsLock = value
                If Me._btnCapsLock IsNot Nothing Then
                    AddHandler Me._btnCapsLock.CheckedChanged, value2
                End If
            End Set
        End Property

        Friend Overridable Property lblSet As System.Windows.Forms.Label
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._lblSet
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Label)
                Me._lblSet = value
            End Set
        End Property

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Public Sub New()
            AddHandler MyBase.Load, AddressOf Me.frmOnscreenKeyboard_Load
            Call RestaurantPOS14.frmOnscreenKeyboard.__ENCAddToList(Me)
            Me.InitializeComponent()
        End Sub

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Private Shared Sub __ENCAddToList(value As Object)
            SyncLock RestaurantPOS14.frmOnscreenKeyboard.__ENCList
                If RestaurantPOS14.frmOnscreenKeyboard.__ENCList.Count = RestaurantPOS14.frmOnscreenKeyboard.__ENCList.Capacity Then
                    Dim num As Integer = 0
                    Dim num2 As Integer = RestaurantPOS14.frmOnscreenKeyboard.__ENCList.Count - 1
                    Dim num3 As Integer = 0
                    While True
                        Dim num4 As Integer = num3
                        Dim num5 As Integer = num2
                        If num4 > num5 Then
                            Exit While
                        End If

                        If RestaurantPOS14.frmOnscreenKeyboard.__ENCList(CInt((num3))).IsAlive Then
                            If num3 <> num Then
                                RestaurantPOS14.frmOnscreenKeyboard.__ENCList(num) = RestaurantPOS14.frmOnscreenKeyboard.__ENCList(num3)
                            End If

                            num += 1
                        End If

                        num3 += 1
                    End While

                    Call RestaurantPOS14.frmOnscreenKeyboard.__ENCList.RemoveRange(num, RestaurantPOS14.frmOnscreenKeyboard.__ENCList.Count - num)
                    RestaurantPOS14.frmOnscreenKeyboard.__ENCList.Capacity = RestaurantPOS14.frmOnscreenKeyboard.__ENCList.Count
                End If

                Call RestaurantPOS14.frmOnscreenKeyboard.__ENCList.Add(New System.WeakReference(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(value)))
            End SyncLock
        End Sub

        Private Sub btnX_Click(sender As Object, e As System.EventArgs)
            MyBase.Close()
        End Sub

        Private Sub frmOnscreenKeyboard_Load(sender As Object, e As System.EventArgs)
            Me.btnCapsLock.Checked = True
            Dim x As Integer = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Width - MyBase.Width
            Dim y As Integer = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Height - MyBase.Height
            Dim location As System.Drawing.Point = New System.Drawing.Point(x, y)
            MyBase.Location = location
        End Sub

        Private Sub btnCapsLock_CheckedChanged(sender As Object, e As System.EventArgs)
            If Me.btnCapsLock.Checked Then
                Me.btnCapsLock.BackColor = System.Drawing.Color.DarkGreen
                Me.Q.Text = "Q"
                Me.W.Text = "W"
                Me.btnE.Text = "E"
                Me.R.Text = "R"
                Me.T.Text = "T"
                Me.Y.Text = "Y"
                Me.U.Text = "U"
                Me.I.Text = "I"
                Me.O.Text = "O"
                Me.P.Text = "P"
                Me.A.Text = "A"
                Me.S.Text = "S"
                Me.D.Text = "D"
                Me.F.Text = "F"
                Me.G.Text = "G"
                Me.H.Text = "H"
                Me.J.Text = "J"
                Me.K.Text = "K"
                Me.L.Text = "L"
                Me.Z.Text = "Z"
                Me.X.Text = "X"
                Me.C.Text = "C"
                Me.V.Text = "V"
                Me.B.Text = "B"
                Me.N.Text = "N"
                Me.M.Text = "M"
            Else
                Me.btnCapsLock.BackColor = System.Drawing.Color.MediumVioletRed
                Me.Q.Text = "q"
                Me.W.Text = "w"
                Me.btnE.Text = "e"
                Me.R.Text = "r"
                Me.T.Text = "t"
                Me.Y.Text = "y"
                Me.U.Text = "u"
                Me.I.Text = "i"
                Me.O.Text = "o"
                Me.P.Text = "p"
                Me.A.Text = "a"
                Me.S.Text = "s"
                Me.D.Text = "d"
                Me.F.Text = "f"
                Me.G.Text = "g"
                Me.H.Text = "h"
                Me.J.Text = "j"
                Me.K.Text = "k"
                Me.L.Text = "l"
                Me.Z.Text = "z"
                Me.X.Text = "x"
                Me.C.Text = "c"
                Me.V.Text = "v"
                Me.B.Text = "b"
                Me.N.Text = "n"
                Me.M.Text = "m"
            End If
        End Sub

        Private Sub btnSpaceBar_Click(sender As Object, e As System.EventArgs)
            If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.lblSet.Text, "DI", TextCompare:=False) = 0 Then
                RestaurantPOS14.My.MyProject.Forms.frmPOS.txtItemsKOT.Text += " "
            End If

            If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.lblSet.Text, "TA", TextCompare:=False) = 0 Then
                RestaurantPOS14.My.MyProject.Forms.frmPOS.txtItemsTA.Text += " "
            End If

            If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.lblSet.Text, "HD", TextCompare:=False) = 0 Then
                RestaurantPOS14.My.MyProject.Forms.frmPOS.txtItemsHD.Text += " "
            End If

            If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.lblSet.Text, "EB", TextCompare:=False) = 0 Then
                RestaurantPOS14.My.MyProject.Forms.frmPOS.txtItemsEB.Text += " "
            End If

            If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.lblSet.Text, "HDC", TextCompare:=False) = 0 Then
                RestaurantPOS14.My.MyProject.Forms.frmPOS.txtCustomerName.Text += " "
            End If

            If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.lblSet.Text, "HDA", TextCompare:=False) = 0 Then
                RestaurantPOS14.My.MyProject.Forms.frmPOS.txtAddress.Text += " "
            End If

            If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.lblSet.Text, "HDCN", TextCompare:=False) = 0 Then
                RestaurantPOS14.My.MyProject.Forms.frmPOS.txtContactNo.Text += " "
            End If

            If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.lblSet.Text, "EBCN", TextCompare:=False) = 0 Then
                RestaurantPOS14.My.MyProject.Forms.frmPOS.txtEBContactNo.Text += " "
            End If

            If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.lblSet.Text, "TACN", TextCompare:=False) = 0 Then
                RestaurantPOS14.My.MyProject.Forms.frmPOS.txtTAContactNo.Text += " "
            End If

            If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.lblSet.Text, "TAC", TextCompare:=False) = 0 Then
                RestaurantPOS14.My.MyProject.Forms.frmPOS.txtTACustomerName.Text += " "
            End If

            If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.lblSet.Text, "EBC", TextCompare:=False) = 0 Then
                RestaurantPOS14.My.MyProject.Forms.frmPOS.txtEBCustomerName.Text += " "
            End If

            If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.lblSet.Text, "DIC", TextCompare:=False) = 0 Then
                RestaurantPOS14.My.MyProject.Forms.frmPOS.txtDICustomerName.Text += " "
            End If

            If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.lblSet.Text, "DICN", TextCompare:=False) = 0 Then
                RestaurantPOS14.My.MyProject.Forms.frmPOS.txtDIContactNo.Text += " "
            End If

            If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.lblSet.Text, "DIE", TextCompare:=False) = 0 Then
                RestaurantPOS14.My.MyProject.Forms.frmPOS.txtEmailID.Text += " "
            End If

            If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.lblSet.Text, "CRC", TextCompare:=False) = 0 Then
                RestaurantPOS14.My.MyProject.Forms.frmCustomersRecord.txtCustomerName.Text += " "
            End If

            If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.lblSet.Text, "CRCN", TextCompare:=False) = 0 Then
                RestaurantPOS14.My.MyProject.Forms.frmCustomersRecord.txtContactNo.Text += " "
            End If

            If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.lblSet.Text, "CRA", TextCompare:=False) = 0 Then
                RestaurantPOS14.My.MyProject.Forms.frmCustomersRecord.txtAddress.Text += " "
            End If
        End Sub

        Private Sub btnEnter_Click(sender As Object, e As System.EventArgs)
            If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.lblSet.Text, "DI", TextCompare:=False) = 0 Then
                Call RestaurantPOS14.My.MyProject.Forms.frmPOS.btnSearch_Click(Me, System.EventArgs.Empty)
                RestaurantPOS14.My.MyProject.Forms.frmPOS.txtItemsKOT.Text = ""
                MyBase.Close()
            End If

            If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.lblSet.Text, "TA", TextCompare:=False) = 0 Then
                Call RestaurantPOS14.My.MyProject.Forms.frmPOS.Button1_Click_1(Me, System.EventArgs.Empty)
                RestaurantPOS14.My.MyProject.Forms.frmPOS.txtItemsTA.Text = ""
                MyBase.Close()
            End If

            If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.lblSet.Text, "HD", TextCompare:=False) = 0 Then
                Call RestaurantPOS14.My.MyProject.Forms.frmPOS.Button2_Click_1(Me, System.EventArgs.Empty)
                RestaurantPOS14.My.MyProject.Forms.frmPOS.txtItemsHD.Text = ""
                MyBase.Close()
            End If

            If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.lblSet.Text, "EB", TextCompare:=False) = 0 Then
                Call RestaurantPOS14.My.MyProject.Forms.frmPOS.Button3_Click(Me, System.EventArgs.Empty)
                RestaurantPOS14.My.MyProject.Forms.frmPOS.txtItemsEB.Text = ""
                MyBase.Close()
            End If

            If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.lblSet.Text, "CRC", TextCompare:=False) = 0 Then
                Call RestaurantPOS14.My.MyProject.Forms.frmCustomersRecord.Button1.PerformClick()
                MyBase.Close()
            End If

            If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.lblSet.Text, "CRCN", TextCompare:=False) = 0 Then
                Call RestaurantPOS14.My.MyProject.Forms.frmCustomersRecord.Button2.PerformClick()
                MyBase.Close()
            End If

            If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.lblSet.Text, "CRA", TextCompare:=False) = 0 Then
                Call RestaurantPOS14.My.MyProject.Forms.frmCustomersRecord.Button3.PerformClick()
                MyBase.Close()
            End If

            If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.lblSet.Text, "HDC", TextCompare:=False) = 0 Then
                MyBase.Close()
            End If

            If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.lblSet.Text, "HDA", TextCompare:=False) = 0 Then
                MyBase.Close()
            End If

            If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.lblSet.Text, "HDCN", TextCompare:=False) = 0 Then
                MyBase.Close()
            End If

            If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.lblSet.Text, "EBCN", TextCompare:=False) = 0 Then
                MyBase.Close()
            End If

            If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.lblSet.Text, "TACN", TextCompare:=False) = 0 Then
                MyBase.Close()
            End If

            If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.lblSet.Text, "TAC", TextCompare:=False) = 0 Then
                MyBase.Close()
            End If

            If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.lblSet.Text, "EBC", TextCompare:=False) = 0 Then
                MyBase.Close()
            End If

            If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.lblSet.Text, "DIC", TextCompare:=False) = 0 Then
                MyBase.Close()
            End If

            If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.lblSet.Text, "DICN", TextCompare:=False) = 0 Then
                MyBase.Close()
            End If

            If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.lblSet.Text, "DIE", TextCompare:=False) = 0 Then
                MyBase.Close()
            End If
        End Sub

        Private Sub Q_Click(sender As Object, e As System.EventArgs)
            If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.lblSet.Text, "DI", TextCompare:=False) = 0 Then
                Dim txtItemsKOT As System.Windows.Forms.TextBox = RestaurantPOS14.My.MyProject.Forms.frmPOS.txtItemsKOT
                txtItemsKOT.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(txtItemsKOT.Text, Microsoft.VisualBasic.CompilerServices.NewLateBinding.LateGet(sender, Nothing, "Text", New Object(-1) {}, Nothing, Nothing, Nothing)))
            End If

            If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.lblSet.Text, "TA", TextCompare:=False) = 0 Then
                Dim txtItemsTA As System.Windows.Forms.TextBox = RestaurantPOS14.My.MyProject.Forms.frmPOS.txtItemsTA
                txtItemsTA.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(txtItemsTA.Text, Microsoft.VisualBasic.CompilerServices.NewLateBinding.LateGet(sender, Nothing, "Text", New Object(-1) {}, Nothing, Nothing, Nothing)))
            End If

            If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.lblSet.Text, "HD", TextCompare:=False) = 0 Then
                Dim txtItemsHD As System.Windows.Forms.TextBox = RestaurantPOS14.My.MyProject.Forms.frmPOS.txtItemsHD
                txtItemsHD.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(txtItemsHD.Text, Microsoft.VisualBasic.CompilerServices.NewLateBinding.LateGet(sender, Nothing, "Text", New Object(-1) {}, Nothing, Nothing, Nothing)))
            End If

            If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.lblSet.Text, "EB", TextCompare:=False) = 0 Then
                Dim txtItemsEB As System.Windows.Forms.TextBox = RestaurantPOS14.My.MyProject.Forms.frmPOS.txtItemsEB
                txtItemsEB.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(txtItemsEB.Text, Microsoft.VisualBasic.CompilerServices.NewLateBinding.LateGet(sender, Nothing, "Text", New Object(-1) {}, Nothing, Nothing, Nothing)))
            End If

            If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.lblSet.Text, "HDC", TextCompare:=False) = 0 Then
                Dim txtCustomerName As System.Windows.Forms.TextBox = RestaurantPOS14.My.MyProject.Forms.frmPOS.txtCustomerName
                txtCustomerName.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(txtCustomerName.Text, Microsoft.VisualBasic.CompilerServices.NewLateBinding.LateGet(sender, Nothing, "Text", New Object(-1) {}, Nothing, Nothing, Nothing)))
            End If

            If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.lblSet.Text, "HDA", TextCompare:=False) = 0 Then
                Dim txtAddress As System.Windows.Forms.TextBox = RestaurantPOS14.My.MyProject.Forms.frmPOS.txtAddress
                txtAddress.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(txtAddress.Text, Microsoft.VisualBasic.CompilerServices.NewLateBinding.LateGet(sender, Nothing, "Text", New Object(-1) {}, Nothing, Nothing, Nothing)))
            End If

            If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.lblSet.Text, "HDCN", TextCompare:=False) = 0 Then
                Dim txtContactNo As System.Windows.Forms.TextBox = RestaurantPOS14.My.MyProject.Forms.frmPOS.txtContactNo
                txtContactNo.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(txtContactNo.Text, Microsoft.VisualBasic.CompilerServices.NewLateBinding.LateGet(sender, Nothing, "Text", New Object(-1) {}, Nothing, Nothing, Nothing)))
            End If

            If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.lblSet.Text, "EBCN", TextCompare:=False) = 0 Then
                Dim txtEBContactNo As System.Windows.Forms.TextBox = RestaurantPOS14.My.MyProject.Forms.frmPOS.txtEBContactNo
                txtEBContactNo.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(txtEBContactNo.Text, Microsoft.VisualBasic.CompilerServices.NewLateBinding.LateGet(sender, Nothing, "Text", New Object(-1) {}, Nothing, Nothing, Nothing)))
            End If

            If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.lblSet.Text, "TACN", TextCompare:=False) = 0 Then
                Dim txtTAContactNo As System.Windows.Forms.TextBox = RestaurantPOS14.My.MyProject.Forms.frmPOS.txtTAContactNo
                txtTAContactNo.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(txtTAContactNo.Text, Microsoft.VisualBasic.CompilerServices.NewLateBinding.LateGet(sender, Nothing, "Text", New Object(-1) {}, Nothing, Nothing, Nothing)))
            End If

            If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.lblSet.Text, "TAC", TextCompare:=False) = 0 Then
                Dim txtTACustomerName As System.Windows.Forms.TextBox = RestaurantPOS14.My.MyProject.Forms.frmPOS.txtTACustomerName
                txtTACustomerName.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(txtTACustomerName.Text, Microsoft.VisualBasic.CompilerServices.NewLateBinding.LateGet(sender, Nothing, "Text", New Object(-1) {}, Nothing, Nothing, Nothing)))
            End If

            If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.lblSet.Text, "EBC", TextCompare:=False) = 0 Then
                Dim txtEBCustomerName As System.Windows.Forms.TextBox = RestaurantPOS14.My.MyProject.Forms.frmPOS.txtEBCustomerName
                txtEBCustomerName.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(txtEBCustomerName.Text, Microsoft.VisualBasic.CompilerServices.NewLateBinding.LateGet(sender, Nothing, "Text", New Object(-1) {}, Nothing, Nothing, Nothing)))
            End If

            If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.lblSet.Text, "DIC", TextCompare:=False) = 0 Then
                Dim txtDICustomerName As System.Windows.Forms.TextBox = RestaurantPOS14.My.MyProject.Forms.frmPOS.txtDICustomerName
                txtDICustomerName.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(txtDICustomerName.Text, Microsoft.VisualBasic.CompilerServices.NewLateBinding.LateGet(sender, Nothing, "Text", New Object(-1) {}, Nothing, Nothing, Nothing)))
            End If

            If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.lblSet.Text, "DICN", TextCompare:=False) = 0 Then
                Dim txtDIContactNo As System.Windows.Forms.TextBox = RestaurantPOS14.My.MyProject.Forms.frmPOS.txtDIContactNo
                txtDIContactNo.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(txtDIContactNo.Text, Microsoft.VisualBasic.CompilerServices.NewLateBinding.LateGet(sender, Nothing, "Text", New Object(-1) {}, Nothing, Nothing, Nothing)))
            End If

            If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.lblSet.Text, "DIE", TextCompare:=False) = 0 Then
                Dim txtEmailID As System.Windows.Forms.TextBox = RestaurantPOS14.My.MyProject.Forms.frmPOS.txtEmailID
                txtEmailID.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(txtEmailID.Text, Microsoft.VisualBasic.CompilerServices.NewLateBinding.LateGet(sender, Nothing, "Text", New Object(-1) {}, Nothing, Nothing, Nothing)))
            End If

            If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.lblSet.Text, "CRC", TextCompare:=False) = 0 Then
                Dim txtCustomerName2 As System.Windows.Forms.TextBox = RestaurantPOS14.My.MyProject.Forms.frmCustomersRecord.txtCustomerName
                txtCustomerName2.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(txtCustomerName2.Text, Microsoft.VisualBasic.CompilerServices.NewLateBinding.LateGet(sender, Nothing, "Text", New Object(-1) {}, Nothing, Nothing, Nothing)))
            End If

            If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.lblSet.Text, "CRCN", TextCompare:=False) = 0 Then
                Dim txtContactNo2 As System.Windows.Forms.TextBox = RestaurantPOS14.My.MyProject.Forms.frmCustomersRecord.txtContactNo
                txtContactNo2.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(txtContactNo2.Text, Microsoft.VisualBasic.CompilerServices.NewLateBinding.LateGet(sender, Nothing, "Text", New Object(-1) {}, Nothing, Nothing, Nothing)))
            End If

            If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.lblSet.Text, "CRA", TextCompare:=False) = 0 Then
                Dim txtAddress2 As System.Windows.Forms.TextBox = RestaurantPOS14.My.MyProject.Forms.frmCustomersRecord.txtAddress
                txtAddress2.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(txtAddress2.Text, Microsoft.VisualBasic.CompilerServices.NewLateBinding.LateGet(sender, Nothing, "Text", New Object(-1) {}, Nothing, Nothing, Nothing)))
            End If
        End Sub

        Private Sub btnBackspace_Click(sender As Object, e As System.EventArgs)
            If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.lblSet.Text, "DI", TextCompare:=False) = 0 Then
                Me.sx = RestaurantPOS14.My.MyProject.Forms.frmPOS.txtItemsKOT.Text
                Dim num As Integer = Me.sx.Length - 2
                Dim num2 As Integer = 0
                While True
                    Dim num3 As Integer = num2
                    Dim num4 As Integer = num
                    If num3 > num4 Then
                        Exit While
                    End If

                    Me.xx += Microsoft.VisualBasic.CompilerServices.Conversions.ToString(Me.sx(num2))
                    num2 += 1
                End While

                RestaurantPOS14.My.MyProject.Forms.frmPOS.txtItemsKOT.Text = Me.xx
                Me.xx = ""
            End If

            If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.lblSet.Text, "TA", TextCompare:=False) = 0 Then
                Me.sx = RestaurantPOS14.My.MyProject.Forms.frmPOS.txtItemsTA.Text
                Dim num5 As Integer = Me.sx.Length - 2
                Dim num6 As Integer = 0
                While True
                    Dim num7 As Integer = num6
                    Dim num8 As Integer = num5
                    If num7 > num8 Then
                        Exit While
                    End If

                    Me.xx += Microsoft.VisualBasic.CompilerServices.Conversions.ToString(Me.sx(num6))
                    num6 += 1
                End While

                RestaurantPOS14.My.MyProject.Forms.frmPOS.txtItemsTA.Text = Me.xx
                Me.xx = ""
            End If

            If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.lblSet.Text, "HD", TextCompare:=False) = 0 Then
                Me.sx = RestaurantPOS14.My.MyProject.Forms.frmPOS.txtItemsHD.Text
                Dim num9 As Integer = Me.sx.Length - 2
                Dim num10 As Integer = 0
                While True
                    Dim num11 As Integer = num10
                    Dim num12 As Integer = num9
                    If num11 > num12 Then
                        Exit While
                    End If

                    Me.xx += Microsoft.VisualBasic.CompilerServices.Conversions.ToString(Me.sx(num10))
                    num10 += 1
                End While

                RestaurantPOS14.My.MyProject.Forms.frmPOS.txtItemsHD.Text = Me.xx
                Me.xx = ""
            End If

            If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.lblSet.Text, "EB", TextCompare:=False) = 0 Then
                Me.sx = RestaurantPOS14.My.MyProject.Forms.frmPOS.txtItemsEB.Text
                Dim num13 As Integer = Me.sx.Length - 2
                Dim num14 As Integer = 0
                While True
                    Dim num15 As Integer = num14
                    Dim num16 As Integer = num13
                    If num15 > num16 Then
                        Exit While
                    End If

                    Me.xx += Microsoft.VisualBasic.CompilerServices.Conversions.ToString(Me.sx(num14))
                    num14 += 1
                End While

                RestaurantPOS14.My.MyProject.Forms.frmPOS.txtItemsEB.Text = Me.xx
                Me.xx = ""
            End If

            If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.lblSet.Text, "HDC", TextCompare:=False) = 0 Then
                Me.sx = RestaurantPOS14.My.MyProject.Forms.frmPOS.txtCustomerName.Text
                Dim num17 As Integer = Me.sx.Length - 2
                Dim num18 As Integer = 0
                While True
                    Dim num19 As Integer = num18
                    Dim num20 As Integer = num17
                    If num19 > num20 Then
                        Exit While
                    End If

                    Me.xx += Microsoft.VisualBasic.CompilerServices.Conversions.ToString(Me.sx(num18))
                    num18 += 1
                End While

                RestaurantPOS14.My.MyProject.Forms.frmPOS.txtCustomerName.Text = Me.xx
                Me.xx = ""
            End If

            If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.lblSet.Text, "HDA", TextCompare:=False) = 0 Then
                Me.sx = RestaurantPOS14.My.MyProject.Forms.frmPOS.txtAddress.Text
                Dim num21 As Integer = Me.sx.Length - 2
                Dim num22 As Integer = 0
                While True
                    Dim num23 As Integer = num22
                    Dim num24 As Integer = num21
                    If num23 > num24 Then
                        Exit While
                    End If

                    Me.xx += Microsoft.VisualBasic.CompilerServices.Conversions.ToString(Me.sx(num22))
                    num22 += 1
                End While

                RestaurantPOS14.My.MyProject.Forms.frmPOS.txtAddress.Text = Me.xx
                Me.xx = ""
            End If

            If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.lblSet.Text, "HDCN", TextCompare:=False) = 0 Then
                Me.sx = RestaurantPOS14.My.MyProject.Forms.frmPOS.txtContactNo.Text
                Dim num25 As Integer = Me.sx.Length - 2
                Dim num26 As Integer = 0
                While True
                    Dim num27 As Integer = num26
                    Dim num28 As Integer = num25
                    If num27 > num28 Then
                        Exit While
                    End If

                    Me.xx += Microsoft.VisualBasic.CompilerServices.Conversions.ToString(Me.sx(num26))
                    num26 += 1
                End While

                RestaurantPOS14.My.MyProject.Forms.frmPOS.txtContactNo.Text = Me.xx
                Me.xx = ""
            End If

            If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.lblSet.Text, "EBCN", TextCompare:=False) = 0 Then
                Me.sx = RestaurantPOS14.My.MyProject.Forms.frmPOS.txtEBContactNo.Text
                Dim num29 As Integer = Me.sx.Length - 2
                Dim num30 As Integer = 0
                While True
                    Dim num31 As Integer = num30
                    Dim num32 As Integer = num29
                    If num31 > num32 Then
                        Exit While
                    End If

                    Me.xx += Microsoft.VisualBasic.CompilerServices.Conversions.ToString(Me.sx(num30))
                    num30 += 1
                End While

                RestaurantPOS14.My.MyProject.Forms.frmPOS.txtEBContactNo.Text = Me.xx
                Me.xx = ""
            End If

            If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.lblSet.Text, "TACN", TextCompare:=False) = 0 Then
                Me.sx = RestaurantPOS14.My.MyProject.Forms.frmPOS.txtTAContactNo.Text
                Dim num33 As Integer = Me.sx.Length - 2
                Dim num34 As Integer = 0
                While True
                    Dim num35 As Integer = num34
                    Dim num36 As Integer = num33
                    If num35 > num36 Then
                        Exit While
                    End If

                    Me.xx += Microsoft.VisualBasic.CompilerServices.Conversions.ToString(Me.sx(num34))
                    num34 += 1
                End While

                RestaurantPOS14.My.MyProject.Forms.frmPOS.txtTAContactNo.Text = Me.xx
                Me.xx = ""
            End If

            If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.lblSet.Text, "TAC", TextCompare:=False) = 0 Then
                Me.sx = RestaurantPOS14.My.MyProject.Forms.frmPOS.txtTACustomerName.Text
                Dim num37 As Integer = Me.sx.Length - 2
                Dim num38 As Integer = 0
                While True
                    Dim num39 As Integer = num38
                    Dim num40 As Integer = num37
                    If num39 > num40 Then
                        Exit While
                    End If

                    Me.xx += Microsoft.VisualBasic.CompilerServices.Conversions.ToString(Me.sx(num38))
                    num38 += 1
                End While

                RestaurantPOS14.My.MyProject.Forms.frmPOS.txtTACustomerName.Text = Me.xx
                Me.xx = ""
            End If

            If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.lblSet.Text, "EBC", TextCompare:=False) = 0 Then
                Me.sx = RestaurantPOS14.My.MyProject.Forms.frmPOS.txtEBCustomerName.Text
                Dim num41 As Integer = Me.sx.Length - 2
                Dim num42 As Integer = 0
                While True
                    Dim num43 As Integer = num42
                    Dim num44 As Integer = num41
                    If num43 > num44 Then
                        Exit While
                    End If

                    Me.xx += Microsoft.VisualBasic.CompilerServices.Conversions.ToString(Me.sx(num42))
                    num42 += 1
                End While

                RestaurantPOS14.My.MyProject.Forms.frmPOS.txtEBCustomerName.Text = Me.xx
                Me.xx = ""
            End If

            If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.lblSet.Text, "DIC", TextCompare:=False) = 0 Then
                Me.sx = RestaurantPOS14.My.MyProject.Forms.frmPOS.txtDICustomerName.Text
                Dim num45 As Integer = Me.sx.Length - 2
                Dim num46 As Integer = 0
                While True
                    Dim num47 As Integer = num46
                    Dim num48 As Integer = num45
                    If num47 > num48 Then
                        Exit While
                    End If

                    Me.xx += Microsoft.VisualBasic.CompilerServices.Conversions.ToString(Me.sx(num46))
                    num46 += 1
                End While

                RestaurantPOS14.My.MyProject.Forms.frmPOS.txtDICustomerName.Text = Me.xx
                Me.xx = ""
            End If

            If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.lblSet.Text, "DICN", TextCompare:=False) = 0 Then
                Me.sx = RestaurantPOS14.My.MyProject.Forms.frmPOS.txtDIContactNo.Text
                Dim num49 As Integer = Me.sx.Length - 2
                Dim num50 As Integer = 0
                While True
                    Dim num51 As Integer = num50
                    Dim num52 As Integer = num49
                    If num51 > num52 Then
                        Exit While
                    End If

                    Me.xx += Microsoft.VisualBasic.CompilerServices.Conversions.ToString(Me.sx(num50))
                    num50 += 1
                End While

                RestaurantPOS14.My.MyProject.Forms.frmPOS.txtDIContactNo.Text = Me.xx
                Me.xx = ""
            End If

            If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.lblSet.Text, "DIE", TextCompare:=False) = 0 Then
                Me.sx = RestaurantPOS14.My.MyProject.Forms.frmPOS.txtEmailID.Text
                Dim num53 As Integer = Me.sx.Length - 2
                Dim num54 As Integer = 0
                While True
                    Dim num55 As Integer = num54
                    Dim num56 As Integer = num53
                    If num55 > num56 Then
                        Exit While
                    End If

                    Me.xx += Microsoft.VisualBasic.CompilerServices.Conversions.ToString(Me.sx(num54))
                    num54 += 1
                End While

                RestaurantPOS14.My.MyProject.Forms.frmPOS.txtEmailID.Text = Me.xx
                Me.xx = ""
            End If

            If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.lblSet.Text, "CRC", TextCompare:=False) = 0 Then
                Me.sx = RestaurantPOS14.My.MyProject.Forms.frmCustomersRecord.txtCustomerName.Text
                Dim num57 As Integer = Me.sx.Length - 2
                Dim num58 As Integer = 0
                While True
                    Dim num59 As Integer = num58
                    Dim num60 As Integer = num57
                    If num59 > num60 Then
                        Exit While
                    End If

                    Me.xx += Microsoft.VisualBasic.CompilerServices.Conversions.ToString(Me.sx(num58))
                    num58 += 1
                End While

                RestaurantPOS14.My.MyProject.Forms.frmCustomersRecord.txtCustomerName.Text = Me.xx
                Me.xx = ""
            End If

            If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.lblSet.Text, "CRCN", TextCompare:=False) = 0 Then
                Me.sx = RestaurantPOS14.My.MyProject.Forms.frmCustomersRecord.txtContactNo.Text
                Dim num61 As Integer = Me.sx.Length - 2
                Dim num62 As Integer = 0
                While True
                    Dim num63 As Integer = num62
                    Dim num64 As Integer = num61
                    If num63 > num64 Then
                        Exit While
                    End If

                    Me.xx += Microsoft.VisualBasic.CompilerServices.Conversions.ToString(Me.sx(num62))
                    num62 += 1
                End While

                RestaurantPOS14.My.MyProject.Forms.frmCustomersRecord.txtContactNo.Text = Me.xx
                Me.xx = ""
            End If

            If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.lblSet.Text, "CRA", TextCompare:=False) <> 0 Then
                Return
            End If

            Me.sx = RestaurantPOS14.My.MyProject.Forms.frmCustomersRecord.txtAddress.Text
            Dim num65 As Integer = Me.sx.Length - 2
            Dim num66 As Integer = 0
            While True
                Dim num67 As Integer = num66
                Dim num68 As Integer = num65
                If num67 > num68 Then
                    Exit While
                End If

                Me.xx += Microsoft.VisualBasic.CompilerServices.Conversions.ToString(Me.sx(num66))
                num66 += 1
            End While

            RestaurantPOS14.My.MyProject.Forms.frmCustomersRecord.txtAddress.Text = Me.xx
            Me.xx = ""
        End Sub

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Protected Overrides Sub Dispose(disposing As Boolean)
            Try
                If disposing AndAlso Me.components IsNot Nothing Then
                    Me.components.Dispose()
                End If
            Finally
                MyBase.Dispose(disposing)
            End Try
        End Sub

        <System.Diagnostics.DebuggerStepThroughAttribute>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim cBlendItems As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
            Dim cBlendItems2 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
            Dim cBlendItems3 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
            Dim cBlendItems4 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
            Dim cBlendItems5 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
            Dim cBlendItems6 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
            Dim cBlendItems7 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
            Dim cBlendItems8 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
            Dim cBlendItems9 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
            Dim cBlendItems10 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
            Dim cBlendItems11 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
            Dim cBlendItems12 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
            Dim cBlendItems13 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
            Dim cBlendItems14 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
            Dim cBlendItems15 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
            Dim cBlendItems16 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
            Dim cBlendItems17 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
            Dim cBlendItems18 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
            Dim cBlendItems19 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
            Dim cBlendItems20 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
            Dim cBlendItems21 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
            Dim cBlendItems22 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
            Dim cBlendItems23 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
            Dim cBlendItems24 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
            Dim cBlendItems25 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
            Dim cBlendItems26 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
            Dim cBlendItems27 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
            Dim cBlendItems28 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
            Dim cBlendItems29 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
            Dim cBlendItems30 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
            Dim cBlendItems31 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
            Dim cBlendItems32 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
            Dim cBlendItems33 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
            Dim cBlendItems34 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
            Dim cBlendItems35 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
            Dim cBlendItems36 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
            Dim cBlendItems37 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
            Dim cBlendItems38 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
            Dim cBlendItems39 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
            Dim cBlendItems40 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
            Dim componentResourceManager As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RestaurantPOS14.frmOnscreenKeyboard))
            Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
            Me.P = New CButtonLib.CButton()
            Me.O = New CButtonLib.CButton()
            Me.I = New CButtonLib.CButton()
            Me.U = New CButtonLib.CButton()
            Me.Y = New CButtonLib.CButton()
            Me.T = New CButtonLib.CButton()
            Me.R = New CButtonLib.CButton()
            Me.btnE = New CButtonLib.CButton()
            Me.W = New CButtonLib.CButton()
            Me.Q = New CButtonLib.CButton()
            Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
            Me.L = New CButtonLib.CButton()
            Me.K = New CButtonLib.CButton()
            Me.J = New CButtonLib.CButton()
            Me.H = New CButtonLib.CButton()
            Me.G = New CButtonLib.CButton()
            Me.F = New CButtonLib.CButton()
            Me.D = New CButtonLib.CButton()
            Me.S = New CButtonLib.CButton()
            Me.A = New CButtonLib.CButton()
            Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
            Me.M = New CButtonLib.CButton()
            Me.N = New CButtonLib.CButton()
            Me.B = New CButtonLib.CButton()
            Me.V = New CButtonLib.CButton()
            Me.C = New CButtonLib.CButton()
            Me.X = New CButtonLib.CButton()
            Me.Z = New CButtonLib.CButton()
            Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
            Me.btnSearch = New CButtonLib.CButton()
            Me.btnBackspace = New CButtonLib.CButton()
            Me.btnSpaceBar = New CButtonLib.CButton()
            Me.btnCapsLock = New System.Windows.Forms.CheckBox()
            Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
            Me.btn3 = New CButtonLib.CButton()
            Me.btn2 = New CButtonLib.CButton()
            Me.btn1 = New CButtonLib.CButton()
            Me.btn6 = New CButtonLib.CButton()
            Me.btn5 = New CButtonLib.CButton()
            Me.btn4 = New CButtonLib.CButton()
            Me.btn9 = New CButtonLib.CButton()
            Me.btn8 = New CButtonLib.CButton()
            Me.btn7 = New CButtonLib.CButton()
            Me.TableLayoutPanel6 = New System.Windows.Forms.TableLayoutPanel()
            Me.btnX = New CButtonLib.CButton()
            Me.btn0 = New CButtonLib.CButton()
            Me.lblSet = New System.Windows.Forms.Label()
            Me.TableLayoutPanel1.SuspendLayout()
            Me.TableLayoutPanel2.SuspendLayout()
            Me.TableLayoutPanel3.SuspendLayout()
            Me.TableLayoutPanel4.SuspendLayout()
            Me.TableLayoutPanel5.SuspendLayout()
            Me.TableLayoutPanel6.SuspendLayout()
            MyBase.SuspendLayout()
            Me.TableLayoutPanel1.ColumnCount = 10
            Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F))
            Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F))
            Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F))
            Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F))
            Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F))
            Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F))
            Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F))
            Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F))
            Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F))
            Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F))
            Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F))
            Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F))
            Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F))
            Me.TableLayoutPanel1.Controls.Add(Me.P, 9, 0)
            Me.TableLayoutPanel1.Controls.Add(Me.O, 8, 0)
            Me.TableLayoutPanel1.Controls.Add(Me.I, 7, 0)
            Me.TableLayoutPanel1.Controls.Add(Me.U, 6, 0)
            Me.TableLayoutPanel1.Controls.Add(Me.Y, 5, 0)
            Me.TableLayoutPanel1.Controls.Add(Me.T, 4, 0)
            Me.TableLayoutPanel1.Controls.Add(Me.R, 3, 0)
            Me.TableLayoutPanel1.Controls.Add(Me.btnE, 2, 0)
            Me.TableLayoutPanel1.Controls.Add(Me.W, 1, 0)
            Me.TableLayoutPanel1.Controls.Add(Me.Q, 0, 0)
            Dim tableLayoutPanel As System.Windows.Forms.TableLayoutPanel = Me.TableLayoutPanel1
            Dim location As System.Drawing.Point = New System.Drawing.Point(2, 3)
            tableLayoutPanel.Location = location
            Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
            Me.TableLayoutPanel1.RowCount = 1
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F))
            Dim tableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel = Me.TableLayoutPanel1
            Dim size As System.Drawing.Size = New System.Drawing.Size(758, 89)
            tableLayoutPanel2.Size = size
            Me.TableLayoutPanel1.TabIndex = 0
            Me.P.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right
            Me.P.BackColor = System.Drawing.Color.Transparent
            Me.P.BorderColor = System.Drawing.Color.Transparent
            Me.P.BorderShow = False
            cBlendItems.iColor = New System.Drawing.Color(2) {System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105)}
            cBlendItems.iPoint = New Single(2) {0F, 0.5F, 1F}
            Me.P.ColorFillBlend = cBlendItems
            Me.P.Corners.All = 3
            Me.P.Corners.LowerLeft = 3
            Me.P.Corners.LowerRight = 3
            Me.P.Corners.UpperLeft = 3
            Me.P.Corners.UpperRight = 3
            Me.P.DesignerSelected = False
            Me.P.Font = New System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.P.ImageIndex = 0
            Dim p As CButtonLib.CButton = Me.P
            location = New System.Drawing.Point(678, 3)
            p.Location = location
            Me.P.Name = "P"
            Dim p2 As CButtonLib.CButton = Me.P
            size = New System.Drawing.Size(77, 83)
            p2.Size = size
            Me.P.TabIndex = 2
            Me.P.Text = "P"
            Me.P.TextShadowShow = False
            Me.P.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.SystemDefault
            Me.O.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right
            Me.O.BackColor = System.Drawing.Color.Transparent
            Me.O.BorderColor = System.Drawing.Color.Transparent
            Me.O.BorderShow = False
            cBlendItems2.iColor = New System.Drawing.Color(2) {System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105)}
            cBlendItems2.iPoint = New Single(2) {0F, 0.5F, 1F}
            Me.O.ColorFillBlend = cBlendItems2
            Me.O.Corners.All = 3
            Me.O.Corners.LowerLeft = 3
            Me.O.Corners.LowerRight = 3
            Me.O.Corners.UpperLeft = 3
            Me.O.Corners.UpperRight = 3
            Me.O.DesignerSelected = False
            Me.O.Font = New System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.O.ImageIndex = 0
            Dim o As CButtonLib.CButton = Me.O
            location = New System.Drawing.Point(603, 3)
            o.Location = location
            Me.O.Name = "O"
            Dim o2 As CButtonLib.CButton = Me.O
            size = New System.Drawing.Size(69, 83)
            o2.Size = size
            Me.O.TabIndex = 2
            Me.O.Text = "O"
            Me.O.TextShadowShow = False
            Me.O.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.SystemDefault
            Me.I.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right
            Me.I.BackColor = System.Drawing.Color.Transparent
            Me.I.BorderColor = System.Drawing.Color.Transparent
            Me.I.BorderShow = False
            cBlendItems3.iColor = New System.Drawing.Color(2) {System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105)}
            cBlendItems3.iPoint = New Single(2) {0F, 0.5F, 1F}
            Me.I.ColorFillBlend = cBlendItems3
            Me.I.Corners.All = 3
            Me.I.Corners.LowerLeft = 3
            Me.I.Corners.LowerRight = 3
            Me.I.Corners.UpperLeft = 3
            Me.I.Corners.UpperRight = 3
            Me.I.DesignerSelected = False
            Me.I.Font = New System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.I.ImageIndex = 0
            Dim i As CButtonLib.CButton = Me.I
            location = New System.Drawing.Point(528, 3)
            i.Location = location
            Me.I.Name = "I"
            Dim i2 As CButtonLib.CButton = Me.I
            size = New System.Drawing.Size(69, 83)
            i2.Size = size
            Me.I.TabIndex = 2
            Me.I.Text = "I"
            Me.I.TextShadowShow = False
            Me.I.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.SystemDefault
            Me.U.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right
            Me.U.BackColor = System.Drawing.Color.Transparent
            Me.U.BorderColor = System.Drawing.Color.Transparent
            Me.U.BorderShow = False
            cBlendItems4.iColor = New System.Drawing.Color(2) {System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105)}
            cBlendItems4.iPoint = New Single(2) {0F, 0.5F, 1F}
            Me.U.ColorFillBlend = cBlendItems4
            Me.U.Corners.All = 3
            Me.U.Corners.LowerLeft = 3
            Me.U.Corners.LowerRight = 3
            Me.U.Corners.UpperLeft = 3
            Me.U.Corners.UpperRight = 3
            Me.U.DesignerSelected = False
            Me.U.Font = New System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.U.ImageIndex = 0
            Dim u As CButtonLib.CButton = Me.U
            location = New System.Drawing.Point(453, 3)
            u.Location = location
            Me.U.Name = "U"
            Dim u2 As CButtonLib.CButton = Me.U
            size = New System.Drawing.Size(69, 83)
            u2.Size = size
            Me.U.TabIndex = 2
            Me.U.Text = "U"
            Me.U.TextShadowShow = False
            Me.U.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.SystemDefault
            Me.Y.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right
            Me.Y.BackColor = System.Drawing.Color.Transparent
            Me.Y.BorderColor = System.Drawing.Color.Transparent
            Me.Y.BorderShow = False
            cBlendItems5.iColor = New System.Drawing.Color(2) {System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105)}
            cBlendItems5.iPoint = New Single(2) {0F, 0.5F, 1F}
            Me.Y.ColorFillBlend = cBlendItems5
            Me.Y.Corners.All = 3
            Me.Y.Corners.LowerLeft = 3
            Me.Y.Corners.LowerRight = 3
            Me.Y.Corners.UpperLeft = 3
            Me.Y.Corners.UpperRight = 3
            Me.Y.DesignerSelected = False
            Me.Y.Font = New System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.Y.ImageIndex = 0
            Dim cButton As CButtonLib.CButton = Me.Y
            location = New System.Drawing.Point(378, 3)
            cButton.Location = location
            Me.Y.Name = "Y"
            Dim cButton2 As CButtonLib.CButton = Me.Y
            size = New System.Drawing.Size(69, 83)
            cButton2.Size = size
            Me.Y.TabIndex = 2
            Me.Y.Text = "Y"
            Me.Y.TextShadowShow = False
            Me.Y.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.SystemDefault
            Me.T.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right
            Me.T.BackColor = System.Drawing.Color.Transparent
            Me.T.BorderColor = System.Drawing.Color.Transparent
            Me.T.BorderShow = False
            cBlendItems6.iColor = New System.Drawing.Color(2) {System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105)}
            cBlendItems6.iPoint = New Single(2) {0F, 0.5F, 1F}
            Me.T.ColorFillBlend = cBlendItems6
            Me.T.Corners.All = 3
            Me.T.Corners.LowerLeft = 3
            Me.T.Corners.LowerRight = 3
            Me.T.Corners.UpperLeft = 3
            Me.T.Corners.UpperRight = 3
            Me.T.DesignerSelected = False
            Me.T.Font = New System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.T.ImageIndex = 0
            Dim t As CButtonLib.CButton = Me.T
            location = New System.Drawing.Point(303, 3)
            t.Location = location
            Me.T.Name = "T"
            Dim t2 As CButtonLib.CButton = Me.T
            size = New System.Drawing.Size(69, 83)
            t2.Size = size
            Me.T.TabIndex = 2
            Me.T.Text = "T"
            Me.T.TextShadowShow = False
            Me.T.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.SystemDefault
            Me.R.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right
            Me.R.BackColor = System.Drawing.Color.Transparent
            Me.R.BorderColor = System.Drawing.Color.Transparent
            Me.R.BorderShow = False
            cBlendItems7.iColor = New System.Drawing.Color(2) {System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105)}
            cBlendItems7.iPoint = New Single(2) {0F, 0.5F, 1F}
            Me.R.ColorFillBlend = cBlendItems7
            Me.R.Corners.All = 3
            Me.R.Corners.LowerLeft = 3
            Me.R.Corners.LowerRight = 3
            Me.R.Corners.UpperLeft = 3
            Me.R.Corners.UpperRight = 3
            Me.R.DesignerSelected = False
            Me.R.Font = New System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.R.ImageIndex = 0
            Dim r As CButtonLib.CButton = Me.R
            location = New System.Drawing.Point(228, 3)
            r.Location = location
            Me.R.Name = "R"
            Dim r2 As CButtonLib.CButton = Me.R
            size = New System.Drawing.Size(69, 83)
            r2.Size = size
            Me.R.TabIndex = 2
            Me.R.Text = "R"
            Me.R.TextShadowShow = False
            Me.R.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.SystemDefault
            Me.btnE.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right
            Me.btnE.BackColor = System.Drawing.Color.Transparent
            Me.btnE.BorderColor = System.Drawing.Color.Transparent
            Me.btnE.BorderShow = False
            cBlendItems8.iColor = New System.Drawing.Color(2) {System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105)}
            cBlendItems8.iPoint = New Single(2) {0F, 0.5F, 1F}
            Me.btnE.ColorFillBlend = cBlendItems8
            Me.btnE.Corners.All = 3
            Me.btnE.Corners.LowerLeft = 3
            Me.btnE.Corners.LowerRight = 3
            Me.btnE.Corners.UpperLeft = 3
            Me.btnE.Corners.UpperRight = 3
            Me.btnE.DesignerSelected = False
            Me.btnE.Font = New System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnE.ImageIndex = 0
            Dim cButton3 As CButtonLib.CButton = Me.btnE
            location = New System.Drawing.Point(153, 3)
            cButton3.Location = location
            Me.btnE.Name = "btnE"
            Dim cButton4 As CButtonLib.CButton = Me.btnE
            size = New System.Drawing.Size(69, 83)
            cButton4.Size = size
            Me.btnE.TabIndex = 2
            Me.btnE.Text = "E"
            Me.btnE.TextShadowShow = False
            Me.btnE.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.SystemDefault
            Me.W.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right
            Me.W.BackColor = System.Drawing.Color.Transparent
            Me.W.BorderColor = System.Drawing.Color.Transparent
            Me.W.BorderShow = False
            cBlendItems9.iColor = New System.Drawing.Color(2) {System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105)}
            cBlendItems9.iPoint = New Single(2) {0F, 0.5F, 1F}
            Me.W.ColorFillBlend = cBlendItems9
            Me.W.Corners.All = 3
            Me.W.Corners.LowerLeft = 3
            Me.W.Corners.LowerRight = 3
            Me.W.Corners.UpperLeft = 3
            Me.W.Corners.UpperRight = 3
            Me.W.DesignerSelected = False
            Me.W.Font = New System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.W.ImageIndex = 0
            Dim w As CButtonLib.CButton = Me.W
            location = New System.Drawing.Point(78, 3)
            w.Location = location
            Me.W.Name = "W"
            Dim w2 As CButtonLib.CButton = Me.W
            size = New System.Drawing.Size(69, 83)
            w2.Size = size
            Me.W.TabIndex = 2
            Me.W.Text = "W"
            Me.W.TextShadowShow = False
            Me.W.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.SystemDefault
            Me.Q.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right
            Me.Q.BackColor = System.Drawing.Color.Transparent
            Me.Q.BorderColor = System.Drawing.Color.Transparent
            Me.Q.BorderShow = False
            cBlendItems10.iColor = New System.Drawing.Color(2) {System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105)}
            cBlendItems10.iPoint = New Single(2) {0F, 0.5F, 1F}
            Me.Q.ColorFillBlend = cBlendItems10
            Me.Q.Corners.All = 3
            Me.Q.Corners.LowerLeft = 3
            Me.Q.Corners.LowerRight = 3
            Me.Q.Corners.UpperLeft = 3
            Me.Q.Corners.UpperRight = 3
            Me.Q.DesignerSelected = False
            Me.Q.Font = New System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.Q.ImageIndex = 0
            Dim q As CButtonLib.CButton = Me.Q
            location = New System.Drawing.Point(3, 3)
            q.Location = location
            Me.Q.Name = "Q"
            Dim q2 As CButtonLib.CButton = Me.Q
            size = New System.Drawing.Size(69, 83)
            q2.Size = size
            Me.Q.TabIndex = 1
            Me.Q.Text = "Q"
            Me.Q.TextShadowShow = False
            Me.Q.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.SystemDefault
            Me.TableLayoutPanel2.ColumnCount = 9
            Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F))
            Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F))
            Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F))
            Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F))
            Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F))
            Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F))
            Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F))
            Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F))
            Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F))
            Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F))
            Me.TableLayoutPanel2.Controls.Add(Me.L, 8, 0)
            Me.TableLayoutPanel2.Controls.Add(Me.K, 7, 0)
            Me.TableLayoutPanel2.Controls.Add(Me.J, 6, 0)
            Me.TableLayoutPanel2.Controls.Add(Me.H, 5, 0)
            Me.TableLayoutPanel2.Controls.Add(Me.G, 4, 0)
            Me.TableLayoutPanel2.Controls.Add(Me.F, 3, 0)
            Me.TableLayoutPanel2.Controls.Add(Me.D, 2, 0)
            Me.TableLayoutPanel2.Controls.Add(Me.S, 1, 0)
            Me.TableLayoutPanel2.Controls.Add(Me.A, 0, 0)
            Dim tableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel = Me.TableLayoutPanel2
            location = New System.Drawing.Point(2, 94)
            tableLayoutPanel3.Location = location
            Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
            Me.TableLayoutPanel2.RowCount = 1
            Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F))
            Dim tableLayoutPanel4 As System.Windows.Forms.TableLayoutPanel = Me.TableLayoutPanel2
            size = New System.Drawing.Size(758, 89)
            tableLayoutPanel4.Size = size
            Me.TableLayoutPanel2.TabIndex = 1
            Me.L.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right
            Me.L.BackColor = System.Drawing.Color.Transparent
            Me.L.BorderColor = System.Drawing.Color.Transparent
            Me.L.BorderShow = False
            cBlendItems11.iColor = New System.Drawing.Color(2) {System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105)}
            cBlendItems11.iPoint = New Single(2) {0F, 0.5F, 1F}
            Me.L.ColorFillBlend = cBlendItems11
            Me.L.Corners.All = 3
            Me.L.Corners.LowerLeft = 3
            Me.L.Corners.LowerRight = 3
            Me.L.Corners.UpperLeft = 3
            Me.L.Corners.UpperRight = 3
            Me.L.DesignerSelected = False
            Me.L.Font = New System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.L.ImageIndex = 0
            Dim l As CButtonLib.CButton = Me.L
            location = New System.Drawing.Point(675, 3)
            l.Location = location
            Me.L.Name = "L"
            Dim l2 As CButtonLib.CButton = Me.L
            size = New System.Drawing.Size(80, 83)
            l2.Size = size
            Me.L.TabIndex = 2
            Me.L.Text = "L"
            Me.L.TextShadowShow = False
            Me.L.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.SystemDefault
            Me.K.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right
            Me.K.BackColor = System.Drawing.Color.Transparent
            Me.K.BorderColor = System.Drawing.Color.Transparent
            Me.K.BorderShow = False
            cBlendItems12.iColor = New System.Drawing.Color(2) {System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105)}
            cBlendItems12.iPoint = New Single(2) {0F, 0.5F, 1F}
            Me.K.ColorFillBlend = cBlendItems12
            Me.K.Corners.All = 3
            Me.K.Corners.LowerLeft = 3
            Me.K.Corners.LowerRight = 3
            Me.K.Corners.UpperLeft = 3
            Me.K.Corners.UpperRight = 3
            Me.K.DesignerSelected = False
            Me.K.Font = New System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.K.ImageIndex = 0
            Dim k As CButtonLib.CButton = Me.K
            location = New System.Drawing.Point(591, 3)
            k.Location = location
            Me.K.Name = "K"
            Dim k2 As CButtonLib.CButton = Me.K
            size = New System.Drawing.Size(78, 83)
            k2.Size = size
            Me.K.TabIndex = 2
            Me.K.Text = "K"
            Me.K.TextShadowShow = False
            Me.K.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.SystemDefault
            Me.J.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right
            Me.J.BackColor = System.Drawing.Color.Transparent
            Me.J.BorderColor = System.Drawing.Color.Transparent
            Me.J.BorderShow = False
            cBlendItems13.iColor = New System.Drawing.Color(2) {System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105)}
            cBlendItems13.iPoint = New Single(2) {0F, 0.5F, 1F}
            Me.J.ColorFillBlend = cBlendItems13
            Me.J.Corners.All = 3
            Me.J.Corners.LowerLeft = 3
            Me.J.Corners.LowerRight = 3
            Me.J.Corners.UpperLeft = 3
            Me.J.Corners.UpperRight = 3
            Me.J.DesignerSelected = False
            Me.J.Font = New System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.J.ImageIndex = 0
            Dim j As CButtonLib.CButton = Me.J
            location = New System.Drawing.Point(507, 3)
            j.Location = location
            Me.J.Name = "J"
            Dim j2 As CButtonLib.CButton = Me.J
            size = New System.Drawing.Size(78, 83)
            j2.Size = size
            Me.J.TabIndex = 2
            Me.J.Text = "J"
            Me.J.TextShadowShow = False
            Me.J.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.SystemDefault
            Me.H.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right
            Me.H.BackColor = System.Drawing.Color.Transparent
            Me.H.BorderColor = System.Drawing.Color.Transparent
            Me.H.BorderShow = False
            cBlendItems14.iColor = New System.Drawing.Color(2) {System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105)}
            cBlendItems14.iPoint = New Single(2) {0F, 0.5F, 1F}
            Me.H.ColorFillBlend = cBlendItems14
            Me.H.Corners.All = 3
            Me.H.Corners.LowerLeft = 3
            Me.H.Corners.LowerRight = 3
            Me.H.Corners.UpperLeft = 3
            Me.H.Corners.UpperRight = 3
            Me.H.DesignerSelected = False
            Me.H.Font = New System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.H.ImageIndex = 0
            Dim h As CButtonLib.CButton = Me.H
            location = New System.Drawing.Point(423, 3)
            h.Location = location
            Me.H.Name = "H"
            Dim h2 As CButtonLib.CButton = Me.H
            size = New System.Drawing.Size(78, 83)
            h2.Size = size
            Me.H.TabIndex = 2
            Me.H.Text = "H"
            Me.H.TextShadowShow = False
            Me.H.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.SystemDefault
            Me.G.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right
            Me.G.BackColor = System.Drawing.Color.Transparent
            Me.G.BorderColor = System.Drawing.Color.Transparent
            Me.G.BorderShow = False
            cBlendItems15.iColor = New System.Drawing.Color(2) {System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105)}
            cBlendItems15.iPoint = New Single(2) {0F, 0.5F, 1F}
            Me.G.ColorFillBlend = cBlendItems15
            Me.G.Corners.All = 3
            Me.G.Corners.LowerLeft = 3
            Me.G.Corners.LowerRight = 3
            Me.G.Corners.UpperLeft = 3
            Me.G.Corners.UpperRight = 3
            Me.G.DesignerSelected = False
            Me.G.Font = New System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.G.ImageIndex = 0
            Dim g As CButtonLib.CButton = Me.G
            location = New System.Drawing.Point(339, 3)
            g.Location = location
            Me.G.Name = "G"
            Dim g2 As CButtonLib.CButton = Me.G
            size = New System.Drawing.Size(78, 83)
            g2.Size = size
            Me.G.TabIndex = 2
            Me.G.Text = "G"
            Me.G.TextShadowShow = False
            Me.G.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.SystemDefault
            Me.F.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right
            Me.F.BackColor = System.Drawing.Color.Transparent
            Me.F.BorderColor = System.Drawing.Color.Transparent
            Me.F.BorderShow = False
            cBlendItems16.iColor = New System.Drawing.Color(2) {System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105)}
            cBlendItems16.iPoint = New Single(2) {0F, 0.5F, 1F}
            Me.F.ColorFillBlend = cBlendItems16
            Me.F.Corners.All = 3
            Me.F.Corners.LowerLeft = 3
            Me.F.Corners.LowerRight = 3
            Me.F.Corners.UpperLeft = 3
            Me.F.Corners.UpperRight = 3
            Me.F.DesignerSelected = False
            Me.F.Font = New System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.F.ImageIndex = 0
            Dim f As CButtonLib.CButton = Me.F
            location = New System.Drawing.Point(255, 3)
            f.Location = location
            Me.F.Name = "F"
            Dim f2 As CButtonLib.CButton = Me.F
            size = New System.Drawing.Size(78, 83)
            f2.Size = size
            Me.F.TabIndex = 2
            Me.F.Text = "F"
            Me.F.TextShadowShow = False
            Me.F.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.SystemDefault
            Me.D.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right
            Me.D.BackColor = System.Drawing.Color.Transparent
            Me.D.BorderColor = System.Drawing.Color.Transparent
            Me.D.BorderShow = False
            cBlendItems17.iColor = New System.Drawing.Color(2) {System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105)}
            cBlendItems17.iPoint = New Single(2) {0F, 0.5F, 1F}
            Me.D.ColorFillBlend = cBlendItems17
            Me.D.Corners.All = 3
            Me.D.Corners.LowerLeft = 3
            Me.D.Corners.LowerRight = 3
            Me.D.Corners.UpperLeft = 3
            Me.D.Corners.UpperRight = 3
            Me.D.DesignerSelected = False
            Me.D.Font = New System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.D.ImageIndex = 0
            Dim d As CButtonLib.CButton = Me.D
            location = New System.Drawing.Point(171, 3)
            d.Location = location
            Me.D.Name = "D"
            Dim d2 As CButtonLib.CButton = Me.D
            size = New System.Drawing.Size(78, 83)
            d2.Size = size
            Me.D.TabIndex = 2
            Me.D.Text = "D"
            Me.D.TextShadowShow = False
            Me.D.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.SystemDefault
            Me.S.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right
            Me.S.BackColor = System.Drawing.Color.Transparent
            Me.S.BorderColor = System.Drawing.Color.Transparent
            Me.S.BorderShow = False
            cBlendItems18.iColor = New System.Drawing.Color(2) {System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105)}
            cBlendItems18.iPoint = New Single(2) {0F, 0.5F, 1F}
            Me.S.ColorFillBlend = cBlendItems18
            Me.S.Corners.All = 3
            Me.S.Corners.LowerLeft = 3
            Me.S.Corners.LowerRight = 3
            Me.S.Corners.UpperLeft = 3
            Me.S.Corners.UpperRight = 3
            Me.S.DesignerSelected = False
            Me.S.Font = New System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.S.ImageIndex = 0
            Dim s As CButtonLib.CButton = Me.S
            location = New System.Drawing.Point(87, 3)
            s.Location = location
            Me.S.Name = "S"
            Dim s2 As CButtonLib.CButton = Me.S
            size = New System.Drawing.Size(78, 83)
            s2.Size = size
            Me.S.TabIndex = 2
            Me.S.Text = "S"
            Me.S.TextShadowShow = False
            Me.S.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.SystemDefault
            Me.A.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right
            Me.A.BackColor = System.Drawing.Color.Transparent
            Me.A.BorderColor = System.Drawing.Color.Transparent
            Me.A.BorderShow = False
            cBlendItems19.iColor = New System.Drawing.Color(2) {System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105)}
            cBlendItems19.iPoint = New Single(2) {0F, 0.5F, 1F}
            Me.A.ColorFillBlend = cBlendItems19
            Me.A.Corners.All = 3
            Me.A.Corners.LowerLeft = 3
            Me.A.Corners.LowerRight = 3
            Me.A.Corners.UpperLeft = 3
            Me.A.Corners.UpperRight = 3
            Me.A.DesignerSelected = False
            Me.A.Font = New System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.A.ImageIndex = 0
            Dim a As CButtonLib.CButton = Me.A
            location = New System.Drawing.Point(3, 3)
            a.Location = location
            Me.A.Name = "A"
            Dim a2 As CButtonLib.CButton = Me.A
            size = New System.Drawing.Size(78, 83)
            a2.Size = size
            Me.A.TabIndex = 1
            Me.A.Text = "A"
            Me.A.TextShadowShow = False
            Me.A.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.SystemDefault
            Me.TableLayoutPanel3.ColumnCount = 7
            Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F))
            Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F))
            Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F))
            Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F))
            Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F))
            Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F))
            Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F))
            Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F))
            Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F))
            Me.TableLayoutPanel3.Controls.Add(Me.M, 6, 0)
            Me.TableLayoutPanel3.Controls.Add(Me.N, 5, 0)
            Me.TableLayoutPanel3.Controls.Add(Me.B, 4, 0)
            Me.TableLayoutPanel3.Controls.Add(Me.V, 3, 0)
            Me.TableLayoutPanel3.Controls.Add(Me.C, 2, 0)
            Me.TableLayoutPanel3.Controls.Add(Me.X, 1, 0)
            Me.TableLayoutPanel3.Controls.Add(Me.Z, 0, 0)
            Dim tableLayoutPanel5 As System.Windows.Forms.TableLayoutPanel = Me.TableLayoutPanel3
            location = New System.Drawing.Point(2, 186)
            tableLayoutPanel5.Location = location
            Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
            Me.TableLayoutPanel3.RowCount = 1
            Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F))
            Dim tableLayoutPanel6 As System.Windows.Forms.TableLayoutPanel = Me.TableLayoutPanel3
            size = New System.Drawing.Size(758, 89)
            tableLayoutPanel6.Size = size
            Me.TableLayoutPanel3.TabIndex = 2
            Me.M.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right
            Me.M.BackColor = System.Drawing.Color.Transparent
            Me.M.BorderColor = System.Drawing.Color.Transparent
            Me.M.BorderShow = False
            cBlendItems20.iColor = New System.Drawing.Color(2) {System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105)}
            cBlendItems20.iPoint = New Single(2) {0F, 0.5F, 1F}
            Me.M.ColorFillBlend = cBlendItems20
            Me.M.Corners.All = 3
            Me.M.Corners.LowerLeft = 3
            Me.M.Corners.LowerRight = 3
            Me.M.Corners.UpperLeft = 3
            Me.M.Corners.UpperRight = 3
            Me.M.DesignerSelected = False
            Me.M.Font = New System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.M.ImageIndex = 0
            Dim m As CButtonLib.CButton = Me.M
            location = New System.Drawing.Point(651, 3)
            m.Location = location
            Me.M.Name = "M"
            Dim m2 As CButtonLib.CButton = Me.M
            size = New System.Drawing.Size(104, 83)
            m2.Size = size
            Me.M.TabIndex = 2
            Me.M.Text = "M"
            Me.M.TextShadowShow = False
            Me.M.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.SystemDefault
            Me.N.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right
            Me.N.BackColor = System.Drawing.Color.Transparent
            Me.N.BorderColor = System.Drawing.Color.Transparent
            Me.N.BorderShow = False
            cBlendItems21.iColor = New System.Drawing.Color(2) {System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105)}
            cBlendItems21.iPoint = New Single(2) {0F, 0.5F, 1F}
            Me.N.ColorFillBlend = cBlendItems21
            Me.N.Corners.All = 3
            Me.N.Corners.LowerLeft = 3
            Me.N.Corners.LowerRight = 3
            Me.N.Corners.UpperLeft = 3
            Me.N.Corners.UpperRight = 3
            Me.N.DesignerSelected = False
            Me.N.Font = New System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.N.ImageIndex = 0
            Dim n As CButtonLib.CButton = Me.N
            location = New System.Drawing.Point(543, 3)
            n.Location = location
            Me.N.Name = "N"
            Dim n2 As CButtonLib.CButton = Me.N
            size = New System.Drawing.Size(102, 83)
            n2.Size = size
            Me.N.TabIndex = 2
            Me.N.Text = "N"
            Me.N.TextShadowShow = False
            Me.N.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.SystemDefault
            Me.B.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right
            Me.B.BackColor = System.Drawing.Color.Transparent
            Me.B.BorderColor = System.Drawing.Color.Transparent
            Me.B.BorderShow = False
            cBlendItems22.iColor = New System.Drawing.Color(2) {System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105)}
            cBlendItems22.iPoint = New Single(2) {0F, 0.5F, 1F}
            Me.B.ColorFillBlend = cBlendItems22
            Me.B.Corners.All = 3
            Me.B.Corners.LowerLeft = 3
            Me.B.Corners.LowerRight = 3
            Me.B.Corners.UpperLeft = 3
            Me.B.Corners.UpperRight = 3
            Me.B.DesignerSelected = False
            Me.B.Font = New System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.B.ImageIndex = 0
            Dim b As CButtonLib.CButton = Me.B
            location = New System.Drawing.Point(435, 3)
            b.Location = location
            Me.B.Name = "B"
            Dim b2 As CButtonLib.CButton = Me.B
            size = New System.Drawing.Size(102, 83)
            b2.Size = size
            Me.B.TabIndex = 2
            Me.B.Text = "B"
            Me.B.TextShadowShow = False
            Me.B.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.SystemDefault
            Me.V.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right
            Me.V.BackColor = System.Drawing.Color.Transparent
            Me.V.BorderColor = System.Drawing.Color.Transparent
            Me.V.BorderShow = False
            cBlendItems23.iColor = New System.Drawing.Color(2) {System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105)}
            cBlendItems23.iPoint = New Single(2) {0F, 0.5F, 1F}
            Me.V.ColorFillBlend = cBlendItems23
            Me.V.Corners.All = 3
            Me.V.Corners.LowerLeft = 3
            Me.V.Corners.LowerRight = 3
            Me.V.Corners.UpperLeft = 3
            Me.V.Corners.UpperRight = 3
            Me.V.DesignerSelected = False
            Me.V.Font = New System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.V.ImageIndex = 0
            Dim v As CButtonLib.CButton = Me.V
            location = New System.Drawing.Point(327, 3)
            v.Location = location
            Me.V.Name = "V"
            Dim v2 As CButtonLib.CButton = Me.V
            size = New System.Drawing.Size(102, 83)
            v2.Size = size
            Me.V.TabIndex = 2
            Me.V.Text = "V"
            Me.V.TextShadowShow = False
            Me.V.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.SystemDefault
            Me.C.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right
            Me.C.BackColor = System.Drawing.Color.Transparent
            Me.C.BorderColor = System.Drawing.Color.Transparent
            Me.C.BorderShow = False
            cBlendItems24.iColor = New System.Drawing.Color(2) {System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105)}
            cBlendItems24.iPoint = New Single(2) {0F, 0.5F, 1F}
            Me.C.ColorFillBlend = cBlendItems24
            Me.C.Corners.All = 3
            Me.C.Corners.LowerLeft = 3
            Me.C.Corners.LowerRight = 3
            Me.C.Corners.UpperLeft = 3
            Me.C.Corners.UpperRight = 3
            Me.C.DesignerSelected = False
            Me.C.Font = New System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.C.ImageIndex = 0
            Dim c As CButtonLib.CButton = Me.C
            location = New System.Drawing.Point(219, 3)
            c.Location = location
            Me.C.Name = "C"
            Dim c2 As CButtonLib.CButton = Me.C
            size = New System.Drawing.Size(102, 83)
            c2.Size = size
            Me.C.TabIndex = 2
            Me.C.Text = "C"
            Me.C.TextShadowShow = False
            Me.C.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.SystemDefault
            Me.X.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right
            Me.X.BackColor = System.Drawing.Color.Transparent
            Me.X.BorderColor = System.Drawing.Color.Transparent
            Me.X.BorderShow = False
            cBlendItems25.iColor = New System.Drawing.Color(2) {System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105)}
            cBlendItems25.iPoint = New Single(2) {0F, 0.5F, 1F}
            Me.X.ColorFillBlend = cBlendItems25
            Me.X.Corners.All = 3
            Me.X.Corners.LowerLeft = 3
            Me.X.Corners.LowerRight = 3
            Me.X.Corners.UpperLeft = 3
            Me.X.Corners.UpperRight = 3
            Me.X.DesignerSelected = False
            Me.X.Font = New System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.X.ImageIndex = 0
            Dim cButton5 As CButtonLib.CButton = Me.X
            location = New System.Drawing.Point(111, 3)
            cButton5.Location = location
            Me.X.Name = "X"
            Dim cButton6 As CButtonLib.CButton = Me.X
            size = New System.Drawing.Size(102, 83)
            cButton6.Size = size
            Me.X.TabIndex = 2
            Me.X.Text = "X"
            Me.X.TextShadowShow = False
            Me.X.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.SystemDefault
            Me.Z.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right
            Me.Z.BackColor = System.Drawing.Color.Transparent
            Me.Z.BorderColor = System.Drawing.Color.Transparent
            Me.Z.BorderShow = False
            cBlendItems26.iColor = New System.Drawing.Color(2) {System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105)}
            cBlendItems26.iPoint = New Single(2) {0F, 0.5F, 1F}
            Me.Z.ColorFillBlend = cBlendItems26
            Me.Z.Corners.All = 3
            Me.Z.Corners.LowerLeft = 3
            Me.Z.Corners.LowerRight = 3
            Me.Z.Corners.UpperLeft = 3
            Me.Z.Corners.UpperRight = 3
            Me.Z.DesignerSelected = False
            Me.Z.Font = New System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.Z.ImageIndex = 0
            Dim z As CButtonLib.CButton = Me.Z
            location = New System.Drawing.Point(3, 3)
            z.Location = location
            Me.Z.Name = "Z"
            Dim z2 As CButtonLib.CButton = Me.Z
            size = New System.Drawing.Size(102, 83)
            z2.Size = size
            Me.Z.TabIndex = 1
            Me.Z.Text = "Z"
            Me.Z.TextShadowShow = False
            Me.Z.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.SystemDefault
            Me.TableLayoutPanel4.ColumnCount = 4
            Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22F))
            Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36F))
            Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24F))
            Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18F))
            Me.TableLayoutPanel4.Controls.Add(Me.btnSearch, 3, 0)
            Me.TableLayoutPanel4.Controls.Add(Me.btnBackspace, 2, 0)
            Me.TableLayoutPanel4.Controls.Add(Me.btnSpaceBar, 1, 0)
            Me.TableLayoutPanel4.Controls.Add(Me.btnCapsLock, 0, 0)
            Dim tableLayoutPanel7 As System.Windows.Forms.TableLayoutPanel = Me.TableLayoutPanel4
            location = New System.Drawing.Point(2, 277)
            tableLayoutPanel7.Location = location
            Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
            Me.TableLayoutPanel4.RowCount = 1
            Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F))
            Dim tableLayoutPanel8 As System.Windows.Forms.TableLayoutPanel = Me.TableLayoutPanel4
            size = New System.Drawing.Size(758, 89)
            tableLayoutPanel8.Size = size
            Me.TableLayoutPanel4.TabIndex = 3
            Me.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right
            Me.btnSearch.BackColor = System.Drawing.Color.Transparent
            Me.btnSearch.BorderColor = System.Drawing.Color.Transparent
            Me.btnSearch.BorderShow = False
            cBlendItems27.iColor = New System.Drawing.Color(2) {System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105)}
            cBlendItems27.iPoint = New Single(2) {0F, 0.5F, 1F}
            Me.btnSearch.ColorFillBlend = cBlendItems27
            Me.btnSearch.Corners.All = 3
            Me.btnSearch.Corners.LowerLeft = 3
            Me.btnSearch.Corners.LowerRight = 3
            Me.btnSearch.Corners.UpperLeft = 3
            Me.btnSearch.Corners.UpperRight = 3
            Me.btnSearch.DesignerSelected = False
            Me.btnSearch.Font = New System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnSearch.ImageIndex = 0
            Dim cButton7 As CButtonLib.CButton = Me.btnSearch
            location = New System.Drawing.Point(622, 3)
            cButton7.Location = location
            Me.btnSearch.Name = "btnSearch"
            Dim cButton8 As CButtonLib.CButton = Me.btnSearch
            size = New System.Drawing.Size(133, 83)
            cButton8.Size = size
            Me.btnSearch.TabIndex = 2
            Me.btnSearch.Text = "ENTER"
            Me.btnSearch.TextShadowShow = False
            Me.btnSearch.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.SystemDefault
            Me.btnBackspace.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right
            Me.btnBackspace.BackColor = System.Drawing.Color.Transparent
            Me.btnBackspace.BorderColor = System.Drawing.Color.Transparent
            Me.btnBackspace.BorderShow = False
            cBlendItems28.iColor = New System.Drawing.Color(2) {System.Drawing.Color.Crimson, System.Drawing.Color.Crimson, System.Drawing.Color.Crimson}
            cBlendItems28.iPoint = New Single(2) {0F, 0.5F, 1F}
            Me.btnBackspace.ColorFillBlend = cBlendItems28
            Me.btnBackspace.Corners.All = 3
            Me.btnBackspace.Corners.LowerLeft = 3
            Me.btnBackspace.Corners.LowerRight = 3
            Me.btnBackspace.Corners.UpperLeft = 3
            Me.btnBackspace.Corners.UpperRight = 3
            Me.btnBackspace.DesignerSelected = False
            Me.btnBackspace.Font = New System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnBackspace.ImageIndex = 0
            Dim cButton9 As CButtonLib.CButton = Me.btnBackspace
            location = New System.Drawing.Point(441, 3)
            cButton9.Location = location
            Me.btnBackspace.Name = "btnBackspace"
            Dim cButton10 As CButtonLib.CButton = Me.btnBackspace
            size = New System.Drawing.Size(175, 83)
            cButton10.Size = size
            Me.btnBackspace.TabIndex = 2
            Me.btnBackspace.Text = "Backspace"
            Me.btnBackspace.TextShadowShow = False
            Me.btnBackspace.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.SystemDefault
            Me.btnSpaceBar.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right
            Me.btnSpaceBar.BackColor = System.Drawing.Color.Transparent
            Me.btnSpaceBar.BorderColor = System.Drawing.Color.Transparent
            Me.btnSpaceBar.BorderShow = False
            cBlendItems29.iColor = New System.Drawing.Color(2) {System.Drawing.Color.Crimson, System.Drawing.Color.Crimson, System.Drawing.Color.Crimson}
            cBlendItems29.iPoint = New Single(2) {0F, 0.5F, 1F}
            Me.btnSpaceBar.ColorFillBlend = cBlendItems29
            Me.btnSpaceBar.Corners.All = 3
            Me.btnSpaceBar.Corners.LowerLeft = 3
            Me.btnSpaceBar.Corners.LowerRight = 3
            Me.btnSpaceBar.Corners.UpperLeft = 3
            Me.btnSpaceBar.Corners.UpperRight = 3
            Me.btnSpaceBar.DesignerSelected = False
            Me.btnSpaceBar.Font = New System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnSpaceBar.ImageIndex = 0
            Dim cButton11 As CButtonLib.CButton = Me.btnSpaceBar
            location = New System.Drawing.Point(169, 3)
            cButton11.Location = location
            Me.btnSpaceBar.Name = "btnSpaceBar"
            Dim cButton12 As CButtonLib.CButton = Me.btnSpaceBar
            size = New System.Drawing.Size(266, 83)
            cButton12.Size = size
            Me.btnSpaceBar.TabIndex = 2
            Me.btnSpaceBar.Text = "Space Bar"
            Me.btnSpaceBar.TextShadowShow = False
            Me.btnSpaceBar.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.SystemDefault
            Me.btnCapsLock.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right
            Me.btnCapsLock.Appearance = System.Windows.Forms.Appearance.Button
            Me.btnCapsLock.AutoSize = True
            Me.btnCapsLock.BackColor = System.Drawing.Color.FromArgb(102, 106, 105)
            Me.btnCapsLock.Checked = True
            Me.btnCapsLock.CheckState = System.Windows.Forms.CheckState.Checked
            Me.btnCapsLock.FlatStyle = System.Windows.Forms.FlatStyle.Popup
            Me.btnCapsLock.Font = New System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnCapsLock.ForeColor = System.Drawing.Color.White
            Dim checkBox As System.Windows.Forms.CheckBox = Me.btnCapsLock
            location = New System.Drawing.Point(3, 3)
            checkBox.Location = location
            Me.btnCapsLock.Name = "btnCapsLock"
            Dim checkBox2 As System.Windows.Forms.CheckBox = Me.btnCapsLock
            size = New System.Drawing.Size(160, 83)
            checkBox2.Size = size
            Me.btnCapsLock.TabIndex = 3
            Me.btnCapsLock.Text = "Caps Lock"
            Me.btnCapsLock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            Me.btnCapsLock.UseVisualStyleBackColor = False
            Me.TableLayoutPanel5.BackColor = System.Drawing.Color.FromArgb(58, 58, 56)
            Me.TableLayoutPanel5.ColumnCount = 3
            Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F))
            Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F))
            Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F))
            Me.TableLayoutPanel5.Controls.Add(Me.btn3, 2, 2)
            Me.TableLayoutPanel5.Controls.Add(Me.btn2, 1, 2)
            Me.TableLayoutPanel5.Controls.Add(Me.btn1, 0, 2)
            Me.TableLayoutPanel5.Controls.Add(Me.btn6, 2, 1)
            Me.TableLayoutPanel5.Controls.Add(Me.btn5, 1, 1)
            Me.TableLayoutPanel5.Controls.Add(Me.btn4, 0, 1)
            Me.TableLayoutPanel5.Controls.Add(Me.btn9, 2, 0)
            Me.TableLayoutPanel5.Controls.Add(Me.btn8, 1, 0)
            Me.TableLayoutPanel5.Controls.Add(Me.btn7, 0, 0)
            Dim tableLayoutPanel9 As System.Windows.Forms.TableLayoutPanel = Me.TableLayoutPanel5
            location = New System.Drawing.Point(763, 3)
            tableLayoutPanel9.Location = location
            Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
            Me.TableLayoutPanel5.RowCount = 3
            Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F))
            Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F))
            Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F))
            Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F))
            Dim tableLayoutPanel10 As System.Windows.Forms.TableLayoutPanel = Me.TableLayoutPanel5
            size = New System.Drawing.Size(238, 269)
            tableLayoutPanel10.Size = size
            Me.TableLayoutPanel5.TabIndex = 4
            Me.btn3.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right
            Me.btn3.BackColor = System.Drawing.Color.Transparent
            Me.btn3.BorderColor = System.Drawing.Color.Transparent
            Me.btn3.BorderShow = False
            cBlendItems30.iColor = New System.Drawing.Color(2) {System.Drawing.Color.Green, System.Drawing.Color.Green, System.Drawing.Color.Green}
            cBlendItems30.iPoint = New Single(2) {0F, 0.5F, 1F}
            Me.btn3.ColorFillBlend = cBlendItems30
            Me.btn3.Corners.All = 3
            Me.btn3.Corners.LowerLeft = 3
            Me.btn3.Corners.LowerRight = 3
            Me.btn3.Corners.UpperLeft = 3
            Me.btn3.Corners.UpperRight = 3
            Me.btn3.DesignerSelected = False
            Me.btn3.Font = New System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btn3.ImageIndex = 0
            Dim cButton13 As CButtonLib.CButton = Me.btn3
            location = New System.Drawing.Point(161, 181)
            cButton13.Location = location
            Me.btn3.Name = "btn3"
            Dim cButton14 As CButtonLib.CButton = Me.btn3
            size = New System.Drawing.Size(74, 85)
            cButton14.Size = size
            Me.btn3.TabIndex = 5
            Me.btn3.Text = "3"
            Me.btn3.TextShadowShow = False
            Me.btn3.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.SystemDefault
            Me.btn2.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right
            Me.btn2.BackColor = System.Drawing.Color.Transparent
            Me.btn2.BorderColor = System.Drawing.Color.Transparent
            Me.btn2.BorderShow = False
            cBlendItems31.iColor = New System.Drawing.Color(2) {System.Drawing.Color.Green, System.Drawing.Color.Green, System.Drawing.Color.Green}
            cBlendItems31.iPoint = New Single(2) {0F, 0.5F, 1F}
            Me.btn2.ColorFillBlend = cBlendItems31
            Me.btn2.Corners.All = 3
            Me.btn2.Corners.LowerLeft = 3
            Me.btn2.Corners.LowerRight = 3
            Me.btn2.Corners.UpperLeft = 3
            Me.btn2.Corners.UpperRight = 3
            Me.btn2.DesignerSelected = False
            Me.btn2.Font = New System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btn2.ImageIndex = 0
            Dim cButton15 As CButtonLib.CButton = Me.btn2
            location = New System.Drawing.Point(82, 181)
            cButton15.Location = location
            Me.btn2.Name = "btn2"
            Dim cButton16 As CButtonLib.CButton = Me.btn2
            size = New System.Drawing.Size(73, 85)
            cButton16.Size = size
            Me.btn2.TabIndex = 5
            Me.btn2.Text = "2"
            Me.btn2.TextShadowShow = False
            Me.btn2.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.SystemDefault
            Me.btn1.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right
            Me.btn1.BackColor = System.Drawing.Color.Transparent
            Me.btn1.BorderColor = System.Drawing.Color.Transparent
            Me.btn1.BorderShow = False
            cBlendItems32.iColor = New System.Drawing.Color(2) {System.Drawing.Color.Green, System.Drawing.Color.Green, System.Drawing.Color.Green}
            cBlendItems32.iPoint = New Single(2) {0F, 0.5F, 1F}
            Me.btn1.ColorFillBlend = cBlendItems32
            Me.btn1.Corners.All = 3
            Me.btn1.Corners.LowerLeft = 3
            Me.btn1.Corners.LowerRight = 3
            Me.btn1.Corners.UpperLeft = 3
            Me.btn1.Corners.UpperRight = 3
            Me.btn1.DesignerSelected = False
            Me.btn1.Font = New System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btn1.ImageIndex = 0
            Dim cButton17 As CButtonLib.CButton = Me.btn1
            location = New System.Drawing.Point(3, 181)
            cButton17.Location = location
            Me.btn1.Name = "btn1"
            Dim cButton18 As CButtonLib.CButton = Me.btn1
            size = New System.Drawing.Size(73, 85)
            cButton18.Size = size
            Me.btn1.TabIndex = 5
            Me.btn1.Text = "1"
            Me.btn1.TextShadowShow = False
            Me.btn1.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.SystemDefault
            Me.btn6.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right
            Me.btn6.BackColor = System.Drawing.Color.Transparent
            Me.btn6.BorderColor = System.Drawing.Color.Transparent
            Me.btn6.BorderShow = False
            cBlendItems33.iColor = New System.Drawing.Color(2) {System.Drawing.Color.Green, System.Drawing.Color.Green, System.Drawing.Color.Green}
            cBlendItems33.iPoint = New Single(2) {0F, 0.5F, 1F}
            Me.btn6.ColorFillBlend = cBlendItems33
            Me.btn6.Corners.All = 3
            Me.btn6.Corners.LowerLeft = 3
            Me.btn6.Corners.LowerRight = 3
            Me.btn6.Corners.UpperLeft = 3
            Me.btn6.Corners.UpperRight = 3
            Me.btn6.DesignerSelected = False
            Me.btn6.Font = New System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btn6.ImageIndex = 0
            Dim cButton19 As CButtonLib.CButton = Me.btn6
            location = New System.Drawing.Point(161, 92)
            cButton19.Location = location
            Me.btn6.Name = "btn6"
            Dim cButton20 As CButtonLib.CButton = Me.btn6
            size = New System.Drawing.Size(74, 83)
            cButton20.Size = size
            Me.btn6.TabIndex = 5
            Me.btn6.Text = "6"
            Me.btn6.TextShadowShow = False
            Me.btn6.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.SystemDefault
            Me.btn5.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right
            Me.btn5.BackColor = System.Drawing.Color.Transparent
            Me.btn5.BorderColor = System.Drawing.Color.Transparent
            Me.btn5.BorderShow = False
            cBlendItems34.iColor = New System.Drawing.Color(2) {System.Drawing.Color.Green, System.Drawing.Color.Green, System.Drawing.Color.Green}
            cBlendItems34.iPoint = New Single(2) {0F, 0.5F, 1F}
            Me.btn5.ColorFillBlend = cBlendItems34
            Me.btn5.Corners.All = 3
            Me.btn5.Corners.LowerLeft = 3
            Me.btn5.Corners.LowerRight = 3
            Me.btn5.Corners.UpperLeft = 3
            Me.btn5.Corners.UpperRight = 3
            Me.btn5.DesignerSelected = False
            Me.btn5.Font = New System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btn5.ImageIndex = 0
            Dim cButton21 As CButtonLib.CButton = Me.btn5
            location = New System.Drawing.Point(82, 92)
            cButton21.Location = location
            Me.btn5.Name = "btn5"
            Dim cButton22 As CButtonLib.CButton = Me.btn5
            size = New System.Drawing.Size(73, 83)
            cButton22.Size = size
            Me.btn5.TabIndex = 5
            Me.btn5.Text = "5"
            Me.btn5.TextShadowShow = False
            Me.btn5.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.SystemDefault
            Me.btn4.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right
            Me.btn4.BackColor = System.Drawing.Color.Transparent
            Me.btn4.BorderColor = System.Drawing.Color.Transparent
            Me.btn4.BorderShow = False
            cBlendItems35.iColor = New System.Drawing.Color(2) {System.Drawing.Color.Green, System.Drawing.Color.Green, System.Drawing.Color.Green}
            cBlendItems35.iPoint = New Single(2) {0F, 0.5F, 1F}
            Me.btn4.ColorFillBlend = cBlendItems35
            Me.btn4.Corners.All = 3
            Me.btn4.Corners.LowerLeft = 3
            Me.btn4.Corners.LowerRight = 3
            Me.btn4.Corners.UpperLeft = 3
            Me.btn4.Corners.UpperRight = 3
            Me.btn4.DesignerSelected = False
            Me.btn4.Font = New System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btn4.ImageIndex = 0
            Dim cButton23 As CButtonLib.CButton = Me.btn4
            location = New System.Drawing.Point(3, 92)
            cButton23.Location = location
            Me.btn4.Name = "btn4"
            Dim cButton24 As CButtonLib.CButton = Me.btn4
            size = New System.Drawing.Size(73, 83)
            cButton24.Size = size
            Me.btn4.TabIndex = 5
            Me.btn4.Text = "4"
            Me.btn4.TextShadowShow = False
            Me.btn4.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.SystemDefault
            Me.btn9.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right
            Me.btn9.BackColor = System.Drawing.Color.Transparent
            Me.btn9.BorderColor = System.Drawing.Color.Transparent
            Me.btn9.BorderShow = False
            cBlendItems36.iColor = New System.Drawing.Color(2) {System.Drawing.Color.Green, System.Drawing.Color.Green, System.Drawing.Color.Green}
            cBlendItems36.iPoint = New Single(2) {0F, 0.5F, 1F}
            Me.btn9.ColorFillBlend = cBlendItems36
            Me.btn9.Corners.All = 3
            Me.btn9.Corners.LowerLeft = 3
            Me.btn9.Corners.LowerRight = 3
            Me.btn9.Corners.UpperLeft = 3
            Me.btn9.Corners.UpperRight = 3
            Me.btn9.DesignerSelected = False
            Me.btn9.Font = New System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btn9.ImageIndex = 0
            Dim cButton25 As CButtonLib.CButton = Me.btn9
            location = New System.Drawing.Point(161, 3)
            cButton25.Location = location
            Me.btn9.Name = "btn9"
            Dim cButton26 As CButtonLib.CButton = Me.btn9
            size = New System.Drawing.Size(74, 83)
            cButton26.Size = size
            Me.btn9.TabIndex = 5
            Me.btn9.Text = "9"
            Me.btn9.TextShadowShow = False
            Me.btn9.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.SystemDefault
            Me.btn8.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right
            Me.btn8.BackColor = System.Drawing.Color.Transparent
            Me.btn8.BorderColor = System.Drawing.Color.Transparent
            Me.btn8.BorderShow = False
            cBlendItems37.iColor = New System.Drawing.Color(2) {System.Drawing.Color.Green, System.Drawing.Color.Green, System.Drawing.Color.Green}
            cBlendItems37.iPoint = New Single(2) {0F, 0.5F, 1F}
            Me.btn8.ColorFillBlend = cBlendItems37
            Me.btn8.Corners.All = 3
            Me.btn8.Corners.LowerLeft = 3
            Me.btn8.Corners.LowerRight = 3
            Me.btn8.Corners.UpperLeft = 3
            Me.btn8.Corners.UpperRight = 3
            Me.btn8.DesignerSelected = False
            Me.btn8.Font = New System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btn8.ImageIndex = 0
            Dim cButton27 As CButtonLib.CButton = Me.btn8
            location = New System.Drawing.Point(82, 3)
            cButton27.Location = location
            Me.btn8.Name = "btn8"
            Dim cButton28 As CButtonLib.CButton = Me.btn8
            size = New System.Drawing.Size(73, 83)
            cButton28.Size = size
            Me.btn8.TabIndex = 5
            Me.btn8.Text = "8"
            Me.btn8.TextShadowShow = False
            Me.btn8.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.SystemDefault
            Me.btn7.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right
            Me.btn7.BackColor = System.Drawing.Color.Transparent
            Me.btn7.BorderColor = System.Drawing.Color.Transparent
            Me.btn7.BorderShow = False
            cBlendItems38.iColor = New System.Drawing.Color(2) {System.Drawing.Color.Green, System.Drawing.Color.Green, System.Drawing.Color.Green}
            cBlendItems38.iPoint = New Single(2) {0F, 0.5F, 1F}
            Me.btn7.ColorFillBlend = cBlendItems38
            Me.btn7.Corners.All = 3
            Me.btn7.Corners.LowerLeft = 3
            Me.btn7.Corners.LowerRight = 3
            Me.btn7.Corners.UpperLeft = 3
            Me.btn7.Corners.UpperRight = 3
            Me.btn7.DesignerSelected = False
            Me.btn7.Font = New System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btn7.ImageIndex = 0
            Dim cButton29 As CButtonLib.CButton = Me.btn7
            location = New System.Drawing.Point(3, 3)
            cButton29.Location = location
            Me.btn7.Name = "btn7"
            Dim cButton30 As CButtonLib.CButton = Me.btn7
            size = New System.Drawing.Size(73, 83)
            cButton30.Size = size
            Me.btn7.TabIndex = 5
            Me.btn7.Text = "7"
            Me.btn7.TextShadowShow = False
            Me.btn7.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.SystemDefault
            Me.TableLayoutPanel6.ColumnCount = 2
            Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F))
            Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F))
            Me.TableLayoutPanel6.Controls.Add(Me.btnX, 1, 0)
            Me.TableLayoutPanel6.Controls.Add(Me.btn0, 0, 0)
            Dim tableLayoutPanel11 As System.Windows.Forms.TableLayoutPanel = Me.TableLayoutPanel6
            location = New System.Drawing.Point(763, 275)
            tableLayoutPanel11.Location = location
            Me.TableLayoutPanel6.Name = "TableLayoutPanel6"
            Me.TableLayoutPanel6.RowCount = 1
            Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F))
            Dim tableLayoutPanel12 As System.Windows.Forms.TableLayoutPanel = Me.TableLayoutPanel6
            size = New System.Drawing.Size(235, 91)
            tableLayoutPanel12.Size = size
            Me.TableLayoutPanel6.TabIndex = 5
            Me.btnX.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right
            Me.btnX.BackColor = System.Drawing.Color.Transparent
            Me.btnX.BorderColor = System.Drawing.Color.Transparent
            Me.btnX.BorderShow = False
            cBlendItems39.iColor = New System.Drawing.Color(2) {System.Drawing.Color.Crimson, System.Drawing.Color.Crimson, System.Drawing.Color.Crimson}
            cBlendItems39.iPoint = New Single(2) {0F, 0.5F, 1F}
            Me.btnX.ColorFillBlend = cBlendItems39
            Me.btnX.Corners.All = 3
            Me.btnX.Corners.LowerLeft = 3
            Me.btnX.Corners.LowerRight = 3
            Me.btnX.Corners.UpperLeft = 3
            Me.btnX.Corners.UpperRight = 3
            Me.btnX.DesignerSelected = False
            Me.btnX.Font = New System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnX.ImageIndex = 0
            Dim cButton31 As CButtonLib.CButton = Me.btnX
            location = New System.Drawing.Point(167, 3)
            cButton31.Location = location
            Me.btnX.Name = "btnX"
            Dim cButton32 As CButtonLib.CButton = Me.btnX
            size = New System.Drawing.Size(65, 85)
            cButton32.Size = size
            Me.btnX.TabIndex = 2
            Me.btnX.Text = "X"
            Me.btnX.TextShadowShow = False
            Me.btnX.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.SystemDefault
            Me.btn0.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right
            Me.btn0.BackColor = System.Drawing.Color.Transparent
            Me.btn0.BorderColor = System.Drawing.Color.Transparent
            Me.btn0.BorderShow = False
            cBlendItems40.iColor = New System.Drawing.Color(2) {System.Drawing.Color.Green, System.Drawing.Color.Green, System.Drawing.Color.Green}
            cBlendItems40.iPoint = New Single(2) {0F, 0.5F, 1F}
            Me.btn0.ColorFillBlend = cBlendItems40
            Me.btn0.Corners.All = 3
            Me.btn0.Corners.LowerLeft = 3
            Me.btn0.Corners.LowerRight = 3
            Me.btn0.Corners.UpperLeft = 3
            Me.btn0.Corners.UpperRight = 3
            Me.btn0.DesignerSelected = False
            Me.btn0.Font = New System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btn0.ImageIndex = 0
            Dim cButton33 As CButtonLib.CButton = Me.btn0
            location = New System.Drawing.Point(3, 3)
            cButton33.Location = location
            Me.btn0.Name = "btn0"
            Dim cButton34 As CButtonLib.CButton = Me.btn0
            size = New System.Drawing.Size(158, 85)
            cButton34.Size = size
            Me.btn0.TabIndex = 1
            Me.btn0.Text = "0"
            Me.btn0.TextShadowShow = False
            Me.btn0.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.SystemDefault
            Me.lblSet.AutoSize = True
            Dim label As System.Windows.Forms.Label = Me.lblSet
            location = New System.Drawing.Point(489, 209)
            label.Location = location
            Me.lblSet.Name = "lblSet"
            Dim label2 As System.Windows.Forms.Label = Me.lblSet
            size = New System.Drawing.Size(0, 13)
            label2.Size = size
            Me.lblSet.TabIndex = 6
            Me.lblSet.Visible = False
            Dim autoScaleDimensions As System.Drawing.SizeF = New System.Drawing.SizeF(6F, 13F)
            MyBase.AutoScaleDimensions = autoScaleDimensions
            MyBase.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(58, 58, 56)
            size = New System.Drawing.Size(1001, 368)
            MyBase.ClientSize = size
            MyBase.Controls.Add(Me.lblSet)
            MyBase.Controls.Add(Me.TableLayoutPanel6)
            MyBase.Controls.Add(Me.TableLayoutPanel5)
            MyBase.Controls.Add(Me.TableLayoutPanel4)
            MyBase.Controls.Add(Me.TableLayoutPanel3)
            MyBase.Controls.Add(Me.TableLayoutPanel2)
            MyBase.Controls.Add(Me.TableLayoutPanel1)
            MyBase.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            MyBase.Icon = CType(componentResourceManager.GetObject("$this.Icon"), System.Drawing.Icon)
            MyBase.MaximizeBox = False
            MyBase.MinimizeBox = False
            MyBase.Name = "frmOnscreenKeyboard"
            MyBase.StartPosition = System.Windows.Forms.FormStartPosition.Manual
            Me.Text = "Onscreen Keyboard"
            MyBase.TopMost = True
            Me.TableLayoutPanel1.ResumeLayout(False)
            Me.TableLayoutPanel2.ResumeLayout(False)
            Me.TableLayoutPanel3.ResumeLayout(False)
            Me.TableLayoutPanel4.ResumeLayout(False)
            Me.TableLayoutPanel4.PerformLayout()
            Me.TableLayoutPanel5.ResumeLayout(False)
            Me.TableLayoutPanel6.ResumeLayout(False)
            MyBase.ResumeLayout(False)
            MyBase.PerformLayout()
        End Sub
    End Class
End Namespace

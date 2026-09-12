Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Data.SqlClient
Imports System.Diagnostics
Imports System.Drawing
Imports System.Drawing.Text
Imports System.IO
Imports System.IO.Ports
Imports System.Net
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports CButtonLib
Imports MetroFramework
Imports Microsoft.VisualBasic.CompilerServices
Imports RestaurantPOS14.My
Imports Telerik.WinControls.Themes
Imports Telerik.WinControls.UI

Namespace RestaurantPOS14

    <Microsoft.VisualBasic.CompilerServices.DesignerGeneratedAttribute>
    Public Class frmLogin
        Inherits System.Windows.Forms.Form
        Private Shared __ENCList As System.Collections.Generic.List(Of System.WeakReference) = New System.Collections.Generic.List(Of System.WeakReference)()
        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("UserID")>
        Private _UserID As System.Windows.Forms.TextBox
        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnCancel")>
        Private _btnCancel As System.Windows.Forms.Button
        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Panel1")>
        Private _Panel1 As System.Windows.Forms.Panel
        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("TableLayoutPanel3")>
        Private _TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Password")>
        Private _Password As System.Windows.Forms.TextBox
        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("UserType")>
        Private _UserType As System.Windows.Forms.TextBox
        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label1")>
        Private _Label1 As System.Windows.Forms.Label
        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnForgetPassword")>
        Private _btnForgetPassword As System.Windows.Forms.Button
        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtDisplayPort")>
        Private _txtDisplayPort As System.Windows.Forms.TextBox
        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtCurrentClockInID")>
        Private _txtCurrentClockInID As System.Windows.Forms.TextBox
        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Panel2")>
        Private _Panel2 As System.Windows.Forms.Panel
        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnX")>
        Private _btnX As CButtonLib.CButton
        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnTA9")>
        Private _btnTA9 As CButtonLib.CButton
        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnTA0")>
        Private _btnTA0 As CButtonLib.CButton
        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnTA8")>
        Private _btnTA8 As CButtonLib.CButton
        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnTA4")>
        Private _btnTA4 As CButtonLib.CButton
        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnTA6")>
        Private _btnTA6 As CButtonLib.CButton
        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnTA5")>
        Private _btnTA5 As CButtonLib.CButton
        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnTA7")>
        Private _btnTA7 As CButtonLib.CButton
        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnTA3")>
        Private _btnTA3 As CButtonLib.CButton
        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnTA1")>
        Private _btnTA1 As CButtonLib.CButton
        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnTA2")>
        Private _btnTA2 As CButtonLib.CButton
        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("lblTime")>
        Private _lblTime As System.Windows.Forms.Label
        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("lblDate")>
        Private _lblDate As System.Windows.Forms.Label
        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Panel3")>
        Private _Panel3 As System.Windows.Forms.Panel
        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Timer1")>
        Private _Timer1 As System.Windows.Forms.Timer
        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnScanCard")>
        Private _btnScanCard As CButtonLib.CButton
        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("cmbLoginType")>
        Private _cmbLoginType As System.Windows.Forms.ComboBox
        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtCPU_ID")>
        Private _txtCPU_ID As System.Windows.Forms.TextBox
        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtActivationID")>
        Private _txtActivationID As System.Windows.Forms.TextBox
        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtMB_SerialNo")>
        Private _txtMB_SerialNo As System.Windows.Forms.TextBox
        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("TextBox1")>
        Private _TextBox1 As System.Windows.Forms.TextBox
        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("LinkLabel1")>
        Private _LinkLabel1 As System.Windows.Forms.LinkLabel
        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("RadClock1")>
        Private _RadClock1 As Telerik.WinControls.UI.RadClock
        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("AquaTheme1")>
        Private _AquaTheme1 As Telerik.WinControls.Themes.AquaTheme
        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("DesertTheme1")>
        Private _DesertTheme1 As Telerik.WinControls.Themes.DesertTheme
        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Timer3")>
        Private _Timer3 As System.Windows.Forms.Timer
        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtDBLocation")>
        Private _txtDBLocation As System.Windows.Forms.TextBox
        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("LinkLabel2")>
        Private _LinkLabel2 As System.Windows.Forms.LinkLabel
        Private frm As RestaurantPOS14.frmOption
        Private sign_Indicator As Integer
        Private variable1 As Double
        Private variable2 As Double
        Private fl As Boolean
        Private s As String
        Private x As String
        Private components As System.ComponentModel.IContainer

        Private NotInheritable Class LoginCredential
            Public UserId As String
            Public UserType As String
            Public StoredPin As String
        End Class
        Friend Overridable Property UserID As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._UserID
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._UserID = value
            End Set
        End Property

        Friend Overridable Property btnCancel As System.Windows.Forms.Button
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnCancel
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Button)
                Dim value2 As System.EventHandler = AddressOf Me.Cancel_Click
                Dim value3 As System.EventHandler = AddressOf Me.Cancel_MouseLeave
                Dim value4 As System.EventHandler = AddressOf Me.Cancel_MouseHover
                If Me._btnCancel IsNot Nothing Then
                    RemoveHandler Me._btnCancel.Click, value2
                    RemoveHandler Me._btnCancel.MouseLeave, value3
                    RemoveHandler Me._btnCancel.MouseHover, value4
                End If

                Me._btnCancel = value
                If Me._btnCancel IsNot Nothing Then
                    AddHandler Me._btnCancel.Click, value2
                    AddHandler Me._btnCancel.MouseLeave, value3
                    AddHandler Me._btnCancel.MouseHover, value4
                End If
            End Set
        End Property

        Friend Overridable Property Panel1 As System.Windows.Forms.Panel
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Panel1
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Panel)
                Me._Panel1 = value
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

        Friend Overridable Property Password As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Password
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Dim value2 As System.Windows.Forms.KeyEventHandler = AddressOf Me.Password_KeyDown
                Dim value3 As System.EventHandler = AddressOf Me.Password_TextChanged
                Dim value4 As System.Windows.Forms.KeyPressEventHandler = AddressOf Me.Password_KeyPress
                If Me._Password IsNot Nothing Then
                    RemoveHandler Me._Password.KeyDown, value2
                    RemoveHandler Me._Password.TextChanged, value3
                    RemoveHandler Me._Password.KeyPress, value4
                End If

                Me._Password = value
                If Me._Password IsNot Nothing Then
                    AddHandler Me._Password.KeyDown, value2
                    AddHandler Me._Password.TextChanged, value3
                    AddHandler Me._Password.KeyPress, value4
                End If
            End Set
        End Property

        Friend Overridable Property UserType As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._UserType
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._UserType = value
            End Set
        End Property

        Friend Overridable Property Label1 As System.Windows.Forms.Label
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Label1
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Label)
                Me._Label1 = value
            End Set
        End Property

        Friend Overridable Property btnForgetPassword As System.Windows.Forms.Button
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnForgetPassword
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Button)
                Dim value2 As System.EventHandler = AddressOf Me.btnForgetPassword_Click
                Dim value3 As System.EventHandler = AddressOf Me.btnForgetPassword_MouseLeave
                Dim value4 As System.EventHandler = AddressOf Me.btnForgetPassword_MouseHover
                If Me._btnForgetPassword IsNot Nothing Then
                    RemoveHandler Me._btnForgetPassword.Click, value2
                    RemoveHandler Me._btnForgetPassword.MouseLeave, value3
                    RemoveHandler Me._btnForgetPassword.MouseHover, value4
                End If

                Me._btnForgetPassword = value
                If Me._btnForgetPassword IsNot Nothing Then
                    AddHandler Me._btnForgetPassword.Click, value2
                    AddHandler Me._btnForgetPassword.MouseLeave, value3
                    AddHandler Me._btnForgetPassword.MouseHover, value4
                End If
            End Set
        End Property

        Friend Overridable Property txtDisplayPort As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtDisplayPort
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._txtDisplayPort = value
            End Set
        End Property

        Friend Overridable Property txtCurrentClockInID As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtCurrentClockInID
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._txtCurrentClockInID = value
            End Set
        End Property

        Friend Overridable Property Panel2 As System.Windows.Forms.Panel
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Panel2
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Panel)
                Me._Panel2 = value
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

        Friend Overridable Property btnTA9 As CButtonLib.CButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnTA9
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As CButtonLib.CButton)
                Dim value2 As System.EventHandler = AddressOf Me.btnTA9_Click
                If Me._btnTA9 IsNot Nothing Then
                    RemoveHandler Me._btnTA9.Click, value2
                End If

                Me._btnTA9 = value
                If Me._btnTA9 IsNot Nothing Then
                    AddHandler Me._btnTA9.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property btnTA0 As CButtonLib.CButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnTA0
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As CButtonLib.CButton)
                Dim value2 As System.EventHandler = AddressOf Me.btnTA0_Click
                If Me._btnTA0 IsNot Nothing Then
                    RemoveHandler Me._btnTA0.Click, value2
                End If

                Me._btnTA0 = value
                If Me._btnTA0 IsNot Nothing Then
                    AddHandler Me._btnTA0.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property btnTA8 As CButtonLib.CButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnTA8
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As CButtonLib.CButton)
                Dim value2 As System.EventHandler = AddressOf Me.btnTA8_Click
                If Me._btnTA8 IsNot Nothing Then
                    RemoveHandler Me._btnTA8.Click, value2
                End If

                Me._btnTA8 = value
                If Me._btnTA8 IsNot Nothing Then
                    AddHandler Me._btnTA8.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property btnTA4 As CButtonLib.CButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnTA4
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As CButtonLib.CButton)
                Dim value2 As System.EventHandler = AddressOf Me.btnTA4_Click
                If Me._btnTA4 IsNot Nothing Then
                    RemoveHandler Me._btnTA4.Click, value2
                End If

                Me._btnTA4 = value
                If Me._btnTA4 IsNot Nothing Then
                    AddHandler Me._btnTA4.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property btnTA6 As CButtonLib.CButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnTA6
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As CButtonLib.CButton)
                Dim value2 As System.EventHandler = AddressOf Me.btnTA6_Click
                If Me._btnTA6 IsNot Nothing Then
                    RemoveHandler Me._btnTA6.Click, value2
                End If

                Me._btnTA6 = value
                If Me._btnTA6 IsNot Nothing Then
                    AddHandler Me._btnTA6.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property btnTA5 As CButtonLib.CButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnTA5
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As CButtonLib.CButton)
                Dim value2 As System.EventHandler = AddressOf Me.btnTA5_Click
                If Me._btnTA5 IsNot Nothing Then
                    RemoveHandler Me._btnTA5.Click, value2
                End If

                Me._btnTA5 = value
                If Me._btnTA5 IsNot Nothing Then
                    AddHandler Me._btnTA5.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property btnTA7 As CButtonLib.CButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnTA7
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As CButtonLib.CButton)
                Dim value2 As System.EventHandler = AddressOf Me.btnTA7_Click
                If Me._btnTA7 IsNot Nothing Then
                    RemoveHandler Me._btnTA7.Click, value2
                End If

                Me._btnTA7 = value
                If Me._btnTA7 IsNot Nothing Then
                    AddHandler Me._btnTA7.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property btnTA3 As CButtonLib.CButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnTA3
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As CButtonLib.CButton)
                Dim value2 As System.EventHandler = AddressOf Me.btnTA3_Click
                If Me._btnTA3 IsNot Nothing Then
                    RemoveHandler Me._btnTA3.Click, value2
                End If

                Me._btnTA3 = value
                If Me._btnTA3 IsNot Nothing Then
                    AddHandler Me._btnTA3.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property btnTA1 As CButtonLib.CButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnTA1
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As CButtonLib.CButton)
                Dim value2 As System.EventHandler = AddressOf Me.btnTA1_Click
                If Me._btnTA1 IsNot Nothing Then
                    RemoveHandler Me._btnTA1.Click, value2
                End If

                Me._btnTA1 = value
                If Me._btnTA1 IsNot Nothing Then
                    AddHandler Me._btnTA1.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property btnTA2 As CButtonLib.CButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnTA2
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As CButtonLib.CButton)
                Dim value2 As System.EventHandler = AddressOf Me.btnTA2_Click
                If Me._btnTA2 IsNot Nothing Then
                    RemoveHandler Me._btnTA2.Click, value2
                End If

                Me._btnTA2 = value
                If Me._btnTA2 IsNot Nothing Then
                    AddHandler Me._btnTA2.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property lblTime As System.Windows.Forms.Label
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._lblTime
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Label)
                Me._lblTime = value
            End Set
        End Property

        Friend Overridable Property lblDate As System.Windows.Forms.Label
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._lblDate
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Label)
                Me._lblDate = value
            End Set
        End Property

        Friend Overridable Property Panel3 As System.Windows.Forms.Panel
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Panel3
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Panel)
                Me._Panel3 = value
            End Set
        End Property

        Friend Overridable Property Timer1 As System.Windows.Forms.Timer
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Timer1
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Timer)
                Dim value2 As System.EventHandler = AddressOf Me.Timer1_Tick
                If Me._Timer1 IsNot Nothing Then
                    RemoveHandler Me._Timer1.Tick, value2
                End If

                Me._Timer1 = value
                If Me._Timer1 IsNot Nothing Then
                    AddHandler Me._Timer1.Tick, value2
                End If
            End Set
        End Property

        Friend Overridable Property btnScanCard As CButtonLib.CButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnScanCard
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As CButtonLib.CButton)
                Dim value2 As System.EventHandler = AddressOf Me.btnScanCard_Click
                If Me._btnScanCard IsNot Nothing Then
                    RemoveHandler Me._btnScanCard.Click, value2
                End If

                Me._btnScanCard = value
                If Me._btnScanCard IsNot Nothing Then
                    AddHandler Me._btnScanCard.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property cmbLoginType As System.Windows.Forms.ComboBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._cmbLoginType
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.ComboBox)
                Dim value2 As System.EventHandler = AddressOf Me.cmbLoginType_SelectedIndexChanged
                If Me._cmbLoginType IsNot Nothing Then
                    RemoveHandler Me._cmbLoginType.SelectedIndexChanged, value2
                End If

                Me._cmbLoginType = value
                If Me._cmbLoginType IsNot Nothing Then
                    AddHandler Me._cmbLoginType.SelectedIndexChanged, value2
                End If
            End Set
        End Property

        Friend Overridable Property txtCPU_ID As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtCPU_ID
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._txtCPU_ID = value
            End Set
        End Property

        Friend Overridable Property txtActivationID As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtActivationID
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._txtActivationID = value
            End Set
        End Property

        Friend Overridable Property txtMB_SerialNo As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtMB_SerialNo
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._txtMB_SerialNo = value
            End Set
        End Property

        Friend Overridable Property TextBox1 As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._TextBox1
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._TextBox1 = value
            End Set
        End Property

        Friend Overridable Property LinkLabel1 As System.Windows.Forms.LinkLabel
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._LinkLabel1
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.LinkLabel)
                Dim value2 As System.Windows.Forms.LinkLabelLinkClickedEventHandler = AddressOf Me.LinkLabel1_LinkClicked
                If Me._LinkLabel1 IsNot Nothing Then
                    RemoveHandler Me._LinkLabel1.LinkClicked, value2
                End If

                Me._LinkLabel1 = value
                If Me._LinkLabel1 IsNot Nothing Then
                    AddHandler Me._LinkLabel1.LinkClicked, value2
                End If
            End Set
        End Property

        Friend Overridable Property RadClock1 As Telerik.WinControls.UI.RadClock
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._RadClock1
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As Telerik.WinControls.UI.RadClock)
                Me._RadClock1 = value
            End Set
        End Property

        Friend Overridable Property AquaTheme1 As Telerik.WinControls.Themes.AquaTheme
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._AquaTheme1
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As Telerik.WinControls.Themes.AquaTheme)
                Me._AquaTheme1 = value
            End Set
        End Property

        Friend Overridable Property DesertTheme1 As Telerik.WinControls.Themes.DesertTheme
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._DesertTheme1
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As Telerik.WinControls.Themes.DesertTheme)
                Me._DesertTheme1 = value
            End Set
        End Property

        Friend Overridable Property Timer3 As System.Windows.Forms.Timer
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Timer3
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Timer)
                Dim value2 As System.EventHandler = AddressOf Me.Timer3_Tick
                If Me._Timer3 IsNot Nothing Then
                    RemoveHandler Me._Timer3.Tick, value2
                End If

                Me._Timer3 = value
                If Me._Timer3 IsNot Nothing Then
                    AddHandler Me._Timer3.Tick, value2
                End If
            End Set
        End Property

        Friend Overridable Property txtDBLocation As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtDBLocation
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._txtDBLocation = value
            End Set
        End Property

        Friend Overridable Property LinkLabel2 As System.Windows.Forms.LinkLabel
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._LinkLabel2
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.LinkLabel)
                Dim value2 As System.Windows.Forms.LinkLabelLinkClickedEventHandler = AddressOf Me.LinkLabel2_LinkClicked
                If Me._LinkLabel2 IsNot Nothing Then
                    RemoveHandler Me._LinkLabel2.LinkClicked, value2
                End If

                Me._LinkLabel2 = value
                If Me._LinkLabel2 IsNot Nothing Then
                    AddHandler Me._LinkLabel2.LinkClicked, value2
                End If
            End Set
        End Property

        Public Property L1 As String
            Get
                If Not String.IsNullOrEmpty(MyBase.Text) Then
                    Return MyBase.Text.Replace(Global.Microsoft.VisualBasic.Constants.vbLf, "\n")
                End If

                Return MyBase.Text
            End Get

            Set(value As String)
                MyBase.Text = (If(String.IsNullOrEmpty(value), value, value.Replace("\n", Global.Microsoft.VisualBasic.Constants.vbLf)))
            End Set
        End Property

        Public Sub New()
            AddHandler MyBase.Load, AddressOf Me.LoginForm1_Load
            AddHandler MyBase.FormClosing, AddressOf Me.frmLogin_FormClosing
            AddHandler MyBase.Shown, AddressOf Me.frmLogin_Shown
            AddHandler MyBase.Activated, AddressOf Me.frmLogin_Activated
            Call RestaurantPOS14.frmLogin.__ENCAddToList(Me)
            Me.frm = New RestaurantPOS14.frmOption()
            Me.sign_Indicator = 0
            Me.fl = False
            Me.InitializeComponent()
        End Sub

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Private Shared Sub __ENCAddToList(value As Object)
            SyncLock RestaurantPOS14.frmLogin.__ENCList
                If RestaurantPOS14.frmLogin.__ENCList.Count = RestaurantPOS14.frmLogin.__ENCList.Capacity Then
                    Dim num As Integer = 0
                    Dim num2 As Integer = RestaurantPOS14.frmLogin.__ENCList.Count - 1
                    Dim num3 As Integer = 0
                    While True
                        Dim num4 As Integer = num3
                        Dim num5 As Integer = num2
                        If num4 > num5 Then
                            Exit While
                        End If

                        If RestaurantPOS14.frmLogin.__ENCList(CInt((num3))).IsAlive Then
                            If num3 <> num Then
                                RestaurantPOS14.frmLogin.__ENCList(num) = RestaurantPOS14.frmLogin.__ENCList(num3)
                            End If

                            num += 1
                        End If

                        num3 += 1
                    End While

                    Call RestaurantPOS14.frmLogin.__ENCList.RemoveRange(num, RestaurantPOS14.frmLogin.__ENCList.Count - num)
                    RestaurantPOS14.frmLogin.__ENCList.Capacity = RestaurantPOS14.frmLogin.__ENCList.Count
                End If

                Call RestaurantPOS14.frmLogin.__ENCList.Add(New System.WeakReference(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(value)))
            End SyncLock
        End Sub

        Public Sub autoBackup()
            Try
                Call RestaurantPOS14.My.MyProject.Forms.frmCustomDialogWS.Show()
                Dim str As String = System.IO.Path.Combine(Me.txtDBLocation.Text.ToString(), RestaurantPOS14.Configuration.DatabaseMaintenance.BuildBackupFileName())
                MyBase.Cursor = System.Windows.Forms.Cursors.WaitCursor
                Me.Timer3.Enabled = True
                Call System.Data.SqlClient.SqlConnection.ClearAllPools()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.ReadCS())
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = RestaurantPOS14.Configuration.DatabaseMaintenance.CreateBackupCommand(RestaurantPOS14.ModClasses.con, str)
                RestaurantPOS14.ModClasses.cmd.ExecuteNonQuery()
                RestaurantPOS14.ModClasses.con.Close()
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.NoInlining Or System.Runtime.CompilerServices.MethodImplOptions.NoOptimization)>
        Private Sub Cancel_Click(sender As Object, e As System.EventArgs)
            Me.txtDBLocation.Text = RestaurantPOS14.ModFunc.DBBackupLocation()
            If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.txtDBLocation.Text, "", TextCompare:=False) <> 0 Then
                ' Never clear the selected directory. It may contain unrelated customer files.
                Call System.IO.Directory.CreateDirectory(Me.txtDBLocation.Text)
                Me.autoBackup()
                Me.ClearCustomerDisplay()
                RestaurantPOS14.Diagnostics.ApplicationLifecycle.ExitApplication()
            Else
                Call RestaurantPOS14.My.MyProject.Forms.frmCustomDialog8X.ShowDialog()
            End If
        End Sub

        Public Sub GetCustomerDisplayPort()
            Try
                Me.txtDisplayPort.Text = RestaurantPOS14.Configuration.SettingsHost.Current.Printing.CustomerDisplayPort
            Catch ex As System.Exception
                MetroFramework.MetroMessageBox.Show(Me, ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Public Sub ClearCustomerDisplay()
            Try
                Me.GetCustomerDisplayPort()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = RestaurantPOS14.ModClasses.con.CreateCommand()
                RestaurantPOS14.ModClasses.cmd.CommandText = "SELECT * from POSPrinterSetting where TillID=@d1 and CustomerDisplay='Yes'"
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", System.Net.Dns.GetHostName())
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                If RestaurantPOS14.ModClasses.rdr.Read() Then
                    Dim serialPort As System.IO.Ports.SerialPort = RestaurantPOS14.Configuration.SerialPortFactory.CreateCustomerDisplay(Me.txtDisplayPort.Text)
                    serialPort.Open()
                    serialPort.Write(Global.Microsoft.VisualBasic.Constants.vbFormFeed)
                    serialPort.Close()
                    serialPort.Dispose()
                End If

                If RestaurantPOS14.ModClasses.rdr IsNot Nothing Then
                    RestaurantPOS14.ModClasses.rdr.Close()
                End If

                If RestaurantPOS14.ModClasses.con.State = System.Data.ConnectionState.Open Then
                    RestaurantPOS14.ModClasses.con.Close()
                End If
            Catch ex As System.Exception
                MetroFramework.MetroMessageBox.Show(Me, ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.NoInlining Or System.Runtime.CompilerServices.MethodImplOptions.NoOptimization)>
        Private Sub LoginForm1_Load(sender As Object, e As System.EventArgs)
            Me.cmbLoginType.SelectedIndex = 0
            If Not RestaurantPOS14.ModFunc.HandleFirstRunDate() Then
                Call System.Windows.Forms.MessageBox.Show("System Datetime has been changed to previous date, Software won't work.", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
                RestaurantPOS14.Diagnostics.ApplicationLifecycle.ExitApplication()
                Return
            End If

            If Not System.IO.File.Exists(System.Windows.Forms.Application.StartupPath & "\LC.txt") Then
                Using streamWriter As System.IO.StreamWriter = New System.IO.StreamWriter(System.Windows.Forms.Application.StartupPath & "\LC.txt")
                    streamWriter.WriteLine(0)
                End Using
            End If

            If Microsoft.VisualBasic.CompilerServices.Conversions.ToDouble(RestaurantPOS14.ModFunc.ReadLC()) = 0.0 AndAlso Not RestaurantPOS14.ModFunc.HandleTrialRegistry() Then
                Call RestaurantPOS14.My.MyProject.Forms.frmSoftwareLicenceRenewal.ShowDialog()
            End If

            If Microsoft.VisualBasic.CompilerServices.Conversions.ToDouble(RestaurantPOS14.ModFunc.ReadLC()) = 1.0 AndAlso Not RestaurantPOS14.ModFunc.HandleRenewalRegistry() Then
                Call RestaurantPOS14.My.MyProject.Forms.frmSoftwareLicenceRenewal.ShowDialog()
            End If
        End Sub

        <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.NoInlining Or System.Runtime.CompilerServices.MethodImplOptions.NoOptimization)>
        Private Sub frmLogin_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs)
            RestaurantPOS14.Diagnostics.ApplicationLifecycle.ExitApplication()
        End Sub

        Public Sub GetNumerpadValue(a As Integer)
            If Me.cmbLoginType.SelectedIndex = 0 Then
                If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.Password.Text, "ENTER PIN", TextCompare:=False) = 0 Then
                    Me.Password.Text = ""
                End If

                Me.Password.PasswordChar = "•"c
                If Me.sign_Indicator = 0 Then
                    Me.Password.Text += System.Convert.ToString(a)
                ElseIf Me.sign_Indicator = 1 Then
                    Me.Password.Text = System.Convert.ToString(a)
                    Me.sign_Indicator = 0
                End If

                Me.fl = True
            End If
        End Sub

        Private Sub btnTA0_Click(sender As Object, e As System.EventArgs)
            Me.GetNumerpadValue(0)
        End Sub

        Private Sub btnX_Click(sender As Object, e As System.EventArgs)
            If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.Password.Text, "ENTER PIN", TextCompare:=False) = 0 Then
                Me.Password.Text = ""
            End If

            If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.Password.Text, "SCAN CARD", TextCompare:=False) = 0 Then
                Me.Password.Text = ""
            End If

            Me.s = Me.Password.Text
            Dim num As Integer = Me.s.Length - 2
            Dim num2 As Integer = 0
            While True
                Dim num3 As Integer = num2
                Dim num4 As Integer = num
                If num3 > num4 Then
                    Exit While
                End If

                Me.x += Microsoft.VisualBasic.CompilerServices.Conversions.ToString(Me.s(num2))
                num2 += 1
            End While

            Me.Password.Text = Me.x
            Me.x = ""
        End Sub

        Private Sub btnTA9_Click(sender As Object, e As System.EventArgs)
            Me.GetNumerpadValue(9)
        End Sub

        Private Sub btnTA8_Click(sender As Object, e As System.EventArgs)
            Me.GetNumerpadValue(8)
        End Sub

        Private Sub btnTA7_Click(sender As Object, e As System.EventArgs)
            Me.GetNumerpadValue(7)
        End Sub

        Private Sub btnTA6_Click(sender As Object, e As System.EventArgs)
            Me.GetNumerpadValue(6)
        End Sub

        Private Sub btnTA5_Click(sender As Object, e As System.EventArgs)
            Me.GetNumerpadValue(5)
        End Sub

        Private Sub btnTA4_Click(sender As Object, e As System.EventArgs)
            Me.GetNumerpadValue(4)
        End Sub

        Private Sub btnTA3_Click(sender As Object, e As System.EventArgs)
            Me.GetNumerpadValue(3)
        End Sub

        Private Sub btnTA2_Click(sender As Object, e As System.EventArgs)
            Me.GetNumerpadValue(2)
        End Sub

        Private Sub btnTA1_Click(sender As Object, e As System.EventArgs)
            Me.GetNumerpadValue(1)
        End Sub

        Private Sub Cancel_MouseHover(sender As Object, e As System.EventArgs)
            Me.btnCancel.BackColor = System.Drawing.Color.Red
        End Sub

        Private Sub Cancel_MouseLeave(sender As Object, e As System.EventArgs)
            Me.btnCancel.BackColor = System.Drawing.Color.Transparent
        End Sub

        Private Sub btnForgetPassword_MouseHover(sender As Object, e As System.EventArgs)
            Me.btnForgetPassword.BackColor = System.Drawing.Color.Blue
        End Sub

        Private Sub btnForgetPassword_MouseLeave(sender As Object, e As System.EventArgs)
            Me.btnForgetPassword.BackColor = System.Drawing.Color.Transparent
        End Sub

        Private Sub btnForgetPassword_Click(sender As Object, e As System.EventArgs)
            MyBase.Hide()
            RestaurantPOS14.My.MyProject.Forms.frmRecoveryPIN.txtEmailID.Text = ""
            Call RestaurantPOS14.My.MyProject.Forms.frmRecoveryPIN.Show()
        End Sub

        Private Sub Password_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs)
            If Me.cmbLoginType.SelectedIndex = 0 Then
                If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.Password.Text, "ENTER PIN", TextCompare:=False) = 0 Then
                    Me.Password.Text = ""
                End If

                Me.Password.PasswordChar = "•"c
            End If

            If Me.cmbLoginType.SelectedIndex = 1 Then
                If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.Password.Text, "SCAN CARD", TextCompare:=False) = 0 Then
                    Me.Password.Text = ""
                End If

                Me.Password.PasswordChar = "•"c
            End If
        End Sub

        Private Sub Password_TextChanged(sender As Object, e As System.EventArgs)
            If Me.cmbLoginType.SelectedIndex = 0 AndAlso Me.Password.Text.Length = 4 Then
                Me.GetData()
            End If

            If Me.cmbLoginType.SelectedIndex = 1 AndAlso Me.Password.Text.Contains("?") Then
                Me.GetCardData()
            End If
        End Sub

        Public Sub GetCardData()
            Dim cardNumber = Me.Password.Text.Replace(";", String.Empty).Replace("?", String.Empty).Replace("%", String.Empty).Trim()
            If cardNumber.Length = 0 OrElse cardNumber.Length > 100 Then
                Me.btnScanCard.PerformClick()
                Return
            End If
            Using connection As New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                connection.Open()
                Using command As New System.Data.SqlClient.SqlCommand("SELECT RTRIM(UserID),RTRIM(UserType) FROM Registration where CardNo=@card and Active='Yes'", connection)
                    command.Parameters.Add("@card", System.Data.SqlDbType.NVarChar, 100).Value = cardNumber
                    Using reader = command.ExecuteReader(System.Data.CommandBehavior.SingleRow)
                        If reader.Read() Then
                            Me.UserID.Text = reader.GetString(0).Trim()
                            Me.UserType.Text = reader.GetString(1).Trim()
                        Else
                            Me.btnScanCard.PerformClick()
                            Return
                        End If
                    End Using
                End Using
            End Using
            Me.ValidatedData()
        End Sub

        Public Sub GetData()
            Try
                Dim throttleKey = System.Environment.MachineName
                Dim waitSeconds As Integer
                If Not RestaurantPOS14.Security.PinSecurity.CanAttempt(throttleKey, waitSeconds) Then
                    Me.Password.PasswordChar = Global.Microsoft.VisualBasic.Strings.ChrW(0)
                    Me.Password.Text = "ENTER PIN"
                    Call System.Windows.Forms.MessageBox.Show("Too many unsuccessful attempts. Try again in " & waitSeconds.ToString() & " seconds.", "Login temporarily locked", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Warning)
                    Return
                End If

                Dim suppliedPin = Me.Password.Text
                RestaurantPOS14.Security.PinSecurity.ValidatePin(suppliedPin)
                Dim matchedUserId As String = Nothing
                Dim matchedUserType As String = Nothing
                Dim matchedStoredPin As String = Nothing
                Dim credentials As New System.Collections.Generic.List(Of LoginCredential)()

                Using connection As New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                    connection.Open()
                    Using command As New System.Data.SqlClient.SqlCommand("SELECT RTRIM(UserID),RTRIM(Password),RTRIM(UserType) FROM Registration where Active='Yes'", connection)
                        Using reader = command.ExecuteReader()
                            While reader.Read()
                                credentials.Add(New LoginCredential With {
                                    .UserId = If(reader.IsDBNull(0), String.Empty, reader.GetString(0).Trim()),
                                    .StoredPin = If(reader.IsDBNull(1), String.Empty, reader.GetString(1).Trim()),
                                    .UserType = If(reader.IsDBNull(2), String.Empty, reader.GetString(2).Trim())
                                })
                            End While
                        End Using
                    End Using

                    Dim matchedCredential = FindMatchingCredential(suppliedPin, credentials)
                    If matchedCredential IsNot Nothing Then
                        matchedUserId = matchedCredential.UserId
                        matchedUserType = matchedCredential.UserType
                        matchedStoredPin = matchedCredential.StoredPin
                    End If

                    If matchedUserId IsNot Nothing AndAlso Not RestaurantPOS14.Security.PinSecurity.IsStrongHash(matchedStoredPin) Then
                        Using upgradeCommand As New System.Data.SqlClient.SqlCommand("UPDATE Registration SET Password=@password WHERE UserID=@userId AND Password=@legacyPassword", connection)
                            upgradeCommand.Parameters.Add("@password", System.Data.SqlDbType.NChar, 50).Value = RestaurantPOS14.Security.PinSecurity.HashPin(suppliedPin)
                            upgradeCommand.Parameters.Add("@userId", System.Data.SqlDbType.NChar, 100).Value = matchedUserId
                            upgradeCommand.Parameters.Add("@legacyPassword", System.Data.SqlDbType.NChar, 50).Value = matchedStoredPin
                            upgradeCommand.ExecuteNonQuery()
                        End Using
                    End If
                End Using

                If matchedUserId IsNot Nothing Then
                    RestaurantPOS14.Security.PinSecurity.ResetFailures(throttleKey)
                    Me.UserID.Text = matchedUserId
                    Me.UserType.Text = matchedUserType
                    Me.ValidatedData()
                Else
                    RestaurantPOS14.Security.PinSecurity.RegisterFailure(throttleKey)
                    Me.Password.PasswordChar = Global.Microsoft.VisualBasic.Strings.ChrW(0)
                    Me.Password.Text = "ENTER PIN"
                End If
            Catch ex As System.Exception
                RestaurantPOS14.Diagnostics.ApplicationDiagnostics.ReportNonFatal("PIN login", ex)
                MetroFramework.MetroMessageBox.Show(Me, "Login could not be completed. Check the database connection and try again.", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Private Shared Function FindMatchingCredential(suppliedPin As String, credentials As System.Collections.Generic.IList(Of LoginCredential)) As LoginCredential
            If credentials Is Nothing OrElse credentials.Count = 0 Then Return Nothing

            ' Legacy PINs are inexpensive to check and should be migrated first.
            For Each credential In credentials
                If Not RestaurantPOS14.Security.PinSecurity.IsStrongHash(credential.StoredPin) AndAlso RestaurantPOS14.Security.PinSecurity.VerifyPin(suppliedPin, credential.StoredPin) Then Return credential
            Next

            ' Every salted PBKDF2 value is intentionally expensive. Verify them in
            ' parallel so login time does not grow linearly with the employee count.
            Dim matches(credentials.Count - 1) As Boolean
            System.Threading.Tasks.Parallel.For(0, credentials.Count, Sub(index)
                Dim credential = credentials(index)
                If RestaurantPOS14.Security.PinSecurity.IsStrongHash(credential.StoredPin) Then
                    matches(index) = RestaurantPOS14.Security.PinSecurity.VerifyPin(suppliedPin, credential.StoredPin)
                End If
            End Sub)

            For index = 0 To credentials.Count - 1
                If matches(index) Then Return credentials(index)
            Next
            Return Nothing
        End Function

        Public Sub ValidatedData()
            RestaurantPOS14.ModFunc.ClearUserRightsCache()
            If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.UserType.Text, "Cashier", TextCompare:=False) = 0 Then
                Dim frontOffice = RestaurantPOS14.My.MyProject.Forms.frmFrontOffice
                frontOffice.lblUser.Text = Me.UserID.Text
                Dim st As String = "Successfully logged in"
                MyBase.Hide()
                frontOffice.btnOpenCashDrawer.Enabled = False
                frontOffice.btnPOS.Enabled = True
                frontOffice.btnClockOut.Enabled = True
                frontOffice.btnKitchenDisplay.Enabled = True
                frontOffice.btnWorkPeriod.Enabled = True
                frontOffice.btnReport.Enabled = True
                frontOffice.lblUserType.Text = Me.UserType.Text
                frontOffice.lblUser.Text = Me.UserID.Text
                frontOffice.Show()
                RestaurantPOS14.ModFunc.LogFuncAsync(Me.UserID.Text, st)
            End If

            If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.UserType.Text, "Kitchen User", TextCompare:=False) = 0 Then
                Dim frontOffice = RestaurantPOS14.My.MyProject.Forms.frmFrontOffice
                frontOffice.lblUser.Text = Me.UserID.Text
                Dim st2 As String = "Successfully logged in"
                MyBase.Hide()
                frontOffice.btnOpenCashDrawer.Enabled = False
                frontOffice.btnPOS.Enabled = False
                frontOffice.btnClockOut.Enabled = True
                frontOffice.btnWorkPeriod.Enabled = False
                frontOffice.btnKitchenDisplay.Enabled = True
                frontOffice.btnReport.Enabled = False
                frontOffice.lblUserType.Text = Me.UserType.Text
                frontOffice.lblUser.Text = Me.UserID.Text
                frontOffice.Show()
                RestaurantPOS14.ModFunc.LogFuncAsync(Me.UserID.Text, st2)
            End If

            If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.UserType.Text, "Waiter", TextCompare:=False) = 0 Then
                Dim frontOffice = RestaurantPOS14.My.MyProject.Forms.frmFrontOffice
                frontOffice.lblUser.Text = Me.UserID.Text
                Dim st3 As String = "Successfully logged in"
                MyBase.Hide()
                frontOffice.btnOpenCashDrawer.Enabled = False
                frontOffice.btnPOS.Enabled = True
                frontOffice.btnClockOut.Enabled = True
                frontOffice.btnWorkPeriod.Enabled = False
                frontOffice.btnKitchenDisplay.Enabled = False
                frontOffice.btnReport.Enabled = False
                frontOffice.lblUserType.Text = Me.UserType.Text
                frontOffice.lblUser.Text = Me.UserID.Text
                frontOffice.Show()
                RestaurantPOS14.ModFunc.LogFuncAsync(Me.UserID.Text, st3)
            End If

            If (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.UserType.Text, "Store Keeper", TextCompare:=False) = 0) Or (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.UserType.Text, "Inventory Manager", TextCompare:=False) = 0) Then
                If Not RestaurantPOS14.ModFunc.LoadUserRightsCache(Me.UserID.Text) Then
                    MetroFramework.MetroMessageBox.Show(Me, "User Rights are not granted...Please contact super administrator", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
                    Me.Password.PasswordChar = Global.Microsoft.VisualBasic.Strings.ChrW(0)
                    Me.Password.Text = "ENTER PIN"
                    Return
                End If

                Me.frm.lblUser.Text = Me.UserID.Text
                Me.frm.lblUserType.Text = Me.UserType.Text
                Me.frm.btnBackOffice.Enabled = True
                Me.frm.btnFrontOffice.Enabled = False
                Dim st4 As String = "Successfully logged in"
                MyBase.Hide()
                Me.frm.lblUser.Text = Me.UserID.Text
                Me.frm.Show()
                RestaurantPOS14.ModFunc.LogFuncAsync(Me.UserID.Text, st4)
            End If

            If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.UserType.Text, "Super Admin", TextCompare:=False) = 0 Then
                Dim hasUserRights = RestaurantPOS14.ModFunc.LoadUserRightsCache(Me.UserID.Text)
                If Not hasUserRights AndAlso Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.UserID.Text, "sa", TextCompare:=False) <> 0 Then
                    MetroFramework.MetroMessageBox.Show(Me, "User Rights are not granted...Please contact super administrator", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
                    Me.Password.PasswordChar = Global.Microsoft.VisualBasic.Strings.ChrW(0)
                    Me.Password.Text = "ENTER PIN"
                    Return
                End If

                Me.frm.lblUser.Text = Me.UserID.Text
                Me.frm.lblUserType.Text = Me.UserType.Text
                Me.frm.btnBackOffice.Enabled = True
                Me.frm.btnFrontOffice.Enabled = True
                Dim st5 As String = "Successfully logged in"
                MyBase.Hide()
                Me.frm.lblUser.Text = Me.UserID.Text
                Me.frm.Show()
                RestaurantPOS14.ModFunc.LogFuncAsync(Me.UserID.Text, st5)
            End If

            If Not ((Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.UserType.Text, "Admin", TextCompare:=False) = 0) Or (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.UserType.Text, "Store Manager", TextCompare:=False) = 0)) Then
                Return
            End If

            If Not RestaurantPOS14.ModFunc.LoadUserRightsCache(Me.UserID.Text) Then
                MetroFramework.MetroMessageBox.Show(Me, "User Rights are not granted...Please contact super administrator", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
                Me.Password.PasswordChar = Global.Microsoft.VisualBasic.Strings.ChrW(0)
                Me.Password.Text = "ENTER PIN"
                Return
            End If

            Me.frm.lblUser.Text = Me.UserID.Text
            Me.frm.lblUserType.Text = Me.UserType.Text
            Me.frm.btnBackOffice.Enabled = True
            Me.frm.btnFrontOffice.Enabled = True
            Dim st6 As String = "Successfully logged in"
            MyBase.Hide()
            Me.frm.lblUser.Text = Me.UserID.Text
            Me.frm.Show()
            RestaurantPOS14.ModFunc.LogFuncAsync(Me.UserID.Text, st6)
        End Sub

        Private Sub Timer1_Tick(sender As Object, e As System.EventArgs)
            Me.lblDate.Text = System.DateTime.Now.ToString("dddd, dd MMMM yyyy")
            Me.lblTime.Text = System.DateTime.Now.ToString("hh:mm:ss tt")
        End Sub

        Private Sub frmLogin_Shown(sender As Object, e As System.EventArgs)
            Me.Password.Focus()
        End Sub

        Private Sub frmLogin_Activated(sender As Object, e As System.EventArgs)
            Me.Password.[Select]()
        End Sub

        Private Sub cmbLoginType_SelectedIndexChanged(sender As Object, e As System.EventArgs)
            If Me.cmbLoginType.SelectedIndex = 0 Then
                Me.Password.PasswordChar = Global.Microsoft.VisualBasic.Strings.ChrW(0)
                Me.Password.Text = "ENTER PIN"
                Me.Password.Focus()
            End If

            If Me.cmbLoginType.SelectedIndex = 1 Then
                Me.Password.PasswordChar = Global.Microsoft.VisualBasic.Strings.ChrW(0)
                Me.Password.Text = "SCAN CARD"
                Me.Password.Focus()
            End If
        End Sub

        Private Sub btnScanCard_Click(sender As Object, e As System.EventArgs)
            Me.cmbLoginType.SelectedIndex = 1
            If Me.cmbLoginType.SelectedIndex = 1 Then
                Me.Password.PasswordChar = Global.Microsoft.VisualBasic.Strings.ChrW(0)
                Me.Password.Text = "SCAN CARD"
                Me.Password.Focus()
            End If
        End Sub

        Private Sub Password_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs)
            If Me.cmbLoginType.SelectedIndex = 1 AndAlso e.KeyCode = System.Windows.Forms.Keys.[Return] Then
                Me.GetCardData()
            End If
        End Sub

        Private Sub LinkLabel1_LinkClicked(sender As Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
            Call RestaurantPOS14.My.MyProject.Forms.frmSoftwareLicenceRenewal.ShowDialog()
        End Sub

        Private Sub Timer3_Tick(sender As Object, e As System.EventArgs)
            MyBase.Cursor = System.Windows.Forms.Cursors.[Default]
            Me.Timer3.Enabled = False
            Call RestaurantPOS14.My.MyProject.Forms.frmCustomDialogWS.Hide()
        End Sub

        Private Sub LinkLabel2_LinkClicked(sender As Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
            Call RestaurantPOS14.My.MyProject.Forms.frmAbout.ShowDialog()
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
            Dim componentResourceManager As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RestaurantPOS14.frmLogin))
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
            Me.UserID = New System.Windows.Forms.TextBox()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
            Me.txtDBLocation = New System.Windows.Forms.TextBox()
            Me.RadClock1 = New Telerik.WinControls.UI.RadClock()
            Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
            Me.txtCPU_ID = New System.Windows.Forms.TextBox()
            Me.txtActivationID = New System.Windows.Forms.TextBox()
            Me.txtMB_SerialNo = New System.Windows.Forms.TextBox()
            Me.TextBox1 = New System.Windows.Forms.TextBox()
            Me.cmbLoginType = New System.Windows.Forms.ComboBox()
            Me.lblTime = New System.Windows.Forms.Label()
            Me.lblDate = New System.Windows.Forms.Label()
            Me.Panel3 = New System.Windows.Forms.Panel()
            Me.txtDisplayPort = New System.Windows.Forms.TextBox()
            Me.UserType = New System.Windows.Forms.TextBox()
            Me.txtCurrentClockInID = New System.Windows.Forms.TextBox()
            Me.btnForgetPassword = New System.Windows.Forms.Button()
            Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
            Me.btnScanCard = New CButtonLib.CButton()
            Me.btnX = New CButtonLib.CButton()
            Me.btnTA9 = New CButtonLib.CButton()
            Me.btnTA0 = New CButtonLib.CButton()
            Me.btnTA8 = New CButtonLib.CButton()
            Me.btnTA4 = New CButtonLib.CButton()
            Me.btnTA6 = New CButtonLib.CButton()
            Me.btnTA5 = New CButtonLib.CButton()
            Me.btnTA1 = New CButtonLib.CButton()
            Me.btnTA7 = New CButtonLib.CButton()
            Me.btnTA3 = New CButtonLib.CButton()
            Me.btnTA2 = New CButtonLib.CButton()
            Me.Password = New System.Windows.Forms.TextBox()
            Me.btnCancel = New System.Windows.Forms.Button()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.Panel2 = New System.Windows.Forms.Panel()
            Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
            Me.AquaTheme1 = New Telerik.WinControls.Themes.AquaTheme()
            Me.DesertTheme1 = New Telerik.WinControls.Themes.DesertTheme()
            Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
            Me.Panel1.SuspendLayout()
            CType(Me.RadClock1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.TableLayoutPanel3.SuspendLayout()
            Me.Panel2.SuspendLayout()
            MyBase.SuspendLayout()
            Me.UserID.Font = New System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.UserID.ForeColor = System.Drawing.Color.FromArgb(102, 106, 105)
            Dim userID As System.Windows.Forms.TextBox = Me.UserID
            Dim location As System.Drawing.Point = New System.Drawing.Point(3, 3)
            userID.Location = location
            Me.UserID.Name = "UserID"
            Dim userID2 As System.Windows.Forms.TextBox = Me.UserID
            Dim size As System.Drawing.Size = New System.Drawing.Size(33, 35)
            userID2.Size = size
            Me.UserID.TabIndex = 0
            Me.UserID.Visible = False
            Me.Panel1.BackColor = System.Drawing.Color.FromArgb(58, 58, 56)
            Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.Panel1.Controls.Add(Me.LinkLabel2)
            Me.Panel1.Controls.Add(Me.txtDBLocation)
            Me.Panel1.Controls.Add(Me.RadClock1)
            Me.Panel1.Controls.Add(Me.LinkLabel1)
            Me.Panel1.Controls.Add(Me.txtCPU_ID)
            Me.Panel1.Controls.Add(Me.txtActivationID)
            Me.Panel1.Controls.Add(Me.txtMB_SerialNo)
            Me.Panel1.Controls.Add(Me.TextBox1)
            Me.Panel1.Controls.Add(Me.cmbLoginType)
            Me.Panel1.Controls.Add(Me.lblTime)
            Me.Panel1.Controls.Add(Me.lblDate)
            Me.Panel1.Controls.Add(Me.Panel3)
            Me.Panel1.Controls.Add(Me.txtDisplayPort)
            Me.Panel1.Controls.Add(Me.UserID)
            Me.Panel1.Controls.Add(Me.UserType)
            Me.Panel1.Controls.Add(Me.txtCurrentClockInID)
            Me.Panel1.Controls.Add(Me.btnForgetPassword)
            Me.Panel1.Controls.Add(Me.TableLayoutPanel3)
            Me.Panel1.Controls.Add(Me.Password)
            Me.Panel1.Controls.Add(Me.btnCancel)
            Dim panel As System.Windows.Forms.Panel = Me.Panel1
            location = New System.Drawing.Point(1, 53)
            panel.Location = location
            Me.Panel1.Name = "Panel1"
            Dim panel2 As System.Windows.Forms.Panel = Me.Panel1
            size = New System.Drawing.Size(842, 479)
            panel2.Size = size
            Me.Panel1.TabIndex = 0
            Me.LinkLabel2.AutoSize = True
            Me.LinkLabel2.Font = New System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.LinkLabel2.LinkColor = System.Drawing.Color.White
            Dim linkLabel As System.Windows.Forms.LinkLabel = Me.LinkLabel2
            location = New System.Drawing.Point(191, 46)
            linkLabel.Location = location
            Me.LinkLabel2.Name = "LinkLabel2"
            Dim linkLabel2 As System.Windows.Forms.LinkLabel = Me.LinkLabel2
            size = New System.Drawing.Size(79, 21)
            linkLabel2.Size = size
            Me.LinkLabel2.TabIndex = 413
            Me.LinkLabel2.TabStop = True
            Me.LinkLabel2.Text = "Abous Us"
            Me.txtDBLocation.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox As System.Windows.Forms.TextBox = Me.txtDBLocation
            location = New System.Drawing.Point(409, 228)
            textBox.Location = location
            Me.txtDBLocation.Name = "txtDBLocation"
            Me.txtDBLocation.[ReadOnly] = True
            Dim textBox2 As System.Windows.Forms.TextBox = Me.txtDBLocation
            size = New System.Drawing.Size(24, 22)
            textBox2.Size = size
            Me.txtDBLocation.TabIndex = 412
            Me.txtDBLocation.Visible = False
            Dim radClock As Telerik.WinControls.UI.RadClock = Me.RadClock1
            location = New System.Drawing.Point(153, 336)
            radClock.Location = location
            Me.RadClock1.Name = "RadClock1"
            Dim radClock2 As Telerik.WinControls.UI.RadClock = Me.RadClock1
            size = New System.Drawing.Size(134, 135)
            radClock2.Size = size
            Me.RadClock1.TabIndex = 406
            Me.RadClock1.ThemeName = "Desert"
            Me.LinkLabel1.AutoSize = True
            Me.LinkLabel1.Font = New System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.LinkLabel1.LinkColor = System.Drawing.Color.White
            Dim linkLabel3 As System.Windows.Forms.LinkLabel = Me.LinkLabel1
            location = New System.Drawing.Point(191, 20)
            linkLabel3.Location = location
            Me.LinkLabel1.Name = "LinkLabel1"
            Dim linkLabel4 As System.Windows.Forms.LinkLabel = Me.LinkLabel1
            size = New System.Drawing.Size(129, 21)
            linkLabel4.Size = size
            Me.LinkLabel1.TabIndex = 405
            Me.LinkLabel1.TabStop = True
            Me.LinkLabel1.Text = "License Renewal"
            Me.txtCPU_ID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox3 As System.Windows.Forms.TextBox = Me.txtCPU_ID
            location = New System.Drawing.Point(374, 237)
            textBox3.Location = location
            Me.txtCPU_ID.Name = "txtCPU_ID"
            Me.txtCPU_ID.[ReadOnly] = True
            Dim textBox4 As System.Windows.Forms.TextBox = Me.txtCPU_ID
            size = New System.Drawing.Size(10, 22)
            textBox4.Size = size
            Me.txtCPU_ID.TabIndex = 404
            Me.txtCPU_ID.Visible = False
            Me.txtActivationID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtActivationID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox5 As System.Windows.Forms.TextBox = Me.txtActivationID
            location = New System.Drawing.Point(444, 257)
            textBox5.Location = location
            Me.txtActivationID.Name = "txtActivationID"
            Dim textBox6 As System.Windows.Forms.TextBox = Me.txtActivationID
            size = New System.Drawing.Size(24, 22)
            textBox6.Size = size
            Me.txtActivationID.TabIndex = 403
            Me.txtActivationID.Visible = False
            Me.txtMB_SerialNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox7 As System.Windows.Forms.TextBox = Me.txtMB_SerialNo
            location = New System.Drawing.Point(458, 199)
            textBox7.Location = location
            Me.txtMB_SerialNo.Name = "txtMB_SerialNo"
            Me.txtMB_SerialNo.[ReadOnly] = True
            Dim textBox8 As System.Windows.Forms.TextBox = Me.txtMB_SerialNo
            size = New System.Drawing.Size(10, 22)
            textBox8.Size = size
            Me.txtMB_SerialNo.TabIndex = 402
            Me.txtMB_SerialNo.Visible = False
            Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox9 As System.Windows.Forms.TextBox = Me.TextBox1
            location = New System.Drawing.Point(416, 211)
            textBox9.Location = location
            Me.TextBox1.Name = "TextBox1"
            Me.TextBox1.[ReadOnly] = True
            Dim textBox10 As System.Windows.Forms.TextBox = Me.TextBox1
            size = New System.Drawing.Size(24, 22)
            textBox10.Size = size
            Me.TextBox1.TabIndex = 401
            Me.TextBox1.Visible = False
            Me.cmbLoginType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbLoginType.Font = New System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.cmbLoginType.FormattingEnabled = True
            Me.cmbLoginType.Items.AddRange(New Object(1) {"PIN", "CARD"})
            Dim comboBox As System.Windows.Forms.ComboBox = Me.cmbLoginType
            location = New System.Drawing.Point(475, 22)
            comboBox.Location = location
            Me.cmbLoginType.Name = "cmbLoginType"
            Dim comboBox2 As System.Windows.Forms.ComboBox = Me.cmbLoginType
            size = New System.Drawing.Size(118, 45)
            comboBox2.Size = size
            Me.cmbLoginType.TabIndex = 391
            Me.lblTime.BackColor = System.Drawing.Color.Transparent
            Me.lblTime.Font = New System.Drawing.Font("Segoe UI", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.lblTime.ForeColor = System.Drawing.Color.White
            Dim label As System.Windows.Forms.Label = Me.lblTime
            location = New System.Drawing.Point(11, 257)
            label.Location = location
            Me.lblTime.Name = "lblTime"
            Dim label2 As System.Windows.Forms.Label = Me.lblTime
            size = New System.Drawing.Size(443, 73)
            label2.Size = size
            Me.lblTime.TabIndex = 390
            Me.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.lblDate.BackColor = System.Drawing.Color.Transparent
            Me.lblDate.Font = New System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.lblDate.ForeColor = System.Drawing.Color.White
            Dim label3 As System.Windows.Forms.Label = Me.lblDate
            location = New System.Drawing.Point(16, 220)
            label3.Location = location
            Me.lblDate.Name = "lblDate"
            Dim label4 As System.Windows.Forms.Label = Me.lblDate
            size = New System.Drawing.Size(438, 37)
            label4.Size = size
            Me.lblDate.TabIndex = 389
            Me.Panel3.BackColor = System.Drawing.Color.Transparent
            Me.Panel3.BackgroundImage = CType(componentResourceManager.GetObject("Panel3.BackgroundImage"), System.Drawing.Image)
            Me.Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Dim panel3 As System.Windows.Forms.Panel = Me.Panel3
            location = New System.Drawing.Point(16, 20)
            panel3.Location = location
            Me.Panel3.Name = "Panel3"
            Dim panel4 As System.Windows.Forms.Panel = Me.Panel3
            size = New System.Drawing.Size(168, 171)
            panel4.Size = size
            Me.Panel3.TabIndex = 388
            Dim textBox11 As System.Windows.Forms.TextBox = Me.txtDisplayPort
            location = New System.Drawing.Point(11, 14)
            textBox11.Location = location
            Me.txtDisplayPort.Name = "txtDisplayPort"
            Dim textBox12 As System.Windows.Forms.TextBox = Me.txtDisplayPort
            size = New System.Drawing.Size(100, 20)
            textBox12.Size = size
            Me.txtDisplayPort.TabIndex = 1
            Me.txtDisplayPort.Visible = False
            Me.UserType.Font = New System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.UserType.ForeColor = System.Drawing.Color.FromArgb(102, 106, 105)
            Dim userType As System.Windows.Forms.TextBox = Me.UserType
            location = New System.Drawing.Point(0, 2)
            userType.Location = location
            Me.UserType.Name = "UserType"
            Dim userType2 As System.Windows.Forms.TextBox = Me.UserType
            size = New System.Drawing.Size(33, 35)
            userType2.Size = size
            Me.UserType.TabIndex = 16
            Me.UserType.Visible = False
            Dim textBox13 As System.Windows.Forms.TextBox = Me.txtCurrentClockInID
            location = New System.Drawing.Point(0, 17)
            textBox13.Location = location
            Me.txtCurrentClockInID.Name = "txtCurrentClockInID"
            Dim textBox14 As System.Windows.Forms.TextBox = Me.txtCurrentClockInID
            size = New System.Drawing.Size(10, 20)
            textBox14.Size = size
            Me.txtCurrentClockInID.TabIndex = 23
            Me.txtCurrentClockInID.Visible = False
            Me.btnForgetPassword.BackColor = System.Drawing.Color.Transparent
            Me.btnForgetPassword.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.btnForgetPassword.FlatAppearance.BorderSize = 0
            Me.btnForgetPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnForgetPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnForgetPassword.ForeColor = System.Drawing.Color.White
            Me.btnForgetPassword.Image = CType(componentResourceManager.GetObject("btnForgetPassword.Image"), System.Drawing.Image)
            Dim button As System.Windows.Forms.Button = Me.btnForgetPassword
            location = New System.Drawing.Point(634, 384)
            button.Location = location
            Me.btnForgetPassword.Name = "btnForgetPassword"
            Dim button2 As System.Windows.Forms.Button = Me.btnForgetPassword
            size = New System.Drawing.Size(85, 72)
            button2.Size = size
            Me.btnForgetPassword.TabIndex = 386
            Me.btnForgetPassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnForgetPassword.UseVisualStyleBackColor = False
            Me.TableLayoutPanel3.BackColor = System.Drawing.Color.Transparent
            Me.TableLayoutPanel3.ColumnCount = 3
            Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F))
            Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F))
            Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F))
            Me.TableLayoutPanel3.Controls.Add(Me.btnScanCard, 2, 3)
            Me.TableLayoutPanel3.Controls.Add(Me.btnX, 0, 3)
            Me.TableLayoutPanel3.Controls.Add(Me.btnTA9, 2, 2)
            Me.TableLayoutPanel3.Controls.Add(Me.btnTA0, 1, 3)
            Me.TableLayoutPanel3.Controls.Add(Me.btnTA8, 1, 2)
            Me.TableLayoutPanel3.Controls.Add(Me.btnTA4, 0, 1)
            Me.TableLayoutPanel3.Controls.Add(Me.btnTA6, 2, 1)
            Me.TableLayoutPanel3.Controls.Add(Me.btnTA5, 1, 1)
            Me.TableLayoutPanel3.Controls.Add(Me.btnTA1, 0, 0)
            Me.TableLayoutPanel3.Controls.Add(Me.btnTA7, 0, 2)
            Me.TableLayoutPanel3.Controls.Add(Me.btnTA3, 2, 0)
            Me.TableLayoutPanel3.Controls.Add(Me.btnTA2, 1, 0)
            Dim tableLayoutPanel As System.Windows.Forms.TableLayoutPanel = Me.TableLayoutPanel3
            location = New System.Drawing.Point(472, 72)
            tableLayoutPanel.Location = location
            Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
            Me.TableLayoutPanel3.RowCount = 4
            Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F))
            Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.25952F))
            Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.56747F))
            Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F))
            Dim tableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel = Me.TableLayoutPanel3
            size = New System.Drawing.Size(341, 289)
            tableLayoutPanel2.Size = size
            Me.TableLayoutPanel3.TabIndex = 385
            Me.btnScanCard.BackColor = System.Drawing.Color.Transparent
            Me.btnScanCard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.btnScanCard.BorderColor = System.Drawing.Color.Transparent
            cBlendItems.iColor = New System.Drawing.Color(2) {System.Drawing.Color.Green, System.Drawing.Color.Green, System.Drawing.Color.Green}
            cBlendItems.iPoint = New Single(2) {0F, 0.5F, 1F}
            Me.btnScanCard.ColorFillBlend = cBlendItems
            Me.btnScanCard.Corners.All = 3
            Me.btnScanCard.Corners.LowerLeft = 3
            Me.btnScanCard.Corners.LowerRight = 3
            Me.btnScanCard.Corners.UpperLeft = 3
            Me.btnScanCard.Corners.UpperRight = 3
            Me.btnScanCard.DesignerSelected = False
            Me.btnScanCard.Dock = System.Windows.Forms.DockStyle.Fill
            Me.btnScanCard.Font = New System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnScanCard.ImageIndex = 0
            Dim cButton As CButtonLib.CButton = Me.btnScanCard
            location = New System.Drawing.Point(227, 217)
            cButton.Location = location
            Dim cButton2 As CButtonLib.CButton = Me.btnScanCard
            Dim margin As System.Windows.Forms.Padding = New System.Windows.Forms.Padding(1)
            cButton2.Margin = margin
            Me.btnScanCard.Name = "btnScanCard"
            Dim cButton3 As CButtonLib.CButton = Me.btnScanCard
            size = New System.Drawing.Size(113, 71)
            cButton3.Size = size
            Me.btnScanCard.TabIndex = 391
            Me.btnScanCard.Text = "SCAN CARD"
            Me.btnScanCard.TextShadowShow = False
            Me.btnScanCard.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit
            Me.btnX.BackColor = System.Drawing.Color.Transparent
            Me.btnX.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.btnX.BorderColor = System.Drawing.Color.Transparent
            cBlendItems2.iColor = New System.Drawing.Color(2) {System.Drawing.Color.Crimson, System.Drawing.Color.Crimson, System.Drawing.Color.Crimson}
            cBlendItems2.iPoint = New Single(2) {0F, 0.5F, 1F}
            Me.btnX.ColorFillBlend = cBlendItems2
            Me.btnX.Corners.All = 3
            Me.btnX.Corners.LowerLeft = 3
            Me.btnX.Corners.LowerRight = 3
            Me.btnX.Corners.UpperLeft = 3
            Me.btnX.Corners.UpperRight = 3
            Me.btnX.DesignerSelected = False
            Me.btnX.Dock = System.Windows.Forms.DockStyle.Fill
            Me.btnX.Font = New System.Drawing.Font("Segoe UI Black", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnX.ImageIndex = 0
            Dim cButton4 As CButtonLib.CButton = Me.btnX
            location = New System.Drawing.Point(1, 217)
            cButton4.Location = location
            Dim cButton5 As CButtonLib.CButton = Me.btnX
            margin = New System.Windows.Forms.Padding(1)
            cButton5.Margin = margin
            Me.btnX.Name = "btnX"
            Dim cButton6 As CButtonLib.CButton = Me.btnX
            size = New System.Drawing.Size(111, 71)
            cButton6.Size = size
            Me.btnX.TabIndex = 31
            Me.btnX.Text = "-->"
            Me.btnX.TextShadowShow = False
            Me.btnX.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit
            Me.btnTA9.BackColor = System.Drawing.Color.Transparent
            Me.btnTA9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.btnTA9.BorderColor = System.Drawing.Color.Transparent
            cBlendItems3.iColor = New System.Drawing.Color(2) {System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105)}
            cBlendItems3.iPoint = New Single(2) {0F, 0.5F, 1F}
            Me.btnTA9.ColorFillBlend = cBlendItems3
            Me.btnTA9.Corners.All = 3
            Me.btnTA9.Corners.LowerLeft = 3
            Me.btnTA9.Corners.LowerRight = 3
            Me.btnTA9.Corners.UpperLeft = 3
            Me.btnTA9.Corners.UpperRight = 3
            Me.btnTA9.DesignerSelected = False
            Me.btnTA9.Dock = System.Windows.Forms.DockStyle.Fill
            Me.btnTA9.Font = New System.Drawing.Font("Segoe UI Black", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnTA9.ImageIndex = 0
            Dim cButton7 As CButtonLib.CButton = Me.btnTA9
            location = New System.Drawing.Point(227, 146)
            cButton7.Location = location
            Dim cButton8 As CButtonLib.CButton = Me.btnTA9
            margin = New System.Windows.Forms.Padding(1)
            cButton8.Margin = margin
            Me.btnTA9.Name = "btnTA9"
            Dim cButton9 As CButtonLib.CButton = Me.btnTA9
            size = New System.Drawing.Size(113, 69)
            cButton9.Size = size
            Me.btnTA9.TabIndex = 15
            Me.btnTA9.Text = "9"
            Me.btnTA9.TextShadowShow = False
            Me.btnTA9.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit
            Me.btnTA0.BackColor = System.Drawing.Color.Transparent
            Me.btnTA0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.btnTA0.BorderColor = System.Drawing.Color.Transparent
            cBlendItems4.iColor = New System.Drawing.Color(2) {System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105)}
            cBlendItems4.iPoint = New Single(2) {0F, 0.5F, 1F}
            Me.btnTA0.ColorFillBlend = cBlendItems4
            Me.btnTA0.Corners.All = 3
            Me.btnTA0.Corners.LowerLeft = 3
            Me.btnTA0.Corners.LowerRight = 3
            Me.btnTA0.Corners.UpperLeft = 3
            Me.btnTA0.Corners.UpperRight = 3
            Me.btnTA0.DesignerSelected = False
            Me.btnTA0.Dock = System.Windows.Forms.DockStyle.Fill
            Me.btnTA0.Font = New System.Drawing.Font("Segoe UI Black", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnTA0.ImageIndex = 0
            Dim cButton10 As CButtonLib.CButton = Me.btnTA0
            location = New System.Drawing.Point(114, 217)
            cButton10.Location = location
            Dim cButton11 As CButtonLib.CButton = Me.btnTA0
            margin = New System.Windows.Forms.Padding(1)
            cButton11.Margin = margin
            Me.btnTA0.Name = "btnTA0"
            Dim cButton12 As CButtonLib.CButton = Me.btnTA0
            size = New System.Drawing.Size(111, 71)
            cButton12.Size = size
            Me.btnTA0.TabIndex = 17
            Me.btnTA0.Text = "0"
            Me.btnTA0.TextShadowShow = False
            Me.btnTA0.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit
            Me.btnTA8.BackColor = System.Drawing.Color.Transparent
            Me.btnTA8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.btnTA8.BorderColor = System.Drawing.Color.Transparent
            cBlendItems5.iColor = New System.Drawing.Color(2) {System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105)}
            cBlendItems5.iPoint = New Single(2) {0F, 0.5F, 1F}
            Me.btnTA8.ColorFillBlend = cBlendItems5
            Me.btnTA8.Corners.All = 3
            Me.btnTA8.Corners.LowerLeft = 3
            Me.btnTA8.Corners.LowerRight = 3
            Me.btnTA8.Corners.UpperLeft = 3
            Me.btnTA8.Corners.UpperRight = 3
            Me.btnTA8.DesignerSelected = False
            Me.btnTA8.Dock = System.Windows.Forms.DockStyle.Fill
            Me.btnTA8.Font = New System.Drawing.Font("Segoe UI Black", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnTA8.ImageIndex = 0
            Dim cButton13 As CButtonLib.CButton = Me.btnTA8
            location = New System.Drawing.Point(114, 146)
            cButton13.Location = location
            Dim cButton14 As CButtonLib.CButton = Me.btnTA8
            margin = New System.Windows.Forms.Padding(1)
            cButton14.Margin = margin
            Me.btnTA8.Name = "btnTA8"
            Dim cButton15 As CButtonLib.CButton = Me.btnTA8
            size = New System.Drawing.Size(111, 69)
            cButton15.Size = size
            Me.btnTA8.TabIndex = 14
            Me.btnTA8.Text = "8"
            Me.btnTA8.TextShadowShow = False
            Me.btnTA8.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit
            Me.btnTA4.BackColor = System.Drawing.Color.Transparent
            Me.btnTA4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.btnTA4.BorderColor = System.Drawing.Color.Transparent
            cBlendItems6.iColor = New System.Drawing.Color(2) {System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105)}
            cBlendItems6.iPoint = New Single(2) {0F, 0.5F, 1F}
            Me.btnTA4.ColorFillBlend = cBlendItems6
            Me.btnTA4.Corners.All = 3
            Me.btnTA4.Corners.LowerLeft = 3
            Me.btnTA4.Corners.LowerRight = 3
            Me.btnTA4.Corners.UpperLeft = 3
            Me.btnTA4.Corners.UpperRight = 3
            Me.btnTA4.DesignerSelected = False
            Me.btnTA4.Dock = System.Windows.Forms.DockStyle.Fill
            Me.btnTA4.Font = New System.Drawing.Font("Segoe UI Black", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnTA4.ImageIndex = 0
            Dim cButton16 As CButtonLib.CButton = Me.btnTA4
            location = New System.Drawing.Point(1, 73)
            cButton16.Location = location
            Dim cButton17 As CButtonLib.CButton = Me.btnTA4
            margin = New System.Windows.Forms.Padding(1)
            cButton17.Margin = margin
            Me.btnTA4.Name = "btnTA4"
            Dim cButton18 As CButtonLib.CButton = Me.btnTA4
            size = New System.Drawing.Size(111, 71)
            cButton18.Size = size
            Me.btnTA4.TabIndex = 30
            Me.btnTA4.Text = "4"
            Me.btnTA4.TextShadowShow = False
            Me.btnTA4.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit
            Me.btnTA6.BackColor = System.Drawing.Color.Transparent
            Me.btnTA6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.btnTA6.BorderColor = System.Drawing.Color.Transparent
            cBlendItems7.iColor = New System.Drawing.Color(2) {System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105)}
            cBlendItems7.iPoint = New Single(2) {0F, 0.5F, 1F}
            Me.btnTA6.ColorFillBlend = cBlendItems7
            Me.btnTA6.Corners.All = 3
            Me.btnTA6.Corners.LowerLeft = 3
            Me.btnTA6.Corners.LowerRight = 3
            Me.btnTA6.Corners.UpperLeft = 3
            Me.btnTA6.Corners.UpperRight = 3
            Me.btnTA6.DesignerSelected = False
            Me.btnTA6.Dock = System.Windows.Forms.DockStyle.Fill
            Me.btnTA6.Font = New System.Drawing.Font("Segoe UI Black", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnTA6.ImageIndex = 0
            Dim cButton19 As CButtonLib.CButton = Me.btnTA6
            location = New System.Drawing.Point(227, 73)
            cButton19.Location = location
            Dim cButton20 As CButtonLib.CButton = Me.btnTA6
            margin = New System.Windows.Forms.Padding(1)
            cButton20.Margin = margin
            Me.btnTA6.Name = "btnTA6"
            Dim cButton21 As CButtonLib.CButton = Me.btnTA6
            size = New System.Drawing.Size(113, 71)
            cButton21.Size = size
            Me.btnTA6.TabIndex = 12
            Me.btnTA6.Text = "6"
            Me.btnTA6.TextShadowShow = False
            Me.btnTA6.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit
            Me.btnTA5.BackColor = System.Drawing.Color.Transparent
            Me.btnTA5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.btnTA5.BorderColor = System.Drawing.Color.Transparent
            cBlendItems8.iColor = New System.Drawing.Color(2) {System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105)}
            cBlendItems8.iPoint = New Single(2) {0F, 0.5F, 1F}
            Me.btnTA5.ColorFillBlend = cBlendItems8
            Me.btnTA5.Corners.All = 3
            Me.btnTA5.Corners.LowerLeft = 3
            Me.btnTA5.Corners.LowerRight = 3
            Me.btnTA5.Corners.UpperLeft = 3
            Me.btnTA5.Corners.UpperRight = 3
            Me.btnTA5.DesignerSelected = False
            Me.btnTA5.Dock = System.Windows.Forms.DockStyle.Fill
            Me.btnTA5.Font = New System.Drawing.Font("Segoe UI Black", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnTA5.ImageIndex = 0
            Dim cButton22 As CButtonLib.CButton = Me.btnTA5
            location = New System.Drawing.Point(114, 73)
            cButton22.Location = location
            Dim cButton23 As CButtonLib.CButton = Me.btnTA5
            margin = New System.Windows.Forms.Padding(1)
            cButton23.Margin = margin
            Me.btnTA5.Name = "btnTA5"
            Dim cButton24 As CButtonLib.CButton = Me.btnTA5
            size = New System.Drawing.Size(111, 71)
            cButton24.Size = size
            Me.btnTA5.TabIndex = 11
            Me.btnTA5.Text = "5"
            Me.btnTA5.TextShadowShow = False
            Me.btnTA5.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit
            Me.btnTA1.BackColor = System.Drawing.Color.Transparent
            Me.btnTA1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.btnTA1.BorderColor = System.Drawing.Color.Transparent
            cBlendItems9.iColor = New System.Drawing.Color(2) {System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105)}
            cBlendItems9.iPoint = New Single(2) {0F, 0.5F, 1F}
            Me.btnTA1.ColorFillBlend = cBlendItems9
            Me.btnTA1.Corners.All = 3
            Me.btnTA1.Corners.LowerLeft = 3
            Me.btnTA1.Corners.LowerRight = 3
            Me.btnTA1.Corners.UpperLeft = 3
            Me.btnTA1.Corners.UpperRight = 3
            Me.btnTA1.DesignerSelected = False
            Me.btnTA1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.btnTA1.Font = New System.Drawing.Font("Segoe UI Black", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnTA1.ImageIndex = 0
            Dim cButton25 As CButtonLib.CButton = Me.btnTA1
            location = New System.Drawing.Point(1, 1)
            cButton25.Location = location
            Dim cButton26 As CButtonLib.CButton = Me.btnTA1
            margin = New System.Windows.Forms.Padding(1)
            cButton26.Margin = margin
            Me.btnTA1.Name = "btnTA1"
            Dim cButton27 As CButtonLib.CButton = Me.btnTA1
            size = New System.Drawing.Size(111, 70)
            cButton27.Size = size
            Me.btnTA1.TabIndex = 7
            Me.btnTA1.Text = "1"
            Me.btnTA1.TextShadowShow = False
            Me.btnTA1.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit
            Me.btnTA7.BackColor = System.Drawing.Color.Transparent
            Me.btnTA7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.btnTA7.BorderColor = System.Drawing.Color.Transparent
            cBlendItems10.iColor = New System.Drawing.Color(2) {System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105)}
            cBlendItems10.iPoint = New Single(2) {0F, 0.5F, 1F}
            Me.btnTA7.ColorFillBlend = cBlendItems10
            Me.btnTA7.Corners.All = 3
            Me.btnTA7.Corners.LowerLeft = 3
            Me.btnTA7.Corners.LowerRight = 3
            Me.btnTA7.Corners.UpperLeft = 3
            Me.btnTA7.Corners.UpperRight = 3
            Me.btnTA7.DesignerSelected = False
            Me.btnTA7.Dock = System.Windows.Forms.DockStyle.Fill
            Me.btnTA7.Font = New System.Drawing.Font("Segoe UI Black", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnTA7.ImageIndex = 0
            Dim cButton28 As CButtonLib.CButton = Me.btnTA7
            location = New System.Drawing.Point(1, 146)
            cButton28.Location = location
            Dim cButton29 As CButtonLib.CButton = Me.btnTA7
            margin = New System.Windows.Forms.Padding(1)
            cButton29.Margin = margin
            Me.btnTA7.Name = "btnTA7"
            Dim cButton30 As CButtonLib.CButton = Me.btnTA7
            size = New System.Drawing.Size(111, 69)
            cButton30.Size = size
            Me.btnTA7.TabIndex = 13
            Me.btnTA7.Text = "7"
            Me.btnTA7.TextShadowShow = False
            Me.btnTA7.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit
            Me.btnTA3.BackColor = System.Drawing.Color.Transparent
            Me.btnTA3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.btnTA3.BorderColor = System.Drawing.Color.Transparent
            cBlendItems11.iColor = New System.Drawing.Color(2) {System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105)}
            cBlendItems11.iPoint = New Single(2) {0F, 0.5F, 1F}
            Me.btnTA3.ColorFillBlend = cBlendItems11
            Me.btnTA3.Corners.All = 3
            Me.btnTA3.Corners.LowerLeft = 3
            Me.btnTA3.Corners.LowerRight = 3
            Me.btnTA3.Corners.UpperLeft = 3
            Me.btnTA3.Corners.UpperRight = 3
            Me.btnTA3.DesignerSelected = False
            Me.btnTA3.Dock = System.Windows.Forms.DockStyle.Fill
            Me.btnTA3.Font = New System.Drawing.Font("Segoe UI Black", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnTA3.ImageIndex = 0
            Dim cButton31 As CButtonLib.CButton = Me.btnTA3
            location = New System.Drawing.Point(227, 1)
            cButton31.Location = location
            Dim cButton32 As CButtonLib.CButton = Me.btnTA3
            margin = New System.Windows.Forms.Padding(1)
            cButton32.Margin = margin
            Me.btnTA3.Name = "btnTA3"
            Dim cButton33 As CButtonLib.CButton = Me.btnTA3
            size = New System.Drawing.Size(113, 70)
            cButton33.Size = size
            Me.btnTA3.TabIndex = 9
            Me.btnTA3.Text = "3"
            Me.btnTA3.TextShadowShow = False
            Me.btnTA3.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit
            Me.btnTA2.BackColor = System.Drawing.Color.Transparent
            Me.btnTA2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.btnTA2.BorderColor = System.Drawing.Color.Transparent
            cBlendItems12.iColor = New System.Drawing.Color(2) {System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105)}
            cBlendItems12.iPoint = New Single(2) {0F, 0.5F, 1F}
            Me.btnTA2.ColorFillBlend = cBlendItems12
            Me.btnTA2.Corners.All = 3
            Me.btnTA2.Corners.LowerLeft = 3
            Me.btnTA2.Corners.LowerRight = 3
            Me.btnTA2.Corners.UpperLeft = 3
            Me.btnTA2.Corners.UpperRight = 3
            Me.btnTA2.DesignerSelected = False
            Me.btnTA2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.btnTA2.Font = New System.Drawing.Font("Segoe UI Black", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnTA2.ImageIndex = 0
            Dim cButton34 As CButtonLib.CButton = Me.btnTA2
            location = New System.Drawing.Point(114, 1)
            cButton34.Location = location
            Dim cButton35 As CButtonLib.CButton = Me.btnTA2
            margin = New System.Windows.Forms.Padding(1)
            cButton35.Margin = margin
            Me.btnTA2.Name = "btnTA2"
            Dim cButton36 As CButtonLib.CButton = Me.btnTA2
            size = New System.Drawing.Size(111, 70)
            cButton36.Size = size
            Me.btnTA2.TabIndex = 8
            Me.btnTA2.Text = "2"
            Me.btnTA2.TextShadowShow = False
            Me.btnTA2.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit
            Me.Password.BackColor = System.Drawing.Color.White
            Me.Password.Font = New System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.Password.ForeColor = System.Drawing.Color.MidnightBlue
            Dim password As System.Windows.Forms.TextBox = Me.Password
            location = New System.Drawing.Point(596, 21)
            password.Location = location
            Me.Password.Name = "Password"
            Dim password2 As System.Windows.Forms.TextBox = Me.Password
            size = New System.Drawing.Size(214, 46)
            password2.Size = size
            Me.Password.TabIndex = 0
            Me.Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            Me.btnCancel.BackColor = System.Drawing.Color.Transparent
            Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.btnCancel.FlatAppearance.BorderSize = 0
            Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnCancel.ForeColor = System.Drawing.Color.White
            Me.btnCancel.Image = CType(componentResourceManager.GetObject("btnCancel.Image"), System.Drawing.Image)
            Dim button3 As System.Windows.Forms.Button = Me.btnCancel
            location = New System.Drawing.Point(560, 386)
            button3.Location = location
            Me.btnCancel.Name = "btnCancel"
            Dim button4 As System.Windows.Forms.Button = Me.btnCancel
            size = New System.Drawing.Size(77, 72)
            button4.Size = size
            Me.btnCancel.TabIndex = 0
            Me.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnCancel.UseVisualStyleBackColor = False
            Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right
            Me.Label1.BackColor = System.Drawing.Color.FromArgb(58, 58, 56)
            Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.Label1.ForeColor = System.Drawing.Color.White
            Dim label5 As System.Windows.Forms.Label = Me.Label1
            location = New System.Drawing.Point(0, 5)
            label5.Location = location
            Me.Label1.Name = "Label1"
            Dim label6 As System.Windows.Forms.Label = Me.Label1
            size = New System.Drawing.Size(842, 37)
            label6.Size = size
            Me.Label1.TabIndex = 0
            Me.Label1.Text = "Restaurant POS Login"
            Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            Me.Panel2.BackColor = System.Drawing.Color.FromArgb(58, 58, 56)
            Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.Panel2.Controls.Add(Me.Label1)
            Dim panel5 As System.Windows.Forms.Panel = Me.Panel2
            location = New System.Drawing.Point(1, 2)
            panel5.Location = location
            Me.Panel2.Name = "Panel2"
            Dim panel6 As System.Windows.Forms.Panel = Me.Panel2
            size = New System.Drawing.Size(842, 47)
            panel6.Size = size
            Me.Panel2.TabIndex = 3
            Me.Timer1.Enabled = True
            Dim autoScaleDimensions As System.Drawing.SizeF = New System.Drawing.SizeF(6F, 13F)
            MyBase.AutoScaleDimensions = autoScaleDimensions
            MyBase.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.SystemColors.Info
            MyBase.CancelButton = Me.btnCancel
            size = New System.Drawing.Size(844, 533)
            MyBase.ClientSize = size
            MyBase.Controls.Add(Me.Panel2)
            MyBase.Controls.Add(Me.Panel1)
            MyBase.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            MyBase.Icon = CType(componentResourceManager.GetObject("$this.Icon"), System.Drawing.Icon)
            MyBase.MaximizeBox = False
            MyBase.MinimizeBox = False
            MyBase.Name = "frmLogin"
            MyBase.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
            MyBase.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Login Form"
            Me.Panel1.ResumeLayout(False)
            Me.Panel1.PerformLayout()
            CType(Me.RadClock1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.TableLayoutPanel3.ResumeLayout(False)
            Me.Panel2.ResumeLayout(False)
            MyBase.ResumeLayout(False)
        End Sub
    End Class
End Namespace

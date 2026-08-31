Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Management
Imports System.Net
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports RestaurantPOS14.My

Namespace RestaurantPOS14

    <Microsoft.VisualBasic.CompilerServices.DesignerGeneratedAttribute>
    Public Class frmSystemInfo
        Inherits System.Windows.Forms.Form
        Private Shared __ENCList As System.Collections.Generic.List(Of System.WeakReference) = New System.Collections.Generic.List(Of System.WeakReference)()
        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("MenuStrip1")>
        Private _MenuStrip1 As System.Windows.Forms.MenuStrip
        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("FileToolStripMenuItem")>
        Private _FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("SaveToFileToolStripMenuItem")>
        Private _SaveToFileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("ToolStripMenuItem1")>
        Private _ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("ExitToolStripMenuItem")>
        Private _ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("SaveFileDialog1")>
        Private _SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("TabControl1")>
        Private _TabControl1 As System.Windows.Forms.TabControl
        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("TabPage1")>
        Private _TabPage1 As System.Windows.Forms.TabPage
        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("TabPage2")>
        Private _TabPage2 As System.Windows.Forms.TabPage
        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtProcessorFamily")>
        Private _txtProcessorFamily As System.Windows.Forms.TextBox
        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtProcessorExtClock")>
        Private _txtProcessorExtClock As System.Windows.Forms.TextBox
        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label9")>
        Private _Label9 As System.Windows.Forms.Label
        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label8")>
        Private _Label8 As System.Windows.Forms.Label
        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label7")>
        Private _Label7 As System.Windows.Forms.Label
        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtProcessorClockSpeed")>
        Private _txtProcessorClockSpeed As System.Windows.Forms.TextBox
        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtProcessorDataWidth")>
        Private _txtProcessorDataWidth As System.Windows.Forms.TextBox
        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label6")>
        Private _Label6 As System.Windows.Forms.Label
        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label5")>
        Private _Label5 As System.Windows.Forms.Label
        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtProcessorL2CacheSize")>
        Private _txtProcessorL2CacheSize As System.Windows.Forms.TextBox
        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtProcessorManufacturer")>
        Private _txtProcessorManufacturer As System.Windows.Forms.TextBox
        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label4")>
        Private _Label4 As System.Windows.Forms.Label
        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtProcessorDescription")>
        Private _txtProcessorDescription As System.Windows.Forms.TextBox
        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label3")>
        Private _Label3 As System.Windows.Forms.Label
        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtProcessorID")>
        Private _txtProcessorID As System.Windows.Forms.TextBox
        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label2")>
        Private _Label2 As System.Windows.Forms.Label
        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtProcessorName")>
        Private _txtProcessorName As System.Windows.Forms.TextBox
        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label1")>
        Private _Label1 As System.Windows.Forms.Label
        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtBoardSerialNumber")>
        Private _txtBoardSerialNumber As System.Windows.Forms.TextBox
        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label13")>
        Private _Label13 As System.Windows.Forms.Label
        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtBoardDescription")>
        Private _txtBoardDescription As System.Windows.Forms.TextBox
        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label12")>
        Private _Label12 As System.Windows.Forms.Label
        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtBoardManufacturer")>
        Private _txtBoardManufacturer As System.Windows.Forms.TextBox
        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label11")>
        Private _Label11 As System.Windows.Forms.Label
        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtBoardName")>
        Private _txtBoardName As System.Windows.Forms.TextBox
        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label10")>
        Private _Label10 As System.Windows.Forms.Label
        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("TabPage3")>
        Private _TabPage3 As System.Windows.Forms.TabPage
        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label22")>
        Private _Label22 As System.Windows.Forms.Label
        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label20")>
        Private _Label20 As System.Windows.Forms.Label
        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label18")>
        Private _Label18 As System.Windows.Forms.Label
        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label16")>
        Private _Label16 As System.Windows.Forms.Label
        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label23")>
        Private _Label23 As System.Windows.Forms.Label
        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label25")>
        Private _Label25 As System.Windows.Forms.Label
        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label27")>
        Private _Label27 As System.Windows.Forms.Label
        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label32")>
        Private _Label32 As System.Windows.Forms.Label
        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label33")>
        Private _Label33 As System.Windows.Forms.Label
        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label34")>
        Private _Label34 As System.Windows.Forms.Label
        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label35")>
        Private _Label35 As System.Windows.Forms.Label
        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("TextBox11")>
        Private _TextBox11 As System.Windows.Forms.TextBox
        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("TextBox10")>
        Private _TextBox10 As System.Windows.Forms.TextBox
        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("TextBox9")>
        Private _TextBox9 As System.Windows.Forms.TextBox
        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("TextBox8")>
        Private _TextBox8 As System.Windows.Forms.TextBox
        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("TextBox7")>
        Private _TextBox7 As System.Windows.Forms.TextBox
        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("TextBox6")>
        Private _TextBox6 As System.Windows.Forms.TextBox
        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("TextBox5")>
        Private _TextBox5 As System.Windows.Forms.TextBox
        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("TextBox4")>
        Private _TextBox4 As System.Windows.Forms.TextBox
        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("TextBox3")>
        Private _TextBox3 As System.Windows.Forms.TextBox
        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("TextBox2")>
        Private _TextBox2 As System.Windows.Forms.TextBox
        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("TextBox1")>
        Private _TextBox1 As System.Windows.Forms.TextBox
        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("TextBox12")>
        Private _TextBox12 As System.Windows.Forms.TextBox
        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label14")>
        Private _Label14 As System.Windows.Forms.Label
        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Timer1")>
        Private _Timer1 As System.Windows.Forms.Timer
        Private hostname As String
        Private ipaddress As String
        Private h As System.Net.IPHostEntry
        Private mc As System.Management.ManagementClass
        Private mo As System.Management.ManagementObject
        Private components As System.ComponentModel.IContainer
        Friend Overridable Property MenuStrip1 As System.Windows.Forms.MenuStrip
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._MenuStrip1
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.MenuStrip)
                Me._MenuStrip1 = value
            End Set
        End Property

        Friend Overridable Property FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._FileToolStripMenuItem
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.ToolStripMenuItem)
                Me._FileToolStripMenuItem = value
            End Set
        End Property

        Friend Overridable Property SaveToFileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._SaveToFileToolStripMenuItem
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.ToolStripMenuItem)
                Dim value2 As System.EventHandler = AddressOf Me.SaveToFileToolStripMenuItem_Click
                If Me._SaveToFileToolStripMenuItem IsNot Nothing Then
                    RemoveHandler Me._SaveToFileToolStripMenuItem.Click, value2
                End If

                Me._SaveToFileToolStripMenuItem = value
                If Me._SaveToFileToolStripMenuItem IsNot Nothing Then
                    AddHandler Me._SaveToFileToolStripMenuItem.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._ToolStripMenuItem1
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.ToolStripSeparator)
                Me._ToolStripMenuItem1 = value
            End Set
        End Property

        Friend Overridable Property ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._ExitToolStripMenuItem
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.ToolStripMenuItem)
                Dim value2 As System.EventHandler = AddressOf Me.ExitToolStripMenuItem_Click
                If Me._ExitToolStripMenuItem IsNot Nothing Then
                    RemoveHandler Me._ExitToolStripMenuItem.Click, value2
                End If

                Me._ExitToolStripMenuItem = value
                If Me._ExitToolStripMenuItem IsNot Nothing Then
                    AddHandler Me._ExitToolStripMenuItem.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._SaveFileDialog1
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.SaveFileDialog)
                Me._SaveFileDialog1 = value
            End Set
        End Property

        Friend Overridable Property TabControl1 As System.Windows.Forms.TabControl
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._TabControl1
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TabControl)
                Me._TabControl1 = value
            End Set
        End Property

        Friend Overridable Property TabPage1 As System.Windows.Forms.TabPage
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._TabPage1
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TabPage)
                Me._TabPage1 = value
            End Set
        End Property

        Friend Overridable Property TabPage2 As System.Windows.Forms.TabPage
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._TabPage2
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TabPage)
                Me._TabPage2 = value
            End Set
        End Property

        Friend Overridable Property txtProcessorFamily As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtProcessorFamily
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._txtProcessorFamily = value
            End Set
        End Property

        Friend Overridable Property txtProcessorExtClock As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtProcessorExtClock
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._txtProcessorExtClock = value
            End Set
        End Property

        Friend Overridable Property Label9 As System.Windows.Forms.Label
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Label9
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Label)
                Me._Label9 = value
            End Set
        End Property

        Friend Overridable Property Label8 As System.Windows.Forms.Label
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Label8
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Label)
                Me._Label8 = value
            End Set
        End Property

        Friend Overridable Property Label7 As System.Windows.Forms.Label
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Label7
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Label)
                Me._Label7 = value
            End Set
        End Property

        Friend Overridable Property txtProcessorClockSpeed As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtProcessorClockSpeed
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._txtProcessorClockSpeed = value
            End Set
        End Property

        Friend Overridable Property txtProcessorDataWidth As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtProcessorDataWidth
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._txtProcessorDataWidth = value
            End Set
        End Property

        Friend Overridable Property Label6 As System.Windows.Forms.Label
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Label6
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Label)
                Me._Label6 = value
            End Set
        End Property

        Friend Overridable Property Label5 As System.Windows.Forms.Label
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Label5
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Label)
                Me._Label5 = value
            End Set
        End Property

        Friend Overridable Property txtProcessorL2CacheSize As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtProcessorL2CacheSize
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._txtProcessorL2CacheSize = value
            End Set
        End Property

        Friend Overridable Property txtProcessorManufacturer As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtProcessorManufacturer
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._txtProcessorManufacturer = value
            End Set
        End Property

        Friend Overridable Property Label4 As System.Windows.Forms.Label
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Label4
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Label)
                Me._Label4 = value
            End Set
        End Property

        Friend Overridable Property txtProcessorDescription As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtProcessorDescription
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._txtProcessorDescription = value
            End Set
        End Property

        Friend Overridable Property Label3 As System.Windows.Forms.Label
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Label3
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Label)
                Me._Label3 = value
            End Set
        End Property

        Friend Overridable Property txtProcessorID As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtProcessorID
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._txtProcessorID = value
            End Set
        End Property

        Friend Overridable Property Label2 As System.Windows.Forms.Label
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Label2
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Label)
                Me._Label2 = value
            End Set
        End Property

        Friend Overridable Property txtProcessorName As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtProcessorName
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._txtProcessorName = value
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

        Friend Overridable Property txtBoardSerialNumber As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtBoardSerialNumber
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._txtBoardSerialNumber = value
            End Set
        End Property

        Friend Overridable Property Label13 As System.Windows.Forms.Label
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Label13
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Label)
                Me._Label13 = value
            End Set
        End Property

        Friend Overridable Property txtBoardDescription As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtBoardDescription
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._txtBoardDescription = value
            End Set
        End Property

        Friend Overridable Property Label12 As System.Windows.Forms.Label
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Label12
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Label)
                Me._Label12 = value
            End Set
        End Property

        Friend Overridable Property txtBoardManufacturer As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtBoardManufacturer
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._txtBoardManufacturer = value
            End Set
        End Property

        Friend Overridable Property Label11 As System.Windows.Forms.Label
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Label11
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Label)
                Me._Label11 = value
            End Set
        End Property

        Friend Overridable Property txtBoardName As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtBoardName
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._txtBoardName = value
            End Set
        End Property

        Friend Overridable Property Label10 As System.Windows.Forms.Label
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Label10
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Label)
                Me._Label10 = value
            End Set
        End Property

        Friend Overridable Property TabPage3 As System.Windows.Forms.TabPage
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._TabPage3
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TabPage)
                Me._TabPage3 = value
            End Set
        End Property

        Friend Overridable Property Label22 As System.Windows.Forms.Label
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Label22
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Label)
                Me._Label22 = value
            End Set
        End Property

        Friend Overridable Property Label20 As System.Windows.Forms.Label
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Label20
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Label)
                Me._Label20 = value
            End Set
        End Property

        Friend Overridable Property Label18 As System.Windows.Forms.Label
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Label18
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Label)
                Me._Label18 = value
            End Set
        End Property

        Friend Overridable Property Label16 As System.Windows.Forms.Label
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Label16
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Label)
                Me._Label16 = value
            End Set
        End Property

        Friend Overridable Property Label23 As System.Windows.Forms.Label
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Label23
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Label)
                Me._Label23 = value
            End Set
        End Property

        Friend Overridable Property Label25 As System.Windows.Forms.Label
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Label25
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Label)
                Me._Label25 = value
            End Set
        End Property

        Friend Overridable Property Label27 As System.Windows.Forms.Label
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Label27
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Label)
                Me._Label27 = value
            End Set
        End Property

        Friend Overridable Property Label32 As System.Windows.Forms.Label
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Label32
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Label)
                Me._Label32 = value
            End Set
        End Property

        Friend Overridable Property Label33 As System.Windows.Forms.Label
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Label33
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Label)
                Me._Label33 = value
            End Set
        End Property

        Friend Overridable Property Label34 As System.Windows.Forms.Label
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Label34
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Label)
                Me._Label34 = value
            End Set
        End Property

        Friend Overridable Property Label35 As System.Windows.Forms.Label
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Label35
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Label)
                Me._Label35 = value
            End Set
        End Property

        Friend Overridable Property TextBox11 As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._TextBox11
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._TextBox11 = value
            End Set
        End Property

        Friend Overridable Property TextBox10 As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._TextBox10
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._TextBox10 = value
            End Set
        End Property

        Friend Overridable Property TextBox9 As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._TextBox9
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._TextBox9 = value
            End Set
        End Property

        Friend Overridable Property TextBox8 As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._TextBox8
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._TextBox8 = value
            End Set
        End Property

        Friend Overridable Property TextBox7 As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._TextBox7
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._TextBox7 = value
            End Set
        End Property

        Friend Overridable Property TextBox6 As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._TextBox6
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._TextBox6 = value
            End Set
        End Property

        Friend Overridable Property TextBox5 As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._TextBox5
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._TextBox5 = value
            End Set
        End Property

        Friend Overridable Property TextBox4 As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._TextBox4
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._TextBox4 = value
            End Set
        End Property

        Friend Overridable Property TextBox3 As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._TextBox3
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._TextBox3 = value
            End Set
        End Property

        Friend Overridable Property TextBox2 As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._TextBox2
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._TextBox2 = value
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

        Friend Overridable Property TextBox12 As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._TextBox12
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._TextBox12 = value
            End Set
        End Property

        Friend Overridable Property Label14 As System.Windows.Forms.Label
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Label14
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Label)
                Me._Label14 = value
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

        Public Sub New()
            AddHandler MyBase.Closed, AddressOf Me.frmSystemInfo_Closed
            AddHandler MyBase.Load, AddressOf Me.MainForm_Load
            Call RestaurantPOS14.frmSystemInfo.__ENCAddToList(Me)
            Me.h = System.Net.Dns.GetHostByName(System.Net.Dns.GetHostName())
            Me.InitializeComponent()
        End Sub

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Private Shared Sub __ENCAddToList(value As Object)
            SyncLock RestaurantPOS14.frmSystemInfo.__ENCList
                If RestaurantPOS14.frmSystemInfo.__ENCList.Count = RestaurantPOS14.frmSystemInfo.__ENCList.Capacity Then
                    Dim num As Integer = 0
                    Dim num2 As Integer = RestaurantPOS14.frmSystemInfo.__ENCList.Count - 1
                    Dim num3 As Integer = 0
                    While True
                        Dim num4 As Integer = num3
                        Dim num5 As Integer = num2
                        If num4 > num5 Then
                            Exit While
                        End If

                        If RestaurantPOS14.frmSystemInfo.__ENCList(CInt((num3))).IsAlive Then
                            If num3 <> num Then
                                RestaurantPOS14.frmSystemInfo.__ENCList(num) = RestaurantPOS14.frmSystemInfo.__ENCList(num3)
                            End If

                            num += 1
                        End If

                        num3 += 1
                    End While

                    Call RestaurantPOS14.frmSystemInfo.__ENCList.RemoveRange(num, RestaurantPOS14.frmSystemInfo.__ENCList.Count - num)
                    RestaurantPOS14.frmSystemInfo.__ENCList.Capacity = RestaurantPOS14.frmSystemInfo.__ENCList.Count
                End If

                Call RestaurantPOS14.frmSystemInfo.__ENCList.Add(New System.WeakReference(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(value)))
            End SyncLock
        End Sub

        Private Sub clear()
            Me.txtProcessorName.Text = ""
            Me.txtProcessorID.Text = ""
            Me.txtProcessorDescription.Text = ""
            Me.txtProcessorManufacturer.Text = ""
            Me.txtProcessorL2CacheSize.Text = ""
            Me.txtProcessorClockSpeed.Text = ""
            Me.txtProcessorDataWidth.Text = ""
            Me.txtProcessorExtClock.Text = ""
            Me.txtProcessorFamily.Text = ""
            Me.txtBoardDescription.Text = ""
            Me.txtBoardManufacturer.Text = ""
            Me.txtBoardName.Text = ""
            Me.txtBoardSerialNumber.Text = ""
            Me.TextBox1.Text = ""
            Me.TextBox2.Text = ""
            Me.TextBox3.Text = ""
            Me.TextBox4.Text = ""
            Me.TextBox5.Text = ""
            Me.TextBox6.Text = ""
            Me.TextBox7.Text = ""
            Me.TextBox8.Text = ""
            Me.TextBox9.Text = ""
            Me.TextBox10.Text = ""
            Me.TextBox11.Text = ""
            Me.TextBox12.Text = ""
        End Sub

        <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.NoInlining Or System.Runtime.CompilerServices.MethodImplOptions.NoOptimization)>
        Private Sub MainForm_Load(sender As Object, e As System.EventArgs)
            Me.clear()
            Me.Timer1.Enabled = True
            Try
                For Each managementObject As System.Management.ManagementObject In New System.Management.ManagementObjectSearcher(CStr(("Select * from Win32_Processor"))).[Get]()
                    Me.txtProcessorName.Text = managementObject(CStr(("Name"))).ToString()
                    Me.txtProcessorID.Text = managementObject(CStr(("ProcessorID"))).ToString()
                    Me.txtProcessorDescription.Text = managementObject(CStr(("Description"))).ToString()
                    Me.txtProcessorManufacturer.Text = managementObject(CStr(("Manufacturer"))).ToString()
                    Me.txtProcessorL2CacheSize.Text = managementObject(CStr(("L2CacheSize"))).ToString()
                    Me.txtProcessorClockSpeed.Text = managementObject(CStr(("CurrentClockSpeed"))).ToString() & " Mhz"
                    Me.txtProcessorDataWidth.Text = managementObject(CStr(("DataWidth"))).ToString()
                    Me.txtProcessorExtClock.Text = managementObject(CStr(("ExtClock"))).ToString() & " Mhz"
                    Me.txtProcessorFamily.Text = managementObject(CStr(("Family"))).ToString()
                Next

                For Each managementObject2 As System.Management.ManagementObject In New System.Management.ManagementObjectSearcher(CStr(("Select * from Win32_BaseBoard"))).[Get]()
                    Me.txtBoardDescription.Text = managementObject2(CStr(("Description"))).ToString()
                    Me.txtBoardManufacturer.Text = managementObject2(CStr(("Manufacturer"))).ToString()
                    Me.txtBoardName.Text = managementObject2(CStr(("Name"))).ToString()
                    Me.txtBoardSerialNumber.Text = managementObject2(CStr(("SerialNumber"))).ToString()
                Next
            Catch ex As System.Exception
                Call Microsoft.VisualBasic.Interaction.MsgBox(ex.Message, Microsoft.VisualBasic.MsgBoxStyle.Critical, "Error!")
                Call Microsoft.VisualBasic.CompilerServices.ProjectData.EndApp()
            End Try

            Try
                Me.ipaddress = CType(Me.h.AddressList.GetValue(CInt((0))), System.Net.IPAddress).ToString()
                Me.hostname = System.Net.Dns.GetHostName()
                Me.TextBox9.Text = Me.ipaddress
                Me.TextBox1.Text = Me.hostname
                Me.TextBox2.Text = System.Environment.UserName
                Me.mc = New System.Management.ManagementClass("Win32_NetworkAdapterConfiguration")
                For Each managementObject3 As System.Management.ManagementObject In Me.mc.GetInstances()
                    Me.mo = managementObject3
                    If Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Me.mo("IPEnabled"), True, TextCompare:=False) Then
                        Me.TextBox11.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(Me.mo("MacAddress"))
                    End If
                Next

                Me.TextBox10.Text = Me.GetPublicIP().ToString()
            Catch __unusedException1__ As System.Exception
            End Try

            Me.TextBox3.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(RestaurantPOS14.My.MyProject.Computer.Info.AvailablePhysicalMemory)
            Me.TextBox4.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(RestaurantPOS14.My.MyProject.Computer.Info.TotalPhysicalMemory)
            Me.TextBox5.Text = RestaurantPOS14.My.MyProject.Computer.Info.OSFullName
            Me.TextBox6.Text = RestaurantPOS14.My.MyProject.Computer.Info.OSPlatform
            Me.TextBox7.Text = RestaurantPOS14.My.MyProject.Computer.Info.OSVersion
            Me.TextBox8.Text = RestaurantPOS14.My.MyProject.Computer.Screen.WorkingArea.ToString()
            Me.TextBox3.Text += " KB"
            Me.TextBox4.Text += " KB"
        End Sub

        Private Sub Timer1_Tick(sender As Object, e As System.EventArgs)
            Me.TextBox12.Text = System.DateTime.Now.ToString("dd-MMM-yyyy | hh:mm:ss tt | dddd")
        End Sub

        Public Function GetPublicIP() As String
            Dim text As String = ""
            Using response As System.Net.WebResponse = System.Net.WebRequest.Create(CStr(("http://checkip.dyndns.org/"))).GetResponse()
                Using streamReader As System.IO.StreamReader = New System.IO.StreamReader(response.GetResponseStream())
                    text = streamReader.ReadToEnd()
                End Using
            End Using

            Dim num As Integer = text.IndexOf("Address: ") + 9
            Dim num2 As Integer = text.LastIndexOf("</body>")
            Return text.Substring(num, num2 - num)
        End Function

        Private Sub SaveToFileToolStripMenuItem_Click(sender As Object, e As System.EventArgs)
            Try
                Dim streamWriter As System.IO.StreamWriter = New System.IO.StreamWriter(New System.IO.FileStream("temp.txt", System.IO.FileMode.Create, System.IO.FileAccess.Write))
                streamWriter.Write("****** Processor Information ******")
                streamWriter.WriteLine()
                streamWriter.WriteLine()
                streamWriter.WriteLine("Name")
                streamWriter.WriteLine(Me.txtProcessorName.Text)
                streamWriter.WriteLine()
                streamWriter.WriteLine("ID")
                streamWriter.WriteLine(Me.txtProcessorID.Text)
                streamWriter.WriteLine()
                streamWriter.WriteLine("Description")
                streamWriter.WriteLine(Me.txtProcessorDescription.Text)
                streamWriter.WriteLine()
                streamWriter.WriteLine("Manufacturer")
                streamWriter.WriteLine(Me.txtProcessorManufacturer.Text)
                streamWriter.WriteLine()
                streamWriter.WriteLine("L2 Cache Size")
                streamWriter.WriteLine(Me.txtProcessorL2CacheSize.Text)
                streamWriter.WriteLine()
                streamWriter.WriteLine("Clock Speed")
                streamWriter.WriteLine(Me.txtProcessorClockSpeed.Text)
                streamWriter.WriteLine()
                streamWriter.WriteLine("Data Width")
                streamWriter.WriteLine(Me.txtProcessorDataWidth.Text)
                streamWriter.WriteLine()
                streamWriter.WriteLine("Ext Clock")
                streamWriter.WriteLine(Me.txtProcessorExtClock.Text)
                streamWriter.WriteLine()
                streamWriter.WriteLine("Family")
                streamWriter.WriteLine(Me.txtProcessorFamily.Text)
                streamWriter.WriteLine()
                streamWriter.WriteLine("****** MotherBoard Information *****")
                streamWriter.WriteLine()
                streamWriter.WriteLine("Name")
                streamWriter.WriteLine(Me.txtBoardDescription.Text)
                streamWriter.WriteLine()
                streamWriter.WriteLine("Manufacturer")
                streamWriter.WriteLine(Me.txtBoardManufacturer.Text)
                streamWriter.WriteLine()
                streamWriter.WriteLine("Description")
                streamWriter.WriteLine(Me.txtBoardDescription.Text)
                streamWriter.WriteLine()
                streamWriter.WriteLine("Serial Number")
                streamWriter.WriteLine(Me.txtBoardSerialNumber.Text)
                streamWriter.WriteLine()
                streamWriter.WriteLine("****** My PC *****")
                streamWriter.WriteLine()
                streamWriter.WriteLine("Computer Name")
                streamWriter.WriteLine(Me.TextBox1.Text)
                streamWriter.WriteLine()
                streamWriter.WriteLine("User Name")
                streamWriter.WriteLine(Me.TextBox2.Text)
                streamWriter.WriteLine()
                streamWriter.WriteLine("RAM Avail Memory")
                streamWriter.WriteLine(Me.TextBox3.Text)
                streamWriter.WriteLine()
                streamWriter.WriteLine("RAM Full Memory")
                streamWriter.WriteLine(Me.TextBox4.Text)
                streamWriter.WriteLine()
                streamWriter.WriteLine("Operating System")
                streamWriter.WriteLine(Me.TextBox5.Text)
                streamWriter.WriteLine()
                streamWriter.WriteLine("Platform")
                streamWriter.WriteLine(Me.TextBox6.Text)
                streamWriter.WriteLine()
                streamWriter.WriteLine("Version")
                streamWriter.WriteLine(Me.TextBox7.Text)
                streamWriter.WriteLine()
                streamWriter.WriteLine("Screen Resolution")
                streamWriter.WriteLine(Me.TextBox8.Text)
                streamWriter.WriteLine()
                streamWriter.WriteLine("Local IP Address")
                streamWriter.WriteLine(Me.TextBox9.Text)
                streamWriter.WriteLine()
                streamWriter.WriteLine("Online IP Address")
                streamWriter.WriteLine(Me.TextBox10.Text)
                streamWriter.WriteLine()
                streamWriter.WriteLine("MAC Address")
                streamWriter.WriteLine(Me.TextBox11.Text)
                streamWriter.WriteLine()
                streamWriter.WriteLine("Date / Time")
                streamWriter.WriteLine(Me.TextBox12.Text)
                streamWriter.WriteLine()
                streamWriter.Flush()
                streamWriter.Close()
                Dim saveFileDialog As System.Windows.Forms.SaveFileDialog = Me.SaveFileDialog1
                saveFileDialog.AddExtension = True
                saveFileDialog.OverwritePrompt = True
                saveFileDialog.DefaultExt = "txt"
                saveFileDialog.InitialDirectory = RestaurantPOS14.My.MyProject.Computer.FileSystem.SpecialDirectories.MyDocuments
                saveFileDialog.FileName = "SystemInfo"
                saveFileDialog.Filter = "Text files (*.txt)|*.txt|All files|*.*"
                saveFileDialog.FilterIndex = 1
                saveFileDialog.Title = "SystemInfo - Save file"
                If saveFileDialog.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                    Call RestaurantPOS14.My.MyProject.Computer.FileSystem.MoveFile("temp.txt", saveFileDialog.FileName, overwrite:=True)
                End If
            Catch ex As System.Exception
                Call Microsoft.VisualBasic.Interaction.MsgBox(ex.Message, Microsoft.VisualBasic.MsgBoxStyle.Critical, "Error!")
            End Try
        End Sub

        Private Sub frmSystemInfo_Closed(sender As Object, e As System.EventArgs)
            MyBase.Close()
        End Sub

        Private Sub ExitToolStripMenuItem_Click(sender As Object, e As System.EventArgs)
            MyBase.Close()
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
            Dim componentResourceManager As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RestaurantPOS14.frmSystemInfo))
            Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
            Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.SaveToFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
            Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
            Me.TabControl1 = New System.Windows.Forms.TabControl()
            Me.TabPage1 = New System.Windows.Forms.TabPage()
            Me.txtProcessorFamily = New System.Windows.Forms.TextBox()
            Me.txtProcessorExtClock = New System.Windows.Forms.TextBox()
            Me.Label9 = New System.Windows.Forms.Label()
            Me.Label8 = New System.Windows.Forms.Label()
            Me.Label7 = New System.Windows.Forms.Label()
            Me.txtProcessorClockSpeed = New System.Windows.Forms.TextBox()
            Me.txtProcessorDataWidth = New System.Windows.Forms.TextBox()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.txtProcessorL2CacheSize = New System.Windows.Forms.TextBox()
            Me.txtProcessorManufacturer = New System.Windows.Forms.TextBox()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.txtProcessorDescription = New System.Windows.Forms.TextBox()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.txtProcessorID = New System.Windows.Forms.TextBox()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.txtProcessorName = New System.Windows.Forms.TextBox()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.TabPage2 = New System.Windows.Forms.TabPage()
            Me.txtBoardSerialNumber = New System.Windows.Forms.TextBox()
            Me.Label13 = New System.Windows.Forms.Label()
            Me.txtBoardDescription = New System.Windows.Forms.TextBox()
            Me.Label12 = New System.Windows.Forms.Label()
            Me.txtBoardManufacturer = New System.Windows.Forms.TextBox()
            Me.Label11 = New System.Windows.Forms.Label()
            Me.txtBoardName = New System.Windows.Forms.TextBox()
            Me.Label10 = New System.Windows.Forms.Label()
            Me.TabPage3 = New System.Windows.Forms.TabPage()
            Me.TextBox12 = New System.Windows.Forms.TextBox()
            Me.Label14 = New System.Windows.Forms.Label()
            Me.TextBox11 = New System.Windows.Forms.TextBox()
            Me.TextBox10 = New System.Windows.Forms.TextBox()
            Me.TextBox9 = New System.Windows.Forms.TextBox()
            Me.TextBox8 = New System.Windows.Forms.TextBox()
            Me.TextBox7 = New System.Windows.Forms.TextBox()
            Me.TextBox6 = New System.Windows.Forms.TextBox()
            Me.TextBox5 = New System.Windows.Forms.TextBox()
            Me.TextBox4 = New System.Windows.Forms.TextBox()
            Me.TextBox3 = New System.Windows.Forms.TextBox()
            Me.TextBox2 = New System.Windows.Forms.TextBox()
            Me.TextBox1 = New System.Windows.Forms.TextBox()
            Me.Label22 = New System.Windows.Forms.Label()
            Me.Label20 = New System.Windows.Forms.Label()
            Me.Label18 = New System.Windows.Forms.Label()
            Me.Label16 = New System.Windows.Forms.Label()
            Me.Label23 = New System.Windows.Forms.Label()
            Me.Label25 = New System.Windows.Forms.Label()
            Me.Label27 = New System.Windows.Forms.Label()
            Me.Label32 = New System.Windows.Forms.Label()
            Me.Label33 = New System.Windows.Forms.Label()
            Me.Label34 = New System.Windows.Forms.Label()
            Me.Label35 = New System.Windows.Forms.Label()
            Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
            Me.MenuStrip1.SuspendLayout()
            Me.TabControl1.SuspendLayout()
            Me.TabPage1.SuspendLayout()
            Me.TabPage2.SuspendLayout()
            Me.TabPage3.SuspendLayout()
            MyBase.SuspendLayout()
            Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem(0) {Me.FileToolStripMenuItem})
            Dim menuStrip As System.Windows.Forms.MenuStrip = Me.MenuStrip1
            Dim location As System.Drawing.Point = New System.Drawing.Point(0, 0)
            menuStrip.Location = location
            Me.MenuStrip1.Name = "MenuStrip1"
            Dim menuStrip2 As System.Windows.Forms.MenuStrip = Me.MenuStrip1
            Dim size As System.Drawing.Size = New System.Drawing.Size(441, 24)
            menuStrip2.Size = size
            Me.MenuStrip1.TabIndex = 0
            Me.MenuStrip1.Text = "MenuStrip1"
            Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem(2) {Me.SaveToFileToolStripMenuItem, Me.ToolStripMenuItem1, Me.ExitToolStripMenuItem})
            Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
            Dim fileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem = Me.FileToolStripMenuItem
            size = New System.Drawing.Size(37, 20)
            fileToolStripMenuItem.Size = size
            Me.FileToolStripMenuItem.Text = "&File"
            Me.SaveToFileToolStripMenuItem.Name = "SaveToFileToolStripMenuItem"
            Dim saveToFileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem = Me.SaveToFileToolStripMenuItem
            size = New System.Drawing.Size(131, 22)
            saveToFileToolStripMenuItem.Size = size
            Me.SaveToFileToolStripMenuItem.Text = "&Save to file"
            Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
            Dim toolStripMenuItem As System.Windows.Forms.ToolStripSeparator = Me.ToolStripMenuItem1
            size = New System.Drawing.Size(128, 6)
            toolStripMenuItem.Size = size
            Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
            Dim exitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem = Me.ExitToolStripMenuItem
            size = New System.Drawing.Size(131, 22)
            exitToolStripMenuItem.Size = size
            Me.ExitToolStripMenuItem.Text = "E&xit"
            Me.TabControl1.Controls.Add(Me.TabPage1)
            Me.TabControl1.Controls.Add(Me.TabPage2)
            Me.TabControl1.Controls.Add(Me.TabPage3)
            Me.TabControl1.Cursor = System.Windows.Forms.Cursors.Hand
            Dim tabControl As System.Windows.Forms.TabControl = Me.TabControl1
            location = New System.Drawing.Point(4, 26)
            tabControl.Location = location
            Me.TabControl1.Name = "TabControl1"
            Me.TabControl1.SelectedIndex = 0
            Dim tabControl2 As System.Windows.Forms.TabControl = Me.TabControl1
            size = New System.Drawing.Size(433, 312)
            tabControl2.Size = size
            Me.TabControl1.TabIndex = 1
            Me.TabPage1.BackColor = System.Drawing.Color.Yellow
            Me.TabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.TabPage1.Controls.Add(Me.txtProcessorFamily)
            Me.TabPage1.Controls.Add(Me.txtProcessorExtClock)
            Me.TabPage1.Controls.Add(Me.Label9)
            Me.TabPage1.Controls.Add(Me.Label8)
            Me.TabPage1.Controls.Add(Me.Label7)
            Me.TabPage1.Controls.Add(Me.txtProcessorClockSpeed)
            Me.TabPage1.Controls.Add(Me.txtProcessorDataWidth)
            Me.TabPage1.Controls.Add(Me.Label6)
            Me.TabPage1.Controls.Add(Me.Label5)
            Me.TabPage1.Controls.Add(Me.txtProcessorL2CacheSize)
            Me.TabPage1.Controls.Add(Me.txtProcessorManufacturer)
            Me.TabPage1.Controls.Add(Me.Label4)
            Me.TabPage1.Controls.Add(Me.txtProcessorDescription)
            Me.TabPage1.Controls.Add(Me.Label3)
            Me.TabPage1.Controls.Add(Me.txtProcessorID)
            Me.TabPage1.Controls.Add(Me.Label2)
            Me.TabPage1.Controls.Add(Me.txtProcessorName)
            Me.TabPage1.Controls.Add(Me.Label1)
            Dim tabPage As System.Windows.Forms.TabPage = Me.TabPage1
            location = New System.Drawing.Point(4, 25)
            tabPage.Location = location
            Me.TabPage1.Name = "TabPage1"
            Dim tabPage2 As System.Windows.Forms.TabPage = Me.TabPage1
            Dim padding As System.Windows.Forms.Padding = New System.Windows.Forms.Padding(3)
            tabPage2.Padding = padding
            Dim tabPage3 As System.Windows.Forms.TabPage = Me.TabPage1
            size = New System.Drawing.Size(425, 283)
            tabPage3.Size = size
            Me.TabPage1.TabIndex = 0
            Me.TabPage1.Text = "Processor"
            Me.txtProcessorFamily.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Dim textBox As System.Windows.Forms.TextBox = Me.txtProcessorFamily
            location = New System.Drawing.Point(218, 237)
            textBox.Location = location
            Me.txtProcessorFamily.Name = "txtProcessorFamily"
            Me.txtProcessorFamily.[ReadOnly] = True
            Dim textBox2 As System.Windows.Forms.TextBox = Me.txtProcessorFamily
            size = New System.Drawing.Size(165, 22)
            textBox2.Size = size
            Me.txtProcessorFamily.TabIndex = 37
            Me.txtProcessorFamily.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            Me.txtProcessorExtClock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Dim textBox3 As System.Windows.Forms.TextBox = Me.txtProcessorExtClock
            location = New System.Drawing.Point(47, 237)
            textBox3.Location = location
            Me.txtProcessorExtClock.Name = "txtProcessorExtClock"
            Me.txtProcessorExtClock.[ReadOnly] = True
            Dim textBox4 As System.Windows.Forms.TextBox = Me.txtProcessorExtClock
            size = New System.Drawing.Size(165, 22)
            textBox4.Size = size
            Me.txtProcessorExtClock.TabIndex = 36
            Me.txtProcessorExtClock.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            Me.Label9.AutoSize = True
            Dim label As System.Windows.Forms.Label = Me.Label9
            location = New System.Drawing.Point(215, 221)
            label.Location = location
            Me.Label9.Name = "Label9"
            Dim label2 As System.Windows.Forms.Label = Me.Label9
            size = New System.Drawing.Size(48, 16)
            label2.Size = size
            Me.Label9.TabIndex = 35
            Me.Label9.Text = "Family"
            Me.Label8.AutoSize = True
            Dim label3 As System.Windows.Forms.Label = Me.Label8
            location = New System.Drawing.Point(43, 221)
            label3.Location = location
            Me.Label8.Name = "Label8"
            Dim label4 As System.Windows.Forms.Label = Me.Label8
            size = New System.Drawing.Size(63, 16)
            label4.Size = size
            Me.Label8.TabIndex = 34
            Me.Label8.Text = "Ext Clock"
            Me.Label7.AutoSize = True
            Dim label5 As System.Windows.Forms.Label = Me.Label7
            location = New System.Drawing.Point(215, 180)
            label5.Location = location
            Me.Label7.Name = "Label7"
            Dim label6 As System.Windows.Forms.Label = Me.Label7
            size = New System.Drawing.Size(74, 16)
            label6.Size = size
            Me.Label7.TabIndex = 33
            Me.Label7.Text = "Data Width"
            Me.txtProcessorClockSpeed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Dim textBox5 As System.Windows.Forms.TextBox = Me.txtProcessorClockSpeed
            location = New System.Drawing.Point(47, 196)
            textBox5.Location = location
            Me.txtProcessorClockSpeed.Name = "txtProcessorClockSpeed"
            Me.txtProcessorClockSpeed.[ReadOnly] = True
            Dim textBox6 As System.Windows.Forms.TextBox = Me.txtProcessorClockSpeed
            size = New System.Drawing.Size(165, 22)
            textBox6.Size = size
            Me.txtProcessorClockSpeed.TabIndex = 32
            Me.txtProcessorClockSpeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            Me.txtProcessorDataWidth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Dim textBox7 As System.Windows.Forms.TextBox = Me.txtProcessorDataWidth
            location = New System.Drawing.Point(218, 196)
            textBox7.Location = location
            Me.txtProcessorDataWidth.Name = "txtProcessorDataWidth"
            Me.txtProcessorDataWidth.[ReadOnly] = True
            Dim textBox8 As System.Windows.Forms.TextBox = Me.txtProcessorDataWidth
            size = New System.Drawing.Size(165, 22)
            textBox8.Size = size
            Me.txtProcessorDataWidth.TabIndex = 31
            Me.txtProcessorDataWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            Me.Label6.AutoSize = True
            Dim label7 As System.Windows.Forms.Label = Me.Label6
            location = New System.Drawing.Point(43, 180)
            label7.Location = location
            Me.Label6.Name = "Label6"
            Dim label8 As System.Windows.Forms.Label = Me.Label6
            size = New System.Drawing.Size(86, 16)
            label8.Size = size
            Me.Label6.TabIndex = 30
            Me.Label6.Text = "Clock Speed"
            Me.Label5.AutoSize = True
            Dim label9 As System.Windows.Forms.Label = Me.Label5
            location = New System.Drawing.Point(215, 138)
            label9.Location = location
            Me.Label5.Name = "Label5"
            Dim label10 As System.Windows.Forms.Label = Me.Label5
            size = New System.Drawing.Size(93, 16)
            label10.Size = size
            Me.Label5.TabIndex = 29
            Me.Label5.Text = "L2 Cache Size"
            Me.txtProcessorL2CacheSize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Dim textBox9 As System.Windows.Forms.TextBox = Me.txtProcessorL2CacheSize
            location = New System.Drawing.Point(218, 154)
            textBox9.Location = location
            Me.txtProcessorL2CacheSize.Name = "txtProcessorL2CacheSize"
            Me.txtProcessorL2CacheSize.[ReadOnly] = True
            Dim textBox10 As System.Windows.Forms.TextBox = Me.txtProcessorL2CacheSize
            size = New System.Drawing.Size(165, 22)
            textBox10.Size = size
            Me.txtProcessorL2CacheSize.TabIndex = 28
            Me.txtProcessorL2CacheSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            Me.txtProcessorManufacturer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Dim textBox11 As System.Windows.Forms.TextBox = Me.txtProcessorManufacturer
            location = New System.Drawing.Point(46, 154)
            textBox11.Location = location
            Me.txtProcessorManufacturer.Name = "txtProcessorManufacturer"
            Me.txtProcessorManufacturer.[ReadOnly] = True
            Dim textBox12 As System.Windows.Forms.TextBox = Me.txtProcessorManufacturer
            size = New System.Drawing.Size(165, 22)
            textBox12.Size = size
            Me.txtProcessorManufacturer.TabIndex = 27
            Me.txtProcessorManufacturer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            Me.Label4.AutoSize = True
            Dim label11 As System.Windows.Forms.Label = Me.Label4
            location = New System.Drawing.Point(43, 138)
            label11.Location = location
            Me.Label4.Name = "Label4"
            Dim label12 As System.Windows.Forms.Label = Me.Label4
            size = New System.Drawing.Size(85, 16)
            label12.Size = size
            Me.Label4.TabIndex = 26
            Me.Label4.Text = "Manufacturer"
            Me.txtProcessorDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Dim textBox13 As System.Windows.Forms.TextBox = Me.txtProcessorDescription
            location = New System.Drawing.Point(46, 113)
            textBox13.Location = location
            Me.txtProcessorDescription.Name = "txtProcessorDescription"
            Me.txtProcessorDescription.[ReadOnly] = True
            Dim textBox14 As System.Windows.Forms.TextBox = Me.txtProcessorDescription
            size = New System.Drawing.Size(337, 22)
            textBox14.Size = size
            Me.txtProcessorDescription.TabIndex = 25
            Me.txtProcessorDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            Me.Label3.AutoSize = True
            Dim label13 As System.Windows.Forms.Label = Me.Label3
            location = New System.Drawing.Point(43, 97)
            label13.Location = location
            Me.Label3.Name = "Label3"
            Dim label14 As System.Windows.Forms.Label = Me.Label3
            size = New System.Drawing.Size(76, 16)
            label14.Size = size
            Me.Label3.TabIndex = 24
            Me.Label3.Text = "Description"
            Me.txtProcessorID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Dim textBox15 As System.Windows.Forms.TextBox = Me.txtProcessorID
            location = New System.Drawing.Point(46, 72)
            textBox15.Location = location
            Me.txtProcessorID.Name = "txtProcessorID"
            Me.txtProcessorID.[ReadOnly] = True
            Dim textBox16 As System.Windows.Forms.TextBox = Me.txtProcessorID
            size = New System.Drawing.Size(337, 22)
            textBox16.Size = size
            Me.txtProcessorID.TabIndex = 23
            Me.txtProcessorID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            Me.Label2.AutoSize = True
            Dim label15 As System.Windows.Forms.Label = Me.Label2
            location = New System.Drawing.Point(43, 56)
            label15.Location = location
            Me.Label2.Name = "Label2"
            Dim label16 As System.Windows.Forms.Label = Me.Label2
            size = New System.Drawing.Size(86, 16)
            label16.Size = size
            Me.Label2.TabIndex = 22
            Me.Label2.Text = "Processor ID"
            Me.txtProcessorName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Dim textBox17 As System.Windows.Forms.TextBox = Me.txtProcessorName
            location = New System.Drawing.Point(46, 31)
            textBox17.Location = location
            Me.txtProcessorName.Name = "txtProcessorName"
            Me.txtProcessorName.[ReadOnly] = True
            Dim textBox18 As System.Windows.Forms.TextBox = Me.txtProcessorName
            size = New System.Drawing.Size(337, 22)
            textBox18.Size = size
            Me.txtProcessorName.TabIndex = 21
            Me.txtProcessorName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            Me.Label1.AutoSize = True
            Dim label17 As System.Windows.Forms.Label = Me.Label1
            location = New System.Drawing.Point(43, 15)
            label17.Location = location
            Me.Label1.Name = "Label1"
            Dim label18 As System.Windows.Forms.Label = Me.Label1
            size = New System.Drawing.Size(110, 16)
            label18.Size = size
            Me.Label1.TabIndex = 20
            Me.Label1.Text = "Processor Name"
            Me.TabPage2.BackColor = System.Drawing.Color.FromArgb(255, 128, 0)
            Me.TabPage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.TabPage2.Controls.Add(Me.txtBoardSerialNumber)
            Me.TabPage2.Controls.Add(Me.Label13)
            Me.TabPage2.Controls.Add(Me.txtBoardDescription)
            Me.TabPage2.Controls.Add(Me.Label12)
            Me.TabPage2.Controls.Add(Me.txtBoardManufacturer)
            Me.TabPage2.Controls.Add(Me.Label11)
            Me.TabPage2.Controls.Add(Me.txtBoardName)
            Me.TabPage2.Controls.Add(Me.Label10)
            Dim tabPage4 As System.Windows.Forms.TabPage = Me.TabPage2
            location = New System.Drawing.Point(4, 25)
            tabPage4.Location = location
            Me.TabPage2.Name = "TabPage2"
            Dim tabPage5 As System.Windows.Forms.TabPage = Me.TabPage2
            padding = New System.Windows.Forms.Padding(3)
            tabPage5.Padding = padding
            Dim tabPage6 As System.Windows.Forms.TabPage = Me.TabPage2
            size = New System.Drawing.Size(425, 283)
            tabPage6.Size = size
            Me.TabPage2.TabIndex = 1
            Me.TabPage2.Text = "Motherboard"
            Me.txtBoardSerialNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Dim textBox19 As System.Windows.Forms.TextBox = Me.txtBoardSerialNumber
            location = New System.Drawing.Point(44, 225)
            textBox19.Location = location
            Me.txtBoardSerialNumber.Name = "txtBoardSerialNumber"
            Me.txtBoardSerialNumber.[ReadOnly] = True
            Dim textBox20 As System.Windows.Forms.TextBox = Me.txtBoardSerialNumber
            size = New System.Drawing.Size(337, 22)
            textBox20.Size = size
            Me.txtBoardSerialNumber.TabIndex = 23
            Me.txtBoardSerialNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            Me.Label13.AutoSize = True
            Dim label19 As System.Windows.Forms.Label = Me.Label13
            location = New System.Drawing.Point(41, 206)
            label19.Location = location
            Me.Label13.Name = "Label13"
            Dim label20 As System.Windows.Forms.Label = Me.Label13
            size = New System.Drawing.Size(94, 16)
            label20.Size = size
            Me.Label13.TabIndex = 22
            Me.Label13.Text = "Serial Number"
            Me.txtBoardDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Dim textBox21 As System.Windows.Forms.TextBox = Me.txtBoardDescription
            location = New System.Drawing.Point(44, 169)
            textBox21.Location = location
            Me.txtBoardDescription.Name = "txtBoardDescription"
            Me.txtBoardDescription.[ReadOnly] = True
            Dim textBox22 As System.Windows.Forms.TextBox = Me.txtBoardDescription
            size = New System.Drawing.Size(337, 22)
            textBox22.Size = size
            Me.txtBoardDescription.TabIndex = 21
            Me.txtBoardDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            Me.Label12.AutoSize = True
            Dim label21 As System.Windows.Forms.Label = Me.Label12
            location = New System.Drawing.Point(41, 150)
            label21.Location = location
            Me.Label12.Name = "Label12"
            Dim label22 As System.Windows.Forms.Label = Me.Label12
            size = New System.Drawing.Size(76, 16)
            label22.Size = size
            Me.Label12.TabIndex = 20
            Me.Label12.Text = "Description"
            Me.txtBoardManufacturer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Dim textBox23 As System.Windows.Forms.TextBox = Me.txtBoardManufacturer
            location = New System.Drawing.Point(44, 113)
            textBox23.Location = location
            Me.txtBoardManufacturer.Name = "txtBoardManufacturer"
            Me.txtBoardManufacturer.[ReadOnly] = True
            Dim textBox24 As System.Windows.Forms.TextBox = Me.txtBoardManufacturer
            size = New System.Drawing.Size(337, 22)
            textBox24.Size = size
            Me.txtBoardManufacturer.TabIndex = 19
            Me.txtBoardManufacturer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            Me.Label11.AutoSize = True
            Dim label23 As System.Windows.Forms.Label = Me.Label11
            location = New System.Drawing.Point(41, 94)
            label23.Location = location
            Me.Label11.Name = "Label11"
            Dim label24 As System.Windows.Forms.Label = Me.Label11
            size = New System.Drawing.Size(85, 16)
            label24.Size = size
            Me.Label11.TabIndex = 18
            Me.Label11.Text = "Manufacturer"
            Me.txtBoardName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Dim textBox25 As System.Windows.Forms.TextBox = Me.txtBoardName
            location = New System.Drawing.Point(44, 57)
            textBox25.Location = location
            Me.txtBoardName.Name = "txtBoardName"
            Me.txtBoardName.[ReadOnly] = True
            Dim textBox26 As System.Windows.Forms.TextBox = Me.txtBoardName
            size = New System.Drawing.Size(337, 22)
            textBox26.Size = size
            Me.txtBoardName.TabIndex = 17
            Me.txtBoardName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            Me.Label10.AutoSize = True
            Dim label25 As System.Windows.Forms.Label = Me.Label10
            location = New System.Drawing.Point(41, 38)
            label25.Location = location
            Me.Label10.Name = "Label10"
            Dim label26 As System.Windows.Forms.Label = Me.Label10
            size = New System.Drawing.Size(125, 16)
            label26.Size = size
            Me.Label10.TabIndex = 16
            Me.Label10.Text = "Motherboard Name"
            Me.TabPage3.BackColor = System.Drawing.Color.Lime
            Me.TabPage3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.TabPage3.Controls.Add(Me.TextBox12)
            Me.TabPage3.Controls.Add(Me.Label14)
            Me.TabPage3.Controls.Add(Me.TextBox11)
            Me.TabPage3.Controls.Add(Me.TextBox10)
            Me.TabPage3.Controls.Add(Me.TextBox9)
            Me.TabPage3.Controls.Add(Me.TextBox8)
            Me.TabPage3.Controls.Add(Me.TextBox7)
            Me.TabPage3.Controls.Add(Me.TextBox6)
            Me.TabPage3.Controls.Add(Me.TextBox5)
            Me.TabPage3.Controls.Add(Me.TextBox4)
            Me.TabPage3.Controls.Add(Me.TextBox3)
            Me.TabPage3.Controls.Add(Me.TextBox2)
            Me.TabPage3.Controls.Add(Me.TextBox1)
            Me.TabPage3.Controls.Add(Me.Label22)
            Me.TabPage3.Controls.Add(Me.Label20)
            Me.TabPage3.Controls.Add(Me.Label18)
            Me.TabPage3.Controls.Add(Me.Label16)
            Me.TabPage3.Controls.Add(Me.Label23)
            Me.TabPage3.Controls.Add(Me.Label25)
            Me.TabPage3.Controls.Add(Me.Label27)
            Me.TabPage3.Controls.Add(Me.Label32)
            Me.TabPage3.Controls.Add(Me.Label33)
            Me.TabPage3.Controls.Add(Me.Label34)
            Me.TabPage3.Controls.Add(Me.Label35)
            Dim tabPage7 As System.Windows.Forms.TabPage = Me.TabPage3
            location = New System.Drawing.Point(4, 25)
            tabPage7.Location = location
            Me.TabPage3.Name = "TabPage3"
            Dim tabPage8 As System.Windows.Forms.TabPage = Me.TabPage3
            padding = New System.Windows.Forms.Padding(3)
            tabPage8.Padding = padding
            Dim tabPage9 As System.Windows.Forms.TabPage = Me.TabPage3
            size = New System.Drawing.Size(425, 283)
            tabPage9.Size = size
            Me.TabPage3.TabIndex = 2
            Me.TabPage3.Text = "My PC"
            Me.TextBox12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Dim textBox27 As System.Windows.Forms.TextBox = Me.TextBox12
            location = New System.Drawing.Point(127, 257)
            textBox27.Location = location
            Me.TextBox12.Name = "TextBox12"
            Me.TextBox12.[ReadOnly] = True
            Dim textBox28 As System.Windows.Forms.TextBox = Me.TextBox12
            size = New System.Drawing.Size(293, 22)
            textBox28.Size = size
            Me.TextBox12.TabIndex = 11
            Me.TextBox12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            Me.Label14.AutoSize = True
            Me.Label14.BackColor = System.Drawing.Color.Transparent
            Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.Label14.ForeColor = System.Drawing.Color.Black
            Dim label27 As System.Windows.Forms.Label = Me.Label14
            location = New System.Drawing.Point(1, 257)
            label27.Location = location
            Me.Label14.Name = "Label14"
            Dim label28 As System.Windows.Forms.Label = Me.Label14
            size = New System.Drawing.Size(84, 16)
            label28.Size = size
            Me.Label14.TabIndex = 82
            Me.Label14.Text = "Date / Time :"
            Me.TextBox11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Dim textBox29 As System.Windows.Forms.TextBox = Me.TextBox11
            location = New System.Drawing.Point(127, 234)
            textBox29.Location = location
            Me.TextBox11.Name = "TextBox11"
            Me.TextBox11.[ReadOnly] = True
            Dim textBox30 As System.Windows.Forms.TextBox = Me.TextBox11
            size = New System.Drawing.Size(293, 22)
            textBox30.Size = size
            Me.TextBox11.TabIndex = 10
            Me.TextBox11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            Me.TextBox10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Dim textBox31 As System.Windows.Forms.TextBox = Me.TextBox10
            location = New System.Drawing.Point(127, 211)
            textBox31.Location = location
            Me.TextBox10.Name = "TextBox10"
            Me.TextBox10.[ReadOnly] = True
            Dim textBox32 As System.Windows.Forms.TextBox = Me.TextBox10
            size = New System.Drawing.Size(293, 22)
            textBox32.Size = size
            Me.TextBox10.TabIndex = 9
            Me.TextBox10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            Me.TextBox9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Dim textBox33 As System.Windows.Forms.TextBox = Me.TextBox9
            location = New System.Drawing.Point(127, 188)
            textBox33.Location = location
            Me.TextBox9.Name = "TextBox9"
            Me.TextBox9.[ReadOnly] = True
            Dim textBox34 As System.Windows.Forms.TextBox = Me.TextBox9
            size = New System.Drawing.Size(293, 22)
            textBox34.Size = size
            Me.TextBox9.TabIndex = 8
            Me.TextBox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            Me.TextBox8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Dim textBox35 As System.Windows.Forms.TextBox = Me.TextBox8
            location = New System.Drawing.Point(127, 165)
            textBox35.Location = location
            Me.TextBox8.Name = "TextBox8"
            Me.TextBox8.[ReadOnly] = True
            Dim textBox36 As System.Windows.Forms.TextBox = Me.TextBox8
            size = New System.Drawing.Size(293, 22)
            textBox36.Size = size
            Me.TextBox8.TabIndex = 7
            Me.TextBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            Me.TextBox7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Dim textBox37 As System.Windows.Forms.TextBox = Me.TextBox7
            location = New System.Drawing.Point(127, 142)
            textBox37.Location = location
            Me.TextBox7.Name = "TextBox7"
            Me.TextBox7.[ReadOnly] = True
            Dim textBox38 As System.Windows.Forms.TextBox = Me.TextBox7
            size = New System.Drawing.Size(293, 22)
            textBox38.Size = size
            Me.TextBox7.TabIndex = 6
            Me.TextBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            Me.TextBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Dim textBox39 As System.Windows.Forms.TextBox = Me.TextBox6
            location = New System.Drawing.Point(127, 119)
            textBox39.Location = location
            Me.TextBox6.Name = "TextBox6"
            Me.TextBox6.[ReadOnly] = True
            Dim textBox40 As System.Windows.Forms.TextBox = Me.TextBox6
            size = New System.Drawing.Size(293, 22)
            textBox40.Size = size
            Me.TextBox6.TabIndex = 5
            Me.TextBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            Me.TextBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Dim textBox41 As System.Windows.Forms.TextBox = Me.TextBox5
            location = New System.Drawing.Point(127, 96)
            textBox41.Location = location
            Me.TextBox5.Name = "TextBox5"
            Me.TextBox5.[ReadOnly] = True
            Dim textBox42 As System.Windows.Forms.TextBox = Me.TextBox5
            size = New System.Drawing.Size(293, 22)
            textBox42.Size = size
            Me.TextBox5.TabIndex = 4
            Me.TextBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            Me.TextBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Dim textBox43 As System.Windows.Forms.TextBox = Me.TextBox4
            location = New System.Drawing.Point(127, 73)
            textBox43.Location = location
            Me.TextBox4.Name = "TextBox4"
            Me.TextBox4.[ReadOnly] = True
            Dim textBox44 As System.Windows.Forms.TextBox = Me.TextBox4
            size = New System.Drawing.Size(293, 22)
            textBox44.Size = size
            Me.TextBox4.TabIndex = 3
            Me.TextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Dim textBox45 As System.Windows.Forms.TextBox = Me.TextBox3
            location = New System.Drawing.Point(127, 50)
            textBox45.Location = location
            Me.TextBox3.Name = "TextBox3"
            Me.TextBox3.[ReadOnly] = True
            Dim textBox46 As System.Windows.Forms.TextBox = Me.TextBox3
            size = New System.Drawing.Size(293, 22)
            textBox46.Size = size
            Me.TextBox3.TabIndex = 2
            Me.TextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Dim textBox47 As System.Windows.Forms.TextBox = Me.TextBox2
            location = New System.Drawing.Point(127, 27)
            textBox47.Location = location
            Me.TextBox2.Name = "TextBox2"
            Me.TextBox2.[ReadOnly] = True
            Dim textBox48 As System.Windows.Forms.TextBox = Me.TextBox2
            size = New System.Drawing.Size(293, 22)
            textBox48.Size = size
            Me.TextBox2.TabIndex = 1
            Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Dim textBox49 As System.Windows.Forms.TextBox = Me.TextBox1
            location = New System.Drawing.Point(127, 4)
            textBox49.Location = location
            Me.TextBox1.Name = "TextBox1"
            Me.TextBox1.[ReadOnly] = True
            Dim textBox50 As System.Windows.Forms.TextBox = Me.TextBox1
            size = New System.Drawing.Size(293, 22)
            textBox50.Size = size
            Me.TextBox1.TabIndex = 0
            Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            Me.Label22.AutoSize = True
            Me.Label22.BackColor = System.Drawing.Color.Transparent
            Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.Label22.ForeColor = System.Drawing.Color.Black
            Dim label29 As System.Windows.Forms.Label = Me.Label22
            location = New System.Drawing.Point(1, 165)
            label29.Location = location
            Me.Label22.Name = "Label22"
            Dim label30 As System.Windows.Forms.Label = Me.Label22
            size = New System.Drawing.Size(124, 16)
            label30.Size = size
            Me.Label22.TabIndex = 69
            Me.Label22.Text = "Screen Resolution :"
            Me.Label20.AutoSize = True
            Me.Label20.BackColor = System.Drawing.Color.Transparent
            Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.Label20.ForeColor = System.Drawing.Color.Black
            Dim label31 As System.Windows.Forms.Label = Me.Label20
            location = New System.Drawing.Point(1, 142)
            label31.Location = location
            Me.Label20.Name = "Label20"
            Dim label32 As System.Windows.Forms.Label = Me.Label20
            size = New System.Drawing.Size(60, 16)
            label32.Size = size
            Me.Label20.TabIndex = 66
            Me.Label20.Text = "Version :"
            Me.Label18.AutoSize = True
            Me.Label18.BackColor = System.Drawing.Color.Transparent
            Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.Label18.ForeColor = System.Drawing.Color.Black
            Dim label33 As System.Windows.Forms.Label = Me.Label18
            location = New System.Drawing.Point(1, 119)
            label33.Location = location
            Me.Label18.Name = "Label18"
            Dim label34 As System.Windows.Forms.Label = Me.Label18
            size = New System.Drawing.Size(63, 16)
            label34.Size = size
            Me.Label18.TabIndex = 63
            Me.Label18.Text = "Platform :"
            Me.Label16.AutoSize = True
            Me.Label16.BackColor = System.Drawing.Color.Transparent
            Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.Label16.ForeColor = System.Drawing.Color.Black
            Dim label35 As System.Windows.Forms.Label = Me.Label16
            location = New System.Drawing.Point(1, 96)
            label35.Location = location
            Me.Label16.Name = "Label16"
            Dim label36 As System.Windows.Forms.Label = Me.Label16
            size = New System.Drawing.Size(121, 16)
            label36.Size = size
            Me.Label16.TabIndex = 60
            Me.Label16.Text = "Operating System :"
            Me.Label23.AutoSize = True
            Me.Label23.BackColor = System.Drawing.Color.Transparent
            Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.Label23.ForeColor = System.Drawing.Color.Black
            Dim label37 As System.Windows.Forms.Label = Me.Label23
            location = New System.Drawing.Point(1, 73)
            label37.Location = location
            Me.Label23.Name = "Label23"
            Dim label38 As System.Windows.Forms.Label = Me.Label23
            size = New System.Drawing.Size(120, 16)
            label38.Size = size
            Me.Label23.TabIndex = 57
            Me.Label23.Text = "RAM Full Memory :"
            Me.Label25.AutoSize = True
            Me.Label25.BackColor = System.Drawing.Color.Transparent
            Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.Label25.ForeColor = System.Drawing.Color.Black
            Dim label39 As System.Windows.Forms.Label = Me.Label25
            location = New System.Drawing.Point(1, 50)
            label39.Location = location
            Me.Label25.Name = "Label25"
            Dim label40 As System.Windows.Forms.Label = Me.Label25
            size = New System.Drawing.Size(129, 16)
            label40.Size = size
            Me.Label25.TabIndex = 54
            Me.Label25.Text = "RAM Avail Memory :"
            Me.Label27.AutoSize = True
            Me.Label27.BackColor = System.Drawing.Color.Transparent
            Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.Label27.ForeColor = System.Drawing.Color.Black
            Dim label41 As System.Windows.Forms.Label = Me.Label27
            location = New System.Drawing.Point(1, 211)
            label41.Location = location
            Me.Label27.Name = "Label27"
            Dim label42 As System.Windows.Forms.Label = Me.Label27
            size = New System.Drawing.Size(121, 16)
            label42.Size = size
            Me.Label27.TabIndex = 51
            Me.Label27.Text = "Online IP Address :"
            Me.Label32.AutoSize = True
            Me.Label32.BackColor = System.Drawing.Color.Transparent
            Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.Label32.ForeColor = System.Drawing.Color.Black
            Dim label43 As System.Windows.Forms.Label = Me.Label32
            location = New System.Drawing.Point(1, 27)
            label43.Location = location
            Me.Label32.Name = "Label32"
            Dim label44 As System.Windows.Forms.Label = Me.Label32
            size = New System.Drawing.Size(83, 16)
            label44.Size = size
            Me.Label32.TabIndex = 42
            Me.Label32.Text = "User Name :"
            Me.Label33.AutoSize = True
            Me.Label33.BackColor = System.Drawing.Color.Transparent
            Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.Label33.ForeColor = System.Drawing.Color.Black
            Dim label45 As System.Windows.Forms.Label = Me.Label33
            location = New System.Drawing.Point(1, 234)
            label45.Location = location
            Me.Label33.Name = "Label33"
            Dim label46 As System.Windows.Forms.Label = Me.Label33
            size = New System.Drawing.Size(97, 16)
            label46.Size = size
            Me.Label33.TabIndex = 41
            Me.Label33.Text = "MAC Address :"
            Me.Label34.AutoSize = True
            Me.Label34.BackColor = System.Drawing.Color.Transparent
            Me.Label34.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.Label34.ForeColor = System.Drawing.Color.Black
            Dim label47 As System.Windows.Forms.Label = Me.Label34
            location = New System.Drawing.Point(1, 4)
            label47.Location = location
            Me.Label34.Name = "Label34"
            Dim label48 As System.Windows.Forms.Label = Me.Label34
            size = New System.Drawing.Size(112, 16)
            label48.Size = size
            Me.Label34.TabIndex = 40
            Me.Label34.Text = "Computer Name :"
            Me.Label35.AutoSize = True
            Me.Label35.BackColor = System.Drawing.Color.Transparent
            Me.Label35.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.Label35.ForeColor = System.Drawing.Color.Black
            Dim label49 As System.Windows.Forms.Label = Me.Label35
            location = New System.Drawing.Point(1, 188)
            label49.Location = location
            Me.Label35.Name = "Label35"
            Dim label50 As System.Windows.Forms.Label = Me.Label35
            size = New System.Drawing.Size(116, 16)
            label50.Size = size
            Me.Label35.TabIndex = 39
            Me.Label35.Text = "Local IP Address :"
            Dim autoScaleDimensions As System.Drawing.SizeF = New System.Drawing.SizeF(8F, 16F)
            MyBase.AutoScaleDimensions = autoScaleDimensions
            MyBase.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(102, 106, 105)
            size = New System.Drawing.Size(441, 342)
            MyBase.ClientSize = size
            MyBase.Controls.Add(Me.TabControl1)
            MyBase.Controls.Add(Me.MenuStrip1)
            Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            MyBase.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            MyBase.Icon = CType(componentResourceManager.GetObject("$this.Icon"), System.Drawing.Icon)
            MyBase.MainMenuStrip = Me.MenuStrip1
            padding = New System.Windows.Forms.Padding(4)
            MyBase.Margin = padding
            MyBase.MaximizeBox = False
            MyBase.MinimizeBox = False
            MyBase.Name = "frmSystemInfo"
            MyBase.ShowInTaskbar = False
            MyBase.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "System Information"
            Me.MenuStrip1.ResumeLayout(False)
            Me.MenuStrip1.PerformLayout()
            Me.TabControl1.ResumeLayout(False)
            Me.TabPage1.ResumeLayout(False)
            Me.TabPage1.PerformLayout()
            Me.TabPage2.ResumeLayout(False)
            Me.TabPage2.PerformLayout()
            Me.TabPage3.ResumeLayout(False)
            Me.TabPage3.PerformLayout()
            MyBase.ResumeLayout(False)
            MyBase.PerformLayout()
        End Sub
    End Class
End Namespace

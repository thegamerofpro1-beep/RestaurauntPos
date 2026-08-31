Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices
Imports RestaurantPOS14.My

Namespace RestaurantPOS14

    <Microsoft.VisualBasic.CompilerServices.DesignerGeneratedAttribute>
    Public Class frmMenuItemsList
        Inherits System.Windows.Forms.Form

        Private Shared __ENCList As System.Collections.Generic.List(Of System.WeakReference) = New System.Collections.Generic.List(Of System.WeakReference)()

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnSelect")>
        Private _btnSelect As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Timer1")>
        Private _Timer1 As System.Windows.Forms.Timer

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("listView1")>
        Private _listView1 As System.Windows.Forms.ListView

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnReset")>
        Private _btnReset As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Panel1")>
        Private _Panel1 As System.Windows.Forms.Panel

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Panel2")>
        Private _Panel2 As System.Windows.Forms.Panel

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label4")>
        Private _Label4 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("ColumnHeader5")>
        Private _ColumnHeader5 As System.Windows.Forms.ColumnHeader

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("ColumnHeader1")>
        Private _ColumnHeader1 As System.Windows.Forms.ColumnHeader

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnCancel")>
        Private _btnCancel As System.Windows.Forms.Button

        Private components As System.ComponentModel.IContainer

        Friend Overridable Property btnSelect As System.Windows.Forms.Button
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnSelect
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Button)
                Dim value2 As System.EventHandler = AddressOf Me.btnSelect_Click
                If Me._btnSelect IsNot Nothing Then
                    RemoveHandler Me._btnSelect.Click, value2
                End If

                Me._btnSelect = value
                If Me._btnSelect IsNot Nothing Then
                    AddHandler Me._btnSelect.Click, value2
                End If
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
                Me._Timer1 = value
            End Set
        End Property

        Friend Overridable Property listView1 As System.Windows.Forms.ListView
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._listView1
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.ListView)
                Me._listView1 = value
            End Set
        End Property

        Friend Overridable Property btnReset As System.Windows.Forms.Button
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnReset
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Button)
                Dim value2 As System.EventHandler = AddressOf Me.btnReset_Click
                If Me._btnReset IsNot Nothing Then
                    RemoveHandler Me._btnReset.Click, value2
                End If

                Me._btnReset = value
                If Me._btnReset IsNot Nothing Then
                    AddHandler Me._btnReset.Click, value2
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

        Friend Overridable Property ColumnHeader5 As System.Windows.Forms.ColumnHeader
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._ColumnHeader5
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.ColumnHeader)
                Me._ColumnHeader5 = value
            End Set
        End Property

        Friend Overridable Property ColumnHeader1 As System.Windows.Forms.ColumnHeader
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._ColumnHeader1
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.ColumnHeader)
                Me._ColumnHeader1 = value
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
                Dim value2 As System.EventHandler = AddressOf Me.btnCancel_Click_1
                If Me._btnCancel IsNot Nothing Then
                    RemoveHandler Me._btnCancel.Click, value2
                End If

                Me._btnCancel = value
                If Me._btnCancel IsNot Nothing Then
                    AddHandler Me._btnCancel.Click, value2
                End If
            End Set
        End Property

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Public Sub New()
            Call RestaurantPOS14.frmMenuItemsList.__ENCAddToList(Me)
            Me.InitializeComponent()
        End Sub

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Private Shared Sub __ENCAddToList(value As Object)
            SyncLock RestaurantPOS14.frmMenuItemsList.__ENCList
                If RestaurantPOS14.frmMenuItemsList.__ENCList.Count = RestaurantPOS14.frmMenuItemsList.__ENCList.Capacity Then
                    Dim num As Integer = 0
                    Dim num2 As Integer = RestaurantPOS14.frmMenuItemsList.__ENCList.Count - 1
                    Dim num3 As Integer = 0
                    While True
                        Dim num4 As Integer = num3
                        Dim num5 As Integer = num2
                        If num4 > num5 Then
                            Exit While
                        End If

                        If RestaurantPOS14.frmMenuItemsList.__ENCList(CInt((num3))).IsAlive Then
                            If num3 <> num Then
                                RestaurantPOS14.frmMenuItemsList.__ENCList(num) = RestaurantPOS14.frmMenuItemsList.__ENCList(num3)
                            End If

                            num += 1
                        End If

                        num3 += 1
                    End While

                    Call RestaurantPOS14.frmMenuItemsList.__ENCList.RemoveRange(num, RestaurantPOS14.frmMenuItemsList.__ENCList.Count - num)
                    RestaurantPOS14.frmMenuItemsList.__ENCList.Capacity = RestaurantPOS14.frmMenuItemsList.__ENCList.Count
                End If

                Call RestaurantPOS14.frmMenuItemsList.__ENCList.Add(New System.WeakReference(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(value)))
            End SyncLock
        End Sub

        Public Sub GetData()
            Try
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("Select RTRIM(DishName),RTRIM(DishNameArabic) from Dish order by DishName", RestaurantPOS14.ModClasses.con)
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                Me.listView1.Items.Clear()
                While RestaurantPOS14.ModClasses.rdr.Read()
                    Dim listViewItem As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem()
                    listViewItem.Text = RestaurantPOS14.ModClasses.rdr(CInt((0))).ToString().Trim()
                    listViewItem.SubItems.Add(RestaurantPOS14.ModClasses.rdr(CInt((1))).ToString().Trim())
                    Me.listView1.Items.Add(listViewItem)
                End While

                RestaurantPOS14.ModClasses.con.Close()
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Public Sub Reset()
            Dim num As Integer = Me.listView1.Items.Count - 1
            Dim num2 As Integer = 0
            While True
                Dim num3 As Integer = num2
                Dim num4 As Integer = num
                If num3 > num4 Then
                    Exit While
                End If

                Me.listView1.Items(CInt((num2))).Checked = False
                num2 += 1
            End While

            Me.GetData()
        End Sub

        Private Sub btnReset_Click(sender As Object, e As System.EventArgs)
            Me.Reset()
        End Sub

        Private Sub btnCancel_Click(sender As Object, e As System.EventArgs)
            MyBase.Close()
        End Sub

        Private Sub btnSelect_Click(sender As Object, e As System.EventArgs)
            Try
                If Me.listView1.CheckedItems.Count <= 0 Then
                    Return
                End If

                Dim text As String = ""
                Dim text2 As String = ""
                Dim num As Integer = Me.listView1.CheckedItems.Count - 1
                Dim num2 As Integer = 0
                While True
                    Dim num3 As Integer = num2
                    Dim num4 As Integer = num
                    If num3 > num4 Then
                        Exit While
                    End If

                    text = text & Me.listView1.CheckedItems(CInt((num2))).Text & " " & Global.Microsoft.VisualBasic.Constants.vbCrLf
                    num2 += 1
                End While

                Dim num5 As Integer = Me.listView1.CheckedItems.Count - 1
                Dim num6 As Integer = 0
                While True
                    Dim num7 As Integer = num6
                    Dim num8 As Integer = num5
                    If num7 > num8 Then
                        Exit While
                    End If

                    text2 = text2 & Me.listView1.CheckedItems(CInt((num6))).SubItems(CInt((1))).Text & " " & Global.Microsoft.VisualBasic.Constants.vbCrLf
                    num6 += 1
                End While

                RestaurantPOS14.My.MyProject.Forms.frmMenuItem.txtItemName.Text = ""
                RestaurantPOS14.My.MyProject.Forms.frmMenuItem.txtItemNameArabic.Text = ""
                RestaurantPOS14.My.MyProject.Forms.frmMenuItem.txtItemName.Text = text.Trim()
                RestaurantPOS14.My.MyProject.Forms.frmMenuItem.txtItemNameArabic.Text = text2.Trim()
                MyBase.Hide()
                Call RestaurantPOS14.My.MyProject.Forms.frmMenuItem.Show()
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Private Sub btnCancel_Click_1(sender As Object, e As System.EventArgs)
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
            Dim componentResourceManager As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RestaurantPOS14.frmMenuItemsList))
            Me.btnSelect = New System.Windows.Forms.Button()
            Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
            Me.listView1 = New System.Windows.Forms.ListView()
            Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader()
            Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader()
            Me.btnReset = New System.Windows.Forms.Button()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.Panel2 = New System.Windows.Forms.Panel()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.btnCancel = New System.Windows.Forms.Button()
            Me.Panel1.SuspendLayout()
            Me.Panel2.SuspendLayout()
            MyBase.SuspendLayout()
            Me.btnSelect.BackColor = System.Drawing.Color.FromArgb(58, 58, 56)
            Me.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Popup
            Me.btnSelect.ForeColor = System.Drawing.Color.White
            Dim button As System.Windows.Forms.Button = Me.btnSelect
            Dim location As System.Drawing.Point = New System.Drawing.Point(8, 11)
            button.Location = location
            Me.btnSelect.Name = "btnSelect"
            Dim button2 As System.Windows.Forms.Button = Me.btnSelect
            Dim size As System.Drawing.Size = New System.Drawing.Size(96, 43)
            button2.Size = size
            Me.btnSelect.TabIndex = 23
            Me.btnSelect.Text = "Select"
            Me.btnSelect.UseVisualStyleBackColor = False
            Me.listView1.CheckBoxes = True
            Me.listView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader(1) {Me.ColumnHeader5, Me.ColumnHeader1})
            Me.listView1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.listView1.GridLines = True
            Dim listView As System.Windows.Forms.ListView = Me.listView1
            location = New System.Drawing.Point(8, 60)
            listView.Location = location
            Me.listView1.Name = "listView1"
            Dim listView2 As System.Windows.Forms.ListView = Me.listView1
            size = New System.Drawing.Size(815, 466)
            listView2.Size = size
            Me.listView1.TabIndex = 67
            Me.listView1.UseCompatibleStateImageBehavior = False
            Me.listView1.View = System.Windows.Forms.View.Details
            Me.ColumnHeader5.Text = "Item Name (EN)"
            Me.ColumnHeader5.Width = 400
            Me.ColumnHeader1.Text = "Item Name (Arabic)"
            Me.ColumnHeader1.Width = 400
            Me.btnReset.BackColor = System.Drawing.Color.FromArgb(58, 58, 56)
            Me.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup
            Me.btnReset.ForeColor = System.Drawing.Color.White
            Dim button3 As System.Windows.Forms.Button = Me.btnReset
            location = New System.Drawing.Point(110, 11)
            button3.Location = location
            Me.btnReset.Name = "btnReset"
            Dim button4 As System.Windows.Forms.Button = Me.btnReset
            size = New System.Drawing.Size(102, 43)
            button4.Size = size
            Me.btnReset.TabIndex = 69
            Me.btnReset.Text = "Reset"
            Me.btnReset.UseVisualStyleBackColor = False
            Me.Panel1.BackColor = System.Drawing.Color.White
            Me.Panel1.Controls.Add(Me.btnReset)
            Me.Panel1.Controls.Add(Me.listView1)
            Me.Panel1.Controls.Add(Me.btnSelect)
            Dim panel As System.Windows.Forms.Panel = Me.Panel1
            location = New System.Drawing.Point(4, 52)
            panel.Location = location
            Me.Panel1.Name = "Panel1"
            Dim panel2 As System.Windows.Forms.Panel = Me.Panel1
            size = New System.Drawing.Size(877, 534)
            panel2.Size = size
            Me.Panel1.TabIndex = 71
            Me.Panel2.BackColor = System.Drawing.Color.FromArgb(58, 58, 56)
            Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.Panel2.Controls.Add(Me.Label4)
            Dim panel3 As System.Windows.Forms.Panel = Me.Panel2
            location = New System.Drawing.Point(0, 0)
            panel3.Location = location
            Me.Panel2.Name = "Panel2"
            Dim panel4 As System.Windows.Forms.Panel = Me.Panel2
            size = New System.Drawing.Size(827, 48)
            panel4.Size = size
            Me.Panel2.TabIndex = 72
            Me.Label4.AutoSize = True
            Me.Label4.BackColor = System.Drawing.Color.Transparent
            Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.Label4.ForeColor = System.Drawing.Color.White
            Dim label As System.Windows.Forms.Label = Me.Label4
            location = New System.Drawing.Point(297, 9)
            label.Location = location
            Me.Label4.Name = "Label4"
            Dim label2 As System.Windows.Forms.Label = Me.Label4
            size = New System.Drawing.Size(164, 30)
            label2.Size = size
            Me.Label4.TabIndex = 0
            Me.Label4.Text = "Menu Items List"
            Me.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right
            Me.btnCancel.BackColor = System.Drawing.Color.Transparent
            Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.btnCancel.FlatAppearance.BorderSize = 0
            Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnCancel.Image = CType(componentResourceManager.GetObject("btnCancel.Image"), System.Drawing.Image)
            Dim button5 As System.Windows.Forms.Button = Me.btnCancel
            location = New System.Drawing.Point(833, 0)
            button5.Location = location
            Me.btnCancel.Name = "btnCancel"
            Dim button6 As System.Windows.Forms.Button = Me.btnCancel
            size = New System.Drawing.Size(52, 49)
            button6.Size = size
            Me.btnCancel.TabIndex = 73
            Me.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnCancel.UseVisualStyleBackColor = False
            Dim autoScaleDimensions As System.Drawing.SizeF = New System.Drawing.SizeF(6F, 13F)
            MyBase.AutoScaleDimensions = autoScaleDimensions
            MyBase.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(58, 58, 56)
            size = New System.Drawing.Size(886, 590)
            MyBase.ClientSize = size
            MyBase.Controls.Add(Me.btnCancel)
            MyBase.Controls.Add(Me.Panel2)
            MyBase.Controls.Add(Me.Panel1)
            MyBase.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            MyBase.Icon = CType(componentResourceManager.GetObject("$this.Icon"), System.Drawing.Icon)
            MyBase.MaximizeBox = False
            MyBase.MinimizeBox = False
            MyBase.Name = "frmMenuItemsList"
            MyBase.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Barcode Label Printing"
            Me.Panel1.ResumeLayout(False)
            Me.Panel2.ResumeLayout(False)
            Me.Panel2.PerformLayout()
            MyBase.ResumeLayout(False)
        End Sub
    End Class
End Namespace

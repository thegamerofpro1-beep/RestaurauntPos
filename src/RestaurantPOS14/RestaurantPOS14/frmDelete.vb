Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices
Imports RestaurantPOS14.My

Namespace RestaurantPOS14

    <Microsoft.VisualBasic.CompilerServices.DesignerGeneratedAttribute>
    Public Class frmDelete
        Inherits System.Windows.Forms.Form

        Private Shared __ENCList As System.Collections.Generic.List(Of System.WeakReference) = New System.Collections.Generic.List(Of System.WeakReference)()

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Button1")>
        Private _Button1 As System.Windows.Forms.Button

        Private components As System.ComponentModel.IContainer

        Friend Overridable Property Button1 As System.Windows.Forms.Button
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Button1
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Button)
                Dim value2 As System.EventHandler = AddressOf Me.Button1_Click
                If Me._Button1 IsNot Nothing Then
                    RemoveHandler Me._Button1.Click, value2
                End If

                Me._Button1 = value
                If Me._Button1 IsNot Nothing Then
                    AddHandler Me._Button1.Click, value2
                End If
            End Set
        End Property

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Public Sub New()
            AddHandler MyBase.Load, AddressOf Me.frmDelete_Load
            Call RestaurantPOS14.frmDelete.__ENCAddToList(Me)
            Me.InitializeComponent()
        End Sub

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Private Shared Sub __ENCAddToList(value As Object)
            SyncLock RestaurantPOS14.frmDelete.__ENCList
                If RestaurantPOS14.frmDelete.__ENCList.Count = RestaurantPOS14.frmDelete.__ENCList.Capacity Then
                    Dim num As Integer = 0
                    Dim num2 As Integer = RestaurantPOS14.frmDelete.__ENCList.Count - 1
                    Dim num3 As Integer = 0
                    While True
                        Dim num4 As Integer = num3
                        Dim num5 As Integer = num2
                        If num4 > num5 Then
                            Exit While
                        End If

                        If RestaurantPOS14.frmDelete.__ENCList(CInt((num3))).IsAlive Then
                            If num3 <> num Then
                                RestaurantPOS14.frmDelete.__ENCList(num) = RestaurantPOS14.frmDelete.__ENCList(num3)
                            End If

                            num += 1
                        End If

                        num3 += 1
                    End While

                    Call RestaurantPOS14.frmDelete.__ENCList.RemoveRange(num, RestaurantPOS14.frmDelete.__ENCList.Count - num)
                    RestaurantPOS14.frmDelete.__ENCList.Capacity = RestaurantPOS14.frmDelete.__ENCList.Count
                End If

                Call RestaurantPOS14.frmDelete.__ENCList.Add(New System.WeakReference(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(value)))
            End SyncLock
        End Sub

        Private Sub Button1_Click(sender As Object, e As System.EventArgs)
            RestaurantPOS14.ModFunc.DeleteTable(RestaurantPOS14.My.MyProject.Forms.frmTableLayoutSettings.acControl.Text)
            Call RestaurantPOS14.My.MyProject.Forms.frmTableLayoutSettings.pnlTables.Controls.Remove(RestaurantPOS14.My.MyProject.Forms.frmTableLayoutSettings.acControl)
            Call RestaurantPOS14.My.MyProject.Forms.frmTableLayoutSettings.GetData()
            Call RestaurantPOS14.My.MyProject.Forms.frmTableLayoutSettings.fillTableNo()
            MyBase.Hide()
            Call RestaurantPOS14.My.MyProject.Forms.frmTableLayoutSettings.Show()
        End Sub

        Private Sub frmDelete_Load(sender As Object, e As System.EventArgs)
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
            Me.Button1 = New System.Windows.Forms.Button()
            MyBase.SuspendLayout()
            Me.Button1.BackColor = System.Drawing.Color.FromArgb(192, 0, 0)
            Me.Button1.FlatAppearance.BorderSize = 0
            Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.Button1.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.Button1.ForeColor = System.Drawing.Color.White
            Dim button As System.Windows.Forms.Button = Me.Button1
            Dim location As System.Drawing.Point = New System.Drawing.Point(-2, 1)
            button.Location = location
            Me.Button1.Name = "Button1"
            Dim button2 As System.Windows.Forms.Button = Me.Button1
            Dim size As System.Drawing.Size = New System.Drawing.Size(215, 81)
            button2.Size = size
            Me.Button1.TabIndex = 0
            Me.Button1.Text = "Delete"
            Me.Button1.UseVisualStyleBackColor = False
            Dim autoScaleDimensions As System.Drawing.SizeF = New System.Drawing.SizeF(6F, 13F)
            MyBase.AutoScaleDimensions = autoScaleDimensions
            MyBase.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            size = New System.Drawing.Size(213, 84)
            MyBase.ClientSize = size
            MyBase.Controls.Add(Me.Button1)
            MyBase.MaximizeBox = False
            MyBase.MinimizeBox = False
            MyBase.Name = "frmDelete"
            MyBase.ShowIcon = False
            MyBase.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            MyBase.ResumeLayout(False)
        End Sub
    End Class
End Namespace

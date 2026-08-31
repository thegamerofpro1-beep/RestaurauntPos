Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Data.SqlClient
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices

Namespace RestaurantPOS14

    <Microsoft.VisualBasic.CompilerServices.DesignerGeneratedAttribute>
    Public Class frmSecondaryDisplay
        Inherits System.Windows.Forms.Form

        Private Shared __ENCList As System.Collections.Generic.List(Of System.WeakReference) = New System.Collections.Generic.List(Of System.WeakReference)()

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("DataGridView1")>
        Private _DataGridView1 As System.Windows.Forms.DataGridView

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("PictureBox1")>
        Private _PictureBox1 As System.Windows.Forms.PictureBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Panel1")>
        Private _Panel1 As System.Windows.Forms.Panel

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("lblContactNo")>
        Private _lblContactNo As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("lblFooter")>
        Private _lblFooter As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("lblAddress2")>
        Private _lblAddress2 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("lblAddress1")>
        Private _lblAddress1 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("lblRestaurantName")>
        Private _lblRestaurantName As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label2")>
        Private _Label2 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("lblTotal")>
        Private _lblTotal As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("pbSlideShow")>
        Private _pbSlideShow As System.Windows.Forms.PictureBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("TableLayoutPanel1")>
        Private _TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Timer1")>
        Private _Timer1 As System.Windows.Forms.Timer

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("imageFolderBrowserDlg")>
        Private _imageFolderBrowserDlg As System.Windows.Forms.FolderBrowserDialog

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label4")>
        Private _Label4 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("lblHST")>
        Private _lblHST As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Column1")>
        Private _Column1 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Column2")>
        Private _Column2 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Column3")>
        Private _Column3 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Column11")>
        Private _Column11 As System.Windows.Forms.DataGridViewTextBoxColumn

        Private imageFiles As String()

        Private selected As Integer

        Private begin As Integer

        Private [end] As Integer

        Private components As System.ComponentModel.IContainer

        Friend Overridable Property DataGridView1 As System.Windows.Forms.DataGridView
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._DataGridView1
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.DataGridView)
                Me._DataGridView1 = value
            End Set
        End Property

        Friend Overridable Property PictureBox1 As System.Windows.Forms.PictureBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._PictureBox1
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.PictureBox)
                Me._PictureBox1 = value
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

        Friend Overridable Property lblContactNo As System.Windows.Forms.Label
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._lblContactNo
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Label)
                Me._lblContactNo = value
            End Set
        End Property

        Friend Overridable Property lblFooter As System.Windows.Forms.Label
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._lblFooter
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Label)
                Me._lblFooter = value
            End Set
        End Property

        Friend Overridable Property lblAddress2 As System.Windows.Forms.Label
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._lblAddress2
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Label)
                Me._lblAddress2 = value
            End Set
        End Property

        Friend Overridable Property lblAddress1 As System.Windows.Forms.Label
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._lblAddress1
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Label)
                Me._lblAddress1 = value
            End Set
        End Property

        Friend Overridable Property lblRestaurantName As System.Windows.Forms.Label
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._lblRestaurantName
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Label)
                Me._lblRestaurantName = value
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

        Friend Overridable Property lblTotal As System.Windows.Forms.Label
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._lblTotal
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Label)
                Me._lblTotal = value
            End Set
        End Property

        Friend Overridable Property pbSlideShow As System.Windows.Forms.PictureBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._pbSlideShow
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.PictureBox)
                Me._pbSlideShow = value
            End Set
        End Property

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

        Friend Overridable Property imageFolderBrowserDlg As System.Windows.Forms.FolderBrowserDialog
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._imageFolderBrowserDlg
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.FolderBrowserDialog)
                Me._imageFolderBrowserDlg = value
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

        Friend Overridable Property lblHST As System.Windows.Forms.Label
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._lblHST
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Label)
                Me._lblHST = value
            End Set
        End Property

        Friend Overridable Property Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Column1
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.DataGridViewTextBoxColumn)
                Me._Column1 = value
            End Set
        End Property

        Friend Overridable Property Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Column2
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.DataGridViewTextBoxColumn)
                Me._Column2 = value
            End Set
        End Property

        Friend Overridable Property Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Column3
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.DataGridViewTextBoxColumn)
                Me._Column3 = value
            End Set
        End Property

        Friend Overridable Property Column11 As System.Windows.Forms.DataGridViewTextBoxColumn
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Column11
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.DataGridViewTextBoxColumn)
                Me._Column11 = value
            End Set
        End Property

        Public Sub New()
            AddHandler MyBase.Load, AddressOf Me.frmSecondaryDisplay_Load
            Call RestaurantPOS14.frmSecondaryDisplay.__ENCAddToList(Me)
            Me.imageFiles = Nothing
            Me.selected = 0
            Me.begin = 0
            Me.[end] = 0
            Me.InitializeComponent()
        End Sub

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Private Shared Sub __ENCAddToList(value As Object)
            SyncLock RestaurantPOS14.frmSecondaryDisplay.__ENCList
                If RestaurantPOS14.frmSecondaryDisplay.__ENCList.Count = RestaurantPOS14.frmSecondaryDisplay.__ENCList.Capacity Then
                    Dim num As Integer = 0
                    Dim num2 As Integer = RestaurantPOS14.frmSecondaryDisplay.__ENCList.Count - 1
                    Dim num3 As Integer = 0
                    While True
                        Dim num4 As Integer = num3
                        Dim num5 As Integer = num2
                        If num4 > num5 Then
                            Exit While
                        End If

                        If RestaurantPOS14.frmSecondaryDisplay.__ENCList(CInt((num3))).IsAlive Then
                            If num3 <> num Then
                                RestaurantPOS14.frmSecondaryDisplay.__ENCList(num) = RestaurantPOS14.frmSecondaryDisplay.__ENCList(num3)
                            End If

                            num += 1
                        End If

                        num3 += 1
                    End While

                    Call RestaurantPOS14.frmSecondaryDisplay.__ENCList.RemoveRange(num, RestaurantPOS14.frmSecondaryDisplay.__ENCList.Count - num)
                    RestaurantPOS14.frmSecondaryDisplay.__ENCList.Capacity = RestaurantPOS14.frmSecondaryDisplay.__ENCList.Count
                End If

                Call RestaurantPOS14.frmSecondaryDisplay.__ENCList.Add(New System.WeakReference(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(value)))
            End SyncLock
        End Sub

        Private Sub frmSecondaryDisplay_Load(sender As Object, e As System.EventArgs)
            Try
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("SELECT RTRIM(HotelName), RTRIM(AddressLine1),RTRIM(AddressLine2),RTRIM(ContactNo),Logo from Hotel", RestaurantPOS14.ModClasses.con)
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection)
                If RestaurantPOS14.ModClasses.rdr.Read() Then
                    Me.lblRestaurantName.Text = RestaurantPOS14.ModClasses.rdr.GetValue(CInt((0))).ToString()
                    Me.lblAddress1.Text = RestaurantPOS14.ModClasses.rdr.GetValue(CInt((1))).ToString()
                    Me.lblAddress2.Text = RestaurantPOS14.ModClasses.rdr.GetValue(CInt((2))).ToString()
                    Me.lblContactNo.Text = "Tel. : " & RestaurantPOS14.ModClasses.rdr.GetValue(CInt((3))).ToString()
                    Dim stream As System.IO.MemoryStream = New System.IO.MemoryStream(CType(RestaurantPOS14.ModClasses.rdr.GetValue(4), Byte()))
                    Me.PictureBox1.Image = System.Drawing.Image.FromStream(stream)
                End If

                RestaurantPOS14.ModClasses.con.Close()
                Me.imageFiles = RestaurantPOS14.frmSecondaryDisplay.GetFiles(RestaurantPOS14.Customization.ApplicationPathResolver.GetSecondaryDisplayImageDirectory(), "*.jpg;*.jpeg;*.png;*.bmp;*.tif;*.tiff;*.gif")
                Me.selected = 0
                Me.begin = 0
                Me.[end] = Me.imageFiles.Length
                Call RestaurantPOS14.frmSecondaryDisplay.ShowImage(Me.imageFiles(Me.selected), Me.pbSlideShow)
                Me.lblHST.Location = New System.Drawing.Point(Me.Label4.Right + 10, Me.lblHST.Location.Y)
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Private Sub btnClose_Click(sender As Object, e As System.EventArgs)
            MyBase.Close()
        End Sub

        Public Shared Sub ShowImage(path As String, pct As System.Windows.Forms.PictureBox)
            pct.ImageLocation = path
        End Sub

        Public Shared Function GetFiles(path As String, searchPattern As String) As String()
            Dim array As String() = searchPattern.Split(";"c)
            Dim list As System.Collections.Generic.List(Of String) = New System.Collections.Generic.List(Of String)()
            Dim array2 As String() = array
            For Each searchPattern2 As String In array2
                Dim stack As System.Collections.Generic.Stack(Of String) = New System.Collections.Generic.Stack(Of String)(20)
                If Not System.IO.Directory.Exists(path) Then
                    Throw New System.ArgumentException()
                End If

                stack.Push(path)
                While stack.Count > 0
                    Dim path2 As String = stack.Pop()
                    Dim directories As String()
                    Try
                        directories = System.IO.Directory.GetDirectories(path2)
                    Catch __unusedUnauthorizedAccessException1__ As System.UnauthorizedAccessException
                        Continue While
                    Catch __unusedDirectoryNotFoundException2__ As System.IO.DirectoryNotFoundException
                        Continue While
                    End Try

                    Try
                        list.AddRange(System.IO.Directory.GetFiles(path2, searchPattern2))
                    Catch __unusedUnauthorizedAccessException1__ As System.UnauthorizedAccessException
                        Continue While
                    Catch __unusedDirectoryNotFoundException2__ As System.IO.DirectoryNotFoundException
                        Continue While
                    End Try

                    Dim array3 As String() = directories
                    For Each item As String In array3
                        stack.Push(item)
                    Next
                End While
            Next

            Return list.ToArray()
        End Function

        Private Sub Timer1_Tick(sender As Object, e As System.EventArgs)
            Me.ShowNextImage()
        End Sub

        Private Sub ShowNextImage()
            Me.selected += 1
            Call RestaurantPOS14.frmSecondaryDisplay.ShowImage(Me.imageFiles(Me.selected Mod Me.imageFiles.Length), Me.pbSlideShow)
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
            Dim dataGridViewCellStyle As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim dataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim dataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim dataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim dataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim dataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim dataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim dataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim componentResourceManager As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RestaurantPOS14.frmSecondaryDisplay))
            Me.DataGridView1 = New System.Windows.Forms.DataGridView()
            Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.lblContactNo = New System.Windows.Forms.Label()
            Me.lblAddress2 = New System.Windows.Forms.Label()
            Me.lblAddress1 = New System.Windows.Forms.Label()
            Me.lblRestaurantName = New System.Windows.Forms.Label()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.lblTotal = New System.Windows.Forms.Label()
            Me.PictureBox1 = New System.Windows.Forms.PictureBox()
            Me.pbSlideShow = New System.Windows.Forms.PictureBox()
            Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
            Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
            Me.imageFolderBrowserDlg = New System.Windows.Forms.FolderBrowserDialog()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.lblHST = New System.Windows.Forms.Label()
            CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.Panel1.SuspendLayout()
            CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.pbSlideShow, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.TableLayoutPanel1.SuspendLayout()
            MyBase.SuspendLayout()
            Me.DataGridView1.AllowUserToAddRows = False
            Me.DataGridView1.AllowUserToDeleteRows = False
            dataGridViewCellStyle.BackColor = System.Drawing.Color.FloralWhite
            Me.DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle
            Me.DataGridView1.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right
            Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
            Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
            Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
            Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(58, 58, 56)
            dataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSteelBlue
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2
            Me.DataGridView1.ColumnHeadersHeight = 24
            Me.DataGridView1.Columns.AddRange(Me.Column1, Me.Column2, Me.Column3, Me.Column11)
            Me.DataGridView1.Cursor = System.Windows.Forms.Cursors.Hand
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
            dataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.DataGridView1.DefaultCellStyle = dataGridViewCellStyle3
            Me.DataGridView1.EnableHeadersVisualStyles = False
            Me.DataGridView1.GridColor = System.Drawing.Color.White
            Dim dataGridView As System.Windows.Forms.DataGridView = Me.DataGridView1
            Dim location As System.Drawing.Point = New System.Drawing.Point(445, 3)
            dataGridView.Location = location
            Me.DataGridView1.MultiSelect = False
            Me.DataGridView1.Name = "DataGridView1"
            Me.DataGridView1.[ReadOnly] = True
            Me.DataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.LightSeaGreen
            dataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Orange
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.DataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4
            Me.DataGridView1.RowHeadersVisible = False
            Me.DataGridView1.RowHeadersWidth = 25
            Me.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White
            dataGridViewCellStyle5.Font = New System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Moccasin
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black
            Me.DataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle5
            Me.DataGridView1.RowTemplate.Height = 45
            Me.DataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
            Me.DataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Dim dataGridView2 As System.Windows.Forms.DataGridView = Me.DataGridView1
            Dim size As System.Drawing.Size = New System.Drawing.Size(436, 192)
            dataGridView2.Size = size
            Me.DataGridView1.TabIndex = 28
            Me.Column1.FillWeight = 170.6349F
            Me.Column1.HeaderText = "Item Name"
            Me.Column1.Name = "Column1"
            Me.Column1.[ReadOnly] = True
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            dataGridViewCellStyle6.NullValue = Nothing
            Me.Column2.DefaultCellStyle = dataGridViewCellStyle6
            Me.Column2.HeaderText = "Rate"
            Me.Column2.Name = "Column2"
            Me.Column2.[ReadOnly] = True
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            Me.Column3.DefaultCellStyle = dataGridViewCellStyle7
            Me.Column3.FillWeight = 48.04989F
            Me.Column3.HeaderText = "Qty."
            Me.Column3.Name = "Column3"
            Me.Column3.[ReadOnly] = True
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            dataGridViewCellStyle8.NullValue = Nothing
            Me.Column11.DefaultCellStyle = dataGridViewCellStyle8
            Me.Column11.FillWeight = 81.3152F
            Me.Column11.HeaderText = "Total Amt."
            Me.Column11.Name = "Column11"
            Me.Column11.[ReadOnly] = True
            Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right
            Me.Panel1.BackColor = System.Drawing.Color.FromArgb(58, 58, 56)
            Me.Panel1.Controls.Add(Me.lblContactNo)
            Me.Panel1.Controls.Add(Me.lblAddress2)
            Me.Panel1.Controls.Add(Me.lblAddress1)
            Me.Panel1.Controls.Add(Me.lblRestaurantName)
            Dim panel As System.Windows.Forms.Panel = Me.Panel1
            location = New System.Drawing.Point(166, 2)
            panel.Location = location
            Me.Panel1.Name = "Panel1"
            Dim panel2 As System.Windows.Forms.Panel = Me.Panel1
            size = New System.Drawing.Size(720, 108)
            panel2.Size = size
            Me.Panel1.TabIndex = 30
            Me.lblFooter = New System.Windows.Forms.Label()
            Me.lblContactNo.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right
            Me.lblContactNo.Font = New System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.lblContactNo.ForeColor = System.Drawing.Color.White
            Dim label As System.Windows.Forms.Label = Me.lblContactNo
            location = New System.Drawing.Point(3, 76)
            label.Location = location
            Me.lblContactNo.Name = "lblContactNo"
            Dim label2 As System.Windows.Forms.Label = Me.lblContactNo
            size = New System.Drawing.Size(714, 20)
            label2.Size = size
            Me.lblContactNo.TabIndex = 4
            Me.lblContactNo.Text = "Tel. -"
            Me.lblContactNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            Me.lblAddress2.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right
            Me.lblAddress2.Font = New System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.lblAddress2.ForeColor = System.Drawing.Color.White
            Dim label3 As System.Windows.Forms.Label = Me.lblAddress2
            location = New System.Drawing.Point(1, 56)
            label3.Location = location
            Me.lblAddress2.Name = "lblAddress2"
            Dim label4 As System.Windows.Forms.Label = Me.lblAddress2
            size = New System.Drawing.Size(716, 20)
            label4.Size = size
            Me.lblAddress2.TabIndex = 2
            Me.lblAddress2.Text = "Address2"
            Me.lblAddress2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            Me.lblAddress1.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right
            Me.lblAddress1.Font = New System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.lblAddress1.ForeColor = System.Drawing.Color.White
            Dim label5 As System.Windows.Forms.Label = Me.lblAddress1
            location = New System.Drawing.Point(1, 36)
            label5.Location = location
            Me.lblAddress1.Name = "lblAddress1"
            Dim label6 As System.Windows.Forms.Label = Me.lblAddress1
            size = New System.Drawing.Size(716, 20)
            label6.Size = size
            Me.lblAddress1.TabIndex = 1
            Me.lblAddress1.Text = "Address1"
            Me.lblAddress1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            Me.lblRestaurantName.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right
            Me.lblRestaurantName.Font = New System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.lblRestaurantName.ForeColor = System.Drawing.Color.White
            Dim label7 As System.Windows.Forms.Label = Me.lblRestaurantName
            location = New System.Drawing.Point(4, 4)
            label7.Location = location
            Me.lblRestaurantName.Name = "lblRestaurantName"
            Dim label8 As System.Windows.Forms.Label = Me.lblRestaurantName
            size = New System.Drawing.Size(716, 32)
            label8.Size = size
            Me.lblRestaurantName.TabIndex = 0
            Me.lblRestaurantName.Text = "Restaurant Name"
            Me.lblRestaurantName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            Me.lblFooter.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right
            Me.lblFooter.Font = New System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.lblFooter.ForeColor = System.Drawing.Color.White
            Dim label9 As System.Windows.Forms.Label = Me.lblFooter
            location = New System.Drawing.Point(1, 84)
            label9.Location = location
            Me.lblFooter.Name = "lblFooter"
            Dim label10 As System.Windows.Forms.Label = Me.lblFooter
            size = New System.Drawing.Size(716, 24)
            label10.Size = size
            Me.lblFooter.TabIndex = 5
            Me.lblFooter.Text = "Developed by Hitech Computer Centre"
            Me.lblFooter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            Me.lblFooter.AutoSize = False
            Me.lblFooter.Padding = New System.Windows.Forms.Padding(0, 4, 0, 0)
            Me.Panel1.Padding = New System.Windows.Forms.Padding(0, 0, 0, 0)
            Me.Panel1.Controls.Add(Me.lblFooter)
            Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right
            Me.Label2.AutoSize = True
            Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Dim label11 As System.Windows.Forms.Label = Me.Label2
            location = New System.Drawing.Point(679, 318)
            label11.Location = location
            Me.Label2.Name = "Label2"
            Dim label12 As System.Windows.Forms.Label = Me.Label2
            size = New System.Drawing.Size(95, 40)
            label12.Size = size
            Me.Label2.TabIndex = 32
            Me.Label2.Text = "Total :"
            Me.lblTotal.Anchor = System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right
            Me.lblTotal.AutoSize = True
            Me.lblTotal.Font = New System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Dim label13 As System.Windows.Forms.Label = Me.lblTotal
            location = New System.Drawing.Point(770, 318)
            label13.Location = location
            Me.lblTotal.Name = "lblTotal"
            Dim label14 As System.Windows.Forms.Label = Me.lblTotal
            size = New System.Drawing.Size(113, 40)
            label14.Size = size
            Me.lblTotal.TabIndex = 33
            Me.lblTotal.Text = "lblTotal"
            Dim pictureBox As System.Windows.Forms.PictureBox = Me.PictureBox1
            location = New System.Drawing.Point(2, 2)
            pictureBox.Location = location
            Me.PictureBox1.Name = "PictureBox1"
            Dim pictureBox2 As System.Windows.Forms.PictureBox = Me.PictureBox1
            size = New System.Drawing.Size(160, 108)
            pictureBox2.Size = size
            Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
            Me.PictureBox1.TabIndex = 29
            Me.PictureBox1.TabStop = False
            Me.pbSlideShow.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right
            Dim pictureBox3 As System.Windows.Forms.PictureBox = Me.pbSlideShow
            location = New System.Drawing.Point(3, 3)
            pictureBox3.Location = location
            Me.pbSlideShow.Name = "pbSlideShow"
            Dim pictureBox4 As System.Windows.Forms.PictureBox = Me.pbSlideShow
            size = New System.Drawing.Size(436, 192)
            pictureBox4.Size = size
            Me.pbSlideShow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
            Me.pbSlideShow.TabIndex = 35
            Me.pbSlideShow.TabStop = False
            Me.TableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right
            Me.TableLayoutPanel1.ColumnCount = 2
            Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F))
            Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F))
            Me.TableLayoutPanel1.Controls.Add(Me.pbSlideShow, 0, 0)
            Me.TableLayoutPanel1.Controls.Add(Me.DataGridView1, 1, 0)
            Dim tableLayoutPanel As System.Windows.Forms.TableLayoutPanel = Me.TableLayoutPanel1
            location = New System.Drawing.Point(2, 116)
            tableLayoutPanel.Location = location
            Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
            Me.TableLayoutPanel1.RowCount = 1
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F))
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 198F))
            Dim tableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel = Me.TableLayoutPanel1
            size = New System.Drawing.Size(884, 198)
            tableLayoutPanel2.Size = size
            Me.TableLayoutPanel1.TabIndex = 36
            Me.Timer1.Enabled = True
            Me.Timer1.Interval = 3000
            Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left
            Me.Label4.AutoSize = True
            Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Dim label15 As System.Windows.Forms.Label = Me.Label4
            location = New System.Drawing.Point(6, 318)
            label15.Location = location
            Me.Label4.Name = "Label4"
            Dim label16 As System.Windows.Forms.Label = Me.Label4
            size = New System.Drawing.Size(82, 40)
            label16.Size = size
            Me.Label4.TabIndex = 38
            Me.Label4.Text = "service charge"
            Me.lblHST.Anchor = System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left
            Me.lblHST.AutoSize = True
            Me.lblHST.Font = New System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Dim label17 As System.Windows.Forms.Label = Me.lblHST
            location = New System.Drawing.Point(320, 318)
            label17.Location = location
            Me.lblHST.Name = "lblHST"
            Dim label18 As System.Windows.Forms.Label = Me.lblHST
            size = New System.Drawing.Size(103, 40)
            label18.Size = size
            Me.lblHST.TabIndex = 40
            Me.lblHST.Text = "lblHST"
            Dim autoScaleDimensions As System.Drawing.SizeF = New System.Drawing.SizeF(6F, 13F)
            MyBase.AutoScaleDimensions = autoScaleDimensions
            MyBase.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            size = New System.Drawing.Size(888, 362)
            MyBase.ClientSize = size
            MyBase.Controls.Add(Me.lblHST)
            MyBase.Controls.Add(Me.Label4)
            MyBase.Controls.Add(Me.TableLayoutPanel1)
            MyBase.Controls.Add(Me.lblTotal)
            MyBase.Controls.Add(Me.Label2)
            MyBase.Controls.Add(Me.Panel1)
            MyBase.Controls.Add(Me.PictureBox1)
            MyBase.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            MyBase.Icon = CType(componentResourceManager.GetObject("$this.Icon"), System.Drawing.Icon)
            MyBase.Name = "frmSecondaryDisplay"
            Me.Text = "Customer Display"
            MyBase.WindowState = System.Windows.Forms.FormWindowState.Maximized
            CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.Panel1.ResumeLayout(False)
            CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.pbSlideShow, System.ComponentModel.ISupportInitialize).EndInit()
            Me.TableLayoutPanel1.ResumeLayout(False)
            MyBase.ResumeLayout(False)
            MyBase.PerformLayout()
        End Sub
    End Class
End Namespace

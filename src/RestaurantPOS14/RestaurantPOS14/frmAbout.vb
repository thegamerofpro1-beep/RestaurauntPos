Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices
Imports RestaurantPOS14.My

Namespace RestaurantPOS14

    <Microsoft.VisualBasic.CompilerServices.DesignerGeneratedAttribute>
    Public NotInheritable Class frmAbout
        Inherits System.Windows.Forms.Form

        Private Shared __ENCList As System.Collections.Generic.List(Of System.WeakReference) = New System.Collections.Generic.List(Of System.WeakReference)()

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("TableLayoutPanel")>
        Private _TableLayoutPanel As System.Windows.Forms.TableLayoutPanel

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("LogoPictureBox")>
        Private _LogoPictureBox As System.Windows.Forms.PictureBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("LabelProductName")>
        Private _LabelProductName As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("LabelVersion")>
        Private _LabelVersion As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("LabelCompanyName")>
        Private _LabelCompanyName As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("TextBoxDescription")>
        Private _TextBoxDescription As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("OKButton")>
        Private _OKButton As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("LabelCopyright")>
        Private _LabelCopyright As System.Windows.Forms.Label

        Private components As System.ComponentModel.IContainer

        Friend Property TableLayoutPanel As System.Windows.Forms.TableLayoutPanel
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._TableLayoutPanel
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TableLayoutPanel)
                Me._TableLayoutPanel = value
            End Set
        End Property

        Friend Property LogoPictureBox As System.Windows.Forms.PictureBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._LogoPictureBox
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.PictureBox)
                Me._LogoPictureBox = value
            End Set
        End Property

        Friend Property LabelProductName As System.Windows.Forms.Label
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._LabelProductName
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Label)
                Me._LabelProductName = value
            End Set
        End Property

        Friend Property LabelVersion As System.Windows.Forms.Label
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._LabelVersion
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Label)
                Me._LabelVersion = value
            End Set
        End Property

        Friend Property LabelCompanyName As System.Windows.Forms.Label
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._LabelCompanyName
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Label)
                Me._LabelCompanyName = value
            End Set
        End Property

        Friend Property TextBoxDescription As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._TextBoxDescription
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._TextBoxDescription = value
            End Set
        End Property

        Friend Property OKButton As System.Windows.Forms.Button
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._OKButton
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Button)
                Dim value2 As System.EventHandler = AddressOf Me.OKButton_Click
                If Me._OKButton IsNot Nothing Then
                    RemoveHandler Me._OKButton.Click, value2
                End If

                Me._OKButton = value
                If Me._OKButton IsNot Nothing Then
                    AddHandler Me._OKButton.Click, value2
                End If
            End Set
        End Property

        Friend Property LabelCopyright As System.Windows.Forms.Label
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._LabelCopyright
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Label)
                Me._LabelCopyright = value
            End Set
        End Property

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Public Sub New()
            AddHandler MyBase.Load, AddressOf Me.frmAbout_Load
            Call RestaurantPOS14.frmAbout.__ENCAddToList(Me)
            Me.InitializeComponent()
        End Sub

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Private Shared Sub __ENCAddToList(value As Object)
            SyncLock RestaurantPOS14.frmAbout.__ENCList
                If RestaurantPOS14.frmAbout.__ENCList.Count = RestaurantPOS14.frmAbout.__ENCList.Capacity Then
                    Dim num As Integer = 0
                    Dim num2 As Integer = RestaurantPOS14.frmAbout.__ENCList.Count - 1
                    Dim num3 As Integer = 0
                    While True
                        Dim num4 As Integer = num3
                        Dim num5 As Integer = num2
                        If num4 > num5 Then
                            Exit While
                        End If

                        If RestaurantPOS14.frmAbout.__ENCList(CInt((num3))).IsAlive Then
                            If num3 <> num Then
                                RestaurantPOS14.frmAbout.__ENCList(num) = RestaurantPOS14.frmAbout.__ENCList(num3)
                            End If

                            num += 1
                        End If

                        num3 += 1
                    End While

                    Call RestaurantPOS14.frmAbout.__ENCList.RemoveRange(num, RestaurantPOS14.frmAbout.__ENCList.Count - num)
                    RestaurantPOS14.frmAbout.__ENCList.Capacity = RestaurantPOS14.frmAbout.__ENCList.Count
                End If

                Call RestaurantPOS14.frmAbout.__ENCList.Add(New System.WeakReference(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(value)))
            End SyncLock
        End Sub

        <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.NoInlining Or System.Runtime.CompilerServices.MethodImplOptions.NoOptimization)>
        Private Sub frmAbout_Load(sender As Object, e As System.EventArgs)
            Dim str As String =(If((Microsoft.VisualBasic.CompilerServices.Operators.CompareString(RestaurantPOS14.My.MyProject.Application.Info.Title, "", TextCompare:=False) = 0), System.IO.Path.GetFileNameWithoutExtension(RestaurantPOS14.My.MyProject.Application.Info.AssemblyName), RestaurantPOS14.My.MyProject.Application.Info.Title))
            MyBase.Text = "About " & str
            Me.LabelProductName.Text = RestaurantPOS14.My.MyProject.Application.Info.ProductName
            Me.LabelVersion.Text = "Version " & RestaurantPOS14.My.MyProject.Application.Info.Version.ToString()
            Me.LabelCopyright.Text = RestaurantPOS14.My.MyProject.Application.Info.Copyright
            Me.LabelCompanyName.Text = RestaurantPOS14.My.MyProject.Application.Info.CompanyName
            Me.TextBoxDescription.Text = RestaurantPOS14.My.MyProject.Application.Info.Description
        End Sub

        Private Sub OKButton_Click(sender As Object, e As System.EventArgs)
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
            Dim componentResourceManager As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RestaurantPOS14.frmAbout))
            Me.TableLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
            Me.LogoPictureBox = New System.Windows.Forms.PictureBox()
            Me.LabelProductName = New System.Windows.Forms.Label()
            Me.LabelVersion = New System.Windows.Forms.Label()
            Me.LabelCopyright = New System.Windows.Forms.Label()
            Me.LabelCompanyName = New System.Windows.Forms.Label()
            Me.TextBoxDescription = New System.Windows.Forms.TextBox()
            Me.OKButton = New System.Windows.Forms.Button()
            Me.TableLayoutPanel.SuspendLayout()
            CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
            MyBase.SuspendLayout()
            Me.TableLayoutPanel.ColumnCount = 2
            Me.TableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37F))
            Me.TableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63F))
            Me.TableLayoutPanel.Controls.Add(Me.LogoPictureBox, 0, 0)
            Me.TableLayoutPanel.Controls.Add(Me.LabelProductName, 1, 0)
            Me.TableLayoutPanel.Controls.Add(Me.LabelVersion, 1, 1)
            Me.TableLayoutPanel.Controls.Add(Me.LabelCopyright, 1, 2)
            Me.TableLayoutPanel.Controls.Add(Me.LabelCompanyName, 1, 3)
            Me.TableLayoutPanel.Controls.Add(Me.TextBoxDescription, 1, 4)
            Me.TableLayoutPanel.Controls.Add(Me.OKButton, 1, 5)
            Me.TableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
            Dim tableLayoutPanel As System.Windows.Forms.TableLayoutPanel = Me.TableLayoutPanel
            Dim location As System.Drawing.Point = New System.Drawing.Point(9, 9)
            tableLayoutPanel.Location = location
            Me.TableLayoutPanel.Name = "TableLayoutPanel"
            Me.TableLayoutPanel.RowCount = 6
            Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F))
            Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F))
            Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F))
            Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F))
            Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F))
            Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F))
            Dim tableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel = Me.TableLayoutPanel
            Dim size As System.Drawing.Size = New System.Drawing.Size(601, 258)
            tableLayoutPanel2.Size = size
            Me.TableLayoutPanel.TabIndex = 0
            Me.LogoPictureBox.Dock = System.Windows.Forms.DockStyle.Fill
            Me.LogoPictureBox.Image = CType(componentResourceManager.GetObject("LogoPictureBox.Image"), System.Drawing.Image)
            Dim logoPictureBox As System.Windows.Forms.PictureBox = Me.LogoPictureBox
            location = New System.Drawing.Point(3, 3)
            logoPictureBox.Location = location
            Me.LogoPictureBox.Name = "LogoPictureBox"
            Me.TableLayoutPanel.SetRowSpan(Me.LogoPictureBox, 6)
            Dim logoPictureBox2 As System.Windows.Forms.PictureBox = Me.LogoPictureBox
            size = New System.Drawing.Size(216, 252)
            logoPictureBox2.Size = size
            Me.LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
            Me.LogoPictureBox.TabIndex = 0
            Me.LogoPictureBox.TabStop = False
            Me.LabelProductName.Dock = System.Windows.Forms.DockStyle.Fill
            Me.LabelProductName.Font = New System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.LabelProductName.ForeColor = System.Drawing.Color.Black
            Dim labelProductName As System.Windows.Forms.Label = Me.LabelProductName
            location = New System.Drawing.Point(228, 0)
            labelProductName.Location = location
            Dim labelProductName2 As System.Windows.Forms.Label = Me.LabelProductName
            Dim padding As System.Windows.Forms.Padding = New System.Windows.Forms.Padding(6, 0, 3, 0)
            labelProductName2.Margin = padding
            Dim labelProductName3 As System.Windows.Forms.Label = Me.LabelProductName
            size = New System.Drawing.Size(0, 17)
            labelProductName3.MaximumSize = size
            Me.LabelProductName.Name = "LabelProductName"
            Dim labelProductName4 As System.Windows.Forms.Label = Me.LabelProductName
            size = New System.Drawing.Size(370, 17)
            labelProductName4.Size = size
            Me.LabelProductName.TabIndex = 0
            Me.LabelProductName.Text = "Product Name"
            Me.LabelProductName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.LabelVersion.Dock = System.Windows.Forms.DockStyle.Fill
            Me.LabelVersion.Font = New System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.LabelVersion.ForeColor = System.Drawing.Color.Black
            Dim labelVersion As System.Windows.Forms.Label = Me.LabelVersion
            location = New System.Drawing.Point(228, 25)
            labelVersion.Location = location
            Dim labelVersion2 As System.Windows.Forms.Label = Me.LabelVersion
            padding = New System.Windows.Forms.Padding(6, 0, 3, 0)
            labelVersion2.Margin = padding
            Dim labelVersion3 As System.Windows.Forms.Label = Me.LabelVersion
            size = New System.Drawing.Size(0, 17)
            labelVersion3.MaximumSize = size
            Me.LabelVersion.Name = "LabelVersion"
            Dim labelVersion4 As System.Windows.Forms.Label = Me.LabelVersion
            size = New System.Drawing.Size(370, 17)
            labelVersion4.Size = size
            Me.LabelVersion.TabIndex = 0
            Me.LabelVersion.Text = "Version"
            Me.LabelVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.LabelCopyright.Dock = System.Windows.Forms.DockStyle.Fill
            Me.LabelCopyright.Font = New System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.LabelCopyright.ForeColor = System.Drawing.Color.Black
            Dim labelCopyright As System.Windows.Forms.Label = Me.LabelCopyright
            location = New System.Drawing.Point(228, 50)
            labelCopyright.Location = location
            Dim labelCopyright2 As System.Windows.Forms.Label = Me.LabelCopyright
            padding = New System.Windows.Forms.Padding(6, 0, 3, 0)
            labelCopyright2.Margin = padding
            Dim labelCopyright3 As System.Windows.Forms.Label = Me.LabelCopyright
            size = New System.Drawing.Size(0, 17)
            labelCopyright3.MaximumSize = size
            Me.LabelCopyright.Name = "LabelCopyright"
            Dim labelCopyright4 As System.Windows.Forms.Label = Me.LabelCopyright
            size = New System.Drawing.Size(370, 17)
            labelCopyright4.Size = size
            Me.LabelCopyright.TabIndex = 0
            Me.LabelCopyright.Text = "Copyright"
            Me.LabelCopyright.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.LabelCompanyName.Dock = System.Windows.Forms.DockStyle.Fill
            Me.LabelCompanyName.Font = New System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.LabelCompanyName.ForeColor = System.Drawing.Color.Black
            Dim labelCompanyName As System.Windows.Forms.Label = Me.LabelCompanyName
            location = New System.Drawing.Point(228, 75)
            labelCompanyName.Location = location
            Dim labelCompanyName2 As System.Windows.Forms.Label = Me.LabelCompanyName
            padding = New System.Windows.Forms.Padding(6, 0, 3, 0)
            labelCompanyName2.Margin = padding
            Dim labelCompanyName3 As System.Windows.Forms.Label = Me.LabelCompanyName
            size = New System.Drawing.Size(0, 17)
            labelCompanyName3.MaximumSize = size
            Me.LabelCompanyName.Name = "LabelCompanyName"
            Dim labelCompanyName4 As System.Windows.Forms.Label = Me.LabelCompanyName
            size = New System.Drawing.Size(370, 17)
            labelCompanyName4.Size = size
            Me.LabelCompanyName.TabIndex = 0
            Me.LabelCompanyName.Text = "Company Name"
            Me.LabelCompanyName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.TextBoxDescription.BackColor = System.Drawing.Color.White
            Me.TextBoxDescription.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TextBoxDescription.Font = New System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.TextBoxDescription.ForeColor = System.Drawing.Color.Black
            Dim textBoxDescription As System.Windows.Forms.TextBox = Me.TextBoxDescription
            location = New System.Drawing.Point(228, 103)
            textBoxDescription.Location = location
            Dim textBoxDescription2 As System.Windows.Forms.TextBox = Me.TextBoxDescription
            padding = New System.Windows.Forms.Padding(6, 3, 3, 3)
            textBoxDescription2.Margin = padding
            Me.TextBoxDescription.Multiline = True
            Me.TextBoxDescription.Name = "TextBoxDescription"
            Me.TextBoxDescription.[ReadOnly] = True
            Me.TextBoxDescription.ScrollBars = System.Windows.Forms.ScrollBars.Both
            Dim textBoxDescription3 As System.Windows.Forms.TextBox = Me.TextBoxDescription
            size = New System.Drawing.Size(370, 123)
            textBoxDescription3.Size = size
            Me.TextBoxDescription.TabIndex = 0
            Me.TextBoxDescription.TabStop = False
            Me.TextBoxDescription.Text = componentResourceManager.GetString("TextBoxDescription.Text")
            Me.OKButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right
            Me.OKButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Dim oKButton As System.Windows.Forms.Button = Me.OKButton
            location = New System.Drawing.Point(523, 232)
            oKButton.Location = location
            Me.OKButton.Name = "OKButton"
            Dim oKButton2 As System.Windows.Forms.Button = Me.OKButton
            size = New System.Drawing.Size(75, 23)
            oKButton2.Size = size
            Me.OKButton.TabIndex = 0
            Me.OKButton.Text = "&OK"
            Dim autoScaleDimensions As System.Drawing.SizeF = New System.Drawing.SizeF(6F, 13F)
            MyBase.AutoScaleDimensions = autoScaleDimensions
            MyBase.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            MyBase.CancelButton = Me.OKButton
            size = New System.Drawing.Size(619, 276)
            MyBase.ClientSize = size
            MyBase.Controls.Add(Me.TableLayoutPanel)
            MyBase.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            MyBase.Icon = CType(componentResourceManager.GetObject("$this.Icon"), System.Drawing.Icon)
            MyBase.MaximizeBox = False
            MyBase.MinimizeBox = False
            MyBase.Name = "frmAbout"
            padding = New System.Windows.Forms.Padding(9)
            MyBase.Padding = padding
            MyBase.ShowInTaskbar = False
            MyBase.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "frmAbout"
            Me.TableLayoutPanel.ResumeLayout(False)
            Me.TableLayoutPanel.PerformLayout()
            CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
            MyBase.ResumeLayout(False)
        End Sub
    End Class
End Namespace

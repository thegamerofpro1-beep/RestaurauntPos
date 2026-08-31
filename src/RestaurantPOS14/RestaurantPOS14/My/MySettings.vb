Imports System
Imports System.CodeDom.Compiler
Imports System.ComponentModel
Imports System.Configuration
Imports System.Diagnostics
Imports System.Runtime.CompilerServices
Imports Microsoft.VisualBasic.CompilerServices

Namespace RestaurantPOS14.My

    <System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0")>
    <System.Runtime.CompilerServices.CompilerGeneratedAttribute>
    <System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)>
    Friend NotInheritable Class MySettings
        Inherits System.Configuration.ApplicationSettingsBase
        Private Shared defaultInstance As RestaurantPOS14.My.MySettings = CType(System.Configuration.SettingsBase.Synchronized(New RestaurantPOS14.My.MySettings()), RestaurantPOS14.My.MySettings)

        Private Shared addedHandler As Boolean

        Private Shared addedHandlerLockObject As Object = System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(New Object())

        Public Shared ReadOnly Property [Default] As RestaurantPOS14.My.MySettings
            Get
                If Not RestaurantPOS14.My.MySettings.addedHandler Then
                    Dim obj As Object = RestaurantPOS14.My.MySettings.addedHandlerLockObject
                    Call Microsoft.VisualBasic.CompilerServices.ObjectFlowControl.CheckForSyncLockOnValueType(obj)
                    SyncLock obj
                        If Not RestaurantPOS14.My.MySettings.addedHandler Then
                            AddHandler RestaurantPOS14.My.MyProject.Application.Shutdown, AddressOf RestaurantPOS14.My.MySettings.AutoSaveSettings
                            RestaurantPOS14.My.MySettings.addedHandler = True
                        End If
                    End SyncLock
                End If
                Return RestaurantPOS14.My.MySettings.defaultInstance
            End Get
        End Property

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        <System.Configuration.ApplicationScopedSettingAttribute>
        <System.Configuration.DefaultSettingValueAttribute("")>
        <System.Configuration.SpecialSettingAttribute(System.Configuration.SpecialSetting.ConnectionString)>
        Public ReadOnly Property RPOS_DBConnectionString As String
            Get
                Return RestaurantPOS14.ConnectionString.cs
            End Get
        End Property

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Public Sub New()
        End Sub

        <System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)>
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Private Shared Sub AutoSaveSettings(sender As Object, e As System.EventArgs)
            If RestaurantPOS14.My.MyProject.Application.SaveMySettingsOnExit Then
                Call RestaurantPOS14.My.MySettingsProperty.Settings.Save()
            End If
        End Sub
    End Class
End Namespace

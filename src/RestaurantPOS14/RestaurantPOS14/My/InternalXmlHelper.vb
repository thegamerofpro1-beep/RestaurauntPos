Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Linq
Imports System.Runtime.CompilerServices
Imports System.Xml.Linq

Namespace RestaurantPOS14.My
    <System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)>
    <System.Runtime.CompilerServices.CompilerGeneratedAttribute>
    <System.Diagnostics.DebuggerNonUserCodeAttribute>
    Friend NotInheritable Class InternalXmlHelper
        <System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)>
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        <System.Runtime.CompilerServices.CompilerGeneratedAttribute>
        Private NotInheritable Class RemoveNamespaceAttributesClosure
            Private ReadOnly m_inScopePrefixes As String()
            Private ReadOnly m_inScopeNs As System.Xml.Linq.XNamespace()
            Private ReadOnly m_attributes As System.Collections.Generic.List(Of System.Xml.Linq.XAttribute)
            <System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)>
            Friend Sub New(inScopePrefixes As String(), inScopeNs As System.Xml.Linq.XNamespace(), attributes As System.Collections.Generic.List(Of System.Xml.Linq.XAttribute))
                Me.m_inScopePrefixes = inScopePrefixes
                Me.m_inScopeNs = inScopeNs
                Me.m_attributes = attributes
            End Sub

            <System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)>
            Friend Function ProcessXElement(elem As System.Xml.Linq.XElement) As System.Xml.Linq.XElement
                Return RestaurantPOS14.My.InternalXmlHelper.RemoveNamespaceAttributes(Me.m_inScopePrefixes, Me.m_inScopeNs, Me.m_attributes, elem)
            End Function

            <System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)>
            Friend Function ProcessObject(obj As Object) As Object
                Dim xelement As System.Xml.Linq.XElement = TryCast(obj, System.Xml.Linq.XElement)

                If xelement IsNot Nothing Then
                    Return RestaurantPOS14.My.InternalXmlHelper.RemoveNamespaceAttributes(Me.m_inScopePrefixes, Me.m_inScopeNs, Me.m_attributes, xelement)
                End If

                Return obj
            End Function

        End Class

        Public Shared Function Value(source As System.Collections.Generic.IEnumerable(Of System.Xml.Linq.XElement)) As String
            Using enumerator As System.Collections.Generic.IEnumerator(Of System.Xml.Linq.XElement) = source?.GetEnumerator()
                If enumerator IsNot Nothing AndAlso enumerator.MoveNext() Then
                    Return enumerator.Current?.Value
                End If
            End Using

            Return Nothing
        End Function

        Public Shared Sub SetValue(source As System.Collections.Generic.IEnumerable(Of System.Xml.Linq.XElement), value As String)
            Using enumerator As System.Collections.Generic.IEnumerator(Of System.Xml.Linq.XElement) = source?.GetEnumerator()
                If enumerator IsNot Nothing AndAlso enumerator.MoveNext() Then
                    Dim xelement As System.Xml.Linq.XElement = enumerator.Current
                    If xelement IsNot Nothing Then
                        xelement.Value = value
                    End If
                End If
            End Using
        End Sub

        Public Shared Function AttributeValue(source As System.Collections.Generic.IEnumerable(Of System.Xml.Linq.XElement), name As System.Xml.Linq.XName) As String
            Using enumerator As System.Collections.Generic.IEnumerator(Of System.Xml.Linq.XElement) = source?.GetEnumerator()
                If enumerator IsNot Nothing AndAlso enumerator.MoveNext() Then
                    Return CStr(enumerator.Current?.Attribute(name))
                End If
            End Using

            Return Nothing
        End Function

        Public Shared Sub SetAttributeValue(source As System.Collections.Generic.IEnumerable(Of System.Xml.Linq.XElement), name As System.Xml.Linq.XName, value As Object)
            Using enumerator As System.Collections.Generic.IEnumerator(Of System.Xml.Linq.XElement) = source?.GetEnumerator()
                If enumerator IsNot Nothing AndAlso enumerator.MoveNext() Then
                    enumerator.Current?.SetAttributeValue(name, value)
                End If
            End Using
        End Sub

        Public Shared Function AttributeValue(source As System.Xml.Linq.XElement, name As System.Xml.Linq.XName) As String
            Return CStr(source?.Attribute(name))
        End Function

        Public Shared Sub SetAttributeValue(source As System.Xml.Linq.XElement, name As System.Xml.Linq.XName, value As Object)
            source?.SetAttributeValue(name, value)
        End Sub

        <System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)>
        Private Sub New()
        End Sub

        <System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)>
        Public Shared Function CreateAttribute(name As System.Xml.Linq.XName, value As Object) As System.Xml.Linq.XAttribute
            If value Is Nothing Then
                Return Nothing
            End If

            Return New System.Xml.Linq.XAttribute(name, System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(value))
        End Function

        <System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)>
        Public Shared Function CreateNamespaceAttribute(name As System.Xml.Linq.XName, ns As System.Xml.Linq.XNamespace) As System.Xml.Linq.XAttribute
            Dim xAttribute As System.Xml.Linq.XAttribute = New System.Xml.Linq.XAttribute(name, ns.NamespaceName)
            xAttribute.AddAnnotation(ns)
            Return xAttribute
        End Function

        <System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)>
        Public Shared Function RemoveNamespaceAttributes(inScopePrefixes As String(), inScopeNs As System.Xml.Linq.XNamespace(), attributes As System.Collections.Generic.List(Of System.Xml.Linq.XAttribute), obj As Object) As Object

            Dim xelement As System.Xml.Linq.XElement = Nothing, enumerable As System.Collections.IEnumerable = Nothing
            If obj IsNot Nothing Then
                xelement = TryCast(obj, System.Xml.Linq.XElement)
                If xelement IsNot Nothing Then
                    Return RestaurantPOS14.My.InternalXmlHelper.RemoveNamespaceAttributes(inScopePrefixes, inScopeNs, attributes, xelement)
                End If

                enumerable = TryCast(obj, System.Collections.IEnumerable)
                If enumerable IsNot Nothing Then
                    Return RestaurantPOS14.My.InternalXmlHelper.RemoveNamespaceAttributes(inScopePrefixes, inScopeNs, attributes, enumerable)
                End If
            End If

            Return obj
        End Function

        <System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)>
        Public Shared Function RemoveNamespaceAttributes(inScopePrefixes As String(), inScopeNs As System.Xml.Linq.XNamespace(), attributes As System.Collections.Generic.List(Of System.Xml.Linq.XAttribute), obj As System.Collections.IEnumerable) As System.Collections.IEnumerable
            If obj Is Nothing Then
                Return obj
            End If

            Dim enumerable As System.Collections.Generic.IEnumerable(Of System.Xml.Linq.XElement) = TryCast(obj, System.Collections.Generic.IEnumerable(Of System.Xml.Linq.XElement))

            If enumerable IsNot Nothing Then
                Return enumerable.[Select](New Global.System.Func(Of Global.System.Xml.Linq.XElement, Global.System.Xml.Linq.XElement)(AddressOf New RestaurantPOS14.My.InternalXmlHelper.RemoveNamespaceAttributesClosure(CType((inScopePrefixes), System.[String]()), CType((inScopeNs), System.Xml.Linq.XNamespace()), CType((attributes), System.Collections.Generic.List(Of System.Xml.Linq.XAttribute))).ProcessXElement))
            End If

            Return obj.Cast(Of Object)().[Select](New Global.System.Func(Of System.Object, System.Object)(AddressOf New RestaurantPOS14.My.InternalXmlHelper.RemoveNamespaceAttributesClosure(CType((inScopePrefixes), System.[String]()), CType((inScopeNs), System.Xml.Linq.XNamespace()), CType((attributes), System.Collections.Generic.List(Of System.Xml.Linq.XAttribute))).ProcessObject))
        End Function

        <System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)>
        Public Shared Function RemoveNamespaceAttributes(inScopePrefixes As String(), inScopeNs As System.Xml.Linq.XNamespace(), attributes As System.Collections.Generic.List(Of System.Xml.Linq.XAttribute), e As System.Xml.Linq.XElement) As System.Xml.Linq.XElement
            If e IsNot Nothing Then
                Dim lXattribute As System.Xml.Linq.XAttribute = e.FirstAttribute
                While lXattribute IsNot Nothing
                    Dim nextAttribute As System.Xml.Linq.XAttribute = lXattribute.NextAttribute
                    If lXattribute.IsNamespaceDeclaration Then
                        Dim xnamespace As System.Xml.Linq.XNamespace = lXattribute.Annotation(Of System.Xml.Linq.XNamespace)()
                        Dim localName As String = lXattribute.Name.LocalName
                        If xnamespace IsNot Nothing Then
                            If inScopePrefixes IsNot Nothing AndAlso inScopeNs IsNot Nothing Then
                                Dim num As Integer = inScopePrefixes.Length - 1
                                Dim num2 As Integer = 0
                                While True
                                    Dim num3 As Integer = num2
                                    Dim num4 As Integer = num
                                    If num3 > num4 Then
                                        Exit While
                                    End If

                                    Dim value As String = inScopePrefixes(num2)
                                    Dim right As System.Xml.Linq.XNamespace = inScopeNs(num2)
                                    If Not localName.Equals(value) Then
                                        num2 += 1
                                        Continue While
                                    End If

                                    If xnamespace Is right Then
                                        lXattribute.Remove()
                                    End If

                                    lXattribute = Nothing
                                    Exit While
                                End While
                            End If

                            If lXattribute IsNot Nothing Then
                                If attributes IsNot Nothing Then
                                    Dim num5 As Integer = attributes.Count - 1
                                    Dim num6 As Integer = 0
                                    While True
                                        Dim num7 As Integer = num6
                                        Dim num8 As Integer = num5
                                        If num7 > num8 Then
                                            Exit While
                                        End If

                                        Dim xAttribute As System.Xml.Linq.XAttribute = attributes(num6)
                                        Dim localName2 As String = xAttribute.Name.LocalName
                                        Dim xnamespace2 As System.Xml.Linq.XNamespace = xAttribute.Annotation(Of System.Xml.Linq.XNamespace)()
                                        If Not (xnamespace2 IsNot Nothing) OrElse Not localName.Equals(localName2) Then
                                            num6 += 1
                                            Continue While
                                        End If

                                        If xnamespace Is xnamespace2 Then
                                            lXattribute.Remove()
                                        End If

                                        lXattribute = Nothing
                                        Exit While
                                    End While
                                End If

                                If lXattribute IsNot Nothing Then
                                    lXattribute.Remove()
                                    attributes.Add(lXattribute)
                                End If
                            End If
                        End If
                    End If

                    lXattribute = nextAttribute
                End While
            End If

            Return e
        End Function

    End Class
End Namespace

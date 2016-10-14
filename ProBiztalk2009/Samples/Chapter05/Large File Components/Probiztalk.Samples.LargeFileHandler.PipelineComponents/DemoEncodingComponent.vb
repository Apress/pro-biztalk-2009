Imports System
Imports System.IO
Imports System.Text
Imports System.Drawing
Imports System.Resources
Imports System.Reflection
Imports System.Diagnostics
Imports System.Collections
Imports System.ComponentModel
Imports Microsoft.BizTalk.Message.Interop
Imports Microsoft.BizTalk.Component.Interop
Imports Microsoft.BizTalk.Component
Imports Microsoft.BizTalk.Messaging

'todo - rename resource file names !!!, check namespaces !!! 

Namespace Probiztalk.Samples.PipelineComponents

    <ComponentCategory(CategoryTypes.CATID_PipelineComponent), _
     System.Runtime.InteropServices.Guid("4f1c7d50-e66f-451b-8e94-2f8d599cd013"), _
     ComponentCategory(CategoryTypes.CATID_Encoder)> _
    Public Class LargeFileEncodingComponent

        Implements IBaseComponent, IPersistPropertyBag, IComponentUI, _
         Global.Microsoft.BizTalk.Component.Interop.IComponent

        Private resourceManager As System.Resources.ResourceManager = New  _
         System.Resources.ResourceManager( _
         "Probiztalk.Samples.PipelineComponents.LargeFileEncodingComponent", _
         [Assembly].GetExecutingAssembly)
        Private Const PROPERTY_SCHEMA_NAMESPACE = _
                "http://LargeFileHandler.Schemas.LargeFilePropertySchema"

        '<summary>
        'Name of the component
        '</summary>
        <Browsable(False)> _
        Public ReadOnly Property Name() As String Implements _
                Global.Microsoft.BizTalk.Component.Interop.IBaseComponent.Name
            Get
                Return resourceManager.GetString("COMPONENTNAME", _
                                System.Globalization.CultureInfo.InvariantCulture)
            End Get
        End Property

        '<summary>
        'Version of the component
        '</summary>
        <Browsable(False)> _
        Public ReadOnly Property Version() As String Implements _
                Global.Microsoft.BizTalk.Component.Interop.IBaseComponent.Version
            Get
                Return resourceManager.GetString("COMPONENTVERSION", _
                         System.Globalization.CultureInfo.InvariantCulture)
            End Get
        End Property

        '<summary>
        'Description of the component
        '</summary>
        <Browsable(False)> _
        Public ReadOnly Property Description() As String Implements _
            Global.Microsoft.BizTalk.Component.Interop.IBaseComponent.Description
            Get
                Return resourceManager.GetString("COMPONENTDESCRIPTION", _
                                System.Globalization.CultureInfo.InvariantCulture)
            End Get
        End Property

        '<summary>
        'Component icon to use in BizTalk Editor
        '</summary>
        <Browsable(False)> _
        Public ReadOnly Property Icon() As IntPtr Implements _
                Global.Microsoft.BizTalk.Component.Interop.IComponentUI.Icon
            Get
                Return CType(Me.resourceManager.GetObject("COMPONENTICON", _
                            System.Globalization.CultureInfo.InvariantCulture),  _
                            System.Drawing.Bitmap).GetHicon
            End Get
        End Property

        '<summary>
        'Gets class ID of component for usage from unmanaged code.
        '</summary>
        '<param name="classid">
        'Class ID of the component
        '</param>
        Public Sub GetClassID(ByRef classid As System.Guid) Implements _
        Global.Microsoft.BizTalk.Component.Interop.IPersistPropertyBag.GetClassID
            classid = New System.Guid("4f1c7d50-e66f-451b-8e94-2f8d599cd013")
        End Sub

        '<summary>
        'not implemented
        '</summary>
        Public Sub InitNew() Implements _
            Global.Microsoft.BizTalk.Component.Interop.IPersistPropertyBag.InitNew
        End Sub

        '<summary>
        'Loads configuration properties for the component
        '</summary>
        '<param name="pb">Configuration property bag</param>
        '<param name="errlog">Error status</param>
        Public Overridable Sub Load(ByVal pb As _
                        Global.Microsoft.BizTalk.Component.Interop.IPropertyBag, _
                        ByVal errlog As Integer) _
                        Implements Global.Microsoft.BizTalk.Component. _
                        Interop.IPersistPropertyBag.Load
        End Sub

        '<summary>
        'Saves the current component configuration into the property bag
        '</summary>
        '<param name="pb">Configuration property bag</param>
        '<param name="fClearDirty">not used</param>
        '<param name="fSaveAllProperties">not used</param>
        Public Overridable Sub Save _
            (ByVal pb As Global.Microsoft.BizTalk.Component.Interop.IPropertyBag, _
             ByVal fClearDirty As Boolean, ByVal fSaveAllProperties As Boolean) _
             Implements _
             Global.Microsoft.BizTalk.Component.Interop.IPersistPropertyBag.Save
        End Sub

        '<summary>
        'Reads property value from property bag
        '</summary>
        '<param name="pb">Property bag</param>
        '<param name="propName">Name of property</param>
        '<returns>Value of the property</returns>
        Private Function ReadPropertyBag( _
            ByVal pb As Global.Microsoft.BizTalk.Component.Interop.IPropertyBag, _
            ByVal propName As String) As Object
            Dim val As Object = Nothing
            Try
                pb.Read(propName, val, 0)
            Catch e As System.ArgumentException
                Return val
            Catch e As System.Exception
                Throw New System.ApplicationException(e.Message)
            End Try
            Return val
        End Function

        '<summary>
        'Writes property values into a property bag.
        '</summary>
        '<param name="pb">Property bag.</param>
        '<param name="propName">Name of property.</param>
        '<param name="val">Value of property.</param>
        Private Sub WritePropertyBag( _
            ByVal pb As Global.Microsoft.BizTalk.Component.Interop.IPropertyBag, _
            ByVal propName As String, ByVal val As Object)
            Try
                pb.Write(propName, val)
            Catch e As System.Exception
                Throw New System.ApplicationException(e.Message)
            End Try
        End Sub

        '<summary>
        'The Validate method is called by the BizTalk Editor during the build 
        'of a BizTalk project.
        '</summary>
        '<param name="obj">An Object containing the 
        'configuration properties.</param>
        '<returns>The IEnumerator enables the caller 
        'to enumerate through a collection of strings containing error messages. 
        'These error messages appear as compiler error messages. 
        'To report successful property validation, 
        'the method should return an empty enumerator.</returns>
        Public Function Validate( _
            ByVal obj As Object) As System.Collections.IEnumerator Implements _
            Global.Microsoft.BizTalk.Component.Interop.IComponentUI.Validate
            'example implementation:
            'ArrayList errorList = new ArrayList();
            'errorList.Add("This is a compiler error");
            'return errorList.GetEnumerator();
            Return Nothing
        End Function

        '<summary>
        'Implements IComponent.Execute method.
        '</summary>
        '<param name="pc">Pipeline context</param>
        '<param name="inmsg">Input message</param>
        '<returns>Original input message</returns>
        '<remarks>
        'IComponent.Execute method is used to initiate
        'the processing of the message in this pipeline component.
        '</remarks>
        Public Function Execute(ByVal pContext As IPipelineContext, _
                                ByVal inmsg As IBaseMessage) As IBaseMessage _
                                Implements Global.Microsoft.BizTalk.Component. _
                                Interop.IComponent.Execute
            Dim isEncoded As Boolean = False

            Try
                isEncoded = inmsg.Context.Read("IsEncoded", _
                    PROPERTY_SCHEMA_NAMESPACE)
            Catch ex As Exception
                isEncoded = False
            End Try

            'Build the message that is to be sent out but only if it is encoded
            If isEncoded Then
                BuildMessageData(pContext, inmsg)
            End If

            Return inmsg
        End Function

        '<summary>
        'Method used to assign the data to a stream. 
        'Method reads path from promoted property
        '</summary>
        '<param name="pc">Pipeline context</param>
        '<param name="inmsg">Input message to be assigned</param>
        '<returns>Original input message by reference</returns>
        '<remarks>
        'Receives the input message ByRef then assigns the file stream to
        ' the messageBody.Data property
        '</remarks>
        Private Sub BuildMessageData(ByVal pContext As IPipelineContext, _
                                     ByRef inMsg As IBaseMessage)

            Dim messageBody As IBaseMessagePart = pContext.GetMessageFactory(). _
            CreateMessagePart()
            Dim data As New FileStream(inMsg.Context.Read("LargeFileLocation", _
                        PROPERTY_SCHEMA_NAMESPACE), FileMode.Open, _
                        FileAccess.Read, FileShare.Read, 4 * 1024 * 1024)
            messageBody.Data = data
            If data.CanSeek Then
                data.Position = 0
            End If

            inMsg.BodyPart.Data = data
        End Sub
    End Class

End Namespace

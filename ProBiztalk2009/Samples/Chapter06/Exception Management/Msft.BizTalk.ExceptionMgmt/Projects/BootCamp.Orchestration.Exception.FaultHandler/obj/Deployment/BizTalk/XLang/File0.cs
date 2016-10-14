
#pragma warning disable 162

namespace BootCamp.Orchestration.Exception.FaultHandler
{

    [System.SerializableAttribute]
    sealed public class __BootCamp_Orchestration_Exception_Schemas_RequestDenied__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static BootCamp.Orchestration.Exception.Schemas.RequestDenied _schema = new BootCamp.Orchestration.Exception.Schemas.RequestDenied();

        public __BootCamp_Orchestration_Exception_Schemas_RequestDenied__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eNone,
        "",
        new System.Type[]{
            typeof(BootCamp.Orchestration.Exception.Schemas.RequestDenied)
        },
        new string[]{
            "Body"
        },
        new System.Type[]{
            typeof(__BootCamp_Orchestration_Exception_Schemas_RequestDenied__)
        },
        0,
        @"http://BootCamp.Orchestration.Exception.Schemas.RequestDenied#DeclineReq"
    )]
    [System.SerializableAttribute]
    sealed internal class RequestDeclined : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __BootCamp_Orchestration_Exception_Schemas_RequestDenied__ Body;

        private void __CreatePartWrappers()
        {
            Body = new __BootCamp_Orchestration_Exception_Schemas_RequestDenied__(this, "Body", 0);
            this.AddPart("Body", 0, Body);
        }

        public RequestDeclined(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [System.SerializableAttribute]
    sealed public class __BootCamp_Orchestration_Exception_Schemas_Request__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static BootCamp.Orchestration.Exception.Schemas.Request _schema = new BootCamp.Orchestration.Exception.Schemas.Request();

        public __BootCamp_Orchestration_Exception_Schemas_Request__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eNone,
        "",
        new System.Type[]{
            typeof(BootCamp.Orchestration.Exception.Schemas.Request)
        },
        new string[]{
            "Body"
        },
        new System.Type[]{
            typeof(__BootCamp_Orchestration_Exception_Schemas_Request__)
        },
        0,
        @"http:/BootCamp.Orchestration.Exception.Schemas.Request#Request"
    )]
    [System.SerializableAttribute]
    sealed public class RequestApproved : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __BootCamp_Orchestration_Exception_Schemas_Request__ Body;

        private void __CreatePartWrappers()
        {
            Body = new __BootCamp_Orchestration_Exception_Schemas_Request__(this, "Body", 0);
            this.AddPart("Body", 0, Body);
        }

        public RequestApproved(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [System.SerializableAttribute]
    sealed public class __Msft_Samples_BizTalk_Exception_Schemas_FaultMessage__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static Msft.Samples.BizTalk.Exception.Schemas.FaultMessage _schema = new Msft.Samples.BizTalk.Exception.Schemas.FaultMessage();

        public __Msft_Samples_BizTalk_Exception_Schemas_FaultMessage__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eNone,
        "",
        new System.Type[]{
            typeof(Msft.Samples.BizTalk.Exception.Schemas.FaultMessage)
        },
        new string[]{
            "Body"
        },
        new System.Type[]{
            typeof(__Msft_Samples_BizTalk_Exception_Schemas_FaultMessage__)
        },
        0,
        @"http://schemas.msft.samples.biztalk.com/exceptionmanagement#FaultEnvelope"
    )]
    [System.SerializableAttribute]
    sealed public class FaultMessageType : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __Msft_Samples_BizTalk_Exception_Schemas_FaultMessage__ Body;

        private void __CreatePartWrappers()
        {
            Body = new __Msft_Samples_BizTalk_Exception_Schemas_FaultMessage__(this, "Body", 0);
            this.AddPart("Body", 0, Body);
        }

        public FaultMessageType(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [System.SerializableAttribute]
    sealed public class __Microsoft_XLANGs_BaseTypes_Any__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static Microsoft.XLANGs.BaseTypes.Any _schema = new Microsoft.XLANGs.BaseTypes.Any();

        public __Microsoft_XLANGs_BaseTypes_Any__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "System.Xml.XmlDocument",
        new System.Type[]{
            typeof(Microsoft.XLANGs.BaseTypes.Any)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__Microsoft_XLANGs_BaseTypes_Any__)
        },
        0,
        Microsoft.XLANGs.Core.XMessage.AnyMessageTypeName
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_System_Xml_XmlDocument : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __Microsoft_XLANGs_BaseTypes_Any__ part;

        private void __CreatePartWrappers()
        {
            part = new __Microsoft_XLANGs_BaseTypes_Any__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_System_Xml_XmlDocument(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "PostTmpMsg",
        new System.Type[]{
            typeof(BootCamp.Orchestration.Exception.FaultHandler.__messagetype_System_Xml_XmlDocument)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal, "")]
    [System.SerializableAttribute]
    sealed internal class MessagePostType : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public MessagePostType(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public MessagePostType(MessagePostType p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            MessagePostType p = new MessagePostType(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo PostTmpMsg = new Microsoft.XLANGs.Core.OperationInfo
        (
            "PostTmpMsg",
            System.Web.Services.Description.OperationFlow.OneWay,
            typeof(MessagePostType),
            typeof(__messagetype_System_Xml_XmlDocument),
            null,
            new System.Type[]{},
            new string[]{}
        );
        static public System.Collections.Hashtable OperationsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[ "PostTmpMsg" ] = PostTmpMsg;
                return h;
            }
        }
        #endregion // port reflection support
    }

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "SubmitFault",
        new System.Type[]{
            typeof(BootCamp.Orchestration.Exception.FaultHandler.FaultMessageType)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal, "")]
    [System.SerializableAttribute]
    sealed internal class FaultProcessType : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public FaultProcessType(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public FaultProcessType(FaultProcessType p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            FaultProcessType p = new FaultProcessType(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo SubmitFault = new Microsoft.XLANGs.Core.OperationInfo
        (
            "SubmitFault",
            System.Web.Services.Description.OperationFlow.OneWay,
            typeof(FaultProcessType),
            typeof(FaultMessageType),
            null,
            new System.Type[]{},
            new string[]{}
        );
        static public System.Collections.Hashtable OperationsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[ "SubmitFault" ] = SubmitFault;
                return h;
            }
        }
        #endregion // port reflection support
    }

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "PostApprove",
        new System.Type[]{
            typeof(BootCamp.Orchestration.Exception.FaultHandler.RequestApproved)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal, "")]
    [System.SerializableAttribute]
    sealed internal class ApprovedPublishType : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public ApprovedPublishType(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public ApprovedPublishType(ApprovedPublishType p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            ApprovedPublishType p = new ApprovedPublishType(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo PostApprove = new Microsoft.XLANGs.Core.OperationInfo
        (
            "PostApprove",
            System.Web.Services.Description.OperationFlow.OneWay,
            typeof(ApprovedPublishType),
            typeof(RequestApproved),
            null,
            new System.Type[]{},
            new string[]{}
        );
        static public System.Collections.Hashtable OperationsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[ "PostApprove" ] = PostApprove;
                return h;
            }
        }
        #endregion // port reflection support
    }

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "PostDecline",
        new System.Type[]{
            typeof(BootCamp.Orchestration.Exception.FaultHandler.RequestDeclined)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal, "")]
    [System.SerializableAttribute]
    sealed internal class DeclinedPublishType : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public DeclinedPublishType(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public DeclinedPublishType(DeclinedPublishType p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            DeclinedPublishType p = new DeclinedPublishType(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo PostDecline = new Microsoft.XLANGs.Core.OperationInfo
        (
            "PostDecline",
            System.Web.Services.Description.OperationFlow.OneWay,
            typeof(DeclinedPublishType),
            typeof(RequestDeclined),
            null,
            new System.Type[]{},
            new string[]{}
        );
        static public System.Collections.Hashtable OperationsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[ "PostDecline" ] = PostDecline;
                return h;
            }
        }
        #endregion // port reflection support
    }

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "SubmitRepair",
        new System.Type[]{
            typeof(BootCamp.Orchestration.Exception.FaultHandler.RequestApproved)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal, "")]
    [System.SerializableAttribute]
    sealed internal class RepairPortType : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public RepairPortType(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public RepairPortType(RepairPortType p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            RepairPortType p = new RepairPortType(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo SubmitRepair = new Microsoft.XLANGs.Core.OperationInfo
        (
            "SubmitRepair",
            System.Web.Services.Description.OperationFlow.OneWay,
            typeof(RepairPortType),
            typeof(RequestApproved),
            null,
            new System.Type[]{},
            new string[]{}
        );
        static public System.Collections.Hashtable OperationsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[ "SubmitRepair" ] = SubmitRepair;
                return h;
            }
        }
        #endregion // port reflection support
    }
    //#line 153 "C:\ProBiztalk2009\Pro_BizTalk_2006-3185\Samples\Chapter06\Exception Management\Msft.BizTalk.ExceptionMgmt\Projects\BootCamp.Orchestration.Exception.FaultHandler\EAIGenericHandler.odx"
    [Microsoft.XLANGs.BaseTypes.StaticSubscriptionAttribute(
        0, "FaultProcess", "SubmitFault", 0, -1, true
    )]
    [Microsoft.XLANGs.BaseTypes.ActivationPredicateAttribute(
        0,
        new bool[] {
            true
        },
        new System.Type[] {
            typeof(Msft.Samples.BizTalk.Exception.Schemas.FaultCode)
        },
        new Microsoft.XLANGs.BaseTypes.EXLangPredicateOperator[] {
            Microsoft.XLANGs.BaseTypes.EXLangPredicateOperator.eOpEqual
        },
        new System.Object[] {
            "1001"
        }
    )]
    [Microsoft.XLANGs.BaseTypes.ServicePortsAttribute(
        new Microsoft.XLANGs.BaseTypes.EXLangSParameter[] {
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eImplements,
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        },
        new System.Type[] {
            typeof(BootCamp.Orchestration.Exception.FaultHandler.FaultProcessType),
            typeof(BootCamp.Orchestration.Exception.FaultHandler.MessagePostType)
        },
        new System.String[] {
            "FaultProcess",
            "MessagePost"
        },
        new System.Type[] {
            null,
            null
        }
    )]
    [Microsoft.XLANGs.BaseTypes.ServiceCallTreeAttribute(
        new System.Type[] {
        },
        new System.Type[] {
        },
        new System.Type[] {
        }
    )]
    [Microsoft.XLANGs.BaseTypes.ServiceAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal,
        Microsoft.XLANGs.BaseTypes.EXLangSServiceInfo.eNone
    )]
    [System.SerializableAttribute]
    [Microsoft.XLANGs.BaseTypes.BPELExportableAttribute(false)]
    sealed internal class EAIGenericHandler : Microsoft.BizTalk.XLANGs.BTXEngine.BTXService
    {
        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        public static readonly bool __execable = false;
        [Microsoft.XLANGs.BaseTypes.CallCompensationAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSCallCompensationInfo.eNone,
            new System.String[] {
            },
            new System.String[] {
            }
        )]
        public static void __bodyProxy()
        {
        }
        private static System.Guid _serviceId = Microsoft.XLANGs.Core.HashHelper.HashServiceType(typeof(EAIGenericHandler));
        private static volatile System.Guid[] _activationSubIds;

        private static new object _lockIdentity = new object();

        public static System.Guid UUID { get { return _serviceId; } }
        public override System.Guid ServiceId { get { return UUID; } }

        protected override System.Guid[] ActivationSubGuids
        {
            get { return _activationSubIds; }
            set { _activationSubIds = value; }
        }

        protected override object StaleStateLock
        {
            get { return _lockIdentity; }
        }

        protected override bool HasActivation { get { return true; } }

        internal bool IsExeced = false;

        static EAIGenericHandler()
        {
            Microsoft.BizTalk.XLANGs.BTXEngine.BTXService.CacheStaticState( _serviceId );
        }

        private void ConstructorHelper()
        {
            _segments = new Microsoft.XLANGs.Core.Segment[] {
                new Microsoft.XLANGs.Core.Segment( new Microsoft.XLANGs.Core.Segment.SegmentCode(this.segment0), 0, 0, 0),
                new Microsoft.XLANGs.Core.Segment( new Microsoft.XLANGs.Core.Segment.SegmentCode(this.segment1), 1, 1, 1)
            };

            _Locks = 0;
            _rootContext = new __EAIGenericHandler_root_0(this);
            _stateMgrs = new Microsoft.XLANGs.Core.IStateManager[2];
            _stateMgrs[0] = _rootContext;
            FinalConstruct();
        }

        public EAIGenericHandler(System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXSession session, Microsoft.BizTalk.XLANGs.BTXEngine.BTXEvents tracker)
            : base(instanceId, session, "EAIGenericHandler", tracker)
        {
            ConstructorHelper();
        }

        public EAIGenericHandler(int callIndex, System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXService parent)
            : base(callIndex, instanceId, parent, "EAIGenericHandler")
        {
            ConstructorHelper();
        }

        private const string _symInfo = @"
<XsymFile>
<ProcessFlow xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>      <shapeType>RootShape</shapeType>      <ShapeID>a975d0d0-e778-4449-9fc6-e8913e53fa5e</ShapeID>      
<children>                          
<ShapeInfo>      <shapeType>ReceiveShape</shapeType>      <ShapeID>58d0fe6f-69e9-4507-9d33-8c30573ba51d</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Receive Fault</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>DNFPredicateShape</shapeType>      <ShapeID>12df6123-1788-4f3d-96a6-ce72462ea3ac</ShapeID>      <ParentLink>Receive_DNFPredicate</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>d55c95ce-d175-45a6-9171-83f74277f103</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Get Msg Array</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>WhileShape</shapeType>      <ShapeID>f9b93288-5b7c-4627-be7d-bf92070c52d6</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Loop Thru All Messages</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>68f218bd-4f8a-48ec-8f25-bfa15a61fdd5</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Retrieve Msg From Fault</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>05291c45-65b3-4fdb-941b-d57065d68765</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Send Msg</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                  </children>
  </ProcessFlow><Metadata>

<TrkMetadata>
<ActionName>'EAIGenericHandler'</ActionName><IsAtomic>0</IsAtomic><Line>153</Line><Position>14</Position><ShapeID>'e211a116-cb8b-44e7-a052-0de295aa0001'</ShapeID>
</TrkMetadata>

<TrkMetadata>
<Line>165</Line><Position>84</Position><ShapeID>'58d0fe6f-69e9-4507-9d33-8c30573ba51d'</ShapeID>
<Messages>
	<MsgInfo><name>FaultMsg</name><part>Body</part><schema>Msft.Samples.BizTalk.Exception.Schemas.FaultMessage</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>168</Line><Position>18</Position><ShapeID>'d55c95ce-d175-45a6-9171-83f74277f103'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>170</Line><Position>13</Position><ShapeID>'f9b93288-5b7c-4627-be7d-bf92070c52d6'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>173</Line><Position>24</Position><ShapeID>'68f218bd-4f8a-48ec-8f25-bfa15a61fdd5'</ShapeID>
<Messages>
	<MsgInfo><name>TmpMsg</name><part>part</part><schema>Microsoft.XLANGs.BaseTypes.Any</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>175</Line><Position>17</Position><ShapeID>'05291c45-65b3-4fdb-941b-d57065d68765'</ShapeID>
<Messages>
	<MsgInfo><name>TmpMsg</name><part>part</part><schema>Microsoft.XLANGs.BaseTypes.Any</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>
</Metadata>
</XsymFile>";

        public override string odXml { get { return _symODXML; } }

        private const string _symODXML = @"
<?xml version='1.0' encoding='utf-8' standalone='yes'?>
<om:MetaModel MajorVersion='1' MinorVersion='3' Core='2b131234-7959-458d-834f-2dc0769ce683' ScheduleModel='66366196-361d-448d-976f-cab5e87496d2' xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>
    <om:Element Type='Module' OID='bbb46702-b246-48a0-8ffc-5038365211ed' LowerBound='1.1' HigherBound='39.1'>
        <om:Property Name='ReportToAnalyst' Value='True' />
        <om:Property Name='Name' Value='BootCamp.Orchestration.Exception.FaultHandler' />
        <om:Property Name='Signal' Value='False' />
        <om:Element Type='PortType' OID='7978b483-fc39-4a15-b9ed-6fb9b2910953' ParentLink='Module_PortType' LowerBound='4.1' HigherBound='11.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='MessagePostType' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='908da71a-5198-4c6f-90ad-db751d77bd9e' ParentLink='PortType_OperationDeclaration' LowerBound='6.1' HigherBound='10.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='PostTmpMsg' />
                <om:Property Name='Signal' Value='True' />
                <om:Element Type='MessageRef' OID='732d403c-df21-4b4e-a9be-fbab7f4fadc8' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='8.13' HigherBound='8.35'>
                    <om:Property Name='Ref' Value='System.Xml.XmlDocument' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='ServiceDeclaration' OID='477d63e3-be00-4b40-b7c8-fd37f744e074' ParentLink='Module_ServiceDeclaration' LowerBound='11.1' HigherBound='38.1'>
            <om:Property Name='InitializedTransactionType' Value='False' />
            <om:Property Name='IsInvokable' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='EAIGenericHandler' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='VariableDeclaration' OID='2649b0ee-1711-4dda-8d62-03462c779633' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='20.1' HigherBound='21.1'>
                <om:Property Name='UseDefaultConstructor' Value='True' />
                <om:Property Name='Type' Value='Msft.Samples.BizTalk.Exception.MessageCollection' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='msgs' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='80807941-2d36-4de1-82af-b0655c2774ce' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='18.1' HigherBound='19.1'>
                <om:Property Name='Type' Value='BootCamp.Orchestration.Exception.FaultHandler.FaultMessageType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='FaultMsg' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='45e6b51e-d675-42da-a5ac-bfed7b77c60b' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='19.1' HigherBound='20.1'>
                <om:Property Name='Type' Value='System.Xml.XmlDocument' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='TmpMsg' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='ServiceBody' OID='a975d0d0-e778-4449-9fc6-e8913e53fa5e' ParentLink='ServiceDeclaration_ServiceBody'>
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='Receive' OID='58d0fe6f-69e9-4507-9d33-8c30573ba51d' ParentLink='ServiceBody_Statement' LowerBound='23.1' HigherBound='26.1'>
                    <om:Property Name='Activate' Value='True' />
                    <om:Property Name='PortName' Value='FaultProcess' />
                    <om:Property Name='MessageName' Value='FaultMsg' />
                    <om:Property Name='OperationName' Value='SubmitFault' />
                    <om:Property Name='OperationMessageName' Value='Request' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Receive Fault' />
                    <om:Property Name='Signal' Value='True' />
                    <om:Element Type='DNFPredicate' OID='12df6123-1788-4f3d-96a6-ce72462ea3ac' ParentLink='Receive_DNFPredicate'>
                        <om:Property Name='LHS' Value='Msft.Samples.BizTalk.Exception.Schemas.FaultCode' />
                        <om:Property Name='RHS' Value='&quot;1001&quot;' />
                        <om:Property Name='Grouping' Value='AND' />
                        <om:Property Name='Operator' Value='Equals' />
                        <om:Property Name='Signal' Value='False' />
                    </om:Element>
                </om:Element>
                <om:Element Type='VariableAssignment' OID='d55c95ce-d175-45a6-9171-83f74277f103' ParentLink='ServiceBody_Statement' LowerBound='26.1' HigherBound='28.1'>
                    <om:Property Name='Expression' Value='msgs =  Msft.Samples.BizTalk.Exception.ExceptionMgmt.GetMessages(FaultMsg);&#xD;&#xA;' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Get Msg Array' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='While' OID='f9b93288-5b7c-4627-be7d-bf92070c52d6' ParentLink='ServiceBody_Statement' LowerBound='28.1' HigherBound='36.1'>
                    <om:Property Name='Expression' Value='msgs.MoveNext()' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Loop Thru All Messages' />
                    <om:Property Name='Signal' Value='True' />
                    <om:Element Type='VariableAssignment' OID='68f218bd-4f8a-48ec-8f25-bfa15a61fdd5' ParentLink='ComplexStatement_Statement' LowerBound='31.1' HigherBound='33.1'>
                        <om:Property Name='Expression' Value='TmpMsg = msgs.Current;' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='Retrieve Msg From Fault' />
                        <om:Property Name='Signal' Value='True' />
                    </om:Element>
                    <om:Element Type='Send' OID='05291c45-65b3-4fdb-941b-d57065d68765' ParentLink='ComplexStatement_Statement' LowerBound='33.1' HigherBound='35.1'>
                        <om:Property Name='PortName' Value='MessagePost' />
                        <om:Property Name='MessageName' Value='TmpMsg' />
                        <om:Property Name='OperationName' Value='PostTmpMsg' />
                        <om:Property Name='OperationMessageName' Value='Request' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='Send Msg' />
                        <om:Property Name='Signal' Value='True' />
                    </om:Element>
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='96c08ff5-81f5-4127-8172-aa6a3481e212' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='14.1' HigherBound='16.1'>
                <om:Property Name='PortModifier' Value='Implements' />
                <om:Property Name='Orientation' Value='Left' />
                <om:Property Name='PortIndex' Value='-1' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='BootCamp.Orchestration.Exception.FaultHandler.FaultProcessType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='FaultProcess' />
                <om:Property Name='Signal' Value='True' />
                <om:Element Type='DirectBindingAttribute' OID='a2b460e1-7c9a-40ff-9ee3-6af4a1094f40' ParentLink='PortDeclaration_CLRAttribute' LowerBound='14.1' HigherBound='15.1'>
                    <om:Property Name='DirectBindingType' Value='MessageBox' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='1675dd34-ad68-4b26-a547-28cb58e95360' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='16.1' HigherBound='18.1'>
                <om:Property Name='PortModifier' Value='Uses' />
                <om:Property Name='Orientation' Value='Right' />
                <om:Property Name='PortIndex' Value='23' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='BootCamp.Orchestration.Exception.FaultHandler.MessagePostType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='MessagePost' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='DirectBindingAttribute' OID='17d2643a-cd5c-4c00-8f79-bc1375f36e8c' ParentLink='PortDeclaration_CLRAttribute' LowerBound='16.1' HigherBound='17.1'>
                    <om:Property Name='DirectBindingType' Value='MessageBox' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
    </om:Element>
</om:MetaModel>
";

        [System.SerializableAttribute]
        public class __EAIGenericHandler_root_0 : Microsoft.XLANGs.Core.ServiceContext
        {
            public __EAIGenericHandler_root_0(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "EAIGenericHandler")
            {
            }

            public override int Index { get { return 0; } }

            public override Microsoft.XLANGs.Core.Segment InitialSegment
            {
                get { return _service._segments[0]; }
            }
            public override Microsoft.XLANGs.Core.Segment FinalSegment
            {
                get { return _service._segments[0]; }
            }

            public override int CompensationSegment { get { return -1; } }
            public override bool OnError()
            {
                Finally();
                return false;
            }

            public override void Finally()
            {
                EAIGenericHandler __svc__ = (EAIGenericHandler)_service;
                __EAIGenericHandler_root_0 __ctx0__ = (__EAIGenericHandler_root_0)(__svc__._stateMgrs[0]);

                if (__svc__.MessagePost != null)
                {
                    __svc__.MessagePost.Close(this, null);
                    __svc__.MessagePost = null;
                }
                if (__svc__.FaultProcess != null)
                {
                    __svc__.FaultProcess.Close(this, null);
                    __svc__.FaultProcess = null;
                }
                base.Finally();
            }

            internal Microsoft.XLANGs.Core.SubscriptionWrapper __subWrapper0;
        }


        [System.SerializableAttribute]
        public class __EAIGenericHandler_1 : Microsoft.XLANGs.Core.ExceptionHandlingContext
        {
            public __EAIGenericHandler_1(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "EAIGenericHandler")
            {
            }

            public override int Index { get { return 1; } }

            public override bool CombineParentCommit { get { return true; } }

            public override Microsoft.XLANGs.Core.Segment InitialSegment
            {
                get { return _service._segments[1]; }
            }
            public override Microsoft.XLANGs.Core.Segment FinalSegment
            {
                get { return _service._segments[1]; }
            }

            public override int CompensationSegment { get { return -1; } }
            public override bool OnError()
            {
                Finally();
                return false;
            }

            public override void Finally()
            {
                EAIGenericHandler __svc__ = (EAIGenericHandler)_service;
                __EAIGenericHandler_1 __ctx1__ = (__EAIGenericHandler_1)(__svc__._stateMgrs[1]);

                if (__ctx1__ != null && __ctx1__.__TmpMsg != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__TmpMsg);
                    __ctx1__.__TmpMsg = null;
                }
                if (__ctx1__ != null)
                    __ctx1__.__msgs = null;
                if (__ctx1__ != null && __ctx1__.__FaultMsg != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__FaultMsg);
                    __ctx1__.__FaultMsg = null;
                }
                base.Finally();
            }

            [Microsoft.XLANGs.Core.UserVariableAttribute("FaultMsg")]
            internal FaultMessageType __FaultMsg;
            [Microsoft.XLANGs.Core.UserVariableAttribute("TmpMsg")]
            public __messagetype_System_Xml_XmlDocument __TmpMsg;
            [Microsoft.XLANGs.Core.UserVariableAttribute("msgs")]
            internal Msft.Samples.BizTalk.Exception.MessageCollection __msgs;
        }

        private static Microsoft.XLANGs.Core.CorrelationType[] _correlationTypes = null;
        public override Microsoft.XLANGs.Core.CorrelationType[] CorrelationTypes { get { return _correlationTypes; } }

        private static System.Guid[] _convoySetIds;

        public override System.Guid[] ConvoySetGuids
        {
            get { return _convoySetIds; }
            set { _convoySetIds = value; }
        }

        public static object[] StaticConvoySetInformation
        {
            get {
                return null;
            }
        }

        [Microsoft.XLANGs.BaseTypes.DirectBindingAttribute()]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eImplements
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("FaultProcess")]
        internal FaultProcessType FaultProcess;
        [Microsoft.XLANGs.BaseTypes.DirectBindingAttribute()]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("MessagePost")]
        internal MessagePostType MessagePost;
        private static Msft.Samples.BizTalk.Exception.Schemas.FaultCode _prop_Msft_Samples_BizTalk_Exception_Schemas_FaultCode = new Msft.Samples.BizTalk.Exception.Schemas.FaultCode();

        sealed private class PredicateSet0_0 : Microsoft.XLANGs.Core.PredicateGroup
        {
            public PredicateSet0_0() : base(1)
            {
                Add(new Microsoft.XLANGs.Core.FullySpecifiedPredicate(_prop_Msft_Samples_BizTalk_Exception_Schemas_FaultCode, Microsoft.XLANGs.Core.PredicateBase.Operators.eEqual, "1001"));
            }
        }


        private static Microsoft.XLANGs.Core.PredicateGroup[] _predicates0 = {
            new PredicateSet0_0()
        };


        public static Microsoft.XLANGs.Core.PortInfo[] _portInfo = new Microsoft.XLANGs.Core.PortInfo[] {
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {FaultProcessType.SubmitFault},
                                               typeof(EAIGenericHandler).GetField("FaultProcess", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.implements,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(EAIGenericHandler), "FaultProcess"),
                                               null),
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {MessagePostType.PostTmpMsg},
                                               typeof(EAIGenericHandler).GetField("MessagePost", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.uses,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(EAIGenericHandler), "MessagePost"),
                                               null)
        };

        public override Microsoft.XLANGs.Core.PortInfo[] PortInformation
        {
            get { return _portInfo; }
        }

        static public System.Collections.Hashtable PortsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[_portInfo[0].Name] = _portInfo[0];
                h[_portInfo[1].Name] = _portInfo[1];
                return h;
            }
        }

        public static System.Type[] InvokedServicesTypes
        {
            get
            {
                return new System.Type[] {
                    // type of each service invoked by this service
                };
            }
        }

        public static System.Type[] CalledServicesTypes
        {
            get
            {
                return new System.Type[] {
                };
            }
        }

        public static System.Type[] ExecedServicesTypes
        {
            get
            {
                return new System.Type[] {
                };
            }
        }

        public static object[] StaticSubscriptionsInformation {
            get {
                return new object[1]{
                     new object[5] { _portInfo[0], 0, _predicates0 , -1, true }
                };
            }
        }

        public static Microsoft.XLANGs.RuntimeTypes.Location[] __eventLocations = new Microsoft.XLANGs.RuntimeTypes.Location[] {
            new Microsoft.XLANGs.RuntimeTypes.Location(0, "00000000-0000-0000-0000-000000000000", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(1, "58d0fe6f-69e9-4507-9d33-8c30573ba51d", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(2, "58d0fe6f-69e9-4507-9d33-8c30573ba51d", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(3, "00000000-0000-0000-0000-000000000000", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(4, "d55c95ce-d175-45a6-9171-83f74277f103", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(5, "d55c95ce-d175-45a6-9171-83f74277f103", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(6, "f9b93288-5b7c-4627-be7d-bf92070c52d6", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(7, "68f218bd-4f8a-48ec-8f25-bfa15a61fdd5", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(8, "68f218bd-4f8a-48ec-8f25-bfa15a61fdd5", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(9, "05291c45-65b3-4fdb-941b-d57065d68765", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(10, "05291c45-65b3-4fdb-941b-d57065d68765", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(11, "f9b93288-5b7c-4627-be7d-bf92070c52d6", 1, false)
        };

        public override Microsoft.XLANGs.RuntimeTypes.Location[] EventLocations
        {
            get { return __eventLocations; }
        }

        public static Microsoft.XLANGs.RuntimeTypes.EventData[] __eventData = new Microsoft.XLANGs.RuntimeTypes.EventData[] {
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Body),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Receive),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Expression),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Expression),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.WhileBody),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.While),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Send),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.While),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.WhileBody),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Body)
        };

        public static int[] __progressLocation0 = new int[] { 0,0,0,3,3,};
        public static int[] __progressLocation1 = new int[] { 0,0,1,1,2,2,4,4,5,6,6,6,7,7,8,9,9,9,10,11,11,11,3,3,3,3,};

        public static int[][] __progressLocations = new int[2] [] {__progressLocation0,__progressLocation1};
        public override int[][] ProgressLocations {get {return __progressLocations;} }

        public Microsoft.XLANGs.Core.StopConditions segment0(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[0];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[0];
            __EAIGenericHandler_1 __ctx1__ = (__EAIGenericHandler_1)_stateMgrs[1];
            __EAIGenericHandler_root_0 __ctx0__ = (__EAIGenericHandler_root_0)_stateMgrs[0];

            switch (__seg__.Progress)
            {
            case 0:
                FaultProcess = new FaultProcessType(0, this);
                MessagePost = new MessagePostType(1, this);
                __ctx__.PrologueCompleted = true;
                __ctx0__.__subWrapper0 = new Microsoft.XLANGs.Core.SubscriptionWrapper(ActivationSubGuids[0], FaultProcess, this);
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.Initialized) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.Initialized;
                goto case 1;
            case 1:
                __ctx1__ = new __EAIGenericHandler_1(this);
                _stateMgrs[1] = __ctx1__;
                if ( !PostProgressInc( __seg__, __ctx__, 2 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 2;
            case 2:
                __ctx0__.StartContext(__seg__, __ctx1__);
                if ( !PostProgressInc( __seg__, __ctx__, 3 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                return Microsoft.XLANGs.Core.StopConditions.Blocked;
            case 3:
                if (!__ctx0__.CleanupAndPrepareToCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 4;
            case 4:
                __ctx1__.Finally();
                ServiceDone(__seg__, (Microsoft.XLANGs.Core.Context)_stateMgrs[0]);
                __ctx0__.OnCommit();
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }

        public Microsoft.XLANGs.Core.StopConditions segment1(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Envelope __msgEnv__ = null;
            bool __condition__;
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[1];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[1];
            __EAIGenericHandler_1 __ctx1__ = (__EAIGenericHandler_1)_stateMgrs[1];
            __EAIGenericHandler_root_0 __ctx0__ = (__EAIGenericHandler_root_0)_stateMgrs[0];

            switch (__seg__.Progress)
            {
            case 0:
                __ctx1__.__msgs = default(Msft.Samples.BizTalk.Exception.MessageCollection);
                __ctx__.PrologueCompleted = true;
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 1;
            case 1:
                if ( !PreProgressInc( __seg__, __ctx__, 2 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[0],__eventData[0],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 2;
            case 2:
                if ( !PreProgressInc( __seg__, __ctx__, 3 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[1],__eventData[1],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 3;
            case 3:
                if (!FaultProcess.GetMessageId(__ctx0__.__subWrapper0.getSubscription(this), __seg__, __ctx1__, out __msgEnv__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if (__ctx1__.__FaultMsg != null)
                    __ctx1__.UnrefMessage(__ctx1__.__FaultMsg);
                __ctx1__.__FaultMsg = new FaultMessageType("FaultMsg", __ctx1__);
                __ctx1__.RefMessage(__ctx1__.__FaultMsg);
                FaultProcess.ReceiveMessage(0, __msgEnv__, __ctx1__.__FaultMsg, null, (Microsoft.XLANGs.Core.Context)_stateMgrs[1], __seg__);
                if (FaultProcess != null)
                {
                    FaultProcess.Close(__ctx1__, __seg__);
                    FaultProcess = null;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 4;
            case 4:
                if ( !PreProgressInc( __seg__, __ctx__, 5 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Receive);
                    __edata.Messages.Add(__ctx1__.__FaultMsg);
                    __edata.PortName = @"FaultProcess";
                    Tracker.FireEvent(__eventLocations[2],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 5;
            case 5:
                __ctx1__.__msgs = new Msft.Samples.BizTalk.Exception.MessageCollection();
                if ( !PostProgressInc( __seg__, __ctx__, 6 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 6;
            case 6:
                if ( !PreProgressInc( __seg__, __ctx__, 7 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[4],__eventData[2],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 7;
            case 7:
                __ctx1__.__msgs = Msft.Samples.BizTalk.Exception.ExceptionMgmt.GetMessages(CreateMessageWrapperForUserCode(__ctx1__.__FaultMsg));
                if (__ctx1__ != null && __ctx1__.__FaultMsg != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__FaultMsg);
                    __ctx1__.__FaultMsg = null;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 8 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 8;
            case 8:
                if ( !PreProgressInc( __seg__, __ctx__, 9 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[5],__eventData[3],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 9;
            case 9:
                if ( !PreProgressInc( __seg__, __ctx__, 10 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[6],__eventData[4],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 10;
            case 10:
                __condition__ = __ctx1__.__msgs.MoveNext();
                if (!__condition__)
                {
                    if ( !PostProgressInc( __seg__, __ctx__, 21 ) )
                        return Microsoft.XLANGs.Core.StopConditions.Paused;
                    goto case 21;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 11 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 11;
            case 11:
                if ( !PreProgressInc( __seg__, __ctx__, 12 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[6],__eventData[5],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 12;
            case 12:
                if ( !PreProgressInc( __seg__, __ctx__, 13 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[7],__eventData[2],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 13;
            case 13:
                if (__ctx1__.__TmpMsg != null)
                    __ctx1__.UnrefMessage(__ctx1__.__TmpMsg);
                __ctx1__.__TmpMsg = new __messagetype_System_Xml_XmlDocument("TmpMsg", __ctx1__);
                __ctx1__.RefMessage(__ctx1__.__TmpMsg);
                __ctx1__.__TmpMsg = (__messagetype_System_Xml_XmlDocument)UnwrapMessageFromUserCode(__ctx1__.__msgs.Current, __ctx1__, __ctx1__.__TmpMsg);
                __ctx1__.__TmpMsg.ConstructionCompleteEvent(false);
                if ( !PostProgressInc( __seg__, __ctx__, 14 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 14;
            case 14:
                if ( !PreProgressInc( __seg__, __ctx__, 15 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[8],__eventData[3],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 15;
            case 15:
                if ( !PreProgressInc( __seg__, __ctx__, 16 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[9],__eventData[6],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 16;
            case 16:
                if (!__ctx1__.PrepareToPendingCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 17 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 17;
            case 17:
                if ( !PreProgressInc( __seg__, __ctx__, 18 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                MessagePost.SendMessage(0, __ctx1__.__TmpMsg, null, null, __ctx1__, __seg__ , Microsoft.XLANGs.Core.ActivityFlags.None );
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingRqst) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingRqst;
                goto case 18;
            case 18:
                if ( !PreProgressInc( __seg__, __ctx__, 19 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__TmpMsg);
                    __edata.PortName = @"MessagePost";
                    Tracker.FireEvent(__eventLocations[10],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (__ctx1__ != null && __ctx1__.__TmpMsg != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__TmpMsg);
                    __ctx1__.__TmpMsg = null;
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 19;
            case 19:
                if ( !PreProgressInc( __seg__, __ctx__, 20 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[11],__eventData[7],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 20;
            case 20:
                if ( !PostProgressInc( __seg__, __ctx__, 10 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 10;
            case 21:
                if ( !PreProgressInc( __seg__, __ctx__, 22 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                if (__ctx1__ != null)
                    __ctx1__.__msgs = null;
                if (MessagePost != null)
                {
                    MessagePost.Close(__ctx1__, __seg__);
                    MessagePost = null;
                }
                Tracker.FireEvent(__eventLocations[11],__eventData[8],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 22;
            case 22:
                if ( !PreProgressInc( __seg__, __ctx__, 23 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[3],__eventData[9],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 23;
            case 23:
                if (!__ctx1__.CleanupAndPrepareToCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 24 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 24;
            case 24:
                if ( !PreProgressInc( __seg__, __ctx__, 25 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                __ctx1__.OnCommit();
                goto case 25;
            case 25:
                __seg__.SegmentDone();
                _segments[0].PredecessorDone(this);
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }
    }
    //#line 351 "C:\ProBiztalk2009\Pro_BizTalk_2006-3185\Samples\Chapter06\Exception Management\Msft.BizTalk.ExceptionMgmt\Projects\BootCamp.Orchestration.Exception.FaultHandler\EAIProcessHandler.odx"
    [Microsoft.XLANGs.BaseTypes.StaticSubscriptionAttribute(
        0, "FaultProcess", "SubmitFault", 0, -1, true
    )]
    [Microsoft.XLANGs.BaseTypes.ActivationPredicateAttribute(
        0,
        new bool[] {
            true
        },
        new System.Type[] {
            typeof(Msft.Samples.BizTalk.Exception.Schemas.FaultCode)
        },
        new Microsoft.XLANGs.BaseTypes.EXLangPredicateOperator[] {
            Microsoft.XLANGs.BaseTypes.EXLangPredicateOperator.eOpEqual
        },
        new System.Object[] {
            "1001"
        }
    )]
    [Microsoft.XLANGs.BaseTypes.ServicePortsAttribute(
        new Microsoft.XLANGs.BaseTypes.EXLangSParameter[] {
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eImplements,
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses,
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses,
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        },
        new System.Type[] {
            typeof(BootCamp.Orchestration.Exception.FaultHandler.FaultProcessType),
            typeof(BootCamp.Orchestration.Exception.FaultHandler.RepairPortType),
            typeof(BootCamp.Orchestration.Exception.FaultHandler.ApprovedPublishType),
            typeof(BootCamp.Orchestration.Exception.FaultHandler.DeclinedPublishType)
        },
        new System.String[] {
            "FaultProcess",
            "RepairSubmit",
            "ApprovedPublish",
            "DeclinedPublish"
        },
        new System.Type[] {
            null,
            null,
            null,
            null
        }
    )]
    [Microsoft.XLANGs.BaseTypes.ServiceCallTreeAttribute(
        new System.Type[] {
        },
        new System.Type[] {
        },
        new System.Type[] {
        }
    )]
    [Microsoft.XLANGs.BaseTypes.ServiceAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal,
        Microsoft.XLANGs.BaseTypes.EXLangSServiceInfo.eNone
    )]
    [System.SerializableAttribute]
    [Microsoft.XLANGs.BaseTypes.BPELExportableAttribute(false)]
    sealed internal class EAIProcessHandler : Microsoft.BizTalk.XLANGs.BTXEngine.BTXService
    {
        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        public static readonly bool __execable = false;
        [Microsoft.XLANGs.BaseTypes.CallCompensationAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSCallCompensationInfo.eNone,
            new System.String[] {
            },
            new System.String[] {
            }
        )]
        public static void __bodyProxy()
        {
        }
        private static System.Guid _serviceId = Microsoft.XLANGs.Core.HashHelper.HashServiceType(typeof(EAIProcessHandler));
        private static volatile System.Guid[] _activationSubIds;

        private static new object _lockIdentity = new object();

        public static System.Guid UUID { get { return _serviceId; } }
        public override System.Guid ServiceId { get { return UUID; } }

        protected override System.Guid[] ActivationSubGuids
        {
            get { return _activationSubIds; }
            set { _activationSubIds = value; }
        }

        protected override object StaleStateLock
        {
            get { return _lockIdentity; }
        }

        protected override bool HasActivation { get { return true; } }

        internal bool IsExeced = false;

        static EAIProcessHandler()
        {
            Microsoft.BizTalk.XLANGs.BTXEngine.BTXService.CacheStaticState( _serviceId );
        }

        private void ConstructorHelper()
        {
            _segments = new Microsoft.XLANGs.Core.Segment[] {
                new Microsoft.XLANGs.Core.Segment( new Microsoft.XLANGs.Core.Segment.SegmentCode(this.segment0), 0, 0, 0),
                new Microsoft.XLANGs.Core.Segment( new Microsoft.XLANGs.Core.Segment.SegmentCode(this.segment1), 1, 1, 1)
            };

            _Locks = 0;
            _rootContext = new __EAIProcessHandler_root_0(this);
            _stateMgrs = new Microsoft.XLANGs.Core.IStateManager[2];
            _stateMgrs[0] = _rootContext;
            FinalConstruct();
        }

        public EAIProcessHandler(System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXSession session, Microsoft.BizTalk.XLANGs.BTXEngine.BTXEvents tracker)
            : base(instanceId, session, "EAIProcessHandler", tracker)
        {
            ConstructorHelper();
        }

        public EAIProcessHandler(int callIndex, System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXService parent)
            : base(callIndex, instanceId, parent, "EAIProcessHandler")
        {
            ConstructorHelper();
        }

        private const string _symInfo = @"
<XsymFile>
<ProcessFlow xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>      <shapeType>RootShape</shapeType>      <ShapeID>57fe69a2-1254-4ecb-846a-683fb6b8f6d3</ShapeID>      
<children>                          
<ShapeInfo>      <shapeType>ReceiveShape</shapeType>      <ShapeID>5f7c7ed7-8bab-4994-8c4f-855ad63773ff</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Receive Fault</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>DNFPredicateShape</shapeType>      <ShapeID>df390c11-c9ac-49bd-998e-4e434f0242f7</ShapeID>      <ParentLink>Receive_DNFPredicate</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>f75bab47-dd38-4db8-bed9-ff80f49f3c42</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Retrieve All Msgs</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>DecisionShape</shapeType>      <ShapeID>02e11e55-c79b-4718-851e-13e9591e70c9</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Divide By Zero Exception?</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>DecisionBranchShape</shapeType>      <ShapeID>0377735c-4caf-4759-8c2d-e3a31c433799</ShapeID>      <ParentLink>ReallyComplexStatement_Branch</ParentLink>                <shapeText>Yes</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>TaskShape</shapeType>      <ShapeID>742f7903-1cce-4b8a-b571-49c580b742b9</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Repair Message and ReSubmit</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>2cda7bc4-2a04-4216-8d27-d043d6582316</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Send Repair</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>DecisionBranchShape</shapeType>      <ShapeID>d96cbf9a-0f6e-4f48-89fa-639e46e1efe0</ShapeID>      <ParentLink>ReallyComplexStatement_Branch</ParentLink>                <shapeText>Else</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>0c801fe5-d753-4e45-b5e3-e9fd38985cf7</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Send Approved</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>b8607b8e-feea-4378-9368-320a9efe5f86</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Send Declined</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ProcessFlow><Metadata>

<TrkMetadata>
<ActionName>'EAIProcessHandler'</ActionName><IsAtomic>0</IsAtomic><Line>351</Line><Position>14</Position><ShapeID>'e211a116-cb8b-44e7-a052-0de295aa0001'</ShapeID>
</TrkMetadata>

<TrkMetadata>
<Line>368</Line><Position>84</Position><ShapeID>'5f7c7ed7-8bab-4994-8c4f-855ad63773ff'</ShapeID>
<Messages>
	<MsgInfo><name>FaultMsg</name><part>Body</part><schema>Msft.Samples.BizTalk.Exception.Schemas.FaultMessage</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>372</Line><Position>24</Position><ShapeID>'f75bab47-dd38-4db8-bed9-ff80f49f3c42'</ShapeID>
<Messages>
	<MsgInfo><name>RequestMsg</name><part>Body</part><schema>BootCamp.Orchestration.Exception.Schemas.Request</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>381</Line><Position>13</Position><ShapeID>'02e11e55-c79b-4718-851e-13e9591e70c9'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>384</Line><Position>17</Position><ShapeID>'2cda7bc4-2a04-4216-8d27-d043d6582316'</ShapeID>
<Messages>
	<MsgInfo><name>RequestMsg</name><part>Body</part><schema>BootCamp.Orchestration.Exception.Schemas.Request</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>389</Line><Position>17</Position><ShapeID>'0c801fe5-d753-4e45-b5e3-e9fd38985cf7'</ShapeID>
<Messages>
	<MsgInfo><name>RequestMsg</name><part>Body</part><schema>BootCamp.Orchestration.Exception.Schemas.Request</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>392</Line><Position>13</Position><ShapeID>'b8607b8e-feea-4378-9368-320a9efe5f86'</ShapeID>
<Messages>
	<MsgInfo><name>DeniedMsg</name><part>Body</part><schema>BootCamp.Orchestration.Exception.Schemas.RequestDenied</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>
</Metadata>
</XsymFile>";

        public override string odXml { get { return _symODXML; } }

        private const string _symODXML = @"
<?xml version='1.0' encoding='utf-8' standalone='yes'?>
<om:MetaModel MajorVersion='1' MinorVersion='3' Core='2b131234-7959-458d-834f-2dc0769ce683' ScheduleModel='66366196-361d-448d-976f-cab5e87496d2' xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>
    <om:Element Type='Module' OID='414ef097-f70c-44d2-b2bc-44c445ed8ef1' LowerBound='1.1' HigherBound='90.1'>
        <om:Property Name='ReportToAnalyst' Value='True' />
        <om:Property Name='Name' Value='BootCamp.Orchestration.Exception.FaultHandler' />
        <om:Property Name='Signal' Value='False' />
        <om:Element Type='PortType' OID='d77850a9-f2ec-4f05-ac86-e4456f7291c1' ParentLink='Module_PortType' LowerBound='16.1' HigherBound='23.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='FaultProcessType' />
            <om:Property Name='Signal' Value='True' />
            <om:Element Type='OperationDeclaration' OID='fbc1fdc4-a4b4-4cdb-9441-585ec59ba480' ParentLink='PortType_OperationDeclaration' LowerBound='18.1' HigherBound='22.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='SubmitFault' />
                <om:Property Name='Signal' Value='True' />
                <om:Element Type='MessageRef' OID='ce4757a4-7f5f-4f5f-b6bd-c9cc19c64731' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='20.13' HigherBound='20.29'>
                    <om:Property Name='Ref' Value='BootCamp.Orchestration.Exception.FaultHandler.FaultMessageType' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='PortType' OID='6f241d76-c997-4a45-8376-1aa76b2b0ba6' ParentLink='Module_PortType' LowerBound='23.1' HigherBound='30.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='ApprovedPublishType' />
            <om:Property Name='Signal' Value='True' />
            <om:Element Type='OperationDeclaration' OID='fdb84981-17fd-4081-b95f-68e38dd490aa' ParentLink='PortType_OperationDeclaration' LowerBound='25.1' HigherBound='29.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='PostApprove' />
                <om:Property Name='Signal' Value='True' />
                <om:Element Type='MessageRef' OID='6eafea28-58b9-4104-804b-b6c741bb318b' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='27.13' HigherBound='27.28'>
                    <om:Property Name='Ref' Value='BootCamp.Orchestration.Exception.FaultHandler.RequestApproved' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='PortType' OID='76baa18e-e9c4-47c3-a612-eae4ee0bdce1' ParentLink='Module_PortType' LowerBound='30.1' HigherBound='37.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='DeclinedPublishType' />
            <om:Property Name='Signal' Value='True' />
            <om:Element Type='OperationDeclaration' OID='cc856452-1a54-40dc-bf08-861709206f2f' ParentLink='PortType_OperationDeclaration' LowerBound='32.1' HigherBound='36.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='PostDecline' />
                <om:Property Name='Signal' Value='True' />
                <om:Element Type='MessageRef' OID='2090e655-d939-4b9d-b4c9-1af0842b5cfa' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='34.13' HigherBound='34.28'>
                    <om:Property Name='Ref' Value='BootCamp.Orchestration.Exception.FaultHandler.RequestDeclined' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='PortType' OID='9fb42552-5e41-43e0-98b3-6d80077820d8' ParentLink='Module_PortType' LowerBound='37.1' HigherBound='44.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='RepairPortType' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='bf51a6e1-692a-4ed3-8572-21499a8b233a' ParentLink='PortType_OperationDeclaration' LowerBound='39.1' HigherBound='43.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='SubmitRepair' />
                <om:Property Name='Signal' Value='True' />
                <om:Element Type='MessageRef' OID='e17eda60-be0d-4683-9d54-eaa5836f31b7' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='41.13' HigherBound='41.28'>
                    <om:Property Name='Ref' Value='BootCamp.Orchestration.Exception.FaultHandler.RequestApproved' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='ServiceDeclaration' OID='228af2e3-a0fe-4c0f-b971-664058021e19' ParentLink='Module_ServiceDeclaration' LowerBound='44.1' HigherBound='89.1'>
            <om:Property Name='InitializedTransactionType' Value='False' />
            <om:Property Name='IsInvokable' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='EAIProcessHandler' />
            <om:Property Name='Signal' Value='True' />
            <om:Element Type='VariableDeclaration' OID='5d2e9847-fa94-42c5-a724-754e8453259e' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='58.1' HigherBound='59.1'>
                <om:Property Name='UseDefaultConstructor' Value='True' />
                <om:Property Name='Type' Value='System.Exception' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='newExc' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='ce2d9512-0d17-4caa-9cd4-2fc6f488cb93' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='55.1' HigherBound='56.1'>
                <om:Property Name='Type' Value='BootCamp.Orchestration.Exception.FaultHandler.FaultMessageType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='FaultMsg' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='0cf4c7d2-f387-4e15-993b-0301cc74435b' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='56.1' HigherBound='57.1'>
                <om:Property Name='Type' Value='BootCamp.Orchestration.Exception.FaultHandler.RequestApproved' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='RequestMsg' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='14bb7bd9-6a16-48cb-b32a-ce5f0ef875b5' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='57.1' HigherBound='58.1'>
                <om:Property Name='Type' Value='BootCamp.Orchestration.Exception.FaultHandler.RequestDeclined' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='DeniedMsg' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='ServiceBody' OID='57fe69a2-1254-4ecb-846a-683fb6b8f6d3' ParentLink='ServiceDeclaration_ServiceBody'>
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='Receive' OID='5f7c7ed7-8bab-4994-8c4f-855ad63773ff' ParentLink='ServiceBody_Statement' LowerBound='61.1' HigherBound='64.1'>
                    <om:Property Name='Activate' Value='True' />
                    <om:Property Name='PortName' Value='FaultProcess' />
                    <om:Property Name='MessageName' Value='FaultMsg' />
                    <om:Property Name='OperationName' Value='SubmitFault' />
                    <om:Property Name='OperationMessageName' Value='Request' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Receive Fault' />
                    <om:Property Name='Signal' Value='True' />
                    <om:Element Type='DNFPredicate' OID='df390c11-c9ac-49bd-998e-4e434f0242f7' ParentLink='Receive_DNFPredicate'>
                        <om:Property Name='LHS' Value='Msft.Samples.BizTalk.Exception.Schemas.FaultCode' />
                        <om:Property Name='RHS' Value='&quot;1001&quot;' />
                        <om:Property Name='Grouping' Value='AND' />
                        <om:Property Name='Operator' Value='Equals' />
                        <om:Property Name='Signal' Value='False' />
                    </om:Element>
                </om:Element>
                <om:Element Type='VariableAssignment' OID='f75bab47-dd38-4db8-bed9-ff80f49f3c42' ParentLink='ServiceBody_Statement' LowerBound='64.1' HigherBound='74.1'>
                    <om:Property Name='Expression' Value='//Retrieve the 2 messages from the Fault Message and submit them...&#xD;&#xA;RequestMsg = Msft.Samples.BizTalk.Exception.ExceptionMgmt.GetMessage(FaultMsg,&quot;ApprovedRequest&quot;);&#xD;&#xA;DeniedMsg = Msft.Samples.BizTalk.Exception.ExceptionMgmt.GetMessage(FaultMsg,&quot;DeniedRequest&quot;);&#xD;&#xA;&#xD;&#xA;//Retrieve the System.Exception from the Original Service&#xD;&#xA;newExc = Msft.Samples.BizTalk.Exception.ExceptionMgmt.GetException(FaultMsg);&#xD;&#xA;&#xD;&#xA;// Write the error value to event log (need admin rights)&#xD;&#xA;System.Diagnostics.EventLog.WriteEntry(&quot;EAIProcessHandler&quot;,newExc.Message.ToString());&#xD;&#xA;' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Retrieve All Msgs' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
                <om:Element Type='Decision' OID='02e11e55-c79b-4718-851e-13e9591e70c9' ParentLink='ServiceBody_Statement' LowerBound='74.1' HigherBound='85.1'>
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Divide By Zero Exception?' />
                    <om:Property Name='Signal' Value='True' />
                    <om:Element Type='DecisionBranch' OID='0377735c-4caf-4759-8c2d-e3a31c433799' ParentLink='ReallyComplexStatement_Branch' LowerBound='75.13' HigherBound='80.1'>
                        <om:Property Name='Expression' Value='FaultMsg(Msft.Samples.BizTalk.Exception.Schemas.ErrorType) == &quot;DivideByZeroException&quot;' />
                        <om:Property Name='IsGhostBranch' Value='True' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='Yes' />
                        <om:Property Name='Signal' Value='False' />
                        <om:Element Type='Task' OID='742f7903-1cce-4b8a-b571-49c580b742b9' ParentLink='ComplexStatement_Statement' LowerBound='77.1' HigherBound='79.1'>
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Repair Message and ReSubmit' />
                            <om:Property Name='Signal' Value='True' />
                            <om:Element Type='Send' OID='2cda7bc4-2a04-4216-8d27-d043d6582316' ParentLink='ComplexStatement_Statement' LowerBound='77.1' HigherBound='79.1'>
                                <om:Property Name='PortName' Value='RepairSubmit' />
                                <om:Property Name='MessageName' Value='RequestMsg' />
                                <om:Property Name='OperationName' Value='SubmitRepair' />
                                <om:Property Name='OperationMessageName' Value='Request' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='Send Repair' />
                                <om:Property Name='Signal' Value='True' />
                            </om:Element>
                        </om:Element>
                    </om:Element>
                    <om:Element Type='DecisionBranch' OID='d96cbf9a-0f6e-4f48-89fa-639e46e1efe0' ParentLink='ReallyComplexStatement_Branch'>
                        <om:Property Name='IsGhostBranch' Value='True' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='Else' />
                        <om:Property Name='Signal' Value='False' />
                        <om:Element Type='Send' OID='0c801fe5-d753-4e45-b5e3-e9fd38985cf7' ParentLink='ComplexStatement_Statement' LowerBound='82.1' HigherBound='84.1'>
                            <om:Property Name='PortName' Value='ApprovedPublish' />
                            <om:Property Name='MessageName' Value='RequestMsg' />
                            <om:Property Name='OperationName' Value='PostApprove' />
                            <om:Property Name='OperationMessageName' Value='Request' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Send Approved' />
                            <om:Property Name='Signal' Value='True' />
                        </om:Element>
                    </om:Element>
                </om:Element>
                <om:Element Type='Send' OID='b8607b8e-feea-4378-9368-320a9efe5f86' ParentLink='ServiceBody_Statement' LowerBound='85.1' HigherBound='87.1'>
                    <om:Property Name='PortName' Value='DeclinedPublish' />
                    <om:Property Name='MessageName' Value='DeniedMsg' />
                    <om:Property Name='OperationName' Value='PostDecline' />
                    <om:Property Name='OperationMessageName' Value='Request' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Send Declined' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='90da5a25-6f9e-4d58-97ee-cb364c520f19' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='47.1' HigherBound='49.1'>
                <om:Property Name='PortModifier' Value='Implements' />
                <om:Property Name='Orientation' Value='Left' />
                <om:Property Name='PortIndex' Value='-1' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='BootCamp.Orchestration.Exception.FaultHandler.FaultProcessType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='FaultProcess' />
                <om:Property Name='Signal' Value='True' />
                <om:Element Type='DirectBindingAttribute' OID='e80de96a-3508-404f-bbbf-761d4dc56795' ParentLink='PortDeclaration_CLRAttribute' LowerBound='47.1' HigherBound='48.1'>
                    <om:Property Name='DirectBindingType' Value='MessageBox' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='6ca54dcc-4dba-49b7-8732-16acda1cd499' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='49.1' HigherBound='51.1'>
                <om:Property Name='PortModifier' Value='Uses' />
                <om:Property Name='Orientation' Value='Left' />
                <om:Property Name='PortIndex' Value='18' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='BootCamp.Orchestration.Exception.FaultHandler.RepairPortType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='RepairSubmit' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='e23ad329-e00c-4076-a2ef-caf3f56e7fdf' ParentLink='PortDeclaration_CLRAttribute' LowerBound='49.1' HigherBound='50.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='fdee6156-a222-49c0-8206-a7530b91fa4a' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='51.1' HigherBound='53.1'>
                <om:Property Name='PortModifier' Value='Uses' />
                <om:Property Name='Orientation' Value='Right' />
                <om:Property Name='PortIndex' Value='29' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='BootCamp.Orchestration.Exception.FaultHandler.DeclinedPublishType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='DeclinedPublish' />
                <om:Property Name='Signal' Value='True' />
                <om:Element Type='DirectBindingAttribute' OID='4f3e25b5-cfdf-4118-aee0-36f4cc919ee0' ParentLink='PortDeclaration_CLRAttribute' LowerBound='51.1' HigherBound='52.1'>
                    <om:Property Name='DirectBindingType' Value='MessageBox' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='0762c1bb-14bf-4764-b49c-ee917c682e29' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='53.1' HigherBound='55.1'>
                <om:Property Name='PortModifier' Value='Uses' />
                <om:Property Name='Orientation' Value='Right' />
                <om:Property Name='PortIndex' Value='19' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='BootCamp.Orchestration.Exception.FaultHandler.ApprovedPublishType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='ApprovedPublish' />
                <om:Property Name='Signal' Value='True' />
                <om:Element Type='DirectBindingAttribute' OID='11b82b1c-0119-472d-b16b-3efe3e13ced3' ParentLink='PortDeclaration_CLRAttribute' LowerBound='53.1' HigherBound='54.1'>
                    <om:Property Name='DirectBindingType' Value='MessageBox' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='MultipartMessageType' OID='f2e48dae-ab0e-430a-a719-6dcb68b4de08' ParentLink='Module_MessageType' LowerBound='4.1' HigherBound='8.1'>
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='RequestDeclined' />
            <om:Property Name='Signal' Value='True' />
            <om:Element Type='PartDeclaration' OID='20faec5c-ebea-4eee-951c-21b8e1db5027' ParentLink='MultipartMessageType_PartDeclaration' LowerBound='6.1' HigherBound='7.1'>
                <om:Property Name='ClassName' Value='BootCamp.Orchestration.Exception.Schemas.RequestDenied' />
                <om:Property Name='IsBodyPart' Value='True' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Body' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
        </om:Element>
        <om:Element Type='MultipartMessageType' OID='90dbb16b-6c20-4f38-a7fa-8ac67a589dec' ParentLink='Module_MessageType' LowerBound='8.1' HigherBound='12.1'>
            <om:Property Name='TypeModifier' Value='Public' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='RequestApproved' />
            <om:Property Name='Signal' Value='True' />
            <om:Element Type='PartDeclaration' OID='85fce5ce-8065-4aea-926b-b94f6f3a34a9' ParentLink='MultipartMessageType_PartDeclaration' LowerBound='10.1' HigherBound='11.1'>
                <om:Property Name='ClassName' Value='BootCamp.Orchestration.Exception.Schemas.Request' />
                <om:Property Name='IsBodyPart' Value='True' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Body' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
        </om:Element>
        <om:Element Type='MultipartMessageType' OID='01da1701-2652-4ac5-a795-1bb30864885b' ParentLink='Module_MessageType' LowerBound='12.1' HigherBound='16.1'>
            <om:Property Name='TypeModifier' Value='Public' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='FaultMessageType' />
            <om:Property Name='Signal' Value='True' />
            <om:Element Type='PartDeclaration' OID='b79877e5-4e26-4280-8d1b-718267d2896c' ParentLink='MultipartMessageType_PartDeclaration' LowerBound='14.1' HigherBound='15.1'>
                <om:Property Name='ClassName' Value='Msft.Samples.BizTalk.Exception.Schemas.FaultMessage' />
                <om:Property Name='IsBodyPart' Value='True' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Body' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
        </om:Element>
    </om:Element>
</om:MetaModel>
";

        [System.SerializableAttribute]
        public class __EAIProcessHandler_root_0 : Microsoft.XLANGs.Core.ServiceContext
        {
            public __EAIProcessHandler_root_0(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "EAIProcessHandler")
            {
            }

            public override int Index { get { return 0; } }

            public override Microsoft.XLANGs.Core.Segment InitialSegment
            {
                get { return _service._segments[0]; }
            }
            public override Microsoft.XLANGs.Core.Segment FinalSegment
            {
                get { return _service._segments[0]; }
            }

            public override int CompensationSegment { get { return -1; } }
            public override bool OnError()
            {
                Finally();
                return false;
            }

            public override void Finally()
            {
                EAIProcessHandler __svc__ = (EAIProcessHandler)_service;
                __EAIProcessHandler_root_0 __ctx0__ = (__EAIProcessHandler_root_0)(__svc__._stateMgrs[0]);

                if (__svc__.FaultProcess != null)
                {
                    __svc__.FaultProcess.Close(this, null);
                    __svc__.FaultProcess = null;
                }
                if (__svc__.ApprovedPublish != null)
                {
                    __svc__.ApprovedPublish.Close(this, null);
                    __svc__.ApprovedPublish = null;
                }
                if (__svc__.DeclinedPublish != null)
                {
                    __svc__.DeclinedPublish.Close(this, null);
                    __svc__.DeclinedPublish = null;
                }
                if (__svc__.RepairSubmit != null)
                {
                    __svc__.RepairSubmit.Close(this, null);
                    __svc__.RepairSubmit = null;
                }
                base.Finally();
            }

            internal Microsoft.XLANGs.Core.SubscriptionWrapper __subWrapper0;
        }


        [System.SerializableAttribute]
        public class __EAIProcessHandler_1 : Microsoft.XLANGs.Core.ExceptionHandlingContext
        {
            public __EAIProcessHandler_1(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "EAIProcessHandler")
            {
            }

            public override int Index { get { return 1; } }

            public override bool CombineParentCommit { get { return true; } }

            public override Microsoft.XLANGs.Core.Segment InitialSegment
            {
                get { return _service._segments[1]; }
            }
            public override Microsoft.XLANGs.Core.Segment FinalSegment
            {
                get { return _service._segments[1]; }
            }

            public override int CompensationSegment { get { return -1; } }
            public override bool OnError()
            {
                Finally();
                return false;
            }

            public override void Finally()
            {
                EAIProcessHandler __svc__ = (EAIProcessHandler)_service;
                __EAIProcessHandler_1 __ctx1__ = (__EAIProcessHandler_1)(__svc__._stateMgrs[1]);

                if (__ctx1__ != null)
                    __ctx1__.__newExc = null;
                if (__ctx1__ != null && __ctx1__.__FaultMsg != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__FaultMsg);
                    __ctx1__.__FaultMsg = null;
                }
                if (__ctx1__ != null && __ctx1__.__RequestMsg != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__RequestMsg);
                    __ctx1__.__RequestMsg = null;
                }
                if (__ctx1__ != null && __ctx1__.__DeniedMsg != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__DeniedMsg);
                    __ctx1__.__DeniedMsg = null;
                }
                base.Finally();
            }

            [Microsoft.XLANGs.Core.UserVariableAttribute("FaultMsg")]
            internal FaultMessageType __FaultMsg;
            [Microsoft.XLANGs.Core.UserVariableAttribute("RequestMsg")]
            internal RequestApproved __RequestMsg;
            [Microsoft.XLANGs.Core.UserVariableAttribute("DeniedMsg")]
            internal RequestDeclined __DeniedMsg;
            [Microsoft.XLANGs.Core.UserVariableAttribute("newExc")]
            internal System.Exception __newExc;
        }

        private static Microsoft.XLANGs.Core.CorrelationType[] _correlationTypes = null;
        public override Microsoft.XLANGs.Core.CorrelationType[] CorrelationTypes { get { return _correlationTypes; } }

        private static System.Guid[] _convoySetIds;

        public override System.Guid[] ConvoySetGuids
        {
            get { return _convoySetIds; }
            set { _convoySetIds = value; }
        }

        public static object[] StaticConvoySetInformation
        {
            get {
                return null;
            }
        }

        [Microsoft.XLANGs.BaseTypes.DirectBindingAttribute()]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eImplements
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("FaultProcess")]
        internal FaultProcessType FaultProcess;
        [Microsoft.XLANGs.BaseTypes.LogicalBindingAttribute()]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("RepairSubmit")]
        internal RepairPortType RepairSubmit;
        [Microsoft.XLANGs.BaseTypes.DirectBindingAttribute()]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("ApprovedPublish")]
        internal ApprovedPublishType ApprovedPublish;
        [Microsoft.XLANGs.BaseTypes.DirectBindingAttribute()]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("DeclinedPublish")]
        internal DeclinedPublishType DeclinedPublish;
        private static Msft.Samples.BizTalk.Exception.Schemas.FaultCode _prop_Msft_Samples_BizTalk_Exception_Schemas_FaultCode = new Msft.Samples.BizTalk.Exception.Schemas.FaultCode();

        sealed private class PredicateSet0_0 : Microsoft.XLANGs.Core.PredicateGroup
        {
            public PredicateSet0_0() : base(1)
            {
                Add(new Microsoft.XLANGs.Core.FullySpecifiedPredicate(_prop_Msft_Samples_BizTalk_Exception_Schemas_FaultCode, Microsoft.XLANGs.Core.PredicateBase.Operators.eEqual, "1001"));
            }
        }


        private static Microsoft.XLANGs.Core.PredicateGroup[] _predicates0 = {
            new PredicateSet0_0()
        };


        public static Microsoft.XLANGs.Core.PortInfo[] _portInfo = new Microsoft.XLANGs.Core.PortInfo[] {
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {FaultProcessType.SubmitFault},
                                               typeof(EAIProcessHandler).GetField("FaultProcess", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.implements,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(EAIProcessHandler), "FaultProcess"),
                                               null),
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {RepairPortType.SubmitRepair},
                                               typeof(EAIProcessHandler).GetField("RepairSubmit", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.uses,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(EAIProcessHandler), "RepairSubmit"),
                                               null),
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {ApprovedPublishType.PostApprove},
                                               typeof(EAIProcessHandler).GetField("ApprovedPublish", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.uses,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(EAIProcessHandler), "ApprovedPublish"),
                                               null),
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {DeclinedPublishType.PostDecline},
                                               typeof(EAIProcessHandler).GetField("DeclinedPublish", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.uses,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(EAIProcessHandler), "DeclinedPublish"),
                                               null)
        };

        public override Microsoft.XLANGs.Core.PortInfo[] PortInformation
        {
            get { return _portInfo; }
        }

        static public System.Collections.Hashtable PortsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[_portInfo[0].Name] = _portInfo[0];
                h[_portInfo[1].Name] = _portInfo[1];
                h[_portInfo[2].Name] = _portInfo[2];
                h[_portInfo[3].Name] = _portInfo[3];
                return h;
            }
        }

        public static System.Type[] InvokedServicesTypes
        {
            get
            {
                return new System.Type[] {
                    // type of each service invoked by this service
                };
            }
        }

        public static System.Type[] CalledServicesTypes
        {
            get
            {
                return new System.Type[] {
                };
            }
        }

        public static System.Type[] ExecedServicesTypes
        {
            get
            {
                return new System.Type[] {
                };
            }
        }

        public static object[] StaticSubscriptionsInformation {
            get {
                return new object[1]{
                     new object[5] { _portInfo[0], 0, _predicates0 , -1, true }
                };
            }
        }

        public static Microsoft.XLANGs.RuntimeTypes.Location[] __eventLocations = new Microsoft.XLANGs.RuntimeTypes.Location[] {
            new Microsoft.XLANGs.RuntimeTypes.Location(0, "00000000-0000-0000-0000-000000000000", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(1, "5f7c7ed7-8bab-4994-8c4f-855ad63773ff", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(2, "5f7c7ed7-8bab-4994-8c4f-855ad63773ff", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(3, "00000000-0000-0000-0000-000000000000", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(4, "f75bab47-dd38-4db8-bed9-ff80f49f3c42", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(5, "f75bab47-dd38-4db8-bed9-ff80f49f3c42", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(6, "02e11e55-c79b-4718-851e-13e9591e70c9", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(7, "2cda7bc4-2a04-4216-8d27-d043d6582316", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(8, "2cda7bc4-2a04-4216-8d27-d043d6582316", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(9, "0c801fe5-d753-4e45-b5e3-e9fd38985cf7", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(10, "0c801fe5-d753-4e45-b5e3-e9fd38985cf7", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(11, "02e11e55-c79b-4718-851e-13e9591e70c9", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(12, "b8607b8e-feea-4378-9368-320a9efe5f86", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(13, "b8607b8e-feea-4378-9368-320a9efe5f86", 1, false)
        };

        public override Microsoft.XLANGs.RuntimeTypes.Location[] EventLocations
        {
            get { return __eventLocations; }
        }

        public static Microsoft.XLANGs.RuntimeTypes.EventData[] __eventData = new Microsoft.XLANGs.RuntimeTypes.EventData[] {
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Body),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Receive),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Expression),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Expression),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.If),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Send),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.If),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Body)
        };

        public static int[] __progressLocation0 = new int[] { 0,0,0,3,3,};
        public static int[] __progressLocation1 = new int[] { 0,0,1,1,2,2,4,4,5,5,5,5,6,6,7,7,7,8,6,9,9,9,10,11,12,12,12,13,3,3,3,3,};

        public static int[][] __progressLocations = new int[2] [] {__progressLocation0,__progressLocation1};
        public override int[][] ProgressLocations {get {return __progressLocations;} }

        public Microsoft.XLANGs.Core.StopConditions segment0(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[0];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[0];
            __EAIProcessHandler_root_0 __ctx0__ = (__EAIProcessHandler_root_0)_stateMgrs[0];
            __EAIProcessHandler_1 __ctx1__ = (__EAIProcessHandler_1)_stateMgrs[1];

            switch (__seg__.Progress)
            {
            case 0:
                FaultProcess = new FaultProcessType(0, this);
                RepairSubmit = new RepairPortType(1, this);
                DeclinedPublish = new DeclinedPublishType(3, this);
                ApprovedPublish = new ApprovedPublishType(2, this);
                __ctx__.PrologueCompleted = true;
                __ctx0__.__subWrapper0 = new Microsoft.XLANGs.Core.SubscriptionWrapper(ActivationSubGuids[0], FaultProcess, this);
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.Initialized) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.Initialized;
                goto case 1;
            case 1:
                __ctx1__ = new __EAIProcessHandler_1(this);
                _stateMgrs[1] = __ctx1__;
                if ( !PostProgressInc( __seg__, __ctx__, 2 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 2;
            case 2:
                __ctx0__.StartContext(__seg__, __ctx1__);
                if ( !PostProgressInc( __seg__, __ctx__, 3 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                return Microsoft.XLANGs.Core.StopConditions.Blocked;
            case 3:
                if (!__ctx0__.CleanupAndPrepareToCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 4;
            case 4:
                __ctx1__.Finally();
                ServiceDone(__seg__, (Microsoft.XLANGs.Core.Context)_stateMgrs[0]);
                __ctx0__.OnCommit();
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }

        public Microsoft.XLANGs.Core.StopConditions segment1(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Envelope __msgEnv__ = null;
            bool __condition__;
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[1];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[1];
            __EAIProcessHandler_root_0 __ctx0__ = (__EAIProcessHandler_root_0)_stateMgrs[0];
            __EAIProcessHandler_1 __ctx1__ = (__EAIProcessHandler_1)_stateMgrs[1];

            switch (__seg__.Progress)
            {
            case 0:
                __ctx1__.__newExc = default(System.Exception);
                __ctx__.PrologueCompleted = true;
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 1;
            case 1:
                if ( !PreProgressInc( __seg__, __ctx__, 2 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[0],__eventData[0],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 2;
            case 2:
                if ( !PreProgressInc( __seg__, __ctx__, 3 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[1],__eventData[1],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 3;
            case 3:
                if (!FaultProcess.GetMessageId(__ctx0__.__subWrapper0.getSubscription(this), __seg__, __ctx1__, out __msgEnv__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if (__ctx1__.__FaultMsg != null)
                    __ctx1__.UnrefMessage(__ctx1__.__FaultMsg);
                __ctx1__.__FaultMsg = new FaultMessageType("FaultMsg", __ctx1__);
                __ctx1__.RefMessage(__ctx1__.__FaultMsg);
                FaultProcess.ReceiveMessage(0, __msgEnv__, __ctx1__.__FaultMsg, null, (Microsoft.XLANGs.Core.Context)_stateMgrs[1], __seg__);
                if (FaultProcess != null)
                {
                    FaultProcess.Close(__ctx1__, __seg__);
                    FaultProcess = null;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 4;
            case 4:
                if ( !PreProgressInc( __seg__, __ctx__, 5 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Receive);
                    __edata.Messages.Add(__ctx1__.__FaultMsg);
                    __edata.PortName = @"FaultProcess";
                    Tracker.FireEvent(__eventLocations[2],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 5;
            case 5:
                __ctx1__.__newExc = new System.Exception();
                if ( !PostProgressInc( __seg__, __ctx__, 6 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 6;
            case 6:
                if ( !PreProgressInc( __seg__, __ctx__, 7 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[4],__eventData[2],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 7;
            case 7:
                if (__ctx1__.__RequestMsg != null)
                    __ctx1__.UnrefMessage(__ctx1__.__RequestMsg);
                __ctx1__.__RequestMsg = new RequestApproved("RequestMsg", __ctx1__);
                __ctx1__.RefMessage(__ctx1__.__RequestMsg);
                __ctx1__.__RequestMsg = (RequestApproved)UnwrapMessageFromUserCode(Msft.Samples.BizTalk.Exception.ExceptionMgmt.GetMessage(CreateMessageWrapperForUserCode(__ctx1__.__FaultMsg), "ApprovedRequest"), __ctx1__, __ctx1__.__RequestMsg);
                __ctx1__.__RequestMsg.ConstructionCompleteEvent(false);
                if ( !PostProgressInc( __seg__, __ctx__, 8 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 8;
            case 8:
                if ( !PreProgressInc( __seg__, __ctx__, 9 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[5],__eventData[3],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 9;
            case 9:
                if (__ctx1__.__DeniedMsg != null)
                    __ctx1__.UnrefMessage(__ctx1__.__DeniedMsg);
                __ctx1__.__DeniedMsg = new RequestDeclined("DeniedMsg", __ctx1__);
                __ctx1__.RefMessage(__ctx1__.__DeniedMsg);
                __ctx1__.__DeniedMsg = (RequestDeclined)UnwrapMessageFromUserCode(Msft.Samples.BizTalk.Exception.ExceptionMgmt.GetMessage(CreateMessageWrapperForUserCode(__ctx1__.__FaultMsg), "DeniedRequest"), __ctx1__, __ctx1__.__DeniedMsg);
                __ctx1__.__DeniedMsg.ConstructionCompleteEvent(false);
                if ( !PostProgressInc( __seg__, __ctx__, 10 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 10;
            case 10:
                __ctx1__.__newExc = Msft.Samples.BizTalk.Exception.ExceptionMgmt.GetException(CreateMessageWrapperForUserCode(__ctx1__.__FaultMsg));
                if ( !PostProgressInc( __seg__, __ctx__, 11 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 11;
            case 11:
                System.Diagnostics.EventLog.WriteEntry("EAIProcessHandler", __ctx1__.__newExc.Message.ToString());
                if (__ctx1__ != null)
                    __ctx1__.__newExc = null;
                if ( !PostProgressInc( __seg__, __ctx__, 12 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 12;
            case 12:
                if ( !PreProgressInc( __seg__, __ctx__, 13 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[6],__eventData[4],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 13;
            case 13:
                __condition__ = (System.String)__ctx1__.__FaultMsg.GetPropertyValueThrows(typeof(Msft.Samples.BizTalk.Exception.Schemas.ErrorType)) == "DivideByZeroException";
                if (__ctx1__ != null && __ctx1__.__FaultMsg != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__FaultMsg);
                    __ctx1__.__FaultMsg = null;
                }
                if (!__condition__)
                {
                    if ( !PostProgressInc( __seg__, __ctx__, 19 ) )
                        return Microsoft.XLANGs.Core.StopConditions.Paused;
                    goto case 19;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 14 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 14;
            case 14:
                if ( !PreProgressInc( __seg__, __ctx__, 15 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[7],__eventData[5],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 15;
            case 15:
                if (!__ctx1__.PrepareToPendingCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 16 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 16;
            case 16:
                if ( !PreProgressInc( __seg__, __ctx__, 17 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                RepairSubmit.SendMessage(0, __ctx1__.__RequestMsg, null, null, __ctx1__, __seg__ , Microsoft.XLANGs.Core.ActivityFlags.None );
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingRqst) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingRqst;
                goto case 17;
            case 17:
                if ( !PreProgressInc( __seg__, __ctx__, 18 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__RequestMsg);
                    __edata.PortName = @"RepairSubmit";
                    Tracker.FireEvent(__eventLocations[8],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 18;
            case 18:
                if ( !PostProgressInc( __seg__, __ctx__, 23 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 23;
            case 19:
                if ( !PreProgressInc( __seg__, __ctx__, 20 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[9],__eventData[5],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 20;
            case 20:
                if (!__ctx1__.PrepareToPendingCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 21 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 21;
            case 21:
                if ( !PreProgressInc( __seg__, __ctx__, 22 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                ApprovedPublish.SendMessage(0, __ctx1__.__RequestMsg, null, null, __ctx1__, __seg__ , Microsoft.XLANGs.Core.ActivityFlags.None );
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingRqst) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingRqst;
                goto case 22;
            case 22:
                if ( !PreProgressInc( __seg__, __ctx__, 23 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__RequestMsg);
                    __edata.PortName = @"ApprovedPublish";
                    Tracker.FireEvent(__eventLocations[10],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 23;
            case 23:
                if ( !PreProgressInc( __seg__, __ctx__, 24 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                if (__ctx1__ != null && __ctx1__.__RequestMsg != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__RequestMsg);
                    __ctx1__.__RequestMsg = null;
                }
                if (ApprovedPublish != null)
                {
                    ApprovedPublish.Close(__ctx1__, __seg__);
                    ApprovedPublish = null;
                }
                if (RepairSubmit != null)
                {
                    RepairSubmit.Close(__ctx1__, __seg__);
                    RepairSubmit = null;
                }
                Tracker.FireEvent(__eventLocations[11],__eventData[6],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 24;
            case 24:
                if ( !PreProgressInc( __seg__, __ctx__, 25 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[12],__eventData[5],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 25;
            case 25:
                if (!__ctx1__.PrepareToPendingCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 26 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 26;
            case 26:
                if ( !PreProgressInc( __seg__, __ctx__, 27 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                DeclinedPublish.SendMessage(0, __ctx1__.__DeniedMsg, null, null, __ctx1__, __seg__ , Microsoft.XLANGs.Core.ActivityFlags.NextActivityPersists );
                if (DeclinedPublish != null)
                {
                    DeclinedPublish.Close(__ctx1__, __seg__);
                    DeclinedPublish = null;
                }
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingRqst) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingRqst;
                goto case 27;
            case 27:
                if ( !PreProgressInc( __seg__, __ctx__, 28 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__DeniedMsg);
                    __edata.PortName = @"DeclinedPublish";
                    Tracker.FireEvent(__eventLocations[13],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (__ctx1__ != null && __ctx1__.__DeniedMsg != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__DeniedMsg);
                    __ctx1__.__DeniedMsg = null;
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 28;
            case 28:
                if ( !PreProgressInc( __seg__, __ctx__, 29 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[3],__eventData[7],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 29;
            case 29:
                if (!__ctx1__.CleanupAndPrepareToCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 30 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 30;
            case 30:
                if ( !PreProgressInc( __seg__, __ctx__, 31 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                __ctx1__.OnCommit();
                goto case 31;
            case 31:
                __seg__.SegmentDone();
                _segments[0].PredecessorDone(this);
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }
    }

    [Microsoft.XLANGs.BaseTypes.BPELExportableAttribute(false)]
    sealed public class _MODULE_PROXY_ { }
}

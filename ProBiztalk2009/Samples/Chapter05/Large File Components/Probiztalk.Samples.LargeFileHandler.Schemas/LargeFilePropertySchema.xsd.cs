namespace Microsoft.Samples.LargeFileHandler.Schemas {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [SchemaType(SchemaTypeEnum.Property)]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"LargeFileLocation", @"IsEncoded"})]
    public sealed class LargeFilePropertySchema : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns=""http://Microsoft.Samples.LargeFileHandler.Schemas.LargeFilePropertySchema"" targetNamespace=""http://Microsoft.Samples.LargeFileHandler.Schemas.LargeFilePropertySchema"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:annotation>
    <xs:appinfo>
      <b:schemaInfo schema_type=""property"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" />
    </xs:appinfo>
  </xs:annotation>
  <xs:element name=""LargeFileLocation"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo propertyGuid=""6b392176-a482-4bb5-9875-2ede86d62e44"" />
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""IsEncoded"" type=""xs:boolean"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo propertyGuid=""8f788f3a-29d6-42e1-882b-a4b59598682c"" />
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
</xs:schema>";
        
        public LargeFilePropertySchema() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [2];
                _RootElements[0] = "LargeFileLocation";
                _RootElements[1] = "IsEncoded";
                return _RootElements;
            }
        }
        
        protected override object RawSchema {
            get {
                return _rawSchema;
            }
            set {
                _rawSchema = value;
            }
        }
    }
    
    [System.SerializableAttribute()]
    [PropertyType(@"LargeFileLocation",@"http://Microsoft.Samples.LargeFileHandler.Schemas.LargeFilePropertySchema","string","System.String")]
    [PropertyGuidAttribute(@"6b392176-a482-4bb5-9875-2ede86d62e44")]
    public sealed class LargeFileLocation : Microsoft.XLANGs.BaseTypes.MessageDataPropertyBase {
        
        [System.NonSerializedAttribute()]
        private static System.Xml.XmlQualifiedName _QName = new System.Xml.XmlQualifiedName(@"LargeFileLocation", @"http://Microsoft.Samples.LargeFileHandler.Schemas.LargeFilePropertySchema");
        
        private static string PropertyValueType {
            get {
                throw new System.NotSupportedException();
            }
        }
        
        public override System.Xml.XmlQualifiedName Name {
            get {
                return _QName;
            }
        }
        
        public override System.Type Type {
            get {
                return typeof(string);
            }
        }
    }
    
    [System.SerializableAttribute()]
    [PropertyType(@"IsEncoded",@"http://Microsoft.Samples.LargeFileHandler.Schemas.LargeFilePropertySchema","boolean","System.Boolean")]
    [PropertyGuidAttribute(@"8f788f3a-29d6-42e1-882b-a4b59598682c")]
    public sealed class IsEncoded : Microsoft.XLANGs.BaseTypes.MessageDataPropertyBase {
        
        [System.NonSerializedAttribute()]
        private static System.Xml.XmlQualifiedName _QName = new System.Xml.XmlQualifiedName(@"IsEncoded", @"http://Microsoft.Samples.LargeFileHandler.Schemas.LargeFilePropertySchema");
        
        private static bool PropertyValueType {
            get {
                throw new System.NotSupportedException();
            }
        }
        
        public override System.Xml.XmlQualifiedName Name {
            get {
                return _QName;
            }
        }
        
        public override System.Type Type {
            get {
                return typeof(bool);
            }
        }
    }
}

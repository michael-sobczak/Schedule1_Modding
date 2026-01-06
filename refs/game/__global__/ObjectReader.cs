internal sealed class ObjectReader // TypeDefIndex: 4502
{
	// Fields
	internal Stream m_stream; // 0x10
	internal ISurrogateSelector m_surrogates; // 0x18
	internal StreamingContext m_context; // 0x20
	internal ObjectManager m_objectManager; // 0x30
	internal InternalFE formatterEnums; // 0x38
	internal SerializationBinder m_binder; // 0x40
	internal long topId; // 0x48
	internal bool bSimpleAssembly; // 0x50
	internal object handlerObject; // 0x58
	internal object m_topObject; // 0x60
	internal Header[] headers; // 0x68
	internal HeaderHandler handler; // 0x70
	internal SerObjectInfoInit serObjectInfoInit; // 0x78
	internal IFormatterConverter m_formatterConverter; // 0x80
	internal SerStack stack; // 0x88
	private SerStack valueFixupStack; // 0x90
	internal object[] crossAppDomainArray; // 0x98
	private bool bFullDeserialization; // 0xA0
	private bool bOldFormatDetected; // 0xA1
	private IntSizedArray valTypeObjectIdTable; // 0xA8
	private NameCache typeCache; // 0xB0
	private string previousAssemblyString; // 0xB8
	private string previousName; // 0xC0
	private Type previousType; // 0xC8

	// Properties
	private SerStack ValueFixupStack { get; }
	internal object TopObject { get; set; }

	// Methods

	// RVA: 0x1B4EFF0 Offset: 0x1B4D9F0 VA: 0x181B4EFF0
	private SerStack get_ValueFixupStack() { }

	// RVA: 0x4C4BF0 Offset: 0x4C35F0 VA: 0x1804C4BF0
	internal object get_TopObject() { }

	// RVA: 0x1B4F080 Offset: 0x1B4DA80 VA: 0x181B4F080
	internal void set_TopObject(object value) { }

	// RVA: 0x1B4EE90 Offset: 0x1B4D890 VA: 0x181B4EE90
	internal void .ctor(Stream stream, ISurrogateSelector selector, StreamingContext context, InternalFE formatterEnums, SerializationBinder binder) { }

	// RVA: 0x1B4B2B0 Offset: 0x1B49CB0 VA: 0x181B4B2B0
	internal object Deserialize(HeaderHandler handler, __BinaryParser serParser, bool fCheck) { }

	// RVA: 0x1B4BF70 Offset: 0x1B4A970 VA: 0x181B4BF70
	private bool HasSurrogate(Type t) { }

	// RVA: 0x1B4AED0 Offset: 0x1B498D0 VA: 0x181B4AED0
	private void CheckSerializable(Type t) { }

	// RVA: 0x1B4C060 Offset: 0x1B4AA60 VA: 0x181B4C060
	private void InitFullDeserialization() { }

	// RVA: 0x6964D0 Offset: 0x694ED0 VA: 0x1806964D0
	internal object CrossAppDomainArray(int index) { }

	// RVA: 0x1B4B0D0 Offset: 0x1B49AD0 VA: 0x181B4B0D0
	internal ReadObjectInfo CreateReadObjectInfo(Type objectType) { }

	// RVA: 0x1B4B120 Offset: 0x1B49B20 VA: 0x181B4B120
	internal ReadObjectInfo CreateReadObjectInfo(Type objectType, string[] memberNames, Type[] memberTypes) { }

	// RVA: 0x1B4E9B0 Offset: 0x1B4D3B0 VA: 0x181B4E9B0
	internal void Parse(ParseRecord pr) { }

	// RVA: 0x1B4D700 Offset: 0x1B4C100 VA: 0x181B4D700
	private void ParseError(ParseRecord processing, ParseRecord onStack) { }

	// RVA: 0x1B4E850 Offset: 0x1B4D250 VA: 0x181B4E850
	private void ParseSerializedStreamHeader(ParseRecord pr) { }

	// RVA: 0x1B4E820 Offset: 0x1B4D220 VA: 0x181B4E820
	private void ParseSerializedStreamHeaderEnd(ParseRecord pr) { }

	// RVA: 0x1B4E460 Offset: 0x1B4CE60 VA: 0x181B4E460
	private void ParseObject(ParseRecord pr) { }

	// RVA: 0x1B4E130 Offset: 0x1B4CB30 VA: 0x181B4E130
	private void ParseObjectEnd(ParseRecord pr) { }

	// RVA: 0x1B4CE70 Offset: 0x1B4B870 VA: 0x181B4CE70
	private void ParseArray(ParseRecord pr) { }

	// RVA: 0x1B4C1A0 Offset: 0x1B4ABA0 VA: 0x181B4C1A0
	private void NextRectangleMap(ParseRecord pr) { }

	// RVA: 0x1B4C2D0 Offset: 0x1B4ACD0 VA: 0x181B4C2D0
	private void ParseArrayMember(ParseRecord pr) { }

	// RVA: 0x1B4C2A0 Offset: 0x1B4ACA0 VA: 0x181B4C2A0
	private void ParseArrayMemberEnd(ParseRecord pr) { }

	// RVA: 0x1B4DA20 Offset: 0x1B4C420 VA: 0x181B4DA20
	private void ParseMember(ParseRecord pr) { }

	// RVA: 0x1B4D960 Offset: 0x1B4C360 VA: 0x181B4D960
	private void ParseMemberEnd(ParseRecord pr) { }

	// RVA: 0x1B4E880 Offset: 0x1B4D280 VA: 0x181B4E880
	private void ParseString(ParseRecord pr, ParseRecord parentPr) { }

	// RVA: 0x1B4ED30 Offset: 0x1B4D730 VA: 0x181B4ED30
	private void RegisterObject(object obj, ParseRecord pr, ParseRecord objectPr) { }

	// RVA: 0x1B4EBF0 Offset: 0x1B4D5F0 VA: 0x181B4EBF0
	private void RegisterObject(object obj, ParseRecord pr, ParseRecord objectPr, bool bIsString) { }

	// RVA: 0x1B4B9A0 Offset: 0x1B4A3A0 VA: 0x181B4B9A0
	internal long GetId(long objectId) { }

	// RVA: 0x1B4AE70 Offset: 0x1B49870 VA: 0x181B4AE70
	internal Type Bind(string assemblyString, string typeString) { }

	// RVA: 0x1B4B720 Offset: 0x1B4A120 VA: 0x181B4B720
	internal Type FastBindToType(string assemblyName, string typeName) { }

	// RVA: 0x1B4EE20 Offset: 0x1B4D820 VA: 0x181B4EE20
	private static Assembly ResolveSimpleAssemblyName(AssemblyName assemblyName) { }

	// RVA: 0x1B4BAA0 Offset: 0x1B4A4A0 VA: 0x181B4BAA0
	private static void GetSimplyNamedTypeFromAssembly(Assembly assm, string typeName, ref Type type) { }

	// RVA: 0x1B4BC40 Offset: 0x1B4A640 VA: 0x181B4BC40
	internal Type GetType(BinaryAssemblyInfo assemblyInfo, string name) { }

	// RVA: 0x1B4B010 Offset: 0x1B49A10 VA: 0x181B4B010
	private static void CheckTypeForwardedTo(Assembly sourceAssembly, Assembly destAssembly, Type resolvedType) { }
}

internal sealed class ObjectWriter // TypeDefIndex: 4503
{
	// Fields
	private Queue m_objectQueue; // 0x10
	private ObjectIDGenerator m_idGenerator; // 0x18
	private int m_currentId; // 0x20
	private ISurrogateSelector m_surrogates; // 0x28
	private StreamingContext m_context; // 0x30
	private __BinaryWriter serWriter; // 0x40
	private SerializationObjectManager m_objectManager; // 0x48
	private long topId; // 0x50
	private string topName; // 0x58
	private Header[] headers; // 0x60
	private InternalFE formatterEnums; // 0x68
	private SerializationBinder m_binder; // 0x70
	private SerObjectInfoInit serObjectInfoInit; // 0x78
	private IFormatterConverter m_formatterConverter; // 0x80
	internal object[] crossAppDomainArray; // 0x88
	private object previousObj; // 0x90
	private long previousId; // 0x98
	private Type previousType; // 0xA0
	private InternalPrimitiveTypeE previousCode; // 0xA8
	private Hashtable assemblyToIdTable; // 0xB0
	private SerStack niPool; // 0xB8

	// Properties
	internal SerializationObjectManager ObjectManager { get; }

	// Methods

	// RVA: 0x1B53310 Offset: 0x1B51D10 VA: 0x181B53310
	internal void .ctor(ISurrogateSelector selector, StreamingContext context, InternalFE formatterEnums, SerializationBinder binder) { }

	// RVA: 0x1B4FB80 Offset: 0x1B4E580 VA: 0x181B4FB80
	internal void Serialize(object graph, Header[] inHeaders, __BinaryWriter serWriter, bool fCheck) { }

	// RVA: 0x4C1D80 Offset: 0x4C0780 VA: 0x1804C1D80
	internal SerializationObjectManager get_ObjectManager() { }

	// RVA: 0x1B52A10 Offset: 0x1B51410 VA: 0x181B52A10
	private void Write(WriteObjectInfo objectInfo, NameInfo memberNameInfo, NameInfo typeNameInfo) { }

	// RVA: 0x1B525A0 Offset: 0x1B50FA0 VA: 0x181B525A0
	private void Write(WriteObjectInfo objectInfo, NameInfo memberNameInfo, NameInfo typeNameInfo, string[] memberNames, Type[] memberTypes, object[] memberData, WriteObjectInfo[] memberObjectInfos) { }

	// RVA: 0x1B518E0 Offset: 0x1B502E0 VA: 0x181B518E0
	private void WriteMemberSetup(WriteObjectInfo objectInfo, NameInfo memberNameInfo, NameInfo typeNameInfo, string memberName, Type memberType, object memberData, WriteObjectInfo memberObjectInfo) { }

	// RVA: 0x1B51A60 Offset: 0x1B50460 VA: 0x181B51A60
	private void WriteMembers(NameInfo memberNameInfo, NameInfo memberTypeNameInfo, object memberData, WriteObjectInfo objectInfo, NameInfo typeNameInfo, WriteObjectInfo memberObjectInfo) { }

	// RVA: 0x1B50870 Offset: 0x1B4F270 VA: 0x181B50870
	private void WriteArray(WriteObjectInfo objectInfo, NameInfo memberNameInfo, WriteObjectInfo memberObjectInfo) { }

	// RVA: 0x1B50520 Offset: 0x1B4EF20 VA: 0x181B50520
	private void WriteArrayMember(WriteObjectInfo objectInfo, NameInfo arrayElemTypeNameInfo, object data) { }

	// RVA: 0x1B520A0 Offset: 0x1B50AA0 VA: 0x181B520A0
	private void WriteRectangle(WriteObjectInfo objectInfo, int rank, int[] maxA, Array array, NameInfo arrayElemNameTypeInfo, int[] lowerBoundA) { }

	// RVA: 0x1B4F6F0 Offset: 0x1B4E0F0 VA: 0x181B4F6F0
	private object GetNext(out long objID) { }

	// RVA: 0x1B4F8D0 Offset: 0x1B4E2D0 VA: 0x181B4F8D0
	private long InternalGetId(object obj, bool assignUniqueIdToValueType, Type type, out bool isNew) { }

	// RVA: 0x1B4FB00 Offset: 0x1B4E500 VA: 0x181B4FB00
	private long Schedule(object obj, bool assignUniqueIdToValueType, Type type) { }

	// RVA: 0x1B4FA40 Offset: 0x1B4E440 VA: 0x181B4FA40
	private long Schedule(object obj, bool assignUniqueIdToValueType, Type type, WriteObjectInfo objectInfo) { }

	// RVA: 0x1B516B0 Offset: 0x1B500B0 VA: 0x181B516B0
	private bool WriteKnownValueClass(NameInfo memberNameInfo, NameInfo typeNameInfo, object data) { }

	// RVA: 0x1B52080 Offset: 0x1B50A80 VA: 0x181B52080
	private void WriteObjectRef(NameInfo nameInfo, long objectId) { }

	// RVA: 0x1B52430 Offset: 0x1B50E30 VA: 0x181B52430
	private void WriteString(NameInfo memberNameInfo, NameInfo typeNameInfo, object stringObject) { }

	// RVA: 0x1B4F0D0 Offset: 0x1B4DAD0 VA: 0x181B4F0D0
	private bool CheckForNull(WriteObjectInfo objectInfo, NameInfo memberNameInfo, NameInfo typeNameInfo, object data) { }

	// RVA: 0x1B522F0 Offset: 0x1B50CF0 VA: 0x181B522F0
	private void WriteSerializedStreamHeader(long topId, long headerId) { }

	// RVA: 0x1B502E0 Offset: 0x1B4ECE0 VA: 0x181B502E0
	private NameInfo TypeToNameInfo(Type type, WriteObjectInfo objectInfo, InternalPrimitiveTypeE code, NameInfo nameInfo) { }

	// RVA: 0x1B50390 Offset: 0x1B4ED90 VA: 0x181B50390
	private NameInfo TypeToNameInfo(Type type) { }

	// RVA: 0x1B503F0 Offset: 0x1B4EDF0 VA: 0x181B503F0
	private NameInfo TypeToNameInfo(WriteObjectInfo objectInfo) { }

	// RVA: 0x1B50210 Offset: 0x1B4EC10 VA: 0x181B50210
	private NameInfo TypeToNameInfo(WriteObjectInfo objectInfo, NameInfo nameInfo) { }

	// RVA: 0x1B504A0 Offset: 0x1B4EEA0 VA: 0x181B504A0
	private void TypeToNameInfo(Type type, NameInfo nameInfo) { }

	// RVA: 0x1B4F9D0 Offset: 0x1B4E3D0 VA: 0x181B4F9D0
	private NameInfo MemberToNameInfo(string name) { }

	// RVA: 0x1B50170 Offset: 0x1B4EB70 VA: 0x181B50170
	internal InternalPrimitiveTypeE ToCode(Type type) { }

	// RVA: 0x1B4F290 Offset: 0x1B4DC90 VA: 0x181B4F290
	private long GetAssemblyId(WriteObjectInfo objectInfo) { }

	// RVA: 0x1B4F8B0 Offset: 0x1B4E2B0 VA: 0x181B4F8B0
	private Type GetType(object obj) { }

	// RVA: 0x1B4F640 Offset: 0x1B4E040 VA: 0x181B4F640
	private NameInfo GetNameInfo() { }

	// RVA: 0x1B4F280 Offset: 0x1B4DC80 VA: 0x181B4F280
	private bool CheckTypeFormat(FormatterTypeStyle test, FormatterTypeStyle want) { }

	// RVA: 0x1B4FA10 Offset: 0x1B4E410 VA: 0x181B4FA10
	private void PutNameInfo(NameInfo nameInfo) { }
}

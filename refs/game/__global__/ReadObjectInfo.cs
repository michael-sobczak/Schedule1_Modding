internal sealed class ReadObjectInfo // TypeDefIndex: 4496
{
	// Fields
	internal int objectInfoId; // 0x10
	internal static int readObjectInfoCounter; // 0x0
	internal Type objectType; // 0x18
	internal ObjectManager objectManager; // 0x20
	internal int count; // 0x28
	internal bool isSi; // 0x2C
	internal bool isNamed; // 0x2D
	internal bool isTyped; // 0x2E
	internal bool bSimpleAssembly; // 0x2F
	internal SerObjectInfoCache cache; // 0x30
	internal string[] wireMemberNames; // 0x38
	internal Type[] wireMemberTypes; // 0x40
	private int lastPosition; // 0x48
	internal ISerializationSurrogate serializationSurrogate; // 0x50
	internal StreamingContext context; // 0x58
	internal List<Type> memberTypesList; // 0x68
	internal SerObjectInfoInit serObjectInfoInit; // 0x70
	internal IFormatterConverter formatterConverter; // 0x78

	// Methods

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	internal void .ctor() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	internal void ObjectEnd() { }

	// RVA: 0x1B551E0 Offset: 0x1B53BE0 VA: 0x181B551E0
	internal void PrepareForReuse() { }

	// RVA: 0x1B53770 Offset: 0x1B52170 VA: 0x181B53770
	internal static ReadObjectInfo Create(Type objectType, ISurrogateSelector surrogateSelector, StreamingContext context, ObjectManager objectManager, SerObjectInfoInit serObjectInfoInit, IFormatterConverter converter, bool bSimpleAssembly) { }

	// RVA: 0x1B54E10 Offset: 0x1B53810 VA: 0x181B54E10
	internal void Init(Type objectType, ISurrogateSelector surrogateSelector, StreamingContext context, ObjectManager objectManager, SerObjectInfoInit serObjectInfoInit, IFormatterConverter converter, bool bSimpleAssembly) { }

	// RVA: 0x1B538A0 Offset: 0x1B522A0 VA: 0x181B538A0
	internal static ReadObjectInfo Create(Type objectType, string[] memberNames, Type[] memberTypes, ISurrogateSelector surrogateSelector, StreamingContext context, ObjectManager objectManager, SerObjectInfoInit serObjectInfoInit, IFormatterConverter converter, bool bSimpleAssembly) { }

	// RVA: 0x1B54ED0 Offset: 0x1B538D0 VA: 0x181B54ED0
	internal void Init(Type objectType, string[] memberNames, Type[] memberTypes, ISurrogateSelector surrogateSelector, StreamingContext context, ObjectManager objectManager, SerObjectInfoInit serObjectInfoInit, IFormatterConverter converter, bool bSimpleAssembly) { }

	// RVA: 0x1B54B10 Offset: 0x1B53510 VA: 0x181B54B10
	private void InitReadConstructor(Type objectType, ISurrogateSelector surrogateSelector, StreamingContext context) { }

	// RVA: 0x1B54D90 Offset: 0x1B53790 VA: 0x181B54D90
	private void InitSiRead() { }

	// RVA: 0x1B54AA0 Offset: 0x1B534A0 VA: 0x181B54AA0
	private void InitNoMembers() { }

	// RVA: 0x1B547F0 Offset: 0x1B531F0 VA: 0x181B547F0
	private void InitMemberInfo() { }

	// RVA: 0x1B53A10 Offset: 0x1B52410 VA: 0x181B53A10
	internal MemberInfo GetMemberInfo(string name) { }

	// RVA: 0x1B54550 Offset: 0x1B52F50 VA: 0x181B54550
	internal Type GetType(string name) { }

	// RVA: 0x1B534E0 Offset: 0x1B51EE0 VA: 0x181B534E0
	internal void AddValue(string name, object value, ref SerializationInfo si, ref object[] memberData) { }

	// RVA: 0x1B546F0 Offset: 0x1B530F0 VA: 0x181B546F0
	internal void InitDataStore(ref SerializationInfo si, ref object[] memberData) { }

	// RVA: 0x1B551F0 Offset: 0x1B53BF0 VA: 0x181B551F0
	internal void RecordFixup(long objectId, string name, long idRef) { }

	// RVA: 0x1B54FE0 Offset: 0x1B539E0 VA: 0x181B54FE0
	internal void PopulateObjectMembers(object obj, object[] memberData) { }

	// RVA: 0x1B55070 Offset: 0x1B53A70 VA: 0x181B55070
	private int Position(string name) { }

	// RVA: 0x1B53E60 Offset: 0x1B52860 VA: 0x181B53E60
	internal Type[] GetMemberTypes(string[] inMemberNames, Type objectType) { }

	// RVA: 0x1B53C80 Offset: 0x1B52680 VA: 0x181B53C80
	internal Type GetMemberType(MemberInfo objMember) { }

	// RVA: 0x1B544E0 Offset: 0x1B52EE0 VA: 0x181B544E0
	private static ReadObjectInfo GetObjectInfo(SerObjectInfoInit serObjectInfoInit) { }
}

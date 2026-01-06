internal sealed class WriteObjectInfo // TypeDefIndex: 4495
{
	// Fields
	internal int objectInfoId; // 0x10
	internal object obj; // 0x18
	internal Type objectType; // 0x20
	internal bool isSi; // 0x28
	internal bool isNamed; // 0x29
	internal bool isTyped; // 0x2A
	internal bool isArray; // 0x2B
	internal SerializationInfo si; // 0x30
	internal SerObjectInfoCache cache; // 0x38
	internal object[] memberData; // 0x40
	internal ISerializationSurrogate serializationSurrogate; // 0x48
	internal StreamingContext context; // 0x50
	internal SerObjectInfoInit serObjectInfoInit; // 0x60
	internal long objectId; // 0x68
	internal long assemId; // 0x70
	private string binderTypeName; // 0x78
	private string binderAssemblyString; // 0x80

	// Methods

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	internal void .ctor() { }

	// RVA: 0x1B5B3F0 Offset: 0x1B59DF0 VA: 0x181B5B3F0
	internal void ObjectEnd() { }

	// RVA: 0x1B5B310 Offset: 0x1B59D10 VA: 0x181B5B310
	private void InternalInit() { }

	// RVA: 0x1B5B4F0 Offset: 0x1B59EF0 VA: 0x181B5B4F0
	internal static WriteObjectInfo Serialize(object obj, ISurrogateSelector surrogateSelector, StreamingContext context, SerObjectInfoInit serObjectInfoInit, IFormatterConverter converter, ObjectWriter objectWriter, SerializationBinder binder) { }

	// RVA: 0x1B5A6E0 Offset: 0x1B590E0 VA: 0x181B5A6E0
	internal void InitSerialize(object obj, ISurrogateSelector surrogateSelector, StreamingContext context, SerObjectInfoInit serObjectInfoInit, IFormatterConverter converter, ObjectWriter objectWriter, SerializationBinder binder) { }

	// RVA: 0x1B5B450 Offset: 0x1B59E50 VA: 0x181B5B450
	internal static WriteObjectInfo Serialize(Type objectType, ISurrogateSelector surrogateSelector, StreamingContext context, SerObjectInfoInit serObjectInfoInit, IFormatterConverter converter, SerializationBinder binder) { }

	// RVA: 0x1B5A0D0 Offset: 0x1B58AD0 VA: 0x181B5A0D0
	internal void InitSerialize(Type objectType, ISurrogateSelector surrogateSelector, StreamingContext context, SerObjectInfoInit serObjectInfoInit, IFormatterConverter converter, SerializationBinder binder) { }

	// RVA: 0x1B5AF80 Offset: 0x1B59980 VA: 0x181B5AF80
	private void InitSiWrite() { }

	// RVA: 0x1B59590 Offset: 0x1B57F90 VA: 0x181B59590
	private static void CheckTypeForwardedFrom(SerObjectInfoCache cache, Type objectType, string binderAssemblyString) { }

	// RVA: 0x1B59F80 Offset: 0x1B58980 VA: 0x181B59F80
	private void InitNoMembers() { }

	// RVA: 0x1B59B90 Offset: 0x1B58590 VA: 0x181B59B90
	private void InitMemberInfo() { }

	// RVA: 0x1B59B60 Offset: 0x1B58560 VA: 0x181B59B60
	internal string GetTypeFullName() { }

	// RVA: 0x1B59710 Offset: 0x1B58110 VA: 0x181B59710
	internal string GetAssemblyString() { }

	// RVA: 0x1B5B3B0 Offset: 0x1B59DB0 VA: 0x181B5B3B0
	private void InvokeSerializationBinder(SerializationBinder binder) { }

	// RVA: 0x1B59820 Offset: 0x1B58220 VA: 0x181B59820
	internal Type GetMemberType(MemberInfo objMember) { }

	// RVA: 0x1B59740 Offset: 0x1B58140 VA: 0x181B59740
	internal void GetMemberInfo(out string[] outMemberNames, out Type[] outMemberTypes, out object[] outMemberData) { }

	// RVA: 0x1B59A00 Offset: 0x1B58400 VA: 0x181B59A00
	private static WriteObjectInfo GetObjectInfo(SerObjectInfoInit serObjectInfoInit) { }

	// RVA: 0x1B5B420 Offset: 0x1B59E20 VA: 0x181B5B420
	private static void PutObjectInfo(SerObjectInfoInit serObjectInfoInit, WriteObjectInfo objectInfo) { }
}

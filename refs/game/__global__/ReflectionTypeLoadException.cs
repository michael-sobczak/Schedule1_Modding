public sealed class ReflectionTypeLoadException : SystemException, ISerializable // TypeDefIndex: 4721
{
	// Fields
	[CompilerGenerated]
	private readonly Type[] <Types>k__BackingField; // 0x90
	[CompilerGenerated]
	private readonly Exception[] <LoaderExceptions>k__BackingField; // 0x98

	// Properties
	public Type[] Types { get; }
	public Exception[] LoaderExceptions { get; }
	public override string Message { get; }

	// Methods

	// RVA: 0x1B8F5C0 Offset: 0x1B8DFC0 VA: 0x181B8F5C0
	public void .ctor(Type[] classes, Exception[] exceptions) { }

	// RVA: 0x1B8F480 Offset: 0x1B8DE80 VA: 0x181B8F480
	private void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1B8F350 Offset: 0x1B8DD50 VA: 0x181B8F350 Slot: 14
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	[CompilerGenerated]
	// RVA: 0x614480 Offset: 0x612E80 VA: 0x180614480
	public Type[] get_Types() { }

	[CompilerGenerated]
	// RVA: 0xAA7250 Offset: 0xAA5C50 VA: 0x180AA7250
	public Exception[] get_LoaderExceptions() { }

	// RVA: 0x1B8F630 Offset: 0x1B8E030 VA: 0x181B8F630 Slot: 5
	public override string get_Message() { }

	// RVA: 0x1B8F470 Offset: 0x1B8DE70 VA: 0x181B8F470 Slot: 3
	public override string ToString() { }

	// RVA: 0x1B8F1F0 Offset: 0x1B8DBF0 VA: 0x181B8F1F0
	private string CreateString(bool isMessage) { }
}

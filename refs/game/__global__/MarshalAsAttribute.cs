public sealed class MarshalAsAttribute : Attribute // TypeDefIndex: 4563
{
	// Fields
	public string MarshalCookie; // 0x10
	[ComVisible(True)]
	public string MarshalType; // 0x18
	[ComVisible(True)]
	public Type MarshalTypeRef; // 0x20
	public Type SafeArrayUserDefinedSubType; // 0x28
	private UnmanagedType utype; // 0x30
	public UnmanagedType ArraySubType; // 0x34
	public VarEnum SafeArraySubType; // 0x38
	public int SizeConst; // 0x3C
	public int IidParameterIndex; // 0x40
	public short SizeParamIndex; // 0x44

	// Properties
	public UnmanagedType Value { get; }

	// Methods

	// RVA: 0x1B65490 Offset: 0x1B63E90 VA: 0x181B65490
	public void .ctor(UnmanagedType unmanagedType) { }

	// RVA: 0x4A7D90 Offset: 0x4A6790 VA: 0x1804A7D90
	public UnmanagedType get_Value() { }

	// RVA: 0x1B65430 Offset: 0x1B63E30 VA: 0x181B65430
	internal MarshalAsAttribute Copy() { }
}

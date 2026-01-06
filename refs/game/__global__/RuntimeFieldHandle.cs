public struct RuntimeFieldHandle : ISerializable // TypeDefIndex: 3870
{
	// Fields
	private IntPtr value; // 0x0

	// Properties
	public IntPtr Value { get; }

	// Methods

	// RVA: 0xC7C0C0 Offset: 0xC7AAC0 VA: 0x180C7C0C0
	internal void .ctor(IntPtr v) { }

	// RVA: 0x1CC77A0 Offset: 0x1CC61A0 VA: 0x181CC77A0
	private void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x43C7F0 Offset: 0x43B1F0 VA: 0x18043C7F0
	public IntPtr get_Value() { }

	// RVA: 0x1CC75E0 Offset: 0x1CC5FE0 VA: 0x181CC75E0 Slot: 4
	public void GetObjectData(SerializationInfo info, StreamingContext context) { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x1CC74F0 Offset: 0x1CC5EF0 VA: 0x181CC74F0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x4C2CC0 Offset: 0x4C16C0 VA: 0x1804C2CC0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1CC7790 Offset: 0x1CC6190 VA: 0x181CC7790
	private static void SetValueInternal(FieldInfo fi, object obj, object value) { }

	// RVA: 0x1CC7790 Offset: 0x1CC6190 VA: 0x181CC7790
	internal static void SetValue(RuntimeFieldInfo field, object obj, object value, RuntimeType fieldType, FieldAttributes fieldAttr, RuntimeType declaringType, ref bool domainInitialized) { }

	// RVA: 0x1CC7780 Offset: 0x1CC6180 VA: 0x181CC7780
	internal static void SetValueDirect(RuntimeFieldInfo field, RuntimeType fieldType, void* pTypedRef, object value, RuntimeType contextType) { }
}

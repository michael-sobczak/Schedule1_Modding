public struct RuntimeMethodHandle : ISerializable // TypeDefIndex: 3871
{
	// Fields
	private IntPtr value; // 0x0

	// Properties
	public IntPtr Value { get; }

	// Methods

	// RVA: 0xC7C0C0 Offset: 0xC7AAC0 VA: 0x180C7C0C0
	internal void .ctor(IntPtr v) { }

	// RVA: 0x1CC7D30 Offset: 0x1CC6730 VA: 0x181CC7D30
	private void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x43C7F0 Offset: 0x43B1F0 VA: 0x18043C7F0
	public IntPtr get_Value() { }

	// RVA: 0x1CC7B90 Offset: 0x1CC6590 VA: 0x181CC7B90 Slot: 4
	public void GetObjectData(SerializationInfo info, StreamingContext context) { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x1CC7AA0 Offset: 0x1CC64A0 VA: 0x181CC7AA0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x4C2CC0 Offset: 0x4C16C0 VA: 0x1804C2CC0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1CC7940 Offset: 0x1CC6340 VA: 0x181CC7940
	internal static string ConstructInstantiation(RuntimeMethodInfo method, TypeNameFormatFlags format) { }

	// RVA: 0xC246A0 Offset: 0xC230A0 VA: 0x180C246A0
	internal bool IsNullHandle() { }
}

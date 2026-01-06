public struct IntPtr : ISerializable, IEquatable<IntPtr> // TypeDefIndex: 3857
{
	// Fields
	private readonly void* m_value; // 0x0
	public static readonly IntPtr Zero; // 0x0

	// Properties
	public static int Size { get; }

	// Methods

	[ReliabilityContract(2, 1)]
	// RVA: 0x1CC0FA0 Offset: 0x1CBF9A0 VA: 0x181CC0FA0
	public void .ctor(int value) { }

	[ReliabilityContract(2, 1)]
	// RVA: 0xC7C0C0 Offset: 0xC7AAC0 VA: 0x180C7C0C0
	public void .ctor(long value) { }

	[ReliabilityContract(2, 1)]
	[CLSCompliant(False)]
	// RVA: 0xC7C0C0 Offset: 0xC7AAC0 VA: 0x180C7C0C0
	public void .ctor(void* value) { }

	// RVA: 0x1CC0FB0 Offset: 0x1CBF9B0 VA: 0x181CC0FB0
	private void .ctor(SerializationInfo info, StreamingContext context) { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x6AA790 Offset: 0x6A9190 VA: 0x1806AA790
	public static int get_Size() { }

	// RVA: 0x1CC0EA0 Offset: 0x1CBF8A0 VA: 0x181CC0EA0 Slot: 4
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1CC0E10 Offset: 0x1CBF810 VA: 0x181CC0E10 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x4C2CC0 Offset: 0x4C16C0 VA: 0x1804C2CC0 Slot: 2
	public override int GetHashCode() { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x4C2CC0 Offset: 0x4C16C0 VA: 0x1804C2CC0
	public int ToInt32() { }

	[ReliabilityContract(3, 2)]
	// RVA: 0xF098E0 Offset: 0xF082E0 VA: 0x180F098E0
	public long ToInt64() { }

	[ReliabilityContract(3, 2)]
	[CLSCompliant(False)]
	// RVA: 0x43C7F0 Offset: 0x43B1F0 VA: 0x18043C7F0
	public void* ToPointer() { }

	// RVA: 0x1CC0F70 Offset: 0x1CBF970 VA: 0x181CC0F70 Slot: 3
	public override string ToString() { }

	// RVA: 0x1CC0F40 Offset: 0x1CBF940 VA: 0x181CC0F40
	public string ToString(string format) { }

	[ReliabilityContract(3, 2)]
	// RVA: 0xC7C1F0 Offset: 0xC7ABF0 VA: 0x180C7C1F0
	public static bool op_Equality(IntPtr value1, IntPtr value2) { }

	[ReliabilityContract(3, 2)]
	// RVA: 0xC7C200 Offset: 0xC7AC00 VA: 0x180C7C200
	public static bool op_Inequality(IntPtr value1, IntPtr value2) { }

	[ReliabilityContract(2, 1)]
	// RVA: 0x1BC70D0 Offset: 0x1BC5AD0 VA: 0x181BC70D0
	public static IntPtr op_Explicit(int value) { }

	[ReliabilityContract(2, 1)]
	// RVA: 0xBB7DD0 Offset: 0xBB67D0 VA: 0x180BB7DD0
	public static IntPtr op_Explicit(long value) { }

	[CLSCompliant(False)]
	[ReliabilityContract(2, 1)]
	// RVA: 0xBB7DD0 Offset: 0xBB67D0 VA: 0x180BB7DD0
	public static IntPtr op_Explicit(void* value) { }

	// RVA: 0xB0B4C0 Offset: 0xB09EC0 VA: 0x180B0B4C0
	public static int op_Explicit(IntPtr value) { }

	// RVA: 0x1CC1010 Offset: 0x1CBFA10 VA: 0x181CC1010
	public static long op_Explicit(IntPtr value) { }

	[CLSCompliant(False)]
	// RVA: 0xBB7DD0 Offset: 0xBB67D0 VA: 0x180BB7DD0
	public static void* op_Explicit(IntPtr value) { }

	[ReliabilityContract(2, 1)]
	// RVA: 0xF6C650 Offset: 0xF6B050 VA: 0x180F6C650
	public static IntPtr Add(IntPtr pointer, int offset) { }

	[ReliabilityContract(2, 1)]
	// RVA: 0xF6C650 Offset: 0xF6B050 VA: 0x180F6C650
	public static IntPtr op_Addition(IntPtr pointer, int offset) { }

	[ReliabilityContract(2, 1)]
	// RVA: 0x1CC1020 Offset: 0x1CBFA20 VA: 0x181CC1020
	public static IntPtr op_Subtraction(IntPtr pointer, int offset) { }

	[ReliabilityContract(3, 2)]
	// RVA: 0xC246A0 Offset: 0xC230A0 VA: 0x180C246A0
	internal bool IsNull() { }

	// RVA: 0xC7BDF0 Offset: 0xC7A7F0 VA: 0x180C7BDF0 Slot: 5
	private bool System.IEquatable<System.IntPtr>.Equals(IntPtr other) { }
}

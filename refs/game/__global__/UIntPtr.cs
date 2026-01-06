public struct UIntPtr : ISerializable, IEquatable<UIntPtr> // TypeDefIndex: 3892
{
	// Fields
	public static readonly UIntPtr Zero; // 0x0
	private readonly void* _pointer; // 0x0

	// Properties
	public static int Size { get; }

	// Methods

	// RVA: 0x1CEA630 Offset: 0x1CE9030 VA: 0x181CEA630
	public void .ctor(ulong value) { }

	// RVA: 0x1CEA620 Offset: 0x1CE9020 VA: 0x181CEA620
	public void .ctor(uint value) { }

	[CLSCompliant(False)]
	// RVA: 0xC7C0C0 Offset: 0xC7AAC0 VA: 0x180C7C0C0
	public void .ctor(void* value) { }

	// RVA: 0x1CEA490 Offset: 0x1CE8E90 VA: 0x181CEA490 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x4C2CC0 Offset: 0x4C16C0 VA: 0x1804C2CC0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1CEA5C0 Offset: 0x1CE8FC0 VA: 0x181CEA5C0 Slot: 3
	public override string ToString() { }

	// RVA: 0x1CEA520 Offset: 0x1CE8F20 VA: 0x181CEA520 Slot: 4
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xC7C1F0 Offset: 0xC7ABF0 VA: 0x180C7C1F0
	public static bool op_Equality(UIntPtr value1, UIntPtr value2) { }

	// RVA: 0xC7C200 Offset: 0xC7AC00 VA: 0x180C7C200
	public static bool op_Inequality(UIntPtr value1, UIntPtr value2) { }

	// RVA: 0xBB7DD0 Offset: 0xBB67D0 VA: 0x180BB7DD0
	public static ulong op_Explicit(UIntPtr value) { }

	// RVA: 0x1CC1010 Offset: 0x1CBFA10 VA: 0x181CC1010
	public static UIntPtr op_Explicit(ulong value) { }

	// RVA: 0xB0B4C0 Offset: 0xB09EC0 VA: 0x180B0B4C0
	public static UIntPtr op_Explicit(uint value) { }

	// RVA: 0x6AA790 Offset: 0x6A9190 VA: 0x1806AA790
	public static int get_Size() { }

	// RVA: 0xC7BDF0 Offset: 0xC7A7F0 VA: 0x180C7BDF0 Slot: 5
	private bool System.IEquatable<System.UIntPtr>.Equals(UIntPtr other) { }

	// RVA: 0x1CEA5E0 Offset: 0x1CE8FE0 VA: 0x181CEA5E0
	private static void .cctor() { }
}

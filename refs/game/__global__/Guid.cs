public struct Guid // TypeDefIndex: 13409
{
	// Fields
	private const string hex = "0123456789ABCDEF";
	public static readonly Guid zero; // 0x0
	public static readonly string zeroString; // 0x10
	private readonly ulong _a; // 0x0
	private readonly ulong _b; // 0x8
	private static Random random; // 0x18
	private static StringBuilder text; // 0x20

	// Methods

	// RVA: 0xBBE900 Offset: 0xBBD300 VA: 0x180BBE900
	public void .ctor(byte[] bytes) { }

	// RVA: 0xBBE560 Offset: 0xBBCF60 VA: 0x180BBE560
	public void .ctor(string str) { }

	// RVA: 0xBBE070 Offset: 0xBBCA70 VA: 0x180BBE070
	public static Guid Parse(string input) { }

	// RVA: 0xBBE090 Offset: 0xBBCA90 VA: 0x180BBE090
	private static ulong SwapEndianness(ulong value) { }

	// RVA: 0xBBE0A0 Offset: 0xBBCAA0 VA: 0x180BBE0A0
	public byte[] ToByteArray() { }

	// RVA: 0xBBDFB0 Offset: 0xBBC9B0 VA: 0x180BBDFB0
	public static Guid NewGuid() { }

	// RVA: 0xBBEA90 Offset: 0xBBD490 VA: 0x180BBEA90
	public static bool op_Equality(Guid lhs, Guid rhs) { }

	// RVA: 0xBBEAB0 Offset: 0xBBD4B0 VA: 0x180BBEAB0
	public static bool op_Inequality(Guid lhs, Guid rhs) { }

	// RVA: 0xBBDF00 Offset: 0xBBC900 VA: 0x180BBDF00 Slot: 0
	public override bool Equals(object _rhs) { }

	// RVA: 0xBBDF90 Offset: 0xBBC990 VA: 0x180BBDF90 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0xBBE180 Offset: 0xBBCB80 VA: 0x180BBE180 Slot: 3
	public override string ToString() { }

	// RVA: 0xBBE430 Offset: 0xBBCE30 VA: 0x180BBE430
	private static void .cctor() { }
}

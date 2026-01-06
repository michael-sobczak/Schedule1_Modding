internal struct NativeAddr : IEquatable<NativeAddr> // TypeDefIndex: 12381
{
	// Fields
	private readonly long _part1; // 0x0
	private readonly long _part2; // 0x8
	private readonly long _part3; // 0x10
	private readonly int _part4; // 0x18
	private readonly int _hash; // 0x1C

	// Methods

	// RVA: 0xCF3FA0 Offset: 0xCF29A0 VA: 0x180CF3FA0
	public void .ctor(byte[] address, int len) { }

	// RVA: 0x4A1F70 Offset: 0x4A0970 VA: 0x1804A1F70 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0xCF3EB0 Offset: 0xCF28B0 VA: 0x180CF3EB0 Slot: 4
	public bool Equals(NativeAddr other) { }

	// RVA: 0xCF3EF0 Offset: 0xCF28F0 VA: 0x180CF3EF0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0xCF3EB0 Offset: 0xCF28B0 VA: 0x180CF3EB0
	public static bool op_Equality(NativeAddr left, NativeAddr right) { }

	// RVA: 0xCF4050 Offset: 0xCF2A50 VA: 0x180CF4050
	public static bool op_Inequality(NativeAddr left, NativeAddr right) { }
}

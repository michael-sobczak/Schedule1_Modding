internal static class Marvin // TypeDefIndex: 3683
{
	// Fields
	[CompilerGenerated]
	private static readonly ulong <DefaultSeed>k__BackingField; // 0x0

	// Properties
	public static ulong DefaultSeed { get; }

	// Methods

	// RVA: 0x1C67AA0 Offset: 0x1C664A0 VA: 0x181C67AA0
	public static int ComputeHash32(ReadOnlySpan<byte> data, ulong seed) { }

	// RVA: 0x1C67B40 Offset: 0x1C66540 VA: 0x181C67B40
	public static int ComputeHash32(ref byte data, int count, ulong seed) { }

	// RVA: 0x1C67A00 Offset: 0x1C66400 VA: 0x181C67A00
	private static void Block(ref uint rp0, ref uint rp1) { }

	// RVA: 0x1C63F50 Offset: 0x1C62950 VA: 0x181C63F50
	private static uint _rotl(uint value, int shift) { }

	[CompilerGenerated]
	// RVA: 0x1C68060 Offset: 0x1C66A60 VA: 0x181C68060
	public static ulong get_DefaultSeed() { }

	// RVA: 0x1C68010 Offset: 0x1C66A10 VA: 0x181C68010
	private static ulong GenerateSeed() { }

	// RVA: 0x1C68020 Offset: 0x1C66A20 VA: 0x181C68020
	private static void .cctor() { }
}

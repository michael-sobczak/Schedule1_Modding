internal sealed class StaticTree // TypeDefIndex: 16671
{
	// Fields
	internal static readonly short[] lengthAndLiteralsTreeCodes; // 0x0
	internal static readonly short[] distTreeCodes; // 0x8
	internal static readonly StaticTree Literals; // 0x10
	internal static readonly StaticTree Distances; // 0x18
	internal static readonly StaticTree BitLengths; // 0x20
	internal short[] treeCodes; // 0x10
	internal int[] extraBits; // 0x18
	internal int extraBase; // 0x20
	internal int elems; // 0x24
	internal int maxLength; // 0x28

	// Methods

	// RVA: 0x1E75670 Offset: 0x1E74070 VA: 0x181E75670
	private void .ctor(short[] treeCodes, int[] extraBits, int extraBase, int elems, int maxLength) { }

	// RVA: 0x1E75330 Offset: 0x1E73D30 VA: 0x181E75330
	private static void .cctor() { }
}

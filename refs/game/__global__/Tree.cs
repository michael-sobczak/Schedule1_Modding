internal sealed class Tree // TypeDefIndex: 16663
{
	// Fields
	internal const int Buf_size = 16;
	private static readonly int HEAP_SIZE; // 0x0
	internal static readonly int[] ExtraLengthBits; // 0x8
	internal static readonly int[] ExtraDistanceBits; // 0x10
	internal static readonly int[] extra_blbits; // 0x18
	internal static readonly sbyte[] bl_order; // 0x20
	private static readonly sbyte[] _dist_code; // 0x28
	internal static readonly sbyte[] LengthCode; // 0x30
	internal static readonly int[] LengthBase; // 0x38
	internal static readonly int[] DistanceBase; // 0x40
	internal short[] dyn_tree; // 0x10
	internal int max_code; // 0x18
	internal StaticTree staticTree; // 0x20

	// Methods

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }

	// RVA: 0x1E757B0 Offset: 0x1E741B0 VA: 0x181E757B0
	private static void .cctor() { }

	// RVA: 0x1E756E0 Offset: 0x1E740E0 VA: 0x181E756E0
	internal static int DistanceCode(int dist) { }

	// RVA: 0x1E760E0 Offset: 0x1E74AE0 VA: 0x181E760E0
	internal void gen_bitlen(DeflateManager s) { }

	// RVA: 0x1E75B50 Offset: 0x1E74550 VA: 0x181E75B50
	internal void build_tree(DeflateManager s) { }

	// RVA: 0x1E76570 Offset: 0x1E74F70 VA: 0x181E76570
	internal static void gen_codes(short[] tree, int max_code, short[] bl_count) { }

	// RVA: 0x1E75B30 Offset: 0x1E74530 VA: 0x181E75B30
	internal static int bi_reverse(int code, int len) { }
}

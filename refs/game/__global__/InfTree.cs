internal sealed class InfTree // TypeDefIndex: 16653
{
	// Fields
	private const int MANY = 1440;
	private const int Z_OK = 0;
	private const int Z_STREAM_END = 1;
	private const int Z_NEED_DICT = 2;
	private const int Z_ERRNO = -1;
	private const int Z_STREAM_ERROR = -2;
	private const int Z_DATA_ERROR = -3;
	private const int Z_MEM_ERROR = -4;
	private const int Z_BUF_ERROR = -5;
	private const int Z_VERSION_ERROR = -6;
	internal const int fixed_bl = 9;
	internal const int fixed_bd = 5;
	internal const int BMAX = 15;
	internal static readonly int[] fixed_tl; // 0x0
	internal static readonly int[] fixed_td; // 0x8
	internal static readonly int[] cplens; // 0x10
	internal static readonly int[] cplext; // 0x18
	internal static readonly int[] cpdist; // 0x20
	internal static readonly int[] cpdext; // 0x28
	internal int[] hn; // 0x10
	internal int[] v; // 0x18
	internal int[] c; // 0x20
	internal int[] r; // 0x28
	internal int[] u; // 0x30
	internal int[] x; // 0x38

	// Methods

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }

	// RVA: 0x1E6A000 Offset: 0x1E68A00 VA: 0x181E6A000
	private static void .cctor() { }

	// RVA: 0x1E6A270 Offset: 0x1E68C70 VA: 0x181E6A270
	private int huft_build(int[] b, int bindex, int n, int s, int[] d, int[] e, int[] t, int[] m, int[] hp, int[] hn, int[] v) { }

	// RVA: 0x1E6ACA0 Offset: 0x1E696A0 VA: 0x181E6ACA0
	internal int inflate_trees_bits(int[] c, int[] bb, int[] tb, int[] hp, ZlibCodec z) { }

	// RVA: 0x1E6AE00 Offset: 0x1E69800 VA: 0x181E6AE00
	internal int inflate_trees_dynamic(int nl, int nd, int[] c, int[] bl, int[] bd, int[] tl, int[] td, int[] hp, ZlibCodec z) { }

	// RVA: 0x1E6B170 Offset: 0x1E69B70 VA: 0x181E6B170
	internal static int inflate_trees_fixed(int[] bl, int[] bd, int[][] tl, int[][] td, ZlibCodec z) { }

	// RVA: 0x1E6B270 Offset: 0x1E69C70 VA: 0x181E6B270
	private void initWorkArea(int vsize) { }
}

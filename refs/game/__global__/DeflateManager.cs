internal sealed class DeflateManager // TypeDefIndex: 16650
{
	// Fields
	private static readonly int MEM_LEVEL_MAX; // 0x0
	private static readonly int MEM_LEVEL_DEFAULT; // 0x4
	private DeflateManager.CompressFunc DeflateFunction; // 0x10
	private static readonly string[] _ErrorMessage; // 0x8
	private static readonly int PRESET_DICT; // 0x10
	private static readonly int INIT_STATE; // 0x14
	private static readonly int BUSY_STATE; // 0x18
	private static readonly int FINISH_STATE; // 0x1C
	private static readonly int Z_DEFLATED; // 0x20
	private static readonly int STORED_BLOCK; // 0x24
	private static readonly int STATIC_TREES; // 0x28
	private static readonly int DYN_TREES; // 0x2C
	private static readonly int Z_BINARY; // 0x30
	private static readonly int Z_ASCII; // 0x34
	private static readonly int Z_UNKNOWN; // 0x38
	private static readonly int Buf_size; // 0x3C
	private static readonly int MIN_MATCH; // 0x40
	private static readonly int MAX_MATCH; // 0x44
	private static readonly int MIN_LOOKAHEAD; // 0x48
	private static readonly int HEAP_SIZE; // 0x4C
	private static readonly int END_BLOCK; // 0x50
	internal ZlibCodec _codec; // 0x18
	internal int status; // 0x20
	internal byte[] pending; // 0x28
	internal int nextPending; // 0x30
	internal int pendingCount; // 0x34
	internal sbyte data_type; // 0x38
	internal int last_flush; // 0x3C
	internal int w_size; // 0x40
	internal int w_bits; // 0x44
	internal int w_mask; // 0x48
	internal byte[] window; // 0x50
	internal int window_size; // 0x58
	internal short[] prev; // 0x60
	internal short[] head; // 0x68
	internal int ins_h; // 0x70
	internal int hash_size; // 0x74
	internal int hash_bits; // 0x78
	internal int hash_mask; // 0x7C
	internal int hash_shift; // 0x80
	internal int block_start; // 0x84
	private DeflateManager.Config config; // 0x88
	internal int match_length; // 0x90
	internal int prev_match; // 0x94
	internal int match_available; // 0x98
	internal int strstart; // 0x9C
	internal int match_start; // 0xA0
	internal int lookahead; // 0xA4
	internal int prev_length; // 0xA8
	internal CompressionLevel compressionLevel; // 0xAC
	internal CompressionStrategy compressionStrategy; // 0xB0
	internal short[] dyn_ltree; // 0xB8
	internal short[] dyn_dtree; // 0xC0
	internal short[] bl_tree; // 0xC8
	internal Tree treeLiterals; // 0xD0
	internal Tree treeDistances; // 0xD8
	internal Tree treeBitLengths; // 0xE0
	internal short[] bl_count; // 0xE8
	internal int[] heap; // 0xF0
	internal int heap_len; // 0xF8
	internal int heap_max; // 0xFC
	internal sbyte[] depth; // 0x100
	internal int _lengthOffset; // 0x108
	internal int lit_bufsize; // 0x10C
	internal int last_lit; // 0x110
	internal int _distanceOffset; // 0x114
	internal int opt_len; // 0x118
	internal int static_len; // 0x11C
	internal int matches; // 0x120
	internal int last_eob_len; // 0x124
	internal short bi_buf; // 0x128
	internal int bi_valid; // 0x12C
	private bool Rfc1950BytesEmitted; // 0x130
	private bool _WantRfc1950HeaderBytes; // 0x131

	// Properties
	internal bool WantRfc1950HeaderBytes { get; set; }

	// Methods

	// RVA: 0x1E64ED0 Offset: 0x1E638D0 VA: 0x181E64ED0
	internal void .ctor() { }

	// RVA: 0x1E64AD0 Offset: 0x1E634D0 VA: 0x181E64AD0
	private static void .cctor() { }

	// RVA: 0x1E64790 Offset: 0x1E63190 VA: 0x181E64790
	private void _InitializeLazyMatch() { }

	// RVA: 0x1E648E0 Offset: 0x1E632E0 VA: 0x181E648E0
	private void _InitializeTreeData() { }

	// RVA: 0x1E64590 Offset: 0x1E62F90 VA: 0x181E64590
	internal void _InitializeBlocks() { }

	// RVA: 0x1E66990 Offset: 0x1E65390 VA: 0x181E66990
	internal void pqdownheap(short[] tree, int k) { }

	// RVA: 0x1E64A50 Offset: 0x1E63450 VA: 0x181E64A50
	internal static bool _IsSmaller(short[] tree, int n, int m, sbyte[] depth) { }

	// RVA: 0x1E66C50 Offset: 0x1E65650 VA: 0x181E66C50
	internal void scan_tree(short[] tree, int max_code) { }

	// RVA: 0x1E66170 Offset: 0x1E64B70 VA: 0x181E66170
	internal int build_bl_tree() { }

	// RVA: 0x1E66F00 Offset: 0x1E65900 VA: 0x181E66F00
	internal void send_all_trees(int lcodes, int dcodes, int blcodes) { }

	// RVA: 0x1E675F0 Offset: 0x1E65FF0 VA: 0x181E675F0
	internal void send_tree(short[] tree, int max_code) { }

	// RVA: 0x1E66C00 Offset: 0x1E65600 VA: 0x181E66C00
	private void put_bytes(byte[] p, int start, int len) { }

	// RVA: 0x1E671D0 Offset: 0x1E65BD0 VA: 0x181E671D0
	internal void send_code(int c, short[] tree) { }

	// RVA: 0x1E67070 Offset: 0x1E65A70 VA: 0x181E67070
	internal void send_bits(int value, int length) { }

	// RVA: 0x1E65430 Offset: 0x1E63E30 VA: 0x181E65430
	internal void _tr_align() { }

	// RVA: 0x1E65C80 Offset: 0x1E64680 VA: 0x181E65C80
	internal bool _tr_tally(int dist, int lc) { }

	// RVA: 0x1E67220 Offset: 0x1E65C20 VA: 0x181E67220
	internal void send_compressed_block(short[] ltree, short[] dtree) { }

	// RVA: 0x1E679A0 Offset: 0x1E663A0 VA: 0x181E679A0
	internal void set_data_type() { }

	// RVA: 0x1E65FC0 Offset: 0x1E649C0 VA: 0x181E65FC0
	internal void bi_flush() { }

	// RVA: 0x1E660A0 Offset: 0x1E64AA0 VA: 0x181E660A0
	internal void bi_windup() { }

	// RVA: 0x1E66300 Offset: 0x1E64D00 VA: 0x181E66300
	internal void copy_block(int buf, int len, bool header) { }

	// RVA: 0x1E66420 Offset: 0x1E64E20 VA: 0x181E66420
	internal void flush_block_only(bool eof) { }

	// RVA: 0x1E623B0 Offset: 0x1E60DB0 VA: 0x181E623B0
	internal BlockState DeflateNone(FlushType flush) { }

	// RVA: 0x1E65B00 Offset: 0x1E64500 VA: 0x181E65B00
	internal void _tr_stored_block(int buf, int stored_len, bool eof) { }

	// RVA: 0x1E65620 Offset: 0x1E64020 VA: 0x181E65620
	internal void _tr_flush_block(int buf, int stored_len, bool eof) { }

	// RVA: 0x1E65160 Offset: 0x1E63B60 VA: 0x181E65160
	private void _fillWindow() { }

	// RVA: 0x1E61DC0 Offset: 0x1E607C0 VA: 0x181E61DC0
	internal BlockState DeflateFast(FlushType flush) { }

	// RVA: 0x1E62650 Offset: 0x1E61050 VA: 0x181E62650
	internal BlockState DeflateSlow(FlushType flush) { }

	// RVA: 0x1E664A0 Offset: 0x1E64EA0 VA: 0x181E664A0
	internal int longest_match(int cur_match) { }

	// RVA: 0x1E66490 Offset: 0x1E64E90 VA: 0x181E66490
	internal bool get_WantRfc1950HeaderBytes() { }

	// RVA: 0x1E67990 Offset: 0x1E66390 VA: 0x181E67990
	internal void set_WantRfc1950HeaderBytes(bool value) { }

	// RVA: 0x1E63700 Offset: 0x1E62100 VA: 0x181E63700
	internal int Initialize(ZlibCodec codec, CompressionLevel level) { }

	// RVA: 0x1E63790 Offset: 0x1E62190 VA: 0x181E63790
	internal int Initialize(ZlibCodec codec, CompressionLevel level, int bits) { }

	// RVA: 0x1E63830 Offset: 0x1E62230 VA: 0x181E63830
	internal int Initialize(ZlibCodec codec, CompressionLevel level, int bits, CompressionStrategy compressionStrategy) { }

	// RVA: 0x1E638D0 Offset: 0x1E622D0 VA: 0x181E638D0
	internal int Initialize(ZlibCodec codec, CompressionLevel level, int windowBits, int memLevel, CompressionStrategy strategy) { }

	// RVA: 0x1E63BF0 Offset: 0x1E625F0 VA: 0x181E63BF0
	internal void Reset() { }

	// RVA: 0x1E635D0 Offset: 0x1E61FD0 VA: 0x181E635D0
	internal int End() { }

	// RVA: 0x1E63F90 Offset: 0x1E62990 VA: 0x181E63F90
	private void SetDeflater() { }

	// RVA: 0x1E64490 Offset: 0x1E62E90 VA: 0x181E64490
	internal int SetParams(CompressionLevel level, CompressionStrategy strategy) { }

	// RVA: 0x1E64170 Offset: 0x1E62B70 VA: 0x181E64170
	internal int SetDictionary(byte[] dictionary) { }

	// RVA: 0x1E62D70 Offset: 0x1E61770 VA: 0x181E62D70
	internal int Deflate(FlushType flush) { }
}

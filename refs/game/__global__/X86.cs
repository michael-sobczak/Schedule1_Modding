public static class X86 // TypeDefIndex: 16351
{
	// Properties
	public static X86.MXCSRBits MXCSR { get; set; }

	// Methods

	// RVA: 0x4944C0 Offset: 0x492EC0 VA: 0x1804944C0
	private static v128 GenericCSharpLoad(void* ptr) { }

	// RVA: 0x4944D0 Offset: 0x492ED0 VA: 0x1804944D0
	private static void GenericCSharpStore(void* ptr, v128 val) { }

	// RVA: 0x2712530 Offset: 0x2710F30 VA: 0x182712530
	private static sbyte Saturate_To_Int8(int val) { }

	// RVA: 0x2712570 Offset: 0x2710F70 VA: 0x182712570
	private static byte Saturate_To_UnsignedInt8(int val) { }

	// RVA: 0x2712510 Offset: 0x2710F10 VA: 0x182712510
	private static short Saturate_To_Int16(int val) { }

	// RVA: 0x2712550 Offset: 0x2710F50 VA: 0x182712550
	private static ushort Saturate_To_UnsignedInt16(int val) { }

	// RVA: 0x27124E0 Offset: 0x2710EE0 VA: 0x1827124E0
	private static bool IsNaN(uint v) { }

	// RVA: 0x27124F0 Offset: 0x2710EF0 VA: 0x1827124F0
	private static bool IsNaN(ulong v) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	private static void BurstIntrinsicSetCSRFromManaged(int _) { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770
	private static int BurstIntrinsicGetCSRFromManaged() { }

	// RVA: 0x1102840 Offset: 0x1101240 VA: 0x181102840
	internal static int getcsr_raw() { }

	// RVA: 0x9F93E0 Offset: 0x9F7DE0 VA: 0x1809F93E0
	internal static void setcsr_raw(int bits) { }

	[BurstCompile(CompileSynchronously = True)]
	// RVA: 0x9F93E0 Offset: 0x9F7DE0 VA: 0x1809F93E0
	private static void DoSetCSRTrampoline(int bits) { }

	[BurstCompile(CompileSynchronously = True)]
	// RVA: 0x1102840 Offset: 0x1101240 VA: 0x181102840
	private static int DoGetCSRTrampoline() { }

	[BurstTargetCpu(3)]
	// RVA: 0x1102840 Offset: 0x1101240 VA: 0x181102840
	public static X86.MXCSRBits get_MXCSR() { }

	[BurstTargetCpu(3)]
	// RVA: 0x9F93E0 Offset: 0x9F7DE0 VA: 0x1809F93E0
	public static void set_MXCSR(X86.MXCSRBits value) { }
}

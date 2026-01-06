internal class Normalization // TypeDefIndex: 4143
{
	// Fields
	private static byte* props; // 0x0
	private static int* mappedChars; // 0x8
	private static short* charMapIndex; // 0x10
	private static short* helperIndex; // 0x18
	private static ushort* mapIdxToComposite; // 0x20
	private static byte* combiningClass; // 0x28
	private static object forLock; // 0x30
	public static readonly bool isReady; // 0x38

	// Methods

	// RVA: 0x1AD3EA0 Offset: 0x1AD28A0 VA: 0x181AD3EA0
	private static uint PropValue(int cp) { }

	// RVA: 0x1AD2400 Offset: 0x1AD0E00 VA: 0x181AD2400
	private static int CharMapIdx(int cp) { }

	// RVA: 0x1AD3B20 Offset: 0x1AD2520 VA: 0x181AD3B20
	private static byte GetCombiningClass(int c) { }

	// RVA: 0x1AD3BD0 Offset: 0x1AD25D0 VA: 0x181AD3BD0
	private static int GetPrimaryCompositeFromMapIndex(int src) { }

	// RVA: 0x1AD3C80 Offset: 0x1AD2680 VA: 0x181AD3C80
	private static int GetPrimaryCompositeHelperIndex(int cp) { }

	// RVA: 0x1AD29F0 Offset: 0x1AD13F0 VA: 0x181AD29F0
	private static string Compose(string source, int checkType) { }

	// RVA: 0x1AD2690 Offset: 0x1AD1090 VA: 0x181AD2690
	private static StringBuilder Combine(string source, int start, int checkType) { }

	// RVA: 0x1AD27C0 Offset: 0x1AD11C0 VA: 0x181AD27C0
	private static void Combine(StringBuilder sb, int i, int checkType) { }

	// RVA: 0x1AD2490 Offset: 0x1AD0E90 VA: 0x181AD2490
	private static int CombineHangul(StringBuilder sb, string s, int current) { }

	// RVA: 0x1AD3670 Offset: 0x1AD2070 VA: 0x181AD3670
	private static int Fetch(StringBuilder sb, string s, int i) { }

	// RVA: 0x1AD4300 Offset: 0x1AD2D00 VA: 0x181AD4300
	private static int TryComposeWithPreviousStarter(StringBuilder sb, string s, int current) { }

	// RVA: 0x1AD4670 Offset: 0x1AD3070 VA: 0x181AD4670
	private static int TryCompose(int i, int starter, int candidate) { }

	// RVA: 0x1AD2DF0 Offset: 0x1AD17F0 VA: 0x181AD2DF0
	private static string Decompose(string source, int checkType) { }

	// RVA: 0x1AD3380 Offset: 0x1AD1D80 VA: 0x181AD3380
	private static void Decompose(string source, ref StringBuilder sb, int checkType) { }

	// RVA: 0x1AD4070 Offset: 0x1AD2A70 VA: 0x181AD4070
	private static void ReorderCanonical(string src, ref StringBuilder sb, int start) { }

	// RVA: 0x1AD2BE0 Offset: 0x1AD15E0 VA: 0x181AD2BE0
	private static void DecomposeChar(ref StringBuilder sb, ref int[] buf, string s, int i, int checkType, ref int start) { }

	// RVA: 0x1AD3F30 Offset: 0x1AD2930 VA: 0x181AD3F30
	public static NormalizationCheck QuickCheck(char c, int type) { }

	// RVA: 0x1AD36C0 Offset: 0x1AD20C0 VA: 0x181AD36C0
	private static int GetCanonicalHangul(int s, int[] buf, int bufIdx) { }

	// RVA: 0x1AD37E0 Offset: 0x1AD21E0 VA: 0x181AD37E0
	private static int GetCanonical(int c, int[] buf, int bufIdx, int checkType) { }

	// RVA: 0x1AD3D30 Offset: 0x1AD2730 VA: 0x181AD3D30
	public static string Normalize(string source, NormalizationForm normalizationForm) { }

	// RVA: 0x1AD3E00 Offset: 0x1AD2800 VA: 0x181AD3E00
	public static string Normalize(string source, int type) { }

	// RVA: 0x1AD4A30 Offset: 0x1AD3430 VA: 0x181AD4A30
	private static void load_normalization_resource(out IntPtr props, out IntPtr mappedChars, out IntPtr charMapIndex, out IntPtr helperIndex, out IntPtr mapIdxToComposite, out IntPtr combiningClass) { }

	// RVA: 0x1AD47E0 Offset: 0x1AD31E0 VA: 0x181AD47E0
	private static void .cctor() { }
}

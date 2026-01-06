public struct NumberedWords // TypeDefIndex: 15943
{
	// Fields
	private int Index; // 0x0
	private int Suffix; // 0x4
	private const int kPositiveNumericSuffixShift = 0;
	private const int kPositiveNumericSuffixBits = 29;
	private const int kMaxPositiveNumericSuffix = 536870911;
	private const int kPositiveNumericSuffixMask = 536870911;
	private const int kLeadingZeroesShift = 29;
	private const int kLeadingZeroesBits = 3;
	private const int kMaxLeadingZeroes = 7;
	private const int kLeadingZeroesMask = 7;

	// Properties
	private int LeadingZeroes { get; set; }
	private int PositiveNumericSuffix { get; set; }
	private bool HasPositiveNumericSuffix { get; }

	// Methods

	// RVA: 0x27394C0 Offset: 0x2737EC0 VA: 0x1827394C0
	private int get_LeadingZeroes() { }

	// RVA: 0x27394E0 Offset: 0x2737EE0 VA: 0x1827394E0
	private void set_LeadingZeroes(int value) { }

	// RVA: 0x27394D0 Offset: 0x2737ED0 VA: 0x1827394D0
	private int get_PositiveNumericSuffix() { }

	// RVA: 0x2739500 Offset: 0x2737F00 VA: 0x182739500
	private void set_PositiveNumericSuffix(int value) { }

	// RVA: 0x27394B0 Offset: 0x2737EB0 VA: 0x1827394B0
	private bool get_HasPositiveNumericSuffix() { }

	[NotBurstCompatible]
	// RVA: 0x27392C0 Offset: 0x2737CC0 VA: 0x1827392C0
	private string NewString(char c, int count) { }

	[NotBurstCompatible]
	// RVA: -1 Offset: -1
	public int ToFixedString<T>(ref T result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF186D0 Offset: 0xF170D0 VA: 0x180F186D0
	|-NumberedWords.ToFixedString<FixedString512Bytes>
	|
	|-RVA: 0xF18860 Offset: 0xF17260 VA: 0x180F18860
	|-NumberedWords.ToFixedString<__Il2CppFullySharedGenericType>
	*/

	[NotBurstCompatible]
	// RVA: 0x2739440 Offset: 0x2737E40 VA: 0x182739440 Slot: 3
	public override string ToString() { }

	// RVA: 0x27392B0 Offset: 0x2737CB0 VA: 0x1827392B0
	private bool IsDigit(byte b) { }

	[NotBurstCompatible]
	// RVA: -1 Offset: -1
	public void SetString<T>(ref T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF17D10 Offset: 0xF16710 VA: 0x180F17D10
	|-NumberedWords.SetString<FixedString512Bytes>
	|
	|-RVA: 0xF17F10 Offset: 0xF16910 VA: 0x180F17F10
	|-NumberedWords.SetString<__Il2CppFullySharedGenericType>
	*/

	[NotBurstCompatible]
	// RVA: 0x2739360 Offset: 0x2737D60 VA: 0x182739360
	public void SetString(string value) { }
}

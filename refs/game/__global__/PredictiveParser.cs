internal struct PredictiveParser // TypeDefIndex: 7840
{
	// Fields
	private int m_Position; // 0x0

	// Methods

	// RVA: 0x2790860 Offset: 0x278F260 VA: 0x182790860
	public void ExpectSingleChar(ReadOnlySpan<char> str, char c) { }

	// RVA: 0x2790710 Offset: 0x278F110 VA: 0x182790710
	public int ExpectInt(ReadOnlySpan<char> str) { }

	// RVA: 0x2790970 Offset: 0x278F370 VA: 0x182790970
	public ReadOnlySpan<char> ExpectString(ReadOnlySpan<char> str) { }

	// RVA: 0x2790560 Offset: 0x278EF60 VA: 0x182790560
	public bool AcceptSingleChar(ReadOnlySpan<char> str, char c) { }

	// RVA: 0x27905A0 Offset: 0x278EFA0 VA: 0x1827905A0
	public bool AcceptString(ReadOnlySpan<char> input, out ReadOnlySpan<char> output) { }

	// RVA: 0x2790500 Offset: 0x278EF00 VA: 0x182790500
	public void AcceptInt(ReadOnlySpan<char> str) { }
}

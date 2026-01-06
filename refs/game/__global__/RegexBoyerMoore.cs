internal sealed class RegexBoyerMoore // TypeDefIndex: 9555
{
	// Fields
	public readonly int[] Positive; // 0x10
	public readonly int[] NegativeASCII; // 0x18
	public readonly int[][] NegativeUnicode; // 0x20
	public readonly string Pattern; // 0x28
	public readonly int LowASCII; // 0x30
	public readonly int HighASCII; // 0x34
	public readonly bool RightToLeft; // 0x38
	public readonly bool CaseInsensitive; // 0x39
	private readonly CultureInfo _culture; // 0x40

	// Methods

	// RVA: 0x2618890 Offset: 0x2617290 VA: 0x182618890
	public void .ctor(string pattern, bool caseInsensitive, bool rightToLeft, CultureInfo culture) { }

	// RVA: 0x2618420 Offset: 0x2616E20 VA: 0x182618420
	private bool MatchPattern(string text, int index) { }

	// RVA: 0x26183B0 Offset: 0x2616DB0 VA: 0x1826183B0
	public bool IsMatch(string text, int index, int beglimit, int endlimit) { }

	// RVA: 0x2618560 Offset: 0x2616F60 VA: 0x182618560
	public int Scan(string text, int index, int beglimit, int endlimit) { }
}

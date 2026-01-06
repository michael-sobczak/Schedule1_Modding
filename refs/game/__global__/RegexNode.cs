internal sealed class RegexNode // TypeDefIndex: 9565
{
	// Fields
	public int NType; // 0x10
	public List<RegexNode> Children; // 0x18
	public string Str; // 0x20
	public char Ch; // 0x28
	public int M; // 0x2C
	public int N; // 0x30
	public readonly RegexOptions Options; // 0x34
	public RegexNode Next; // 0x38

	// Methods

	// RVA: 0x2631A30 Offset: 0x2630430 VA: 0x182631A30
	public void .ctor(int type, RegexOptions options) { }

	// RVA: 0x2631A70 Offset: 0x2630470 VA: 0x182631A70
	public void .ctor(int type, RegexOptions options, char ch) { }

	// RVA: 0x2631940 Offset: 0x2630340 VA: 0x182631940
	public void .ctor(int type, RegexOptions options, string str) { }

	// RVA: 0x2631990 Offset: 0x2630390 VA: 0x182631990
	public void .ctor(int type, RegexOptions options, int m) { }

	// RVA: 0x26319E0 Offset: 0x26303E0 VA: 0x1826319E0
	public void .ctor(int type, RegexOptions options, int m, int n) { }

	// RVA: 0x2631930 Offset: 0x2630330 VA: 0x182631930
	public bool UseOptionR() { }

	// RVA: 0x26317D0 Offset: 0x26301D0 VA: 0x1826317D0
	public RegexNode ReverseLeft() { }

	// RVA: 0x2630A00 Offset: 0x262F400 VA: 0x182630A00
	private void MakeRep(int type, int min, int max) { }

	// RVA: 0x2631590 Offset: 0x262FF90 VA: 0x182631590
	private RegexNode Reduce() { }

	// RVA: 0x2631840 Offset: 0x2630240 VA: 0x182631840
	private RegexNode StripEnation(int emptyType) { }

	// RVA: 0x2631200 Offset: 0x262FC00 VA: 0x182631200
	private RegexNode ReduceGroup() { }

	// RVA: 0x2631270 Offset: 0x262FC70 VA: 0x182631270
	private RegexNode ReduceRep() { }

	// RVA: 0x2631430 Offset: 0x262FE30 VA: 0x182631430
	private RegexNode ReduceSet() { }

	// RVA: 0x2630A10 Offset: 0x262F410 VA: 0x182630A10
	private RegexNode ReduceAlternation() { }

	// RVA: 0x2630E20 Offset: 0x262F820 VA: 0x182630E20
	private RegexNode ReduceConcatenation() { }

	// RVA: 0x26308F0 Offset: 0x262F2F0 VA: 0x1826308F0
	public RegexNode MakeQuantifier(bool lazy, int min, int max) { }

	// RVA: 0x2630710 Offset: 0x262F110 VA: 0x182630710
	public void AddChild(RegexNode newChild) { }

	// RVA: 0x2630890 Offset: 0x262F290 VA: 0x182630890
	public RegexNode Child(int i) { }

	// RVA: 0x2630840 Offset: 0x262F240 VA: 0x182630840
	public int ChildCount() { }

	// RVA: 0x43C220 Offset: 0x43AC20 VA: 0x18043C220
	public int Type() { }
}

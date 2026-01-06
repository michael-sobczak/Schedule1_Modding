internal struct RegexWriter // TypeDefIndex: 9573
{
	// Fields
	private ValueListBuilder<int> _emitted; // 0x0
	private ValueListBuilder<int> _intStack; // 0x20
	private readonly Dictionary<string, int> _stringHash; // 0x40
	private readonly List<string> _stringTable; // 0x48
	private Hashtable _caps; // 0x50
	private int _trackCount; // 0x58

	// Methods

	// RVA: 0x263C300 Offset: 0x263AD00 VA: 0x18263C300
	private void .ctor(Span<int> emittedSpan, Span<int> intStackSpan) { }

	// RVA: 0x263C0A0 Offset: 0x263AAA0 VA: 0x18263C0A0
	public static RegexCode Write(RegexTree tree) { }

	// RVA: 0x263ACA0 Offset: 0x26396A0 VA: 0x18263ACA0
	public void Dispose() { }

	// RVA: 0x263B980 Offset: 0x263A380 VA: 0x18263B980
	public RegexCode RegexCodeFromRegexTree(RegexTree tree) { }

	// RVA: 0x263B920 Offset: 0x263A320 VA: 0x18263B920
	private void PatchJump(int offset, int jumpDest) { }

	// RVA: 0x263B750 Offset: 0x263A150 VA: 0x18263B750
	private void Emit(int op) { }

	// RVA: 0x263B6D0 Offset: 0x263A0D0 VA: 0x18263B6D0
	private void Emit(int op, int opd1) { }

	// RVA: 0x263B7B0 Offset: 0x263A1B0 VA: 0x18263B7B0
	private void Emit(int op, int opd1, int opd2) { }

	// RVA: 0x263BFA0 Offset: 0x263A9A0 VA: 0x18263BFA0
	private int StringCode(string str) { }

	// RVA: 0x263B850 Offset: 0x263A250 VA: 0x18263B850
	private int MapCapnum(int capnum) { }

	// RVA: 0x263ACF0 Offset: 0x26396F0 VA: 0x18263ACF0
	private void EmitFragment(int nodetype, RegexNode node, int curIndex) { }
}

internal struct RegexFCD // TypeDefIndex: 9561
{
	// Fields
	private readonly List<RegexFC> _fcStack; // 0x0
	private ValueListBuilder<int> _intStack; // 0x8
	private bool _skipAllChildren; // 0x28
	private bool _skipchild; // 0x29
	private bool _failed; // 0x2A

	// Methods

	// RVA: 0x26226F0 Offset: 0x26210F0 VA: 0x1826226F0
	private void .ctor(Span<int> intStack) { }

	// RVA: 0x2621B00 Offset: 0x2620500 VA: 0x182621B00
	public static Nullable<RegexPrefix> FirstChars(RegexTree t) { }

	// RVA: 0x2622020 Offset: 0x2620A20 VA: 0x182622020
	public static RegexPrefix Prefix(RegexTree tree) { }

	// RVA: 0x2621120 Offset: 0x261FB20 VA: 0x182621120
	public static int Anchors(RegexTree tree) { }

	// RVA: 0x26210A0 Offset: 0x261FAA0 VA: 0x1826210A0
	private static int AnchorFromType(int type) { }

	// RVA: 0x2622360 Offset: 0x2620D60 VA: 0x182622360
	private void PushInt(int i) { }

	// RVA: 0x2621EE0 Offset: 0x26208E0 VA: 0x182621EE0
	private bool IntIsEmpty() { }

	// RVA: 0x2621FD0 Offset: 0x26209D0 VA: 0x182621FD0
	private int PopInt() { }

	// RVA: 0x26222B0 Offset: 0x2620CB0 VA: 0x1826222B0
	private void PushFC(RegexFC fc) { }

	// RVA: 0x2621AC0 Offset: 0x26204C0 VA: 0x182621AC0
	private bool FCIsEmpty() { }

	// RVA: 0x2621F20 Offset: 0x2620920 VA: 0x182621F20
	private RegexFC PopFC() { }

	// RVA: 0x2622690 Offset: 0x2621090 VA: 0x182622690
	private RegexFC TopFC() { }

	// RVA: 0x2621A80 Offset: 0x2620480 VA: 0x182621A80
	public void Dispose() { }

	// RVA: 0x2622410 Offset: 0x2620E10 VA: 0x182622410
	private RegexFC RegexFCFromRegexTree(RegexTree tree) { }

	// RVA: 0xB2DE80 Offset: 0xB2C880 VA: 0x180B2DE80
	private void SkipChild() { }

	// RVA: 0x26212F0 Offset: 0x261FCF0 VA: 0x1826212F0
	private void CalculateFC(int NodeType, RegexNode node, int CurIndex) { }
}

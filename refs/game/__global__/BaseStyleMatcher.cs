internal abstract class BaseStyleMatcher // TypeDefIndex: 7184
{
	// Fields
	protected static readonly Regex s_CustomIdentRegex; // 0x0
	private Stack<BaseStyleMatcher.MatchContext> m_ContextStack; // 0x10
	private BaseStyleMatcher.MatchContext m_CurrentContext; // 0x18

	// Properties
	public abstract int valueCount { get; }
	public abstract bool isCurrentVariable { get; }
	public abstract bool isCurrentComma { get; }
	public bool hasCurrent { get; }
	public int currentIndex { get; set; }
	public int matchedVariableCount { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	protected abstract bool MatchKeyword(string keyword);

	// RVA: -1 Offset: -1 Slot: 5
	protected abstract bool MatchNumber();

	// RVA: -1 Offset: -1 Slot: 6
	protected abstract bool MatchInteger();

	// RVA: -1 Offset: -1 Slot: 7
	protected abstract bool MatchLength();

	// RVA: -1 Offset: -1 Slot: 8
	protected abstract bool MatchPercentage();

	// RVA: -1 Offset: -1 Slot: 9
	protected abstract bool MatchColor();

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract bool MatchResource();

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract bool MatchUrl();

	// RVA: -1 Offset: -1 Slot: 12
	protected abstract bool MatchTime();

	// RVA: -1 Offset: -1 Slot: 13
	protected abstract bool MatchAngle();

	// RVA: -1 Offset: -1 Slot: 14
	protected abstract bool MatchCustomIdent();

	// RVA: -1 Offset: -1 Slot: 15
	public abstract int get_valueCount();

	// RVA: -1 Offset: -1 Slot: 16
	public abstract bool get_isCurrentVariable();

	// RVA: -1 Offset: -1 Slot: 17
	public abstract bool get_isCurrentComma();

	// RVA: 0x2E3FEF0 Offset: 0x2E3E8F0 VA: 0x182E3FEF0
	public bool get_hasCurrent() { }

	// RVA: 0x456E90 Offset: 0x455890 VA: 0x180456E90
	public int get_currentIndex() { }

	// RVA: 0x49D810 Offset: 0x49C210 VA: 0x18049D810
	public void set_currentIndex(int value) { }

	// RVA: 0x4A1F70 Offset: 0x4A0970 VA: 0x1804A1F70
	public int get_matchedVariableCount() { }

	// RVA: 0x4A1F80 Offset: 0x4A0980 VA: 0x1804A1F80
	public void set_matchedVariableCount(int value) { }

	// RVA: 0x2E3ECF0 Offset: 0x2E3D6F0 VA: 0x182E3ECF0
	protected void Initialize() { }

	// RVA: 0x2E3FD00 Offset: 0x2E3E700 VA: 0x182E3FD00
	public void MoveNext() { }

	// RVA: 0x2E3FD90 Offset: 0x2E3E790 VA: 0x182E3FD90
	public void SaveContext() { }

	// RVA: 0x2E3FD40 Offset: 0x2E3E740 VA: 0x182E3FD40
	public void RestoreContext() { }

	// RVA: 0x2E3ECA0 Offset: 0x2E3D6A0 VA: 0x182E3ECA0
	public void DropContext() { }

	// RVA: 0x2E3FB70 Offset: 0x2E3E570 VA: 0x182E3FB70
	protected bool Match(Expression exp) { }

	// RVA: 0x2E3F370 Offset: 0x2E3DD70 VA: 0x182E3F370
	private bool MatchExpression(Expression exp) { }

	// RVA: 0x2E3F250 Offset: 0x2E3DC50 VA: 0x182E3F250
	private bool MatchExpressionWithMultiplier(Expression exp) { }

	// RVA: 0x2E3F5C0 Offset: 0x2E3DFC0 VA: 0x182E3F5C0
	private bool MatchGroup(Expression exp) { }

	// RVA: 0x2E3ED80 Offset: 0x2E3D780 VA: 0x182E3ED80
	private bool MatchCombinator(Expression exp) { }

	// RVA: 0x2E3FA40 Offset: 0x2E3E440 VA: 0x182E3FA40
	private bool MatchOr(Expression exp) { }

	// RVA: 0x2E3FA20 Offset: 0x2E3E420 VA: 0x182E3FA20
	private bool MatchOrOr(Expression exp) { }

	// RVA: 0x2E3ED40 Offset: 0x2E3D740 VA: 0x182E3ED40
	private bool MatchAndAnd(Expression exp) { }

	// RVA: 0x2E3F860 Offset: 0x2E3E260 VA: 0x182E3F860
	private int MatchMany(Expression exp) { }

	// RVA: 0x2E3F6F0 Offset: 0x2E3E0F0 VA: 0x182E3F6F0
	private int MatchManyByOrder(Expression exp, int* matchOrder) { }

	// RVA: 0x2E3F670 Offset: 0x2E3E070 VA: 0x182E3F670
	private bool MatchJuxtaposition(Expression exp) { }

	// RVA: 0x2E3F0D0 Offset: 0x2E3DAD0 VA: 0x182E3F0D0
	private bool MatchDataType(Expression exp) { }

	// RVA: 0x2E3FE70 Offset: 0x2E3E870 VA: 0x182E3FE70
	protected void .ctor() { }

	// RVA: 0x2E3FDE0 Offset: 0x2E3E7E0 VA: 0x182E3FDE0
	private static void .cctor() { }
}

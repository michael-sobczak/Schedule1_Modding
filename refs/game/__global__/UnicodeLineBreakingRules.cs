public class UnicodeLineBreakingRules // TypeDefIndex: 16764
{
	// Fields
	[SerializeField]
	private TextAsset m_UnicodeLineBreakingRules; // 0x10
	[SerializeField]
	private TextAsset m_LeadingCharacters; // 0x18
	[SerializeField]
	private TextAsset m_FollowingCharacters; // 0x20
	[SerializeField]
	private bool m_UseModernHangulLineBreakingRules; // 0x28
	private HashSet<uint> m_LeadingCharactersLookup; // 0x30
	private HashSet<uint> m_FollowingCharactersLookup; // 0x38

	// Properties
	public TextAsset leadingCharacters { get; }
	public TextAsset followingCharacters { get; }
	internal HashSet<uint> leadingCharactersLookup { get; }
	internal HashSet<uint> followingCharactersLookup { get; }
	public bool useModernHangulLineBreakingRules { get; }

	// Methods

	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	public TextAsset get_leadingCharacters() { }

	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	public TextAsset get_followingCharacters() { }

	// RVA: 0x2D89A50 Offset: 0x2D88450 VA: 0x182D89A50
	internal HashSet<uint> get_leadingCharactersLookup() { }

	// RVA: 0x2D89A10 Offset: 0x2D88410 VA: 0x182D89A10
	internal HashSet<uint> get_followingCharactersLookup() { }

	// RVA: 0x493120 Offset: 0x491B20 VA: 0x180493120
	public bool get_useModernHangulLineBreakingRules() { }

	// RVA: 0x2D89650 Offset: 0x2D88050 VA: 0x182D89650
	internal void LoadLineBreakingRules() { }

	// RVA: 0x2D89840 Offset: 0x2D88240 VA: 0x182D89840
	internal void LoadLineBreakingRules(TextAsset leadingRules, TextAsset followingRules) { }

	// RVA: 0x2D89580 Offset: 0x2D87F80 VA: 0x182D89580
	private static HashSet<uint> GetCharacters(TextAsset file) { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }
}

internal class StyleMatchingContext // TypeDefIndex: 7056
{
	// Fields
	private List<StyleSheet> m_StyleSheetStack; // 0x10
	public StyleVariableContext variableContext; // 0x18
	public VisualElement currentElement; // 0x20
	public Action<VisualElement, MatchResultInfo> processResult; // 0x28
	public AncestorFilter ancestorFilter; // 0x30

	// Properties
	public int styleSheetCount { get; }

	// Methods

	// RVA: 0x2E051A0 Offset: 0x2E03BA0 VA: 0x182E051A0
	public int get_styleSheetCount() { }

	// RVA: 0x2E05080 Offset: 0x2E03A80 VA: 0x182E05080
	public void .ctor(Action<VisualElement, MatchResultInfo> processResult) { }

	// RVA: 0x2E04F20 Offset: 0x2E03920 VA: 0x182E04F20
	public void AddStyleSheet(StyleSheet sheet) { }

	// RVA: 0x2E05010 Offset: 0x2E03A10 VA: 0x182E05010
	public void RemoveStyleSheetRange(int index, int count) { }

	// RVA: 0x2E04FB0 Offset: 0x2E039B0 VA: 0x182E04FB0
	public StyleSheet GetStyleSheetAt(int index) { }
}

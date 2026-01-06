internal class VisualTreeStyleUpdaterTraversal : HierarchyTraversal // TypeDefIndex: 7058
{
	// Fields
	private StyleVariableContext m_ProcessVarContext; // 0x10
	private HashSet<VisualElement> m_UpdateList; // 0x18
	private HashSet<VisualElement> m_ParentList; // 0x20
	private List<SelectorMatchRecord> m_TempMatchResults; // 0x28
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private float <currentPixelsPerPoint>k__BackingField; // 0x30
	private StyleMatchingContext m_StyleMatchingContext; // 0x38
	private StylePropertyReader m_StylePropertyReader; // 0x40
	private readonly List<StylePropertyId> m_AnimatedProperties; // 0x48

	// Properties
	private float currentPixelsPerPoint { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x497260 Offset: 0x495C60 VA: 0x180497260
	private float get_currentPixelsPerPoint() { }

	[CompilerGenerated]
	// RVA: 0x49D320 Offset: 0x49BD20 VA: 0x18049D320
	private void set_currentPixelsPerPoint(float value) { }

	// RVA: 0x49D320 Offset: 0x49BD20 VA: 0x18049D320
	public void PrepareTraversal(float pixelsPerPoint) { }

	// RVA: 0x2E0F290 Offset: 0x2E0DC90 VA: 0x182E0F290
	public void AddChangedElement(VisualElement ve, VersionChangeType versionChangeType) { }

	// RVA: 0x2E0F580 Offset: 0x2E0DF80 VA: 0x182E0F580
	public void Clear() { }

	// RVA: 0x2E10630 Offset: 0x2E0F030 VA: 0x182E10630
	private void PropagateToChildren(VisualElement ve) { }

	// RVA: 0x2E10710 Offset: 0x2E0F110 VA: 0x182E10710
	private void PropagateToParents(VisualElement ve) { }

	// RVA: 0x2E0F860 Offset: 0x2E0E260 VA: 0x182E0F860
	private static void OnProcessMatchResult(VisualElement current, MatchResultInfo info) { }

	// RVA: 0x2E10840 Offset: 0x2E0F240 VA: 0x182E10840 Slot: 5
	public override void TraverseRecursive(VisualElement element, int depth) { }

	// RVA: 0x2E10500 Offset: 0x2E0EF00 VA: 0x182E10500
	private void ProcessTransitions(VisualElement element, ref ComputedStyle oldStyle, ref ComputedStyle newStyle) { }

	// RVA: 0x2E0F620 Offset: 0x2E0E020 VA: 0x182E0F620
	private void ForceUpdateTransitions(VisualElement element) { }

	// RVA: 0x2E0F3A0 Offset: 0x2E0DDA0 VA: 0x182E0F3A0
	internal void CancelAnimationsWithNoTransitionProperty(VisualElement element, ref ComputedStyle newStyle) { }

	// RVA: 0x2E107C0 Offset: 0x2E0F1C0 VA: 0x182E107C0
	protected bool ShouldSkipElement(VisualElement element) { }

	// RVA: 0x2E0F8A0 Offset: 0x2E0E2A0 VA: 0x182E0F8A0
	private ComputedStyle ProcessMatchedRules(VisualElement element, List<SelectorMatchRecord> matchingSelectors) { }

	// RVA: 0x2E103E0 Offset: 0x2E0EDE0 VA: 0x182E103E0
	private void ProcessMatchedVariables(StyleSheet sheet, StyleRule rule) { }

	// RVA: 0x2E110E0 Offset: 0x2E0FAE0 VA: 0x182E110E0
	public void .ctor() { }
}

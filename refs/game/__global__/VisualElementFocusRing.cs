public class VisualElementFocusRing : IFocusRing // TypeDefIndex: 7041
{
	// Fields
	private readonly VisualElement root; // 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private VisualElementFocusRing.DefaultFocusOrder <defaultFocusOrder>k__BackingField; // 0x18
	private List<VisualElementFocusRing.FocusRingRecord> m_FocusRing; // 0x20

	// Properties
	private FocusController focusController { get; }
	public VisualElementFocusRing.DefaultFocusOrder defaultFocusOrder { get; set; }

	// Methods

	// RVA: 0x2DF4780 Offset: 0x2DF3180 VA: 0x182DF4780
	public void .ctor(VisualElement root, VisualElementFocusRing.DefaultFocusOrder dfo = 0) { }

	// RVA: 0x1B56610 Offset: 0x1B55010 VA: 0x181B56610
	private FocusController get_focusController() { }

	[CompilerGenerated]
	// RVA: 0x456E90 Offset: 0x455890 VA: 0x180456E90
	public VisualElementFocusRing.DefaultFocusOrder get_defaultFocusOrder() { }

	[CompilerGenerated]
	// RVA: 0x49D810 Offset: 0x49C210 VA: 0x18049D810
	public void set_defaultFocusOrder(VisualElementFocusRing.DefaultFocusOrder value) { }

	// RVA: 0x2DF33E0 Offset: 0x2DF1DE0 VA: 0x182DF33E0
	private int FocusRingAutoIndexSort(VisualElementFocusRing.FocusRingRecord a, VisualElementFocusRing.FocusRingRecord b) { }

	// RVA: 0x2DF37A0 Offset: 0x2DF21A0 VA: 0x182DF37A0
	private int FocusRingSort(VisualElementFocusRing.FocusRingRecord a, VisualElementFocusRing.FocusRingRecord b) { }

	// RVA: 0x2DF3300 Offset: 0x2DF1D00 VA: 0x182DF3300
	private void DoUpdate() { }

	// RVA: 0x2DF3030 Offset: 0x2DF1A30 VA: 0x182DF3030
	private void BuildRingForScopeRecursive(VisualElement ve, ref int scopeIndex, List<VisualElementFocusRing.FocusRingRecord> scopeList) { }

	// RVA: 0x2DF4530 Offset: 0x2DF2F30 VA: 0x182DF4530
	private void SortAndFlattenScopeLists(List<VisualElementFocusRing.FocusRingRecord> rootScopeList) { }

	// RVA: 0x2DF3C70 Offset: 0x2DF2670 VA: 0x182DF3C70
	private int GetFocusableInternalIndex(Focusable f) { }

	// RVA: 0x2DF38C0 Offset: 0x2DF22C0 VA: 0x182DF38C0 Slot: 4
	public FocusChangeDirection GetFocusChangeDirection(Focusable currentFocusable, EventBase e) { }

	// RVA: 0x2DF3DD0 Offset: 0x2DF27D0 VA: 0x182DF3DD0 Slot: 5
	public Focusable GetNextFocusable(Focusable currentFocusable, FocusChangeDirection direction) { }

	// RVA: 0x2DF3D20 Offset: 0x2DF2720 VA: 0x182DF3D20
	internal static Focusable GetNextFocusableInTree(VisualElement currentFocusable) { }

	// RVA: 0x2DF4440 Offset: 0x2DF2E40 VA: 0x182DF4440
	internal static Focusable GetPreviousFocusableInTree(VisualElement currentFocusable) { }
}

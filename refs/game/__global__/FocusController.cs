public class FocusController // TypeDefIndex: 6670
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private readonly IFocusRing <focusRing>k__BackingField; // 0x10
	private TextElement m_SelectedTextElement; // 0x18
	private List<FocusController.FocusedElement> m_FocusedElements; // 0x20
	private Focusable m_LastFocusedElement; // 0x28
	internal Focusable m_LastPendingFocusedElement; // 0x30
	private int m_PendingFocusCount; // 0x38
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private int <imguiKeyboardControl>k__BackingField; // 0x3C

	// Properties
	private IFocusRing focusRing { get; }
	internal TextElement selectedTextElement { set; }
	public Focusable focusedElement { get; }
	internal int imguiKeyboardControl { get; set; }

	// Methods

	// RVA: 0x2EA3710 Offset: 0x2EA2110 VA: 0x182EA3710
	public void .ctor(IFocusRing focusRing) { }

	[CompilerGenerated]
	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	private IFocusRing get_focusRing() { }

	// RVA: 0x2EA3810 Offset: 0x2EA2210 VA: 0x182EA3810
	internal void set_selectedTextElement(TextElement value) { }

	// RVA: 0x2EA37B0 Offset: 0x2EA21B0 VA: 0x182EA37B0
	public Focusable get_focusedElement() { }

	// RVA: 0x2EA29D0 Offset: 0x2EA13D0 VA: 0x182EA29D0
	internal bool IsFocused(Focusable f) { }

	// RVA: 0x2EA2680 Offset: 0x2EA1080 VA: 0x182EA2680
	internal Focusable GetRetargetedFocusedElement(VisualElement retargetAgainst) { }

	// RVA: 0x2EA25C0 Offset: 0x2EA0FC0 VA: 0x182EA25C0
	internal Focusable GetLeafFocusedElement() { }

	// RVA: 0x2EA2B10 Offset: 0x2EA1510 VA: 0x182EA2B10
	private bool IsLocalElement(Focusable f) { }

	// RVA: 0x2EA2B60 Offset: 0x2EA1560 VA: 0x182EA2B60
	internal bool IsPendingFocus(Focusable f) { }

	// RVA: 0x2EA2FC0 Offset: 0x2EA19C0 VA: 0x182EA2FC0
	internal void SetFocusToLastFocusedElement() { }

	// RVA: 0x2EA1FC0 Offset: 0x2EA09C0 VA: 0x182EA1FC0
	internal void BlurLastFocusedElement() { }

	// RVA: 0x2EA21E0 Offset: 0x2EA0BE0 VA: 0x182EA21E0
	internal void DoFocusChange(Focusable f) { }

	// RVA: 0x2EA2C30 Offset: 0x2EA1630 VA: 0x182EA2C30
	internal void ProcessPendingFocusChange(Focusable f) { }

	// RVA: 0x2EA2380 Offset: 0x2EA0D80 VA: 0x182EA2380
	internal Focusable FocusNextInDirection(FocusChangeDirection direction) { }

	// RVA: 0x2EA1EB0 Offset: 0x2EA08B0 VA: 0x182EA1EB0
	private void AboutToReleaseFocus(Focusable focusable, Focusable willGiveFocusTo, FocusChangeDirection direction, DispatchMode dispatchMode) { }

	// RVA: 0x2EA2EB0 Offset: 0x2EA18B0 VA: 0x182EA2EB0
	private void ReleaseFocus(Focusable focusable, Focusable willGiveFocusTo, FocusChangeDirection direction, DispatchMode dispatchMode) { }

	// RVA: 0x2EA1DA0 Offset: 0x2EA07A0 VA: 0x182EA1DA0
	private void AboutToGrabFocus(Focusable focusable, Focusable willTakeFocusFrom, FocusChangeDirection direction, DispatchMode dispatchMode) { }

	// RVA: 0x2EA28B0 Offset: 0x2EA12B0 VA: 0x182EA28B0
	private void GrabFocus(Focusable focusable, Focusable willTakeFocusFrom, FocusChangeDirection direction, bool bIsFocusDelegated, DispatchMode dispatchMode) { }

	// RVA: 0x2EA20D0 Offset: 0x2EA0AD0 VA: 0x182EA20D0
	internal void Blur(Focusable focusable, bool bIsFocusDelegated = False, DispatchMode dispatchMode = 1) { }

	// RVA: 0x2EA3250 Offset: 0x2EA1C50 VA: 0x182EA3250
	internal void SwitchFocus(Focusable newFocusedElement, bool bIsFocusDelegated = False, DispatchMode dispatchMode = 1) { }

	// RVA: 0x2EA3320 Offset: 0x2EA1D20 VA: 0x182EA3320
	internal void SwitchFocus(Focusable newFocusedElement, FocusChangeDirection direction, bool bIsFocusDelegated = False, DispatchMode dispatchMode = 1) { }

	// RVA: 0x2EA3050 Offset: 0x2EA1A50 VA: 0x182EA3050
	internal void SwitchFocusOnEvent(EventBase e) { }

	// RVA: 0x2EA2DE0 Offset: 0x2EA17E0 VA: 0x182EA2DE0
	internal void ReevaluateFocus() { }

	// RVA: 0x2EA2490 Offset: 0x2EA0E90 VA: 0x182EA2490
	internal bool GetFocusableParentForPointerEvent(Focusable target, out Focusable effectiveTarget) { }

	[CompilerGenerated]
	// RVA: 0xC21BD0 Offset: 0xC205D0 VA: 0x180C21BD0
	internal int get_imguiKeyboardControl() { }

	[CompilerGenerated]
	// RVA: 0xC21CD0 Offset: 0xC206D0 VA: 0x180C21CD0
	internal void set_imguiKeyboardControl(int value) { }

	// RVA: 0x2EA35F0 Offset: 0x2EA1FF0 VA: 0x182EA35F0
	internal void SyncIMGUIFocus(int imguiKeyboardControlID, Focusable imguiContainerHavingKeyboardControl, bool forceSwitch) { }
}

public abstract class Focusable : CallbackEventHandler // TypeDefIndex: 6666
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private bool <focusable>k__BackingField; // 0x20
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private int <tabIndex>k__BackingField; // 0x24
	private bool m_DelegatesFocus; // 0x28
	private bool m_ExcludeFromFocusRing; // 0x29

	// Properties
	public abstract FocusController focusController { get; }
	public bool focusable { get; set; }
	public int tabIndex { get; set; }
	public bool delegatesFocus { get; set; }
	internal bool excludeFromFocusRing { get; set; }
	public virtual bool canGrabFocus { get; }

	// Methods

	// RVA: 0x2EA4560 Offset: 0x2EA2F60 VA: 0x182EA4560
	protected void .ctor() { }

	// RVA: -1 Offset: -1 Slot: 15
	public abstract FocusController get_focusController();

	[CompilerGenerated]
	// RVA: 0x4945E0 Offset: 0x492FE0 VA: 0x1804945E0
	public bool get_focusable() { }

	[CompilerGenerated]
	// RVA: 0x494600 Offset: 0x493000 VA: 0x180494600
	public void set_focusable(bool value) { }

	[CompilerGenerated]
	// RVA: 0x49CD40 Offset: 0x49B740 VA: 0x18049CD40
	public int get_tabIndex() { }

	[CompilerGenerated]
	// RVA: 0x49CD60 Offset: 0x49B760 VA: 0x18049CD60
	public void set_tabIndex(int value) { }

	// RVA: 0x2EA4590 Offset: 0x2EA2F90 VA: 0x182EA4590
	public bool get_delegatesFocus() { }

	// RVA: 0x493130 Offset: 0x491B30 VA: 0x180493130
	public void set_delegatesFocus(bool value) { }

	// RVA: 0x2EA45A0 Offset: 0x2EA2FA0 VA: 0x182EA45A0
	internal bool get_excludeFromFocusRing() { }

	// RVA: 0x2EA45B0 Offset: 0x2EA2FB0 VA: 0x182EA45B0
	internal void set_excludeFromFocusRing(bool value) { }

	// RVA: 0x4945E0 Offset: 0x492FE0 VA: 0x1804945E0 Slot: 16
	public virtual bool get_canGrabFocus() { }

	// RVA: 0x2EA41F0 Offset: 0x2EA2BF0 VA: 0x182EA41F0 Slot: 17
	public virtual void Focus() { }

	// RVA: 0x2EA4130 Offset: 0x2EA2B30 VA: 0x182EA4130 Slot: 18
	public virtual void Blur() { }

	// RVA: 0x2EA40E0 Offset: 0x2EA2AE0 VA: 0x182EA40E0
	internal void BlurImmediately() { }

	// RVA: 0x2EA4470 Offset: 0x2EA2E70 VA: 0x182EA4470
	private Focusable GetFocusDelegate() { }

	// RVA: 0x2EA4320 Offset: 0x2EA2D20 VA: 0x182EA4320
	private static Focusable GetFirstFocusableChild(VisualElement ve) { }

	[EventInterest(new[] { typeof(PointerDownEvent), typeof(NavigationMoveEvent) })]
	// RVA: 0x2EA4180 Offset: 0x2EA2B80 VA: 0x182EA4180 Slot: 12
	protected override void ExecuteDefaultAction(EventBase evt) { }

	[EventInterest(new[] { typeof(PointerDownEvent), typeof(NavigationMoveEvent) })]
	// RVA: 0x2EA4180 Offset: 0x2EA2B80 VA: 0x182EA4180 Slot: 14
	internal override void ExecuteDefaultActionDisabled(EventBase evt) { }

	// RVA: 0x2EA4500 Offset: 0x2EA2F00 VA: 0x182EA4500
	private void ProcessEvent(EventBase evt) { }
}

public abstract class MouseEventBase<T> : EventBase<T>, IMouseEvent, IMouseEventInternal // TypeDefIndex: 6571
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private EventModifiers <modifiers>k__BackingField; // 0x0
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private Vector2 <mousePosition>k__BackingField; // 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private Vector2 <localMousePosition>k__BackingField; // 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private Vector2 <mouseDelta>k__BackingField; // 0x0
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private int <clickCount>k__BackingField; // 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private int <button>k__BackingField; // 0x0
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private int <pressedButtons>k__BackingField; // 0x0
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private bool <UnityEngine.UIElements.IMouseEventInternal.triggeredByOS>k__BackingField; // 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private bool <UnityEngine.UIElements.IMouseEventInternal.recomputeTopElementUnderMouse>k__BackingField; // 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private IPointerEvent <UnityEngine.UIElements.IMouseEventInternal.sourcePointerEvent>k__BackingField; // 0x0

	// Properties
	public EventModifiers modifiers { get; set; }
	public Vector2 mousePosition { get; set; }
	public Vector2 localMousePosition { get; set; }
	public Vector2 mouseDelta { get; set; }
	public int clickCount { get; set; }
	public int button { get; set; }
	public int pressedButtons { get; set; }
	public bool shiftKey { get; }
	public bool ctrlKey { get; }
	public bool commandKey { get; }
	public bool altKey { get; }
	private bool UnityEngine.UIElements.IMouseEventInternal.triggeredByOS { get; set; }
	private bool UnityEngine.UIElements.IMouseEventInternal.recomputeTopElementUnderMouse { get; set; }
	private IPointerEvent UnityEngine.UIElements.IMouseEventInternal.sourcePointerEvent { get; set; }
	public override IEventHandler currentTarget { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 15
	public EventModifiers get_modifiers() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1063C60 Offset: 0x1062660 VA: 0x181063C60
	|-MouseEventBase<object>.get_modifiers
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	protected void set_modifiers(EventModifiers value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1063DF0 Offset: 0x10627F0 VA: 0x181063DF0
	|-MouseEventBase<object>.set_modifiers
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 16
	public Vector2 get_mousePosition() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1063C90 Offset: 0x1062690 VA: 0x181063C90
	|-MouseEventBase<object>.get_mousePosition
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	protected void set_mousePosition(Vector2 value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1063E10 Offset: 0x1062810 VA: 0x181063E10
	|-MouseEventBase<object>.set_mousePosition
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 17
	public Vector2 get_localMousePosition() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1063C40 Offset: 0x1062640 VA: 0x181063C40
	|-MouseEventBase<object>.get_localMousePosition
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	internal void set_localMousePosition(Vector2 value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1063DE0 Offset: 0x10627E0 VA: 0x181063DE0
	|-MouseEventBase<object>.set_localMousePosition
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 18
	public Vector2 get_mouseDelta() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1063C70 Offset: 0x1062670 VA: 0x181063C70
	|-MouseEventBase<object>.get_mouseDelta
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	protected void set_mouseDelta(Vector2 value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1063E00 Offset: 0x1062800 VA: 0x181063E00
	|-MouseEventBase<object>.set_mouseDelta
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 19
	public int get_clickCount() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBBA760 Offset: 0xBB9160 VA: 0x180BBA760
	|-MouseEventBase<object>.get_clickCount
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	protected void set_clickCount(int value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBBA830 Offset: 0xBB9230 VA: 0x180BBA830
	|-MouseEventBase<object>.set_clickCount
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 20
	public int get_button() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x587050 Offset: 0x585A50 VA: 0x180587050
	|-MouseEventBase<object>.get_button
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	protected void set_button(int value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x587060 Offset: 0x585A60 VA: 0x180587060
	|-MouseEventBase<object>.set_button
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 21
	public int get_pressedButtons() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBBA750 Offset: 0xBB9150 VA: 0x180BBA750
	|-MouseEventBase<object>.get_pressedButtons
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	protected void set_pressedButtons(int value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBBA820 Offset: 0xBB9220 VA: 0x180BBA820
	|-MouseEventBase<object>.set_pressedButtons
	*/

	// RVA: -1 Offset: -1 Slot: 22
	public bool get_shiftKey() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1063CB0 Offset: 0x10626B0 VA: 0x181063CB0
	|-MouseEventBase<object>.get_shiftKey
	*/

	// RVA: -1 Offset: -1 Slot: 23
	public bool get_ctrlKey() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1063C10 Offset: 0x1062610 VA: 0x181063C10
	|-MouseEventBase<object>.get_ctrlKey
	*/

	// RVA: -1 Offset: -1 Slot: 24
	public bool get_commandKey() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1063C00 Offset: 0x1062600 VA: 0x181063C00
	|-MouseEventBase<object>.get_commandKey
	*/

	// RVA: -1 Offset: -1 Slot: 25
	public bool get_altKey() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1063BF0 Offset: 0x10625F0 VA: 0x181063BF0
	|-MouseEventBase<object>.get_altKey
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 26
	private bool UnityEngine.UIElements.IMouseEventInternal.get_triggeredByOS() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1063B40 Offset: 0x1062540 VA: 0x181063B40
	|-MouseEventBase<object>.UnityEngine.UIElements.IMouseEventInternal.get_triggeredByOS
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 27
	private void UnityEngine.UIElements.IMouseEventInternal.set_triggeredByOS(bool value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1063B60 Offset: 0x1062560 VA: 0x181063B60
	|-MouseEventBase<object>.UnityEngine.UIElements.IMouseEventInternal.set_triggeredByOS
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 28
	private bool UnityEngine.UIElements.IMouseEventInternal.get_recomputeTopElementUnderMouse() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1063B30 Offset: 0x1062530 VA: 0x181063B30
	|-MouseEventBase<object>.UnityEngine.UIElements.IMouseEventInternal.get_recomputeTopElementUnderMouse
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 29
	private void UnityEngine.UIElements.IMouseEventInternal.set_recomputeTopElementUnderMouse(bool value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1063B50 Offset: 0x1062550 VA: 0x181063B50
	|-MouseEventBase<object>.UnityEngine.UIElements.IMouseEventInternal.set_recomputeTopElementUnderMouse
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 30
	private IPointerEvent UnityEngine.UIElements.IMouseEventInternal.get_sourcePointerEvent() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B6160 Offset: 0x4B4B60 VA: 0x1804B6160
	|-MouseEventBase<object>.UnityEngine.UIElements.IMouseEventInternal.get_sourcePointerEvent
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 31
	private void UnityEngine.UIElements.IMouseEventInternal.set_sourcePointerEvent(IPointerEvent value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B6CA0 Offset: 0x4B56A0 VA: 0x1804B6CA0
	|-MouseEventBase<object>.UnityEngine.UIElements.IMouseEventInternal.set_sourcePointerEvent
	*/

	// RVA: -1 Offset: -1 Slot: 12
	protected override void Init() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1063670 Offset: 0x1062070 VA: 0x181063670
	|-MouseEventBase<object>.Init
	*/

	// RVA: -1 Offset: -1
	private void LocalInit() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10636C0 Offset: 0x10620C0 VA: 0x1810636C0
	|-MouseEventBase<object>.LocalInit
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public override IEventHandler get_currentTarget() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1063C20 Offset: 0x1062620 VA: 0x181063C20
	|-MouseEventBase<object>.get_currentTarget
	*/

	// RVA: -1 Offset: -1 Slot: 11
	internal override void set_currentTarget(IEventHandler value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1063CC0 Offset: 0x10626C0 VA: 0x181063CC0
	|-MouseEventBase<object>.set_currentTarget
	*/

	// RVA: -1 Offset: -1 Slot: 7
	protected internal override void PreDispatch(IPanel panel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10639F0 Offset: 0x10623F0 VA: 0x1810639F0
	|-MouseEventBase<object>.PreDispatch
	*/

	// RVA: -1 Offset: -1 Slot: 9
	protected internal override void PostDispatch(IPanel panel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1063830 Offset: 0x1062230 VA: 0x181063830
	|-MouseEventBase<object>.PostDispatch
	*/

	// RVA: -1 Offset: -1
	public static T GetPooled(Event systemEvent) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1062F20 Offset: 0x1061920 VA: 0x181062F20
	|-MouseEventBase<object>.GetPooled
	*/

	// RVA: -1 Offset: -1
	internal static T GetPooled(IMouseEvent triggerEvent, Vector2 mousePosition, bool recomputeTopElementUnderMouse) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10631D0 Offset: 0x1061BD0 VA: 0x1810631D0
	|-MouseEventBase<object>.GetPooled
	*/

	// RVA: -1 Offset: -1
	public static T GetPooled(IMouseEvent triggerEvent) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1063350 Offset: 0x1061D50 VA: 0x181063350
	|-MouseEventBase<object>.GetPooled
	*/

	// RVA: -1 Offset: -1
	protected static T GetPooled(IPointerEvent pointerEvent) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10629F0 Offset: 0x10613F0 VA: 0x1810629F0
	|-MouseEventBase<object>.GetPooled
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1063B70 Offset: 0x1062570 VA: 0x181063B70
	|-MouseEventBase<object>..ctor
	*/
}

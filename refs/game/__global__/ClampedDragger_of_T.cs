internal class ClampedDragger<T> : Clickable // TypeDefIndex: 6178
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private Action dragging; // 0x0
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private Action draggingEnded; // 0x0
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private ClampedDragger.DragDirection<T> <dragDirection>k__BackingField; // 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private BaseSlider<T> <slider>k__BackingField; // 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private Vector2 <startMousePosition>k__BackingField; // 0x0

	// Properties
	public ClampedDragger.DragDirection<T> dragDirection { get; set; }
	private BaseSlider<T> slider { set; }
	public Vector2 startMousePosition { get; set; }
	public Vector2 delta { get; }

	// Methods

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public void add_dragging(Action value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1441330 Offset: 0x143FD30 VA: 0x181441330
	|-ClampedDragger<int>.add_dragging
	|
	|-RVA: 0x1441290 Offset: 0x143FC90 VA: 0x181441290
	|-ClampedDragger<float>.add_dragging
	|
	|-RVA: 0x14413D0 Offset: 0x143FDD0 VA: 0x1814413D0
	|-ClampedDragger<__Il2CppFullySharedGenericType>.add_dragging
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public void remove_dragging(Action value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1441880 Offset: 0x1440280 VA: 0x181441880
	|-ClampedDragger<int>.remove_dragging
	|
	|-RVA: 0x1441740 Offset: 0x1440140 VA: 0x181441740
	|-ClampedDragger<float>.remove_dragging
	|
	|-RVA: 0x14417E0 Offset: 0x14401E0 VA: 0x1814417E0
	|-ClampedDragger<__Il2CppFullySharedGenericType>.remove_dragging
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public void add_draggingEnded(Action value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14411E0 Offset: 0x143FBE0 VA: 0x1814411E0
	|-ClampedDragger<int>.add_draggingEnded
	|
	|-RVA: 0x1441130 Offset: 0x143FB30 VA: 0x181441130
	|-ClampedDragger<float>.add_draggingEnded
	|
	|-RVA: 0x1441080 Offset: 0x143FA80 VA: 0x181441080
	|-ClampedDragger<__Il2CppFullySharedGenericType>.add_draggingEnded
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public void remove_draggingEnded(Action value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14415E0 Offset: 0x143FFE0 VA: 0x1814415E0
	|-ClampedDragger<int>.remove_draggingEnded
	|
	|-RVA: 0x1441530 Offset: 0x143FF30 VA: 0x181441530
	|-ClampedDragger<float>.remove_draggingEnded
	|
	|-RVA: 0x1441690 Offset: 0x1440090 VA: 0x181441690
	|-ClampedDragger<__Il2CppFullySharedGenericType>.remove_draggingEnded
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public ClampedDragger.DragDirection<T> get_dragDirection() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1063C60 Offset: 0x1062660 VA: 0x181063C60
	|-ClampedDragger<int>.get_dragDirection
	|-ClampedDragger<float>.get_dragDirection
	|-ClampedDragger<__Il2CppFullySharedGenericType>.get_dragDirection
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public void set_dragDirection(ClampedDragger.DragDirection<T> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1063DF0 Offset: 0x10627F0 VA: 0x181063DF0
	|-ClampedDragger<int>.set_dragDirection
	|-ClampedDragger<float>.set_dragDirection
	|-ClampedDragger<__Il2CppFullySharedGenericType>.set_dragDirection
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	private void set_slider(BaseSlider<T> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x614510 Offset: 0x612F10 VA: 0x180614510
	|-ClampedDragger<int>.set_slider
	|-ClampedDragger<float>.set_slider
	|-ClampedDragger<__Il2CppFullySharedGenericType>.set_slider
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public Vector2 get_startMousePosition() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1441510 Offset: 0x143FF10 VA: 0x181441510
	|-ClampedDragger<int>.get_startMousePosition
	|-ClampedDragger<float>.get_startMousePosition
	|-ClampedDragger<__Il2CppFullySharedGenericType>.get_startMousePosition
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	private void set_startMousePosition(Vector2 value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCD54F0 Offset: 0xCD3EF0 VA: 0x180CD54F0
	|-ClampedDragger<int>.set_startMousePosition
	|-ClampedDragger<float>.set_startMousePosition
	|-ClampedDragger<__Il2CppFullySharedGenericType>.set_startMousePosition
	*/

	// RVA: -1 Offset: -1
	public Vector2 get_delta() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1441470 Offset: 0x143FE70 VA: 0x181441470
	|-ClampedDragger<int>.get_delta
	|-ClampedDragger<float>.get_delta
	|
	|-RVA: 0x14414B0 Offset: 0x143FEB0 VA: 0x1814414B0
	|-ClampedDragger<__Il2CppFullySharedGenericType>.get_delta
	*/

	// RVA: -1 Offset: -1
	public void .ctor(BaseSlider<T> slider, Action clickHandler, Action dragHandler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1440E10 Offset: 0x143F810 VA: 0x181440E10
	|-ClampedDragger<int>..ctor
	|
	|-RVA: 0x1440EF0 Offset: 0x143F8F0 VA: 0x181440EF0
	|-ClampedDragger<float>..ctor
	|
	|-RVA: 0x1440FD0 Offset: 0x143F9D0 VA: 0x181440FD0
	|-ClampedDragger<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 8
	protected override void ProcessDownEvent(EventBase evt, Vector2 localPosition, int pointerId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14408B0 Offset: 0x143F2B0 VA: 0x1814408B0
	|-ClampedDragger<int>.ProcessDownEvent
	|-ClampedDragger<float>.ProcessDownEvent
	|
	|-RVA: 0x14407F0 Offset: 0x143F1F0 VA: 0x1814407F0
	|-ClampedDragger<__Il2CppFullySharedGenericType>.ProcessDownEvent
	*/

	// RVA: -1 Offset: -1 Slot: 10
	protected override void ProcessUpEvent(EventBase evt, Vector2 localPosition, int pointerId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1440DC0 Offset: 0x143F7C0 VA: 0x181440DC0
	|-ClampedDragger<int>.ProcessUpEvent
	|-ClampedDragger<float>.ProcessUpEvent
	|-ClampedDragger<__Il2CppFullySharedGenericType>.ProcessUpEvent
	*/

	// RVA: -1 Offset: -1 Slot: 9
	protected override void ProcessMoveEvent(EventBase evt, Vector2 localPosition) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1440C40 Offset: 0x143F640 VA: 0x181440C40
	|-ClampedDragger<int>.ProcessMoveEvent
	|
	|-RVA: 0x1440AC0 Offset: 0x143F4C0 VA: 0x181440AC0
	|-ClampedDragger<float>.ProcessMoveEvent
	|
	|-RVA: 0x1440900 Offset: 0x143F300 VA: 0x181440900
	|-ClampedDragger<__Il2CppFullySharedGenericType>.ProcessMoveEvent
	*/
}

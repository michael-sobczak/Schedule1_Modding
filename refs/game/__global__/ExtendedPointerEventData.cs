public class ExtendedPointerEventData : PointerEventData // TypeDefIndex: 7510
{
	// Fields
	[CompilerGenerated]
	private InputControl <control>k__BackingField; // 0x180
	[CompilerGenerated]
	private InputDevice <device>k__BackingField; // 0x188
	[CompilerGenerated]
	private int <touchId>k__BackingField; // 0x190
	[CompilerGenerated]
	private UIPointerType <pointerType>k__BackingField; // 0x194
	[CompilerGenerated]
	private int <uiToolkitPointerId>k__BackingField; // 0x198
	[CompilerGenerated]
	private Vector3 <trackedDevicePosition>k__BackingField; // 0x19C
	[CompilerGenerated]
	private Quaternion <trackedDeviceOrientation>k__BackingField; // 0x1A8

	// Properties
	public InputControl control { get; set; }
	public InputDevice device { get; set; }
	public int touchId { get; set; }
	public UIPointerType pointerType { get; set; }
	public int uiToolkitPointerId { get; set; }
	public Vector3 trackedDevicePosition { get; set; }
	public Quaternion trackedDeviceOrientation { get; set; }

	// Methods

	// RVA: 0x283FB00 Offset: 0x283E500 VA: 0x18283FB00
	public void .ctor(EventSystem eventSystem) { }

	[CompilerGenerated]
	// RVA: 0x73B370 Offset: 0x739D70 VA: 0x18073B370
	public InputControl get_control() { }

	[CompilerGenerated]
	// RVA: 0x73B4D0 Offset: 0x739ED0 VA: 0x18073B4D0
	public void set_control(InputControl value) { }

	[CompilerGenerated]
	// RVA: 0x73B380 Offset: 0x739D80 VA: 0x18073B380
	public InputDevice get_device() { }

	[CompilerGenerated]
	// RVA: 0x73B4F0 Offset: 0x739EF0 VA: 0x18073B4F0
	public void set_device(InputDevice value) { }

	[CompilerGenerated]
	// RVA: 0xB3D920 Offset: 0xB3C320 VA: 0x180B3D920
	public int get_touchId() { }

	[CompilerGenerated]
	// RVA: 0x1E444F0 Offset: 0x1E42EF0 VA: 0x181E444F0
	public void set_touchId(int value) { }

	[CompilerGenerated]
	// RVA: 0x1E44220 Offset: 0x1E42C20 VA: 0x181E44220
	public UIPointerType get_pointerType() { }

	[CompilerGenerated]
	// RVA: 0x1E44A40 Offset: 0x1E43440 VA: 0x181E44A40
	public void set_pointerType(UIPointerType value) { }

	[CompilerGenerated]
	// RVA: 0x2249420 Offset: 0x2247E20 VA: 0x182249420
	public int get_uiToolkitPointerId() { }

	[CompilerGenerated]
	// RVA: 0x283FB70 Offset: 0x283E570 VA: 0x18283FB70
	public void set_uiToolkitPointerId(int value) { }

	[CompilerGenerated]
	// RVA: 0x283FB20 Offset: 0x283E520 VA: 0x18283FB20
	public Vector3 get_trackedDevicePosition() { }

	[CompilerGenerated]
	// RVA: 0x283FB50 Offset: 0x283E550 VA: 0x18283FB50
	public void set_trackedDevicePosition(Vector3 value) { }

	[CompilerGenerated]
	// RVA: 0x283FB10 Offset: 0x283E510 VA: 0x18283FB10
	public Quaternion get_trackedDeviceOrientation() { }

	[CompilerGenerated]
	// RVA: 0x283FB40 Offset: 0x283E540 VA: 0x18283FB40
	public void set_trackedDeviceOrientation(Quaternion value) { }

	// RVA: 0x283F5F0 Offset: 0x283DFF0 VA: 0x18283F5F0 Slot: 3
	public override string ToString() { }

	// RVA: 0x283F280 Offset: 0x283DC80 VA: 0x18283F280
	internal static int MakePointerIdForTouch(int deviceId, int touchId) { }

	// RVA: 0xE45B00 Offset: 0xE44500 VA: 0x180E45B00
	internal static int TouchIdFromPointerId(int pointerId) { }

	// RVA: 0x283F290 Offset: 0x283DC90 VA: 0x18283F290
	internal void ReadDeviceState() { }

	// RVA: 0x283EF70 Offset: 0x283D970 VA: 0x18283EF70
	private static int GetPenPointerId(Pen pen) { }

	// RVA: 0x283F180 Offset: 0x283DB80 VA: 0x18283F180
	private static int GetTouchPointerId(TouchControl touchControl) { }
}

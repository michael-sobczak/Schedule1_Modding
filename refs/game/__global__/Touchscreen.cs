public class Touchscreen : Pointer, IInputStateCallbackReceiver, IEventMerger, ICustomDeviceReset // TypeDefIndex: 7421
{
	// Fields
	[CompilerGenerated]
	private TouchControl <primaryTouch>k__BackingField; // 0x1C0
	[CompilerGenerated]
	private ReadOnlyArray<TouchControl> <touches>k__BackingField; // 0x1C8
	private static readonly ProfilerMarker k_TouchscreenUpdateMarker; // 0x0
	private static readonly ProfilerMarker k_TouchAllocateMarker; // 0x8
	[CompilerGenerated]
	private static Touchscreen <current>k__BackingField; // 0x10
	internal static float s_TapTime; // 0x18
	internal static float s_TapDelayTime; // 0x1C
	internal static float s_TapRadiusSquared; // 0x20

	// Properties
	public TouchControl primaryTouch { get; set; }
	public ReadOnlyArray<TouchControl> touches { get; set; }
	protected TouchControl[] touchControlArray { get; set; }
	public static Touchscreen current { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x67E980 Offset: 0x67D380 VA: 0x18067E980
	public TouchControl get_primaryTouch() { }

	[CompilerGenerated]
	// RVA: 0x67EAE0 Offset: 0x67D4E0 VA: 0x18067EAE0
	protected void set_primaryTouch(TouchControl value) { }

	[CompilerGenerated]
	// RVA: 0x281DA80 Offset: 0x281C480 VA: 0x18281DA80
	public ReadOnlyArray<TouchControl> get_touches() { }

	[CompilerGenerated]
	// RVA: 0x281DB70 Offset: 0x281C570 VA: 0x18281DB70
	protected void set_touches(ReadOnlyArray<TouchControl> value) { }

	// RVA: 0x726430 Offset: 0x724E30 VA: 0x180726430
	protected TouchControl[] get_touchControlArray() { }

	// RVA: 0x281DB00 Offset: 0x281C500 VA: 0x18281DB00
	protected void set_touchControlArray(TouchControl[] value) { }

	[CompilerGenerated]
	// RVA: 0x281DA30 Offset: 0x281C430 VA: 0x18281DA30
	public static Touchscreen get_current() { }

	[CompilerGenerated]
	// RVA: 0x281DA90 Offset: 0x281C490 VA: 0x18281DA90
	internal static void set_current(Touchscreen value) { }

	// RVA: 0x281C230 Offset: 0x281AC30 VA: 0x18281C230 Slot: 17
	public override void MakeCurrent() { }

	// RVA: 0x281C7E0 Offset: 0x281B1E0 VA: 0x18281C7E0 Slot: 19
	protected override void OnRemoved() { }

	// RVA: 0x281BE60 Offset: 0x281A860 VA: 0x18281BE60 Slot: 13
	protected override void FinishSetup() { }

	// RVA: 0x281C400 Offset: 0x281AE00 VA: 0x18281C400
	protected void OnNextUpdate() { }

	// RVA: 0x281C8F0 Offset: 0x281B2F0 VA: 0x18281C8F0
	protected void OnStateEvent(InputEventPtr eventPtr) { }

	// RVA: 0x281D970 Offset: 0x281C370 VA: 0x18281D970 Slot: 22
	private void UnityEngine.InputSystem.LowLevel.IInputStateCallbackReceiver.OnNextUpdate() { }

	// RVA: 0x281D980 Offset: 0x281C380 VA: 0x18281D980 Slot: 23
	private void UnityEngine.InputSystem.LowLevel.IInputStateCallbackReceiver.OnStateEvent(InputEventPtr eventPtr) { }

	// RVA: 0x281D6D0 Offset: 0x281C0D0 VA: 0x18281D6D0 Slot: 24
	private bool UnityEngine.InputSystem.LowLevel.IInputStateCallbackReceiver.GetStateOffsetForEvent(InputControl control, InputEventPtr eventPtr, ref uint offset) { }

	// RVA: 0x281D1B0 Offset: 0x281BBB0 VA: 0x18281D1B0 Slot: 26
	private void UnityEngine.InputSystem.LowLevel.ICustomDeviceReset.Reset() { }

	// RVA: 0x281C2E0 Offset: 0x281ACE0 VA: 0x18281C2E0
	internal static bool MergeForward(InputEventPtr currentEventPtr, InputEventPtr nextEventPtr) { }

	// RVA: 0x281D570 Offset: 0x281BF70 VA: 0x18281D570 Slot: 25
	private bool UnityEngine.InputSystem.LowLevel.IEventMerger.MergeForward(InputEventPtr currentEventPtr, InputEventPtr nextEventPtr) { }

	// RVA: 0x281D0F0 Offset: 0x281BAF0 VA: 0x18281D0F0
	private static void TriggerTap(TouchControl control, ref TouchState state, InputEventPtr eventPtr) { }

	// RVA: 0x274A080 Offset: 0x2748A80 VA: 0x18274A080
	public void .ctor() { }

	// RVA: 0x281D990 Offset: 0x281C390 VA: 0x18281D990
	private static void .cctor() { }
}

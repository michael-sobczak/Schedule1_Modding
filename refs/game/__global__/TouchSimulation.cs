public class TouchSimulation : MonoBehaviour, IInputStateChangeMonitor // TypeDefIndex: 7578
{
	// Fields
	[CompilerGenerated]
	private Touchscreen <simulatedTouchscreen>k__BackingField; // 0x20
	private int m_NumPointers; // 0x28
	private Pointer[] m_Pointers; // 0x30
	private Vector2[] m_CurrentPositions; // 0x38
	private int[] m_CurrentDisplayIndices; // 0x40
	private ButtonControl[] m_Touches; // 0x48
	private int[] m_TouchIds; // 0x50
	private int m_LastTouchId; // 0x58
	private Action<InputDevice, InputDeviceChange> m_OnDeviceChange; // 0x60
	private Action<InputEventPtr, InputDevice> m_OnEvent; // 0x68
	internal static TouchSimulation s_Instance; // 0x0

	// Properties
	public Touchscreen simulatedTouchscreen { get; set; }
	public static TouchSimulation instance { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	public Touchscreen get_simulatedTouchscreen() { }

	[CompilerGenerated]
	// RVA: 0x43EFF0 Offset: 0x43D9F0 VA: 0x18043EFF0
	private void set_simulatedTouchscreen(Touchscreen value) { }

	// RVA: 0x2867B70 Offset: 0x2866570 VA: 0x182867B70
	public static TouchSimulation get_instance() { }

	// RVA: 0x2866790 Offset: 0x2865190 VA: 0x182866790
	public static void Enable() { }

	// RVA: 0x28666C0 Offset: 0x28650C0 VA: 0x1828666C0
	public static void Disable() { }

	// RVA: 0x28665D0 Offset: 0x2864FD0 VA: 0x1828665D0
	public static void Destroy() { }

	// RVA: 0x2866480 Offset: 0x2864E80 VA: 0x182866480
	protected void AddPointer(Pointer pointer) { }

	// RVA: 0x28676F0 Offset: 0x28660F0 VA: 0x1828676F0
	protected void RemovePointer(Pointer pointer) { }

	// RVA: 0x28670D0 Offset: 0x2865AD0 VA: 0x1828670D0
	private void OnEvent(InputEventPtr eventPtr, InputDevice device) { }

	// RVA: 0x2866940 Offset: 0x2865340 VA: 0x182866940
	private void OnDeviceChange(InputDevice device, InputDeviceChange change) { }

	// RVA: 0x2866CC0 Offset: 0x28656C0 VA: 0x182866CC0
	protected void OnEnable() { }

	// RVA: 0x2866B50 Offset: 0x2865550 VA: 0x182866B50
	protected void OnDisable() { }

	// RVA: 0x28678E0 Offset: 0x28662E0 VA: 0x1828678E0
	private void UpdateTouch(int touchIndex, int pointerIndex, TouchPhase phase, InputEventPtr eventPtr) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 4
	private void UnityEngine.InputSystem.LowLevel.IInputStateChangeMonitor.NotifyControlStateChanged(InputControl control, double time, InputEventPtr eventPtr, long monitorIndex) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 5
	private void UnityEngine.InputSystem.LowLevel.IInputStateChangeMonitor.NotifyTimerExpired(InputControl control, double time, long monitorIndex, int timerIndex) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	protected void InstallStateChangeMonitors(int startIndex = 0) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	protected void OnSourceControlChangedValue(InputControl control, double time, InputEventPtr eventPtr, long sourceDeviceAndButtonIndex) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	protected void UninstallStateChangeMonitors(int startIndex = 0) { }

	// RVA: 0x43CCF0 Offset: 0x43B6F0 VA: 0x18043CCF0
	public void .ctor() { }
}

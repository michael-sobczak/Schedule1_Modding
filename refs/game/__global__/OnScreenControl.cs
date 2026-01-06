public abstract class OnScreenControl : MonoBehaviour // TypeDefIndex: 7543
{
	// Fields
	private InputControl m_Control; // 0x20
	private OnScreenControl m_NextControlOnDevice; // 0x28
	private InputEventPtr m_InputEventPtr; // 0x30
	private static int s_nbActiveInstances; // 0x0
	private static InlinedArray<OnScreenControl.OnScreenDeviceInfo> s_OnScreenDevices; // 0x8

	// Properties
	public string controlPath { get; set; }
	public InputControl control { get; }
	protected abstract string controlPathInternal { get; set; }
	internal static bool HasAnyActive { get; }

	// Methods

	// RVA: 0x1C842D0 Offset: 0x1C82CD0 VA: 0x181C842D0
	public string get_controlPath() { }

	// RVA: 0x284BC90 Offset: 0x284A690 VA: 0x18284BC90
	public void set_controlPath(string value) { }

	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	public InputControl get_control() { }

	// RVA: -1 Offset: -1 Slot: 4
	protected abstract string get_controlPathInternal();

	// RVA: -1 Offset: -1 Slot: 5
	protected abstract void set_controlPathInternal(string value);

	// RVA: 0x284B370 Offset: 0x2849D70 VA: 0x18284B370
	private void SetupInputControl() { }

	// RVA: -1 Offset: -1
	protected void SendValueToControl<TValue>(TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF1AE50 Offset: 0xF19850 VA: 0x180F1AE50
	|-OnScreenControl.SendValueToControl<float>
	|
	|-RVA: 0xF1B140 Offset: 0xF19B40 VA: 0x180F1B140
	|-OnScreenControl.SendValueToControl<Vector2>
	|
	|-RVA: 0xF1AB00 Offset: 0xF19500 VA: 0x180F1AB00
	|-OnScreenControl.SendValueToControl<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: 0x284B2B0 Offset: 0x2849CB0 VA: 0x18284B2B0
	protected void SentDefaultValueToControl() { }

	// RVA: 0x284BC50 Offset: 0x284A650 VA: 0x18284BC50
	internal static bool get_HasAnyActive() { }

	// RVA: 0x284AFD0 Offset: 0x28499D0 VA: 0x18284AFD0 Slot: 6
	protected virtual void OnEnable() { }

	// RVA: 0x284AD20 Offset: 0x2849720 VA: 0x18284AD20 Slot: 7
	protected virtual void OnDisable() { }

	// RVA: 0x284ACD0 Offset: 0x28496D0 VA: 0x18284ACD0
	internal string GetWarningMessage() { }

	// RVA: 0x43CCF0 Offset: 0x43B6F0 VA: 0x18043CCF0
	protected void .ctor() { }
}

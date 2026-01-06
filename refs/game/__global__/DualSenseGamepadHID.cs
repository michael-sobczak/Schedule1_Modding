public class DualSenseGamepadHID : DualShockGamepad, IEventMerger, IEventPreProcessor, IInputStateCallbackReceiver // TypeDefIndex: 7584
{
	// Fields
	[CompilerGenerated]
	private ButtonControl <leftTriggerButton>k__BackingField; // 0x288
	[CompilerGenerated]
	private ButtonControl <rightTriggerButton>k__BackingField; // 0x290
	[CompilerGenerated]
	private ButtonControl <playStationButton>k__BackingField; // 0x298
	private Nullable<float> m_LowFrequencyMotorSpeed; // 0x2A0
	private Nullable<float> m_HighFrequenceyMotorSpeed; // 0x2A8
	protected Nullable<Color> m_LightBarColor; // 0x2B0
	private byte outputSequenceId; // 0x2C4
	internal const byte JitterMaskLow = 120;
	internal const byte JitterMaskHigh = 135;

	// Properties
	public ButtonControl leftTriggerButton { get; set; }
	public ButtonControl rightTriggerButton { get; set; }
	public ButtonControl playStationButton { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x860AD0 Offset: 0x85F4D0 VA: 0x180860AD0
	public ButtonControl get_leftTriggerButton() { }

	[CompilerGenerated]
	// RVA: 0xA141E0 Offset: 0xA12BE0 VA: 0x180A141E0
	protected void set_leftTriggerButton(ButtonControl value) { }

	[CompilerGenerated]
	// RVA: 0x860A10 Offset: 0x85F410 VA: 0x180860A10
	public ButtonControl get_rightTriggerButton() { }

	[CompilerGenerated]
	// RVA: 0xA14220 Offset: 0xA12C20 VA: 0x180A14220
	protected void set_rightTriggerButton(ButtonControl value) { }

	[CompilerGenerated]
	// RVA: 0x8793C0 Offset: 0x877DC0 VA: 0x1808793C0
	public ButtonControl get_playStationButton() { }

	[CompilerGenerated]
	// RVA: 0x879420 Offset: 0x877E20 VA: 0x180879420
	protected void set_playStationButton(ButtonControl value) { }

	// RVA: 0x2854E40 Offset: 0x2853840 VA: 0x182854E40 Slot: 13
	protected override void FinishSetup() { }

	// RVA: 0x28551B0 Offset: 0x2853BB0 VA: 0x1828551B0 Slot: 26
	public override void PauseHaptics() { }

	// RVA: 0x2855270 Offset: 0x2853C70 VA: 0x182855270 Slot: 28
	public override void ResetHaptics() { }

	// RVA: 0x2855300 Offset: 0x2853D00 VA: 0x182855300 Slot: 27
	public override void ResumeHaptics() { }

	// RVA: 0x2855380 Offset: 0x2853D80 VA: 0x182855380 Slot: 31
	public override void SetLightBarColor(Color color) { }

	// RVA: 0x2855770 Offset: 0x2854170 VA: 0x182855770 Slot: 29
	public override void SetMotorSpeeds(float lowFrequency, float highFrequency) { }

	// RVA: 0x2855430 Offset: 0x2853E30 VA: 0x182855430
	public bool SetMotorSpeedsAndLightBarColor(Nullable<float> lowFrequency, Nullable<float> highFrequency, Nullable<Color> color) { }

	// RVA: 0x2854F20 Offset: 0x2853920 VA: 0x182854F20
	private static bool MergeForward(DualSenseGamepadHID.DualSenseHIDUSBInputReport* currentState, DualSenseGamepadHID.DualSenseHIDUSBInputReport* nextState) { }

	// RVA: 0x2854F60 Offset: 0x2853960 VA: 0x182854F60
	private static bool MergeForward(DualSenseGamepadHID.DualSenseHIDBluetoothInputReport* currentState, DualSenseGamepadHID.DualSenseHIDBluetoothInputReport* nextState) { }

	// RVA: 0x2854FA0 Offset: 0x28539A0 VA: 0x182854FA0
	private static bool MergeForward(DualSenseGamepadHID.DualSenseHIDMinimalInputReport* currentState, DualSenseGamepadHID.DualSenseHIDMinimalInputReport* nextState) { }

	// RVA: 0x2855850 Offset: 0x2854250 VA: 0x182855850 Slot: 32
	private bool UnityEngine.InputSystem.LowLevel.IEventMerger.MergeForward(InputEventPtr currentEventPtr, InputEventPtr nextEventPtr) { }

	// RVA: 0x2855B10 Offset: 0x2854510 VA: 0x182855B10 Slot: 33
	private bool UnityEngine.InputSystem.LowLevel.IEventPreProcessor.PreProcessEvent(InputEventPtr eventPtr) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 34
	public void OnNextUpdate() { }

	// RVA: 0x2854FE0 Offset: 0x28539E0 VA: 0x182854FE0 Slot: 35
	public void OnStateEvent(InputEventPtr eventPtr) { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 36
	public bool GetStateOffsetForEvent(InputControl control, InputEventPtr eventPtr, ref uint offset) { }

	// RVA: 0x275AB30 Offset: 0x2759530 VA: 0x18275AB30
	public void .ctor() { }
}

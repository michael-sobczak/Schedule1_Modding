public class DualShock4GamepadHID : DualShockGamepad, IEventPreProcessor, IInputStateCallbackReceiver // TypeDefIndex: 7586
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
	private Nullable<Color> m_LightBarColor; // 0x2B0
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

	// RVA: 0x28562F0 Offset: 0x2854CF0 VA: 0x1828562F0 Slot: 13
	protected override void FinishSetup() { }

	// RVA: 0x28565A0 Offset: 0x2854FA0 VA: 0x1828565A0 Slot: 26
	public override void PauseHaptics() { }

	// RVA: 0x2856720 Offset: 0x2855120 VA: 0x182856720 Slot: 28
	public override void ResetHaptics() { }

	// RVA: 0x28568C0 Offset: 0x28552C0 VA: 0x1828568C0 Slot: 27
	public override void ResumeHaptics() { }

	// RVA: 0x2856B40 Offset: 0x2855540 VA: 0x182856B40 Slot: 31
	public override void SetLightBarColor(Color color) { }

	// RVA: 0x2856FB0 Offset: 0x28559B0 VA: 0x182856FB0 Slot: 29
	public override void SetMotorSpeeds(float lowFrequency, float highFrequency) { }

	// RVA: 0x2856D10 Offset: 0x2855710 VA: 0x182856D10
	public bool SetMotorSpeedsAndLightBarColor(float lowFrequency, float highFrequency, Color color) { }

	// RVA: 0x2857180 Offset: 0x2855B80 VA: 0x182857180 Slot: 32
	private bool UnityEngine.InputSystem.LowLevel.IEventPreProcessor.PreProcessEvent(InputEventPtr eventPtr) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 33
	public void OnNextUpdate() { }

	// RVA: 0x28563D0 Offset: 0x2854DD0 VA: 0x1828563D0 Slot: 34
	public void OnStateEvent(InputEventPtr eventPtr) { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 35
	public bool GetStateOffsetForEvent(InputControl control, InputEventPtr eventPtr, ref uint offset) { }

	// RVA: 0x275AB30 Offset: 0x2759530 VA: 0x18275AB30
	public void .ctor() { }
}

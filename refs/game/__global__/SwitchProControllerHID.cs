public class SwitchProControllerHID : Gamepad, IInputStateCallbackReceiver, IEventPreProcessor // TypeDefIndex: 7537
{
	// Fields
	[CompilerGenerated]
	private ButtonControl <captureButton>k__BackingField; // 0x210
	[CompilerGenerated]
	private ButtonControl <homeButton>k__BackingField; // 0x218
	private static readonly SwitchProControllerHID.SwitchMagicOutputReport.CommandIdType[] s_HandshakeSequence; // 0x0
	private int m_HandshakeStepIndex; // 0x220
	private double m_HandshakeTimer; // 0x228
	internal const byte JitterMaskLow = 120;
	internal const byte JitterMaskHigh = 135;

	// Properties
	[InputControl(name = "capture", displayName = "Capture")]
	public ButtonControl captureButton { get; set; }
	[InputControl(name = "home", displayName = "Home")]
	public ButtonControl homeButton { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x640D80 Offset: 0x63F780 VA: 0x180640D80
	public ButtonControl get_captureButton() { }

	[CompilerGenerated]
	// RVA: 0x9CAFC0 Offset: 0x9C99C0 VA: 0x1809CAFC0
	protected void set_captureButton(ButtonControl value) { }

	[CompilerGenerated]
	// RVA: 0x640D70 Offset: 0x63F770 VA: 0x180640D70
	public ButtonControl get_homeButton() { }

	[CompilerGenerated]
	// RVA: 0x6413A0 Offset: 0x63FDA0 VA: 0x1806413A0
	protected void set_homeButton(ButtonControl value) { }

	// RVA: 0x284F500 Offset: 0x284DF00 VA: 0x18284F500 Slot: 18
	protected override void OnAdded() { }

	// RVA: 0x284F100 Offset: 0x284DB00 VA: 0x18284F100
	private void HandshakeRestart() { }

	// RVA: 0x284F180 Offset: 0x284DB80 VA: 0x18284F180
	private void HandshakeTick() { }

	// RVA: 0x284F610 Offset: 0x284E010 VA: 0x18284F610 Slot: 30
	public void OnNextUpdate() { }

	// RVA: 0x284F620 Offset: 0x284E020 VA: 0x18284F620 Slot: 31
	public void OnStateEvent(InputEventPtr eventPtr) { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 32
	public bool GetStateOffsetForEvent(InputControl control, InputEventPtr eventPtr, ref uint offset) { }

	// RVA: 0x284F7B0 Offset: 0x284E1B0 VA: 0x18284F7B0 Slot: 33
	public bool PreProcessEvent(InputEventPtr eventPtr) { }

	// RVA: 0x275AB30 Offset: 0x2759530 VA: 0x18275AB30
	public void .ctor() { }

	// RVA: 0x284FA00 Offset: 0x284E400 VA: 0x18284FA00
	private static void .cctor() { }
}

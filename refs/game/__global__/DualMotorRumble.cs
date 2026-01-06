internal struct DualMotorRumble // TypeDefIndex: 7603
{
	// Fields
	[CompilerGenerated]
	private float <lowFrequencyMotorSpeed>k__BackingField; // 0x0
	[CompilerGenerated]
	private float <highFrequencyMotorSpeed>k__BackingField; // 0x4

	// Properties
	public float lowFrequencyMotorSpeed { get; set; }
	public float highFrequencyMotorSpeed { get; set; }
	public bool isRumbling { get; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x474780 Offset: 0x473180 VA: 0x180474780
	public float get_lowFrequencyMotorSpeed() { }

	[CompilerGenerated]
	// RVA: 0x4D53B0 Offset: 0x4D3DB0 VA: 0x1804D53B0
	private void set_lowFrequencyMotorSpeed(float value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x474770 Offset: 0x473170 VA: 0x180474770
	public float get_highFrequencyMotorSpeed() { }

	[CompilerGenerated]
	// RVA: 0x4D5390 Offset: 0x4D3D90 VA: 0x1804D5390
	private void set_highFrequencyMotorSpeed(float value) { }

	// RVA: 0x2854E00 Offset: 0x2853800 VA: 0x182854E00
	public bool get_isRumbling() { }

	// RVA: 0x2854A00 Offset: 0x2853400 VA: 0x182854A00
	public void PauseHaptics(InputDevice device) { }

	// RVA: 0x2854BE0 Offset: 0x28535E0 VA: 0x182854BE0
	public void ResumeHaptics(InputDevice device) { }

	// RVA: 0x2854B30 Offset: 0x2853530 VA: 0x182854B30
	public void ResetHaptics(InputDevice device) { }

	// RVA: 0x2854C90 Offset: 0x2853690 VA: 0x182854C90
	public void SetMotorSpeeds(InputDevice device, float lowFrequency, float highFrequency) { }
}

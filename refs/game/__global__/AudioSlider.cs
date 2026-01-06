public class AudioSlider : SettingsSlider // TypeDefIndex: 2752
{
	// Fields
	public const float MULTIPLIER = 0.01;
	public bool Master; // 0x40
	public EAudioType AudioType; // 0x44

	// Methods

	// RVA: 0x924D60 Offset: 0x923760 VA: 0x180924D60 Slot: 8
	protected virtual void Start() { }

	// RVA: 0x924A30 Offset: 0x923430 VA: 0x180924A30 Slot: 6
	protected override void OnValueChanged(float value) { }

	// RVA: 0x924EA0 Offset: 0x9238A0 VA: 0x180924EA0
	public void .ctor() { }
}

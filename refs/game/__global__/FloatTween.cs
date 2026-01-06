internal struct FloatTween : ITweenValue // TypeDefIndex: 16508
{
	// Fields
	private FloatTween.FloatTweenCallback m_Target; // 0x0
	private float m_StartValue; // 0x8
	private float m_TargetValue; // 0xC
	private float m_Duration; // 0x10
	private bool m_IgnoreTimeScale; // 0x14

	// Properties
	public float startValue { get; set; }
	public float targetValue { get; set; }
	public float duration { get; set; }
	public bool ignoreTimeScale { get; set; }

	// Methods

	// RVA: 0x4747A0 Offset: 0x4731A0 VA: 0x1804747A0
	public float get_startValue() { }

	// RVA: 0x4D53A0 Offset: 0x4D3DA0 VA: 0x1804D53A0
	public void set_startValue(float value) { }

	// RVA: 0x474790 Offset: 0x473190 VA: 0x180474790
	public float get_targetValue() { }

	// RVA: 0x4D5380 Offset: 0x4D3D80 VA: 0x1804D5380
	public void set_targetValue(float value) { }

	// RVA: 0x4747B0 Offset: 0x4731B0 VA: 0x1804747B0 Slot: 6
	public float get_duration() { }

	// RVA: 0x4944E0 Offset: 0x492EE0 VA: 0x1804944E0
	public void set_duration(float value) { }

	// RVA: 0x60D730 Offset: 0x60C130 VA: 0x18060D730 Slot: 5
	public bool get_ignoreTimeScale() { }

	// RVA: 0x60D740 Offset: 0x60C140 VA: 0x18060D740
	public void set_ignoreTimeScale(bool value) { }

	// RVA: 0x2F4A370 Offset: 0x2F48D70 VA: 0x182F4A370 Slot: 4
	public void TweenValue(float floatPercentage) { }

	// RVA: 0x2F4A2B0 Offset: 0x2F48CB0 VA: 0x182F4A2B0
	public void AddOnChangedCallback(UnityAction<float> callback) { }

	// RVA: 0x60D730 Offset: 0x60C130 VA: 0x18060D730
	public bool GetIgnoreTimescale() { }

	// RVA: 0x4747B0 Offset: 0x4731B0 VA: 0x1804747B0
	public float GetDuration() { }

	// RVA: 0x1CD57E0 Offset: 0x1CD41E0 VA: 0x181CD57E0 Slot: 7
	public bool ValidTarget() { }
}

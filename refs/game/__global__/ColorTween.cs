internal struct ColorTween : ITweenValue // TypeDefIndex: 16506
{
	// Fields
	private ColorTween.ColorTweenCallback m_Target; // 0x0
	private Color m_StartColor; // 0x8
	private Color m_TargetColor; // 0x18
	private ColorTween.ColorTweenMode m_TweenMode; // 0x28
	private float m_Duration; // 0x2C
	private bool m_IgnoreTimeScale; // 0x30

	// Properties
	public Color startColor { get; set; }
	public Color targetColor { get; set; }
	public ColorTween.ColorTweenMode tweenMode { get; set; }
	public float duration { get; set; }
	public bool ignoreTimeScale { get; set; }

	// Methods

	// RVA: 0x46EE40 Offset: 0x46D840 VA: 0x18046EE40
	public Color get_startColor() { }

	// RVA: 0x1C2E7D0 Offset: 0x1C2D1D0 VA: 0x181C2E7D0
	public void set_startColor(Color value) { }

	// RVA: 0x526100 Offset: 0x524B00 VA: 0x180526100
	public Color get_targetColor() { }

	// RVA: 0x691670 Offset: 0x690070 VA: 0x180691670
	public void set_targetColor(Color value) { }

	// RVA: 0x494430 Offset: 0x492E30 VA: 0x180494430
	public ColorTween.ColorTweenMode get_tweenMode() { }

	// RVA: 0x494480 Offset: 0x492E80 VA: 0x180494480
	public void set_tweenMode(ColorTween.ColorTweenMode value) { }

	// RVA: 0x4971C0 Offset: 0x495BC0 VA: 0x1804971C0 Slot: 6
	public float get_duration() { }

	// RVA: 0x5A9D40 Offset: 0x5A8740 VA: 0x1805A9D40
	public void set_duration(float value) { }

	// RVA: 0x498810 Offset: 0x497210 VA: 0x180498810 Slot: 5
	public bool get_ignoreTimeScale() { }

	// RVA: 0x4CEB50 Offset: 0x4CD550 VA: 0x1804CEB50
	public void set_ignoreTimeScale(bool value) { }

	// RVA: 0x2F46160 Offset: 0x2F44B60 VA: 0x182F46160 Slot: 4
	public void TweenValue(float floatPercentage) { }

	// RVA: 0x2F460A0 Offset: 0x2F44AA0 VA: 0x182F460A0
	public void AddOnChangedCallback(UnityAction<Color> callback) { }

	// RVA: 0x498810 Offset: 0x497210 VA: 0x180498810
	public bool GetIgnoreTimescale() { }

	// RVA: 0x4971C0 Offset: 0x495BC0 VA: 0x1804971C0
	public float GetDuration() { }

	// RVA: 0x1CD57E0 Offset: 0x1CD41E0 VA: 0x181CD57E0 Slot: 7
	public bool ValidTarget() { }
}

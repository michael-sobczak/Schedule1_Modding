public abstract class ScalingModule : CGModule // TypeDefIndex: 10697
{
	// Fields
	[Tooltip("What type of scaling should be applied")]
	[Tab("Scale", Sort = 101)]
	[Label("Mode", "")]
	[SerializeField]
	private ScaleMode m_ScaleMode; // 0xC0
	[SerializeField]
	[Label("Reference", "")]
	[Tooltip("Determines on what range the scale is applied:
Self: the scale is applied over the Path's active range
Source: the scale is applied over the Path's total length")]
	[FieldCondition("m_ScaleMode", 1, False, 0, null, 1)]
	private CGReferenceMode m_ScaleReference; // 0xC4
	[SerializeField]
	[Label("Offset", "")]
	[Tooltip("Scale is applied starting at this offset")]
	[FieldCondition("m_ScaleMode", 1, False, 0, null, 1)]
	private float m_ScaleOffset; // 0xC8
	[Tooltip("If enabled, the same scale is applied to both X and Y axis of the cross section")]
	[SerializeField]
	[Label("Uniform Scaling", "")]
	private bool m_ScaleUniform; // 0xCC
	[SerializeField]
	[Tooltip("The (base) value of the scaling along the cross section's X axis, and Y axis if Uniform Scaling is disabled")]
	private float m_ScaleX; // 0xD0
	[Tooltip("Defines scale multiplier, depending on the Relative Distance (between 0 and 1) of a point on the path")]
	[SerializeField]
	[FieldCondition("m_ScaleMode", 1, False, 0, null, 1)]
	[AnimationCurveEx("    Multiplier", "")]
	private AnimationCurve m_ScaleCurveX; // 0xD8
	[SerializeField]
	[FieldCondition("m_ScaleUniform", False, False, 0, null, 1)]
	[Tooltip("The (base) value of the scaling along the cross section's Y axis")]
	private float m_ScaleY; // 0xE0
	[FieldCondition("m_ScaleUniform", False, False, 0, "m_ScaleMode", 1, False)]
	[AnimationCurveEx("    Multiplier", "")]
	[Tooltip("Defines scale multiplier, depending on the Relative Distance (between 0 and 1) of a point on the path")]
	[SerializeField]
	private AnimationCurve m_ScaleCurveY; // 0xE8

	// Properties
	public ScaleMode ScaleMode { get; set; }
	public CGReferenceMode ScaleReference { get; set; }
	public bool ScaleUniform { get; set; }
	public float ScaleOffset { get; set; }
	public float ScaleX { get; set; }
	public AnimationCurve ScaleMultiplierX { get; set; }
	public float ScaleY { get; set; }
	public AnimationCurve ScaleMultiplierY { get; set; }

	// Methods

	// RVA: 0x505900 Offset: 0x504300 VA: 0x180505900
	public ScaleMode get_ScaleMode() { }

	// RVA: 0x527000 Offset: 0x525A00 VA: 0x180527000
	public void set_ScaleMode(ScaleMode value) { }

	// RVA: 0x526FE0 Offset: 0x5259E0 VA: 0x180526FE0
	public CGReferenceMode get_ScaleReference() { }

	// RVA: 0x5270D0 Offset: 0x525AD0 VA: 0x1805270D0
	public void set_ScaleReference(CGReferenceMode value) { }

	// RVA: 0x526FF0 Offset: 0x5259F0 VA: 0x180526FF0
	public bool get_ScaleUniform() { }

	// RVA: 0x5270F0 Offset: 0x525AF0 VA: 0x1805270F0
	public void set_ScaleUniform(bool value) { }

	// RVA: 0x526FD0 Offset: 0x5259D0 VA: 0x180526FD0
	public float get_ScaleOffset() { }

	// RVA: 0x5270A0 Offset: 0x525AA0 VA: 0x1805270A0
	public void set_ScaleOffset(float value) { }

	// RVA: 0x510840 Offset: 0x50F240 VA: 0x180510840
	public float get_ScaleX() { }

	// RVA: 0x527110 Offset: 0x525B10 VA: 0x180527110
	public void set_ScaleX(float value) { }

	// RVA: 0x4E8C90 Offset: 0x4E7690 VA: 0x1804E8C90
	public AnimationCurve get_ScaleMultiplierX() { }

	// RVA: 0x527020 Offset: 0x525A20 VA: 0x180527020
	public void set_ScaleMultiplierX(AnimationCurve value) { }

	// RVA: 0x51E8E0 Offset: 0x51D2E0 VA: 0x18051E8E0
	public float get_ScaleY() { }

	// RVA: 0x51EAB0 Offset: 0x51D4B0 VA: 0x18051EAB0
	public void set_ScaleY(float value) { }

	// RVA: 0x4E8CB0 Offset: 0x4E76B0 VA: 0x1804E8CB0
	public AnimationCurve get_ScaleMultiplierY() { }

	// RVA: 0x527060 Offset: 0x525A60 VA: 0x180527060
	public void set_ScaleMultiplierY(AnimationCurve value) { }

	// RVA: 0x526D90 Offset: 0x525790 VA: 0x180526D90 Slot: 13
	public override void Reset() { }

	// RVA: 0x526C10 Offset: 0x525610 VA: 0x180526C10
	public Vector2 GetScale(float relativeDistance) { }

	// RVA: 0x526A30 Offset: 0x525430 VA: 0x180526A30
	protected Vector2 GetScale(int sampleIndex, SubArray<float> relativeDistances, SubArray<float> sourceRelativeDistances) { }

	// RVA: 0x526930 Offset: 0x525330 VA: 0x180526930
	protected static Vector2 GetScale(float relativeDistance, ScaleMode mode, float offset, bool isUniform, float scaleX, AnimationCurve scaleMultiplierX, float scaleY, AnimationCurve scaleMultiplierY) { }

	// RVA: 0x5268A0 Offset: 0x5252A0 VA: 0x1805268A0
	protected static float GetRelativeDistance(int sampleIndex, CGReferenceMode cgReferenceMode, SubArray<float> relativeDistances, SubArray<float> sourceRelativeDistances) { }

	// RVA: 0x526810 Offset: 0x525210 VA: 0x180526810
	protected static Vector2 GetAdvancedScale(float relativeDistance, float scaleOffset, bool isUniform, float scaleX, AnimationCurve scaleMultiplierX, float scaleY, AnimationCurve scaleMultiplierY) { }

	// RVA: 0x526D60 Offset: 0x525760 VA: 0x180526D60
	protected static Vector2 GetSimpleScale(bool isUniform, float scaleX, float scaleY) { }

	// RVA: 0x526F20 Offset: 0x525920 VA: 0x180526F20
	protected void .ctor() { }
}

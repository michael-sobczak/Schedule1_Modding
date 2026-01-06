public class VolumeController : CurvyController // TypeDefIndex: 10602
{
	// Fields
	private const float CrossPositionRangeMin = -0.5;
	private const float CrossPositionRangeMax = 0.5;
	[SerializeField]
	[CGDataReferenceSelector(typeof(CGVolume), Label = "Volume/Slot")]
	[Section("General", True, False, 100)]
	private CGDataReference m_Volume; // 0xB0
	[SerializeField]
	[Section("Cross Position", True, False, 100, Sort = 1, HelpURL = "https://curvyeditor.com/doclink/volumecontroller_crossposition")]
	[FloatRegion(UseSlider = True, Precision = 4, RegionOptionsPropertyName = "CrossRangeOptions", Options = 1920)]
	private FloatRegion m_CrossRange; // 0xB8
	[RangeEx("MinCrossRelativePosition", "MaxCrossRelativePosition", "", "")]
	[SerializeField]
	private float crossRelativePosition; // 0xC4
	[SerializeField]
	private CurvyClamping m_CrossClamping; // 0xC8
	[Obsolete("Use crossRelativePosition instead. This field is kept for retro compatibility reasons")]
	[UsedImplicitly]
	[HideInInspector]
	[SerializeField]
	private float m_CrossInitialPosition; // 0xCC

	// Properties
	public CGDataReference Volume { get; set; }
	[CanBeNull]
	public CGVolume VolumeData { get; }
	public float CrossFrom { get; set; }
	public float CrossTo { get; set; }
	public float CrossLength { get; }
	public CurvyClamping CrossClamping { get; set; }
	public float CrossRelativePosition { get; set; }
	public override float Length { get; }
	public override bool IsReady { get; }
	private RegionOptions<float> CrossRangeOptions { get; }
	private float MinCrossRelativePosition { get; }
	private float MaxCrossRelativePosition { get; }

	// Methods

	// RVA: 0x4B6150 Offset: 0x4B4B50 VA: 0x1804B6150
	public CGDataReference get_Volume() { }

	// RVA: 0x4B6C80 Offset: 0x4B5680 VA: 0x1804B6C80
	public void set_Volume(CGDataReference value) { }

	// RVA: 0x4F2480 Offset: 0x4F0E80 VA: 0x1804F2480
	public CGVolume get_VolumeData() { }

	// RVA: 0x4F2360 Offset: 0x4F0D60 VA: 0x1804F2360
	public float get_CrossFrom() { }

	// RVA: 0x4F2510 Offset: 0x4F0F10 VA: 0x1804F2510
	public void set_CrossFrom(float value) { }

	// RVA: 0x4F2430 Offset: 0x4F0E30 VA: 0x1804F2430
	public float get_CrossTo() { }

	// RVA: 0x4F2580 Offset: 0x4F0F80 VA: 0x1804F2580
	public void set_CrossTo(float value) { }

	// RVA: 0x4F2370 Offset: 0x4F0D70 VA: 0x1804F2370
	public float get_CrossLength() { }

	// RVA: 0x4F2350 Offset: 0x4F0D50 VA: 0x1804F2350
	public CurvyClamping get_CrossClamping() { }

	// RVA: 0x4F2500 Offset: 0x4F0F00 VA: 0x1804F2500
	public void set_CrossClamping(CurvyClamping value) { }

	// RVA: 0x4F23F0 Offset: 0x4F0DF0 VA: 0x1804F23F0
	public float get_CrossRelativePosition() { }

	// RVA: 0x4F2540 Offset: 0x4F0F40 VA: 0x1804F2540
	public void set_CrossRelativePosition(float value) { }

	// RVA: 0x4F2440 Offset: 0x4F0E40 VA: 0x1804F2440 Slot: 35
	public override float get_Length() { }

	// RVA: 0x4F1A80 Offset: 0x4F0480 VA: 0x1804F1A80
	public float CrossRelativeToAbsolute(float relativeDistance) { }

	// RVA: 0x4F1A00 Offset: 0x4F0400 VA: 0x1804F1A00
	public float CrossAbsoluteToRelative(float worldUnitDistance) { }

	// RVA: 0x4E4B10 Offset: 0x4E3510 VA: 0x1804E4B10 Slot: 11
	public override bool get_IsReady() { }

	// RVA: 0x4F20D0 Offset: 0x4F0AD0 VA: 0x1804F20D0 Slot: 39
	protected override float RelativeToAbsolute(float relativeDistance) { }

	// RVA: 0x4F19A0 Offset: 0x4F03A0 VA: 0x1804F19A0 Slot: 38
	protected override float AbsoluteToRelative(float worldUnitDistance) { }

	// RVA: 0x4F1B30 Offset: 0x4F0530 VA: 0x1804F1B30 Slot: 40
	protected override Vector3 GetInterpolatedSourcePosition(float tf) { }

	// RVA: 0x4F1C50 Offset: 0x4F0650 VA: 0x1804F1C50 Slot: 41
	protected override void GetInterpolatedSourcePosition(float tf, out Vector3 interpolatedPosition, out Vector3 tangent, out Vector3 up) { }

	// RVA: 0x4F1F10 Offset: 0x4F0910 VA: 0x1804F1F10 Slot: 43
	protected override Vector3 GetTangent(float tf) { }

	// RVA: 0x4F1DF0 Offset: 0x4F07F0 VA: 0x1804F1DF0 Slot: 42
	protected override Vector3 GetOrientation(float tf) { }

	// RVA: 0x4E4470 Offset: 0x4E2E70 VA: 0x1804E4470 Slot: 36
	protected override void Advance(float speed, float deltaTime) { }

	// RVA: 0x4F2130 Offset: 0x4F0B30 VA: 0x1804F2130 Slot: 37
	protected override void SimulateAdvance(ref float tf, ref MovementDirection direction, float speed, float deltaTime) { }

	// RVA: 0x4F2380 Offset: 0x4F0D80 VA: 0x1804F2380
	private RegionOptions<float> get_CrossRangeOptions() { }

	// RVA: 0x4F2360 Offset: 0x4F0D60 VA: 0x1804F2360
	private float get_MinCrossRelativePosition() { }

	// RVA: 0x4F2430 Offset: 0x4F0E30 VA: 0x1804F2430
	private float get_MaxCrossRelativePosition() { }

	// RVA: 0x4F1B00 Offset: 0x4F0500 VA: 0x1804F1B00
	private float GetClampedCrossPosition(float position) { }

	// RVA: 0x4F2030 Offset: 0x4F0A30 VA: 0x1804F2030 Slot: 44
	public override void OnAfterDeserialize() { }

	// RVA: 0x4F22A0 Offset: 0x4F0CA0 VA: 0x1804F22A0
	public void .ctor() { }
}

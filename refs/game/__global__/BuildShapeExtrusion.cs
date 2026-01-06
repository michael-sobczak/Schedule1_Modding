public class BuildShapeExtrusion : ScalingModule, IPathProvider // TypeDefIndex: 10703
{
	// Fields
	private const int MinResolution = 1;
	private const int MaxResolution = 100;
	private const float MinAngleThreshold = 0.1;
	private const float MaxAngleThreshold = 120;
	private const int MinShiftValue = 0;
	private const int MaxShiftValue = 1;
	private const int MinHollowInset = 0;
	private const int MaxHollowInset = 1;
	[InputSlotInfo(new[] { typeof(CGPath) }, RequestDataOnly = True)]
	[HideInInspector]
	public CGModuleInputSlot InPath; // 0xF0
	[HideInInspector]
	[InputSlotInfo(new[] { typeof(CGShape) }, Array = True, ArrayType = 2, RequestDataOnly = True)]
	public CGModuleInputSlot InCross; // 0xF8
	[HideInInspector]
	[OutputSlotInfo(typeof(CGVolume))]
	public CGModuleOutputSlot OutVolume; // 0x100
	[HideInInspector]
	[OutputSlotInfo(typeof(CGVolume))]
	public CGModuleOutputSlot OutVolumeHollow; // 0x108
	[Tab("Path")]
	[FloatRegion(UseSlider = True, RegionOptionsPropertyName = "RangeOptions", Precision = 4)]
	[SerializeField]
	private FloatRegion m_Range; // 0x110
	[SerializeField]
	[RangeEx(1, 100, "Resolution", "Defines how densely the path spline's sampling points are. When the value is 100, the number of sampling points per world distance unit is equal to the spline's Max Points Per Unit")]
	private int m_Resolution; // 0x11C
	[SerializeField]
	private bool m_Optimize; // 0x120
	[SerializeField]
	[FieldCondition("m_Optimize", True, False, 0, null, 1)]
	[RangeEx(0.1, 120, "", "", Tooltip = "Max angle")]
	private float m_AngleThreshold; // 0x124
	[FieldAction("CBEditCrossButton", 7, Position = 0)]
	[FloatRegion(UseSlider = True, RegionOptionsPropertyName = "CrossRangeOptions", Precision = 4)]
	[SerializeField]
	[Tab("Cross")]
	private FloatRegion m_CrossRange; // 0x128
	[SerializeField]
	[RangeEx(1, 100, "Resolution", "", Tooltip = "Defines how densely the cross spline's sampling points are. When the value is 100, the number of sampling points per world distance unit is equal to the spline's Max Points Per Unit")]
	private int m_CrossResolution; // 0x134
	[Label("Optimize", "")]
	[SerializeField]
	private bool m_CrossOptimize; // 0x138
	[SerializeField]
	[RangeEx(0.1, 120, "Angle Threshold", "", Tooltip = "Max angle")]
	[FieldCondition("m_CrossOptimize", True, False, 0, null, 1)]
	private float m_CrossAngleThreshold; // 0x13C
	[SerializeField]
	[Tooltip("If enabled, vertices are guaranteed to be created for all the Cross shape's Control Points.")]
	[Label("Include CPs", "")]
	private bool m_CrossIncludeControlpoints; // 0x140
	[UsedImplicitly]
	[HideInInspector]
	[Label("Hard Edges", "")]
	[SerializeField]
	[Obsolete("This option is now always assumed to be true")]
	private bool m_CrossHardEdges; // 0x141
	[Obsolete("This option is now always assumed to be true")]
	[Label("Materials", "")]
	[HideInInspector]
	[SerializeField]
	[UsedImplicitly]
	private bool m_CrossMaterials; // 0x142
	[Obsolete("This option is now always assumed to be true")]
	[UsedImplicitly]
	[HideInInspector]
	[Label("Extended UV", "")]
	[SerializeField]
	private bool m_CrossExtendedUV; // 0x143
	[SerializeField]
	[Label("Shift", "", Tooltip = "Defines a shift to be applied on the output volume's cross.
This shift is used when interpolating values (position, normal, ...) along the volume's surface.")]
	private BuildShapeExtrusion.CrossShiftModeEnum m_CrossShiftMode; // 0x144
	[SerializeField]
	[RangeEx(0, 1, "Value", "Shift By", Slider = True)]
	[FieldCondition("m_CrossShiftMode", 2, False, 0, null, 1)]
	private float m_CrossShiftValue; // 0x148
	[Label("Reverse Normal", "Reverse Vertex Normals?")]
	[SerializeField]
	private bool m_CrossReverseNormals; // 0x14C
	[Tab("Hollow", Sort = 102)]
	[RangeEx(0, 1, "", "", Slider = True, Label = "Inset")]
	[SerializeField]
	private float m_HollowInset; // 0x150
	[SerializeField]
	[Label("Reverse Normal", "Reverse Vertex Normals?")]
	private bool m_HollowReverseNormals; // 0x154
	[CompilerGenerated]
	private BuildShapeExtrusion.Statistics <ExtrusionStatistics>k__BackingField; // 0x158

	// Properties
	public float From { get; set; }
	public float To { get; set; }
	public float Length { get; set; }
	public int Resolution { get; set; }
	public bool Optimize { get; set; }
	public float AngleThreshold { get; set; }
	public float CrossFrom { get; set; }
	public float CrossTo { get; set; }
	public float CrossLength { get; set; }
	public int CrossResolution { get; set; }
	public bool CrossOptimize { get; set; }
	public float CrossAngleThreshold { get; set; }
	public bool CrossIncludeControlPoints { get; set; }
	[Obsolete("This option is now always assumed to be true")]
	[UsedImplicitly]
	public bool CrossHardEdges { get; set; }
	[Obsolete("This option is now always assumed to be true")]
	[UsedImplicitly]
	public bool CrossMaterials { get; set; }
	[Obsolete("This option is now always assumed to be true")]
	[UsedImplicitly]
	public bool CrossExtendedUV { get; set; }
	public BuildShapeExtrusion.CrossShiftModeEnum CrossShiftMode { get; set; }
	public float CrossShiftValue { get; set; }
	public bool CrossReverseNormals { get; set; }
	[Obsolete("Use parent class ScalingModule's ScaleMode instead")]
	[UsedImplicitly]
	public BuildShapeExtrusion.ScaleModeEnum ScaleMode { get; set; }
	public float HollowInset { get; set; }
	public bool HollowReverseNormals { get; set; }
	public IExternalInput Cross { get; }
	[Obsolete]
	[UsedImplicitly]
	public Vector3 CrossPosition { get; set; }
	[UsedImplicitly]
	[Obsolete]
	public Quaternion CrossRotation { get; set; }
	public bool PathIsClosed { get; }
	public BuildShapeExtrusion.Statistics ExtrusionStatistics { get; set; }
	private bool ClampPath { get; }
	private bool ClampCross { get; }
	private RegionOptions<float> RangeOptions { get; }
	private RegionOptions<float> CrossRangeOptions { get; }
	[Obsolete("Use ExtrusionStatistics instead")]
	[UsedImplicitly]
	public int PathSamples { get; set; }
	[UsedImplicitly]
	[Obsolete("Use ExtrusionStatistics instead")]
	public int CrossSamples { get; set; }
	[Obsolete("Use ExtrusionStatistics instead")]
	[UsedImplicitly]
	public int CrossGroups { get; set; }

	// Methods

	// RVA: 0x513110 Offset: 0x511B10 VA: 0x180513110
	public float get_From() { }

	// RVA: 0x5137C0 Offset: 0x5121C0 VA: 0x1805137C0
	public void set_From(float value) { }

	// RVA: 0x513360 Offset: 0x511D60 VA: 0x180513360
	public float get_To() { }

	// RVA: 0x5139D0 Offset: 0x5123D0 VA: 0x1805139D0
	public void set_To(float value) { }

	// RVA: 0x513140 Offset: 0x511B40 VA: 0x180513140
	public float get_Length() { }

	// RVA: 0x513890 Offset: 0x512290 VA: 0x180513890
	public void set_Length(float value) { }

	// RVA: 0x513340 Offset: 0x511D40 VA: 0x180513340
	public int get_Resolution() { }

	// RVA: 0x513950 Offset: 0x512350 VA: 0x180513950
	public void set_Resolution(int value) { }

	// RVA: 0x513170 Offset: 0x511B70 VA: 0x180513170
	public bool get_Optimize() { }

	// RVA: 0x5138F0 Offset: 0x5122F0 VA: 0x1805138F0
	public void set_Optimize(bool value) { }

	// RVA: 0x512AC0 Offset: 0x5114C0 VA: 0x180512AC0
	public float get_AngleThreshold() { }

	// RVA: 0x513370 Offset: 0x511D70 VA: 0x180513370
	public void set_AngleThreshold(float value) { }

	// RVA: 0x512C10 Offset: 0x511610 VA: 0x180512C10
	public float get_CrossFrom() { }

	// RVA: 0x513410 Offset: 0x511E10 VA: 0x180513410
	public void set_CrossFrom(float value) { }

	// RVA: 0x513080 Offset: 0x511A80 VA: 0x180513080
	public float get_CrossTo() { }

	// RVA: 0x513720 Offset: 0x512120 VA: 0x180513720
	public void set_CrossTo(float value) { }

	// RVA: 0x512C50 Offset: 0x511650 VA: 0x180512C50
	public float get_CrossLength() { }

	// RVA: 0x5134E0 Offset: 0x511EE0 VA: 0x1805134E0
	public void set_CrossLength(float value) { }

	// RVA: 0x512ED0 Offset: 0x5118D0 VA: 0x180512ED0
	public int get_CrossResolution() { }

	// RVA: 0x5135D0 Offset: 0x511FD0 VA: 0x1805135D0
	public void set_CrossResolution(int value) { }

	// RVA: 0x512C90 Offset: 0x511690 VA: 0x180512C90
	public bool get_CrossOptimize() { }

	// RVA: 0x513560 Offset: 0x511F60 VA: 0x180513560
	public void set_CrossOptimize(bool value) { }

	// RVA: 0x512BF0 Offset: 0x5115F0 VA: 0x180512BF0
	public float get_CrossAngleThreshold() { }

	// RVA: 0x5133B0 Offset: 0x511DB0 VA: 0x1805133B0
	public void set_CrossAngleThreshold(float value) { }

	// RVA: 0x512C40 Offset: 0x511640 VA: 0x180512C40
	public bool get_CrossIncludeControlPoints() { }

	// RVA: 0x5134C0 Offset: 0x511EC0 VA: 0x1805134C0
	public void set_CrossIncludeControlPoints(bool value) { }

	// RVA: 0x512C30 Offset: 0x511630 VA: 0x180512C30
	public bool get_CrossHardEdges() { }

	// RVA: 0x5134A0 Offset: 0x511EA0 VA: 0x1805134A0
	public void set_CrossHardEdges(bool value) { }

	// RVA: 0x512C80 Offset: 0x511680 VA: 0x180512C80
	public bool get_CrossMaterials() { }

	// RVA: 0x513540 Offset: 0x511F40 VA: 0x180513540
	public void set_CrossMaterials(bool value) { }

	// RVA: 0x512C00 Offset: 0x511600 VA: 0x180512C00
	public bool get_CrossExtendedUV() { }

	// RVA: 0x5133F0 Offset: 0x511DF0 VA: 0x1805133F0
	public void set_CrossExtendedUV(bool value) { }

	// RVA: 0x513060 Offset: 0x511A60 VA: 0x180513060
	public BuildShapeExtrusion.CrossShiftModeEnum get_CrossShiftMode() { }

	// RVA: 0x5136B0 Offset: 0x5120B0 VA: 0x1805136B0
	public void set_CrossShiftMode(BuildShapeExtrusion.CrossShiftModeEnum value) { }

	// RVA: 0x513070 Offset: 0x511A70 VA: 0x180513070
	public float get_CrossShiftValue() { }

	// RVA: 0x5136D0 Offset: 0x5120D0 VA: 0x1805136D0
	public void set_CrossShiftValue(float value) { }

	// RVA: 0x512EE0 Offset: 0x5118E0 VA: 0x180512EE0
	public bool get_CrossReverseNormals() { }

	// RVA: 0x513600 Offset: 0x512000 VA: 0x180513600
	public void set_CrossReverseNormals(bool value) { }

	// RVA: 0x513350 Offset: 0x511D50 VA: 0x180513350
	public BuildShapeExtrusion.ScaleModeEnum get_ScaleMode() { }

	// RVA: 0x513980 Offset: 0x512380 VA: 0x180513980
	public void set_ScaleMode(BuildShapeExtrusion.ScaleModeEnum value) { }

	// RVA: 0x513120 Offset: 0x511B20 VA: 0x180513120
	public float get_HollowInset() { }

	// RVA: 0x513830 Offset: 0x512230 VA: 0x180513830
	public void set_HollowInset(float value) { }

	// RVA: 0x513130 Offset: 0x511B30 VA: 0x180513130
	public bool get_HollowReverseNormals() { }

	// RVA: 0x513870 Offset: 0x512270 VA: 0x180513870
	public void set_HollowReverseNormals(bool value) { }

	// RVA: 0x513090 Offset: 0x511A90 VA: 0x180513090
	public IExternalInput get_Cross() { }

	// RVA: 0x512CA0 Offset: 0x5116A0 VA: 0x180512CA0
	public Vector3 get_CrossPosition() { }

	// RVA: 0x513580 Offset: 0x511F80 VA: 0x180513580
	protected void set_CrossPosition(Vector3 value) { }

	// RVA: 0x512EF0 Offset: 0x5118F0 VA: 0x180512EF0
	public Quaternion get_CrossRotation() { }

	// RVA: 0x513620 Offset: 0x512020 VA: 0x180513620
	protected void set_CrossRotation(Quaternion value) { }

	// RVA: 0x513180 Offset: 0x511B80 VA: 0x180513180 Slot: 18
	public bool get_PathIsClosed() { }

	[CompilerGenerated]
	// RVA: 0x5130F0 Offset: 0x511AF0 VA: 0x1805130F0
	public BuildShapeExtrusion.Statistics get_ExtrusionStatistics() { }

	[Obsolete]
	[UsedImplicitly]
	[CompilerGenerated]
	// RVA: 0x5137A0 Offset: 0x5121A0 VA: 0x1805137A0
	public void set_ExtrusionStatistics(BuildShapeExtrusion.Statistics value) { }

	// RVA: 0x512B60 Offset: 0x511560 VA: 0x180512B60
	private bool get_ClampPath() { }

	// RVA: 0x512AD0 Offset: 0x5114D0 VA: 0x180512AD0
	private bool get_ClampCross() { }

	// RVA: 0x513210 Offset: 0x511C10 VA: 0x180513210
	private RegionOptions<float> get_RangeOptions() { }

	// RVA: 0x512DA0 Offset: 0x5117A0 VA: 0x180512DA0
	private RegionOptions<float> get_CrossRangeOptions() { }

	// RVA: 0x510EE0 Offset: 0x50F8E0 VA: 0x180510EE0 Slot: 4
	protected override void OnEnable() { }

	// RVA: 0x512600 Offset: 0x511000 VA: 0x180512600 Slot: 13
	public override void Reset() { }

	// RVA: 0x510F30 Offset: 0x50F930 VA: 0x180510F30 Slot: 14
	public override void Refresh() { }

	[Obsolete("Use parent class ScalingModule's GetScale instead")]
	[UsedImplicitly]
	// RVA: 0x510D50 Offset: 0x50F750 VA: 0x180510D50
	public Vector3 GetScale(float relativeDistance) { }

	// RVA: 0x5125C0 Offset: 0x510FC0 VA: 0x1805125C0 Slot: 5
	protected override void ResetOnEnable() { }

	// RVA: 0x5131F0 Offset: 0x511BF0 VA: 0x1805131F0
	public int get_PathSamples() { }

	// RVA: 0x513910 Offset: 0x512310 VA: 0x180513910
	private void set_PathSamples(int value) { }

	// RVA: 0x513040 Offset: 0x511A40 VA: 0x180513040
	public int get_CrossSamples() { }

	// RVA: 0x513670 Offset: 0x512070 VA: 0x180513670
	private void set_CrossSamples(int value) { }

	// RVA: 0x512C20 Offset: 0x511620 VA: 0x180512C20
	public int get_CrossGroups() { }

	// RVA: 0x513480 Offset: 0x511E80 VA: 0x180513480
	private void set_CrossGroups(int value) { }

	// RVA: 0x512930 Offset: 0x511330 VA: 0x180512930
	public void .ctor() { }
}

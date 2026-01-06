public class BuildRasterizedPath : CGModule, IPathProvider // TypeDefIndex: 10698
{
	// Fields
	private const int MinResolution = 1;
	private const int MaxResolution = 100;
	private const float MinAngleThreshold = 0.1;
	private const float MaxAngleThreshold = 120;
	private const int DefaultResolution = 50;
	private const int DefaultAngleThreshold = 10;
	[InputSlotInfo(new[] { typeof(CGPath) }, Name = "Path", RequestDataOnly = True)]
	[HideInInspector]
	public CGModuleInputSlot InPath; // 0xC0
	[OutputSlotInfo(typeof(CGPath), Name = "Path", DisplayName = "Rasterized Path")]
	[HideInInspector]
	public CGModuleOutputSlot OutPath; // 0xC8
	[FloatRegion(UseSlider = True, RegionOptionsPropertyName = "RangeOptions", Precision = 4)]
	[SerializeField]
	private FloatRegion m_Range; // 0xD0
	[RangeEx(1, 100, "Resolution", "Defines how densely the path spline's sampling points are. When the value is 100, the number of sampling points per world distance unit is equal to the spline's Max Points Per Unit")]
	[SerializeField]
	private int m_Resolution; // 0xDC
	[SerializeField]
	private bool m_Optimize; // 0xE0
	[RangeEx(0.1, 120, "", "")]
	[FieldCondition("m_Optimize", True, False, 0, null, 1)]
	[SerializeField]
	private float m_AngleTreshold; // 0xE4
	[Tooltip("Curvy versions prior to 8.0.0 had a bug in the computation of the rasterization range for closed splines. Enable this value to keep that bugged behaviour if your project depends on it")]
	[Section("Backward Compatibility", False, False, 100)]
	[SerializeField]
	private bool useBuggedRange; // 0xE8

	// Properties
	public float From { get; set; }
	public float To { get; set; }
	public float Length { get; set; }
	public int Resolution { get; set; }
	public bool Optimize { get; set; }
	public float AngleThreshold { get; set; }
	[CanBeNull]
	public CGPath Path { get; }
	public bool PathIsClosed { get; }
	public bool UseBuggedRange { get; set; }
	private bool ClampPath { get; }
	private RegionOptions<float> RangeOptions { get; }

	// Methods

	// RVA: 0x510840 Offset: 0x50F240 VA: 0x180510840
	public float get_From() { }

	// RVA: 0x510B80 Offset: 0x50F580 VA: 0x180510B80
	public void set_From(float value) { }

	// RVA: 0x510B20 Offset: 0x50F520 VA: 0x180510B20
	public float get_To() { }

	// RVA: 0x510C90 Offset: 0x50F690 VA: 0x180510C90
	public void set_To(float value) { }

	// RVA: 0x510850 Offset: 0x50F250 VA: 0x180510850
	public float get_Length() { }

	// RVA: 0x510BD0 Offset: 0x50F5D0 VA: 0x180510BD0
	public void set_Length(float value) { }

	// RVA: 0x510B10 Offset: 0x50F510 VA: 0x180510B10
	public int get_Resolution() { }

	// RVA: 0x510C60 Offset: 0x50F660 VA: 0x180510C60
	public void set_Resolution(int value) { }

	// RVA: 0x510890 Offset: 0x50F290 VA: 0x180510890
	public bool get_Optimize() { }

	// RVA: 0x510C40 Offset: 0x50F640 VA: 0x180510C40
	public void set_Optimize(bool value) { }

	// RVA: 0x510800 Offset: 0x50F200 VA: 0x180510800
	public float get_AngleThreshold() { }

	// RVA: 0x510B40 Offset: 0x50F540 VA: 0x180510B40
	public void set_AngleThreshold(float value) { }

	// RVA: 0x510930 Offset: 0x50F330 VA: 0x180510930
	public CGPath get_Path() { }

	// RVA: 0x5108A0 Offset: 0x50F2A0 VA: 0x1805108A0 Slot: 18
	public bool get_PathIsClosed() { }

	// RVA: 0x510B30 Offset: 0x50F530 VA: 0x180510B30
	public bool get_UseBuggedRange() { }

	// RVA: 0x510D30 Offset: 0x50F730 VA: 0x180510D30
	public void set_UseBuggedRange(bool value) { }

	// RVA: 0x510810 Offset: 0x50F210 VA: 0x180510810
	private bool get_ClampPath() { }

	// RVA: 0x5109E0 Offset: 0x50F3E0 VA: 0x1805109E0
	private RegionOptions<float> get_RangeOptions() { }

	// RVA: 0x5103C0 Offset: 0x50EDC0 VA: 0x1805103C0 Slot: 4
	protected override void OnEnable() { }

	// RVA: 0x510660 Offset: 0x50F060 VA: 0x180510660 Slot: 13
	public override void Reset() { }

	// RVA: 0x510410 Offset: 0x50EE10 VA: 0x180510410 Slot: 14
	public override void Refresh() { }

	// RVA: 0x510720 Offset: 0x50F120 VA: 0x180510720
	public void .ctor() { }
}

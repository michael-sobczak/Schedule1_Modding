public class BuildVolumeSpots : CGModule, ISerializationCallbackReceiver // TypeDefIndex: 10711
{
	// Fields
	private const int MinCrossBase = -1;
	private const int MaxCrossBase = 1;
	private const int MinRange = 0;
	private const int MaxRange = 1;
	[InputSlotInfo(new[] { typeof(CGPath) }, Name = "Path/Volume", DisplayName = "Volume/Rasterized Path")]
	[HideInInspector]
	public CGModuleInputSlot InPath; // 0xC0
	[InputSlotInfo(new[] { typeof(CGBounds) }, Array = True)]
	[HideInInspector]
	public CGModuleInputSlot InBounds; // 0xC8
	[HideInInspector]
	[OutputSlotInfo(typeof(CGSpots))]
	public CGModuleOutputSlot OutSpots; // 0xD0
	[HideInInspector]
	[SerializeField]
	private bool m_WasUpgraded; // 0xD8
	[Tab("General")]
	[Section("Default/General/Volume Path", True, False, 100)]
	[FloatRegion(RegionOptionsPropertyName = "RangeOptions", Precision = 4)]
	[SerializeField]
	private FloatRegion m_Range; // 0xDC
	[Label("Use Volume's Surface", "")]
	[SerializeField]
	[Section("Default/General/Volume Cross", True, False, 100)]
	[FieldCondition("IsInputAVolume", False, True, 0, null, 1)]
	[Tooltip("When the source is a Volume, you can choose if you want to use it's path or the volume")]
	private bool m_UseVolume; // 0xE8
	[SerializeField]
	[RangeEx(-1, 1, "", "")]
	[Tooltip("Shifts the Cross origin value by constant value")]
	private float m_CrossBase; // 0xEC
	[SerializeField]
	[Label("Cross Base Variation", "")]
	[Tooltip("Shifts the Cross origin value by a value that varies along the Volume's length. The Curve's X axis has values between 0 (start of the Range) and 1 (its end)")]
	private AnimationCurve m_CrossCurve; // 0xF0
	[SerializeField]
	[Tooltip("Check to run a dry run without actually creating spots")]
	[Section("Default/General/Advanced Settings", False, False, 100)]
	private bool m_Simulate; // 0xF8
	[SerializeField]
	[Tooltip("Until version 6.3.1, this module had a bug in the computation of the randomized values. Enable this value to keep that bugged behaviour if your project depends on it")]
	private bool m_UseBuggedRNG; // 0xF9
	[Tab("Groups")]
	[ArrayEx(Space = 10)]
	[SerializeField]
	private List<CGBoundsGroup> m_Groups; // 0x100
	[Tooltip("The range of groups that will be placed repetitively along the volume. Groups that are not in this range will be placed only once")]
	[IntRegion(UseSlider = False, RegionOptionsPropertyName = "RepeatingGroupsOptions", Options = 1)]
	[SerializeField]
	private IntRegion m_RepeatingGroups; // 0x108
	[SerializeField]
	private CurvyRepeatingOrderEnum m_RepeatingOrder; // 0x114
	[SerializeField]
	[FieldCondition("ShowFitEnd", True, False, 0, null, 1)]
	[Label("Fits The End", "")]
	[Tooltip("If checked, the last non repeating group is placed exactly at the end of the volume used for spots. If not, the last group is placed at the first available spot, which might leave some space between it and the end of the volume")]
	private bool m_FitEnd; // 0x118
	public CGSpots SimulatedSpots; // 0x120
	private BuildVolumeSpots.EditorData editorData; // 0x128

	// Properties
	public FloatRegion Range { get; set; }
	public bool UseVolume { get; set; }
	public bool Simulate { get; set; }
	public bool UseBuggedRng { get; set; }
	public float CrossBase { get; set; }
	public AnimationCurve CrossCurve { get; set; }
	public List<CGBoundsGroup> Groups { get; set; }
	public CurvyRepeatingOrderEnum RepeatingOrder { get; set; }
	public int FirstRepeating { get; set; }
	public int LastRepeating { get; set; }
	public bool FitEnd { get; set; }
	public int GroupCount { get; }
	[Obsolete("Will become an editor only method")]
	[UsedImplicitly]
	public GUIContent[] BoundsNames { get; }
	[UsedImplicitly]
	[Obsolete]
	public int[] BoundsIndices { get; }
	public int Count { get; }
	private int LastGroupIndex { get; }
	private RegionOptions<float> RangeOptions { get; }
	private RegionOptions<int> RepeatingGroupsOptions { get; }
	private bool ShowFitEnd { get; }

	// Methods

	// RVA: 0x51D4D0 Offset: 0x51BED0 VA: 0x18051D4D0
	public void .ctor() { }

	// RVA: 0x51DAA0 Offset: 0x51C4A0 VA: 0x18051DAA0
	public FloatRegion get_Range() { }

	// RVA: 0x51DDD0 Offset: 0x51C7D0 VA: 0x18051DDD0
	public void set_Range(FloatRegion value) { }

	// RVA: 0x510B30 Offset: 0x50F530 VA: 0x180510B30
	public bool get_UseVolume() { }

	// RVA: 0x510D30 Offset: 0x50F730 VA: 0x180510D30
	public void set_UseVolume(bool value) { }

	// RVA: 0x516240 Offset: 0x514C40 VA: 0x180516240
	public bool get_Simulate() { }

	// RVA: 0x5164A0 Offset: 0x514EA0 VA: 0x1805164A0
	public void set_Simulate(bool value) { }

	// RVA: 0x51DBD0 Offset: 0x51C5D0 VA: 0x18051DBD0
	public bool get_UseBuggedRng() { }

	// RVA: 0x51DE70 Offset: 0x51C870 VA: 0x18051DE70
	public void set_UseBuggedRng(bool value) { }

	// RVA: 0x51D960 Offset: 0x51C360 VA: 0x18051D960
	public float get_CrossBase() { }

	// RVA: 0x51DBE0 Offset: 0x51C5E0 VA: 0x18051DBE0
	public void set_CrossBase(float value) { }

	// RVA: 0x5162A0 Offset: 0x514CA0 VA: 0x1805162A0
	public AnimationCurve get_CrossCurve() { }

	// RVA: 0x51DC40 Offset: 0x51C640 VA: 0x18051DC40
	public void set_CrossCurve(AnimationCurve value) { }

	// RVA: 0x516250 Offset: 0x514C50 VA: 0x180516250
	public List<CGBoundsGroup> get_Groups() { }

	// RVA: 0x51DD20 Offset: 0x51C720 VA: 0x18051DD20
	public void set_Groups(List<CGBoundsGroup> value) { }

	// RVA: 0x51DB70 Offset: 0x51C570 VA: 0x18051DB70
	public CurvyRepeatingOrderEnum get_RepeatingOrder() { }

	// RVA: 0x51DE50 Offset: 0x51C850 VA: 0x18051DE50
	public void set_RepeatingOrder(CurvyRepeatingOrderEnum value) { }

	// RVA: 0x51D970 Offset: 0x51C370 VA: 0x18051D970
	public int get_FirstRepeating() { }

	// RVA: 0x51DC80 Offset: 0x51C680 VA: 0x18051DC80
	public void set_FirstRepeating(int value) { }

	// RVA: 0x51DA20 Offset: 0x51C420 VA: 0x18051DA20
	public int get_LastRepeating() { }

	// RVA: 0x51DD40 Offset: 0x51C740 VA: 0x18051DD40
	public void set_LastRepeating(int value) { }

	// RVA: 0x51D980 Offset: 0x51C380 VA: 0x18051D980
	public bool get_FitEnd() { }

	// RVA: 0x51DD00 Offset: 0x51C700 VA: 0x18051DD00
	public void set_FitEnd(bool value) { }

	// RVA: 0x51D990 Offset: 0x51C390 VA: 0x18051D990
	public int get_GroupCount() { }

	// RVA: 0x51D820 Offset: 0x51C220 VA: 0x18051D820
	public GUIContent[] get_BoundsNames() { }

	// RVA: 0x51D680 Offset: 0x51C080 VA: 0x18051D680
	public int[] get_BoundsIndices() { }

	// RVA: 0x51D950 Offset: 0x51C350 VA: 0x18051D950
	public int get_Count() { }

	// RVA: 0x51ADF0 Offset: 0x5197F0 VA: 0x18051ADF0
	private bool IsInputAVolume() { }

	// RVA: 0x51D9D0 Offset: 0x51C3D0 VA: 0x18051D9D0
	private int get_LastGroupIndex() { }

	// RVA: 0x51DA30 Offset: 0x51C430 VA: 0x18051DA30
	private RegionOptions<float> get_RangeOptions() { }

	// RVA: 0x51DAC0 Offset: 0x51C4C0 VA: 0x18051DAC0
	private RegionOptions<int> get_RepeatingGroupsOptions() { }

	// RVA: 0x51B0D0 Offset: 0x519AD0 VA: 0x18051B0D0 Slot: 4
	protected override void OnEnable() { }

	// RVA: 0x51D1E0 Offset: 0x51BBE0 VA: 0x18051D1E0 Slot: 13
	public override void Reset() { }

	// RVA: 0x51B100 Offset: 0x519B00 VA: 0x18051B100 Slot: 16
	public override void OnStateChange() { }

	// RVA: 0x5196D0 Offset: 0x5180D0 VA: 0x1805196D0
	public void Clear() { }

	// RVA: 0x51B580 Offset: 0x519F80 VA: 0x18051B580 Slot: 14
	public override void Refresh() { }

	// RVA: 0x519530 Offset: 0x517F30 VA: 0x180519530
	public CGBoundsGroup AddGroup(string name) { }

	// RVA: 0x51D150 Offset: 0x51BB50 VA: 0x18051D150
	public void RemoveGroup(CGBoundsGroup group) { }

	// RVA: 0x519910 Offset: 0x518310 VA: 0x180519910
	private static SubArray<int> GetGroupItemIndices(CGBoundsGroup boundsGroup, WeightedRandom<int> groupItemBag) { }

	// RVA: 0x519770 Offset: 0x518170 VA: 0x180519770
	private static float GetGroupDepth(List<CGBounds> bounds, SubArray<int> groupItemIndices, float spaceBefore, float spaceAfter, out CGBounds[] itemsBounds) { }

	// RVA: 0x518B90 Offset: 0x517590 VA: 0x180518B90
	private bool AddGroupItems(List<CGBounds> bounds, CGPath path, int groupIndex, ref SubArrayList<CGSpot> spots, float remainingLength, float startDistance, ref float currentDistance, out bool failedAddingAllItems, Dictionary<CGBoundsGroup, WeightedRandom<int>> itemsBagDictionary, int MaxSpotsCount) { }

	// RVA: 0x519200 Offset: 0x517C00 VA: 0x180519200
	private void AddGroupItems(CGPath path, CGBoundsGroup group, ref SubArrayList<CGSpot> spots, float remainingLength, float startDistance, ref float currentDistance, out bool failedAddingAllItems, SubArray<int> itemIndices, float groupDepth, CGBounds[] itemBounds, float spaceBefore, float spaceAfter) { }

	// RVA: 0x519B40 Offset: 0x518540 VA: 0x180519B40
	private CGSpot GetSpot(CGPath path, int itemID, CGBoundsGroup boundsGroup, CGBounds bounds, float currentDistance, float startDistance) { }

	// RVA: 0x519B00 Offset: 0x518500 VA: 0x180519B00
	private static float GetRegionNextValue(FloatRegion floatRegion) { }

	// RVA: 0x51A920 Offset: 0x519320 VA: 0x18051A920
	private void GetTRS(CGBoundsGroup boundsGroup, Vector3 tangent, Vector3 up, out Quaternion rotation, out Vector3 translation, out Vector3 scale) { }

	// RVA: 0x51A2A0 Offset: 0x518CA0 VA: 0x18051A2A0
	private void GetTRS630(CGBoundsGroup boundsGroup, Vector3 tangent, Vector3 up, out Quaternion rotation, out Vector3 translation, out Vector3 scale) { }

	// RVA: 0x51B1D0 Offset: 0x519BD0 VA: 0x18051B1D0
	private Dictionary<CGBoundsGroup, WeightedRandom<int>> Prepare(out WeightedRandom<int> groupBag) { }

	// RVA: 0x51DB80 Offset: 0x51C580 VA: 0x18051DB80
	private bool get_ShowFitEnd() { }

	// RVA: 0x51D1C0 Offset: 0x51BBC0 VA: 0x18051D1C0 Slot: 5
	protected override void ResetOnEnable() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 18
	public void OnBeforeSerialize() { }

	// RVA: 0x51AE00 Offset: 0x519800 VA: 0x18051AE00 Slot: 19
	public void OnAfterDeserialize() { }
}

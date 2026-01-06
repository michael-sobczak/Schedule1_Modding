public class CGBoundsGroup : CGWeightedItem // TypeDefIndex: 10608
{
	// Fields
	[SerializeField]
	private string m_Name; // 0x18
	[SerializeField]
	[Tooltip("When checked, the group will only be placed when all the group's items can be placed in the space left")]
	private bool m_KeepTogether; // 0x20
	[SerializeField]
	[FloatRegion(RegionIsOptional = True, Options = 1)]
	private FloatRegion m_SpaceBefore; // 0x24
	[SerializeField]
	[FloatRegion(RegionIsOptional = True, Options = 1)]
	private FloatRegion m_SpaceAfter; // 0x30
	[SerializeField]
	[FloatRegion(RegionIsOptional = True, RegionOptionsPropertyName = "PositionRangeOptions", UseSlider = True, Precision = 3)]
	private FloatRegion m_CrossBase; // 0x3C
	[Tooltip("If ticked, the Cross origin for this group will not take into consideration the Cross parameters in the General tab")]
	[SerializeField]
	private bool m_IgnoreModuleCrossBase; // 0x48
	[SerializeField]
	[Tooltip("When enabled, items will be selected randomly")]
	private bool m_RandomizeItems; // 0x49
	[IntRegion(UseSlider = False, RegionOptionsPropertyName = "RepeatingGroupsOptions", Options = 1)]
	[SerializeField]
	[Tooltip("The randomized items are the the ones that have their indices inside this range")]
	private IntRegion m_RepeatingItems; // 0x4C
	[Tooltip("If unchecked, translation will be done in the global/world space")]
	[SerializeField]
	private bool m_RelativeTranslation; // 0x58
	[SerializeField]
	[FloatRegion(RegionIsOptional = True, Options = 1)]
	private FloatRegion m_TranslationX; // 0x5C
	[SerializeField]
	[FloatRegion(RegionIsOptional = True, Options = 1)]
	private FloatRegion m_TranslationY; // 0x68
	[SerializeField]
	[FloatRegion(RegionIsOptional = True, Options = 1)]
	private FloatRegion m_TranslationZ; // 0x74
	[SerializeField]
	[Tooltip("How the rotation axes are defined related to the Volume's data
  - Full : Use Volume's direction and orientation
  - Direction : Use Volume's direction only
  - Horizontal : Use Volume's direction only after projecting it on XZ plane
  - Independent : Do not use Volume's data")]
	private CGBoundsGroup.RotationModeEnum m_RotationMode; // 0x80
	[SerializeField]
	[FloatRegion(RegionIsOptional = True, Options = 1)]
	private FloatRegion m_RotationX; // 0x84
	[SerializeField]
	[FloatRegion(RegionIsOptional = True, Options = 1)]
	private FloatRegion m_RotationY; // 0x90
	[FloatRegion(RegionIsOptional = True, Options = 1)]
	[SerializeField]
	private FloatRegion m_RotationZ; // 0x9C
	[SerializeField]
	[Tooltip("Whether the scaling is applied equally on all dimensions")]
	private bool m_UniformScaling; // 0xA8
	[SerializeField]
	[FloatRegion(RegionIsOptional = True, Options = 1)]
	private FloatRegion m_ScaleX; // 0xAC
	[SerializeField]
	[FloatRegion(RegionIsOptional = True, Options = 1)]
	private FloatRegion m_ScaleY; // 0xB8
	[SerializeField]
	[FloatRegion(RegionIsOptional = True, Options = 1)]
	private FloatRegion m_ScaleZ; // 0xC4
	[SerializeField]
	private List<CGBoundsGroupItem> m_Items; // 0xD0
	[Obsolete("Use IgnoreModuleCrossBase instead. This field is kept for retro compatibility reasons")]
	[UsedImplicitly]
	[HideInInspector]
	[SerializeField]
	private CGBoundsGroup.DistributionModeEnum m_DistributionMode; // 0xD8
	[FloatRegion(RegionIsOptional = True, RegionOptionsPropertyName = "PositionRangeOptions", UseSlider = True, Precision = 3)]
	[SerializeField]
	[HideInInspector]
	[UsedImplicitly]
	[Obsolete("Use CrossBase instead. This field is kept for retro compatibility reasons")]
	private FloatRegion m_PositionOffset; // 0xDC
	[UsedImplicitly]
	[SerializeField]
	[HideInInspector]
	[Obsolete("Use TranslationY instead, while setting RelativeTranslation to true. This field is kept for retro compatibility reasons")]
	[FloatRegion(RegionIsOptional = True, Options = 1)]
	private FloatRegion m_Height; // 0xE8
	[SerializeField]
	[HideInInspector]
	[UsedImplicitly]
	[Obsolete("Use RandomizeItems instead. This field is kept for retro compatibility reasons")]
	private CurvyRepeatingOrderEnum m_RepeatingOrder; // 0xF4
	[SerializeField]
	[UsedImplicitly]
	[Obsolete("Use RotationX, RotationY and RotationZ instead. This field is kept for retro compatibility reasons")]
	[VectorEx("", "")]
	[HideInInspector]
	private Vector3 m_RotationOffset; // 0xF8
	[SerializeField]
	[HideInInspector]
	[UsedImplicitly]
	[Obsolete("Use RotationX, RotationY and RotationZ instead. This field is kept for retro compatibility reasons")]
	[VectorEx("", "")]
	private Vector3 m_RotationScatter; // 0x104

	// Properties
	public string Name { get; set; }
	public bool KeepTogether { get; set; }
	public FloatRegion SpaceBefore { get; set; }
	public FloatRegion SpaceAfter { get; set; }
	public bool RandomizeItems { get; set; }
	public IntRegion RepeatingItems { get; set; }
	public FloatRegion CrossBase { get; set; }
	public bool IgnoreModuleCrossBase { get; set; }
	public CGBoundsGroup.RotationModeEnum RotationMode { get; set; }
	public FloatRegion RotationX { get; set; }
	public FloatRegion RotationY { get; set; }
	public FloatRegion RotationZ { get; set; }
	public bool UniformScaling { get; set; }
	public FloatRegion ScaleX { get; set; }
	public FloatRegion ScaleY { get; set; }
	public FloatRegion ScaleZ { get; set; }
	public bool RelativeTranslation { get; set; }
	public FloatRegion TranslationX { get; set; }
	public FloatRegion TranslationY { get; set; }
	public FloatRegion TranslationZ { get; set; }
	public List<CGBoundsGroupItem> Items { get; }
	public int FirstRepeating { get; set; }
	public int LastRepeating { get; set; }
	public int ItemCount { get; }
	private RegionOptions<int> RepeatingGroupsOptions { get; }
	private RegionOptions<float> PositionRangeOptions { get; }

	// Methods

	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	public string get_Name() { }

	// RVA: 0x43EFE0 Offset: 0x43D9E0 VA: 0x18043EFE0
	public void set_Name(string value) { }

	// RVA: 0x4945E0 Offset: 0x492FE0 VA: 0x1804945E0
	public bool get_KeepTogether() { }

	// RVA: 0x494600 Offset: 0x493000 VA: 0x180494600
	public void set_KeepTogether(bool value) { }

	// RVA: 0x4D6370 Offset: 0x4D4D70 VA: 0x1804D6370
	public FloatRegion get_SpaceBefore() { }

	// RVA: 0x4D6620 Offset: 0x4D5020 VA: 0x1804D6620
	public void set_SpaceBefore(FloatRegion value) { }

	// RVA: 0x4D6350 Offset: 0x4D4D50 VA: 0x1804D6350
	public FloatRegion get_SpaceAfter() { }

	// RVA: 0x4D6610 Offset: 0x4D5010 VA: 0x1804D6610
	public void set_SpaceAfter(FloatRegion value) { }

	// RVA: 0x4D6190 Offset: 0x4D4B90 VA: 0x1804D6190
	public bool get_RandomizeItems() { }

	// RVA: 0x4D6510 Offset: 0x4D4F10 VA: 0x1804D6510
	public void set_RandomizeItems(bool value) { }

	// RVA: 0x4D6260 Offset: 0x4D4C60 VA: 0x1804D6260
	public IntRegion get_RepeatingItems() { }

	// RVA: 0x4D6530 Offset: 0x4D4F30 VA: 0x1804D6530
	public void set_RepeatingItems(IntRegion value) { }

	// RVA: 0x4D60A0 Offset: 0x4D4AA0 VA: 0x1804D60A0
	public FloatRegion get_CrossBase() { }

	// RVA: 0x4D6400 Offset: 0x4D4E00 VA: 0x1804D6400
	public void set_CrossBase(FloatRegion value) { }

	// RVA: 0x4D60D0 Offset: 0x4D4AD0 VA: 0x1804D60D0
	public bool get_IgnoreModuleCrossBase() { }

	// RVA: 0x4D6480 Offset: 0x4D4E80 VA: 0x1804D6480
	public void set_IgnoreModuleCrossBase(bool value) { }

	// RVA: 0x4D6280 Offset: 0x4D4C80 VA: 0x1804D6280
	public CGBoundsGroup.RotationModeEnum get_RotationMode() { }

	// RVA: 0x4D6540 Offset: 0x4D4F40 VA: 0x1804D6540
	public void set_RotationMode(CGBoundsGroup.RotationModeEnum value) { }

	// RVA: 0x4D6290 Offset: 0x4D4C90 VA: 0x1804D6290
	public FloatRegion get_RotationX() { }

	// RVA: 0x4D6550 Offset: 0x4D4F50 VA: 0x1804D6550
	public void set_RotationX(FloatRegion value) { }

	// RVA: 0x4D62B0 Offset: 0x4D4CB0 VA: 0x1804D62B0
	public FloatRegion get_RotationY() { }

	// RVA: 0x4D6570 Offset: 0x4D4F70 VA: 0x1804D6570
	public void set_RotationY(FloatRegion value) { }

	// RVA: 0x4D62D0 Offset: 0x4D4CD0 VA: 0x1804D62D0
	public FloatRegion get_RotationZ() { }

	// RVA: 0x4D6590 Offset: 0x4D4F90 VA: 0x1804D6590
	public void set_RotationZ(FloatRegion value) { }

	// RVA: 0x4D63F0 Offset: 0x4D4DF0 VA: 0x1804D63F0
	public bool get_UniformScaling() { }

	// RVA: 0x4D6660 Offset: 0x4D5060 VA: 0x1804D6660
	public void set_UniformScaling(bool value) { }

	// RVA: 0x4D62F0 Offset: 0x4D4CF0 VA: 0x1804D62F0
	public FloatRegion get_ScaleX() { }

	// RVA: 0x4D65B0 Offset: 0x4D4FB0 VA: 0x1804D65B0
	public void set_ScaleX(FloatRegion value) { }

	// RVA: 0x4D6310 Offset: 0x4D4D10 VA: 0x1804D6310
	public FloatRegion get_ScaleY() { }

	// RVA: 0x4D65D0 Offset: 0x4D4FD0 VA: 0x1804D65D0
	public void set_ScaleY(FloatRegion value) { }

	// RVA: 0x4D6330 Offset: 0x4D4D30 VA: 0x1804D6330
	public FloatRegion get_ScaleZ() { }

	// RVA: 0x4D65F0 Offset: 0x4D4FF0 VA: 0x1804D65F0
	public void set_ScaleZ(FloatRegion value) { }

	// RVA: 0x4D61A0 Offset: 0x4D4BA0 VA: 0x1804D61A0
	public bool get_RelativeTranslation() { }

	// RVA: 0x4D6520 Offset: 0x4D4F20 VA: 0x1804D6520
	public void set_RelativeTranslation(bool value) { }

	// RVA: 0x4D6390 Offset: 0x4D4D90 VA: 0x1804D6390
	public FloatRegion get_TranslationX() { }

	// RVA: 0x4D6630 Offset: 0x4D5030 VA: 0x1804D6630
	public void set_TranslationX(FloatRegion value) { }

	// RVA: 0x4D63B0 Offset: 0x4D4DB0 VA: 0x1804D63B0
	public FloatRegion get_TranslationY() { }

	// RVA: 0x4D6640 Offset: 0x4D5040 VA: 0x1804D6640
	public void set_TranslationY(FloatRegion value) { }

	// RVA: 0x4D63D0 Offset: 0x4D4DD0 VA: 0x1804D63D0
	public FloatRegion get_TranslationZ() { }

	// RVA: 0x4D6650 Offset: 0x4D5050 VA: 0x1804D6650
	public void set_TranslationZ(FloatRegion value) { }

	// RVA: 0x4B6180 Offset: 0x4B4B80 VA: 0x1804B6180
	public List<CGBoundsGroupItem> get_Items() { }

	// RVA: 0x4D60C0 Offset: 0x4D4AC0 VA: 0x1804D60C0
	public int get_FirstRepeating() { }

	// RVA: 0x4D6410 Offset: 0x4D4E10 VA: 0x1804D6410
	public void set_FirstRepeating(int value) { }

	// RVA: 0x4B61B0 Offset: 0x4B4BB0 VA: 0x1804B61B0
	public int get_LastRepeating() { }

	// RVA: 0x4D6490 Offset: 0x4D4E90 VA: 0x1804D6490
	public void set_LastRepeating(int value) { }

	// RVA: 0x4D60E0 Offset: 0x4D4AE0 VA: 0x1804D60E0
	public int get_ItemCount() { }

	// RVA: 0x4D5D80 Offset: 0x4D4780 VA: 0x1804D5D80
	public void .ctor(string name) { }

	// RVA: 0x4D5C70 Offset: 0x4D4670 VA: 0x1804D5C70
	public static void FillItemBag(WeightedRandom<int> bag, IEnumerable<CGWeightedItem> itemsWeights, int firstItem, int lastItem) { }

	// RVA: 0x4D61B0 Offset: 0x4D4BB0 VA: 0x1804D61B0
	private RegionOptions<int> get_RepeatingGroupsOptions() { }

	// RVA: 0x4D6120 Offset: 0x4D4B20 VA: 0x1804D6120
	private RegionOptions<float> get_PositionRangeOptions() { }

	[UsedImplicitly]
	[Obsolete("Method will get removed once the obsolete data will get removed")]
	// RVA: 0x4D5AA0 Offset: 0x4D44A0 VA: 0x1804D5AA0
	public void ConvertObsoleteData() { }
}

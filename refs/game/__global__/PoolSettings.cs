public class PoolSettings // TypeDefIndex: 10418
{
	// Fields
	[Header("General")]
	[SerializeField]
	[Label("Auto Create Items", "")]
	[Tooltip("Automatically create items when an item is requested and none is available")]
	private bool m_AutoCreate; // 0x10
	[Tooltip("Automatically disable objects when entering the pool and enable them when leaving it")]
	[Label("Auto Enable/Disable Items", "")]
	[SerializeField]
	private bool m_AutoEnableDisable; // 0x11
	[Label("Debug mode", "")]
	[Tooltip("Log operations and show pooled objects in the hierarchy")]
	public bool Debug; // 0x12
	[FormerlySerializedAs("m_MinItems")]
	[SerializeField]
	[Header("Item Count Constraints")]
	[Positive]
	[Tooltip("Minimum number of items in the pool")]
	private int minimumCount; // 0x14
	[Positive]
	[SerializeField]
	[FormerlySerializedAs("m_Threshold")]
	[Tooltip("Maximum number of items in the pool")]
	private int maximumCount; // 0x18
	[Label("Adjustment Interval", "")]
	[SerializeField]
	[Tooltip("Number of seconds between item count adjustments.
If 0, adjustments are instantaneous.")]
	[Positive]
	[FormerlySerializedAs("m_Speed")]
	private float countAdjustmentInterval; // 0x1C
	[FormerlySerializedAs("m_Prewarm")]
	[Tooltip("Initialize the pool with its item count already within the constraints")]
	[SerializeField]
	[Label("Initialize Constrained", "")]
	private bool initializeCountConstrained; // 0x20

	// Properties
	public bool InitializeCountConstrained { get; set; }
	public bool AutoCreate { get; set; }
	public bool AutoEnableDisable { get; set; }
	public int MinimumCount { get; set; }
	public int MaximumCount { get; set; }
	public float CountAdjustmentInterval { get; set; }
	[UsedImplicitly]
	[Obsolete("Use InitializeCountConstrained instead")]
	public bool Prewarm { get; set; }
	[UsedImplicitly]
	[Obsolete("Use MinimumCount instead")]
	public int MinItems { get; set; }
	[UsedImplicitly]
	[Obsolete("Use MaximumCount instead")]
	public int Threshold { get; set; }
	[UsedImplicitly]
	[Obsolete("Use CountAdjustmentInterval instead")]
	public float Speed { get; set; }

	// Methods

	// RVA: 0x4945E0 Offset: 0x492FE0 VA: 0x1804945E0
	public bool get_InitializeCountConstrained() { }

	// RVA: 0x494600 Offset: 0x493000 VA: 0x180494600
	public void set_InitializeCountConstrained(bool value) { }

	// RVA: 0x498A40 Offset: 0x497440 VA: 0x180498A40
	public bool get_AutoCreate() { }

	// RVA: 0x498A80 Offset: 0x497480 VA: 0x180498A80
	public void set_AutoCreate(bool value) { }

	// RVA: 0x498A50 Offset: 0x497450 VA: 0x180498A50
	public bool get_AutoEnableDisable() { }

	// RVA: 0x498A90 Offset: 0x497490 VA: 0x180498A90
	public void set_AutoEnableDisable(bool value) { }

	// RVA: 0x498A70 Offset: 0x497470 VA: 0x180498A70
	public int get_MinimumCount() { }

	// RVA: 0x498AC0 Offset: 0x4974C0 VA: 0x180498AC0
	public void set_MinimumCount(int value) { }

	// RVA: 0x456E90 Offset: 0x455890 VA: 0x180456E90
	public int get_MaximumCount() { }

	// RVA: 0x498AB0 Offset: 0x4974B0 VA: 0x180498AB0
	public void set_MaximumCount(int value) { }

	// RVA: 0x498A60 Offset: 0x497460 VA: 0x180498A60
	public float get_CountAdjustmentInterval() { }

	// RVA: 0x498AA0 Offset: 0x4974A0 VA: 0x180498AA0
	public void set_CountAdjustmentInterval(float value) { }

	// RVA: 0x4945E0 Offset: 0x492FE0 VA: 0x1804945E0
	public bool get_Prewarm() { }

	// RVA: 0x494600 Offset: 0x493000 VA: 0x180494600
	public void set_Prewarm(bool value) { }

	// RVA: 0x498A70 Offset: 0x497470 VA: 0x180498A70
	public int get_MinItems() { }

	// RVA: 0x498AC0 Offset: 0x4974C0 VA: 0x180498AC0
	public void set_MinItems(int value) { }

	// RVA: 0x456E90 Offset: 0x455890 VA: 0x180456E90
	public int get_Threshold() { }

	// RVA: 0x498AB0 Offset: 0x4974B0 VA: 0x180498AB0
	public void set_Threshold(int value) { }

	// RVA: 0x498A60 Offset: 0x497460 VA: 0x180498A60
	public float get_Speed() { }

	// RVA: 0x498AA0 Offset: 0x4974A0 VA: 0x180498AA0
	public void set_Speed(float value) { }

	// RVA: 0x498990 Offset: 0x497390 VA: 0x180498990
	public void .ctor() { }

	// RVA: 0x4989D0 Offset: 0x4973D0 VA: 0x1804989D0
	public void .ctor(PoolSettings src) { }

	// RVA: 0x498960 Offset: 0x497360 VA: 0x180498960
	public void SetToDefault() { }

	[Obsolete("Use Validate instead")]
	[UsedImplicitly]
	// RVA: 0x498930 Offset: 0x497330 VA: 0x180498930
	public void OnValidate() { }

	// RVA: 0x498930 Offset: 0x497330 VA: 0x180498930
	public void Validate() { }
}

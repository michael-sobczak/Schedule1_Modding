public class CartelActivity : MonoBehaviour // TypeDefIndex: 2067
{
	// Fields
	[CompilerGenerated]
	private bool <IsActive>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <MinsSinceActivation>k__BackingField; // 0x24
	[CompilerGenerated]
	private EMapRegion <Region>k__BackingField; // 0x28
	[Header("Settings")]
	[Range(0, 1)]
	public float InfluenceRequirement; // 0x2C
	public Action onActivated; // 0x30
	public Action onDeactivated; // 0x38

	// Properties
	public bool IsActive { get; set; }
	public int MinsSinceActivation { get; set; }
	public EMapRegion Region { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4945E0 Offset: 0x492FE0 VA: 0x1804945E0
	public bool get_IsActive() { }

	[CompilerGenerated]
	// RVA: 0x494600 Offset: 0x493000 VA: 0x180494600
	protected void set_IsActive(bool value) { }

	[CompilerGenerated]
	// RVA: 0x49CD40 Offset: 0x49B740 VA: 0x18049CD40
	public int get_MinsSinceActivation() { }

	[CompilerGenerated]
	// RVA: 0x49CD60 Offset: 0x49B760 VA: 0x18049CD60
	protected void set_MinsSinceActivation(int value) { }

	[CompilerGenerated]
	// RVA: 0x494430 Offset: 0x492E30 VA: 0x180494430
	public EMapRegion get_Region() { }

	[CompilerGenerated]
	// RVA: 0x494480 Offset: 0x492E80 VA: 0x180494480
	protected void set_Region(EMapRegion value) { }

	// RVA: 0x7E03A0 Offset: 0x7DEDA0 VA: 0x1807E03A0
	private void Start() { }

	// RVA: 0x7E00C0 Offset: 0x7DEAC0 VA: 0x1807E00C0 Slot: 4
	public virtual void Activate(EMapRegion region) { }

	// RVA: 0x7E0390 Offset: 0x7DED90 VA: 0x1807E0390 Slot: 5
	protected virtual void MinPassed() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 6
	protected virtual void HourPassed() { }

	// RVA: 0x7E01D0 Offset: 0x7DEBD0 VA: 0x1807E01D0 Slot: 7
	protected virtual void Deactivate() { }

	// RVA: 0x7E02D0 Offset: 0x7DECD0 VA: 0x1807E02D0 Slot: 8
	public virtual bool IsRegionValidForActivity(EMapRegion region) { }

	// RVA: 0x43CCF0 Offset: 0x43B6F0 VA: 0x18043CCF0
	public void .ctor() { }
}

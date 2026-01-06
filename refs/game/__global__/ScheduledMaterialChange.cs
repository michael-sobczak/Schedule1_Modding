public class ScheduledMaterialChange : MonoBehaviour // TypeDefIndex: 3358
{
	// Fields
	public MeshRenderer[] Renderers; // 0x20
	public int MaterialIndex; // 0x28
	[Header("Settings")]
	public bool Enabled; // 0x2C
	public Material OutsideTimeRangeMaterial; // 0x30
	public Material InsideTimeRangeMaterial; // 0x38
	public int TimeRangeMin; // 0x40
	public int TimeRangeMax; // 0x44
	public int TimeRangeShift; // 0x48
	public int TimeRangeRandomization; // 0x4C
	[Range(0, 1)]
	public float TurnOnChance; // 0x50
	private bool appliedInsideTimeRange; // 0x54
	private ScheduledMaterialChange.EOnState onState; // 0x58
	private int randomShift; // 0x5C

	// Methods

	// RVA: 0xA554F0 Offset: 0xA53EF0 VA: 0x180A554F0 Slot: 4
	protected virtual void Start() { }

	// RVA: 0xA55630 Offset: 0xA54030 VA: 0x180A55630 Slot: 5
	protected virtual void Tick() { }

	// RVA: 0xA55380 Offset: 0xA53D80 VA: 0x180A55380
	private void SetMaterial(bool insideTimeRange) { }

	// RVA: 0xA557C0 Offset: 0xA541C0 VA: 0x180A557C0
	public void .ctor() { }
}

public class MapPositionUtility : Singleton<MapPositionUtility> // TypeDefIndex: 3343
{
	// Fields
	public Transform OriginPoint; // 0x28
	public Transform EdgePoint; // 0x30
	public float MapDimensions; // 0x38
	[CompilerGenerated]
	private float <conversionFactor>k__BackingField; // 0x3C

	// Properties
	private float conversionFactor { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4E2CC0 Offset: 0x4E16C0 VA: 0x1804E2CC0
	private float get_conversionFactor() { }

	[CompilerGenerated]
	// RVA: 0x4E2CE0 Offset: 0x4E16E0 VA: 0x1804E2CE0
	private void set_conversionFactor(float value) { }

	// RVA: 0xA4E1E0 Offset: 0xA4CBE0 VA: 0x180A4E1E0 Slot: 5
	protected override void Awake() { }

	// RVA: 0xA4E370 Offset: 0xA4CD70 VA: 0x180A4E370
	public Vector2 GetMapPosition(Vector3 worldPosition) { }

	[Button]
	// RVA: 0xA4E400 Offset: 0xA4CE00 VA: 0x180A4E400
	public void Recalculate() { }

	// RVA: 0xA4E560 Offset: 0xA4CF60 VA: 0x180A4E560
	public void .ctor() { }
}

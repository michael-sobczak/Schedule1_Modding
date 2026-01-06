public class MushroomSpawnStationItem : StationItem // TypeDefIndex: 2431
{
	// Fields
	[SerializeField]
	private MeshRenderer[] _renderers; // 0x38
	[SerializeField]
	private int _materialIndex; // 0x40
	[CompilerGenerated]
	[SerializeField]
	private Collider <InjectionPortCollider>k__BackingField; // 0x48
	[SerializeField]
	private GameObject _injectionPortHighlight; // 0x50

	// Properties
	public Collider InjectionPortCollider { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4C1D80 Offset: 0x4C0780 VA: 0x1804C1D80
	public Collider get_InjectionPortCollider() { }

	[CompilerGenerated]
	// RVA: 0x5A9D30 Offset: 0x5A8730 VA: 0x1805A9D30
	private void set_InjectionPortCollider(Collider value) { }

	// RVA: 0x890AD0 Offset: 0x88F4D0 VA: 0x180890AD0 Slot: 4
	protected override void Awake() { }

	// RVA: 0x890CF0 Offset: 0x88F6F0 VA: 0x180890CF0
	public void SetInocculationAmount(float amount) { }

	// RVA: 0x890CD0 Offset: 0x88F6D0 VA: 0x180890CD0
	public void SetInjectionPortHighlightActive(bool active) { }

	// RVA: 0x873960 Offset: 0x872360 VA: 0x180873960
	public void .ctor() { }
}

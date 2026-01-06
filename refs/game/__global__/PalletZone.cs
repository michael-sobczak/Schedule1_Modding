public class PalletZone : MonoBehaviour // TypeDefIndex: 2390
{
	// Fields
	private List<Pallet> pallets; // 0x20
	[SerializeField]
	[Header("Prefabs")]
	protected GameObject palletPrefab; // 0x28
	private bool orderReceivedThisFrame; // 0x30

	// Properties
	public bool isClear { get; }

	// Methods

	// RVA: 0x879D10 Offset: 0x878710 VA: 0x180879D10
	public bool get_isClear() { }

	// RVA: 0x879BB0 Offset: 0x8785B0 VA: 0x180879BB0
	protected void OnTriggerStay(Collider other) { }

	// RVA: 0x879A00 Offset: 0x878400 VA: 0x180879A00
	protected void FixedUpdate() { }

	// RVA: 0x5FF4E0 Offset: 0x5FDEE0 VA: 0x1805FF4E0
	protected void LateUpdate() { }

	// RVA: 0x879A60 Offset: 0x878460 VA: 0x180879A60
	public Pallet GeneratePallet() { }

	// RVA: 0x879950 Offset: 0x878350 VA: 0x180879950
	private bool AreAllPalletsClear() { }

	// RVA: 0x879C90 Offset: 0x878690 VA: 0x180879C90
	public void .ctor() { }
}

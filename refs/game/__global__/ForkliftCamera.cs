public class ForkliftCamera : VehicleCamera // TypeDefIndex: 2166
{
	// Fields
	[SerializeField]
	[Header("Forklift References")]
	protected Transform forkCamPos; // 0x80
	[SerializeField]
	protected Light guidanceLight; // 0x88
	protected bool forkliftCamActive; // 0x90

	// Methods

	// RVA: 0x811CE0 Offset: 0x8106E0 VA: 0x180811CE0 Slot: 5
	protected override void Update() { }

	// RVA: 0x811B80 Offset: 0x810580 VA: 0x180811B80 Slot: 6
	protected override void LateUpdate() { }

	// RVA: 0x811D30 Offset: 0x810730 VA: 0x180811D30
	public void .ctor() { }
}

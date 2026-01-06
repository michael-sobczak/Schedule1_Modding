public class RecastTileUpdateHandler : MonoBehaviour // TypeDefIndex: 13209
{
	// Fields
	private RecastGraph graph; // 0x20
	private bool[] dirtyTiles; // 0x28
	private bool anyDirtyTiles; // 0x30
	private float earliestDirty; // 0x34
	public float maxThrottlingDelay; // 0x38

	// Methods

	// RVA: 0xB2AEB0 Offset: 0xB298B0 VA: 0x180B2AEB0
	public void SetGraph(RecastGraph graph) { }

	// RVA: 0xB2AB30 Offset: 0xB29530 VA: 0x180B2AB30
	public void ScheduleUpdate(Bounds bounds) { }

	// RVA: 0xB2AA10 Offset: 0xB29410 VA: 0x180B2AA10
	private void OnEnable() { }

	// RVA: 0xB2A8F0 Offset: 0xB292F0 VA: 0x180B2A8F0
	private void OnDisable() { }

	// RVA: 0xB2B2C0 Offset: 0xB29CC0 VA: 0x180B2B2C0
	private void Update() { }

	// RVA: 0xB2AF30 Offset: 0xB29930 VA: 0x180B2AF30
	public void UpdateDirtyTiles() { }

	// RVA: 0xB2B300 Offset: 0xB29D00 VA: 0x180B2B300
	public void .ctor() { }
}

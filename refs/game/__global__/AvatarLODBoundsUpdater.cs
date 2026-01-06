public class AvatarLODBoundsUpdater : MonoBehaviour // TypeDefIndex: 3100
{
	// Fields
	public const float CHECK_RATE_SECONDS = 1;
	public const float HIP_OFFSET_THRESHOLD = 5;
	public Avatar Avatar; // 0x20
	private List<LODGroup> lodGroups; // 0x28
	private Vector3 hipOffsetOnLastRefresh; // 0x30

	// Methods

	// RVA: 0x9AF7C0 Offset: 0x9AE1C0 VA: 0x1809AF7C0
	private void Awake() { }

	// RVA: 0x9AF960 Offset: 0x9AE360 VA: 0x1809AF960
	private void InfrequentUpdate() { }

	// RVA: 0x9AF8F0 Offset: 0x9AE2F0 VA: 0x1809AF8F0
	private void GetLODGroups() { }

	// RVA: 0x9AFAE0 Offset: 0x9AE4E0 VA: 0x1809AFAE0
	private void Recalculate() { }

	// RVA: 0x9AFCC0 Offset: 0x9AE6C0 VA: 0x1809AFCC0
	public void .ctor() { }
}

public class LightTimer : MonoBehaviour // TypeDefIndex: 1266
{
	// Fields
	[Header("Timing")]
	public int StartTime; // 0x20
	public int EndTime; // 0x24
	public int StartTimeOffset; // 0x28
	private ToggleableLight toggleableLight; // 0x30

	// Methods

	// RVA: 0x618600 Offset: 0x617000 VA: 0x180618600 Slot: 4
	protected virtual void Awake() { }

	// RVA: 0x618750 Offset: 0x617150 VA: 0x180618750
	private void Start() { }

	// RVA: 0x618770 Offset: 0x617170 VA: 0x180618770 Slot: 5
	protected virtual void UpdateState() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	private void OnDrawGizmos() { }

	// RVA: 0x618730 Offset: 0x617130 VA: 0x180618730
	private void SetState(bool on) { }

	// RVA: 0x618810 Offset: 0x617210 VA: 0x180618810
	public void .ctor() { }
}

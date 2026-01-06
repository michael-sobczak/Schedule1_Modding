public class PlaceholderBuilding : MonoBehaviour // TypeDefIndex: 1928
{
	// Fields
	[Header("Settings")]
	public string Name; // 0x20
	public Vector3 Dimensions; // 0x28
	public bool AutoGround; // 0x34
	[Header("References")]
	public Transform Model; // 0x38
	public TextMeshPro Label; // 0x40
	private Vector3 lastFramePosition; // 0x48

	// Methods

	// RVA: 0x79EE60 Offset: 0x79D860 VA: 0x18079EE60
	private void Awake() { }

	// RVA: 0x79EEF0 Offset: 0x79D8F0 VA: 0x18079EEF0 Slot: 4
	protected virtual void LateUpdate() { }

	// RVA: 0x79F440 Offset: 0x79DE40 VA: 0x18079F440
	public void .ctor() { }
}

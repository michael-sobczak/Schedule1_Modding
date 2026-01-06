public class RollerDoor : MonoBehaviour // TypeDefIndex: 1544
{
	// Fields
	[CompilerGenerated]
	private bool <IsOpen>k__BackingField; // 0x20
	[Header("Settings")]
	public Transform Door; // 0x28
	public Vector3 LocalPos_Open; // 0x30
	public Vector3 LocalPos_Closed; // 0x3C
	public float LerpTime; // 0x48
	public GameObject Blocker; // 0x50
	private Vector3 startPos; // 0x58
	private float timeSinceValueChange; // 0x64

	// Properties
	public bool IsOpen { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4945E0 Offset: 0x492FE0 VA: 0x1804945E0
	public bool get_IsOpen() { }

	[CompilerGenerated]
	// RVA: 0x494600 Offset: 0x493000 VA: 0x180494600
	protected void set_IsOpen(bool value) { }

	// RVA: 0x6FCA00 Offset: 0x6FB400 VA: 0x1806FCA00
	private void Awake() { }

	// RVA: 0x6FCAA0 Offset: 0x6FB4A0 VA: 0x1806FCAA0
	private void LateUpdate() { }

	// RVA: 0x6FCC50 Offset: 0x6FB650 VA: 0x1806FCC50
	public void Open() { }

	// RVA: 0x6FCA50 Offset: 0x6FB450 VA: 0x1806FCA50
	public void Close() { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0 Slot: 4
	protected virtual bool CanOpen() { }

	// RVA: 0x6FCCC0 Offset: 0x6FB6C0 VA: 0x1806FCCC0
	public void .ctor() { }
}

public class EmployeeHome : MonoBehaviour // TypeDefIndex: 1424
{
	// Fields
	[CompilerGenerated]
	private Employee <AssignedEmployee>k__BackingField; // 0x20
	public string HomeType; // 0x28
	[Header("References")]
	public GameObject Clipboard; // 0x30
	public SpriteRenderer MugshotSprite; // 0x38
	public TextMeshPro NameLabel; // 0x40
	public StorageEntity Storage; // 0x48
	public MeshRenderer[] EmployeeSpecificMeshes; // 0x50
	public Material SpecificMat_Default; // 0x58
	public Material SpecificMat_Botanist; // 0x60
	public Material SpecificMat_Chemist; // 0x68
	public Material SpecificMat_Packager; // 0x70
	public Material SpecificMat_Cleaner; // 0x78
	public UnityEvent onAssignedEmployeeChanged; // 0x80

	// Properties
	public Employee AssignedEmployee { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	public Employee get_AssignedEmployee() { }

	[CompilerGenerated]
	// RVA: 0x43EFF0 Offset: 0x43D9F0 VA: 0x18043EFF0
	protected void set_AssignedEmployee(Employee value) { }

	// RVA: 0x6C1220 Offset: 0x6BFC20 VA: 0x1806C1220
	private void Awake() { }

	// RVA: 0x6C1A80 Offset: 0x6C0480 VA: 0x1806C1A80
	private void Start() { }

	// RVA: 0x6C1800 Offset: 0x6C0200 VA: 0x1806C1800
	public void SetAssignedEmployee(Employee employee) { }

	// RVA: 0x6C1BC0 Offset: 0x6C05C0 VA: 0x1806C1BC0
	private void UpdateStorageText() { }

	// RVA: 0x6C1A90 Offset: 0x6C0490 VA: 0x1806C1A90
	private void UpdateMaterial() { }

	// RVA: 0x6C12B0 Offset: 0x6BFCB0 VA: 0x1806C12B0
	public float GetCashSum() { }

	// RVA: 0x6C15E0 Offset: 0x6BFFE0 VA: 0x1806C15E0
	public void RemoveCash(float amount) { }

	// RVA: 0x6C1480 Offset: 0x6BFE80 VA: 0x1806C1480
	public static bool IsBuildableEntityAValidEmployeeHome(BuildableItem obj, out string reason) { }

	// RVA: 0x6C1EE0 Offset: 0x6C08E0 VA: 0x1806C1EE0
	public void .ctor() { }
}

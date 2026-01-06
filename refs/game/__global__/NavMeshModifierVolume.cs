public class NavMeshModifierVolume : MonoBehaviour // TypeDefIndex: 18985
{
	// Fields
	[SerializeField]
	private Vector3 m_Size; // 0x20
	[SerializeField]
	private Vector3 m_Center; // 0x2C
	[SerializeField]
	private int m_Area; // 0x38
	[SerializeField]
	private List<int> m_AffectedAgents; // 0x40
	private static readonly List<NavMeshModifierVolume> s_NavMeshModifiers; // 0x0

	// Properties
	public Vector3 size { get; set; }
	public Vector3 center { get; set; }
	public int area { get; set; }
	public static List<NavMeshModifierVolume> activeModifiers { get; }

	// Methods

	// RVA: 0x4DA100 Offset: 0x4D8B00 VA: 0x1804DA100
	public Vector3 get_size() { }

	// RVA: 0x4DA200 Offset: 0x4D8C00 VA: 0x1804DA200
	public void set_size(Vector3 value) { }

	// RVA: 0x4DA0C0 Offset: 0x4D8AC0 VA: 0x1804DA0C0
	public Vector3 get_center() { }

	// RVA: 0x4DA1E0 Offset: 0x4D8BE0 VA: 0x1804DA1E0
	public void set_center(Vector3 value) { }

	// RVA: 0x495F50 Offset: 0x494950 VA: 0x180495F50
	public int get_area() { }

	// RVA: 0x4E2930 Offset: 0x4E1330 VA: 0x1804E2930
	public void set_area(int value) { }

	// RVA: 0x26D26E0 Offset: 0x26D10E0 VA: 0x1826D26E0
	public static List<NavMeshModifierVolume> get_activeModifiers() { }

	// RVA: 0x26D2420 Offset: 0x26D0E20 VA: 0x1826D2420
	private void OnEnable() { }

	// RVA: 0x26D23A0 Offset: 0x26D0DA0 VA: 0x1826D23A0
	private void OnDisable() { }

	// RVA: 0x26D22F0 Offset: 0x26D0CF0 VA: 0x1826D22F0
	public bool AffectsAgentType(int agentTypeID) { }

	// RVA: 0x26D25E0 Offset: 0x26D0FE0 VA: 0x1826D25E0
	public void .ctor() { }

	// RVA: 0x26D2550 Offset: 0x26D0F50 VA: 0x1826D2550
	private static void .cctor() { }
}

public class NavMeshLink : MonoBehaviour // TypeDefIndex: 18983
{
	// Fields
	[SerializeField]
	private int m_AgentTypeID; // 0x20
	[SerializeField]
	private Vector3 m_StartPoint; // 0x24
	[SerializeField]
	private Vector3 m_EndPoint; // 0x30
	[SerializeField]
	private float m_Width; // 0x3C
	[SerializeField]
	private int m_CostModifier; // 0x40
	[SerializeField]
	private bool m_Bidirectional; // 0x44
	[SerializeField]
	private bool m_AutoUpdatePosition; // 0x45
	[SerializeField]
	private int m_Area; // 0x48
	private NavMeshLinkInstance m_LinkInstance; // 0x4C
	private Vector3 m_LastPosition; // 0x50
	private Quaternion m_LastRotation; // 0x5C
	private static readonly List<NavMeshLink> s_Tracked; // 0x0

	// Properties
	public int agentTypeID { get; set; }
	public Vector3 startPoint { get; set; }
	public Vector3 endPoint { get; set; }
	public float width { get; set; }
	public int costModifier { get; set; }
	public bool bidirectional { get; set; }
	public bool autoUpdate { get; set; }
	public int area { get; set; }

	// Methods

	// RVA: 0x494440 Offset: 0x492E40 VA: 0x180494440
	public int get_agentTypeID() { }

	// RVA: 0x26D2180 Offset: 0x26D0B80 VA: 0x1826D2180
	public void set_agentTypeID(int value) { }

	// RVA: 0x4D6370 Offset: 0x4D4D70 VA: 0x1804D6370
	public Vector3 get_startPoint() { }

	// RVA: 0x26D2280 Offset: 0x26D0C80 VA: 0x1826D2280
	public void set_startPoint(Vector3 value) { }

	// RVA: 0x4D6350 Offset: 0x4D4D50 VA: 0x1804D6350
	public Vector3 get_endPoint() { }

	// RVA: 0x26D2240 Offset: 0x26D0C40 VA: 0x1826D2240
	public void set_endPoint(Vector3 value) { }

	// RVA: 0x4E2CC0 Offset: 0x4E16C0 VA: 0x1804E2CC0
	public float get_width() { }

	// RVA: 0x26D22C0 Offset: 0x26D0CC0 VA: 0x1826D22C0
	public void set_width(float value) { }

	// RVA: 0x4B5E40 Offset: 0x4B4840 VA: 0x1804B5E40
	public int get_costModifier() { }

	// RVA: 0x26D2210 Offset: 0x26D0C10 VA: 0x1826D2210
	public void set_costModifier(int value) { }

	// RVA: 0x495FF0 Offset: 0x4949F0 VA: 0x180495FF0
	public bool get_bidirectional() { }

	// RVA: 0x26D21E0 Offset: 0x26D0BE0 VA: 0x1826D21E0
	public void set_bidirectional(bool value) { }

	// RVA: 0x495E70 Offset: 0x494870 VA: 0x180495E70
	public bool get_autoUpdate() { }

	// RVA: 0x26D1D00 Offset: 0x26D0700 VA: 0x1826D1D00
	public void set_autoUpdate(bool value) { }

	// RVA: 0x4B61C0 Offset: 0x4B4BC0 VA: 0x1804B61C0
	public int get_area() { }

	// RVA: 0x26D21B0 Offset: 0x26D0BB0 VA: 0x1826D21B0
	public void set_area(int value) { }

	// RVA: 0x26D1AE0 Offset: 0x26D04E0 VA: 0x1826D1AE0
	private void OnEnable() { }

	// RVA: 0x26D1A80 Offset: 0x26D0480 VA: 0x1826D1A80
	private void OnDisable() { }

	// RVA: 0x26D1A50 Offset: 0x26D0450 VA: 0x1826D1A50
	public void UpdateLink() { }

	// RVA: 0x26D1700 Offset: 0x26D0100 VA: 0x1826D1700
	private static void AddTracking(NavMeshLink link) { }

	// RVA: 0x26D1B50 Offset: 0x26D0550 VA: 0x1826D1B50
	private static void RemoveTracking(NavMeshLink link) { }

	// RVA: 0x26D1D00 Offset: 0x26D0700 VA: 0x1826D1D00
	private void SetAutoUpdate(bool value) { }

	// RVA: 0x26D14F0 Offset: 0x26CFEF0 VA: 0x1826D14F0
	private void AddLink() { }

	// RVA: 0x26D1910 Offset: 0x26D0310 VA: 0x1826D1910
	private bool HasTransformChanged() { }

	// RVA: 0x26D1A50 Offset: 0x26D0450 VA: 0x1826D1A50
	private void OnDidApplyAnimationProperties() { }

	// RVA: 0x26D1D90 Offset: 0x26D0790 VA: 0x1826D1D90
	private static void UpdateTrackedInstances() { }

	// RVA: 0x26D20C0 Offset: 0x26D0AC0 VA: 0x1826D20C0
	public void .ctor() { }

	// RVA: 0x26D2030 Offset: 0x26D0A30 VA: 0x1826D2030
	private static void .cctor() { }
}

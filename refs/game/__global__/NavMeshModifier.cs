public class NavMeshModifier : MonoBehaviour // TypeDefIndex: 18984
{
	// Fields
	[SerializeField]
	private bool m_OverrideArea; // 0x20
	[SerializeField]
	private int m_Area; // 0x24
	[SerializeField]
	private bool m_OverrideGenerateLinks; // 0x28
	[SerializeField]
	private bool m_GenerateLinks; // 0x29
	[SerializeField]
	private bool m_IgnoreFromBuild; // 0x2A
	[SerializeField]
	private bool m_ApplyToChildren; // 0x2B
	[SerializeField]
	private List<int> m_AffectedAgents; // 0x30
	private static readonly List<NavMeshModifier> s_NavMeshModifiers; // 0x0

	// Properties
	public bool overrideArea { get; set; }
	public int area { get; set; }
	public bool overrideGenerateLinks { get; set; }
	public bool generateLinks { get; set; }
	public bool ignoreFromBuild { get; set; }
	public bool applyToChildren { get; set; }
	public static List<NavMeshModifier> activeModifiers { get; }

	// Methods

	// RVA: 0x4945E0 Offset: 0x492FE0 VA: 0x1804945E0
	public bool get_overrideArea() { }

	// RVA: 0x494600 Offset: 0x493000 VA: 0x180494600
	public void set_overrideArea(bool value) { }

	// RVA: 0x49CD40 Offset: 0x49B740 VA: 0x18049CD40
	public int get_area() { }

	// RVA: 0x49CD60 Offset: 0x49B760 VA: 0x18049CD60
	public void set_area(int value) { }

	// RVA: 0x493120 Offset: 0x491B20 VA: 0x180493120
	public bool get_overrideGenerateLinks() { }

	// RVA: 0x493130 Offset: 0x491B30 VA: 0x180493130
	public void set_overrideGenerateLinks(bool value) { }

	// RVA: 0x5A9D10 Offset: 0x5A8710 VA: 0x1805A9D10
	public bool get_generateLinks() { }

	// RVA: 0x5A9D20 Offset: 0x5A8720 VA: 0x1805A9D20
	public void set_generateLinks(bool value) { }

	// RVA: 0x844440 Offset: 0x842E40 VA: 0x180844440
	public bool get_ignoreFromBuild() { }

	// RVA: 0x844450 Offset: 0x842E50 VA: 0x180844450
	public void set_ignoreFromBuild(bool value) { }

	// RVA: 0x2642540 Offset: 0x2640F40 VA: 0x182642540
	public bool get_applyToChildren() { }

	// RVA: 0x26D2B40 Offset: 0x26D1540 VA: 0x1826D2B40
	public void set_applyToChildren(bool value) { }

	// RVA: 0x26D2AF0 Offset: 0x26D14F0 VA: 0x1826D2AF0
	public static List<NavMeshModifier> get_activeModifiers() { }

	// RVA: 0x26D2860 Offset: 0x26D1260 VA: 0x1826D2860
	private void OnEnable() { }

	// RVA: 0x26D27E0 Offset: 0x26D11E0 VA: 0x1826D27E0
	private void OnDisable() { }

	// RVA: 0x26D2730 Offset: 0x26D1130 VA: 0x1826D2730
	public bool AffectsAgentType(int agentTypeID) { }

	// RVA: 0x26D2A20 Offset: 0x26D1420 VA: 0x1826D2A20
	public void .ctor() { }

	// RVA: 0x26D2990 Offset: 0x26D1390 VA: 0x1826D2990
	private static void .cctor() { }
}

public abstract class TextAsset : ScriptableObject // TypeDefIndex: 16721
{
	// Fields
	[SerializeField]
	internal string m_Version; // 0x18
	internal int m_InstanceID; // 0x20
	internal int m_HashCode; // 0x24
	[SerializeField]
	[FormerlySerializedAs("material")]
	internal Material m_Material; // 0x28
	internal int m_MaterialHashCode; // 0x30

	// Properties
	public string version { get; set; }
	public int instanceID { get; }
	public int hashCode { get; set; }
	public Material material { get; set; }
	public int materialHashCode { get; set; }

	// Methods

	// RVA: 0x1670E50 Offset: 0x166F850 VA: 0x181670E50
	public string get_version() { }

	// RVA: 0x43EFE0 Offset: 0x43D9E0 VA: 0x18043EFE0
	internal void set_version(string value) { }

	// RVA: 0x2BD6CA0 Offset: 0x2BD56A0 VA: 0x182BD6CA0
	public int get_instanceID() { }

	// RVA: 0x2D5B350 Offset: 0x2D59D50 VA: 0x182D5B350
	public int get_hashCode() { }

	// RVA: 0x49CD60 Offset: 0x49B760 VA: 0x18049CD60
	public void set_hashCode(int value) { }

	// RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0
	public Material get_material() { }

	// RVA: 0x4513F0 Offset: 0x44FDF0 VA: 0x1804513F0
	public void set_material(Material value) { }

	// RVA: 0x2D5B390 Offset: 0x2D59D90 VA: 0x182D5B390
	public int get_materialHashCode() { }

	// RVA: 0x54D060 Offset: 0x54BA60 VA: 0x18054D060
	public void set_materialHashCode(int value) { }

	// RVA: 0x6CAB30 Offset: 0x6C9530 VA: 0x1806CAB30
	protected void .ctor() { }
}

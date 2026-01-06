public abstract class TMP_Asset : ScriptableObject // TypeDefIndex: 14866
{
	// Fields
	[SerializeField]
	internal string m_Version; // 0x18
	internal int m_InstanceID; // 0x20
	internal int m_HashCode; // 0x24
	[SerializeField]
	internal FaceInfo m_FaceInfo; // 0x28
	[SerializeField]
	[FormerlySerializedAs("material")]
	internal Material m_Material; // 0x88
	internal int m_MaterialHashCode; // 0x90

	// Properties
	public string version { get; set; }
	public int instanceID { get; }
	public int hashCode { get; set; }
	public FaceInfo faceInfo { get; set; }
	public Material material { get; set; }
	public int materialHashCode { get; set; }

	// Methods

	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	public string get_version() { }

	// RVA: 0x43EFE0 Offset: 0x43D9E0 VA: 0x18043EFE0
	internal void set_version(string value) { }

	// RVA: 0x2BD6CA0 Offset: 0x2BD56A0 VA: 0x182BD6CA0
	public int get_instanceID() { }

	// RVA: 0x2BD6C30 Offset: 0x2BD5630 VA: 0x182BD6C30
	public int get_hashCode() { }

	// RVA: 0x49CD60 Offset: 0x49B760 VA: 0x18049CD60
	public void set_hashCode(int value) { }

	// RVA: 0x2BD6BF0 Offset: 0x2BD55F0 VA: 0x182BD6BF0
	public FaceInfo get_faceInfo() { }

	// RVA: 0x2BD6DA0 Offset: 0x2BD57A0 VA: 0x182BD6DA0
	public void set_faceInfo(FaceInfo value) { }

	// RVA: 0x4CD080 Offset: 0x4CBA80 VA: 0x1804CD080
	public Material get_material() { }

	// RVA: 0x589030 Offset: 0x587A30 VA: 0x180589030
	public void set_material(Material value) { }

	// RVA: 0x2BD6CD0 Offset: 0x2BD56D0 VA: 0x182BD6CD0
	public int get_materialHashCode() { }

	// RVA: 0x589020 Offset: 0x587A20 VA: 0x180589020
	public void set_materialHashCode(int value) { }

	// RVA: 0x6CAB30 Offset: 0x6C9530 VA: 0x1806CAB30
	protected void .ctor() { }
}

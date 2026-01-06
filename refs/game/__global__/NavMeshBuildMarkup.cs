public struct NavMeshBuildMarkup // TypeDefIndex: 18877
{
	// Fields
	private int m_OverrideArea; // 0x0
	private int m_Area; // 0x4
	private int m_InheritIgnoreFromBuild; // 0x8
	private int m_IgnoreFromBuild; // 0xC
	private int m_OverrideGenerateLinks; // 0x10
	private int m_GenerateLinks; // 0x14
	private int m_InstanceID; // 0x18
	private int m_IgnoreChildren; // 0x1C

	// Properties
	public bool overrideArea { set; }
	public int area { set; }
	public bool ignoreFromBuild { set; }
	public bool overrideGenerateLinks { set; }
	public bool generateLinks { set; }
	public bool applyToChildren { set; }
	public Transform root { set; }

	// Methods

	// RVA: 0x2158CD0 Offset: 0x21576D0 VA: 0x182158CD0
	public void set_overrideArea(bool value) { }

	// RVA: 0x5276B0 Offset: 0x5260B0 VA: 0x1805276B0
	public void set_area(int value) { }

	// RVA: 0x2C62BA0 Offset: 0x2C615A0 VA: 0x182C62BA0
	public void set_ignoreFromBuild(bool value) { }

	// RVA: 0x2C62BB0 Offset: 0x2C615B0 VA: 0x182C62BB0
	public void set_overrideGenerateLinks(bool value) { }

	// RVA: 0x2C62B90 Offset: 0x2C61590 VA: 0x182C62B90
	public void set_generateLinks(bool value) { }

	// RVA: 0x2C62B80 Offset: 0x2C61580 VA: 0x182C62B80
	public void set_applyToChildren(bool value) { }

	// RVA: 0x2C62BC0 Offset: 0x2C615C0 VA: 0x182C62BC0
	public void set_root(Transform value) { }
}

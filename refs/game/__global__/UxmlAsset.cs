internal class UxmlAsset : IUxmlAttributes // TypeDefIndex: 6995
{
	// Fields
	[SerializeField]
	private string m_FullTypeName; // 0x10
	[SerializeField]
	private int m_Id; // 0x18
	[SerializeField]
	private int m_OrderInDocument; // 0x1C
	[SerializeField]
	private int m_ParentId; // 0x20
	[SerializeField]
	protected List<string> m_Properties; // 0x28

	// Properties
	public string fullTypeName { get; }
	public int id { get; }
	public int orderInDocument { get; }
	public int parentId { get; }

	// Methods

	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	public string get_fullTypeName() { }

	// RVA: 0x456E90 Offset: 0x455890 VA: 0x180456E90
	public int get_id() { }

	// RVA: 0x4A1F70 Offset: 0x4A0970 VA: 0x1804A1F70
	public int get_orderInDocument() { }

	// RVA: 0x494440 Offset: 0x492E40 VA: 0x180494440
	public int get_parentId() { }

	// RVA: 0x2DEC360 Offset: 0x2DEAD60 VA: 0x182DEC360 Slot: 4
	public bool TryGetAttributeValue(string propertyName, out string value) { }

	// RVA: 0x2DEC200 Offset: 0x2DEAC00 VA: 0x182DEC200
	public void SetAttribute(string name, string value) { }

	// RVA: 0x2DEC200 Offset: 0x2DEAC00 VA: 0x182DEC200
	private void SetOrAddProperty(string propertyName, string propertyValue) { }
}

public struct RaycastResult // TypeDefIndex: 16565
{
	// Fields
	private GameObject m_GameObject; // 0x0
	public BaseRaycaster module; // 0x8
	public float distance; // 0x10
	public float index; // 0x14
	public int depth; // 0x18
	public int sortingGroupID; // 0x1C
	public int sortingGroupOrder; // 0x20
	public int sortingLayer; // 0x24
	public int sortingOrder; // 0x28
	public Vector3 worldPosition; // 0x2C
	public Vector3 worldNormal; // 0x38
	public Vector2 screenPosition; // 0x44
	public int displayIndex; // 0x4C

	// Properties
	public GameObject gameObject { get; set; }
	public bool isValid { get; }

	// Methods

	// RVA: 0x43C7F0 Offset: 0x43B1F0 VA: 0x18043C7F0
	public GameObject get_gameObject() { }

	// RVA: 0x48A530 Offset: 0x488F30 VA: 0x18048A530
	public void set_gameObject(GameObject value) { }

	// RVA: 0x2F52060 Offset: 0x2F50A60 VA: 0x182F52060
	public bool get_isValid() { }

	// RVA: 0x2F51A10 Offset: 0x2F50410 VA: 0x182F51A10
	public void Clear() { }

	// RVA: 0x2F51B00 Offset: 0x2F50500 VA: 0x182F51B00 Slot: 3
	public override string ToString() { }
}

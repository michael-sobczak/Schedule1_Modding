public struct LayerMask // TypeDefIndex: 11831
{
	// Fields
	[NativeName("m_Bits")]
	private int m_Mask; // 0x0

	// Properties
	public int value { get; set; }

	// Methods

	// RVA: 0x2CBEE40 Offset: 0x2CBD840 VA: 0x182CBEE40
	public static int op_Implicit(LayerMask mask) { }

	// RVA: 0x2CBEE40 Offset: 0x2CBD840 VA: 0x182CBEE40
	public static LayerMask op_Implicit(int intVal) { }

	// RVA: 0x2C62C50 Offset: 0x2C61650 VA: 0x182C62C50
	public int get_value() { }

	// RVA: 0x5276C0 Offset: 0x5260C0 VA: 0x1805276C0
	public void set_value(int value) { }

	[NativeMethod("LayerToString")]
	[StaticAccessor("GetTagManager()", 0)]
	// RVA: 0x2CBEDC0 Offset: 0x2CBD7C0 VA: 0x182CBEDC0
	public static string LayerToName(int layer) { }

	[StaticAccessor("GetTagManager()", 0)]
	[NativeMethod("StringToLayer")]
	// RVA: 0x2CBEE00 Offset: 0x2CBD800 VA: 0x182CBEE00
	public static int NameToLayer(string layerName) { }

	// RVA: 0x2CBECD0 Offset: 0x2CBD6D0 VA: 0x182CBECD0
	public static int GetMask(string[] layerNames) { }
}

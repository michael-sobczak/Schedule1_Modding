public struct SortingLayer // TypeDefIndex: 11580
{
	// Fields
	private int m_Id; // 0x0

	// Properties
	public int id { get; }
	public int value { get; }
	public static SortingLayer[] layers { get; }

	// Methods

	// RVA: 0x2C62C50 Offset: 0x2C61650 VA: 0x182C62C50
	public int get_id() { }

	// RVA: 0x2CA0A70 Offset: 0x2C9F470 VA: 0x182CA0A70
	public int get_value() { }

	// RVA: 0x2CA09C0 Offset: 0x2C9F3C0 VA: 0x182CA09C0
	public static SortingLayer[] get_layers() { }

	[FreeFunction("GetTagManager().GetSortingLayerIDs")]
	// RVA: 0x2CA08D0 Offset: 0x2C9F2D0 VA: 0x182CA08D0
	private static int[] GetSortingLayerIDsInternal() { }

	[FreeFunction("GetTagManager().GetSortingLayerValueFromUniqueID")]
	// RVA: 0x2CA0890 Offset: 0x2C9F290 VA: 0x182CA0890
	public static int GetLayerValueFromID(int id) { }

	[FreeFunction("GetTagManager().GetSortingLayerUniqueIDFromName")]
	// RVA: 0x2CA0980 Offset: 0x2C9F380 VA: 0x182CA0980
	public static int NameToID(string name) { }

	[FreeFunction("GetTagManager().GetSortingLayerNameFromUniqueID")]
	// RVA: 0x2CA0900 Offset: 0x2C9F300 VA: 0x182CA0900
	public static string IDToName(int id) { }

	[FreeFunction("GetTagManager().IsSortingLayerUniqueIDValid")]
	// RVA: 0x2CA0940 Offset: 0x2C9F340 VA: 0x182CA0940
	public static bool IsValid(int id) { }
}

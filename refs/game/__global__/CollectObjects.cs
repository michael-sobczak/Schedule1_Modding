public enum CollectObjects // TypeDefIndex: 18986
{
	// Fields
	public int value__; // 0x0
	[InspectorName("All Game Objects")]
	public const CollectObjects All = 0;
	[InspectorName("Volume")]
	public const CollectObjects Volume = 1;
	[InspectorName("Current Object Hierarchy")]
	public const CollectObjects Children = 2;
	[InspectorName("NavMeshModifier Component Only")]
	public const CollectObjects MarkedWithModifier = 3;
}

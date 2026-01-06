public class DeformMesh : ScalingModule // TypeDefIndex: 10724
{
	// Fields
	[HideInInspector]
	[InputSlotInfo(new[] { typeof(CGVMesh) }, Array = True, Name = "VMesh")]
	public CGModuleInputSlot InVMeshes; // 0xF0
	[InputSlotInfo(new[] { typeof(CGPath) }, Name = "Path", DisplayName = "Volume/Rasterized Path")]
	[HideInInspector]
	public CGModuleInputSlot InPath; // 0xF8
	[InputSlotInfo(new[] { typeof(CGSpots) }, Array = True, Name = "Spots", Optional = True)]
	[HideInInspector]
	public CGModuleInputSlot InSpots; // 0x100
	[HideInInspector]
	[OutputSlotInfo(typeof(CGVMesh), Name = "VMesh", Array = True)]
	public CGModuleOutputSlot OutVMeshes; // 0x108
	[OutputSlotInfo(typeof(CGSpots), Array = True, Name = "Spots")]
	[HideInInspector]
	public CGModuleOutputSlot OutSpots; // 0x110
	[Tooltip("Stretch the meshes to make them fit the end of the path")]
	[SerializeField]
	[Tab("General")]
	private bool stretchToEnd; // 0x118
	private readonly ThreadPoolWorker<CGSpot> threadWorker; // 0x120

	// Properties
	public bool StretchToEnd { get; set; }

	// Methods

	// RVA: 0x51D980 Offset: 0x51C380 VA: 0x18051D980
	public bool get_StretchToEnd() { }

	// RVA: 0x51DD00 Offset: 0x51C700 VA: 0x18051DD00
	public void set_StretchToEnd(bool value) { }

	// RVA: 0x5254A0 Offset: 0x523EA0 VA: 0x1805254A0 Slot: 13
	public override void Reset() { }

	// RVA: 0x524BC0 Offset: 0x5235C0 VA: 0x180524BC0 Slot: 12
	protected override void OnDestroy() { }

	// RVA: 0x524C20 Offset: 0x523620 VA: 0x180524C20 Slot: 14
	public override void Refresh() { }

	// RVA: 0x5248D0 Offset: 0x5232D0 VA: 0x1805248D0
	public static void DeformMeshes(List<CGVMesh> inputMeshes, SubArray<CGSpot> inputSpots, SubArray<CGSpot> outputSpots, CGVMesh[] outputMeshes, CGPath path, bool stretchToEnd, ThreadPoolWorker<CGSpot> threadPoolWorker) { }

	// RVA: 0x523E00 Offset: 0x522800 VA: 0x180523E00
	public static void DeformMeshes(List<CGVMesh> inputMeshes, SubArray<CGSpot> inputSpots, SubArray<CGSpot> outputSpots, CGVMesh[] outputMeshes, CGPath path, bool stretchToEnd, ThreadPoolWorker<CGSpot> threadPoolWorker, ScaleParameters scaleParameters) { }

	// RVA: 0x524B30 Offset: 0x523530 VA: 0x180524B30
	private static bool IsCurveEvaluationNeeded(ScaleParameters scaleParameters) { }

	// RVA: 0x524A30 Offset: 0x523430 VA: 0x180524A30
	private static float GetSpotDistance(CGPath path, Vector3 spotPosition, Vector3[] pathPoints, int maxIndex, float[] pathRelativeDistances, float pathLength) { }

	// RVA: 0x5254E0 Offset: 0x523EE0 VA: 0x1805254E0
	private static Nullable<SubArray<CGSpot>> ToOneDimensionalArray(List<CGSpots> spotsList, out bool arrayIsCopy) { }

	// RVA: 0x525A30 Offset: 0x524430 VA: 0x180525A30
	public void .ctor() { }
}

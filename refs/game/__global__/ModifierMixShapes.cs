public class ModifierMixShapes : CGModule, IOnRequestProcessing, IPathProvider // TypeDefIndex: 10738
{
	// Fields
	private const int MixMinValue = -1;
	private const int MixMaxValue = 1;
	[HideInInspector]
	[InputSlotInfo(new[] { typeof(CGShape) }, Name = "Shape A")]
	public CGModuleInputSlot InShapeA; // 0xC0
	[HideInInspector]
	[InputSlotInfo(new[] { typeof(CGShape) }, Name = "Shape B")]
	public CGModuleInputSlot InShapeB; // 0xC8
	[HideInInspector]
	[OutputSlotInfo(typeof(CGShape))]
	public CGModuleOutputSlot OutShape; // 0xD0
	[SerializeField]
	[RangeEx(-1, 1, "", "", Tooltip = "Mix between the shapes. Values between -1 for Shape A and 1 for Shape B")]
	private float m_Mix; // 0xD8

	// Properties
	public float Mix { get; set; }
	public bool PathIsClosed { get; }

	// Methods

	// RVA: 0x537070 Offset: 0x535A70 VA: 0x180537070
	public float get_Mix() { }

	// RVA: 0x537150 Offset: 0x535B50 VA: 0x180537150
	public void set_Mix(float value) { }

	// RVA: 0x538400 Offset: 0x536E00 VA: 0x180538400 Slot: 19
	public bool get_PathIsClosed() { }

	// RVA: 0x4EFB50 Offset: 0x4EE550 VA: 0x1804EFB50 Slot: 4
	protected override void OnEnable() { }

	// RVA: 0x536F40 Offset: 0x535940 VA: 0x180536F40 Slot: 13
	public override void Reset() { }

	// RVA: 0x5380C0 Offset: 0x536AC0 VA: 0x1805380C0 Slot: 18
	public CGData[] OnSlotDataRequest(CGModuleInputSlot requestedBy, CGModuleOutputSlot requestedSlot, CGDataRequestParameter[] requests) { }

	[CanBeNull]
	// RVA: 0x538000 Offset: 0x536A00 VA: 0x180538000
	public static CGShape MixShapes(CGShape shapeA, CGShape shapeB, float mix, List<string> warningsContainer, bool ignoreWarnings = False) { }

	// RVA: 0x537190 Offset: 0x535B90 VA: 0x180537190
	public static void InterpolateShape(CGShape resultShape, CGShape shapeA, CGShape shapeB, float mix, List<string> warningsContainer, bool ignoreWarnings = False) { }

	// RVA: 0x538320 Offset: 0x536D20 VA: 0x180538320
	public void .ctor() { }
}

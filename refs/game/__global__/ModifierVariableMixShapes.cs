public class ModifierVariableMixShapes : CGModule, IOnRequestProcessing, IPathProvider // TypeDefIndex: 10744
{
	// Fields
	[InputSlotInfo(new[] { typeof(CGShape) }, Name = "Shape A")]
	[HideInInspector]
	public CGModuleInputSlot InShapeA; // 0xC0
	[InputSlotInfo(new[] { typeof(CGShape) }, Name = "Shape B")]
	[HideInInspector]
	public CGModuleInputSlot InShapeB; // 0xC8
	[ShapeOutputSlotInfo(OutputsVariableShape = True, Array = True, ArrayType = 2)]
	[HideInInspector]
	public CGModuleOutputSlot OutShape; // 0xD0
	[Label("Mix Curve", "Mix between the shapes. Values (Y axis) between -1 for Shape A and 1 for Shape B. Times (X axis) between 0 for extrusion start and 1 for extrusion end")]
	[SerializeField]
	private AnimationCurve m_MixCurve; // 0xD8

	// Properties
	public bool PathIsClosed { get; }
	public AnimationCurve MixCurve { get; set; }

	// Methods

	// RVA: 0x539AA0 Offset: 0x5384A0 VA: 0x180539AA0 Slot: 19
	public bool get_PathIsClosed() { }

	// RVA: 0x4E8C90 Offset: 0x4E7690 VA: 0x1804E8C90
	public AnimationCurve get_MixCurve() { }

	// RVA: 0x527020 Offset: 0x525A20 VA: 0x180527020
	public void set_MixCurve(AnimationCurve value) { }

	// RVA: 0x539940 Offset: 0x538340 VA: 0x180539940 Slot: 13
	public override void Reset() { }

	// RVA: 0x539610 Offset: 0x538010 VA: 0x180539610 Slot: 18
	public CGData[] OnSlotDataRequest(CGModuleInputSlot requestedBy, CGModuleOutputSlot requestedSlot, CGDataRequestParameter[] requests) { }

	// RVA: 0x539990 Offset: 0x538390 VA: 0x180539990
	public void .ctor() { }
}

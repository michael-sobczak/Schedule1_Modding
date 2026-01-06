public class InputSplineShape : SplineInputModuleBase, IExternalInput, IOnRequestProcessing, IPathProvider // TypeDefIndex: 10731
{
	// Fields
	[HideInInspector]
	[OutputSlotInfo(typeof(CGShape))]
	public CGModuleOutputSlot OutShape; // 0xD8
	[CGResourceManager("Shape")]
	[Tab("General", Sort = 0)]
	[FieldCondition("m_Shape", null, False, 5, "Missing Shape input", 1)]
	[SerializeField]
	private CurvySpline m_Shape; // 0xE0

	// Properties
	public CurvySpline Shape { get; set; }
	public bool SupportsIPE { get; }
	public bool FreeForm { get; set; }
	protected override CurvySpline InputSpline { get; set; }

	// Methods

	// RVA: 0x4E8CA0 Offset: 0x4E76A0 VA: 0x1804E8CA0
	public CurvySpline get_Shape() { }

	// RVA: 0x533EB0 Offset: 0x5328B0 VA: 0x180533EB0
	public void set_Shape(CurvySpline value) { }

	// RVA: 0x533CB0 Offset: 0x5326B0 VA: 0x180533CB0 Slot: 22
	public bool get_SupportsIPE() { }

	// RVA: 0x533CB0 Offset: 0x5326B0 VA: 0x180533CB0
	public bool get_FreeForm() { }

	// RVA: 0x533D70 Offset: 0x532770 VA: 0x180533D70
	public void set_FreeForm(bool value) { }

	// RVA: 0x533990 Offset: 0x532390 VA: 0x180533990 Slot: 23
	public CGData[] OnSlotDataRequest(CGModuleInputSlot requestedBy, CGModuleOutputSlot requestedSlot, CGDataRequestParameter[] requests) { }

	// RVA: -1 Offset: -1
	public T SetManagedShape<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEE0350 Offset: 0xEDED50 VA: 0x180EE0350
	|-InputSplineShape.SetManagedShape<object>
	*/

	// RVA: 0x533B90 Offset: 0x532590 VA: 0x180533B90
	public void RemoveManagedShape() { }

	// RVA: 0x4E8CA0 Offset: 0x4E76A0 VA: 0x1804E8CA0 Slot: 19
	protected override CurvySpline get_InputSpline() { }

	// RVA: 0x533EB0 Offset: 0x5328B0 VA: 0x180533EB0 Slot: 20
	protected override void set_InputSpline(CurvySpline value) { }

	// RVA: 0x533B00 Offset: 0x532500 VA: 0x180533B00 Slot: 21
	protected override void OnSplineAssigned() { }

	// RVA: 0x533C40 Offset: 0x532640 VA: 0x180533C40
	public void .ctor() { }
}

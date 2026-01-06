public class InputSplinePath : SplineInputModuleBase, IExternalInput, IOnRequestProcessing, IPathProvider // TypeDefIndex: 10730
{
	// Fields
	[OutputSlotInfo(typeof(CGPath))]
	[HideInInspector]
	public CGModuleOutputSlot Path; // 0xD8
	[SerializeField]
	[CGResourceManager("Spline")]
	[FieldCondition("m_Spline", null, False, 5, "Missing Spline input", 1)]
	[Tab("General", Sort = 0)]
	private CurvySpline m_Spline; // 0xE0

	// Properties
	public CurvySpline Spline { get; set; }
	public bool SupportsIPE { get; }
	protected override CurvySpline InputSpline { get; set; }

	// Methods

	// RVA: 0x4E8CA0 Offset: 0x4E76A0 VA: 0x1804E8CA0
	public CurvySpline get_Spline() { }

	// RVA: 0x5338D0 Offset: 0x5322D0 VA: 0x1805338D0
	public void set_Spline(CurvySpline value) { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 22
	public bool get_SupportsIPE() { }

	// RVA: 0x533610 Offset: 0x532010 VA: 0x180533610 Slot: 23
	public CGData[] OnSlotDataRequest(CGModuleInputSlot requestedBy, CGModuleOutputSlot requestedSlot, CGDataRequestParameter[] requests) { }

	// RVA: 0x5337C0 Offset: 0x5321C0 VA: 0x1805337C0 Slot: 17
	public override void OnTemplateCreated() { }

	// RVA: 0x4E8CA0 Offset: 0x4E76A0 VA: 0x1804E8CA0 Slot: 19
	protected override CurvySpline get_InputSpline() { }

	// RVA: 0x5338C0 Offset: 0x5322C0 VA: 0x1805338C0 Slot: 20
	protected override void set_InputSpline(CurvySpline value) { }

	// RVA: 0x533850 Offset: 0x532250 VA: 0x180533850
	public void .ctor() { }
}

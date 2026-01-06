public class UITextSplineController : SplineController, IMeshModifier // TypeDefIndex: 10601
{
	// Fields
	[Section("Orientation", True, False, 100)]
	[Tooltip("If true, the text characters will keep the same orientation regardless of the spline they follow")]
	[SerializeField]
	private bool staticOrientation; // 0x108
	private Graphic m_Graphic; // 0x110
	private RectTransform rectTransform; // 0x118
	private Text text; // 0x120

	// Properties
	public bool StaticOrientation { get; set; }
	protected override bool ShowOrientationSection { get; }
	protected override bool ShowOffsetSection { get; }
	protected Text Text { get; }
	protected RectTransform Rect { get; }
	protected Graphic graphic { get; }
	public override CurvySpline Spline { get; set; }

	// Methods

	// RVA: 0x4F17A0 Offset: 0x4F01A0 VA: 0x1804F17A0
	public bool get_StaticOrientation() { }

	// RVA: 0x4F1990 Offset: 0x4F0390 VA: 0x1804F1990
	public void set_StaticOrientation(bool value) { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 33
	protected override bool get_ShowOrientationSection() { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 34
	protected override bool get_ShowOffsetSection() { }

	// RVA: 0x4F17B0 Offset: 0x4F01B0 VA: 0x1804F17B0
	protected Text get_Text() { }

	// RVA: 0x4F1700 Offset: 0x4F0100 VA: 0x1804F1700
	protected RectTransform get_Rect() { }

	// RVA: 0x4F1850 Offset: 0x4F0250 VA: 0x1804F1850
	protected Graphic get_graphic() { }

	// RVA: 0x4F0320 Offset: 0x4EED20 VA: 0x1804F0320 Slot: 20
	protected override void InitializedApplyDeltaTime(float deltaTime) { }

	// RVA: 0x4F0710 Offset: 0x4EF110 VA: 0x1804F0710 Slot: 48
	public void ModifyMesh(Mesh verts) { }

	// RVA: 0x4F04A0 Offset: 0x4EEEA0 VA: 0x1804F04A0 Slot: 49
	public void ModifyMesh(VertexHelper vertexHelper) { }

	[UsedImplicitly]
	// RVA: 0x4F0F50 Offset: 0x4EF950 VA: 0x1804F0F50
	private void UpdateGlyph(UITextSplineController.IGlyph glyph) { }

	// RVA: 0x4F0AF0 Offset: 0x4EF4F0 VA: 0x1804F0AF0 Slot: 4
	protected override void OnEnable() { }

	// RVA: 0x4F0A20 Offset: 0x4EF420 VA: 0x1804F0A20 Slot: 6
	protected override void OnDisable() { }

	// RVA: 0x4F0D70 Offset: 0x4EF770 VA: 0x1804F0D70 Slot: 7
	protected override void OnValidate() { }

	// RVA: 0x4B6150 Offset: 0x4B4B50 VA: 0x1804B6150 Slot: 45
	public override CurvySpline get_Spline() { }

	// RVA: 0x4F18F0 Offset: 0x4F02F0 VA: 0x1804F18F0 Slot: 46
	public override void set_Spline(CurvySpline value) { }

	// RVA: 0x4F0200 Offset: 0x4EEC00 VA: 0x1804F0200 Slot: 24
	protected override void BindEvents() { }

	// RVA: 0x4F0E30 Offset: 0x4EF830 VA: 0x1804F0E30 Slot: 25
	protected override void UnbindEvents() { }

	// RVA: 0x4F0210 Offset: 0x4EEC10 VA: 0x1804F0210
	private void BindSplineRelatedEvents() { }

	// RVA: 0x4F0E40 Offset: 0x4EF840 VA: 0x1804F0E40
	private void UnbindSplineRelatedEvents() { }

	// RVA: 0x4F0BF0 Offset: 0x4EF5F0 VA: 0x1804F0BF0
	private void OnSplineRefreshed(CurvySplineEventArgs e) { }

	// RVA: 0x4F16F0 Offset: 0x4F00F0 VA: 0x1804F16F0
	public void .ctor() { }
}

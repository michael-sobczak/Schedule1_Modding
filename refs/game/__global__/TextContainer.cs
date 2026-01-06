public class TextContainer : UIBehaviour // TypeDefIndex: 14845
{
	// Fields
	private bool m_hasChanged; // 0x20
	[SerializeField]
	private Vector2 m_pivot; // 0x24
	[SerializeField]
	private TextContainerAnchors m_anchorPosition; // 0x2C
	[SerializeField]
	private Rect m_rect; // 0x30
	private bool m_isDefaultWidth; // 0x40
	private bool m_isDefaultHeight; // 0x41
	private bool m_isAutoFitting; // 0x42
	private Vector3[] m_corners; // 0x48
	private Vector3[] m_worldCorners; // 0x50
	[SerializeField]
	private Vector4 m_margins; // 0x58
	private RectTransform m_rectTransform; // 0x68
	private static Vector2 k_defaultSize; // 0x0
	private TextMeshPro m_textMeshPro; // 0x70

	// Properties
	public bool hasChanged { get; set; }
	public Vector2 pivot { get; set; }
	public TextContainerAnchors anchorPosition { get; set; }
	public Rect rect { get; set; }
	public Vector2 size { get; set; }
	public float width { get; set; }
	public float height { get; set; }
	public bool isDefaultWidth { get; }
	public bool isDefaultHeight { get; }
	public bool isAutoFitting { get; set; }
	public Vector3[] corners { get; }
	public Vector3[] worldCorners { get; }
	public Vector4 margins { get; set; }
	public RectTransform rectTransform { get; }
	public TextMeshPro textMeshPro { get; }

	// Methods

	// RVA: 0x4945E0 Offset: 0x492FE0 VA: 0x1804945E0
	public bool get_hasChanged() { }

	// RVA: 0x494600 Offset: 0x493000 VA: 0x180494600
	public void set_hasChanged(bool value) { }

	// RVA: 0x2BC30E0 Offset: 0x2BC1AE0 VA: 0x182BC30E0
	public Vector2 get_pivot() { }

	// RVA: 0x2BC3460 Offset: 0x2BC1E60 VA: 0x182BC3460
	public void set_pivot(Vector2 value) { }

	// RVA: 0x65E590 Offset: 0x65CF90 VA: 0x18065E590
	public TextContainerAnchors get_anchorPosition() { }

	// RVA: 0x2BC3250 Offset: 0x2BC1C50 VA: 0x182BC3250
	public void set_anchorPosition(TextContainerAnchors value) { }

	// RVA: 0x6FC320 Offset: 0x6FAD20 VA: 0x1806FC320
	public Rect get_rect() { }

	// RVA: 0x2BC34E0 Offset: 0x2BC1EE0 VA: 0x182BC34E0
	public void set_rect(Rect value) { }

	// RVA: 0x2BC3190 Offset: 0x2BC1B90 VA: 0x182BC3190
	public Vector2 get_size() { }

	// RVA: 0x2BC3540 Offset: 0x2BC1F40 VA: 0x182BC3540
	public void set_size(Vector2 value) { }

	// RVA: 0x2BC3240 Offset: 0x2BC1C40 VA: 0x182BC3240
	public float get_width() { }

	// RVA: 0x2BC35D0 Offset: 0x2BC1FD0 VA: 0x182BC35D0
	public void set_width(float value) { }

	// RVA: 0x2BC30D0 Offset: 0x2BC1AD0 VA: 0x182BC30D0
	public float get_height() { }

	// RVA: 0x2BC3380 Offset: 0x2BC1D80 VA: 0x182BC3380
	public void set_height(float value) { }

	// RVA: 0x4988A0 Offset: 0x4972A0 VA: 0x1804988A0
	public bool get_isDefaultWidth() { }

	// RVA: 0x1C12200 Offset: 0x1C10C00 VA: 0x181C12200
	public bool get_isDefaultHeight() { }

	// RVA: 0xC31540 Offset: 0xC2FF40 VA: 0x180C31540
	public bool get_isAutoFitting() { }

	// RVA: 0xC31570 Offset: 0xC2FF70 VA: 0x180C31570
	public void set_isAutoFitting(bool value) { }

	// RVA: 0x4C1D80 Offset: 0x4C0780 VA: 0x1804C1D80
	public Vector3[] get_corners() { }

	// RVA: 0x441BA0 Offset: 0x4405A0 VA: 0x180441BA0
	public Vector3[] get_worldCorners() { }

	// RVA: 0x4F9F10 Offset: 0x4F8910 VA: 0x1804F9F10
	public Vector4 get_margins() { }

	// RVA: 0x2BC33D0 Offset: 0x2BC1DD0 VA: 0x182BC33D0
	public void set_margins(Vector4 value) { }

	// RVA: 0x2BC3100 Offset: 0x2BC1B00 VA: 0x182BC3100
	public RectTransform get_rectTransform() { }

	// RVA: 0x2BC31B0 Offset: 0x2BC1BB0 VA: 0x182BC31B0
	public TextMeshPro get_textMeshPro() { }

	// RVA: 0x2BC25B0 Offset: 0x2BC0FB0 VA: 0x182BC25B0 Slot: 4
	protected override void Awake() { }

	// RVA: 0x2BC2B50 Offset: 0x2BC1550 VA: 0x182BC2B50 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x2BC29C0 Offset: 0x2BC13C0 VA: 0x182BC29C0
	private void OnContainerChanged() { }

	// RVA: 0x2BC2B60 Offset: 0x2BC1560 VA: 0x182BC2B60 Slot: 10
	protected override void OnRectTransformDimensionsChange() { }

	// RVA: 0x2BC2E20 Offset: 0x2BC1820 VA: 0x182BC2E20
	private void SetRect(Vector2 size) { }

	// RVA: 0x2BC2E70 Offset: 0x2BC1870 VA: 0x182BC2E70
	private void UpdateCorners() { }

	// RVA: 0x2BC2870 Offset: 0x2BC1270 VA: 0x182BC2870
	private Vector2 GetPivot(TextContainerAnchors anchor) { }

	// RVA: 0x2BC2660 Offset: 0x2BC1060 VA: 0x182BC2660
	private TextContainerAnchors GetAnchorPosition(Vector2 pivot) { }

	// RVA: 0x2BC3050 Offset: 0x2BC1A50 VA: 0x182BC3050
	public void .ctor() { }

	// RVA: 0x2BC3010 Offset: 0x2BC1A10 VA: 0x182BC3010
	private static void .cctor() { }
}

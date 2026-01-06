public class Shadow : BaseMeshEffect // TypeDefIndex: 16501
{
	// Fields
	[SerializeField]
	private Color m_EffectColor; // 0x28
	[SerializeField]
	private Vector2 m_EffectDistance; // 0x38
	[SerializeField]
	private bool m_UseGraphicAlpha; // 0x40
	private const float kMaxEffectDistance = 600;

	// Properties
	public Color effectColor { get; set; }
	public Vector2 effectDistance { get; set; }
	public bool useGraphicAlpha { get; set; }

	// Methods

	// RVA: 0x2F528A0 Offset: 0x2F512A0 VA: 0x182F528A0
	protected void .ctor() { }

	// RVA: 0x4D8510 Offset: 0x4D6F10 VA: 0x1804D8510
	public Color get_effectColor() { }

	// RVA: 0x2F528D0 Offset: 0x2F512D0 VA: 0x182F528D0
	public void set_effectColor(Color value) { }

	// RVA: 0x57CCD0 Offset: 0x57B6D0 VA: 0x18057CCD0
	public Vector2 get_effectDistance() { }

	// RVA: 0x2F52970 Offset: 0x2F51370 VA: 0x182F52970
	public void set_effectDistance(Vector2 value) { }

	// RVA: 0x4988A0 Offset: 0x4972A0 VA: 0x1804988A0
	public bool get_useGraphicAlpha() { }

	// RVA: 0x2F52A70 Offset: 0x2F51470 VA: 0x182F52A70
	public void set_useGraphicAlpha(bool value) { }

	// RVA: 0x2F523D0 Offset: 0x2F50DD0 VA: 0x182F523D0
	protected void ApplyShadowZeroAlloc(List<UIVertex> verts, Color32 color, int start, int end, float x, float y) { }

	// RVA: 0x2F52750 Offset: 0x2F51150 VA: 0x182F52750
	protected void ApplyShadow(List<UIVertex> verts, Color32 color, int start, int end, float x, float y) { }

	// RVA: 0x2F52760 Offset: 0x2F51160 VA: 0x182F52760 Slot: 20
	public override void ModifyMesh(VertexHelper vh) { }
}

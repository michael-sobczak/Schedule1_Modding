public abstract class MaskableGraphic : Graphic, IClippable, IMaskable, IMaterialModifier // TypeDefIndex: 16452
{
	// Fields
	protected bool m_ShouldRecalculateStencil; // 0xA8
	protected Material m_MaskMaterial; // 0xB0
	private RectMask2D m_ParentMask; // 0xB8
	[SerializeField]
	private bool m_Maskable; // 0xC0
	private bool m_IsMaskingGraphic; // 0xC1
	[EditorBrowsable(1)]
	[Obsolete("Not used anymore.", True)]
	protected bool m_IncludeForMasking; // 0xC2
	[SerializeField]
	private MaskableGraphic.CullStateChangedEvent m_OnCullStateChanged; // 0xC8
	[EditorBrowsable(1)]
	[Obsolete("Not used anymore", True)]
	protected bool m_ShouldRecalculate; // 0xD0
	protected int m_StencilValue; // 0xD4
	private readonly Vector3[] m_Corners; // 0xD8

	// Properties
	public MaskableGraphic.CullStateChangedEvent onCullStateChanged { get; set; }
	public bool maskable { get; set; }
	public bool isMaskingGraphic { get; set; }
	private Rect rootCanvasRect { get; }

	// Methods

	// RVA: 0x4B6170 Offset: 0x4B4B70 VA: 0x1804B6170
	public MaskableGraphic.CullStateChangedEvent get_onCullStateChanged() { }

	// RVA: 0x4B6CC0 Offset: 0x4B56C0 VA: 0x1804B6CC0
	public void set_onCullStateChanged(MaskableGraphic.CullStateChangedEvent value) { }

	// RVA: 0x4E8B60 Offset: 0x4E7560 VA: 0x1804E8B60
	public bool get_maskable() { }

	// RVA: 0x2F2CFD0 Offset: 0x2F2B9D0 VA: 0x182F2CFD0
	public void set_maskable(bool value) { }

	// RVA: 0x4E8CC0 Offset: 0x4E76C0 VA: 0x1804E8CC0
	public bool get_isMaskingGraphic() { }

	// RVA: 0x2F2CFC0 Offset: 0x2F2B9C0 VA: 0x182F2CFC0
	public void set_isMaskingGraphic(bool value) { }

	// RVA: 0x2F2C510 Offset: 0x2F2AF10 VA: 0x182F2C510 Slot: 58
	public virtual Material GetModifiedMaterial(Material baseMaterial) { }

	// RVA: 0x2F2C3A0 Offset: 0x2F2ADA0 VA: 0x182F2C3A0 Slot: 59
	public virtual void Cull(Rect clipRect, bool validRect) { }

	// RVA: 0x2F2CB20 Offset: 0x2F2B520 VA: 0x182F2CB20
	private void UpdateCull(bool cull) { }

	// RVA: 0x2F2C8F0 Offset: 0x2F2B2F0 VA: 0x182F2C8F0 Slot: 60
	public virtual void SetClipRect(Rect clipRect, bool validRect) { }

	// RVA: 0x2F2C950 Offset: 0x2F2B350 VA: 0x182F2C950 Slot: 61
	public virtual void SetClipSoftness(Vector2 clipSoftness) { }

	// RVA: 0x2F2C790 Offset: 0x2F2B190 VA: 0x182F2C790 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x2F2C6D0 Offset: 0x2F2B0D0 VA: 0x182F2C6D0 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x2F2C7F0 Offset: 0x2F2B1F0 VA: 0x182F2C7F0 Slot: 12
	protected override void OnTransformParentChanged() { }

	[Obsolete("Not used anymore.", True)]
	[EditorBrowsable(1)]
	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 62
	public virtual void ParentMaskStateChanged() { }

	// RVA: 0x2F2C670 Offset: 0x2F2B070 VA: 0x182F2C670 Slot: 15
	protected override void OnCanvasHierarchyChanged() { }

	// RVA: 0x2F2CCF0 Offset: 0x2F2B6F0 VA: 0x182F2CCF0
	private Rect get_rootCanvasRect() { }

	// RVA: 0x2F2C990 Offset: 0x2F2B390 VA: 0x182F2C990
	private void UpdateClipParent() { }

	// RVA: 0x2F2C850 Offset: 0x2F2B250 VA: 0x182F2C850 Slot: 63
	public virtual void RecalculateClipping() { }

	// RVA: 0x2F2C860 Offset: 0x2F2B260 VA: 0x182F2C860 Slot: 64
	public virtual void RecalculateMasking() { }

	// RVA: 0x2F2CBF0 Offset: 0x2F2B5F0 VA: 0x182F2CBF0
	protected void .ctor() { }

	// RVA: 0x63D6C0 Offset: 0x63C0C0 VA: 0x18063D6C0 Slot: 50
	private GameObject UnityEngine.UI.IClippable.get_gameObject() { }
}

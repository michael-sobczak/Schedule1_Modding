public class Mask : UIBehaviour, ICanvasRaycastFilter, IMaterialModifier // TypeDefIndex: 16450
{
	// Fields
	private RectTransform m_RectTransform; // 0x20
	[SerializeField]
	private bool m_ShowMaskGraphic; // 0x28
	private Graphic m_Graphic; // 0x30
	private Material m_MaskMaterial; // 0x38
	private Material m_UnmaskMaterial; // 0x40

	// Properties
	public RectTransform rectTransform { get; }
	public bool showMaskGraphic { get; set; }
	public Graphic graphic { get; }

	// Methods

	// RVA: 0x2F2C250 Offset: 0x2F2AC50 VA: 0x182F2C250
	public RectTransform get_rectTransform() { }

	// RVA: 0x493120 Offset: 0x491B20 VA: 0x180493120
	public bool get_showMaskGraphic() { }

	// RVA: 0x2F2C2C0 Offset: 0x2F2ACC0 VA: 0x182F2C2C0
	public void set_showMaskGraphic(bool value) { }

	// RVA: 0x2F2C1E0 Offset: 0x2F2ABE0 VA: 0x182F2C1E0
	public Graphic get_graphic() { }

	// RVA: 0x2F2C1D0 Offset: 0x2F2ABD0 VA: 0x182F2C1D0
	protected void .ctor() { }

	// RVA: 0x2F2BB10 Offset: 0x2F2A510 VA: 0x182F2BB10 Slot: 19
	public virtual bool MaskEnabled() { }

	[Obsolete("Not used anymore.")]
	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 20
	public virtual void OnSiblingGraphicEnabledDisabled() { }

	// RVA: 0x2F2BF40 Offset: 0x2F2A940 VA: 0x182F2BF40 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x2F2BBD0 Offset: 0x2F2A5D0 VA: 0x182F2BBD0 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x2F2BA20 Offset: 0x2F2A420 VA: 0x182F2BA20 Slot: 21
	public virtual bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera) { }

	// RVA: 0x2F2B710 Offset: 0x2F2A110 VA: 0x182F2B710 Slot: 22
	public virtual Material GetModifiedMaterial(Material baseMaterial) { }
}

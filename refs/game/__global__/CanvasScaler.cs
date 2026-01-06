public class CanvasScaler : UIBehaviour // TypeDefIndex: 16428
{
	// Fields
	[Tooltip("Determines how UI elements in the Canvas are scaled.")]
	[SerializeField]
	private CanvasScaler.ScaleMode m_UiScaleMode; // 0x20
	[SerializeField]
	[Tooltip("If a sprite has this 'Pixels Per Unit' setting, then one pixel in the sprite will cover one unit in the UI.")]
	protected float m_ReferencePixelsPerUnit; // 0x24
	[SerializeField]
	[Tooltip("Scales all UI elements in the Canvas by this factor.")]
	protected float m_ScaleFactor; // 0x28
	[SerializeField]
	[Tooltip("The resolution the UI layout is designed for. If the screen resolution is larger, the UI will be scaled up, and if it's smaller, the UI will be scaled down. This is done in accordance with the Screen Match Mode.")]
	protected Vector2 m_ReferenceResolution; // 0x2C
	[Tooltip("A mode used to scale the canvas area if the aspect ratio of the current resolution doesn't fit the reference resolution.")]
	[SerializeField]
	protected CanvasScaler.ScreenMatchMode m_ScreenMatchMode; // 0x34
	[SerializeField]
	[Tooltip("Determines if the scaling is using the width or height as reference, or a mix in between.")]
	[Range(0, 1)]
	protected float m_MatchWidthOrHeight; // 0x38
	private const float kLogBase = 2;
	[SerializeField]
	[Tooltip("The physical unit to specify positions and sizes in.")]
	protected CanvasScaler.Unit m_PhysicalUnit; // 0x3C
	[Tooltip("The DPI to assume if the screen DPI is not known.")]
	[SerializeField]
	protected float m_FallbackScreenDPI; // 0x40
	[SerializeField]
	[Tooltip("The pixels per inch to use for sprites that have a 'Pixels Per Unit' setting that matches the 'Reference Pixels Per Unit' setting.")]
	protected float m_DefaultSpriteDPI; // 0x44
	[SerializeField]
	[Tooltip("The amount of pixels per unit to use for dynamically created bitmaps in the UI, such as Text.")]
	protected float m_DynamicPixelsPerUnit; // 0x48
	private Canvas m_Canvas; // 0x50
	private float m_PrevScaleFactor; // 0x58
	private float m_PrevReferencePixelsPerUnit; // 0x5C
	[SerializeField]
	protected bool m_PresetInfoIsWorld; // 0x60

	// Properties
	public CanvasScaler.ScaleMode uiScaleMode { get; set; }
	public float referencePixelsPerUnit { get; set; }
	public float scaleFactor { get; set; }
	public Vector2 referenceResolution { get; set; }
	public CanvasScaler.ScreenMatchMode screenMatchMode { get; set; }
	public float matchWidthOrHeight { get; set; }
	public CanvasScaler.Unit physicalUnit { get; set; }
	public float fallbackScreenDPI { get; set; }
	public float defaultSpriteDPI { get; set; }
	public float dynamicPixelsPerUnit { get; set; }

	// Methods

	// RVA: 0x494440 Offset: 0x492E40 VA: 0x180494440
	public CanvasScaler.ScaleMode get_uiScaleMode() { }

	// RVA: 0x494490 Offset: 0x492E90 VA: 0x180494490
	public void set_uiScaleMode(CanvasScaler.ScaleMode value) { }

	// RVA: 0x494450 Offset: 0x492E50 VA: 0x180494450
	public float get_referencePixelsPerUnit() { }

	// RVA: 0x4944A0 Offset: 0x492EA0 VA: 0x1804944A0
	public void set_referencePixelsPerUnit(float value) { }

	// RVA: 0x5260F0 Offset: 0x524AF0 VA: 0x1805260F0
	public float get_scaleFactor() { }

	// RVA: 0x2F18B60 Offset: 0x2F17560 VA: 0x182F18B60
	public void set_scaleFactor(float value) { }

	// RVA: 0x494460 Offset: 0x492E60 VA: 0x180494460
	public Vector2 get_referenceResolution() { }

	// RVA: 0x2F18AE0 Offset: 0x2F174E0 VA: 0x182F18AE0
	public void set_referenceResolution(Vector2 value) { }

	// RVA: 0x4CDA00 Offset: 0x4CC400 VA: 0x1804CDA00
	public CanvasScaler.ScreenMatchMode get_screenMatchMode() { }

	// RVA: 0x4E2B40 Offset: 0x4E1540 VA: 0x1804E2B40
	public void set_screenMatchMode(CanvasScaler.ScreenMatchMode value) { }

	// RVA: 0x4CD9F0 Offset: 0x4CC3F0 VA: 0x1804CD9F0
	public float get_matchWidthOrHeight() { }

	// RVA: 0x4E2CD0 Offset: 0x4E16D0 VA: 0x1804E2CD0
	public void set_matchWidthOrHeight(float value) { }

	// RVA: 0xC21BD0 Offset: 0xC205D0 VA: 0x180C21BD0
	public CanvasScaler.Unit get_physicalUnit() { }

	// RVA: 0xC21CD0 Offset: 0xC206D0 VA: 0x180C21CD0
	public void set_physicalUnit(CanvasScaler.Unit value) { }

	// RVA: 0x495F60 Offset: 0x494960 VA: 0x180495F60
	public float get_fallbackScreenDPI() { }

	// RVA: 0x49D330 Offset: 0x49BD30 VA: 0x18049D330
	public void set_fallbackScreenDPI(float value) { }

	// RVA: 0x49D270 Offset: 0x49BC70 VA: 0x18049D270
	public float get_defaultSpriteDPI() { }

	// RVA: 0x2F18AC0 Offset: 0x2F174C0 VA: 0x182F18AC0
	public void set_defaultSpriteDPI(float value) { }

	// RVA: 0x495E80 Offset: 0x494880 VA: 0x180495E80
	public float get_dynamicPixelsPerUnit() { }

	// RVA: 0x810830 Offset: 0x80F230 VA: 0x180810830
	public void set_dynamicPixelsPerUnit(float value) { }

	// RVA: 0x2F18A70 Offset: 0x2F17470 VA: 0x182F18A70
	protected void .ctor() { }

	// RVA: 0x2F18930 Offset: 0x2F17330 VA: 0x182F18930 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0xBF3280 Offset: 0xBF1C80 VA: 0x180BF3280
	private void Canvas_preWillRenderCanvases() { }

	// RVA: 0x2F18860 Offset: 0x2F17260 VA: 0x182F18860 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x2F18740 Offset: 0x2F17140 VA: 0x182F18740 Slot: 17
	protected virtual void Handle() { }

	// RVA: 0x2F186D0 Offset: 0x2F170D0 VA: 0x182F186D0 Slot: 18
	protected virtual void HandleWorldCanvas() { }

	// RVA: 0x2F18410 Offset: 0x2F16E10 VA: 0x182F18410 Slot: 19
	protected virtual void HandleConstantPixelSize() { }

	// RVA: 0x2F18480 Offset: 0x2F16E80 VA: 0x182F18480 Slot: 20
	protected virtual void HandleScaleWithScreenSize() { }

	// RVA: 0x2F18330 Offset: 0x2F16D30 VA: 0x182F18330 Slot: 21
	protected virtual void HandleConstantPhysicalSize() { }

	// RVA: 0x2F18A30 Offset: 0x2F17430 VA: 0x182F18A30
	protected void SetScaleFactor(float scaleFactor) { }

	// RVA: 0x2F189F0 Offset: 0x2F173F0 VA: 0x182F189F0
	protected void SetReferencePixelsPerUnit(float referencePixelsPerUnit) { }
}

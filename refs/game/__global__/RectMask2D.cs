public class RectMask2D : UIBehaviour, IClipper, ICanvasRaycastFilter // TypeDefIndex: 16460
{
	// Fields
	private readonly RectangularVertexClipper m_VertexClipper; // 0x20
	private RectTransform m_RectTransform; // 0x28
	private HashSet<MaskableGraphic> m_MaskableTargets; // 0x30
	private HashSet<IClippable> m_ClipTargets; // 0x38
	private bool m_ShouldRecalculateClipRects; // 0x40
	private List<RectMask2D> m_Clippers; // 0x48
	private Rect m_LastClipRectCanvasSpace; // 0x50
	private bool m_ForceClip; // 0x60
	[SerializeField]
	private Vector4 m_Padding; // 0x64
	[SerializeField]
	private Vector2Int m_Softness; // 0x74
	private Canvas m_Canvas; // 0x80
	private Vector3[] m_Corners; // 0x88

	// Properties
	public Vector4 padding { get; set; }
	public Vector2Int softness { get; set; }
	internal Canvas Canvas { get; }
	public Rect canvasRect { get; }
	public RectTransform rectTransform { get; }
	private Rect rootCanvasRect { get; }

	// Methods

	// RVA: 0x1EF3A40 Offset: 0x1EF2440 VA: 0x181EF3A40
	public Vector4 get_padding() { }

	// RVA: 0x2F31A20 Offset: 0x2F30420 VA: 0x182F31A20
	public void set_padding(Vector4 value) { }

	// RVA: 0xABD6B0 Offset: 0xABC0B0 VA: 0x180ABD6B0
	public Vector2Int get_softness() { }

	// RVA: 0x2F31A30 Offset: 0x2F30430 VA: 0x182F31A30
	public void set_softness(Vector2Int value) { }

	// RVA: 0x2F315A0 Offset: 0x2F2FFA0 VA: 0x182F315A0
	internal Canvas get_Canvas() { }

	// RVA: 0x2F31710 Offset: 0x2F30110 VA: 0x182F31710
	public Rect get_canvasRect() { }

	// RVA: 0x2F317D0 Offset: 0x2F301D0 VA: 0x182F317D0
	public RectTransform get_rectTransform() { }

	// RVA: 0x2F31430 Offset: 0x2F2FE30 VA: 0x182F31430
	protected void .ctor() { }

	// RVA: 0x2F30420 Offset: 0x2F2EE20 VA: 0x182F30420 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x2F30360 Offset: 0x2F2ED60 VA: 0x182F30360 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x2F30340 Offset: 0x2F2ED40 VA: 0x182F30340 Slot: 8
	protected override void OnDestroy() { }

	// RVA: 0x2F301F0 Offset: 0x2F2EBF0 VA: 0x182F301F0 Slot: 19
	public virtual bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera) { }

	// RVA: 0x2F31840 Offset: 0x2F30240 VA: 0x182F31840
	private Rect get_rootCanvasRect() { }

	// RVA: 0x2F30450 Offset: 0x2F2EE50 VA: 0x182F30450 Slot: 20
	public virtual void PerformClipping() { }

	// RVA: 0x2F31110 Offset: 0x2F2FB10 VA: 0x182F31110 Slot: 21
	public virtual void UpdateClipSoftness() { }

	// RVA: 0x2F300E0 Offset: 0x2F2EAE0 VA: 0x182F300E0
	public void AddClippable(IClippable clippable) { }

	// RVA: 0x2F30F60 Offset: 0x2F2F960 VA: 0x182F30F60
	public void RemoveClippable(IClippable clippable) { }

	// RVA: 0x2F30300 Offset: 0x2F2ED00 VA: 0x182F30300 Slot: 12
	protected override void OnTransformParentChanged() { }

	// RVA: 0x2F30300 Offset: 0x2F2ED00 VA: 0x182F30300 Slot: 15
	protected override void OnCanvasHierarchyChanged() { }
}

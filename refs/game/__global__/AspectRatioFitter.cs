public class AspectRatioFitter : UIBehaviour, ILayoutSelfController, ILayoutController // TypeDefIndex: 16424
{
	// Fields
	[SerializeField]
	private AspectRatioFitter.AspectMode m_AspectMode; // 0x20
	[SerializeField]
	private float m_AspectRatio; // 0x24
	private RectTransform m_Rect; // 0x28
	private bool m_DelayedSetDirty; // 0x30
	private bool m_DoesParentExist; // 0x31
	private DrivenRectTransformTracker m_Tracker; // 0x32

	// Properties
	public AspectRatioFitter.AspectMode aspectMode { get; set; }
	public float aspectRatio { get; set; }
	private RectTransform rectTransform { get; }

	// Methods

	// RVA: 0x494440 Offset: 0x492E40 VA: 0x180494440
	public AspectRatioFitter.AspectMode get_aspectMode() { }

	// RVA: 0x2F18270 Offset: 0x2F16C70 VA: 0x182F18270
	public void set_aspectMode(AspectRatioFitter.AspectMode value) { }

	// RVA: 0x494450 Offset: 0x492E50 VA: 0x180494450
	public float get_aspectRatio() { }

	// RVA: 0x2F182D0 Offset: 0x2F16CD0 VA: 0x182F182D0
	public void set_aspectRatio(float value) { }

	// RVA: 0x2F181E0 Offset: 0x2F16BE0 VA: 0x182F181E0
	private RectTransform get_rectTransform() { }

	// RVA: 0x2F181D0 Offset: 0x2F16BD0 VA: 0x182F181D0
	protected void .ctor() { }

	// RVA: 0x2F17C20 Offset: 0x2F16620 VA: 0x182F17C20 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x2F17D70 Offset: 0x2F16770 VA: 0x182F17D70 Slot: 6
	protected override void Start() { }

	// RVA: 0x2F17BA0 Offset: 0x2F165A0 VA: 0x182F17BA0 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x2F17CD0 Offset: 0x2F166D0 VA: 0x182F17CD0 Slot: 12
	protected override void OnTransformParentChanged() { }

	// RVA: 0x2F181B0 Offset: 0x2F16BB0 VA: 0x182F181B0 Slot: 19
	protected virtual void Update() { }

	// RVA: 0x2F17CC0 Offset: 0x2F166C0 VA: 0x182F17CC0 Slot: 10
	protected override void OnRectTransformDimensionsChange() { }

	// RVA: 0x2F17DC0 Offset: 0x2F167C0 VA: 0x182F17DC0
	private void UpdateRect() { }

	// RVA: 0x2F17900 Offset: 0x2F16300 VA: 0x182F17900
	private float GetSizeDeltaToProduceSize(float size, int axis) { }

	// RVA: 0x2F17800 Offset: 0x2F16200 VA: 0x182F17800
	private Vector2 GetParentSize() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 20
	public virtual void SetLayoutHorizontal() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 21
	public virtual void SetLayoutVertical() { }

	// RVA: 0x2F17CC0 Offset: 0x2F166C0 VA: 0x182F17CC0
	protected void SetDirty() { }

	// RVA: 0x2F17AF0 Offset: 0x2F164F0 VA: 0x182F17AF0
	public bool IsComponentValidOnObject() { }

	// RVA: 0x2F17AD0 Offset: 0x2F164D0 VA: 0x182F17AD0
	public bool IsAspectModeValid() { }

	// RVA: 0x4CD9C0 Offset: 0x4CC3C0 VA: 0x1804CD9C0
	private bool DoesParentExists() { }
}

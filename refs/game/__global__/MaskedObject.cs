public class MaskedObject : UIBehaviour // TypeDefIndex: 2711
{
	// Fields
	[SerializeField]
	private CanvasRenderer canvasRendererToClip; // 0x20
	public bool includeChildren; // 0x28
	[SerializeField]
	private Canvas rootCanvas; // 0x30
	[SerializeField]
	private RectTransform maskRectTransform; // 0x38
	private bool initialized; // 0x40
	private List<CanvasRenderer> canvasRenderersToClip; // 0x48

	// Methods

	// RVA: 0x910130 Offset: 0x90EB30 VA: 0x180910130 Slot: 10
	protected override void OnRectTransformDimensionsChange() { }

	// RVA: 0x910090 Offset: 0x90EA90 VA: 0x180910090 Slot: 4
	protected override void Awake() { }

	// RVA: 0x9103B0 Offset: 0x90EDB0 VA: 0x1809103B0 Slot: 6
	protected override void Start() { }

	// RVA: 0x9100E0 Offset: 0x90EAE0 VA: 0x1809100E0
	public void Initialize(Canvas rootCanvas, RectTransform maskRectTransform) { }

	// RVA: 0x910160 Offset: 0x90EB60 VA: 0x180910160
	private void SetTargetClippingRect() { }

	// RVA: 0x910540 Offset: 0x90EF40 VA: 0x180910540
	public void .ctor() { }
}

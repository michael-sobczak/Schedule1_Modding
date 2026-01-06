public class CompassManager : Singleton<CompassManager> // TypeDefIndex: 2965
{
	// Fields
	public const int NOTCH_COUNT = 24;
	public const float DISTANCE_LABEL_THRESHOLD = 50;
	[Header("References")]
	public RectTransform Container; // 0x28
	public RectTransform NotchUIContainer; // 0x30
	public RectTransform ElementUIContainer; // 0x38
	public Canvas Canvas; // 0x40
	[Header("Prefabs")]
	public GameObject DirectionIndicatorPrefab; // 0x48
	public GameObject NotchPrefab; // 0x50
	public GameObject ElementPrefab; // 0x58
	[Header("Settings")]
	public bool CompassEnabled; // 0x60
	public Vector2 ElementContentSize; // 0x64
	public float CompassUIRange; // 0x6C
	public float FullAlphaRange; // 0x70
	public float AngleDivisor; // 0x74
	public float ClosedYPos; // 0x78
	public float OpenYPos; // 0x7C
	private List<Vector3> notchPositions; // 0x80
	private List<CompassManager.Notch> notches; // 0x88
	private List<CompassManager.Element> elements; // 0x90
	private Coroutine lerpContainerPositionCoroutine; // 0x98

	// Properties
	private Transform cam { get; }

	// Methods

	// RVA: 0x97D4C0 Offset: 0x97BEC0 VA: 0x18097D4C0
	private Transform get_cam() { }

	// RVA: 0x97BCB0 Offset: 0x97A6B0 VA: 0x18097BCB0 Slot: 5
	protected override void Awake() { }

	// RVA: 0x97C520 Offset: 0x97AF20 VA: 0x18097C520
	private void LateUpdate() { }

	// RVA: 0x97D160 Offset: 0x97BB60 VA: 0x18097D160
	private void Update() { }

	// RVA: 0x68C180 Offset: 0x68AB80 VA: 0x18068C180
	public void SetCompassEnabled(bool enabled) { }

	// RVA: 0x97C7D0 Offset: 0x97B1D0 VA: 0x18097C7D0
	public void SetVisible(bool visible) { }

	// RVA: 0x97D010 Offset: 0x97BA10 VA: 0x18097D010
	private void UpdateNotches() { }

	// RVA: 0x97CC30 Offset: 0x97B630 VA: 0x18097CC30
	private void UpdateElements() { }

	// RVA: 0x97C930 Offset: 0x97B330 VA: 0x18097C930
	private void UpdateElement(CompassManager.Element element) { }

	// RVA: 0x97C1D0 Offset: 0x97ABD0 VA: 0x18097C1D0
	public void GetCompassData(Vector3 worldPosition, out float xPos, out float alpha) { }

	// RVA: 0x97B9C0 Offset: 0x97A3C0 VA: 0x18097B9C0
	public CompassManager.Element AddElement(Transform transform, RectTransform contentPrefab, bool visible = True) { }

	// RVA: 0x97C6B0 Offset: 0x97B0B0 VA: 0x18097C6B0
	public void RemoveElement(Transform transform, bool alsoDestroyRect = True) { }

	// RVA: 0x97C600 Offset: 0x97B000 VA: 0x18097C600
	public void RemoveElement(CompassManager.Element el, bool alsoDestroyRect = True) { }

	// RVA: 0x97D360 Offset: 0x97BD60 VA: 0x18097D360
	public void .ctor() { }

	[IteratorStateMachine(typeof(CompassManager.<<SetVisible>g__LerpContainerPosition|28_0>d))]
	[CompilerGenerated]
	// RVA: 0x97C8A0 Offset: 0x97B2A0 VA: 0x18097C8A0
	private IEnumerator <SetVisible>g__LerpContainerPosition|28_0(float yPos, bool visible) { }
}

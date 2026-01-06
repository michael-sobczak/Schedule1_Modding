public class MapApp : App<MapApp> // TypeDefIndex: 2818
{
	// Fields
	public const float KeyMoveSpeed = 1.25;
	public RectTransform ContentRect; // 0x68
	public RectTransform PoIContainer; // 0x70
	public Scrollbar HorizontalScrollbar; // 0x78
	public Scrollbar VerticalScrollbar; // 0x80
	public Image BackgroundImage; // 0x88
	public CanvasGroup LabelGroup; // 0x90
	[Header("Settings")]
	public Sprite DemoMapSprite; // 0x98
	public Sprite MainMapSprite; // 0xA0
	public Sprite TutorialMapSprite; // 0xA8
	public float LabelScrollMin; // 0xB0
	public float LabelScrollMax; // 0xB4
	[HideInInspector]
	public bool SkipFocusPlayer; // 0xB8
	private Coroutine contentMoveRoutine; // 0xC0
	private bool opened; // 0xC8

	// Methods

	// RVA: 0x92F1E0 Offset: 0x92DBE0 VA: 0x18092F1E0 Slot: 5
	protected override void Start() { }

	// RVA: 0x92ED90 Offset: 0x92D790 VA: 0x18092ED90 Slot: 11
	public override void SetOpen(bool open) { }

	// RVA: 0x92F2B0 Offset: 0x92DCB0 VA: 0x18092F2B0 Slot: 8
	protected override void Update() { }

	// RVA: 0x92EC60 Offset: 0x92D660 VA: 0x18092EC60
	public void FocusPosition(Vector2 anchoredPosition) { }

	// RVA: 0x92F3F0 Offset: 0x92DDF0 VA: 0x18092F3F0
	public void .ctor() { }
}

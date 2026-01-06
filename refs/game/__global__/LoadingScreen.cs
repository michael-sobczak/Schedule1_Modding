public class LoadingScreen : PersistentSingleton<LoadingScreen> // TypeDefIndex: 2638
{
	// Fields
	public const float FADE_TIME = 0.25;
	public const float BACKGROUND_IMAGE_TIME = 8;
	public const float BACKGROUND_IMAGE_FADE_TIME = 1;
	[CompilerGenerated]
	private bool <IsOpen>k__BackingField; // 0x28
	public StringDatabase LoadingMessagesDatabase; // 0x30
	public Sprite[] BackgroundImages; // 0x38
	public Sprite[] TutorialBackgroundImages; // 0x40
	[Header("References")]
	public Canvas Canvas; // 0x48
	public CanvasGroup Group; // 0x50
	public TextMeshProUGUI LoadStatusLabel; // 0x58
	public TextMeshProUGUI LoadingMessageLabel; // 0x60
	public Image BackgroundImage1; // 0x68
	public Image BackgroundImage2; // 0x70
	public RectTransform TutorialContainer; // 0x78
	public RectTransform CoopTutorialHint; // 0x80
	private string[] loadingMessages; // 0x88
	private int currentBackgroundImageIndex; // 0x90
	private Coroutine fadeRoutine; // 0x98
	private Coroutine animateBackgroundRoutine; // 0xA0
	private Coroutine scaleBackgroundRoutine; // 0xA8
	private bool isLoadingTutorial; // 0xB0

	// Properties
	public bool IsOpen { get; set; }
	public Sprite[] ContextualBackgroundImages { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x493120 Offset: 0x491B20 VA: 0x180493120
	public bool get_IsOpen() { }

	[CompilerGenerated]
	// RVA: 0x493130 Offset: 0x491B30 VA: 0x180493130
	protected void set_IsOpen(bool value) { }

	// RVA: 0x8F6EC0 Offset: 0x8F58C0 VA: 0x1808F6EC0
	public Sprite[] get_ContextualBackgroundImages() { }

	// RVA: 0x8F6580 Offset: 0x8F4F80 VA: 0x1808F6580 Slot: 5
	protected override void Awake() { }

	// RVA: 0x8F6DD0 Offset: 0x8F57D0 VA: 0x1808F6DD0
	protected void Update() { }

	// RVA: 0x8F6AB0 Offset: 0x8F54B0 VA: 0x1808F6AB0
	public void Open(bool loadingTutorial = False) { }

	// RVA: 0x8F6870 Offset: 0x8F5270 VA: 0x1808F6870
	public void Close() { }

	// RVA: 0x8F64C0 Offset: 0x8F4EC0 VA: 0x1808F64C0
	private void AnimateBackground() { }

	// RVA: 0x8F6990 Offset: 0x8F5390 VA: 0x1808F6990
	private void Fade(float endAlpha) { }

	// RVA: 0x8F6E80 Offset: 0x8F5880 VA: 0x1808F6E80
	public void .ctor() { }

	[IteratorStateMachine(typeof(LoadingScreen.<<AnimateBackground>g__Routine|30_0>d))]
	[CompilerGenerated]
	// RVA: 0x8F6D60 Offset: 0x8F5760 VA: 0x1808F6D60
	private IEnumerator <AnimateBackground>g__Routine|30_0() { }
}

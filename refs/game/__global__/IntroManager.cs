public class IntroManager : Singleton<IntroManager> // TypeDefIndex: 1365
{
	// Fields
	public const float SKIP_TIME = 0.5;
	[CompilerGenerated]
	private bool <IsPlaying>k__BackingField; // 0x28
	public int CurrentStep; // 0x2C
	[Header("Settings")]
	public int TimeOfDayOverride; // 0x30
	[Header("References")]
	public GameObject Container; // 0x38
	public Transform PlayerInitialPosition; // 0x40
	public Transform PlayerInitialPosition_AfterRVExplosion; // 0x48
	public Transform CameraContainer; // 0x50
	public Animation Anim; // 0x58
	public GameObject SkipContainer; // 0x60
	public Image SkipDial; // 0x68
	public GameObject[] DisableDuringIntro; // 0x70
	public RV rv; // 0x78
	public UnityEvent onIntroDone; // 0x80
	public UnityEvent onIntroDoneAsServer; // 0x88
	public string MusicName; // 0x90
	private float currentSkipTime; // 0x98
	private bool depressed; // 0x9C

	// Properties
	public bool IsPlaying { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x493120 Offset: 0x491B20 VA: 0x180493120
	public bool get_IsPlaying() { }

	[CompilerGenerated]
	// RVA: 0x493130 Offset: 0x491B30 VA: 0x180493130
	protected void set_IsPlaying(bool value) { }

	// RVA: 0x660950 Offset: 0x65F350 VA: 0x180660950 Slot: 5
	protected override void Awake() { }

	// RVA: 0x661220 Offset: 0x65FC20 VA: 0x180661220
	private void Update() { }

	[Button]
	// RVA: 0x660BD0 Offset: 0x65F5D0 VA: 0x180660BD0
	public void Play() { }

	// RVA: 0x660AB0 Offset: 0x65F4B0 VA: 0x180660AB0
	private void PlayMusic() { }

	// RVA: 0x6609C0 Offset: 0x65F3C0 VA: 0x1806609C0
	public void CharacterCreationDone(BasicAvatarSettings avatar, List<ClothingInstance> clothes) { }

	// RVA: 0x65E020 Offset: 0x65CA20 VA: 0x18065E020
	public void PassedStep(int stepIndex) { }

	// RVA: 0x661500 Offset: 0x65FF00 VA: 0x180661500
	public void .ctor() { }

	[CompilerGenerated]
	[IteratorStateMachine(typeof(IntroManager.<<Play>g__Wait|23_0>d))]
	// RVA: 0x6611B0 Offset: 0x65FBB0 VA: 0x1806611B0
	private IEnumerator <Play>g__Wait|23_0() { }

	[CompilerGenerated]
	// RVA: 0x661180 Offset: 0x65FB80 VA: 0x180661180
	private bool <Play>b__23_2() { }

	[CompilerGenerated]
	// RVA: 0x661150 Offset: 0x65FB50 VA: 0x180661150
	private bool <PlayMusic>b__24_0(MusicTrack t) { }
}

public class DemoIntro : Singleton<DemoIntro> // TypeDefIndex: 2590
{
	// Fields
	public const float SKIP_TIME = 0.5;
	[CompilerGenerated]
	private bool <IsPlaying>k__BackingField; // 0x28
	public Animation Anim; // 0x30
	public Transform PlayerInitialPosition; // 0x38
	public GameObject SkipContainer; // 0x40
	public Image SkipDial; // 0x48
	public int SkipEvents; // 0x50
	public UnityEvent onStart; // 0x58
	public UnityEvent onStartAsServer; // 0x60
	public UnityEvent onCutsceneDone; // 0x68
	public UnityEvent onIntroDone; // 0x70
	public UnityEvent onIntroDoneAsServer; // 0x78
	private int CurrentStep; // 0x80
	public string MusicName; // 0x88
	private float currentSkipTime; // 0x90
	private bool depressed; // 0x94
	private bool waitingForCutsceneEnd; // 0x95

	// Properties
	public bool IsPlaying { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x493120 Offset: 0x491B20 VA: 0x180493120
	public bool get_IsPlaying() { }

	[CompilerGenerated]
	// RVA: 0x493130 Offset: 0x491B30 VA: 0x180493130
	protected void set_IsPlaying(bool value) { }

	// RVA: 0x8E0F00 Offset: 0x8DF900 VA: 0x1808E0F00
	private void Update() { }

	[Button]
	// RVA: 0x8E0B00 Offset: 0x8DF500 VA: 0x1808E0B00
	public void Play() { }

	// RVA: 0x8E09E0 Offset: 0x8DF3E0 VA: 0x1808E09E0
	private void PlayMusic() { }

	// RVA: 0x8E0D90 Offset: 0x8DF790 VA: 0x1808E0D90
	public void ShowAvatar() { }

	// RVA: 0x8E0870 Offset: 0x8DF270 VA: 0x1808E0870
	public void CutsceneDone() { }

	// RVA: 0x4D6540 Offset: 0x4D4F40 VA: 0x1804D6540
	public void PassedStep(int stepIndex) { }

	// RVA: 0x8E07F0 Offset: 0x8DF1F0 VA: 0x1808E07F0
	public void CharacterCreationDone(BasicAvatarSettings avatar) { }

	// RVA: 0x8E1370 Offset: 0x8DFD70 VA: 0x1808E1370
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x8E0ED0 Offset: 0x8DF8D0 VA: 0x1808E0ED0
	private bool <PlayMusic>b__22_0(MusicTrack t) { }

	[IteratorStateMachine(typeof(DemoIntro.<<CharacterCreationDone>g__Wait|26_0>d))]
	[CompilerGenerated]
	// RVA: 0x8E0E60 Offset: 0x8DF860 VA: 0x1808E0E60
	private IEnumerator <CharacterCreationDone>g__Wait|26_0() { }
}

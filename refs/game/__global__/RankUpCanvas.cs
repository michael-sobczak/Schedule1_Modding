public class RankUpCanvas : MonoBehaviour, IPostSleepEvent // TypeDefIndex: 2700
{
	// Fields
	[CompilerGenerated]
	private bool <IsRunning>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <Order>k__BackingField; // 0x24
	public Animation OpenCloseAnim; // 0x28
	public Animation RankUpAnim; // 0x30
	public TextMeshProUGUI OldRankLabel; // 0x38
	public TextMeshProUGUI NewRankLabel; // 0x40
	public Canvas Canvas; // 0x48
	public GameObject UnlockedItemsContainer; // 0x50
	public CanvasGroup UnlockedItemsCanvasGroup; // 0x58
	public RectTransform[] UnlockedItems; // 0x60
	public TextMeshProUGUI ExtraUnlocksLabel; // 0x68
	public AudioSourceController SoundEffect; // 0x70
	public Slider ProgressSlider; // 0x78
	public TextMeshProUGUI ProgressLabel; // 0x80
	public AudioSourceController BlipSound; // 0x88
	public AudioSourceController ClickSound; // 0x90
	private Coroutine coroutine; // 0x98
	private List<Tuple<FullRank, FullRank>> queuedRankUps; // 0xA0

	// Properties
	public bool IsRunning { get; set; }
	public int Order { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4945E0 Offset: 0x492FE0 VA: 0x1804945E0 Slot: 4
	public bool get_IsRunning() { }

	[CompilerGenerated]
	// RVA: 0x494600 Offset: 0x493000 VA: 0x180494600
	private void set_IsRunning(bool value) { }

	[CompilerGenerated]
	// RVA: 0x49CD40 Offset: 0x49B740 VA: 0x18049CD40 Slot: 5
	public int get_Order() { }

	[CompilerGenerated]
	// RVA: 0x49CD60 Offset: 0x49B760 VA: 0x18049CD60
	private void set_Order(int value) { }

	// RVA: 0x916CF0 Offset: 0x9156F0 VA: 0x180916CF0
	public void Start() { }

	// RVA: 0x916460 Offset: 0x914E60 VA: 0x180916460
	private void QueuePostSleepEvent() { }

	// RVA: 0x916600 Offset: 0x915000 VA: 0x180916600 Slot: 6
	public void StartEvent() { }

	// RVA: 0x915EA0 Offset: 0x9148A0 VA: 0x180915EA0
	public void EndEvent() { }

	// RVA: 0x916500 Offset: 0x914F00 VA: 0x180916500
	public void RankUp(FullRank oldRank, FullRank newRank) { }

	// RVA: 0x915F60 Offset: 0x914960 VA: 0x180915F60
	private void PlayRankupAnimation(FullRank oldRank, FullRank newRank, bool playSound) { }

	// RVA: 0x916F80 Offset: 0x915980 VA: 0x180916F80
	public void .ctor() { }
}

public class MessagesApp : App<MessagesApp> // TypeDefIndex: 2842
{
	// Fields
	public static List<MSGConversation> Conversations; // 0x0
	public static List<MSGConversation> ActiveConversations; // 0x8
	public List<MessagesApp.CategoryInfo> categoryInfos; // 0x68
	[SerializeField]
	[Header("References")]
	protected RectTransform conversationEntryContainer; // 0x70
	[SerializeField]
	protected RectTransform conversationContainer; // 0x78
	public GameObject homePage; // 0x80
	public GameObject dialoguePage; // 0x88
	public Text dialoguePageNameText; // 0x90
	public RectTransform relationshipContainer; // 0x98
	public Scrollbar relationshipScrollbar; // 0xA0
	public Tooltip relationshipTooltip; // 0xA8
	public RectTransform standardsContainer; // 0xB0
	public Image standardsStar; // 0xB8
	public Tooltip standardsTooltip; // 0xC0
	public RectTransform iconContainerRect; // 0xC8
	public Image iconImage; // 0xD0
	public Sprite BlankAvatarSprite; // 0xD8
	public DealWindowSelector DealWindowSelector; // 0xE0
	public PhoneShopInterface PhoneShopInterface; // 0xE8
	public CounterofferInterface CounterofferInterface; // 0xF0
	public RectTransform ClearFilterButton; // 0xF8
	public Button[] CategoryButtons; // 0x100
	public AudioSourceController MessageReceivedSound; // 0x108
	public AudioSourceController MessageSentSound; // 0x110
	public ConfirmationPopup ConfirmationPopup; // 0x118
	[SerializeField]
	[Header("Prefabs")]
	protected GameObject conversationEntryPrefab; // 0x120
	[SerializeField]
	protected GameObject conversationContainerPrefab; // 0x128
	public GameObject messageBubblePrefab; // 0x130
	public List<MSGConversation> unreadConversations; // 0x138
	[CompilerGenerated]
	private MSGConversation <currentConversation>k__BackingField; // 0x140

	// Properties
	public MSGConversation currentConversation { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x67E910 Offset: 0x67D310 VA: 0x18067E910
	public MSGConversation get_currentConversation() { }

	[CompilerGenerated]
	// RVA: 0x6FB0A0 Offset: 0x6F9AA0 VA: 0x1806FB0A0
	private void set_currentConversation(MSGConversation value) { }

	// RVA: 0x94E8F0 Offset: 0x94D2F0 VA: 0x18094E8F0 Slot: 5
	protected override void Start() { }

	// RVA: 0x94EBC0 Offset: 0x94D5C0 VA: 0x18094EBC0 Slot: 8
	protected override void Update() { }

	// RVA: 0x94E450 Offset: 0x94CE50 VA: 0x18094E450
	private void Loaded() { }

	// RVA: 0x94D8A0 Offset: 0x94C2A0 VA: 0x18094D8A0
	private void Clean() { }

	// RVA: 0x94DB00 Offset: 0x94C500 VA: 0x18094DB00
	public void CreateConversationUI(MSGConversation c, out RectTransform entry, out RectTransform container) { }

	// RVA: 0x94E700 Offset: 0x94D100 VA: 0x18094E700
	public void RepositionEntries() { }

	// RVA: 0x94E870 Offset: 0x94D270 VA: 0x18094E870
	public void ReturnButtonClicked() { }

	// RVA: 0x94E610 Offset: 0x94D010 VA: 0x18094E610
	public void RefreshNotifications() { }

	// RVA: 0x94E0C0 Offset: 0x94CAC0 VA: 0x18094E0C0 Slot: 10
	public override void Exit(ExitAction exit) { }

	// RVA: 0x94E890 Offset: 0x94D290 VA: 0x18094E890
	public void SetCurrentConversation(MSGConversation conversation) { }

	// RVA: 0x94E380 Offset: 0x94CD80 VA: 0x18094E380
	public MessagesApp.CategoryInfo GetCategoryInfo(EConversationCategory category) { }

	// RVA: 0x94E160 Offset: 0x94CB60 VA: 0x18094E160
	public void FilterByCategory(int category) { }

	// RVA: 0x94D970 Offset: 0x94C370 VA: 0x18094D970
	public void ClearFilter() { }

	// RVA: 0x94ECD0 Offset: 0x94D6D0 VA: 0x18094ECD0
	public void .ctor() { }

	// RVA: 0x94EC00 Offset: 0x94D600 VA: 0x18094EC00
	private static void .cctor() { }
}

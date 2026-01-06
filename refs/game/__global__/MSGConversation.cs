public class MSGConversation : ISaveable // TypeDefIndex: 1173
{
	// Fields
	public const int MAX_MESSAGE_HISTORY = 10;
	public string contactName; // 0x10
	public NPC sender; // 0x18
	[CompilerGenerated]
	private bool <IsSenderKnown>k__BackingField; // 0x20
	public List<Message> messageHistory; // 0x28
	public List<MessageChain> messageChainHistory; // 0x30
	public List<MessageBubble> bubbles; // 0x38
	public List<SendableMessage> Sendables; // 0x40
	[CompilerGenerated]
	private bool <Read>k__BackingField; // 0x48
	[CompilerGenerated]
	private int <index>k__BackingField; // 0x4C
	[CompilerGenerated]
	private bool <isOpen>k__BackingField; // 0x50
	[CompilerGenerated]
	private bool <rollingOut>k__BackingField; // 0x51
	[CompilerGenerated]
	private bool <EntryVisible>k__BackingField; // 0x52
	public List<EConversationCategory> Categories; // 0x58
	public RectTransform entry; // 0x60
	protected RectTransform container; // 0x68
	protected RectTransform bubbleContainer; // 0x70
	protected RectTransform scrollRectContainer; // 0x78
	protected ScrollRect scrollRect; // 0x80
	protected Text entryPreviewText; // 0x88
	protected RectTransform unreadDot; // 0x90
	protected Slider slider; // 0x98
	protected Image sliderFill; // 0xA0
	protected RectTransform responseContainer; // 0xA8
	protected MessageSenderInterface senderInterface; // 0xB0
	private bool uiCreated; // 0xB8
	public Action onMessageRendered; // 0xC0
	public Action onLoaded; // 0xC8
	public Action onResponsesShown; // 0xD0
	public Action onConversationOpened; // 0xD8
	public List<Response> currentResponses; // 0xE0
	private List<RectTransform> responseRects; // 0xE8
	[CompilerGenerated]
	private List<string> <LocalExtraFiles>k__BackingField; // 0xF0
	[CompilerGenerated]
	private List<string> <LocalExtraFolders>k__BackingField; // 0xF8
	[CompilerGenerated]
	private bool <HasChanged>k__BackingField; // 0x100

	// Properties
	public bool IsSenderKnown { get; set; }
	public bool Read { get; set; }
	public int index { get; set; }
	public bool isOpen { get; set; }
	public bool rollingOut { get; set; }
	public bool EntryVisible { get; set; }
	public bool AreResponsesActive { get; }
	public string SaveFolderName { get; }
	public string SaveFileName { get; }
	public Loader Loader { get; }
	public bool ShouldSaveUnderFolder { get; }
	public List<string> LocalExtraFiles { get; set; }
	public List<string> LocalExtraFolders { get; set; }
	public bool HasChanged { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4945E0 Offset: 0x492FE0 VA: 0x1804945E0
	public bool get_IsSenderKnown() { }

	[CompilerGenerated]
	// RVA: 0x494600 Offset: 0x493000 VA: 0x180494600
	protected void set_IsSenderKnown(bool value) { }

	[CompilerGenerated]
	// RVA: 0x4D60D0 Offset: 0x4D4AD0 VA: 0x1804D60D0
	public bool get_Read() { }

	[CompilerGenerated]
	// RVA: 0x4D6480 Offset: 0x4D4E80 VA: 0x1804D6480
	private void set_Read(bool value) { }

	[CompilerGenerated]
	// RVA: 0x4D60C0 Offset: 0x4D4AC0 VA: 0x1804D60C0
	public int get_index() { }

	[CompilerGenerated]
	// RVA: 0x4E27E0 Offset: 0x4E11E0 VA: 0x1804E27E0
	protected void set_index(int value) { }

	[CompilerGenerated]
	// RVA: 0x49CAE0 Offset: 0x49B4E0 VA: 0x18049CAE0
	public bool get_isOpen() { }

	[CompilerGenerated]
	// RVA: 0x49CCF0 Offset: 0x49B6F0 VA: 0x18049CCF0
	protected void set_isOpen(bool value) { }

	[CompilerGenerated]
	// RVA: 0x50A750 Offset: 0x509150 VA: 0x18050A750
	public bool get_rollingOut() { }

	[CompilerGenerated]
	// RVA: 0x605240 Offset: 0x603C40 VA: 0x180605240
	protected void set_rollingOut(bool value) { }

	[CompilerGenerated]
	// RVA: 0x605160 Offset: 0x603B60 VA: 0x180605160
	public bool get_EntryVisible() { }

	[CompilerGenerated]
	// RVA: 0x6051E0 Offset: 0x603BE0 VA: 0x1806051E0
	protected void set_EntryVisible(bool value) { }

	// RVA: 0x605110 Offset: 0x603B10 VA: 0x180605110
	public bool get_AreResponsesActive() { }

	// RVA: 0x6051B0 Offset: 0x603BB0 VA: 0x1806051B0 Slot: 4
	public string get_SaveFolderName() { }

	// RVA: 0x605180 Offset: 0x603B80 VA: 0x180605180 Slot: 5
	public string get_SaveFileName() { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 6
	public Loader get_Loader() { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 7
	public bool get_ShouldSaveUnderFolder() { }

	[CompilerGenerated]
	// RVA: 0x5162A0 Offset: 0x514CA0 VA: 0x1805162A0 Slot: 8
	public List<string> get_LocalExtraFiles() { }

	[CompilerGenerated]
	// RVA: 0x605200 Offset: 0x603C00 VA: 0x180605200 Slot: 9
	public void set_LocalExtraFiles(List<string> value) { }

	[CompilerGenerated]
	// RVA: 0x605170 Offset: 0x603B70 VA: 0x180605170 Slot: 10
	public List<string> get_LocalExtraFolders() { }

	[CompilerGenerated]
	// RVA: 0x605220 Offset: 0x603C20 VA: 0x180605220 Slot: 11
	public void set_LocalExtraFolders(List<string> value) { }

	[CompilerGenerated]
	// RVA: 0x523400 Offset: 0x521E00 VA: 0x180523400 Slot: 12
	public bool get_HasChanged() { }

	[CompilerGenerated]
	// RVA: 0x6051F0 Offset: 0x603BF0 VA: 0x1806051F0 Slot: 13
	public void set_HasChanged(bool value) { }

	// RVA: 0x604D10 Offset: 0x603710 VA: 0x180604D10
	public void .ctor(NPC _npc, string _contactName) { }

	// RVA: 0x601800 Offset: 0x600200 VA: 0x180601800 Slot: 27
	public virtual void InitializeSaveable() { }

	// RVA: 0x4993E0 Offset: 0x497DE0 VA: 0x1804993E0
	public void SetCategories(List<EConversationCategory> cat) { }

	// RVA: 0x601D30 Offset: 0x600730 VA: 0x180601D30
	public void MoveToTop() { }

	// RVA: 0x604920 Offset: 0x603320 VA: 0x180604920
	public bool ShouldReplicate() { }

	// RVA: 0x601280 Offset: 0x5FFC80 VA: 0x180601280
	public int GetReplicationByteSize() { }

	// RVA: 0x600A70 Offset: 0x5FF470 VA: 0x180600A70
	protected void CreateUI() { }

	// RVA: 0x601250 Offset: 0x5FFC50 VA: 0x180601250
	public void EnsureUIExists() { }

	// RVA: 0x601E50 Offset: 0x600850 VA: 0x180601E50
	protected void RefreshPreviewText() { }

	// RVA: 0x6029D0 Offset: 0x6013D0 VA: 0x1806029D0
	public void RepositionEntry() { }

	// RVA: 0x6036A0 Offset: 0x6020A0 VA: 0x1806036A0
	public void SetIsKnown(bool known) { }

	// RVA: 0x601270 Offset: 0x5FFC70 VA: 0x180601270
	public void EntryClicked() { }

	// RVA: 0x603840 Offset: 0x602240 VA: 0x180603840
	public void SetOpen(bool open) { }

	// RVA: 0x602160 Offset: 0x600B60 VA: 0x180602160 Slot: 28
	protected virtual void RenderMessage(Message m) { }

	// RVA: 0x603620 Offset: 0x602020 VA: 0x180603620
	public void SetEntryVisibility(bool v) { }

	// RVA: 0x6044D0 Offset: 0x602ED0 VA: 0x1806044D0
	public void SetRead(bool r) { }

	// RVA: 0x603170 Offset: 0x601B70 VA: 0x180603170
	public void SendMessage(Message message, bool notify = True, bool network = True) { }

	// RVA: 0x602EA0 Offset: 0x6018A0 VA: 0x180602EA0
	public void SendMessageChain(MessageChain messages, float initialDelay = 0, bool notify = True, bool network = True) { }

	// RVA: 0x6013C0 Offset: 0x5FFDC0 VA: 0x1806013C0
	public MSGConversationData GetSaveData() { }

	// RVA: 0x6017C0 Offset: 0x6001C0 VA: 0x1806017C0 Slot: 29
	public virtual string GetSaveString() { }

	// RVA: 0x601890 Offset: 0x600290 VA: 0x180601890 Slot: 30
	public virtual void Load(MSGConversationData data) { }

	// RVA: 0x602AA0 Offset: 0x6014A0 VA: 0x180602AA0
	public void ResetConversation() { }

	// RVA: 0x604820 Offset: 0x603220 VA: 0x180604820
	public void SetSliderValue(float value, Color color) { }

	// RVA: 0x6012E0 Offset: 0x5FFCE0 VA: 0x1806012E0
	public Response GetResponse(string label) { }

	// RVA: 0x604990 Offset: 0x603390 VA: 0x180604990
	public void ShowResponses(List<Response> _responses, float showResponseDelay = 0, bool network = True) { }

	// RVA: 0x600440 Offset: 0x5FEE40 VA: 0x180600440
	protected void CreateResponseUI(Response r) { }

	// RVA: 0x601F30 Offset: 0x600930 VA: 0x180601F30
	private void RefreshResponseContainer() { }

	// RVA: 0x600220 Offset: 0x5FEC20 VA: 0x180600220
	protected void ClearResponseUI() { }

	// RVA: 0x604710 Offset: 0x603110 VA: 0x180604710
	public void SetResponseContainerVisible(bool v) { }

	// RVA: 0x602C90 Offset: 0x601690 VA: 0x180602C90
	public void ResponseChosen(Response r, bool network) { }

	// RVA: 0x600340 Offset: 0x5FED40 VA: 0x180600340
	public void ClearResponses(bool network = False) { }

	// RVA: 0x6008F0 Offset: 0x5FF2F0 VA: 0x1806008F0
	public SendableMessage CreateSendableMessage(string text) { }

	// RVA: 0x603500 Offset: 0x601F00 VA: 0x180603500
	public void SendPlayerMessage(int sendableIndex, int sentIndex, bool network) { }

	// RVA: 0x602930 Offset: 0x601330 VA: 0x180602930
	public void RenderPlayerMessage(SendableMessage sendable) { }

	// RVA: 0x600130 Offset: 0x5FEB30 VA: 0x180600130
	private void CheckSendLoop() { }

	// RVA: 0x5FFFC0 Offset: 0x5FE9C0 VA: 0x1805FFFC0
	private bool CanSendNewMessage() { }

	[CompilerGenerated]
	// RVA: 0x604CA0 Offset: 0x6036A0 VA: 0x180604CA0
	private void <CreateUI>b__78_0() { }

	[CompilerGenerated]
	[IteratorStateMachine(typeof(MSGConversation.<<CheckSendLoop>g__Loop|106_0>d))]
	// RVA: 0x604C30 Offset: 0x603630 VA: 0x180604C30
	private IEnumerator <CheckSendLoop>g__Loop|106_0() { }
}

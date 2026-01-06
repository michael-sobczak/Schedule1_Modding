public class Trello // TypeDefIndex: 18047
{
	// Fields
	public const int MaxCharLength = 16384;
	public const string CategoryTag = "(EF)";
	public const string TemplateBoardID = "589d1b02a4856195b7cc31c9";
	public const string AppKey = "9babe077311b8a24fddaebb73de1df6a";
	public const string ApiUri = "https://trello.com/1";
	public bool IsDoneUploading; // 0x10
	public bool UploadError; // 0x11
	public string ErrorMessage; // 0x18
	public Exception UploadException; // 0x20
	public AddCardResponse LastAddCardResponse; // 0x28
	public UnityWebRequest LastRequest; // 0x30
	private readonly string token; // 0x38

	// Properties
	public static string AuthURL { get; }

	// Methods

	// RVA: 0x445C60 Offset: 0x444660 VA: 0x180445C60
	public static string get_AuthURL() { }

	// RVA: 0x445C20 Offset: 0x444620 VA: 0x180445C20
	public void .ctor(string token) { }

	// RVA: 0x445780 Offset: 0x444180 VA: 0x180445780
	public string GetURI(string apiPath) { }

	// RVA: 0x4458D0 Offset: 0x4442D0 VA: 0x1804458D0
	public static bool IsValidToken(string token, bool silent = False) { }

	[IteratorStateMachine(typeof(Trello.<AddCard>d__17))]
	// RVA: 0x445190 Offset: 0x443B90 VA: 0x180445190
	public IEnumerator AddCard(string name, string description, IEnumerable<Label> labels, string list, byte[] fileSource) { }

	[IteratorStateMachine(typeof(Trello.<AddAttachmentAsync>d__18))]
	// RVA: 0x4448C0 Offset: 0x4432C0 VA: 0x1804448C0
	public IEnumerator AddAttachmentAsync(string cardID, byte[] file, string url, string name, string mimeType) { }

	[IteratorStateMachine(typeof(Trello.<GetLabelsAsync>d__19))]
	// RVA: 0x4453C0 Offset: 0x443DC0 VA: 0x1804453C0
	public IEnumerator GetLabelsAsync(string boardID, Action<Label[]> onFinished) { }

	[IteratorStateMachine(typeof(Trello.<GetListsAsync>d__20))]
	// RVA: 0x445540 Offset: 0x443F40 VA: 0x180445540
	public IEnumerator GetListsAsync(string boardID, Action<List[]> onFinished) { }

	// RVA: 0x4455F0 Offset: 0x443FF0 VA: 0x1804455F0
	public List[] GetLists(string boardID) { }

	// RVA: 0x4449B0 Offset: 0x4433B0 VA: 0x1804449B0
	public Board AddBoard(string name, bool defaultLabels = True, bool defaultLists = True, string desc, string idOrganization, string idBoardSource, string keepFromSource = "all", string powerUps = "all", Nullable<Prefs> prefs) { }

	[IteratorStateMachine(typeof(Trello.<GetBoardsAsync>d__23))]
	// RVA: 0x445280 Offset: 0x443C80 VA: 0x180445280
	public IEnumerator GetBoardsAsync(Action<Board[]> onFinished) { }

	// RVA: 0x445310 Offset: 0x443D10 VA: 0x180445310
	public Board[] GetBoards() { }

	// RVA: 0x445470 Offset: 0x443E70 VA: 0x180445470
	public Label[] GetLabels(string boardID) { }

	// RVA: 0x4456C0 Offset: 0x4440C0 VA: 0x1804456C0
	public bool GetSubscribed(string boardID) { }

	// RVA: 0x445970 Offset: 0x444370 VA: 0x180445970
	public void PutSubscribed(string boardID, bool value) { }

	[CompilerGenerated]
	// RVA: 0x445BA0 Offset: 0x4445A0 VA: 0x180445BA0
	private void <AddCard>b__17_1(WebResponse resp) { }

	[CompilerGenerated]
	// RVA: 0x445B70 Offset: 0x444570 VA: 0x180445B70
	private void <AddAttachmentAsync>b__18_0(WebResponse resp) { }
}

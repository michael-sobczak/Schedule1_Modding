internal class BufferX : IBuffer, IBufferDebug // TypeDefIndex: 17942
{
	// Fields
	private const long k_UploadBatchMaximumSizeInBytes = 4194304;
	private const string k_MillisecondDateFormat = "yyyy-MM-dd HH:mm:ss.fff zzz";
	private readonly byte[] k_WorkingBuffer; // 0x10
	private readonly char[] k_WorkingCharacterBuffer; // 0x18
	private readonly byte[] k_PayloadHeader; // 0x20
	private readonly byte[] k_HeaderEventName; // 0x28
	private readonly byte[] k_HeaderUserName; // 0x30
	private readonly byte[] k_HeaderSessionID; // 0x38
	private readonly byte[] k_HeaderEventUUID; // 0x40
	private readonly byte[] k_HeaderTimestamp; // 0x48
	private readonly byte[] k_HeaderEventVersion; // 0x50
	private readonly byte[] k_HeaderInstallationID; // 0x58
	private readonly byte[] k_HeaderPlayerID; // 0x60
	private readonly byte[] k_HeaderOpenEventParams; // 0x68
	private readonly byte[] k_CloseEvent; // 0x70
	private readonly byte k_Quote; // 0x78
	private readonly byte[] k_QuoteColon; // 0x80
	private readonly byte[] k_QuoteComma; // 0x88
	private readonly byte[] k_Comma; // 0x90
	private readonly byte[] k_OpenBrace; // 0x98
	private readonly byte[] k_CloseBraceComma; // 0xA0
	private readonly byte[] k_OpenBracket; // 0xA8
	private readonly byte[] k_CloseBracketComma; // 0xB0
	private readonly byte k_Colon; // 0xB8
	private readonly byte k_Dash; // 0xB9
	private readonly byte k_Space; // 0xBA
	private readonly byte k_Point; // 0xBB
	private readonly byte k_Positive; // 0xBC
	private readonly byte k_Negative; // 0xBD
	private readonly byte[] k_True; // 0xC0
	private readonly byte[] k_False; // 0xC8
	private readonly byte[] k_Int2CharacterByte; // 0xD0
	private readonly long[] k_Order; // 0xD8
	private readonly IBufferSystemCalls m_SystemCalls; // 0xE0
	private readonly IDiskCache m_DiskCache; // 0xE8
	private readonly IIdentityManager m_UserIdentity; // 0xF0
	private readonly ISessionManager m_Session; // 0xF8
	private readonly List<EventSummary> m_EventSummaries; // 0x100
	private string m_CurrentEventId; // 0x108
	private string m_CurrentEventName; // 0x110
	private DateTime m_CurrentEventTimestamp; // 0x118
	private MemoryStream m_SpareBuffer; // 0x120
	private MemoryStream m_Buffer; // 0x128
	[CompilerGenerated]
	private Action<string, string, DateTime, byte[]> EventRecorded; // 0x130
	[CompilerGenerated]
	private Action<HashSet<string>> EventsClearing; // 0x138
	[CompilerGenerated]
	private Action<HashSet<string>> EventsCleared; // 0x140

	// Properties
	public int Length { get; }
	internal int EventsRecorded { get; }
	internal IReadOnlyList<EventSummary> EventSummaries { get; }
	internal byte[] RawContents { get; }

	// Methods

	// RVA: 0x2B8D1C0 Offset: 0x2B8BBC0 VA: 0x182B8D1C0 Slot: 18
	public int get_Length() { }

	// RVA: 0x2B8D180 Offset: 0x2B8BB80 VA: 0x182B8D180
	internal int get_EventsRecorded() { }

	// RVA: 0x516250 Offset: 0x514C50 VA: 0x180516250
	internal IReadOnlyList<EventSummary> get_EventSummaries() { }

	// RVA: 0x2B8D1F0 Offset: 0x2B8BBF0 VA: 0x182B8D1F0
	internal byte[] get_RawContents() { }

	[CompilerGenerated]
	// RVA: 0x2B8CF40 Offset: 0x2B8B940 VA: 0x182B8CF40 Slot: 22
	public void add_EventRecorded(Action<string, string, DateTime, byte[]> value) { }

	[CompilerGenerated]
	// RVA: 0x2B8D220 Offset: 0x2B8BC20 VA: 0x182B8D220 Slot: 23
	public void remove_EventRecorded(Action<string, string, DateTime, byte[]> value) { }

	[CompilerGenerated]
	// RVA: 0x2B8D0C0 Offset: 0x2B8BAC0 VA: 0x182B8D0C0 Slot: 24
	public void add_EventsClearing(Action<HashSet<string>> value) { }

	[CompilerGenerated]
	// RVA: 0x2B8D3A0 Offset: 0x2B8BDA0 VA: 0x182B8D3A0 Slot: 25
	public void remove_EventsClearing(Action<HashSet<string>> value) { }

	[CompilerGenerated]
	// RVA: 0x2B8D000 Offset: 0x2B8BA00 VA: 0x182B8D000 Slot: 26
	public void add_EventsCleared(Action<HashSet<string>> value) { }

	[CompilerGenerated]
	// RVA: 0x2B8D2E0 Offset: 0x2B8BCE0 VA: 0x182B8D2E0 Slot: 27
	public void remove_EventsCleared(Action<HashSet<string>> value) { }

	// RVA: 0x2B8C450 Offset: 0x2B8AE50 VA: 0x182B8C450
	public void .ctor(IBufferSystemCalls eventIdGenerator, IDiskCache diskCache, IIdentityManager userIdentity, ISessionManager session) { }

	// RVA: 0x2B8C390 Offset: 0x2B8AD90 VA: 0x182B8C390
	private void WriteString(in string value) { }

	// RVA: 0x2B8C280 Offset: 0x2B8AC80 VA: 0x182B8C280
	private void WriteLong(in long value) { }

	// RVA: 0x2B8BC70 Offset: 0x2B8A670 VA: 0x182B8BC70
	private void WriteByte(in byte value) { }

	// RVA: 0x2B8BCB0 Offset: 0x2B8A6B0 VA: 0x182B8BCB0
	private void WriteBytes(in byte[] bytes) { }

	// RVA: 0x2B8C2F0 Offset: 0x2B8ACF0 VA: 0x182B8C2F0
	private void WriteName(string name) { }

	// RVA: 0x2B8BD00 Offset: 0x2B8A700 VA: 0x182B8BD00
	private void WriteDateTime(DateTime dateTime) { }

	// RVA: 0x2B8B560 Offset: 0x2B89F60 VA: 0x182B8B560
	private int SerializeLong(in long number, in byte[] buffer, in int startIndex, in int minimumLength) { }

	// RVA: 0x2B8AC60 Offset: 0x2B89660 VA: 0x182B8AC60 Slot: 4
	public void PushStandardEventStart(string name, int version) { }

	// RVA: 0x2B88DF0 Offset: 0x2B877F0 VA: 0x182B88DF0 Slot: 5
	public void PushCustomEventStart(string name) { }

	// RVA: 0x2B88B00 Offset: 0x2B87500 VA: 0x182B88B00
	private void PushCommonEventStart(string name) { }

	// RVA: 0x2B8BB90 Offset: 0x2B8A590 VA: 0x182B8BB90
	private void StripTrailingCommaIfNecessary() { }

	// RVA: 0x2B88FA0 Offset: 0x2B879A0 VA: 0x182B88FA0 Slot: 6
	public void PushEndEvent() { }

	// RVA: 0x2B896D0 Offset: 0x2B880D0 VA: 0x182B896D0
	public void PushObjectStart(string name) { }

	// RVA: 0x2B89670 Offset: 0x2B88070 VA: 0x182B89670
	public void PushObjectEnd() { }

	// RVA: 0x2B888D0 Offset: 0x2B872D0 VA: 0x182B888D0
	public void PushArrayStart(string name) { }

	// RVA: 0x2B88870 Offset: 0x2B87270 VA: 0x182B88870
	public void PushArrayEnd() { }

	// RVA: 0x2B88E50 Offset: 0x2B87850 VA: 0x182B88E50 Slot: 7
	public void PushDouble(string name, double value) { }

	// RVA: 0x2B893D0 Offset: 0x2B87DD0 VA: 0x182B893D0 Slot: 8
	public void PushFloat(string name, float value) { }

	// RVA: 0x2B8AF90 Offset: 0x2B89990 VA: 0x182B8AF90 Slot: 9
	public void PushString(string name, string value) { }

	// RVA: 0x2B886A0 Offset: 0x2B870A0 VA: 0x182B886A0
	private int ProcessCharacterOntoWorkingBuffer(int index, char character) { }

	// RVA: 0x2B89520 Offset: 0x2B87F20 VA: 0x182B89520 Slot: 10
	public void PushInt64(string name, long value) { }

	// RVA: 0x2B89660 Offset: 0x2B88060 VA: 0x182B89660 Slot: 11
	public void PushInt(string name, int value) { }

	// RVA: 0x2B889B0 Offset: 0x2B873B0 VA: 0x182B889B0 Slot: 12
	public void PushBool(string name, bool value) { }

	// RVA: 0x2B8B3B0 Offset: 0x2B89DB0 VA: 0x182B8B3B0
	public void PushTimestamp(string name, DateTime value) { }

	// RVA: 0x2B8A3A0 Offset: 0x2B88DA0 VA: 0x182B8A3A0 Slot: 14
	public void PushProduct(string name, TransactionRealCurrency realCurrency, List<TransactionVirtualCurrency> virtualCurrencies, List<TransactionItem> items) { }

	// RVA: 0x2B897B0 Offset: 0x2B881B0 VA: 0x182B897B0 Slot: 13
	public void PushObject(string name, object value) { }

	// RVA: 0x2B8B770 Offset: 0x2B8A170 VA: 0x182B8B770 Slot: 19
	public byte[] Serialize() { }

	// RVA: 0x2B883C0 Offset: 0x2B86DC0 VA: 0x182B883C0 Slot: 20
	public void ClearBuffer() { }

	// RVA: 0x2B87F60 Offset: 0x2B86960 VA: 0x182B87F60 Slot: 21
	public void ClearBuffer(long upTo) { }

	// RVA: 0x2B884C0 Offset: 0x2B86EC0 VA: 0x182B884C0 Slot: 15
	public void FlushToDisk() { }

	// RVA: 0x2B88470 Offset: 0x2B86E70 VA: 0x182B88470 Slot: 16
	public void ClearDiskCache() { }

	// RVA: 0x2B885A0 Offset: 0x2B86FA0 VA: 0x182B885A0 Slot: 17
	public void LoadFromDisk() { }

	// RVA: 0x2B8B4D0 Offset: 0x2B89ED0 VA: 0x182B8B4D0
	internal static string SerializeDateTime(DateTime dateTime) { }
}

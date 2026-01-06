public abstract class WebRequest : MarshalByRefObject, ISerializable // TypeDefIndex: 9994
{
	// Fields
	private static ArrayList s_PrefixList; // 0x0
	private static object s_InternalSyncObject; // 0x8
	private static TimerThread.Queue s_DefaultTimerQueue; // 0x10
	private AuthenticationLevel m_AuthenticationLevel; // 0x18
	private TokenImpersonationLevel m_ImpersonationLevel; // 0x1C
	private RequestCachePolicy m_CachePolicy; // 0x20
	private RequestCacheProtocol m_CacheProtocol; // 0x28
	private RequestCacheBinding m_CacheBinding; // 0x30
	private static WebRequest.DesignerWebRequestCreate webRequestCreate; // 0x18
	private static IWebProxy s_DefaultWebProxy; // 0x20
	private static bool s_DefaultWebProxyInitialized; // 0x28

	// Properties
	private static object InternalSyncObject { get; }
	internal static ArrayList PrefixList { get; }
	public static RequestCachePolicy DefaultCachePolicy { get; }
	public virtual RequestCachePolicy CachePolicy { set; }
	public virtual string Method { get; set; }
	public virtual Uri RequestUri { get; }
	public virtual string ConnectionGroupName { set; }
	public virtual WebHeaderCollection Headers { get; }
	public virtual long ContentLength { get; set; }
	public virtual ICredentials Credentials { get; set; }
	public virtual bool UseDefaultCredentials { get; }
	public virtual IWebProxy Proxy { get; set; }
	public virtual bool PreAuthenticate { set; }
	public virtual int Timeout { get; set; }
	internal RequestCacheProtocol CacheProtocol { get; set; }
	internal static IWebProxy InternalDefaultWebProxy { get; }

	// Methods

	// RVA: 0x26D0EE0 Offset: 0x26CF8E0 VA: 0x1826D0EE0
	private static object get_InternalSyncObject() { }

	// RVA: 0x26CFB80 Offset: 0x26CE580 VA: 0x1826CFB80
	private static WebRequest Create(Uri requestUri, bool useUriBase) { }

	// RVA: 0x26CFF10 Offset: 0x26CE910 VA: 0x1826CFF10
	public static WebRequest Create(string requestUriString) { }

	// RVA: 0x26CFE40 Offset: 0x26CE840 VA: 0x1826CFE40
	public static WebRequest Create(Uri requestUri) { }

	// RVA: 0x26D1000 Offset: 0x26CFA00 VA: 0x1826D1000
	internal static ArrayList get_PrefixList() { }

	// RVA: 0x26D0610 Offset: 0x26CF010 VA: 0x1826D0610
	private static ArrayList PopulatePrefixList() { }

	// RVA: 0x26D0BC0 Offset: 0x26CF5C0 VA: 0x1826D0BC0
	protected void .ctor() { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	protected void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x25B1980 Offset: 0x25B0380 VA: 0x1825B1980 Slot: 6
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 7
	protected virtual void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x26D0C50 Offset: 0x26CF650 VA: 0x1826D0C50
	public static RequestCachePolicy get_DefaultCachePolicy() { }

	// RVA: 0x26D0530 Offset: 0x26CEF30 VA: 0x1826D0530 Slot: 8
	public virtual void set_CachePolicy(RequestCachePolicy value) { }

	// RVA: 0x26D0530 Offset: 0x26CEF30 VA: 0x1826D0530
	private void InternalSetCachePolicy(RequestCachePolicy policy) { }

	// RVA: 0x26D0FD0 Offset: 0x26CF9D0 VA: 0x1826D0FD0 Slot: 9
	public virtual string get_Method() { }

	// RVA: 0x26D1300 Offset: 0x26CFD00 VA: 0x1826D1300 Slot: 10
	public virtual void set_Method(string value) { }

	// RVA: 0x26D11E0 Offset: 0x26CFBE0 VA: 0x1826D11E0 Slot: 11
	public virtual Uri get_RequestUri() { }

	// RVA: 0x26D1270 Offset: 0x26CFC70 VA: 0x1826D1270 Slot: 12
	public virtual void set_ConnectionGroupName(string value) { }

	// RVA: 0x26D0CD0 Offset: 0x26CF6D0 VA: 0x1826D0CD0 Slot: 13
	public virtual WebHeaderCollection get_Headers() { }

	// RVA: 0x26D0BF0 Offset: 0x26CF5F0 VA: 0x1826D0BF0 Slot: 14
	public virtual long get_ContentLength() { }

	// RVA: 0x26D12A0 Offset: 0x26CFCA0 VA: 0x1826D12A0 Slot: 15
	public virtual void set_ContentLength(long value) { }

	// RVA: 0x26D0C20 Offset: 0x26CF620 VA: 0x1826D0C20 Slot: 16
	public virtual ICredentials get_Credentials() { }

	// RVA: 0x26D12D0 Offset: 0x26CFCD0 VA: 0x1826D12D0 Slot: 17
	public virtual void set_Credentials(ICredentials value) { }

	// RVA: 0x26D1240 Offset: 0x26CFC40 VA: 0x1826D1240 Slot: 18
	public virtual bool get_UseDefaultCredentials() { }

	// RVA: 0x26D11B0 Offset: 0x26CFBB0 VA: 0x1826D11B0 Slot: 19
	public virtual IWebProxy get_Proxy() { }

	// RVA: 0x26D1360 Offset: 0x26CFD60 VA: 0x1826D1360 Slot: 20
	public virtual void set_Proxy(IWebProxy value) { }

	// RVA: 0x26D1330 Offset: 0x26CFD30 VA: 0x1826D1330 Slot: 21
	public virtual void set_PreAuthenticate(bool value) { }

	// RVA: 0x26D1210 Offset: 0x26CFC10 VA: 0x1826D1210 Slot: 22
	public virtual int get_Timeout() { }

	// RVA: 0x26D1390 Offset: 0x26CFD90 VA: 0x1826D1390 Slot: 23
	public virtual void set_Timeout(int value) { }

	// RVA: 0x26D0500 Offset: 0x26CEF00 VA: 0x1826D0500 Slot: 24
	public virtual WebResponse GetResponse() { }

	// RVA: 0x26CFB50 Offset: 0x26CE550 VA: 0x1826CFB50 Slot: 25
	public virtual IAsyncResult BeginGetResponse(AsyncCallback callback, object state) { }

	// RVA: 0x26D0010 Offset: 0x26CEA10 VA: 0x1826D0010 Slot: 26
	public virtual WebResponse EndGetResponse(IAsyncResult asyncResult) { }

	// RVA: 0x26CFB20 Offset: 0x26CE520 VA: 0x1826CFB20 Slot: 27
	public virtual IAsyncResult BeginGetRequestStream(AsyncCallback callback, object state) { }

	// RVA: 0x26CFFE0 Offset: 0x26CE9E0 VA: 0x1826CFFE0 Slot: 28
	public virtual Stream EndGetRequestStream(IAsyncResult asyncResult) { }

	// RVA: 0x26D0040 Offset: 0x26CEA40 VA: 0x1826D0040 Slot: 29
	public virtual Task<Stream> GetRequestStreamAsync() { }

	// RVA: 0x26D02A0 Offset: 0x26CECA0 VA: 0x1826D02A0 Slot: 30
	public virtual Task<WebResponse> GetResponseAsync() { }

	// RVA: 0x26D08A0 Offset: 0x26CF2A0 VA: 0x1826D08A0
	private WindowsIdentity SafeCaptureIdenity() { }

	// RVA: 0x26CFAF0 Offset: 0x26CE4F0 VA: 0x1826CFAF0 Slot: 31
	public virtual void Abort() { }

	// RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0
	internal RequestCacheProtocol get_CacheProtocol() { }

	// RVA: 0x4513F0 Offset: 0x44FDF0 VA: 0x1804513F0
	internal void set_CacheProtocol(RequestCacheProtocol value) { }

	// RVA: 0x26D0D00 Offset: 0x26CF700 VA: 0x1826D0D00
	internal static IWebProxy get_InternalDefaultWebProxy() { }

	// RVA: 0x26D0AE0 Offset: 0x26CF4E0 VA: 0x1826D0AE0
	private static void .cctor() { }

	[CompilerGenerated]
	// RVA: 0x26D08E0 Offset: 0x26CF2E0 VA: 0x1826D08E0
	private Task<Stream> <GetRequestStreamAsync>b__78_0() { }

	[CompilerGenerated]
	// RVA: 0x26D09E0 Offset: 0x26CF3E0 VA: 0x1826D09E0
	private Task<WebResponse> <GetResponseAsync>b__79_0() { }
}

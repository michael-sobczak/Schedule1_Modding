public class Exception : ISerializable // TypeDefIndex: 3815
{
	// Fields
	[OptionalField]
	private static object s_EDILock; // 0x0
	private string _className; // 0x10
	internal string _message; // 0x18
	private IDictionary _data; // 0x20
	private Exception _innerException; // 0x28
	private string _helpURL; // 0x30
	private object _stackTrace; // 0x38
	private string _stackTraceString; // 0x40
	private string _remoteStackTraceString; // 0x48
	private int _remoteStackIndex; // 0x50
	private object _dynamicMethods; // 0x58
	internal int _HResult; // 0x60
	private string _source; // 0x68
	[OptionalField(VersionAdded = 4)]
	private SafeSerializationManager _safeSerializationManager; // 0x70
	internal StackTrace[] captured_traces; // 0x78
	private IntPtr[] native_trace_ips; // 0x80
	private int caught_in_unmanaged; // 0x88
	private const int _COMPlusExceptionCode = -532462766;

	// Properties
	public virtual string Message { get; }
	public virtual IDictionary Data { get; }
	public Exception InnerException { get; }
	public MethodBase TargetSite { get; }
	public virtual string StackTrace { get; }
	public virtual string HelpLink { get; set; }
	public virtual string Source { get; set; }
	internal string RemoteStackTrace { get; }
	public int HResult { get; set; }
	internal bool IsTransient { get; }

	// Methods

	// RVA: 0x1CA77C0 Offset: 0x1CA61C0 VA: 0x181CA77C0
	private void Init() { }

	// RVA: 0x1CA7D40 Offset: 0x1CA6740 VA: 0x181CA7D40
	public void .ctor() { }

	// RVA: 0x1CA8240 Offset: 0x1CA6C40 VA: 0x181CA8240
	public void .ctor(string message) { }

	// RVA: 0x1CA8280 Offset: 0x1CA6C80 VA: 0x181CA8280
	public void .ctor(string message, Exception innerException) { }

	// RVA: 0x1CA7D60 Offset: 0x1CA6760 VA: 0x181CA7D60
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1CA8390 Offset: 0x1CA6D90 VA: 0x181CA8390 Slot: 5
	public virtual string get_Message() { }

	// RVA: 0x1CA82E0 Offset: 0x1CA6CE0 VA: 0x181CA82E0 Slot: 6
	public virtual IDictionary get_Data() { }

	// RVA: 0x1CA71E0 Offset: 0x1CA5BE0 VA: 0x181CA71E0
	private string GetClassName() { }

	// RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0 Slot: 7
	public Exception get_InnerException() { }

	// RVA: 0x1CA8640 Offset: 0x1CA7040 VA: 0x181CA8640 Slot: 8
	public MethodBase get_TargetSite() { }

	// RVA: 0x1CA8600 Offset: 0x1CA7000 VA: 0x181CA8600 Slot: 9
	public virtual string get_StackTrace() { }

	// RVA: 0x1CA7770 Offset: 0x1CA6170 VA: 0x181CA7770
	private string GetStackTrace(bool needFileInfo) { }

	// RVA: 0x4E2900 Offset: 0x4E1300 VA: 0x1804E2900
	internal void SetErrorCode(int hr) { }

	// RVA: 0x4513A0 Offset: 0x44FDA0 VA: 0x1804513A0 Slot: 10
	public virtual string get_HelpLink() { }

	// RVA: 0x4513D0 Offset: 0x44FDD0 VA: 0x1804513D0 Slot: 11
	public virtual void set_HelpLink(string value) { }

	// RVA: 0x1CA84B0 Offset: 0x1CA6EB0 VA: 0x181CA84B0 Slot: 12
	public virtual string get_Source() { }

	// RVA: 0x5F4EB0 Offset: 0x5F38B0 VA: 0x1805F4EB0 Slot: 13
	public virtual void set_Source(string value) { }

	// RVA: 0x1CA7CB0 Offset: 0x1CA66B0 VA: 0x181CA7CB0 Slot: 3
	public override string ToString() { }

	// RVA: 0x1CA79E0 Offset: 0x1CA63E0 VA: 0x181CA79E0
	private string ToString(bool needFileLineInfo, bool needMessage) { }

	// RVA: 0x1CA72D0 Offset: 0x1CA5CD0 VA: 0x181CA72D0 Slot: 14
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	[OnDeserialized]
	// RVA: 0x1CA7860 Offset: 0x1CA6260 VA: 0x181CA7860
	private void OnDeserialized(StreamingContext context) { }

	// RVA: 0x499060 Offset: 0x497A60 VA: 0x180499060
	private string StripFileInfo(string stackTrace, bool isRemoteStackTrace) { }

	// RVA: 0x4C1D80 Offset: 0x4C0780 VA: 0x1804C1D80
	internal string get_RemoteStackTrace() { }

	// RVA: 0x1CA7900 Offset: 0x1CA6300 VA: 0x181CA7900
	internal void RestoreExceptionDispatchInfo(ExceptionDispatchInfo exceptionDispatchInfo) { }

	// RVA: 0x4E2410 Offset: 0x4E0E10 VA: 0x1804E2410
	public int get_HResult() { }

	// RVA: 0x4E2900 Offset: 0x4E1300 VA: 0x1804E2900
	protected void set_HResult(int value) { }

	// RVA: 0x1C8F6B0 Offset: 0x1C8E0B0 VA: 0x181C8F6B0 Slot: 15
	public Type GetType() { }

	// RVA: 0x1CA8350 Offset: 0x1CA6D50 VA: 0x181CA8350
	internal bool get_IsTransient() { }

	// RVA: 0x1CA8700 Offset: 0x1CA7100 VA: 0x181CA8700
	private static bool nIsTransient(int hr) { }

	// RVA: 0x1CA7240 Offset: 0x1CA5C40 VA: 0x181CA7240
	internal static string GetMessageFromNativeResources(Exception.ExceptionMessageKind kind) { }

	// RVA: 0x1CA70E0 Offset: 0x1CA5AE0 VA: 0x181CA70E0
	internal Exception FixRemotingException() { }

	// RVA: 0x1CA78F0 Offset: 0x1CA62F0 VA: 0x181CA78F0
	internal static void ReportUnhandledException(Exception exception) { }

	// RVA: 0x1CA7CC0 Offset: 0x1CA66C0 VA: 0x181CA7CC0
	private static void .cctor() { }
}

public class UnityWebRequest : IDisposable // TypeDefIndex: 18713
{
	// Fields
	internal IntPtr m_Ptr; // 0x10
	internal DownloadHandler m_DownloadHandler; // 0x18
	internal UploadHandler m_UploadHandler; // 0x20
	internal CertificateHandler m_CertificateHandler; // 0x28
	internal Uri m_Uri; // 0x30
	public const string kHttpVerbGET = "GET";
	public const string kHttpVerbHEAD = "HEAD";
	public const string kHttpVerbPOST = "POST";
	public const string kHttpVerbPUT = "PUT";
	public const string kHttpVerbCREATE = "CREATE";
	public const string kHttpVerbDELETE = "DELETE";
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private bool <disposeCertificateHandlerOnDispose>k__BackingField; // 0x38
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private bool <disposeDownloadHandlerOnDispose>k__BackingField; // 0x39
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private bool <disposeUploadHandlerOnDispose>k__BackingField; // 0x3A

	// Properties
	public bool disposeCertificateHandlerOnDispose { get; set; }
	public bool disposeDownloadHandlerOnDispose { get; set; }
	public bool disposeUploadHandlerOnDispose { get; set; }
	public string method { set; }
	public string error { get; }
	public string url { get; set; }
	public long responseCode { get; }
	public bool isModifiable { get; }
	public bool isDone { get; }
	public UnityWebRequest.Result result { get; }
	[Obsolete("HTTP/2 and many HTTP/1.1 servers don't support this; we recommend leaving it set to false (default).", False)]
	public bool chunkedTransfer { set; }
	public UploadHandler uploadHandler { get; set; }
	public DownloadHandler downloadHandler { get; set; }
	public CertificateHandler certificateHandler { get; }

	// Methods

	[NativeConditional("ENABLE_UNITYWEBREQUEST")]
	[NativeMethod(IsThreadSafe = True)]
	// RVA: 0x2F57EB0 Offset: 0x2F568B0 VA: 0x182F57EB0
	private static string GetWebErrorString(UnityWebRequest.UnityWebRequestError err) { }

	[VisibleToOtherModules]
	// RVA: 0x2F57E30 Offset: 0x2F56830 VA: 0x182F57E30
	internal static string GetHTTPStatusString(long responseCode) { }

	[CompilerGenerated]
	// RVA: 0x8D2170 Offset: 0x8D0B70 VA: 0x1808D2170
	public bool get_disposeCertificateHandlerOnDispose() { }

	[CompilerGenerated]
	// RVA: 0x91C530 Offset: 0x91AF30 VA: 0x18091C530
	public void set_disposeCertificateHandlerOnDispose(bool value) { }

	[CompilerGenerated]
	// RVA: 0x8D2180 Offset: 0x8D0B80 VA: 0x1808D2180
	public bool get_disposeDownloadHandlerOnDispose() { }

	[CompilerGenerated]
	// RVA: 0xCD74A0 Offset: 0xCD5EA0 VA: 0x180CD74A0
	public void set_disposeDownloadHandlerOnDispose(bool value) { }

	[CompilerGenerated]
	// RVA: 0x1B24E10 Offset: 0x1B23810 VA: 0x181B24E10
	public bool get_disposeUploadHandlerOnDispose() { }

	[CompilerGenerated]
	// RVA: 0x1B24E20 Offset: 0x1B23820 VA: 0x181B24E20
	public void set_disposeUploadHandlerOnDispose(bool value) { }

	[NativeThrows]
	// RVA: 0x2F57C50 Offset: 0x2F56650 VA: 0x182F57C50
	internal static IntPtr Create() { }

	[NativeMethod(IsThreadSafe = True)]
	// RVA: 0x2F58650 Offset: 0x2F57050 VA: 0x182F58650
	private void Release() { }

	// RVA: 0x2F58020 Offset: 0x2F56A20 VA: 0x182F58020
	internal void InternalDestroy() { }

	// RVA: 0x2F581A0 Offset: 0x2F56BA0 VA: 0x182F581A0
	private void InternalSetDefaults() { }

	// RVA: 0x2F58FE0 Offset: 0x2F579E0 VA: 0x182F58FE0
	public void .ctor() { }

	// RVA: 0x2F59030 Offset: 0x2F57A30 VA: 0x182F59030
	public void .ctor(string url, string method) { }

	// RVA: 0x2F58F30 Offset: 0x2F57930 VA: 0x182F58F30
	public void .ctor(string url, string method, DownloadHandler downloadHandler, UploadHandler uploadHandler) { }

	// RVA: 0x2F57D80 Offset: 0x2F56780 VA: 0x182F57D80 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x2F57D20 Offset: 0x2F56720 VA: 0x182F57D20 Slot: 4
	public void Dispose() { }

	// RVA: 0x2F57C80 Offset: 0x2F56680 VA: 0x182F57C80
	private void DisposeHandlers() { }

	[NativeThrows]
	// RVA: 0x2F57C10 Offset: 0x2F56610 VA: 0x182F57C10
	internal UnityWebRequestAsyncOperation BeginWebRequest() { }

	// RVA: 0x2F58690 Offset: 0x2F57090 VA: 0x182F58690
	public UnityWebRequestAsyncOperation SendWebRequest() { }

	[NativeMethod(IsThreadSafe = True)]
	// RVA: 0x2F57BD0 Offset: 0x2F565D0 VA: 0x182F57BD0
	public void Abort() { }

	// RVA: 0x2F587E0 Offset: 0x2F571E0 VA: 0x182F587E0
	private UnityWebRequest.UnityWebRequestError SetMethod(UnityWebRequest.UnityWebRequestMethod methodType) { }

	// RVA: 0x2F581B0 Offset: 0x2F56BB0 VA: 0x182F581B0
	internal void InternalSetMethod(UnityWebRequest.UnityWebRequestMethod methodType) { }

	// RVA: 0x2F58740 Offset: 0x2F57140 VA: 0x182F58740
	private UnityWebRequest.UnityWebRequestError SetCustomMethod(string customMethodName) { }

	// RVA: 0x2F580A0 Offset: 0x2F56AA0 VA: 0x182F580A0
	internal void InternalSetCustomMethod(string customMethodName) { }

	// RVA: 0x2F59540 Offset: 0x2F57F40 VA: 0x182F59540
	public void set_method(string value) { }

	// RVA: 0x2F57DF0 Offset: 0x2F567F0 VA: 0x182F57DF0
	private UnityWebRequest.UnityWebRequestError GetError() { }

	// RVA: 0x2F590B0 Offset: 0x2F57AB0 VA: 0x182F590B0
	public string get_error() { }

	// RVA: 0x2F57E70 Offset: 0x2F56870 VA: 0x182F57E70
	public string get_url() { }

	// RVA: 0x2F598B0 Offset: 0x2F582B0 VA: 0x182F598B0
	public void set_url(string value) { }

	// RVA: 0x2F57E70 Offset: 0x2F56870 VA: 0x182F57E70
	private string GetUrl() { }

	// RVA: 0x2F58A40 Offset: 0x2F57440 VA: 0x182F58A40
	private UnityWebRequest.UnityWebRequestError SetUrl(string url) { }

	// RVA: 0x2F58310 Offset: 0x2F56D10 VA: 0x182F58310
	private void InternalSetUrl(string url) { }

	// RVA: 0x2F592A0 Offset: 0x2F57CA0 VA: 0x182F592A0
	public long get_responseCode() { }

	[NativeMethod("IsModifiable")]
	// RVA: 0x2F59260 Offset: 0x2F57C60 VA: 0x182F59260
	public bool get_isModifiable() { }

	// RVA: 0x2F59220 Offset: 0x2F57C20 VA: 0x182F59220
	public bool get_isDone() { }

	[NativeMethod("GetResult")]
	// RVA: 0x2F592E0 Offset: 0x2F57CE0 VA: 0x182F592E0
	public UnityWebRequest.Result get_result() { }

	// RVA: 0x2F586F0 Offset: 0x2F570F0 VA: 0x182F586F0
	private UnityWebRequest.UnityWebRequestError SetChunked(bool chunked) { }

	// RVA: 0x2F59320 Offset: 0x2F57D20 VA: 0x182F59320
	public void set_chunkedTransfer(bool value) { }

	[NativeMethod("SetRequestHeader")]
	// RVA: 0x2F582B0 Offset: 0x2F56CB0 VA: 0x182F582B0
	internal UnityWebRequest.UnityWebRequestError InternalSetRequestHeader(string name, string value) { }

	// RVA: 0x2F58820 Offset: 0x2F57220 VA: 0x182F58820
	public void SetRequestHeader(string name, string value) { }

	// RVA: 0x2F589F0 Offset: 0x2F573F0 VA: 0x182F589F0
	private UnityWebRequest.UnityWebRequestError SetUploadHandler(UploadHandler uh) { }

	// RVA: 0x1E09860 Offset: 0x1E08260 VA: 0x181E09860
	public UploadHandler get_uploadHandler() { }

	// RVA: 0x2F597A0 Offset: 0x2F581A0 VA: 0x182F597A0
	public void set_uploadHandler(UploadHandler value) { }

	// RVA: 0x2F58790 Offset: 0x2F57190 VA: 0x182F58790
	private UnityWebRequest.UnityWebRequestError SetDownloadHandler(DownloadHandler dh) { }

	// RVA: 0x1670E50 Offset: 0x166F850 VA: 0x181670E50
	public DownloadHandler get_downloadHandler() { }

	// RVA: 0x2F59430 Offset: 0x2F57E30 VA: 0x182F59430
	public void set_downloadHandler(DownloadHandler value) { }

	// RVA: 0x1E0E080 Offset: 0x1E0CA80 VA: 0x181E0E080
	public CertificateHandler get_certificateHandler() { }

	// RVA: 0x2F57EF0 Offset: 0x2F568F0 VA: 0x182F57EF0
	public static UnityWebRequest Get(string uri) { }

	// RVA: 0x2F58410 Offset: 0x2F56E10 VA: 0x182F58410
	public static UnityWebRequest Post(string uri, string postData, string contentType) { }

	// RVA: 0x2F58DC0 Offset: 0x2F577C0 VA: 0x182F58DC0
	private static void SetupPost(UnityWebRequest request, string postData, string contentType) { }

	// RVA: 0x2F585C0 Offset: 0x2F56FC0 VA: 0x182F585C0
	public static UnityWebRequest Post(string uri, WWWForm formData) { }

	// RVA: 0x2F58A90 Offset: 0x2F57490 VA: 0x182F58A90
	private static void SetupPost(UnityWebRequest request, WWWForm formData) { }
}

internal static class WebInterface // TypeDefIndex: 17991
{
	// Methods

	// RVA: 0x449BE0 Offset: 0x4485E0 VA: 0x180449BE0
	public static WebResponse Get(string uri, Action<AsyncWebRequestData> onStatusUpdate) { }

	// RVA: 0x449A80 Offset: 0x448480 VA: 0x180449A80
	public static IEnumerator GetCoroutine(string uri, Action<WebResponse> onResponseReturned) { }

	// RVA: 0x44A320 Offset: 0x448D20 VA: 0x18044A320
	public static WebResponse Post(string uri, WWWForm data, Action<AsyncWebRequestData> onStatusUpdate) { }

	// RVA: 0x44A400 Offset: 0x448E00 VA: 0x18044A400
	public static WebResponse Post(string uri, string contentType, byte[] data, Action<AsyncWebRequestData> onStatusUpdate) { }

	// RVA: 0x44A210 Offset: 0x448C10 VA: 0x18044A210
	public static IEnumerator PostCoroutine(string uri, WWWForm data, Action<WebResponse> onResponseReturned) { }

	// RVA: 0x44A160 Offset: 0x448B60 VA: 0x18044A160
	public static IEnumerator PostCoroutine(string uri, string contentType, byte[] data, Action<WebResponse> onResponseReturned) { }

	// RVA: 0x44A520 Offset: 0x448F20 VA: 0x18044A520
	public static WebResponse Put(string uri, string contentType, byte[] data, Action<AsyncWebRequestData> onStatusUpdate) { }

	// RVA: 0x44A470 Offset: 0x448E70 VA: 0x18044A470
	public static IEnumerator PutCoroutine(string uri, string contentType, byte[] data, Action<WebResponse> onResponseReturned) { }

	// RVA: 0x449C40 Offset: 0x448640 VA: 0x180449C40
	private static AsyncWebRequestData MakeGet(string uri) { }

	// RVA: 0x449D90 Offset: 0x448790 VA: 0x180449D90
	private static AsyncWebRequestData MakePost(string uri, WWWForm data) { }

	// RVA: 0x449E30 Offset: 0x448830 VA: 0x180449E30
	private static AsyncWebRequestData MakePost(string uri, string contentType, byte[] data) { }

	// RVA: 0x449E70 Offset: 0x448870 VA: 0x180449E70
	private static AsyncWebRequestData MakePut(string uri, string contentType, byte[] data) { }

	// RVA: 0x449EB0 Offset: 0x4488B0 VA: 0x180449EB0
	private static AsyncWebRequestData MakeRequest(string uri, WebRequestMethod method, string contentType, byte[] data) { }

	// RVA: 0x44A0D0 Offset: 0x448AD0 VA: 0x18044A0D0
	private static AsyncWebRequestData MakeRequest(string uri, WWWForm data) { }

	// RVA: 0x44A830 Offset: 0x449230 VA: 0x18044A830
	private static WebResponse WaitForResponse(AsyncWebRequestData requestData, Action<AsyncWebRequestData> onStatusUpdate) { }

	[IteratorStateMachine(typeof(WebInterface.<WaitForResponseCoroutine>d__15))]
	// RVA: 0x44A7A0 Offset: 0x4491A0 VA: 0x18044A7A0
	private static IEnumerator WaitForResponseCoroutine(AsyncWebRequestData requestData, Action<WebResponse> onResponseReturned) { }

	// RVA: 0x4498A0 Offset: 0x4482A0 VA: 0x1804498A0
	private static UnityWebRequest ConstructWebRequest(string uri, WebRequestMethod method, string contentType, byte[] data) { }

	// RVA: 0x449890 Offset: 0x448290 VA: 0x180449890
	private static UnityWebRequest ConstructWebRequest(string uri, WWWForm data) { }

	// RVA: 0x44A780 Offset: 0x449180 VA: 0x18044A780
	private static AsyncOperation SendWebRequest(UnityWebRequest request) { }

	// RVA: 0x449B20 Offset: 0x448520 VA: 0x180449B20
	private static string GetRequestMethodString(WebRequestMethod method) { }

	// RVA: 0x4497B0 Offset: 0x4481B0 VA: 0x1804497B0
	private static void CheckCertificateValidationCallback() { }

	// RVA: 0x44A590 Offset: 0x448F90 VA: 0x18044A590
	private static bool RemoteCertificateValidationCallback(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) { }
}

internal class AnalyticsWebRequest : UnityWebRequest, IWebRequest, IDisposable // TypeDefIndex: 17957
{
	// Properties
	public bool IsNetworkError { get; }

	// Methods

	// RVA: 0x2B87E50 Offset: 0x2B86850 VA: 0x182B87E50
	internal void .ctor(string url, string method) { }

	// RVA: 0x2B87E60 Offset: 0x2B86860 VA: 0x182B87E60 Slot: 9
	public bool get_IsNetworkError() { }

	// RVA: 0x2B87E10 Offset: 0x2B86810 VA: 0x182B87E10 Slot: 5
	private UnityWebRequestAsyncOperation Unity.Services.Analytics.Internal.IWebRequest.SendWebRequest() { }

	// RVA: 0x2B87E30 Offset: 0x2B86830 VA: 0x182B87E30 Slot: 6
	private UploadHandler Unity.Services.Analytics.Internal.IWebRequest.get_uploadHandler() { }

	// RVA: 0x2B87E40 Offset: 0x2B86840 VA: 0x182B87E40 Slot: 7
	private void Unity.Services.Analytics.Internal.IWebRequest.set_uploadHandler(UploadHandler value) { }

	// RVA: 0x2B87E20 Offset: 0x2B86820 VA: 0x182B87E20 Slot: 8
	private void Unity.Services.Analytics.Internal.IWebRequest.SetRequestHeader(string key, string value) { }
}

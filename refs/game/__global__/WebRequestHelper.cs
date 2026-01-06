internal class WebRequestHelper : IWebRequestHelper // TypeDefIndex: 17959
{
	// Fields
	private readonly string k_ClientIdHeaderValue; // 0x10

	// Methods

	// RVA: 0x2B96410 Offset: 0x2B94E10 VA: 0x182B96410 Slot: 4
	public IWebRequest CreateWebRequest(string url, string method, byte[] postBytes) { }

	// RVA: 0x2B96520 Offset: 0x2B94F20 VA: 0x182B96520 Slot: 5
	public void SendWebRequest(IWebRequest request, Action<long> onCompleted) { }

	// RVA: 0x2B96680 Offset: 0x2B95080 VA: 0x182B96680
	public void .ctor() { }
}

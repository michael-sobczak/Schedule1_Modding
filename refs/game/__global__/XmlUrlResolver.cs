public class XmlUrlResolver : XmlResolver // TypeDefIndex: 8125
{
	// Fields
	private static object s_DownloadManager; // 0x0
	private ICredentials _credentials; // 0x10
	private IWebProxy _proxy; // 0x18
	private RequestCachePolicy _cachePolicy; // 0x20

	// Properties
	private static XmlDownloadManager DownloadManager { get; }

	// Methods

	// RVA: 0x253E930 Offset: 0x253D330 VA: 0x18253E930
	private static XmlDownloadManager get_DownloadManager() { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }

	// RVA: 0x253E6C0 Offset: 0x253D0C0 VA: 0x18253E6C0 Slot: 4
	public override object GetEntity(Uri absoluteUri, string role, Type ofObjectToReturn) { }

	// RVA: 0x253E920 Offset: 0x253D320 VA: 0x18253E920 Slot: 5
	public override Uri ResolveUri(Uri baseUri, string relativeUri) { }

	[AsyncStateMachine(typeof(XmlUrlResolver.<GetEntityAsync>d__15))]
	// RVA: 0x253E570 Offset: 0x253CF70 VA: 0x18253E570 Slot: 7
	public override Task<object> GetEntityAsync(Uri absoluteUri, string role, Type ofObjectToReturn) { }
}

internal class XmlDownloadManager // TypeDefIndex: 8098
{
	// Fields
	private Hashtable connections; // 0x10

	// Methods

	// RVA: 0x2539AE0 Offset: 0x25384E0 VA: 0x182539AE0
	internal Stream GetStream(Uri uri, ICredentials credentials, IWebProxy proxy, RequestCachePolicy cachePolicy) { }

	// RVA: 0x25393F0 Offset: 0x2537DF0 VA: 0x1825393F0
	private Stream GetNonFileStream(Uri uri, ICredentials credentials, IWebProxy proxy, RequestCachePolicy cachePolicy) { }

	// RVA: 0x2539BF0 Offset: 0x25385F0 VA: 0x182539BF0
	internal void Remove(string host) { }

	// RVA: 0x2539870 Offset: 0x2538270 VA: 0x182539870
	internal Task<Stream> GetStreamAsync(Uri uri, ICredentials credentials, IWebProxy proxy, RequestCachePolicy cachePolicy) { }

	[AsyncStateMachine(typeof(XmlDownloadManager.<GetNonFileStreamAsync>d__5))]
	// RVA: 0x2539280 Offset: 0x2537C80 VA: 0x182539280
	private Task<Stream> GetNonFileStreamAsync(Uri uri, ICredentials credentials, IWebProxy proxy, RequestCachePolicy cachePolicy) { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }
}

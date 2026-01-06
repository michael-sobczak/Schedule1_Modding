internal class WebConnectionTunnel // TypeDefIndex: 10101
{
	// Fields
	[CompilerGenerated]
	private readonly HttpWebRequest <Request>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly Uri <ConnectUri>k__BackingField; // 0x18
	private HttpWebRequest connectRequest; // 0x20
	private WebConnectionTunnel.NtlmAuthState ntlmAuthState; // 0x28
	[CompilerGenerated]
	private bool <Success>k__BackingField; // 0x2C
	[CompilerGenerated]
	private bool <CloseConnection>k__BackingField; // 0x2D
	[CompilerGenerated]
	private int <StatusCode>k__BackingField; // 0x30
	[CompilerGenerated]
	private string <StatusDescription>k__BackingField; // 0x38
	[CompilerGenerated]
	private string[] <Challenge>k__BackingField; // 0x40
	[CompilerGenerated]
	private WebHeaderCollection <Headers>k__BackingField; // 0x48
	[CompilerGenerated]
	private Version <ProxyVersion>k__BackingField; // 0x50
	[CompilerGenerated]
	private byte[] <Data>k__BackingField; // 0x58

	// Properties
	public HttpWebRequest Request { get; }
	public Uri ConnectUri { get; }
	public bool Success { get; set; }
	public bool CloseConnection { get; set; }
	public int StatusCode { get; set; }
	private string StatusDescription { set; }
	public string[] Challenge { get; set; }
	public WebHeaderCollection Headers { get; set; }
	public Version ProxyVersion { get; set; }
	public byte[] Data { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	public HttpWebRequest get_Request() { }

	[CompilerGenerated]
	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	public Uri get_ConnectUri() { }

	// RVA: 0x5CC320 Offset: 0x5CAD20 VA: 0x1805CC320
	public void .ctor(HttpWebRequest request, Uri connectUri) { }

	[CompilerGenerated]
	// RVA: 0x1ECD6B0 Offset: 0x1ECC0B0 VA: 0x181ECD6B0
	public bool get_Success() { }

	[CompilerGenerated]
	// RVA: 0x1ECD6C0 Offset: 0x1ECC0C0 VA: 0x181ECD6C0
	private void set_Success(bool value) { }

	[CompilerGenerated]
	// RVA: 0x25D1600 Offset: 0x25D0000 VA: 0x1825D1600
	public bool get_CloseConnection() { }

	[CompilerGenerated]
	// RVA: 0x25D1610 Offset: 0x25D0010 VA: 0x1825D1610
	private void set_CloseConnection(bool value) { }

	[CompilerGenerated]
	// RVA: 0x4A7D90 Offset: 0x4A6790 VA: 0x1804A7D90
	public int get_StatusCode() { }

	[CompilerGenerated]
	// RVA: 0x54D060 Offset: 0x54BA60 VA: 0x18054D060
	private void set_StatusCode(int value) { }

	[CompilerGenerated]
	// RVA: 0x4513E0 Offset: 0x44FDE0 VA: 0x1804513E0
	private void set_StatusDescription(string value) { }

	[CompilerGenerated]
	// RVA: 0x4945F0 Offset: 0x492FF0 VA: 0x1804945F0
	public string[] get_Challenge() { }

	[CompilerGenerated]
	// RVA: 0x4D36A0 Offset: 0x4D20A0 VA: 0x1804D36A0
	private void set_Challenge(string[] value) { }

	[CompilerGenerated]
	// RVA: 0x4C1D80 Offset: 0x4C0780 VA: 0x1804C1D80
	public WebHeaderCollection get_Headers() { }

	[CompilerGenerated]
	// RVA: 0x5A9D30 Offset: 0x5A8730 VA: 0x1805A9D30
	private void set_Headers(WebHeaderCollection value) { }

	[CompilerGenerated]
	// RVA: 0x441BA0 Offset: 0x4405A0 VA: 0x180441BA0
	public Version get_ProxyVersion() { }

	[CompilerGenerated]
	// RVA: 0x4993D0 Offset: 0x497DD0 VA: 0x1804993D0
	private void set_ProxyVersion(Version value) { }

	[CompilerGenerated]
	// RVA: 0x4993C0 Offset: 0x497DC0 VA: 0x1804993C0
	public byte[] get_Data() { }

	[CompilerGenerated]
	// RVA: 0x4993E0 Offset: 0x497DE0 VA: 0x1804993E0
	private void set_Data(byte[] value) { }

	[AsyncStateMachine(typeof(WebConnectionTunnel.<Initialize>d__42))]
	// RVA: 0x25D1390 Offset: 0x25CFD90 VA: 0x1825D1390
	internal Task Initialize(Stream stream, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(WebConnectionTunnel.<ReadHeaders>d__43))]
	// RVA: 0x25D14B0 Offset: 0x25CFEB0 VA: 0x1825D14B0
	private Task<ValueTuple<WebHeaderCollection, byte[], int>> ReadHeaders(Stream stream, CancellationToken cancellationToken) { }

	// RVA: 0x25D1300 Offset: 0x25CFD00 VA: 0x1825D1300
	private void FlushContents(Stream stream, int contentLength) { }
}

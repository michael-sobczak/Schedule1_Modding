public class WebProxy : IWebProxy, ISerializable // TypeDefIndex: 10034
{
	// Fields
	private bool _UseRegistry; // 0x10
	private bool _BypassOnLocal; // 0x11
	private bool m_EnableAutoproxy; // 0x12
	private Uri _ProxyAddress; // 0x18
	private ArrayList _BypassList; // 0x20
	private ICredentials _Credentials; // 0x28
	private Regex[] _RegExBypassList; // 0x30
	private Hashtable _ProxyHostAddresses; // 0x38
	private AutoWebProxyScriptEngine m_ScriptEngine; // 0x40

	// Properties
	public ICredentials Credentials { get; }
	public bool UseDefaultCredentials { get; set; }
	internal AutoWebProxyScriptEngine ScriptEngine { get; }

	// Methods

	// RVA: 0x25BF860 Offset: 0x25BE260 VA: 0x1825BF860
	public void .ctor() { }

	// RVA: 0x25BF8D0 Offset: 0x25BE2D0 VA: 0x1825BF8D0
	public void .ctor(Uri Address, bool BypassOnLocal, string[] BypassList, ICredentials Credentials) { }

	// RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0 Slot: 6
	public ICredentials get_Credentials() { }

	// RVA: 0x25BFCF0 Offset: 0x25BE6F0 VA: 0x1825BFCF0
	public bool get_UseDefaultCredentials() { }

	// RVA: 0x25BFD60 Offset: 0x25BE760 VA: 0x1825BFD60
	public void set_UseDefaultCredentials(bool value) { }

	// RVA: 0x25BEBB0 Offset: 0x25BD5B0 VA: 0x1825BEBB0 Slot: 4
	public Uri GetProxy(Uri destination) { }

	// RVA: 0x25BF640 Offset: 0x25BE040 VA: 0x1825BF640
	private void UpdateRegExList(bool canThrow) { }

	// RVA: 0x25BF420 Offset: 0x25BDE20 VA: 0x1825BF420
	private bool IsMatchInBypassList(Uri input) { }

	// RVA: 0x25BF2A0 Offset: 0x25BDCA0 VA: 0x1825BF2A0
	private bool IsLocal(Uri host) { }

	// RVA: 0x25BF1B0 Offset: 0x25BDBB0 VA: 0x1825BF1B0
	private bool IsLocalInProxyHash(Uri host) { }

	// RVA: 0x25BF0C0 Offset: 0x25BDAC0 VA: 0x1825BF0C0 Slot: 5
	public bool IsBypassed(Uri host) { }

	// RVA: 0x25BEDF0 Offset: 0x25BD7F0 VA: 0x1825BEDF0
	private bool IsBypassedManual(Uri host) { }

	// RVA: 0x25BF9A0 Offset: 0x25BE3A0 VA: 0x1825BF9A0
	protected void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x25B2710 Offset: 0x25B1110 VA: 0x1825B2710 Slot: 7
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x25BE9E0 Offset: 0x25BD3E0 VA: 0x1825BE9E0 Slot: 8
	protected virtual void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x4945F0 Offset: 0x492FF0 VA: 0x1804945F0
	internal AutoWebProxyScriptEngine get_ScriptEngine() { }

	// RVA: 0x25BE990 Offset: 0x25BD390 VA: 0x1825BE990
	public static IWebProxy CreateDefaultProxy() { }

	// RVA: 0x25BF830 Offset: 0x25BE230 VA: 0x1825BF830
	internal void .ctor(bool enableAutoproxy) { }

	// RVA: 0x50C890 Offset: 0x50B290 VA: 0x18050C890
	internal void UnsafeUpdateFromRegistry() { }

	// RVA: 0x25BEB30 Offset: 0x25BD530 VA: 0x1825BEB30
	private bool GetProxyAuto(Uri destination, out Uri proxyUri) { }

	// RVA: 0x25BED90 Offset: 0x25BD790 VA: 0x1825BED90
	private bool IsBypassedAuto(Uri destination, out bool isBypassed) { }

	// RVA: 0x25BE820 Offset: 0x25BD220 VA: 0x1825BE820
	private static bool AreAllBypassed(IEnumerable<string> proxies, bool checkFirstOnly) { }

	// RVA: 0x25BF5B0 Offset: 0x25BDFB0 VA: 0x1825BF5B0
	private static Uri ProxyUri(string proxyName) { }
}

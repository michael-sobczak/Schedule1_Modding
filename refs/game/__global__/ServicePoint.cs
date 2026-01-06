public class ServicePoint // TypeDefIndex: 10077
{
	// Fields
	private readonly Uri uri; // 0x10
	private DateTime lastDnsResolve; // 0x18
	private Version protocolVersion; // 0x20
	private IPHostEntry host; // 0x28
	private bool usesProxy; // 0x30
	private bool sendContinue; // 0x31
	private bool useConnect; // 0x32
	private object hostE; // 0x38
	private bool useNagle; // 0x40
	private BindIPEndPoint endPointCallback; // 0x48
	private bool tcp_keepalive; // 0x50
	private int tcp_keepalive_time; // 0x54
	private int tcp_keepalive_interval; // 0x58
	private bool disposed; // 0x5C
	private int connectionLeaseTimeout; // 0x60
	private int receiveBufferSize; // 0x64
	[CompilerGenerated]
	private readonly ServicePointManager.SPKey <Key>k__BackingField; // 0x68
	[CompilerGenerated]
	private ServicePointScheduler <Scheduler>k__BackingField; // 0x70
	private int connectionLimit; // 0x78
	private int maxIdleTime; // 0x7C
	private object m_ServerCertificateOrBytes; // 0x80
	private object m_ClientCertificateOrBytes; // 0x88

	// Properties
	internal ServicePointManager.SPKey Key { get; }
	private ServicePointScheduler Scheduler { get; set; }
	public Uri Address { get; }
	public int ConnectionLimit { get; }
	public virtual Version ProtocolVersion { get; }
	public bool Expect100Continue { set; }
	public bool UseNagleAlgorithm { get; set; }
	internal bool SendContinue { get; set; }
	internal bool UsesProxy { get; set; }
	internal bool UseConnect { get; set; }
	private bool HasTimedOut { get; }
	internal IPHostEntry HostEntry { get; }

	// Methods

	// RVA: 0x25C4790 Offset: 0x25C3190 VA: 0x1825C4790
	internal void .ctor(ServicePointManager.SPKey key, Uri uri, int connectionLimit, int maxIdleTime) { }

	[CompilerGenerated]
	// RVA: 0x4663D0 Offset: 0x464DD0 VA: 0x1804663D0
	internal ServicePointManager.SPKey get_Key() { }

	[CompilerGenerated]
	// RVA: 0x4663C0 Offset: 0x464DC0 VA: 0x1804663C0
	private ServicePointScheduler get_Scheduler() { }

	[CompilerGenerated]
	// RVA: 0x5F4EE0 Offset: 0x5F38E0 VA: 0x1805F4EE0
	private void set_Scheduler(ServicePointScheduler value) { }

	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	public Uri get_Address() { }

	// RVA: 0x553640 Offset: 0x552040 VA: 0x180553640
	public int get_ConnectionLimit() { }

	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0 Slot: 4
	public virtual Version get_ProtocolVersion() { }

	// RVA: 0x50AAE0 Offset: 0x5094E0 VA: 0x18050AAE0
	public void set_Expect100Continue(bool value) { }

	// RVA: 0x4988A0 Offset: 0x4972A0 VA: 0x1804988A0
	public bool get_UseNagleAlgorithm() { }

	// RVA: 0x498920 Offset: 0x497320 VA: 0x180498920
	public void set_UseNagleAlgorithm(bool value) { }

	// RVA: 0x25C4E20 Offset: 0x25C3820 VA: 0x1825C4E20
	internal bool get_SendContinue() { }

	// RVA: 0x50AAE0 Offset: 0x5094E0 VA: 0x18050AAE0
	internal void set_SendContinue(bool value) { }

	// RVA: 0x25C4600 Offset: 0x25C3000 VA: 0x1825C4600
	public void SetTcpKeepAlive(bool enabled, int keepAliveTime, int keepAliveInterval) { }

	// RVA: 0x25C4300 Offset: 0x25C2D00 VA: 0x1825C4300
	internal void KeepAliveSetup(Socket socket) { }

	// RVA: 0x25C4450 Offset: 0x25C2E50 VA: 0x1825C4450
	private static void PutBytes(byte[] bytes, uint v, int offset) { }

	// RVA: 0x498810 Offset: 0x497210 VA: 0x180498810
	internal bool get_UsesProxy() { }

	// RVA: 0x4CEB50 Offset: 0x4CD550 VA: 0x1804CEB50
	internal void set_UsesProxy(bool value) { }

	// RVA: 0x231C2D0 Offset: 0x231ACD0 VA: 0x18231C2D0
	internal bool get_UseConnect() { }

	// RVA: 0x231C770 Offset: 0x231B170 VA: 0x18231C770
	internal void set_UseConnect(bool value) { }

	// RVA: 0x25C48A0 Offset: 0x25C32A0 VA: 0x1825C48A0
	private bool get_HasTimedOut() { }

	// RVA: 0x25C49C0 Offset: 0x25C33C0 VA: 0x1825C49C0
	internal IPHostEntry get_HostEntry() { }

	// RVA: 0x43EFF0 Offset: 0x43D9F0 VA: 0x18043EFF0
	internal void SetVersion(Version version) { }

	// RVA: 0x25C44C0 Offset: 0x25C2EC0 VA: 0x1825C44C0
	internal void SendRequest(WebOperation operation, string groupName) { }

	// RVA: 0x25C4110 Offset: 0x25C2B10 VA: 0x1825C4110
	public bool CloseConnectionGroup(string connectionGroupName) { }

	// RVA: 0x25C42E0 Offset: 0x25C2CE0 VA: 0x1825C42E0
	internal void FreeServicePoint() { }

	// RVA: 0x25C4740 Offset: 0x25C3140 VA: 0x1825C4740
	internal void UpdateServerCertificate(X509Certificate certificate) { }

	// RVA: 0x25C46F0 Offset: 0x25C30F0 VA: 0x1825C46F0
	internal void UpdateClientCertificate(X509Certificate certificate) { }

	// RVA: 0x25C4030 Offset: 0x25C2A30 VA: 0x1825C4030
	internal bool CallEndPointDelegate(Socket sock, IPEndPoint remote) { }
}

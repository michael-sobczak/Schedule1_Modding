internal class WebConnection : IDisposable // TypeDefIndex: 10096
{
	// Fields
	private NetworkCredential ntlm_credentials; // 0x10
	private bool ntlm_authenticated; // 0x18
	private bool unsafe_sharing; // 0x19
	private Stream networkStream; // 0x20
	private Socket socket; // 0x28
	private MonoTlsStream monoTlsStream; // 0x30
	private WebConnectionTunnel tunnel; // 0x38
	private int disposed; // 0x40
	[CompilerGenerated]
	private readonly ServicePoint <ServicePoint>k__BackingField; // 0x48
	private DateTime idleSince; // 0x50
	private WebOperation currentOperation; // 0x58

	// Properties
	public ServicePoint ServicePoint { get; }
	public bool Closed { get; }
	public DateTime IdleSince { get; }
	internal bool NtlmAuthenticated { get; set; }
	internal NetworkCredential NtlmCredential { get; set; }
	internal bool UnsafeAuthenticatedConnectionSharing { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4C1D80 Offset: 0x4C0780 VA: 0x1804C1D80
	public ServicePoint get_ServicePoint() { }

	// RVA: 0x17B1A60 Offset: 0x17B0460 VA: 0x1817B1A60
	public void .ctor(ServicePoint sPoint) { }

	// RVA: 0x25D1980 Offset: 0x25D0380 VA: 0x1825D1980
	private bool CanReuse() { }

	// RVA: 0x25D19B0 Offset: 0x25D03B0 VA: 0x1825D19B0
	private bool CheckReusable() { }

	[AsyncStateMachine(typeof(WebConnection.<Connect>d__16))]
	// RVA: 0x25D1C00 Offset: 0x25D0600 VA: 0x1825D1C00
	private Task Connect(WebOperation operation, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(WebConnection.<CreateStream>d__18))]
	// RVA: 0x25D1E80 Offset: 0x25D0880 VA: 0x1825D1E80
	private Task<bool> CreateStream(WebOperation operation, bool reused, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(WebConnection.<InitConnection>d__19))]
	// RVA: 0x25D2180 Offset: 0x25D0B80 VA: 0x1825D2180
	internal Task<WebRequestStream> InitConnection(WebOperation operation, CancellationToken cancellationToken) { }

	// RVA: 0x25D2010 Offset: 0x25D0A10 VA: 0x1825D2010
	internal static WebException GetException(WebExceptionStatus status, Exception error) { }

	// RVA: 0x25D2520 Offset: 0x25D0F20 VA: 0x1825D2520
	internal static bool ReadLine(byte[] buffer, ref int start, int max, ref string output) { }

	// RVA: 0x25D1620 Offset: 0x25D0020 VA: 0x1825D1620
	internal bool CanReuseConnection(WebOperation operation) { }

	// RVA: 0x25D22D0 Offset: 0x25D0CD0 VA: 0x1825D22D0
	private bool PrepareSharingNtlm(WebOperation operation) { }

	// RVA: 0x25D2740 Offset: 0x25D1140 VA: 0x1825D2740
	private void Reset() { }

	// RVA: 0x25D1B60 Offset: 0x25D0560 VA: 0x1825D1B60
	private void Close(bool reset) { }

	// RVA: 0x25D1A00 Offset: 0x25D0400 VA: 0x1825D1A00
	private void CloseSocket() { }

	// RVA: 0x25D29D0 Offset: 0x25D13D0 VA: 0x1825D29D0
	public bool get_Closed() { }

	// RVA: 0x441BA0 Offset: 0x4405A0 VA: 0x180441BA0
	public DateTime get_IdleSince() { }

	// RVA: 0x25D27F0 Offset: 0x25D11F0 VA: 0x1825D27F0
	public bool StartOperation(WebOperation operation, bool reused) { }

	// RVA: 0x25D1D20 Offset: 0x25D0720 VA: 0x1825D1D20
	public bool Continue(WebOperation next) { }

	// RVA: 0x25D1FD0 Offset: 0x25D09D0 VA: 0x1825D1FD0
	private void Dispose(bool disposing) { }

	// RVA: 0x25D1FD0 Offset: 0x25D09D0 VA: 0x1825D1FD0 Slot: 4
	public void Dispose() { }

	// RVA: 0x25D2710 Offset: 0x25D1110 VA: 0x1825D2710
	private void ResetNtlm() { }

	// RVA: 0x4971B0 Offset: 0x495BB0 VA: 0x1804971B0
	internal bool get_NtlmAuthenticated() { }

	// RVA: 0x698000 Offset: 0x696A00 VA: 0x180698000
	internal void set_NtlmAuthenticated(bool value) { }

	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	internal NetworkCredential get_NtlmCredential() { }

	// RVA: 0x49CBB0 Offset: 0x49B5B0 VA: 0x18049CBB0
	internal void set_NtlmCredential(NetworkCredential value) { }

	// RVA: 0xCD85E0 Offset: 0xCD6FE0 VA: 0x180CD85E0
	internal bool get_UnsafeAuthenticatedConnectionSharing() { }

	// RVA: 0xCD85F0 Offset: 0xCD6FF0 VA: 0x180CD85F0
	internal void set_UnsafeAuthenticatedConnectionSharing(bool value) { }
}

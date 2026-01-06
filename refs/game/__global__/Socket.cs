public class Socket : IDisposable // TypeDefIndex: 10190
{
	// Fields
	private static readonly EventHandler<SocketAsyncEventArgs> AcceptCompletedHandler; // 0x0
	private static readonly EventHandler<SocketAsyncEventArgs> ReceiveCompletedHandler; // 0x8
	private static readonly EventHandler<SocketAsyncEventArgs> SendCompletedHandler; // 0x10
	private static readonly Socket.TaskSocketAsyncEventArgs<Socket> s_rentedSocketSentinel; // 0x18
	private static readonly Socket.Int32TaskSocketAsyncEventArgs s_rentedInt32Sentinel; // 0x20
	private static readonly Task<int> s_zeroTask; // 0x28
	private Socket.CachedEventArgs _cachedTaskEventArgs; // 0x10
	private static object s_InternalSyncObject; // 0x30
	internal static bool s_SupportsIPv4; // 0x38
	internal static bool s_SupportsIPv6; // 0x39
	internal static bool s_OSSupportsIPv6; // 0x3A
	internal static bool s_Initialized; // 0x3B
	private static bool s_LoggingEnabled; // 0x3C
	internal static bool s_PerfCountersEnabled; // 0x3D
	internal const int DefaultCloseTimeout = -1;
	private const int SOCKET_CLOSED_CODE = 10004;
	private const string TIMEOUT_EXCEPTION_MSG = "A connection attempt failed because the connected party did not properly respondafter a period of time, or established connection failed because connected host has failed to respond";
	private bool is_closed; // 0x18
	private bool is_listening; // 0x19
	private bool useOverlappedIO; // 0x1A
	private int linger_timeout; // 0x1C
	private AddressFamily addressFamily; // 0x20
	private SocketType socketType; // 0x24
	private ProtocolType protocolType; // 0x28
	internal SafeSocketHandle m_Handle; // 0x30
	internal EndPoint seed_endpoint; // 0x38
	internal SemaphoreSlim ReadSem; // 0x40
	internal SemaphoreSlim WriteSem; // 0x48
	internal bool is_blocking; // 0x50
	internal bool is_bound; // 0x51
	internal bool is_connected; // 0x52
	private int m_IntCleanedUp; // 0x54
	internal bool connect_in_progress; // 0x58
	internal readonly int ID; // 0x5C
	private static AsyncCallback AcceptAsyncCallback; // 0x40
	private static IOAsyncCallback BeginAcceptCallback; // 0x48
	private static IOAsyncCallback BeginAcceptReceiveCallback; // 0x50
	private static AsyncCallback ConnectAsyncCallback; // 0x58
	private static IOAsyncCallback BeginConnectCallback; // 0x60
	private static AsyncCallback DisconnectAsyncCallback; // 0x68
	private static IOAsyncCallback BeginDisconnectCallback; // 0x70
	private static AsyncCallback ReceiveAsyncCallback; // 0x78
	private static IOAsyncCallback BeginReceiveCallback; // 0x80
	private static IOAsyncCallback BeginReceiveGenericCallback; // 0x88
	private static AsyncCallback ReceiveFromAsyncCallback; // 0x90
	private static IOAsyncCallback BeginReceiveFromCallback; // 0x98
	private static AsyncCallback SendAsyncCallback; // 0xA0
	private static IOAsyncCallback BeginSendGenericCallback; // 0xA8
	private static AsyncCallback SendToAsyncCallback; // 0xB0

	// Properties
	public static bool OSSupportsIPv4 { get; }
	public static bool OSSupportsIPv6 { get; }
	public IntPtr Handle { get; }
	public AddressFamily AddressFamily { get; }
	public SocketType SocketType { get; }
	public ProtocolType ProtocolType { get; }
	public bool ExclusiveAddressUse { set; }
	public int ReceiveBufferSize { set; }
	public int SendBufferSize { set; }
	public int ReceiveTimeout { set; }
	public int SendTimeout { set; }
	public short Ttl { get; set; }
	public bool DontFragment { set; }
	public bool DualMode { get; set; }
	private bool IsDualMode { get; }
	private static object InternalSyncObject { get; }
	internal bool CleanedUp { get; }
	public int Available { get; }
	public bool EnableBroadcast { set; }
	public bool IsBound { get; }
	public EndPoint LocalEndPoint { get; }
	public bool Blocking { get; set; }
	public bool Connected { get; }
	public bool NoDelay { set; }
	public EndPoint RemoteEndPoint { get; }
	internal static int FamilyHint { get; }

	// Methods

	// RVA: 0x25E8D00 Offset: 0x25E7700 VA: 0x1825E8D00
	internal ValueTask<int> ReceiveAsync(Memory<byte> buffer, SocketFlags socketFlags, bool fromNetworkStream, CancellationToken cancellationToken) { }

	// RVA: 0x25E88C0 Offset: 0x25E72C0 VA: 0x1825E88C0
	private Task<int> ReceiveAsyncApm(Memory<byte> buffer, SocketFlags socketFlags) { }

	// RVA: 0x25EB3F0 Offset: 0x25E9DF0 VA: 0x1825EB3F0
	internal ValueTask SendAsyncForNetworkStream(ReadOnlyMemory<byte> buffer, SocketFlags socketFlags, CancellationToken cancellationToken) { }

	// RVA: 0x25EAF90 Offset: 0x25E9990 VA: 0x1825EAF90
	private Task<int> SendAsyncApm(ReadOnlyMemory<byte> buffer, SocketFlags socketFlags) { }

	// RVA: 0x25E5840 Offset: 0x25E4240 VA: 0x1825E5840
	private static void CompleteAccept(Socket s, Socket.TaskSocketAsyncEventArgs<Socket> saea) { }

	// RVA: 0x25E5A30 Offset: 0x25E4430 VA: 0x1825E5A30
	private static void CompleteSendReceive(Socket s, Socket.Int32TaskSocketAsyncEventArgs saea, bool isReceive) { }

	// RVA: 0x25E6F60 Offset: 0x25E5960 VA: 0x1825E6F60
	private static Exception GetException(SocketError error, bool wrapExceptionsInIOExceptions = False) { }

	// RVA: 0x25EAF00 Offset: 0x25E9900 VA: 0x1825EAF00
	private void ReturnSocketAsyncEventArgs(Socket.Int32TaskSocketAsyncEventArgs saea, bool isReceive) { }

	// RVA: 0x25EAE90 Offset: 0x25E9890 VA: 0x1825EAE90
	private void ReturnSocketAsyncEventArgs(Socket.TaskSocketAsyncEventArgs<Socket> saea) { }

	// RVA: 0x25EE460 Offset: 0x25ECE60 VA: 0x1825EE460
	public void .ctor(AddressFamily addressFamily, SocketType socketType, ProtocolType protocolType) { }

	// RVA: 0x25EEE40 Offset: 0x25ED840 VA: 0x1825EEE40
	public static bool get_OSSupportsIPv4() { }

	// RVA: 0x25EEEA0 Offset: 0x25ED8A0 VA: 0x1825EEEA0
	public static bool get_OSSupportsIPv6() { }

	// RVA: 0x24FAD10 Offset: 0x24F9710 VA: 0x1824FAD10
	public IntPtr get_Handle() { }

	// RVA: 0x494440 Offset: 0x492E40 VA: 0x180494440
	public AddressFamily get_AddressFamily() { }

	// RVA: 0x49CD40 Offset: 0x49B740 VA: 0x18049CD40
	public SocketType get_SocketType() { }

	// RVA: 0x494430 Offset: 0x492E30 VA: 0x180494430
	public ProtocolType get_ProtocolType() { }

	// RVA: 0x25EF3C0 Offset: 0x25EDDC0 VA: 0x1825EF3C0
	public void set_ExclusiveAddressUse(bool value) { }

	// RVA: 0x25EF4F0 Offset: 0x25EDEF0 VA: 0x1825EF4F0
	public void set_ReceiveBufferSize(int value) { }

	// RVA: 0x25EF600 Offset: 0x25EE000 VA: 0x1825EF600
	public void set_SendBufferSize(int value) { }

	// RVA: 0x25EF570 Offset: 0x25EDF70 VA: 0x1825EF570
	public void set_ReceiveTimeout(int value) { }

	// RVA: 0x25EF680 Offset: 0x25EE080 VA: 0x1825EF680
	public void set_SendTimeout(int value) { }

	// RVA: 0x25EF000 Offset: 0x25EDA00 VA: 0x1825EF000
	public short get_Ttl() { }

	// RVA: 0x25EF710 Offset: 0x25EE110 VA: 0x1825EF710
	public void set_Ttl(short value) { }

	// RVA: 0x25EF1F0 Offset: 0x25EDBF0 VA: 0x1825EF1F0
	public void set_DontFragment(bool value) { }

	// RVA: 0x25EE950 Offset: 0x25ED350 VA: 0x1825EE950
	public bool get_DualMode() { }

	// RVA: 0x25EF290 Offset: 0x25EDC90 VA: 0x1825EF290
	public void set_DualMode(bool value) { }

	// RVA: 0x25EEC50 Offset: 0x25ED650 VA: 0x1825EEC50
	private bool get_IsDualMode() { }

	// RVA: 0x25E5730 Offset: 0x25E4130 VA: 0x1825E5730
	internal bool CanTryAddressFamily(AddressFamily family) { }

	// RVA: 0x25EC4A0 Offset: 0x25EAEA0 VA: 0x1825EC4A0
	public int Send(byte[] buffer) { }

	// RVA: 0x25EC430 Offset: 0x25EAE30 VA: 0x1825EC430
	public int Send(IList<ArraySegment<byte>> buffers, SocketFlags socketFlags) { }

	// RVA: 0x25ECD40 Offset: 0x25EB740 VA: 0x1825ECD40
	public int Send(byte[] buffer, int offset, int size, SocketFlags socketFlags) { }

	// RVA: 0x25EA2B0 Offset: 0x25E8CB0 VA: 0x1825EA2B0
	public int Receive(byte[] buffer, int offset, int size, SocketFlags socketFlags) { }

	// RVA: 0x25EAC20 Offset: 0x25E9620 VA: 0x1825EAC20
	public int Receive(IList<ArraySegment<byte>> buffers, SocketFlags socketFlags) { }

	// RVA: 0x25E7510 Offset: 0x25E5F10 VA: 0x1825E7510
	public int IOControl(IOControlCode ioControlCode, byte[] optionInValue, byte[] optionOutValue) { }

	// RVA: 0x25ECDC0 Offset: 0x25EB7C0 VA: 0x1825ECDC0
	public void SetIPProtectionLevel(IPProtectionLevel level) { }

	// RVA: 0x25E52A0 Offset: 0x25E3CA0 VA: 0x1825E52A0
	public IAsyncResult BeginSend(byte[] buffer, int offset, int size, SocketFlags socketFlags, AsyncCallback callback, object state) { }

	// RVA: 0x25E6E40 Offset: 0x25E5840 VA: 0x1825E6E40
	public int EndSend(IAsyncResult asyncResult) { }

	// RVA: 0x25E4670 Offset: 0x25E3070 VA: 0x1825E4670
	public IAsyncResult BeginReceive(byte[] buffer, int offset, int size, SocketFlags socketFlags, AsyncCallback callback, object state) { }

	// RVA: 0x25E6B70 Offset: 0x25E5570 VA: 0x1825E6B70
	public int EndReceive(IAsyncResult asyncResult) { }

	// RVA: 0x25EEB60 Offset: 0x25ED560 VA: 0x1825EEB60
	private static object get_InternalSyncObject() { }

	// RVA: 0xAEB450 Offset: 0xAE9E50 VA: 0x180AEB450
	internal bool get_CleanedUp() { }

	// RVA: 0x25E7B90 Offset: 0x25E6590 VA: 0x1825E7B90
	internal static void InitializeSockets() { }

	// RVA: 0x25E65A0 Offset: 0x25E4FA0 VA: 0x1825E65A0 Slot: 4
	public void Dispose() { }

	// RVA: 0x4D8670 Offset: 0x4D7070 VA: 0x1804D8670 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x25E7ED0 Offset: 0x25E68D0 VA: 0x1825E7ED0
	internal void InternalShutdown(SocketShutdown how) { }

	// RVA: 0x25ED190 Offset: 0x25EBB90 VA: 0x1825ED190
	internal void SetSocketOption(SocketOptionLevel optionLevel, SocketOptionName optionName, int optionValue, bool silent) { }

	// RVA: 0x25EE760 Offset: 0x25ED160 VA: 0x1825EE760
	internal void .ctor(AddressFamily family, SocketType type, ProtocolType proto, SafeSocketHandle safe_handle) { }

	// RVA: 0x25ED440 Offset: 0x25EBE40 VA: 0x1825ED440
	private void SocketDefaults() { }

	// RVA: 0x25ED640 Offset: 0x25EC040 VA: 0x1825ED640
	private static IntPtr Socket_icall(AddressFamily family, SocketType type, ProtocolType proto, out int error) { }

	// RVA: 0x25EE890 Offset: 0x25ED290 VA: 0x1825EE890
	public int get_Available() { }

	// RVA: 0x25E3B70 Offset: 0x25E2570 VA: 0x1825E3B70
	private static int Available_internal(SafeSocketHandle safeHandle, out int error) { }

	// RVA: 0x25E3B60 Offset: 0x25E2560 VA: 0x1825E3B60
	private static int Available_icall(IntPtr socket, out int error) { }

	// RVA: 0x25EF330 Offset: 0x25EDD30 VA: 0x1825EF330
	public void set_EnableBroadcast(bool value) { }

	// RVA: 0x50A750 Offset: 0x509150 VA: 0x18050A750
	public bool get_IsBound() { }

	// RVA: 0x25EED40 Offset: 0x25ED740 VA: 0x1825EED40
	public EndPoint get_LocalEndPoint() { }

	// RVA: 0x25E8350 Offset: 0x25E6D50 VA: 0x1825E8350
	private static SocketAddress LocalEndPoint_internal(SafeSocketHandle safeHandle, int family, out int error) { }

	// RVA: 0x25E8340 Offset: 0x25E6D40 VA: 0x1825E8340
	private static SocketAddress LocalEndPoint_icall(IntPtr socket, int family, out int error) { }

	// RVA: 0x49CAE0 Offset: 0x49B4E0 VA: 0x18049CAE0
	public bool get_Blocking() { }

	// RVA: 0x25EF120 Offset: 0x25EDB20 VA: 0x1825EF120
	public void set_Blocking(bool value) { }

	// RVA: 0x25E5620 Offset: 0x25E4020 VA: 0x1825E5620
	private static void Blocking_internal(SafeSocketHandle safeHandle, bool block, out int error) { }

	// RVA: 0x25E5610 Offset: 0x25E4010 VA: 0x1825E5610
	internal static void Blocking_icall(IntPtr socket, bool block, out int error) { }

	// RVA: 0x605160 Offset: 0x603B60 VA: 0x180605160
	public bool get_Connected() { }

	// RVA: 0x25EF460 Offset: 0x25EDE60 VA: 0x1825EF460
	public void set_NoDelay(bool value) { }

	// RVA: 0x25EEF00 Offset: 0x25ED900 VA: 0x1825EEF00
	public EndPoint get_RemoteEndPoint() { }

	// RVA: 0x25EAD60 Offset: 0x25E9760 VA: 0x1825EAD60
	private static SocketAddress RemoteEndPoint_internal(SafeSocketHandle safeHandle, int family, out int error) { }

	// RVA: 0x25EAD50 Offset: 0x25E9750 VA: 0x1825EAD50
	private static SocketAddress RemoteEndPoint_icall(IntPtr socket, int family, out int error) { }

	// RVA: 0x25E85D0 Offset: 0x25E6FD0 VA: 0x1825E85D0
	public bool Poll(int microSeconds, SelectMode mode) { }

	// RVA: 0x25E8490 Offset: 0x25E6E90 VA: 0x1825E8490
	private static bool Poll_internal(SafeSocketHandle safeHandle, SelectMode mode, int timeout, out int error) { }

	// RVA: 0x25E8480 Offset: 0x25E6E80 VA: 0x1825E8480
	private static bool Poll_icall(IntPtr socket, SelectMode mode, int timeout, out int error) { }

	// RVA: 0x25E38D0 Offset: 0x25E22D0 VA: 0x1825E38D0
	public Socket Accept() { }

	// RVA: 0x25E3A20 Offset: 0x25E2420 VA: 0x1825E3A20
	internal void Accept(Socket acceptSocket) { }

	// RVA: 0x25E3C80 Offset: 0x25E2680 VA: 0x1825E3C80
	public IAsyncResult BeginAccept(AsyncCallback callback, object state) { }

	// RVA: 0x25E6610 Offset: 0x25E5010 VA: 0x1825E6610
	public Socket EndAccept(IAsyncResult asyncResult) { }

	// RVA: 0x25E6700 Offset: 0x25E5100 VA: 0x1825E6700
	public Socket EndAccept(out byte[] buffer, out int bytesTransferred, IAsyncResult asyncResult) { }

	// RVA: 0x25E37A0 Offset: 0x25E21A0 VA: 0x1825E37A0
	private static SafeSocketHandle Accept_internal(SafeSocketHandle safeHandle, out int error, bool blocking) { }

	// RVA: 0x25E3790 Offset: 0x25E2190 VA: 0x1825E3790
	private static IntPtr Accept_icall(IntPtr sock, out int error, bool blocking) { }

	// RVA: 0x25E5460 Offset: 0x25E3E60 VA: 0x1825E5460
	public void Bind(EndPoint localEP) { }

	// RVA: 0x25E5350 Offset: 0x25E3D50 VA: 0x1825E5350
	private static void Bind_internal(SafeSocketHandle safeHandle, SocketAddress sa, out int error) { }

	// RVA: 0x25E5340 Offset: 0x25E3D40 VA: 0x1825E5340
	private static void Bind_icall(IntPtr sock, SocketAddress sa, out int error) { }

	// RVA: 0x25E8230 Offset: 0x25E6C30 VA: 0x1825E8230
	public void Listen(int backlog) { }

	// RVA: 0x25E8120 Offset: 0x25E6B20 VA: 0x1825E8120
	private static void Listen_internal(SafeSocketHandle safeHandle, int backlog, out int error) { }

	// RVA: 0x25E8110 Offset: 0x25E6B10 VA: 0x1825E8110
	private static void Listen_icall(IntPtr sock, int backlog, out int error) { }

	// RVA: 0x25E6120 Offset: 0x25E4B20 VA: 0x1825E6120
	public void Connect(IPAddress address, int port) { }

	// RVA: 0x25E5D10 Offset: 0x25E4710 VA: 0x1825E5D10
	public void Connect(EndPoint remoteEP) { }

	// RVA: 0x25E3FA0 Offset: 0x25E29A0 VA: 0x1825E3FA0
	public IAsyncResult BeginConnect(string host, int port, AsyncCallback callback, object state) { }

	// RVA: 0x25E3E20 Offset: 0x25E2820 VA: 0x1825E3E20
	public IAsyncResult BeginConnect(EndPoint remoteEP, AsyncCallback callback, object state) { }

	// RVA: 0x25E4280 Offset: 0x25E2C80 VA: 0x1825E4280
	private static bool BeginMConnect(SocketAsyncResult sockares) { }

	// RVA: 0x25E4710 Offset: 0x25E3110 VA: 0x1825E4710
	private static bool BeginSConnect(SocketAsyncResult sockares) { }

	// RVA: 0x25E6810 Offset: 0x25E5210 VA: 0x1825E6810
	public void EndConnect(IAsyncResult asyncResult) { }

	// RVA: 0x25E5C10 Offset: 0x25E4610 VA: 0x1825E5C10
	private static void Connect_internal(SafeSocketHandle safeHandle, SocketAddress sa, out int error, bool blocking) { }

	// RVA: 0x25E5C00 Offset: 0x25E4600 VA: 0x1825E5C00
	private static void Connect_icall(IntPtr sock, SocketAddress sa, out int error, bool blocking) { }

	// RVA: 0x25E62C0 Offset: 0x25E4CC0 VA: 0x1825E62C0
	public void Disconnect(bool reuseSocket) { }

	// RVA: 0x25E68D0 Offset: 0x25E52D0 VA: 0x1825E68D0
	public void EndDisconnect(IAsyncResult asyncResult) { }

	// RVA: 0x25E61B0 Offset: 0x25E4BB0 VA: 0x1825E61B0
	private static void Disconnect_internal(SafeSocketHandle safeHandle, bool reuse, out int error) { }

	// RVA: 0x25E61A0 Offset: 0x25E4BA0 VA: 0x1825E61A0
	private static void Disconnect_icall(IntPtr sock, bool reuse, out int error) { }

	// RVA: 0x25EAAB0 Offset: 0x25E94B0 VA: 0x1825EAAB0
	public int Receive(byte[] buffer, int offset, int size, SocketFlags socketFlags, out SocketError errorCode) { }

	// RVA: 0x25EA330 Offset: 0x25E8D30 VA: 0x1825EA330
	private int Receive(Memory<byte> buffer, int offset, int size, SocketFlags socketFlags, out SocketError errorCode) { }

	[CLSCompliant(False)]
	// RVA: 0x25EA540 Offset: 0x25E8F40 VA: 0x1825EA540
	public int Receive(IList<ArraySegment<byte>> buffers, SocketFlags socketFlags, out SocketError errorCode) { }

	// RVA: 0x25EA190 Offset: 0x25E8B90 VA: 0x1825EA190
	public int Receive(Span<byte> buffer, SocketFlags socketFlags, out SocketError errorCode) { }

	// RVA: 0x25EC540 Offset: 0x25EAF40 VA: 0x1825EC540
	public int Send(ReadOnlySpan<byte> buffer, SocketFlags socketFlags, out SocketError errorCode) { }

	// RVA: 0x25E91C0 Offset: 0x25E7BC0 VA: 0x1825E91C0
	public bool ReceiveAsync(SocketAsyncEventArgs e) { }

	// RVA: 0x25E4450 Offset: 0x25E2E50 VA: 0x1825E4450
	public IAsyncResult BeginReceive(byte[] buffer, int offset, int size, SocketFlags socketFlags, out SocketError errorCode, AsyncCallback callback, object state) { }

	// RVA: 0x25E6A80 Offset: 0x25E5480 VA: 0x1825E6A80
	public int EndReceive(IAsyncResult asyncResult, out SocketError errorCode) { }

	// RVA: 0x25EA060 Offset: 0x25E8A60 VA: 0x1825EA060
	private static int Receive_internal(SafeSocketHandle safeHandle, Socket.WSABUF* bufarray, int count, SocketFlags flags, out int error, bool blocking) { }

	// RVA: 0x25E9F10 Offset: 0x25E8910 VA: 0x1825E9F10
	private static int Receive_array_icall(IntPtr sock, Socket.WSABUF* bufarray, int count, SocketFlags flags, out int error, bool blocking) { }

	// RVA: 0x25E9F30 Offset: 0x25E8930 VA: 0x1825E9F30
	private static int Receive_internal(SafeSocketHandle safeHandle, byte* buffer, int count, SocketFlags flags, out int error, bool blocking) { }

	// RVA: 0x25E9F20 Offset: 0x25E8920 VA: 0x1825E9F20
	private static int Receive_icall(IntPtr sock, byte* buffer, int count, SocketFlags flags, out int error, bool blocking) { }

	// RVA: 0x25E9AD0 Offset: 0x25E84D0 VA: 0x1825E9AD0
	public int ReceiveFrom(byte[] buffer, int offset, int size, SocketFlags socketFlags, ref EndPoint remoteEP) { }

	// RVA: 0x25E9D70 Offset: 0x25E8770 VA: 0x1825E9D70
	internal int ReceiveFrom(byte[] buffer, int offset, int size, SocketFlags socketFlags, ref EndPoint remoteEP, out SocketError errorCode) { }

	// RVA: 0x25E9810 Offset: 0x25E8210 VA: 0x1825E9810
	private int ReceiveFrom(Memory<byte> buffer, int offset, int size, SocketFlags socketFlags, ref EndPoint remoteEP, out SocketError errorCode) { }

	// RVA: 0x25E6990 Offset: 0x25E5390 VA: 0x1825E6990
	private int EndReceiveFrom_internal(SocketAsyncResult sockares, SocketAsyncEventArgs ares) { }

	// RVA: 0x25E96D0 Offset: 0x25E80D0 VA: 0x1825E96D0
	private static int ReceiveFrom_internal(SafeSocketHandle safeHandle, byte* buffer, int count, SocketFlags flags, ref SocketAddress sockaddr, out int error, bool blocking) { }

	// RVA: 0x25E96C0 Offset: 0x25E80C0 VA: 0x1825E96C0
	private static int ReceiveFrom_icall(IntPtr sock, byte* buffer, int count, SocketFlags flags, ref SocketAddress sockaddr, out int error, bool blocking) { }

	// RVA: 0x25ECB90 Offset: 0x25EB590 VA: 0x1825ECB90
	public int Send(byte[] buffer, int offset, int size, SocketFlags socketFlags, out SocketError errorCode) { }

	[CLSCompliant(False)]
	// RVA: 0x25EC5D0 Offset: 0x25EAFD0 VA: 0x1825EC5D0
	public int Send(IList<ArraySegment<byte>> buffers, SocketFlags socketFlags, out SocketError errorCode) { }

	// RVA: 0x25EB860 Offset: 0x25EA260 VA: 0x1825EB860
	public bool SendAsync(SocketAsyncEventArgs e) { }

	// RVA: 0x25E4FF0 Offset: 0x25E39F0 VA: 0x1825E4FF0
	public IAsyncResult BeginSend(byte[] buffer, int offset, int size, SocketFlags socketFlags, out SocketError errorCode, AsyncCallback callback, object state) { }

	// RVA: 0x25E4C80 Offset: 0x25E3680 VA: 0x1825E4C80
	private static void BeginSendCallback(SocketAsyncResult sockares, int sent_so_far) { }

	// RVA: 0x25E6D50 Offset: 0x25E5750 VA: 0x1825E6D50
	public int EndSend(IAsyncResult asyncResult, out SocketError errorCode) { }

	// RVA: 0x25EC300 Offset: 0x25EAD00 VA: 0x1825EC300
	private static int Send_internal(SafeSocketHandle safeHandle, Socket.WSABUF* bufarray, int count, SocketFlags flags, out int error, bool blocking) { }

	// RVA: 0x25EC1B0 Offset: 0x25EABB0 VA: 0x1825EC1B0
	private static int Send_array_icall(IntPtr sock, Socket.WSABUF* bufarray, int count, SocketFlags flags, out int error, bool blocking) { }

	// RVA: 0x25EC1D0 Offset: 0x25EABD0 VA: 0x1825EC1D0
	private static int Send_internal(SafeSocketHandle safeHandle, byte* buffer, int count, SocketFlags flags, out int error, bool blocking) { }

	// RVA: 0x25EC1C0 Offset: 0x25EABC0 VA: 0x1825EC1C0
	private static int Send_icall(IntPtr sock, byte* buffer, int count, SocketFlags flags, out int error, bool blocking) { }

	// RVA: 0x25EBF70 Offset: 0x25EA970 VA: 0x1825EBF70
	public int SendTo(byte[] buffer, int offset, int size, SocketFlags socketFlags, EndPoint remoteEP) { }

	// RVA: 0x25E6C90 Offset: 0x25E5690 VA: 0x1825E6C90
	public int EndSendTo(IAsyncResult asyncResult) { }

	// RVA: 0x25EBE30 Offset: 0x25EA830 VA: 0x1825EBE30
	private static int SendTo_internal(SafeSocketHandle safeHandle, byte* buffer, int count, SocketFlags flags, SocketAddress sa, out int error, bool blocking) { }

	// RVA: 0x25EBE20 Offset: 0x25EA820 VA: 0x1825EBE20
	private static int SendTo_icall(IntPtr sock, byte* buffer, int count, SocketFlags flags, SocketAddress sa, out int error, bool blocking) { }

	// RVA: 0x25E7050 Offset: 0x25E5A50 VA: 0x1825E7050
	public object GetSocketOption(SocketOptionLevel optionLevel, SocketOptionName optionName) { }

	// RVA: 0x25E7280 Offset: 0x25E5C80 VA: 0x1825E7280
	private static void GetSocketOption_obj_internal(SafeSocketHandle safeHandle, SocketOptionLevel level, SocketOptionName name, out object obj_val, out int error) { }

	// RVA: 0x25E7270 Offset: 0x25E5C70 VA: 0x1825E7270
	private static void GetSocketOption_obj_icall(IntPtr socket, SocketOptionLevel level, SocketOptionName name, out object obj_val, out int error) { }

	// RVA: 0x25ED300 Offset: 0x25EBD00 VA: 0x1825ED300
	public void SetSocketOption(SocketOptionLevel optionLevel, SocketOptionName optionName, bool optionValue) { }

	// RVA: 0x25ED050 Offset: 0x25EBA50 VA: 0x1825ED050
	public void SetSocketOption(SocketOptionLevel optionLevel, SocketOptionName optionName, int optionValue) { }

	// RVA: 0x25ECEF0 Offset: 0x25EB8F0 VA: 0x1825ECEF0
	private static void SetSocketOption_internal(SafeSocketHandle safeHandle, SocketOptionLevel level, SocketOptionName name, object obj_val, byte[] byte_val, int int_val, out int error) { }

	// RVA: 0x25ECEE0 Offset: 0x25EB8E0 VA: 0x1825ECEE0
	private static void SetSocketOption_icall(IntPtr socket, SocketOptionLevel level, SocketOptionName name, object obj_val, byte[] byte_val, int int_val, out int error) { }

	// RVA: 0x25E76B0 Offset: 0x25E60B0 VA: 0x1825E76B0
	public int IOControl(int ioControlCode, byte[] optionInValue, byte[] optionOutValue) { }

	// RVA: 0x25E73D0 Offset: 0x25E5DD0 VA: 0x1825E73D0
	private static int IOControl_internal(SafeSocketHandle safeHandle, int ioctl_code, byte[] input, byte[] output, out int error) { }

	// RVA: 0x25E73C0 Offset: 0x25E5DC0 VA: 0x1825E73C0
	private static int IOControl_icall(IntPtr sock, int ioctl_code, byte[] input, byte[] output, out int error) { }

	// RVA: 0x25E5760 Offset: 0x25E4160 VA: 0x1825E5760
	public void Close() { }

	// RVA: 0x25E57D0 Offset: 0x25E41D0 VA: 0x1825E57D0
	public void Close(int timeout) { }

	// RVA: 0x25E5750 Offset: 0x25E4150 VA: 0x1825E5750
	internal static void Close_icall(IntPtr socket, out int error) { }

	// RVA: 0x25ED330 Offset: 0x25EBD30 VA: 0x1825ED330
	private static void Shutdown_internal(SafeSocketHandle safeHandle, SocketShutdown how, out int error) { }

	// RVA: 0x25ED320 Offset: 0x25EBD20 VA: 0x1825ED320
	internal static void Shutdown_icall(IntPtr socket, SocketShutdown how, out int error) { }

	// RVA: 0x25E63D0 Offset: 0x25E4DD0 VA: 0x1825E63D0 Slot: 5
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x25E7FA0 Offset: 0x25E69A0 VA: 0x1825E7FA0
	private void Linger(IntPtr handle) { }

	// RVA: 0x25ED870 Offset: 0x25EC270 VA: 0x1825ED870
	private void ThrowIfDisposedAndClosed() { }

	// RVA: 0x25ED650 Offset: 0x25EC050 VA: 0x1825ED650
	private void ThrowIfBufferNull(byte[] buffer) { }

	// RVA: 0x25ED6B0 Offset: 0x25EC0B0 VA: 0x1825ED6B0
	private void ThrowIfBufferOutOfRange(byte[] buffer, int offset, int size) { }

	// RVA: 0x25ED900 Offset: 0x25EC300 VA: 0x1825ED900
	private void ThrowIfUdp() { }

	// RVA: 0x25ED960 Offset: 0x25EC360 VA: 0x1825ED960
	private SocketAsyncResult ValidateEndIAsyncResult(IAsyncResult ares, string methodName, string argName) { }

	// RVA: 0x25E8770 Offset: 0x25E7170 VA: 0x1825E8770
	private void QueueIOSelectorJob(SemaphoreSlim sem, IntPtr handle, IOSelectorJob job) { }

	// RVA: 0x25E7850 Offset: 0x25E6250 VA: 0x1825E7850
	private void InitSocketAsyncEventArgs(SocketAsyncEventArgs e, AsyncCallback callback, object state, SocketOperation operation) { }

	// RVA: 0x25ED510 Offset: 0x25EBF10 VA: 0x1825ED510
	private SocketAsyncOperation SocketOperationToSocketAsyncOperation(SocketOperation op) { }

	// RVA: 0x25EAC90 Offset: 0x25E9690 VA: 0x1825EAC90
	private IPEndPoint RemapIPEndPoint(IPEndPoint input) { }

	// RVA: 0x25EE880 Offset: 0x25ED280 VA: 0x1825EE880
	internal static void cancel_blocking_socket_operation(Thread thread) { }

	// RVA: 0x25EEA30 Offset: 0x25ED430 VA: 0x1825EEA30
	internal static int get_FamilyHint() { }

	// RVA: 0x1B62050 Offset: 0x1B60A50 VA: 0x181B62050
	private static bool IsProtocolSupported_internal(NetworkInterfaceComponent networkInterface) { }

	// RVA: 0x25E7F50 Offset: 0x25E6950 VA: 0x1825E7F50
	private static bool IsProtocolSupported(NetworkInterfaceComponent networkInterface) { }

	// RVA: 0x25EDAD0 Offset: 0x25EC4D0 VA: 0x1825EDAD0
	private static void .cctor() { }
}

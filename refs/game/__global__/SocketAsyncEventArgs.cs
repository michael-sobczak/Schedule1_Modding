public class SocketAsyncEventArgs : EventArgs, IDisposable // TypeDefIndex: 10211
{
	// Fields
	private bool disposed; // 0x10
	internal int in_progress; // 0x14
	private EndPoint remote_ep; // 0x18
	private Socket current_socket; // 0x20
	internal SocketAsyncResult socket_async_result; // 0x28
	[CompilerGenerated]
	private Exception <ConnectByNameError>k__BackingField; // 0x30
	[CompilerGenerated]
	private Socket <AcceptSocket>k__BackingField; // 0x38
	[CompilerGenerated]
	private int <BytesTransferred>k__BackingField; // 0x40
	[CompilerGenerated]
	private bool <DisconnectReuseSocket>k__BackingField; // 0x44
	[CompilerGenerated]
	private SocketAsyncOperation <LastOperation>k__BackingField; // 0x48
	[CompilerGenerated]
	private IPPacketInformation <ReceiveMessageFromPacketInfo>k__BackingField; // 0x50
	[CompilerGenerated]
	private SendPacketsElement[] <SendPacketsElements>k__BackingField; // 0x60
	[CompilerGenerated]
	private TransmitFileOptions <SendPacketsFlags>k__BackingField; // 0x68
	[CompilerGenerated]
	private int <SendPacketsSendSize>k__BackingField; // 0x6C
	[CompilerGenerated]
	private SocketError <SocketError>k__BackingField; // 0x70
	[CompilerGenerated]
	private SocketFlags <SocketFlags>k__BackingField; // 0x74
	[CompilerGenerated]
	private object <UserToken>k__BackingField; // 0x78
	[CompilerGenerated]
	private EventHandler<SocketAsyncEventArgs> Completed; // 0x80
	private Memory<byte> _buffer; // 0x88
	private int _offset; // 0x98
	private int _count; // 0x9C
	private bool _bufferIsExplicitArray; // 0xA0
	private IList<ArraySegment<byte>> _bufferList; // 0xA8
	private List<ArraySegment<byte>> _bufferListInternal; // 0xB0

	// Properties
	public Socket AcceptSocket { get; set; }
	public int BytesTransferred { get; set; }
	private SocketAsyncOperation LastOperation { set; }
	public EndPoint RemoteEndPoint { set; }
	[MonoTODO("unused property")]
	public int SendPacketsSendSize { set; }
	public SocketError SocketError { get; set; }
	public SocketFlags SocketFlags { set; }
	public object UserToken { get; set; }
	internal Socket CurrentSocket { get; }
	public Memory<byte> MemoryBuffer { get; }
	public int Offset { get; }
	public int Count { get; }
	public IList<ArraySegment<byte>> BufferList { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4513B0 Offset: 0x44FDB0 VA: 0x1804513B0
	public Socket get_AcceptSocket() { }

	[CompilerGenerated]
	// RVA: 0x4513E0 Offset: 0x44FDE0 VA: 0x1804513E0
	public void set_AcceptSocket(Socket value) { }

	[CompilerGenerated]
	// RVA: 0x4B5E40 Offset: 0x4B4840 VA: 0x1804B5E40
	public int get_BytesTransferred() { }

	[CompilerGenerated]
	// RVA: 0x4E28B0 Offset: 0x4E12B0 VA: 0x1804E28B0
	private void set_BytesTransferred(int value) { }

	[CompilerGenerated]
	// RVA: 0x4E28C0 Offset: 0x4E12C0 VA: 0x1804E28C0
	private void set_LastOperation(SocketAsyncOperation value) { }

	// RVA: 0x43EFE0 Offset: 0x43D9E0 VA: 0x18043EFE0
	public void set_RemoteEndPoint(EndPoint value) { }

	[CompilerGenerated]
	// RVA: 0xA9F820 Offset: 0xA9E220 VA: 0x180A9F820
	public void set_SendPacketsSendSize(int value) { }

	[CompilerGenerated]
	// RVA: 0x501290 Offset: 0x4FFC90 VA: 0x180501290
	public SocketError get_SocketError() { }

	[CompilerGenerated]
	// RVA: 0xA9F800 Offset: 0xA9E200 VA: 0x180A9F800
	public void set_SocketError(SocketError value) { }

	[CompilerGenerated]
	// RVA: 0xA9F810 Offset: 0xA9E210 VA: 0x180A9F810
	public void set_SocketFlags(SocketFlags value) { }

	[CompilerGenerated]
	// RVA: 0x4CD210 Offset: 0x4CBC10 VA: 0x1804CD210
	public object get_UserToken() { }

	[CompilerGenerated]
	// RVA: 0x5F4EC0 Offset: 0x5F38C0 VA: 0x1805F4EC0
	public void set_UserToken(object value) { }

	// RVA: 0x25E2F20 Offset: 0x25E1920 VA: 0x1825E2F20
	public void .ctor() { }

	// RVA: 0x25E2FB0 Offset: 0x25E19B0 VA: 0x1825E2FB0
	internal void .ctor(bool flowExecutionContext) { }

	// RVA: 0x25E2CE0 Offset: 0x25E16E0 VA: 0x1825E2CE0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x25E2CD0 Offset: 0x25E16D0 VA: 0x1825E2CD0
	private void Dispose(bool disposing) { }

	// RVA: 0x25E2C70 Offset: 0x25E1670 VA: 0x1825E2C70 Slot: 4
	public void Dispose() { }

	// RVA: 0x4E28B0 Offset: 0x4E12B0 VA: 0x1804E28B0
	internal void SetBytesTransferred(int value) { }

	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	internal Socket get_CurrentSocket() { }

	// RVA: 0x43EFF0 Offset: 0x43D9F0 VA: 0x18043EFF0
	internal void SetCurrentSocket(Socket socket) { }

	// RVA: 0x25E2E50 Offset: 0x25E1850 VA: 0x1825E2E50
	internal void SetLastOperation(SocketAsyncOperation op) { }

	// RVA: 0x25E2C30 Offset: 0x25E1630 VA: 0x1825E2C30
	internal void Complete_internal() { }

	// RVA: 0x25E2D20 Offset: 0x25E1720 VA: 0x1825E2D20 Slot: 5
	protected virtual void OnCompleted(SocketAsyncEventArgs e) { }

	// RVA: 0x501580 Offset: 0x4FFF80 VA: 0x180501580
	public Memory<byte> get_MemoryBuffer() { }

	// RVA: 0x4B62D0 Offset: 0x4B4CD0 VA: 0x1804B62D0
	public int get_Offset() { }

	// RVA: 0x614470 Offset: 0x612E70 VA: 0x180614470
	public int get_Count() { }

	// RVA: 0x4B61A0 Offset: 0x4B4BA0 VA: 0x1804B61A0
	public IList<ArraySegment<byte>> get_BufferList() { }

	// RVA: 0x25E2D50 Offset: 0x25E1750 VA: 0x1825E2D50
	public void SetBuffer(Memory<byte> buffer) { }
}

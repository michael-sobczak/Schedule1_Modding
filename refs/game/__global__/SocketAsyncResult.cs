internal sealed class SocketAsyncResult : IOAsyncResult // TypeDefIndex: 10213
{
	// Fields
	public Socket socket; // 0x30
	public SocketOperation operation; // 0x38
	private Exception DelayedException; // 0x40
	public EndPoint EndPoint; // 0x48
	public Memory<byte> Buffer; // 0x50
	public int Offset; // 0x60
	public int Size; // 0x64
	public SocketFlags SockFlags; // 0x68
	public Socket AcceptSocket; // 0x70
	public IPAddress[] Addresses; // 0x78
	public int Port; // 0x80
	public IList<ArraySegment<byte>> Buffers; // 0x88
	public bool ReuseSocket; // 0x90
	public int CurrentAddress; // 0x94
	public Socket AcceptedSocket; // 0x98
	public int Total; // 0xA0
	internal int error; // 0xA4
	public int EndCalled; // 0xA8

	// Properties
	public IntPtr Handle { get; }
	public SocketError ErrorCode { get; }

	// Methods

	// RVA: 0x25E3640 Offset: 0x25E2040 VA: 0x1825E3640
	public IntPtr get_Handle() { }

	// RVA: 0xA955C0 Offset: 0xA93FC0 VA: 0x180A955C0
	public void .ctor() { }

	// RVA: 0x25E3430 Offset: 0x25E1E30 VA: 0x1825E3430
	public void Init(Socket socket, AsyncCallback callback, object state, SocketOperation operation) { }

	// RVA: 0x25E3560 Offset: 0x25E1F60 VA: 0x1825E3560
	public void .ctor(Socket socket, AsyncCallback callback, object state, SocketOperation operation) { }

	// RVA: 0x25E35B0 Offset: 0x25E1FB0 VA: 0x1825E35B0
	public SocketError get_ErrorCode() { }

	// RVA: 0x25E3040 Offset: 0x25E1A40 VA: 0x1825E3040
	public void CheckIfThrowDelayedException() { }

	// RVA: 0x25E30F0 Offset: 0x25E1AF0 VA: 0x1825E30F0 Slot: 8
	internal override void CompleteDisposed() { }

	// RVA: 0x25E3200 Offset: 0x25E1C00 VA: 0x1825E3200
	public void Complete() { }

	// RVA: 0x25E3100 Offset: 0x25E1B00 VA: 0x1825E3100
	public void Complete(bool synch) { }

	// RVA: 0x25E31C0 Offset: 0x25E1BC0 VA: 0x1825E31C0
	public void Complete(int total) { }

	// RVA: 0x25E3140 Offset: 0x25E1B40 VA: 0x1825E3140
	public void Complete(Exception e, bool synch) { }

	// RVA: 0x25E3110 Offset: 0x25E1B10 VA: 0x1825E3110
	public void Complete(Exception e) { }

	// RVA: 0x25E31D0 Offset: 0x25E1BD0 VA: 0x1825E31D0
	public void Complete(Socket s) { }

	// RVA: 0x25E3180 Offset: 0x25E1B80 VA: 0x1825E3180
	public void Complete(Socket s, int total) { }
}

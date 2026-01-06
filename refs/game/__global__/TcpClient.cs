public class TcpClient : IDisposable // TypeDefIndex: 10208
{
	// Fields
	private Socket m_ClientSocket; // 0x10
	private bool m_Active; // 0x18
	private NetworkStream m_DataStream; // 0x20
	private AddressFamily m_Family; // 0x28
	private bool m_CleanedUp; // 0x2C

	// Properties
	public Socket Client { get; set; }

	// Methods

	// RVA: 0x25F1970 Offset: 0x25F0370 VA: 0x1825F1970
	public void .ctor() { }

	// RVA: 0x25F1A30 Offset: 0x25F0430 VA: 0x1825F1A30
	public void .ctor(AddressFamily family) { }

	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	public Socket get_Client() { }

	// RVA: 0x49CBB0 Offset: 0x49B5B0 VA: 0x18049CBB0
	public void set_Client(Socket value) { }

	// RVA: 0x25F1020 Offset: 0x25EFA20 VA: 0x1825F1020
	public void Connect(string hostname, int port) { }

	// RVA: 0x25F0F10 Offset: 0x25EF910 VA: 0x1825F0F10
	public void Connect(IPEndPoint remoteEP) { }

	// RVA: 0x25F0D20 Offset: 0x25EF720 VA: 0x1825F0D20
	public IAsyncResult BeginConnect(string host, int port, AsyncCallback requestCallback, object state) { }

	// RVA: 0x25F17A0 Offset: 0x25F01A0 VA: 0x1825F17A0
	public void EndConnect(IAsyncResult asyncResult) { }

	// RVA: 0x25F0DA0 Offset: 0x25EF7A0 VA: 0x1825F0DA0
	public Task ConnectAsync(string host, int port) { }

	// RVA: 0x25F17F0 Offset: 0x25F01F0 VA: 0x1825F17F0
	public NetworkStream GetStream() { }

	// RVA: 0x25F1680 Offset: 0x25F0080 VA: 0x1825F1680 Slot: 5
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x1EA1F90 Offset: 0x1EA0990 VA: 0x181EA1F90 Slot: 4
	public void Dispose() { }

	// RVA: 0x4D8670 Offset: 0x4D7070 VA: 0x1804D8670 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x25F1BA0 Offset: 0x25F05A0 VA: 0x1825F1BA0
	private void initialize() { }
}

internal class TlsStream : NetworkStream // TypeDefIndex: 9930
{
	// Fields
	private SslStream _sslStream; // 0x48
	private string _host; // 0x50
	private X509CertificateCollection _clientCertificates; // 0x58

	// Methods

	// RVA: 0x26B58A0 Offset: 0x26B42A0 VA: 0x1826B58A0
	public void .ctor(NetworkStream stream, Socket socket, string host, X509CertificateCollection clientCertificates) { }

	// RVA: 0x26B5480 Offset: 0x26B3E80 VA: 0x1826B5480
	public void AuthenticateAsClient() { }

	// RVA: 0x26B55B0 Offset: 0x26B3FB0 VA: 0x1826B55B0
	public IAsyncResult BeginAuthenticateAsClient(AsyncCallback asyncCallback, object state) { }

	// RVA: 0x26B57B0 Offset: 0x26B41B0 VA: 0x1826B57B0
	public void EndAuthenticateAsClient(IAsyncResult asyncResult) { }

	// RVA: 0x26B5730 Offset: 0x26B4130 VA: 0x1826B5730 Slot: 28
	public override IAsyncResult BeginWrite(byte[] buffer, int offset, int size, AsyncCallback callback, object state) { }

	// RVA: 0x26B5810 Offset: 0x26B4210 VA: 0x1826B5810 Slot: 29
	public override void EndWrite(IAsyncResult result) { }

	// RVA: 0x26B5870 Offset: 0x26B4270 VA: 0x1826B5870 Slot: 37
	public override void Write(byte[] buffer, int offset, int size) { }

	// RVA: 0x26B5840 Offset: 0x26B4240 VA: 0x1826B5840 Slot: 34
	public override int Read(byte[] buffer, int offset, int size) { }

	// RVA: 0x26B56F0 Offset: 0x26B40F0 VA: 0x1826B56F0 Slot: 24
	public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	// RVA: 0x26B57E0 Offset: 0x26B41E0 VA: 0x1826B57E0 Slot: 25
	public override int EndRead(IAsyncResult asyncResult) { }

	// RVA: 0x26B5770 Offset: 0x26B4170 VA: 0x1826B5770 Slot: 20
	public override void Close() { }
}

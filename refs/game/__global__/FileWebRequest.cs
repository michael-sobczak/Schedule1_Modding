public class FileWebRequest : WebRequest, ISerializable // TypeDefIndex: 10029
{
	// Fields
	private static WaitCallback s_GetRequestStreamCallback; // 0x0
	private static WaitCallback s_GetResponseCallback; // 0x8
	private string m_connectionGroupName; // 0x38
	private long m_contentLength; // 0x40
	private ICredentials m_credentials; // 0x48
	private FileAccess m_fileAccess; // 0x50
	private WebHeaderCollection m_headers; // 0x58
	private string m_method; // 0x60
	private bool m_preauthenticate; // 0x68
	private IWebProxy m_proxy; // 0x70
	private ManualResetEvent m_readerEvent; // 0x78
	private bool m_readPending; // 0x80
	private WebResponse m_response; // 0x88
	private Stream m_stream; // 0x90
	private bool m_syncHint; // 0x98
	private int m_timeout; // 0x9C
	private Uri m_uri; // 0xA0
	private bool m_writePending; // 0xA8
	private bool m_writing; // 0xA9
	private LazyAsyncResult m_WriteAResult; // 0xB0
	private LazyAsyncResult m_ReadAResult; // 0xB8
	private int m_Aborted; // 0xC0

	// Properties
	internal bool Aborted { get; }
	public override string ConnectionGroupName { set; }
	public override long ContentLength { get; set; }
	public override ICredentials Credentials { get; set; }
	public override WebHeaderCollection Headers { get; }
	public override string Method { get; set; }
	public override bool PreAuthenticate { set; }
	public override IWebProxy Proxy { get; set; }
	public override int Timeout { get; set; }
	public override Uri RequestUri { get; }
	public override bool UseDefaultCredentials { get; }

	// Methods

	// RVA: 0x25B1B40 Offset: 0x25B0540 VA: 0x1825B1B40
	internal void .ctor(Uri uri) { }

	[Obsolete("Serialization is obsoleted for this type. http://go.microsoft.com/fwlink/?linkid=14202")]
	// RVA: 0x25B1CD0 Offset: 0x25B06D0 VA: 0x1825B1CD0
	protected void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x25B1980 Offset: 0x25B0380 VA: 0x1825B1980 Slot: 6
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x25B0F50 Offset: 0x25AF950 VA: 0x1825B0F50 Slot: 7
	protected override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x25B2110 Offset: 0x25B0B10 VA: 0x1825B2110
	internal bool get_Aborted() { }

	// RVA: 0x4513E0 Offset: 0x44FDE0 VA: 0x1804513E0 Slot: 12
	public override void set_ConnectionGroupName(string value) { }

	// RVA: 0x4945F0 Offset: 0x492FF0 VA: 0x1804945F0 Slot: 14
	public override long get_ContentLength() { }

	// RVA: 0x25B2150 Offset: 0x25B0B50 VA: 0x1825B2150 Slot: 15
	public override void set_ContentLength(long value) { }

	// RVA: 0x4C1D80 Offset: 0x4C0780 VA: 0x1804C1D80 Slot: 16
	public override ICredentials get_Credentials() { }

	// RVA: 0x5A9D30 Offset: 0x5A8730 VA: 0x1805A9D30 Slot: 17
	public override void set_Credentials(ICredentials value) { }

	// RVA: 0x4993C0 Offset: 0x497DC0 VA: 0x1804993C0 Slot: 13
	public override WebHeaderCollection get_Headers() { }

	// RVA: 0x4C4BF0 Offset: 0x4C35F0 VA: 0x1804C4BF0 Slot: 9
	public override string get_Method() { }

	// RVA: 0x25B21E0 Offset: 0x25B0BE0 VA: 0x1825B21E0 Slot: 10
	public override void set_Method(string value) { }

	// RVA: 0x25B22B0 Offset: 0x25B0CB0 VA: 0x1825B22B0 Slot: 21
	public override void set_PreAuthenticate(bool value) { }

	// RVA: 0x4663C0 Offset: 0x464DC0 VA: 0x1804663C0 Slot: 19
	public override IWebProxy get_Proxy() { }

	// RVA: 0x5F4EE0 Offset: 0x5F38E0 VA: 0x1805F4EE0 Slot: 20
	public override void set_Proxy(IWebProxy value) { }

	// RVA: 0x614470 Offset: 0x612E70 VA: 0x180614470 Slot: 22
	public override int get_Timeout() { }

	// RVA: 0x25B22C0 Offset: 0x25B0CC0 VA: 0x1825B22C0 Slot: 23
	public override void set_Timeout(int value) { }

	// RVA: 0x4B6190 Offset: 0x4B4B90 VA: 0x1804B6190 Slot: 11
	public override Uri get_RequestUri() { }

	// RVA: 0x25B0520 Offset: 0x25AEF20 VA: 0x1825B0520 Slot: 27
	public override IAsyncResult BeginGetRequestStream(AsyncCallback callback, object state) { }

	// RVA: 0x25B0870 Offset: 0x25AF270 VA: 0x1825B0870 Slot: 25
	public override IAsyncResult BeginGetResponse(AsyncCallback callback, object state) { }

	// RVA: 0x25B0AB0 Offset: 0x25AF4B0 VA: 0x1825B0AB0
	private bool CanGetRequestStream() { }

	// RVA: 0x25B0B10 Offset: 0x25AF510 VA: 0x1825B0B10 Slot: 28
	public override Stream EndGetRequestStream(IAsyncResult asyncResult) { }

	// RVA: 0x25B0D30 Offset: 0x25AF730 VA: 0x1825B0D30 Slot: 26
	public override WebResponse EndGetResponse(IAsyncResult asyncResult) { }

	// RVA: 0x25B1700 Offset: 0x25B0100 VA: 0x1825B1700 Slot: 24
	public override WebResponse GetResponse() { }

	// RVA: 0x25B11B0 Offset: 0x25AFBB0 VA: 0x1825B11B0
	private static void GetRequestStreamCallback(object state) { }

	// RVA: 0x25B13E0 Offset: 0x25AFDE0 VA: 0x1825B13E0
	private static void GetResponseCallback(object state) { }

	// RVA: 0x25B19B0 Offset: 0x25B03B0 VA: 0x1825B19B0
	internal void UnblockReader() { }

	// RVA: 0x25B2120 Offset: 0x25B0B20 VA: 0x1825B2120 Slot: 18
	public override bool get_UseDefaultCredentials() { }

	// RVA: 0x25B02E0 Offset: 0x25AECE0 VA: 0x1825B02E0 Slot: 31
	public override void Abort() { }

	// RVA: 0x25B1A50 Offset: 0x25B0450 VA: 0x1825B1A50
	private static void .cctor() { }
}

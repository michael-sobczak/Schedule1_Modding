public class FileWebResponse : WebResponse, ISerializable, ICloseEx // TypeDefIndex: 10032
{
	// Fields
	private bool m_closed; // 0x20
	private long m_contentLength; // 0x28
	private FileAccess m_fileAccess; // 0x30
	private WebHeaderCollection m_headers; // 0x38
	private Stream m_stream; // 0x40
	private Uri m_uri; // 0x48

	// Properties
	public override WebHeaderCollection Headers { get; }
	public override Uri ResponseUri { get; }

	// Methods

	// RVA: 0x25B29D0 Offset: 0x25B13D0 VA: 0x1825B29D0
	internal void .ctor(FileWebRequest request, Uri uri, FileAccess access, bool asyncHint) { }

	[Obsolete("Serialization is obsoleted for this type. http://go.microsoft.com/fwlink/?linkid=14202")]
	// RVA: 0x25B2740 Offset: 0x25B1140 VA: 0x1825B2740
	protected void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x25B2710 Offset: 0x25B1110 VA: 0x1825B2710 Slot: 6
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x25B2420 Offset: 0x25B0E20 VA: 0x1825B2420 Slot: 8
	protected override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x25B2CC0 Offset: 0x25B16C0 VA: 0x1825B2CC0 Slot: 14
	public override WebHeaderCollection get_Headers() { }

	// RVA: 0x25B2CE0 Offset: 0x25B16E0 VA: 0x1825B2CE0 Slot: 13
	public override Uri get_ResponseUri() { }

	// RVA: 0x25B2350 Offset: 0x25B0D50 VA: 0x1825B2350
	private void CheckDisposed() { }

	// RVA: 0x25B23E0 Offset: 0x25B0DE0 VA: 0x1825B23E0 Slot: 9
	public override void Close() { }

	// RVA: 0x25B25F0 Offset: 0x25B0FF0 VA: 0x1825B25F0 Slot: 15
	private void System.Net.ICloseEx.CloseEx(CloseExState closeState) { }

	// RVA: 0x25B25B0 Offset: 0x25B0FB0 VA: 0x1825B25B0 Slot: 12
	public override Stream GetResponseStream() { }
}

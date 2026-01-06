public class WebException : InvalidOperationException, ISerializable // TypeDefIndex: 9983
{
	// Fields
	private WebExceptionStatus m_Status; // 0x90
	private WebResponse m_Response; // 0x98
	private WebExceptionInternalStatus m_InternalStatus; // 0xA0

	// Properties
	public WebExceptionStatus Status { get; }
	public WebResponse Response { get; }

	// Methods

	// RVA: 0x26CC7F0 Offset: 0x26CB1F0 VA: 0x1826CC7F0
	public void .ctor() { }

	// RVA: 0x26CCC90 Offset: 0x26CB690 VA: 0x1826CCC90
	public void .ctor(string message) { }

	// RVA: 0x26CC9E0 Offset: 0x26CB3E0 VA: 0x1826CC9E0
	public void .ctor(string message, Exception innerException) { }

	// RVA: 0x26CC810 Offset: 0x26CB210 VA: 0x1826CC810
	public void .ctor(string message, WebExceptionStatus status) { }

	// RVA: 0x26CC860 Offset: 0x26CB260 VA: 0x1826CC860
	internal void .ctor(string message, WebExceptionStatus status, WebExceptionInternalStatus internalStatus, Exception innerException) { }

	// RVA: 0x26CCA00 Offset: 0x26CB400 VA: 0x1826CCA00
	public void .ctor(string message, Exception innerException, WebExceptionStatus status, WebResponse response) { }

	// RVA: 0x26CCAC0 Offset: 0x26CB4C0 VA: 0x1826CCAC0
	internal void .ctor(string message, string data, Exception innerException, WebExceptionStatus status, WebResponse response) { }

	// RVA: 0x26CC920 Offset: 0x26CB320 VA: 0x1826CC920
	internal void .ctor(string message, Exception innerException, WebExceptionStatus status, WebResponse response, WebExceptionInternalStatus internalStatus) { }

	// RVA: 0x26CCBA0 Offset: 0x26CB5A0 VA: 0x1826CCBA0
	internal void .ctor(string message, string data, Exception innerException, WebExceptionStatus status, WebResponse response, WebExceptionInternalStatus internalStatus) { }

	// RVA: 0x26CC830 Offset: 0x26CB230 VA: 0x1826CC830
	protected void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x26CC7C0 Offset: 0x26CB1C0 VA: 0x1826CC7C0 Slot: 4
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x25AC8A0 Offset: 0x25AB2A0 VA: 0x1825AC8A0 Slot: 14
	public override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x4E2430 Offset: 0x4E0E30 VA: 0x1804E2430
	public WebExceptionStatus get_Status() { }

	// RVA: 0xAA7250 Offset: 0xAA5C50 VA: 0x180AA7250
	public WebResponse get_Response() { }
}

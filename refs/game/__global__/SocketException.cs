public class SocketException : Win32Exception // TypeDefIndex: 10191
{
	// Fields
	private EndPoint m_EndPoint; // 0x98

	// Properties
	public override string Message { get; }
	public SocketError SocketErrorCode { get; }

	// Methods

	// RVA: 0x25E36D0 Offset: 0x25E20D0 VA: 0x1825E36D0
	private static int WSAGetLastError_icall() { }

	// RVA: 0x25E36E0 Offset: 0x25E20E0 VA: 0x1825E36E0
	public void .ctor() { }

	// RVA: 0x1E01F80 Offset: 0x1E00980 VA: 0x181E01F80
	internal void .ctor(int error, string message) { }

	// RVA: 0x1E01EC0 Offset: 0x1E008C0 VA: 0x181E01EC0
	public void .ctor(int errorCode) { }

	// RVA: 0x1E01EC0 Offset: 0x1E008C0 VA: 0x181E01EC0
	internal void .ctor(SocketError socketError) { }

	// RVA: 0x1E01EA0 Offset: 0x1E008A0 VA: 0x181E01EA0
	protected void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x25E3700 Offset: 0x25E2100 VA: 0x1825E3700 Slot: 5
	public override string get_Message() { }

	// RVA: 0x4E2430 Offset: 0x4E0E30 VA: 0x1804E2430
	public SocketError get_SocketErrorCode() { }
}

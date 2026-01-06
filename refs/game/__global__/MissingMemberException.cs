public class MissingMemberException : MemberAccessException // TypeDefIndex: 3779
{
	// Fields
	protected string ClassName; // 0x90
	protected string MemberName; // 0x98
	protected byte[] Signature; // 0xA0

	// Properties
	public override string Message { get; }

	// Methods

	// RVA: 0x1C80980 Offset: 0x1C7F380 VA: 0x181C80980
	public void .ctor() { }

	// RVA: 0x1C809D0 Offset: 0x1C7F3D0 VA: 0x181C809D0
	public void .ctor(string message) { }

	// RVA: 0x1C809F0 Offset: 0x1C7F3F0 VA: 0x181C809F0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1C80740 Offset: 0x1C7F140 VA: 0x181C80740 Slot: 14
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1C80BF0 Offset: 0x1C7F5F0 VA: 0x181C80BF0 Slot: 5
	public override string get_Message() { }

	// RVA: 0x1C80700 Offset: 0x1C7F100 VA: 0x181C80700
	internal static string FormatSignature(byte[] signature) { }
}

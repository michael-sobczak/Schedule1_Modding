public class RequestFailedException : Exception // TypeDefIndex: 19102
{
	// Fields
	[CompilerGenerated]
	private readonly int <ErrorCode>k__BackingField; // 0x90

	// Properties
	public int ErrorCode { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4E2430 Offset: 0x4E0E30 VA: 0x1804E2430
	public int get_ErrorCode() { }

	// RVA: 0x2B98440 Offset: 0x2B96E40 VA: 0x182B98440
	public void .ctor(int errorCode, string message) { }

	// RVA: 0x2B983C0 Offset: 0x2B96DC0 VA: 0x182B983C0
	public void .ctor(int errorCode, string message, Exception innerException) { }
}

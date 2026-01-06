public class Win32Exception : ExternalException, ISerializable // TypeDefIndex: 9814
{
	// Fields
	private readonly int nativeErrorCode; // 0x90

	// Properties
	public int NativeErrorCode { get; }

	// Methods

	// RVA: 0x2699B50 Offset: 0x2698550 VA: 0x182699B50
	public void .ctor() { }

	// RVA: 0x2699D00 Offset: 0x2698700 VA: 0x182699D00
	public void .ctor(int error) { }

	// RVA: 0x2699CD0 Offset: 0x26986D0 VA: 0x182699CD0
	public void .ctor(int error, string message) { }

	// RVA: 0x2699C50 Offset: 0x2698650 VA: 0x182699C50
	public void .ctor(string message) { }

	// RVA: 0x2699AD0 Offset: 0x26984D0 VA: 0x182699AD0
	public void .ctor(string message, Exception innerException) { }

	// RVA: 0x2699BC0 Offset: 0x26985C0 VA: 0x182699BC0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x4E2430 Offset: 0x4E0E30 VA: 0x1804E2430
	public int get_NativeErrorCode() { }

	// RVA: 0x2699A00 Offset: 0x2698400 VA: 0x182699A00 Slot: 14
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x2698F20 Offset: 0x2697920 VA: 0x182698F20
	internal static string GetErrorMessage(int error) { }
}

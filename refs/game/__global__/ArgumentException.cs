public class ArgumentException : SystemException // TypeDefIndex: 3592
{
	// Fields
	private string _paramName; // 0x90

	// Properties
	public override string Message { get; }

	// Methods

	// RVA: 0x1BBAF40 Offset: 0x1BB9940 VA: 0x181BBAF40
	public void .ctor() { }

	// RVA: 0x1BBAF20 Offset: 0x1BB9920 VA: 0x181BBAF20
	public void .ctor(string message) { }

	// RVA: 0x1BBB0C0 Offset: 0x1BB9AC0 VA: 0x181BBB0C0
	public void .ctor(string message, Exception innerException) { }

	// RVA: 0x1BBAF90 Offset: 0x1BB9990 VA: 0x181BBAF90
	public void .ctor(string message, string paramName, Exception innerException) { }

	// RVA: 0x1BBAFE0 Offset: 0x1BB99E0 VA: 0x181BBAFE0
	public void .ctor(string message, string paramName) { }

	// RVA: 0x1BBB020 Offset: 0x1BB9A20 VA: 0x181BBB020
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1BBAE50 Offset: 0x1BB9850 VA: 0x181BBAE50 Slot: 14
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1BBB0E0 Offset: 0x1BB9AE0 VA: 0x181BBB0E0 Slot: 5
	public override string get_Message() { }
}

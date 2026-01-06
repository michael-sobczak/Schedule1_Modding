public class ArgumentOutOfRangeException : ArgumentException // TypeDefIndex: 3594
{
	// Fields
	private object _actualValue; // 0x98

	// Properties
	public override string Message { get; }

	// Methods

	// RVA: 0x1BBB580 Offset: 0x1BB9F80 VA: 0x181BBB580
	public void .ctor() { }

	// RVA: 0x1BBB5D0 Offset: 0x1BB9FD0 VA: 0x181BBB5D0
	public void .ctor(string paramName) { }

	// RVA: 0x1BBB640 Offset: 0x1BBA040 VA: 0x181BBB640
	public void .ctor(string paramName, string message) { }

	// RVA: 0x1BBB3F0 Offset: 0x1BB9DF0 VA: 0x181BBB3F0
	public void .ctor(string paramName, object actualValue, string message) { }

	// RVA: 0x1BBB460 Offset: 0x1BB9E60 VA: 0x181BBB460
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1BBB290 Offset: 0x1BB9C90 VA: 0x181BBB290 Slot: 14
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1BBB690 Offset: 0x1BBA090 VA: 0x181BBB690 Slot: 5
	public override string get_Message() { }
}

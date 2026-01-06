public class MissingFieldException : MissingMemberException, ISerializable // TypeDefIndex: 3778
{
	// Properties
	public override string Message { get; }

	// Methods

	// RVA: 0x1C803F0 Offset: 0x1C7EDF0 VA: 0x181C803F0
	public void .ctor() { }

	// RVA: 0x1C804D0 Offset: 0x1C7EED0 VA: 0x181C804D0
	public void .ctor(string message) { }

	// RVA: 0x1C80440 Offset: 0x1C7EE40 VA: 0x181C80440
	public void .ctor(string className, string fieldName) { }

	// RVA: 0x1C69FF0 Offset: 0x1C689F0 VA: 0x181C69FF0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1C804F0 Offset: 0x1C7EEF0 VA: 0x181C804F0 Slot: 5
	public override string get_Message() { }
}

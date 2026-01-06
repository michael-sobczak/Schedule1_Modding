public class ObjectDisposedException : InvalidOperationException // TypeDefIndex: 3704
{
	// Fields
	private string _objectName; // 0x90

	// Properties
	public override string Message { get; }
	public string ObjectName { get; }

	// Methods

	// RVA: 0x1C80F90 Offset: 0x1C7F990 VA: 0x181C80F90
	private void .ctor() { }

	// RVA: 0x1C81040 Offset: 0x1C7FA40 VA: 0x181C81040
	public void .ctor(string objectName) { }

	// RVA: 0x1C80FF0 Offset: 0x1C7F9F0 VA: 0x181C80FF0
	public void .ctor(string objectName, string message) { }

	// RVA: 0x1C80EF0 Offset: 0x1C7F8F0 VA: 0x181C80EF0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1C80DA0 Offset: 0x1C7F7A0 VA: 0x181C80DA0 Slot: 14
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1C810B0 Offset: 0x1C7FAB0 VA: 0x181C810B0 Slot: 5
	public override string get_Message() { }

	// RVA: 0x1C81180 Offset: 0x1C7FB80 VA: 0x181C81180
	public string get_ObjectName() { }
}

public class SecurityException : SystemException // TypeDefIndex: 4157
{
	// Fields
	private string permissionState; // 0x90

	// Methods

	// RVA: 0x1AD9A90 Offset: 0x1AD8490 VA: 0x181AD9A90
	public void .ctor() { }

	// RVA: 0x1AD9A50 Offset: 0x1AD8450 VA: 0x181AD9A50
	public void .ctor(string message) { }

	// RVA: 0x1AD9AE0 Offset: 0x1AD84E0 VA: 0x181AD9AE0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1AD9A70 Offset: 0x1AD8470 VA: 0x181AD9A70
	public void .ctor(string message, Exception inner) { }

	// RVA: 0x1AD99B0 Offset: 0x1AD83B0 VA: 0x181AD99B0 Slot: 14
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1AD9A40 Offset: 0x1AD8440 VA: 0x181AD9A40 Slot: 3
	public override string ToString() { }
}

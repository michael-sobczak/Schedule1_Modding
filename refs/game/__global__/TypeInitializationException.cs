public sealed class TypeInitializationException : SystemException // TypeDefIndex: 3747
{
	// Fields
	private string _typeName; // 0x90

	// Properties
	public string TypeName { get; }

	// Methods

	// RVA: 0x1C8C410 Offset: 0x1C8AE10 VA: 0x181C8C410
	private void .ctor() { }

	// RVA: 0x1C8C4A0 Offset: 0x1C8AEA0 VA: 0x181C8C4A0
	public void .ctor(string fullTypeName, Exception innerException) { }

	// RVA: 0x1C8C640 Offset: 0x1C8B040 VA: 0x181C8C640
	internal void .ctor(string fullTypeName, string message, Exception innerException) { }

	// RVA: 0x1C8C570 Offset: 0x1C8AF70 VA: 0x181C8C570
	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1C8C2C0 Offset: 0x1C8ACC0 VA: 0x181C8C2C0 Slot: 14
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1C8C6E0 Offset: 0x1C8B0E0 VA: 0x181C8C6E0
	public string get_TypeName() { }
}

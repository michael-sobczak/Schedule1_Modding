public class TypeLoadException : SystemException, ISerializable // TypeDefIndex: 3827
{
	// Fields
	private string ClassName; // 0x90
	private string AssemblyName; // 0x98
	private string MessageArg; // 0xA0
	internal int ResourceId; // 0xA8

	// Properties
	public override string Message { get; }

	// Methods

	// RVA: 0x1CCFF50 Offset: 0x1CCE950 VA: 0x181CCFF50
	public void .ctor() { }

	// RVA: 0x1CCFF20 Offset: 0x1CCE920 VA: 0x181CCFF20
	public void .ctor(string message) { }

	// RVA: 0x1CD0040 Offset: 0x1CCEA40 VA: 0x181CD0040 Slot: 5
	public override string get_Message() { }

	// RVA: 0x1CCFBC0 Offset: 0x1CCE5C0 VA: 0x181CCFBC0
	private void SetMessageField() { }

	// RVA: 0x1CCFFA0 Offset: 0x1CCE9A0 VA: 0x181CCFFA0
	private void .ctor(string className, string assemblyName) { }

	// RVA: 0x1CCFD00 Offset: 0x1CCE700 VA: 0x181CCFD00
	private void .ctor(string className, string assemblyName, string messageArg, int resourceId) { }

	// RVA: 0x1CCFDB0 Offset: 0x1CCE7B0 VA: 0x181CCFDB0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1CCFA00 Offset: 0x1CCE400 VA: 0x181CCFA00 Slot: 14
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }
}

public class BadImageFormatException : SystemException // TypeDefIndex: 3604
{
	// Fields
	private string _fileName; // 0x90
	private string _fusionLog; // 0x98

	// Properties
	public override string Message { get; }

	// Methods

	// RVA: 0x1BBBEC0 Offset: 0x1BBA8C0 VA: 0x181BBBEC0
	public void .ctor() { }

	// RVA: 0x1BBBE60 Offset: 0x1BBA860 VA: 0x181BBBE60
	public void .ctor(string message) { }

	// RVA: 0x1BBBE40 Offset: 0x1BBA840 VA: 0x181BBBE40
	public void .ctor(string message, Exception inner) { }

	// RVA: 0x1BBBE80 Offset: 0x1BBA880 VA: 0x181BBBE80
	public void .ctor(string message, string fileName) { }

	// RVA: 0x1BBBD70 Offset: 0x1BBA770 VA: 0x181BBBD70
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1BBB9D0 Offset: 0x1BBA3D0 VA: 0x181BBB9D0 Slot: 14
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1BBBF10 Offset: 0x1BBA910 VA: 0x181BBBF10 Slot: 5
	public override string get_Message() { }

	// RVA: 0x1BBBAF0 Offset: 0x1BBA4F0 VA: 0x181BBBAF0
	private void SetMessageField() { }

	// RVA: 0x1BBBB80 Offset: 0x1BBA580 VA: 0x181BBBB80 Slot: 3
	public override string ToString() { }
}

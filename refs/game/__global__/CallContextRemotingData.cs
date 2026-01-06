internal class CallContextRemotingData : ICloneable // TypeDefIndex: 4365
{
	// Fields
	private string _logicalCallID; // 0x10

	// Properties
	internal string LogicalCallID { get; set; }
	internal bool HasInfo { get; }

	// Methods

	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	internal string get_LogicalCallID() { }

	// RVA: 0x49CBB0 Offset: 0x49B5B0 VA: 0x18049CBB0
	internal void set_LogicalCallID(string value) { }

	// RVA: 0x82C1F0 Offset: 0x82ABF0 VA: 0x18082C1F0
	internal bool get_HasInfo() { }

	// RVA: 0x1B28840 Offset: 0x1B27240 VA: 0x181B28840 Slot: 4
	public object Clone() { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }
}

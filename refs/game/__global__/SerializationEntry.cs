public struct SerializationEntry // TypeDefIndex: 4416
{
	// Fields
	private readonly string _name; // 0x0
	private readonly object _value; // 0x8
	private readonly Type _type; // 0x10

	// Properties
	public object Value { get; }
	public string Name { get; }

	// Methods

	// RVA: 0xB0FAD0 Offset: 0xB0E4D0 VA: 0x180B0FAD0
	internal void .ctor(string entryName, object entryValue, Type entryType) { }

	// RVA: 0x43C7B0 Offset: 0x43B1B0 VA: 0x18043C7B0
	public object get_Value() { }

	// RVA: 0x43C7F0 Offset: 0x43B1F0 VA: 0x18043C7F0
	public string get_Name() { }
}

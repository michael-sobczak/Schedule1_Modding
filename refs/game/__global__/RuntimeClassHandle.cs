internal struct RuntimeClassHandle // TypeDefIndex: 3463
{
	// Fields
	private RuntimeStructs.MonoClass* value; // 0x0

	// Properties
	internal RuntimeStructs.MonoClass* Value { get; }

	// Methods

	// RVA: 0xC7C0C0 Offset: 0xC7AAC0 VA: 0x180C7C0C0
	internal void .ctor(RuntimeStructs.MonoClass* value) { }

	// RVA: 0x1A8DC10 Offset: 0x1A8C610 VA: 0x181A8DC10
	internal void .ctor(IntPtr ptr) { }

	// RVA: 0x43C7F0 Offset: 0x43B1F0 VA: 0x18043C7F0
	internal RuntimeStructs.MonoClass* get_Value() { }

	// RVA: 0x1A8DAC0 Offset: 0x1A8C4C0 VA: 0x181A8DAC0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1A8DBC0 Offset: 0x1A8C5C0 VA: 0x181A8DBC0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1A8DBF0 Offset: 0x1A8C5F0 VA: 0x181A8DBF0
	internal static IntPtr GetTypeFromClass(RuntimeStructs.MonoClass* klass) { }

	// RVA: 0x1A8DC00 Offset: 0x1A8C600 VA: 0x181A8DC00
	internal RuntimeTypeHandle GetTypeHandle() { }
}

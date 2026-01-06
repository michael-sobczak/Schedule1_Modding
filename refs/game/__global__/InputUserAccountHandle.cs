public struct InputUserAccountHandle : IEquatable<InputUserAccountHandle> // TypeDefIndex: 7504
{
	// Fields
	private string m_ApiName; // 0x0
	private ulong m_Handle; // 0x8

	// Properties
	public string apiName { get; }
	public ulong handle { get; }

	// Methods

	// RVA: 0x43C7F0 Offset: 0x43B1F0 VA: 0x18043C7F0
	public string get_apiName() { }

	// RVA: 0x43C7B0 Offset: 0x43B1B0 VA: 0x18043C7B0
	public ulong get_handle() { }

	// RVA: 0x284A750 Offset: 0x2849150 VA: 0x18284A750
	public void .ctor(string apiName, ulong handle) { }

	// RVA: 0x284A6A0 Offset: 0x28490A0 VA: 0x18284A6A0 Slot: 3
	public override string ToString() { }

	// RVA: 0x284A490 Offset: 0x2848E90 VA: 0x18284A490 Slot: 4
	public bool Equals(InputUserAccountHandle other) { }

	// RVA: 0x284A530 Offset: 0x2848F30 VA: 0x18284A530 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x284A7F0 Offset: 0x28491F0 VA: 0x18284A7F0
	public static bool op_Equality(InputUserAccountHandle left, InputUserAccountHandle right) { }

	// RVA: 0x284A8A0 Offset: 0x28492A0 VA: 0x18284A8A0
	public static bool op_Inequality(InputUserAccountHandle left, InputUserAccountHandle right) { }

	// RVA: 0x284A640 Offset: 0x2849040 VA: 0x18284A640 Slot: 2
	public override int GetHashCode() { }
}

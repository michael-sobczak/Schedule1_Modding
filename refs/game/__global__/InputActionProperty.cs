public struct InputActionProperty : IEquatable<InputActionProperty>, IEquatable<InputAction>, IEquatable<InputActionReference> // TypeDefIndex: 7293
{
	// Fields
	[SerializeField]
	private bool m_UseReference; // 0x0
	[SerializeField]
	private InputAction m_Action; // 0x8
	[SerializeField]
	private InputActionReference m_Reference; // 0x10

	// Properties
	public InputAction action { get; }
	public InputActionReference reference { get; }
	internal InputAction serializedAction { get; }
	internal InputActionReference serializedReference { get; }

	// Methods

	// RVA: 0x2766CA0 Offset: 0x27656A0 VA: 0x182766CA0
	public InputAction get_action() { }

	// RVA: 0x2766D30 Offset: 0x2765730 VA: 0x182766D30
	public InputActionReference get_reference() { }

	// RVA: 0x43C7B0 Offset: 0x43B1B0 VA: 0x18043C7B0
	internal InputAction get_serializedAction() { }

	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	internal InputActionReference get_serializedReference() { }

	// RVA: 0x2766C20 Offset: 0x2765620 VA: 0x182766C20
	public void .ctor(InputAction action) { }

	// RVA: 0x2766C60 Offset: 0x2765660 VA: 0x182766C60
	public void .ctor(InputActionReference reference) { }

	// RVA: 0x2766950 Offset: 0x2765350 VA: 0x182766950 Slot: 4
	public bool Equals(InputActionProperty other) { }

	// RVA: 0x2766B00 Offset: 0x2765500 VA: 0x182766B00 Slot: 5
	public bool Equals(InputAction other) { }

	// RVA: 0x2766B20 Offset: 0x2765520 VA: 0x182766B20 Slot: 6
	public bool Equals(InputActionReference other) { }

	// RVA: 0x27669F0 Offset: 0x27653F0 VA: 0x1827669F0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2766B80 Offset: 0x2765580 VA: 0x182766B80 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2766D40 Offset: 0x2765740 VA: 0x182766D40
	public static bool op_Equality(InputActionProperty left, InputActionProperty right) { }

	// RVA: 0x2766DD0 Offset: 0x27657D0 VA: 0x182766DD0
	public static bool op_Inequality(InputActionProperty left, InputActionProperty right) { }
}

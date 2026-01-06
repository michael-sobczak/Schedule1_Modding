public struct EnableIMECompositionCommand : IInputDeviceCommandInfo // TypeDefIndex: 7608
{
	// Fields
	internal const int kSize = 12;
	public InputDeviceCommand baseCommand; // 0x0
	private byte m_ImeEnabled; // 0x8

	// Properties
	public static FourCC Type { get; }
	public bool imeEnabled { get; }
	public FourCC typeStatic { get; }

	// Methods

	// RVA: 0x2857FD0 Offset: 0x28569D0 VA: 0x182857FD0
	public static FourCC get_Type() { }

	// RVA: 0x2858010 Offset: 0x2856A10 VA: 0x182858010
	public bool get_imeEnabled() { }

	// RVA: 0x2858020 Offset: 0x2856A20 VA: 0x182858020 Slot: 4
	public FourCC get_typeStatic() { }

	// RVA: 0x2857F50 Offset: 0x2856950 VA: 0x182857F50
	public static EnableIMECompositionCommand Create(bool enabled) { }
}

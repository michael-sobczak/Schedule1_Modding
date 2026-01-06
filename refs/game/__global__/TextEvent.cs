public struct TextEvent : IInputEventTypeInfo // TypeDefIndex: 7689
{
	// Fields
	public const int Type = 1413830740;
	public InputEvent baseEvent; // 0x0
	public int character; // 0x14

	// Properties
	public FourCC typeStatic { get; }

	// Methods

	// RVA: 0x28808D0 Offset: 0x287F2D0 VA: 0x1828808D0 Slot: 4
	public FourCC get_typeStatic() { }

	// RVA: 0x2880790 Offset: 0x287F190 VA: 0x182880790
	public static TextEvent* From(InputEventPtr eventPtr) { }

	// RVA: 0x28806B0 Offset: 0x287F0B0 VA: 0x1828806B0
	public static TextEvent Create(int deviceId, char character, double time = -1) { }

	// RVA: 0x2880720 Offset: 0x287F120 VA: 0x182880720
	public static TextEvent Create(int deviceId, int character, double time = -1) { }
}

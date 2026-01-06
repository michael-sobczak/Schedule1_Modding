public struct IMECompositionEvent : IInputEventTypeInfo // TypeDefIndex: 7668
{
	// Fields
	internal const int kIMECharBufferSize = 64;
	public const int Type = 1229800787;
	public InputEvent baseEvent; // 0x0
	public IMECompositionString compositionString; // 0x14

	// Properties
	public FourCC typeStatic { get; }

	// Methods

	// RVA: 0x285F940 Offset: 0x285E340 VA: 0x18285F940 Slot: 4
	public FourCC get_typeStatic() { }

	// RVA: 0x285F6D0 Offset: 0x285E0D0 VA: 0x18285F6D0
	public static IMECompositionEvent Create(int deviceId, string compositionString, double time) { }
}

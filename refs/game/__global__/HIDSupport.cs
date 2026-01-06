public static class HIDSupport // TypeDefIndex: 7568
{
	// Fields
	private static HIDSupport.HIDPageUsage[] s_SupportedHIDUsages; // 0x0

	// Properties
	public static ReadOnlyArray<HIDSupport.HIDPageUsage> supportedHIDUsages { get; set; }

	// Methods

	// RVA: 0x285F3D0 Offset: 0x285DDD0 VA: 0x18285F3D0
	public static ReadOnlyArray<HIDSupport.HIDPageUsage> get_supportedHIDUsages() { }

	// RVA: 0x285F440 Offset: 0x285DE40 VA: 0x18285F440
	public static void set_supportedHIDUsages(ReadOnlyArray<HIDSupport.HIDPageUsage> value) { }

	// RVA: 0x285F240 Offset: 0x285DC40 VA: 0x18285F240
	internal static void Initialize() { }
}

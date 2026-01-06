public struct BufferedRumble // TypeDefIndex: 7478
{
	// Fields
	[CompilerGenerated]
	private HapticCapabilities <capabilities>k__BackingField; // 0x0
	[CompilerGenerated]
	private InputDevice <device>k__BackingField; // 0x18

	// Properties
	public HapticCapabilities capabilities { get; set; }
	private InputDevice device { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x281EA90 Offset: 0x281D490 VA: 0x18281EA90
	public HapticCapabilities get_capabilities() { }

	[CompilerGenerated]
	// RVA: 0x281EAA0 Offset: 0x281D4A0 VA: 0x18281EAA0
	private void set_capabilities(HapticCapabilities value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	private InputDevice get_device() { }

	[CompilerGenerated]
	// RVA: 0x43EFE0 Offset: 0x43D9E0 VA: 0x18043EFE0
	private void set_device(InputDevice value) { }

	// RVA: 0x281E920 Offset: 0x281D320 VA: 0x18281E920
	public void .ctor(InputDevice device) { }

	// RVA: 0x281E6A0 Offset: 0x281D0A0 VA: 0x18281E6A0
	public void EnqueueRumble(byte[] samples) { }
}

public sealed class FastApproximateAntialiasing // TypeDefIndex: 16978
{
	// Fields
	[Tooltip("Boost performances by lowering the effect quality. This setting is meant to be used on mobile and other low-end platforms but can also provide a nice performance boost on desktops and consoles.")]
	[FormerlySerializedAs("mobileOptimized")]
	public bool fastMode; // 0x10
	[Tooltip("Keep alpha channel. This will slightly lower the effect quality but allows rendering against a transparent background.
This setting has no effect if the camera render target has no alpha channel.")]
	public bool keepAlpha; // 0x11

	// Methods

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }
}

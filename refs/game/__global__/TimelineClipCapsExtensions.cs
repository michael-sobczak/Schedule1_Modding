internal static class TimelineClipCapsExtensions // TypeDefIndex: 17399
{
	// Methods

	[Extension]
	// RVA: 0x2C4E280 Offset: 0x2C4CC80 VA: 0x182C4E280
	public static bool SupportsLooping(TimelineClip clip) { }

	[Extension]
	// RVA: 0x2C4E250 Offset: 0x2C4CC50 VA: 0x182C4E250
	public static bool SupportsExtrapolation(TimelineClip clip) { }

	[Extension]
	// RVA: 0x2C4E220 Offset: 0x2C4CC20 VA: 0x182C4E220
	public static bool SupportsClipIn(TimelineClip clip) { }

	[Extension]
	// RVA: 0x2C4E2A0 Offset: 0x2C4CCA0 VA: 0x182C4E2A0
	public static bool SupportsSpeedMultiplier(TimelineClip clip) { }

	[Extension]
	// RVA: 0x2C4E1F0 Offset: 0x2C4CBF0 VA: 0x182C4E1F0
	public static bool SupportsBlending(TimelineClip clip) { }

	[Extension]
	// RVA: 0xD4A560 Offset: 0xD48F60 VA: 0x180D4A560
	public static bool HasAll(ClipCaps caps, ClipCaps flags) { }

	[Extension]
	// RVA: 0x24A46B0 Offset: 0x24A30B0 VA: 0x1824A46B0
	public static bool HasAny(ClipCaps caps, ClipCaps flags) { }
}

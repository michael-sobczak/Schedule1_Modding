public abstract class Switch // TypeDefIndex: 9577
{
	// Fields
	private readonly string description; // 0x10
	private readonly string displayName; // 0x18
	private string switchValueString; // 0x20
	private string defaultValue; // 0x28
	private static List<WeakReference> switches; // 0x0
	private static int s_LastCollectionCount; // 0x8

	// Methods

	// RVA: 0x263CD90 Offset: 0x263B790 VA: 0x18263CD90
	protected void .ctor(string displayName, string description) { }

	// RVA: 0x263CE00 Offset: 0x263B800 VA: 0x18263CE00
	protected void .ctor(string displayName, string description, string defaultSwitchValue) { }

	// RVA: 0x263D060 Offset: 0x263BA60 VA: 0x18263D060
	private static void _pruneCachedSwitches() { }

	// RVA: 0x263CD00 Offset: 0x263B700 VA: 0x18263CD00
	private static void .cctor() { }
}

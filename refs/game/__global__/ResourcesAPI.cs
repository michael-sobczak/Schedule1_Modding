public class ResourcesAPI // TypeDefIndex: 11789
{
	// Fields
	private static ResourcesAPI s_DefaultAPI; // 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static ResourcesAPI <overrideAPI>k__BackingField; // 0x8

	// Properties
	internal static ResourcesAPI ActiveAPI { get; }
	public static ResourcesAPI overrideAPI { get; }

	// Methods

	// RVA: 0x2CC6630 Offset: 0x2CC5030 VA: 0x182CC6630
	internal static ResourcesAPI get_ActiveAPI() { }

	[CompilerGenerated]
	// RVA: 0x2CC66E0 Offset: 0x2CC50E0 VA: 0x182CC66E0
	public static ResourcesAPI get_overrideAPI() { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	protected internal void .ctor() { }

	// RVA: 0x2CC64A0 Offset: 0x2CC4EA0 VA: 0x182CC64A0 Slot: 4
	protected internal virtual Object[] FindObjectsOfTypeAll(Type systemTypeInstance) { }

	// RVA: 0x2CC64E0 Offset: 0x2CC4EE0 VA: 0x182CC64E0 Slot: 5
	protected internal virtual Shader FindShaderByName(string name) { }

	// RVA: 0x2CC6570 Offset: 0x2CC4F70 VA: 0x182CC6570 Slot: 6
	protected internal virtual Object Load(string path, Type systemTypeInstance) { }

	// RVA: 0x2CC6520 Offset: 0x2CC4F20 VA: 0x182CC6520 Slot: 7
	protected internal virtual Object[] LoadAll(string path, Type systemTypeInstance) { }

	// RVA: 0x2CC65C0 Offset: 0x2CC4FC0 VA: 0x182CC65C0
	private static void .cctor() { }
}

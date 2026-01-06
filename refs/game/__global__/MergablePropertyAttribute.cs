public sealed class MergablePropertyAttribute : Attribute // TypeDefIndex: 9675
{
	// Fields
	public static readonly MergablePropertyAttribute Yes; // 0x0
	public static readonly MergablePropertyAttribute No; // 0x8
	public static readonly MergablePropertyAttribute Default; // 0x10
	[CompilerGenerated]
	private readonly bool <AllowMerge>k__BackingField; // 0x10

	// Properties
	public bool AllowMerge { get; }

	// Methods

	// RVA: 0x1B5FE70 Offset: 0x1B5E870 VA: 0x181B5FE70
	public void .ctor(bool allowMerge) { }

	[CompilerGenerated]
	// RVA: 0x498A40 Offset: 0x497440 VA: 0x180498A40
	public bool get_AllowMerge() { }

	// RVA: 0x2647DE0 Offset: 0x26467E0 VA: 0x182647DE0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x263FCC0 Offset: 0x263E6C0 VA: 0x18263FCC0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2647EA0 Offset: 0x26468A0 VA: 0x182647EA0 Slot: 6
	public override bool IsDefaultAttribute() { }

	// RVA: 0x2647F10 Offset: 0x2646910 VA: 0x182647F10
	private static void .cctor() { }
}

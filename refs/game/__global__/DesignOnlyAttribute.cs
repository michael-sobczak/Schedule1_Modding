public sealed class DesignOnlyAttribute : Attribute // TypeDefIndex: 9661
{
	// Fields
	[CompilerGenerated]
	private readonly bool <IsDesignOnly>k__BackingField; // 0x10
	public static readonly DesignOnlyAttribute Yes; // 0x0
	public static readonly DesignOnlyAttribute No; // 0x8
	public static readonly DesignOnlyAttribute Default; // 0x10

	// Properties
	public bool IsDesignOnly { get; }

	// Methods

	// RVA: 0x1B5FE70 Offset: 0x1B5E870 VA: 0x181B5FE70
	public void .ctor(bool isDesignOnly) { }

	[CompilerGenerated]
	// RVA: 0x498A40 Offset: 0x497440 VA: 0x180498A40
	public bool get_IsDesignOnly() { }

	// RVA: 0x2646A10 Offset: 0x2645410 VA: 0x182646A10 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2646AD0 Offset: 0x26454D0 VA: 0x182646AD0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2646B30 Offset: 0x2645530 VA: 0x182646B30 Slot: 6
	public override bool IsDefaultAttribute() { }

	// RVA: 0x2646BA0 Offset: 0x26455A0 VA: 0x182646BA0
	private static void .cctor() { }
}

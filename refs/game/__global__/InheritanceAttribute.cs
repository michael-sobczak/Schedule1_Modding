public sealed class InheritanceAttribute : Attribute // TypeDefIndex: 9707
{
	// Fields
	public static readonly InheritanceAttribute Inherited; // 0x0
	public static readonly InheritanceAttribute InheritedReadOnly; // 0x8
	public static readonly InheritanceAttribute NotInherited; // 0x10
	public static readonly InheritanceAttribute Default; // 0x18
	[CompilerGenerated]
	private readonly InheritanceLevel <InheritanceLevel>k__BackingField; // 0x10

	// Properties
	public InheritanceLevel InheritanceLevel { get; }

	// Methods

	// RVA: 0xC23480 Offset: 0xC21E80 VA: 0x180C23480
	public void .ctor(InheritanceLevel inheritanceLevel) { }

	[CompilerGenerated]
	// RVA: 0x43C220 Offset: 0x43AC20 VA: 0x18043C220
	public InheritanceLevel get_InheritanceLevel() { }

	// RVA: 0x26690E0 Offset: 0x2667AE0 VA: 0x1826690E0 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x263FCC0 Offset: 0x263E6C0 VA: 0x18263FCC0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2669180 Offset: 0x2667B80 VA: 0x182669180 Slot: 6
	public override bool IsDefaultAttribute() { }

	// RVA: 0x26691F0 Offset: 0x2667BF0 VA: 0x1826691F0 Slot: 3
	public override string ToString() { }

	// RVA: 0x26692D0 Offset: 0x2667CD0 VA: 0x1826692D0
	private static void .cctor() { }
}

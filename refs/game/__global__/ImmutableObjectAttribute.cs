public sealed class ImmutableObjectAttribute : Attribute // TypeDefIndex: 9671
{
	// Fields
	public static readonly ImmutableObjectAttribute Yes; // 0x0
	public static readonly ImmutableObjectAttribute No; // 0x8
	public static readonly ImmutableObjectAttribute Default; // 0x10
	[CompilerGenerated]
	private readonly bool <Immutable>k__BackingField; // 0x10

	// Properties
	public bool Immutable { get; }

	// Methods

	// RVA: 0x1B5FE70 Offset: 0x1B5E870 VA: 0x181B5FE70
	public void .ctor(bool immutable) { }

	[CompilerGenerated]
	// RVA: 0x498A40 Offset: 0x497440 VA: 0x180498A40
	public bool get_Immutable() { }

	// RVA: 0x2647840 Offset: 0x2646240 VA: 0x182647840 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x263FCC0 Offset: 0x263E6C0 VA: 0x18263FCC0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2647900 Offset: 0x2646300 VA: 0x182647900 Slot: 6
	public override bool IsDefaultAttribute() { }

	// RVA: 0x2647970 Offset: 0x2646370 VA: 0x182647970
	private static void .cctor() { }
}

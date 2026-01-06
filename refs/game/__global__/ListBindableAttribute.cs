public sealed class ListBindableAttribute : Attribute // TypeDefIndex: 9732
{
	// Fields
	public static readonly ListBindableAttribute Yes; // 0x0
	public static readonly ListBindableAttribute No; // 0x8
	public static readonly ListBindableAttribute Default; // 0x10
	private bool _isDefault; // 0x10
	[CompilerGenerated]
	private readonly bool <ListBindable>k__BackingField; // 0x11

	// Properties
	public bool ListBindable { get; }

	// Methods

	// RVA: 0x2669B60 Offset: 0x2668560 VA: 0x182669B60
	public void .ctor(bool listBindable) { }

	[CompilerGenerated]
	// RVA: 0x498A50 Offset: 0x497450 VA: 0x180498A50
	public bool get_ListBindable() { }

	// RVA: 0x2669980 Offset: 0x2668380 VA: 0x182669980 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x263FCC0 Offset: 0x263E6C0 VA: 0x18263FCC0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2669A00 Offset: 0x2668400 VA: 0x182669A00 Slot: 6
	public override bool IsDefaultAttribute() { }

	// RVA: 0x2669A80 Offset: 0x2668480 VA: 0x182669A80
	private static void .cctor() { }
}

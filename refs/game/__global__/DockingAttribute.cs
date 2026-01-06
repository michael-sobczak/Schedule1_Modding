public sealed class DockingAttribute : Attribute // TypeDefIndex: 5312
{
	// Fields
	private DockingBehavior dockingBehavior; // 0x10
	public static readonly DockingAttribute Default; // 0x0

	// Properties
	public DockingBehavior DockingBehavior { get; }

	// Methods

	// RVA: 0x21C0260 Offset: 0x21BEC60 VA: 0x1821C0260
	public void .ctor() { }

	// RVA: 0xC23480 Offset: 0xC21E80 VA: 0x180C23480
	public void .ctor(DockingBehavior dockingBehavior) { }

	// RVA: 0x23155E0 Offset: 0x2313FE0 VA: 0x1823155E0
	private static void .cctor() { }

	// RVA: 0x43C220 Offset: 0x43AC20 VA: 0x18043C220
	public DockingBehavior get_DockingBehavior() { }

	// RVA: 0x2315420 Offset: 0x2313E20 VA: 0x182315420 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x23154B0 Offset: 0x2313EB0 VA: 0x1823154B0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2315500 Offset: 0x2313F00 VA: 0x182315500 Slot: 6
	public override bool IsDefaultAttribute() { }
}

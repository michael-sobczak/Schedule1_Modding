public sealed class NotifyParentPropertyAttribute : Attribute // TypeDefIndex: 9815
{
	// Fields
	public static readonly NotifyParentPropertyAttribute Yes; // 0x0
	public static readonly NotifyParentPropertyAttribute No; // 0x8
	public static readonly NotifyParentPropertyAttribute Default; // 0x10
	private bool notifyParent; // 0x10

	// Properties
	public bool NotifyParent { get; }

	// Methods

	// RVA: 0x1B5FE70 Offset: 0x1B5E870 VA: 0x181B5FE70
	public void .ctor(bool notifyParent) { }

	// RVA: 0x498A40 Offset: 0x497440 VA: 0x180498A40
	public bool get_NotifyParent() { }

	// RVA: 0x2680620 Offset: 0x267F020 VA: 0x182680620 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x263FCC0 Offset: 0x263E6C0 VA: 0x18263FCC0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x26806C0 Offset: 0x267F0C0 VA: 0x1826806C0 Slot: 6
	public override bool IsDefaultAttribute() { }

	// RVA: 0x2680730 Offset: 0x267F130 VA: 0x182680730
	private static void .cctor() { }
}

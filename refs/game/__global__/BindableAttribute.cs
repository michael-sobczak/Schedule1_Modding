public sealed class BindableAttribute : Attribute // TypeDefIndex: 9686
{
	// Fields
	public static readonly BindableAttribute Yes; // 0x0
	public static readonly BindableAttribute No; // 0x8
	public static readonly BindableAttribute Default; // 0x10
	private bool _isDefault; // 0x10
	[CompilerGenerated]
	private readonly bool <Bindable>k__BackingField; // 0x11
	[CompilerGenerated]
	private readonly BindingDirection <Direction>k__BackingField; // 0x14

	// Properties
	public bool Bindable { get; }

	// Methods

	// RVA: 0x2643100 Offset: 0x2641B00 VA: 0x182643100
	public void .ctor(bool bindable) { }

	// RVA: 0x26430C0 Offset: 0x2641AC0 VA: 0x1826430C0
	public void .ctor(bool bindable, BindingDirection direction) { }

	[CompilerGenerated]
	// RVA: 0x498A50 Offset: 0x497450 VA: 0x180498A50
	public bool get_Bindable() { }

	// RVA: 0x2642E50 Offset: 0x2641850 VA: 0x182642E50 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2642EF0 Offset: 0x26418F0 VA: 0x182642EF0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2642F50 Offset: 0x2641950 VA: 0x182642F50 Slot: 6
	public override bool IsDefaultAttribute() { }

	// RVA: 0x2642FD0 Offset: 0x26419D0 VA: 0x182642FD0
	private static void .cctor() { }
}

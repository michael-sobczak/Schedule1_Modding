public class ListChangedEventArgs : EventArgs // TypeDefIndex: 9733
{
	// Fields
	[CompilerGenerated]
	private readonly ListChangedType <ListChangedType>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly int <NewIndex>k__BackingField; // 0x14
	[CompilerGenerated]
	private readonly int <OldIndex>k__BackingField; // 0x18
	[CompilerGenerated]
	private readonly PropertyDescriptor <PropertyDescriptor>k__BackingField; // 0x20

	// Properties
	public ListChangedType ListChangedType { get; }
	public int NewIndex { get; }
	public int OldIndex { get; }

	// Methods

	// RVA: 0x2669C90 Offset: 0x2668690 VA: 0x182669C90
	public void .ctor(ListChangedType listChangedType, int newIndex) { }

	// RVA: 0x2669D00 Offset: 0x2668700 VA: 0x182669D00
	public void .ctor(ListChangedType listChangedType, int newIndex, PropertyDescriptor propDesc) { }

	// RVA: 0x2669B90 Offset: 0x2668590 VA: 0x182669B90
	public void .ctor(ListChangedType listChangedType, PropertyDescriptor propDesc) { }

	// RVA: 0x2669C10 Offset: 0x2668610 VA: 0x182669C10
	public void .ctor(ListChangedType listChangedType, int newIndex, int oldIndex) { }

	[CompilerGenerated]
	// RVA: 0x43C220 Offset: 0x43AC20 VA: 0x18043C220
	public ListChangedType get_ListChangedType() { }

	[CompilerGenerated]
	// RVA: 0x498A70 Offset: 0x497470 VA: 0x180498A70
	public int get_NewIndex() { }

	[CompilerGenerated]
	// RVA: 0x456E90 Offset: 0x455890 VA: 0x180456E90
	public int get_OldIndex() { }
}

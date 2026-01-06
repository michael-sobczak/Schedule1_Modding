public class CollectionChangeEventArgs : EventArgs // TypeDefIndex: 9693
{
	// Fields
	[CompilerGenerated]
	private readonly CollectionChangeAction <Action>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly object <Element>k__BackingField; // 0x18

	// Properties
	public virtual CollectionChangeAction Action { get; }
	public virtual object Element { get; }

	// Methods

	// RVA: 0x2643C90 Offset: 0x2642690 VA: 0x182643C90
	public void .ctor(CollectionChangeAction action, object element) { }

	[CompilerGenerated]
	// RVA: 0x43C220 Offset: 0x43AC20 VA: 0x18043C220 Slot: 4
	public virtual CollectionChangeAction get_Action() { }

	[CompilerGenerated]
	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0 Slot: 5
	public virtual object get_Element() { }
}

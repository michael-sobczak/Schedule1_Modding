public class BindingsCollection : BaseCollection // TypeDefIndex: 5246
{
	// Fields
	private CollectionChangeEventHandler CollectionChanged; // 0x20
	private CollectionChangeEventHandler CollectionChanging; // 0x28

	// Properties
	public override int Count { get; }
	public Binding Item { get; }
	protected override ArrayList List { get; }

	// Methods

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	internal void .ctor() { }

	// RVA: 0x207E3E0 Offset: 0x207CDE0 VA: 0x18207E3E0 Slot: 11
	public override int get_Count() { }

	// RVA: 0x21C7070 Offset: 0x21C5A70 VA: 0x1821C7070
	public Binding get_Item(int index) { }

	// RVA: 0x21C38C0 Offset: 0x21C22C0 VA: 0x1821C38C0 Slot: 12
	protected override ArrayList get_List() { }

	// RVA: 0x1DBFC40 Offset: 0x1DBE640 VA: 0x181DBFC40
	protected internal void Add(Binding binding) { }

	// RVA: 0x21C6EA0 Offset: 0x21C58A0 VA: 0x1821C6EA0 Slot: 13
	protected virtual void AddCore(Binding dataBinding) { }

	// RVA: 0x21C7010 Offset: 0x21C5A10 VA: 0x1821C7010 Slot: 14
	protected virtual void OnCollectionChanged(CollectionChangeEventArgs ccevent) { }

	// RVA: 0x21C7040 Offset: 0x21C5A40 VA: 0x1821C7040 Slot: 15
	protected virtual void OnCollectionChanging(CollectionChangeEventArgs e) { }

	// RVA: 0x21C6FC0 Offset: 0x21C59C0 VA: 0x1821C6FC0
	internal bool Contains(Binding binding) { }
}

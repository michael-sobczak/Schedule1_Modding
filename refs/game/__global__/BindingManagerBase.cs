public abstract class BindingManagerBase // TypeDefIndex: 5244
{
	// Fields
	private BindingsCollection bindings; // 0x10
	internal bool transfering_data; // 0x18
	protected EventHandler onCurrentChangedHandler; // 0x20
	protected EventHandler onPositionChangedHandler; // 0x28
	internal EventHandler onCurrentItemChangedHandler; // 0x30

	// Properties
	public BindingsCollection Bindings { get; }
	public abstract int Count { get; }
	public abstract object Current { get; }
	public abstract int Position { get; set; }
	internal virtual bool IsSuspended { get; }

	// Methods

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }

	// RVA: 0x21C4940 Offset: 0x21C3340 VA: 0x1821C4940
	public void add_PositionChanged(EventHandler value) { }

	// RVA: 0x21C4A50 Offset: 0x21C3450 VA: 0x1821C4A50
	public void remove_PositionChanged(EventHandler value) { }

	// RVA: 0x21C49E0 Offset: 0x21C33E0 VA: 0x1821C49E0
	public BindingsCollection get_Bindings() { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract int get_Count();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract object get_Current();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract int get_Position();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void set_Position(int value);

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void EndCurrentEdit();

	// RVA: 0x6FDC50 Offset: 0x6FC650 VA: 0x1806FDC50 Slot: 9
	public virtual PropertyDescriptorCollection GetItemProperties() { }

	// RVA: 0x21C4300 Offset: 0x21C2D00 VA: 0x1821C4300 Slot: 10
	internal virtual PropertyDescriptorCollection GetItemPropertiesInternal() { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 11
	internal virtual bool get_IsSuspended() { }

	// RVA: -1 Offset: -1 Slot: 12
	protected internal abstract void OnCurrentChanged(EventArgs e);

	// RVA: 0x21C4340 Offset: 0x21C2D40 VA: 0x1821C4340
	protected void PullData() { }

	// RVA: 0x21C4640 Offset: 0x21C3040 VA: 0x1821C4640
	protected void PushData() { }

	// RVA: -1 Offset: -1 Slot: 13
	protected abstract void OnCurrentItemChanged(EventArgs e);

	// RVA: -1 Offset: -1 Slot: 14
	protected abstract void UpdateIsBinding();

	// RVA: 0x21C4220 Offset: 0x21C2C20 VA: 0x1821C4220
	internal void AddBinding(Binding binding) { }
}

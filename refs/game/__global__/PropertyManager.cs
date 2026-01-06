public class PropertyManager : BindingManagerBase // TypeDefIndex: 5538
{
	// Fields
	internal string property_name; // 0x38
	private PropertyDescriptor prop_desc; // 0x40
	private object data_source; // 0x48
	private EventDescriptor changed_event; // 0x50
	private EventHandler property_value_changed_handler; // 0x58

	// Properties
	public override object Current { get; }
	public override int Position { get; set; }
	public override int Count { get; }
	internal override bool IsSuspended { get; }

	// Methods

	// RVA: 0xA955C0 Offset: 0xA93FC0 VA: 0x180A955C0
	public void .ctor() { }

	// RVA: 0x23A5E60 Offset: 0x23A4860 VA: 0x1823A5E60
	internal void .ctor(object data_source) { }

	// RVA: 0x23A5C80 Offset: 0x23A4680 VA: 0x1823A5C80
	internal void SetDataSource(object new_data_source) { }

	// RVA: 0x23A5C60 Offset: 0x23A4660 VA: 0x1823A5C60
	private void PropertyValueChanged(object sender, EventArgs args) { }

	// RVA: 0x23A5E90 Offset: 0x23A4890 VA: 0x1823A5E90 Slot: 5
	public override object get_Current() { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 6
	public override int get_Position() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 7
	public override void set_Position(int value) { }

	// RVA: 0x570B50 Offset: 0x56F550 VA: 0x180570B50 Slot: 4
	public override int get_Count() { }

	// RVA: 0x23A5B10 Offset: 0x23A4510 VA: 0x1823A5B10 Slot: 8
	public override void EndCurrentEdit() { }

	// RVA: 0x23A5B80 Offset: 0x23A4580 VA: 0x1823A5B80 Slot: 10
	internal override PropertyDescriptorCollection GetItemPropertiesInternal() { }

	// RVA: 0x23A5EC0 Offset: 0x23A48C0 VA: 0x1823A5EC0 Slot: 11
	internal override bool get_IsSuspended() { }

	[MonoTODO("Stub, does nothing")]
	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 14
	protected override void UpdateIsBinding() { }

	// RVA: 0x23A5BD0 Offset: 0x23A45D0 VA: 0x1823A5BD0 Slot: 12
	protected internal override void OnCurrentChanged(EventArgs ea) { }

	// RVA: 0x23A5C20 Offset: 0x23A4620 VA: 0x1823A5C20 Slot: 13
	protected override void OnCurrentItemChanged(EventArgs ea) { }
}

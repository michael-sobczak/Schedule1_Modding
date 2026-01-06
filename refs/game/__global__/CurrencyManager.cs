public class CurrencyManager : BindingManagerBase // TypeDefIndex: 5298
{
	// Fields
	protected int listposition; // 0x38
	protected Type finalType; // 0x40
	private IList list; // 0x48
	private bool binding_suspended; // 0x50
	private object data_source; // 0x58
	private bool editing; // 0x60
	private ListChangedEventHandler ListChanged; // 0x68
	private ItemChangedEventHandler ItemChanged; // 0x70
	private EventHandler MetaDataChanged; // 0x78

	// Properties
	public IList List { get; }
	public override object Current { get; }
	public override int Count { get; }
	public override int Position { get; set; }
	internal override bool IsSuspended { get; }

	// Methods

	// RVA: 0x230ED60 Offset: 0x230D760 VA: 0x18230ED60
	internal void .ctor(object data_source) { }

	// RVA: 0x230ED90 Offset: 0x230D790 VA: 0x18230ED90
	public void add_ItemChanged(ItemChangedEventHandler value) { }

	// RVA: 0x230F010 Offset: 0x230DA10 VA: 0x18230F010
	public void remove_ItemChanged(ItemChangedEventHandler value) { }

	// RVA: 0x4C1D80 Offset: 0x4C0780 VA: 0x1804C1D80
	public IList get_List() { }

	// RVA: 0x230EE80 Offset: 0x230D880 VA: 0x18230EE80 Slot: 5
	public override object get_Current() { }

	// RVA: 0x230EE30 Offset: 0x230D830 VA: 0x18230EE30 Slot: 4
	public override int get_Count() { }

	// RVA: 0x495F50 Offset: 0x494950 VA: 0x180495F50 Slot: 6
	public override int get_Position() { }

	// RVA: 0x230F0B0 Offset: 0x230DAB0 VA: 0x18230F0B0 Slot: 7
	public override void set_Position(int value) { }

	// RVA: 0x230E6B0 Offset: 0x230D0B0 VA: 0x18230E6B0
	internal void SetDataSource(object data_source) { }

	// RVA: 0x230DFB0 Offset: 0x230C9B0 VA: 0x18230DFB0 Slot: 9
	public override PropertyDescriptorCollection GetItemProperties() { }

	// RVA: 0x230EFD0 Offset: 0x230D9D0 VA: 0x18230EFD0 Slot: 11
	internal override bool get_IsSuspended() { }

	// RVA: 0x230DC60 Offset: 0x230C660 VA: 0x18230DC60
	private void BeginEdit() { }

	// RVA: 0x230DE20 Offset: 0x230C820 VA: 0x18230DE20 Slot: 8
	public override void EndCurrentEdit() { }

	// RVA: 0x230E580 Offset: 0x230CF80 VA: 0x18230E580 Slot: 12
	protected internal override void OnCurrentChanged(EventArgs e) { }

	// RVA: 0x230E5E0 Offset: 0x230CFE0 VA: 0x18230E5E0 Slot: 13
	protected override void OnCurrentItemChanged(EventArgs e) { }

	// RVA: 0x230E610 Offset: 0x230D010 VA: 0x18230E610 Slot: 15
	protected virtual void OnItemChanged(ItemChangedEventArgs e) { }

	// RVA: 0x230E650 Offset: 0x230D050 VA: 0x18230E650
	private void OnListChanged(ListChangedEventArgs args) { }

	// RVA: 0x21C7040 Offset: 0x21C5A40 VA: 0x1821C7040 Slot: 16
	protected virtual void OnPositionChanged(EventArgs e) { }

	// RVA: 0x230E9E0 Offset: 0x230D3E0 VA: 0x18230E9E0 Slot: 14
	protected override void UpdateIsBinding() { }

	// RVA: 0x230DCD0 Offset: 0x230C6D0 VA: 0x18230DCD0
	private void ChangeRecordState(int newPosition, bool validating, bool endCurrentEdit, bool firePositionChanged, bool pullData) { }

	// RVA: 0x230ECE0 Offset: 0x230D6E0 VA: 0x18230ECE0
	private void UpdateItem() { }

	// RVA: 0x230E680 Offset: 0x230D080 VA: 0x18230E680
	protected void OnMetaDataChanged(EventArgs e) { }

	// RVA: 0x230DFC0 Offset: 0x230C9C0 VA: 0x18230DFC0
	private void ListChangedHandler(object sender, ListChangedEventArgs e) { }
}

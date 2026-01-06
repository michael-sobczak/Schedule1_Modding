public class DataRowView : ICustomTypeDescriptor, IEditableObject, INotifyPropertyChanged // TypeDefIndex: 12909
{
	// Fields
	private readonly DataView _dataView; // 0x10
	private readonly DataRow _row; // 0x18
	private bool _delayBeginEdit; // 0x20
	private static readonly PropertyDescriptorCollection s_zeroPropertyDescriptorCollection; // 0x0
	[CompilerGenerated]
	private PropertyChangedEventHandler PropertyChanged; // 0x28

	// Properties
	public DataView DataView { get; }
	private DataRowVersion RowVersionDefault { get; }
	public DataRow Row { get; }
	public bool IsNew { get; }

	// Methods

	// RVA: 0x5CC320 Offset: 0x5CAD20 VA: 0x1805CC320
	internal void .ctor(DataView dataView, DataRow row) { }

	// RVA: 0xC7C1F0 Offset: 0xC7ABF0 VA: 0x180C7C1F0 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x20749B0 Offset: 0x20733B0 VA: 0x1820749B0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	public DataView get_DataView() { }

	// RVA: 0x2074F10 Offset: 0x2073910 VA: 0x182074F10
	private DataRowVersion get_RowVersionDefault() { }

	// RVA: 0x20749E0 Offset: 0x20733E0 VA: 0x1820749E0
	internal int GetRecord() { }

	// RVA: 0x2074A60 Offset: 0x2073460 VA: 0x182074A60
	internal bool HasRecord() { }

	// RVA: 0x2074890 Offset: 0x2073290 VA: 0x182074890
	internal object GetColumnValue(DataColumn column) { }

	// RVA: 0x2074B70 Offset: 0x2073570 VA: 0x182074B70
	internal void SetColumnValue(DataColumn column, object value) { }

	// RVA: 0x20745F0 Offset: 0x2072FF0 VA: 0x1820745F0
	public DataView CreateChildView(DataRelation relation, bool followParent) { }

	// RVA: 0x2074820 Offset: 0x2073220 VA: 0x182074820
	public DataView CreateChildView(DataRelation relation) { }

	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	public DataRow get_Row() { }

	// RVA: 0x77D420 Offset: 0x77BE20 VA: 0x18077D420 Slot: 16
	public void BeginEdit() { }

	// RVA: 0x2074830 Offset: 0x2073230 VA: 0x182074830 Slot: 17
	public void EndEdit() { }

	// RVA: 0x2074EE0 Offset: 0x20738E0 VA: 0x182074EE0
	public bool get_IsNew() { }

	// RVA: 0x2074AE0 Offset: 0x20734E0 VA: 0x182074AE0
	internal void RaisePropertyChangedEvent(string propName) { }

	// RVA: 0x2074C30 Offset: 0x2073630 VA: 0x182074C30 Slot: 4
	private AttributeCollection System.ComponentModel.ICustomTypeDescriptor.GetAttributes() { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 5
	private string System.ComponentModel.ICustomTypeDescriptor.GetClassName() { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 6
	private string System.ComponentModel.ICustomTypeDescriptor.GetComponentName() { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 7
	private TypeConverter System.ComponentModel.ICustomTypeDescriptor.GetConverter() { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 8
	private EventDescriptor System.ComponentModel.ICustomTypeDescriptor.GetDefaultEvent() { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 9
	private PropertyDescriptor System.ComponentModel.ICustomTypeDescriptor.GetDefaultProperty() { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 10
	private object System.ComponentModel.ICustomTypeDescriptor.GetEditor(Type editorBaseType) { }

	// RVA: 0x2074C80 Offset: 0x2073680 VA: 0x182074C80 Slot: 11
	private EventDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetEvents() { }

	// RVA: 0x2074CD0 Offset: 0x20736D0 VA: 0x182074CD0 Slot: 12
	private EventDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetEvents(Attribute[] attributes) { }

	// RVA: 0x2074DB0 Offset: 0x20737B0 VA: 0x182074DB0 Slot: 13
	private PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties() { }

	// RVA: 0x2074D20 Offset: 0x2073720 VA: 0x182074D20 Slot: 14
	private PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties(Attribute[] attributes) { }

	// RVA: 0xBB7DD0 Offset: 0xBB67D0 VA: 0x180BB7DD0 Slot: 15
	private object System.ComponentModel.ICustomTypeDescriptor.GetPropertyOwner(PropertyDescriptor pd) { }

	// RVA: 0x2074E60 Offset: 0x2073860 VA: 0x182074E60
	private static void .cctor() { }
}

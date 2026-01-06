public class Binding // TypeDefIndex: 5238
{
	// Fields
	private string property_name; // 0x10
	private object data_source; // 0x18
	private string data_member; // 0x20
	private bool is_binding; // 0x28
	private bool checked_isnull; // 0x29
	private BindingMemberInfo binding_member_info; // 0x30
	private IBindableComponent control; // 0x48
	private BindingManagerBase manager; // 0x50
	private PropertyDescriptor control_property; // 0x58
	private PropertyDescriptor is_null_desc; // 0x60
	private object data; // 0x68
	private Type data_type; // 0x70
	private DataSourceUpdateMode datasource_update_mode; // 0x78
	private ControlUpdateMode control_update_mode; // 0x7C
	private object datasource_null_value; // 0x80
	private object null_value; // 0x88
	private IFormatProvider format_info; // 0x90
	private string format_string; // 0x98
	private bool formatting_enabled; // 0xA0
	private ConvertEventHandler Format; // 0xA8
	private ConvertEventHandler Parse; // 0xB0
	private BindingCompleteEventHandler BindingComplete; // 0xB8

	// Properties
	[DefaultValue(null)]
	public IBindableComponent BindableComponent { get; }
	[DefaultValue(null)]
	public Control Control { get; }
	public bool IsBinding { get; }
	[DefaultValue("")]
	public string PropertyName { get; }

	// Methods

	// RVA: 0x21C6B00 Offset: 0x21C5500 VA: 0x1821C6B00
	public void .ctor(string propertyName, object dataSource, string dataMember) { }

	// RVA: 0x21C6BA0 Offset: 0x21C55A0 VA: 0x1821C6BA0
	public void .ctor(string propertyName, object dataSource, string dataMember, bool formattingEnabled, DataSourceUpdateMode dataSourceUpdateMode, object nullValue, string formatString, IFormatProvider formatInfo) { }

	// RVA: 0x4C1D80 Offset: 0x4C0780 VA: 0x1804C1D80
	public IBindableComponent get_BindableComponent() { }

	// RVA: 0x21C6DE0 Offset: 0x21C57E0 VA: 0x1821C6DE0
	public Control get_Control() { }

	// RVA: 0x21C6E60 Offset: 0x21C5860 VA: 0x1821C6E60
	public bool get_IsBinding() { }

	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	public string get_PropertyName() { }

	// RVA: 0x21C5BE0 Offset: 0x21C45E0 VA: 0x1821C5BE0 Slot: 4
	protected virtual void OnBindingComplete(BindingCompleteEventArgs e) { }

	// RVA: 0x21C5C10 Offset: 0x21C4610 VA: 0x1821C5C10 Slot: 5
	protected virtual void OnFormat(ConvertEventArgs cevent) { }

	// RVA: 0x21C5C40 Offset: 0x21C4640 VA: 0x1821C5C40 Slot: 6
	protected virtual void OnParse(ConvertEventArgs cevent) { }

	// RVA: 0x21C65A0 Offset: 0x21C4FA0 VA: 0x1821C65A0
	internal void SetControl(IBindableComponent control) { }

	// RVA: 0x21C4D70 Offset: 0x21C3770 VA: 0x1821C4D70
	internal void Check() { }

	// RVA: 0x21C5EC0 Offset: 0x21C48C0 VA: 0x1821C5EC0
	internal bool PullData() { }

	// RVA: 0x21C5ED0 Offset: 0x21C48D0 VA: 0x1821C5ED0
	private bool PullData(bool force) { }

	// RVA: 0x21C6550 Offset: 0x21C4F50 VA: 0x1821C6550
	internal void PushData() { }

	// RVA: 0x21C6190 Offset: 0x21C4B90 VA: 0x1821C6190
	private void PushData(bool force) { }

	// RVA: 0x21C6A40 Offset: 0x21C5440 VA: 0x1821C6A40
	internal void UpdateIsBinding() { }

	// RVA: 0x21C6560 Offset: 0x21C4F60 VA: 0x1821C6560
	private void SetControlValue(object data) { }

	// RVA: 0x21C6900 Offset: 0x21C5300 VA: 0x1821C6900
	private void SetPropertyValue(object data) { }

	// RVA: 0x21C5330 Offset: 0x21C3D30 VA: 0x1821C5330
	private void ControlValidatingHandler(object sender, CancelEventArgs e) { }

	// RVA: 0x21C5300 Offset: 0x21C3D00 VA: 0x1821C5300
	private void ControlCreatedHandler(object o, EventArgs args) { }

	// RVA: 0x21C5E90 Offset: 0x21C4890 VA: 0x1821C5E90
	private void PositionChangedHandler(object sender, EventArgs e) { }

	// RVA: 0x21C5940 Offset: 0x21C4340 VA: 0x1821C5940
	private EventDescriptor GetPropertyChangedEvent(object o, string property_name) { }

	// RVA: 0x21C6550 Offset: 0x21C4F50 VA: 0x1821C6550
	private void SourcePropertyChangedHandler(object o, EventArgs args) { }

	// RVA: 0x21C5310 Offset: 0x21C3D10 VA: 0x1821C5310
	private void ControlPropertyChangedHandler(object o, EventArgs args) { }

	// RVA: 0x21C5C70 Offset: 0x21C4670 VA: 0x1821C5C70
	private object ParseData(object data, Type data_type) { }

	// RVA: 0x21C5650 Offset: 0x21C4050 VA: 0x1821C5650
	private object FormatData(object data) { }

	// RVA: 0x21C5370 Offset: 0x21C3D70 VA: 0x1821C5370
	private object ConvertData(object data, Type data_type) { }

	// RVA: 0x21C5510 Offset: 0x21C3F10 VA: 0x1821C5510
	private void FireBindingComplete(BindingCompleteContext context, Exception exc, string error_message) { }
}

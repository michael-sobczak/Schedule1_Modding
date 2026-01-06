public abstract class ListControl : Control // TypeDefIndex: 5445
{
	// Fields
	private object data_source; // 0x1D8
	private BindingMemberInfo value_member; // 0x1E0
	private string display_member; // 0x1F8
	private CurrencyManager data_manager; // 0x200
	private BindingContext last_binding_context; // 0x208
	private IFormatProvider format_info; // 0x210
	private string format_string; // 0x218
	private bool formatting_enabled; // 0x220
	private static object DataSourceChangedEvent; // 0x0
	private static object DisplayMemberChangedEvent; // 0x8
	private static object FormatEvent; // 0x10
	private static object FormatInfoChangedEvent; // 0x18
	private static object FormatStringChangedEvent; // 0x20
	private static object FormattingEnabledChangedEvent; // 0x28
	private static object SelectedValueChangedEvent; // 0x30
	private static object ValueMemberChangedEvent; // 0x38

	// Properties
	[Browsable(False)]
	[DefaultValue(null)]
	[EditorBrowsable(2)]
	public IFormatProvider FormatInfo { get; }
	[DefaultValue("")]
	[MergableProperty(False)]
	[Editor("System.Windows.Forms.Design.FormatStringEditor, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
	public string FormatString { get; }
	[DefaultValue(False)]
	public bool FormattingEnabled { get; }
	[MWFCategory("Data")]
	[DefaultValue("")]
	[TypeConverter("System.Windows.Forms.Design.DataMemberFieldConverter, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
	[Editor("System.Windows.Forms.Design.DataMemberFieldEditor, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
	public string DisplayMember { get; }
	public abstract int SelectedIndex { get; set; }
	protected virtual bool AllowSelection { get; }
	internal override bool ScaleChildrenInternal { get; }
	protected CurrencyManager DataManager { get; }

	// Methods

	// RVA: 0x235D930 Offset: 0x235C330 VA: 0x18235D930
	protected void .ctor() { }

	// RVA: 0x235D6D0 Offset: 0x235C0D0 VA: 0x18235D6D0
	private static void .cctor() { }

	// RVA: 0x640D80 Offset: 0x63F780 VA: 0x180640D80
	public IFormatProvider get_FormatInfo() { }

	// RVA: 0x640D70 Offset: 0x63F770 VA: 0x180640D70
	public string get_FormatString() { }

	// RVA: 0xA472E0 Offset: 0xA45CE0 VA: 0x180A472E0
	public bool get_FormattingEnabled() { }

	// RVA: 0x6410E0 Offset: 0x63FAE0 VA: 0x1806410E0
	public string get_DisplayMember() { }

	// RVA: -1 Offset: -1 Slot: 193
	public abstract int get_SelectedIndex();

	// RVA: -1 Offset: -1 Slot: 194
	public abstract void set_SelectedIndex(int value);

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0 Slot: 195
	protected virtual bool get_AllowSelection() { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 78
	internal override bool get_ScaleChildrenInternal() { }

	// RVA: 0x235CCD0 Offset: 0x235B6D0 VA: 0x18235CCD0
	protected object FilterItemOnProperty(object item, string field) { }

	// RVA: 0x235CE10 Offset: 0x235B810 VA: 0x18235CE10
	public string GetItemText(object item) { }

	// RVA: 0x2031380 Offset: 0x202FD80 VA: 0x182031380
	protected CurrencyManager get_DataManager() { }

	// RVA: 0x235D180 Offset: 0x235BB80 VA: 0x18235D180 Slot: 96
	protected override bool IsInputKey(Keys keyData) { }

	// RVA: 0x235D1E0 Offset: 0x235BBE0 VA: 0x18235D1E0 Slot: 118
	protected override void OnBindingContextChanged(EventArgs e) { }

	// RVA: 0x235D2E0 Offset: 0x235BCE0 VA: 0x18235D2E0 Slot: 196
	protected virtual void OnFormat(ListControlConvertEventArgs e) { }

	// RVA: 0x235D550 Offset: 0x235BF50 VA: 0x18235D550 Slot: 197
	protected virtual void OnSelectedIndexChanged(EventArgs e) { }

	// RVA: 0x235D5F0 Offset: 0x235BFF0 VA: 0x18235D5F0 Slot: 198
	protected virtual void OnSelectedValueChanged(EventArgs e) { }

	// RVA: -1 Offset: -1 Slot: 199
	protected abstract void RefreshItem(int index);

	// RVA: -1 Offset: -1 Slot: 200
	protected abstract void SetItemsCore(IList items);

	// RVA: 0x235CA90 Offset: 0x235B490 VA: 0x18235CA90
	private void ConnectToDataSource() { }

	// RVA: 0x235D3C0 Offset: 0x235BDC0 VA: 0x18235D3C0
	private void OnItemChanged(object sender, ItemChangedEventArgs e) { }

	// RVA: 0x235D4C0 Offset: 0x235BEC0 VA: 0x18235D4C0
	private void OnPositionChanged(object sender, EventArgs e) { }
}

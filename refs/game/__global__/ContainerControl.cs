public class ContainerControl : ScrollableControl, IContainerControl // TypeDefIndex: 5281
{
	// Fields
	private Control active_control; // 0x248
	private Control unvalidated_control; // 0x250
	private ArrayList pending_validation_chain; // 0x258
	internal bool auto_select_child; // 0x260
	private SizeF auto_scale_dimensions; // 0x264
	private AutoScaleMode auto_scale_mode; // 0x26C
	private bool auto_scale_mode_set; // 0x270
	private bool auto_scale_pending; // 0x271
	private bool is_auto_scaling; // 0x272
	internal bool validation_failed; // 0x273
	private AutoValidate auto_validate; // 0x274
	private static object OnValidateChanged; // 0x0

	// Properties
	[Browsable(False)]
	[DesignerSerializationVisibility(0)]
	public Control ActiveControl { get; set; }
	protected SizeF AutoScaleFactor { get; }
	[EditorBrowsable(2)]
	[DesignerSerializationVisibility(0)]
	[Browsable(False)]
	public AutoScaleMode AutoScaleMode { get; set; }
	[Browsable(False)]
	public override BindingContext BindingContext { get; set; }
	[Browsable(False)]
	[EditorBrowsable(2)]
	public SizeF CurrentAutoScaleDimensions { get; }
	[DesignerSerializationVisibility(0)]
	[Browsable(False)]
	public Form ParentForm { get; }
	protected override CreateParams CreateParams { get; }
	internal bool IsAutoScaling { get; }

	// Methods

	// RVA: 0x22ED940 Offset: 0x22EC340 VA: 0x1822ED940
	public void .ctor() { }

	// RVA: 0x22ED8C0 Offset: 0x22EC2C0 VA: 0x1822ED8C0
	private static void .cctor() { }

	// RVA: 0x8793A0 Offset: 0x877DA0 VA: 0x1808793A0 Slot: 197
	public Control get_ActiveControl() { }

	// RVA: 0x22EDE50 Offset: 0x22EC850 VA: 0x1822EDE50 Slot: 198
	public void set_ActiveControl(Control value) { }

	// RVA: 0x22EC6D0 Offset: 0x22EB0D0 VA: 0x1822EC6D0
	private Control PerformValidation(ContainerControl top_container, bool postpone_validation, ArrayList validation_chain, Control topmost_under_root) { }

	// RVA: 0x22EBB90 Offset: 0x22EA590 VA: 0x1822EBB90
	private void AddValidationChain(ContainerControl top_container, ArrayList validation_chain) { }

	// RVA: 0x22ED480 Offset: 0x22EBE80 VA: 0x1822ED480
	private bool ValidateControl(Control c) { }

	// RVA: 0x22EC100 Offset: 0x22EAB00 VA: 0x1822EC100
	private Control GetMostDeeplyNestedActiveControl(ContainerControl container) { }

	// RVA: 0x22EC0B0 Offset: 0x22EAAB0 VA: 0x1822EC0B0
	private Control GetCommonContainer(Control active_control, Control value) { }

	// RVA: 0x22ED200 Offset: 0x22EBC00 VA: 0x1822ED200
	internal void SendControlFocus(Control c) { }

	// RVA: 0x22EDAC0 Offset: 0x22EC4C0 VA: 0x1822EDAC0
	protected SizeF get_AutoScaleFactor() { }

	// RVA: 0x22EDB70 Offset: 0x22EC570 VA: 0x1822EDB70
	public AutoScaleMode get_AutoScaleMode() { }

	// RVA: 0x22EE5D0 Offset: 0x22ECFD0 VA: 0x1822EE5D0
	public void set_AutoScaleMode(AutoScaleMode value) { }

	// RVA: 0x22EDB80 Offset: 0x22EC580 VA: 0x1822EDB80 Slot: 47
	public override BindingContext get_BindingContext() { }

	// RVA: 0x2246B80 Offset: 0x2245580 VA: 0x182246B80 Slot: 48
	public override void set_BindingContext(BindingContext value) { }

	// RVA: 0x22EDC90 Offset: 0x22EC690 VA: 0x1822EDC90
	public SizeF get_CurrentAutoScaleDimensions() { }

	// RVA: 0x22EDDA0 Offset: 0x22EC7A0 VA: 0x1822EDDA0
	public Form get_ParentForm() { }

	// RVA: 0x226DCC0 Offset: 0x226C6C0 VA: 0x18226DCC0 Slot: 72
	protected override CreateParams get_CreateParams() { }

	// RVA: 0x22EC520 Offset: 0x22EAF20 VA: 0x1822EC520
	internal void PerformAutoScale(bool called_by_scale) { }

	// RVA: 0x22EC510 Offset: 0x22EAF10 VA: 0x1822EC510
	public void PerformAutoScale() { }

	// RVA: 0x22EC6B0 Offset: 0x22EB0B0 VA: 0x1822EC6B0
	internal void PerformDelayedAutoScale() { }

	// RVA: 0x22EDD90 Offset: 0x22EC790 VA: 0x1822EDD90
	internal bool get_IsAutoScaling() { }

	[EditorBrowsable(1)]
	[Browsable(False)]
	// RVA: 0x22ED460 Offset: 0x22EBE60 VA: 0x1822ED460 Slot: 199
	public virtual bool ValidateChildren() { }

	[EditorBrowsable(1)]
	[Browsable(False)]
	// RVA: 0x22ED280 Offset: 0x22EBC80 VA: 0x1822ED280 Slot: 200
	public virtual bool ValidateChildren(ValidationConstraints validationConstraints) { }

	[EditorBrowsable(2)]
	// RVA: 0x22EBDF0 Offset: 0x22EA7F0 VA: 0x1822EBDF0 Slot: 194
	protected override void AdjustFormScrollbars(bool displayScrollbars) { }

	// RVA: 0x21C7160 Offset: 0x21C5B60 VA: 0x1821C7160 Slot: 12
	protected override void Dispose(bool disposing) { }

	// RVA: 0x22EC1B0 Offset: 0x22EABB0 VA: 0x1822EC1B0
	private void OnControlRemoved(object sender, ControlEventArgs e) { }

	// RVA: 0x22EC230 Offset: 0x22EAC30 VA: 0x1822EC230 Slot: 126
	protected override void OnCreateControl() { }

	// RVA: 0x22EC930 Offset: 0x22EB330 VA: 0x1822EC930 Slot: 98
	protected override bool ProcessCmdKey(ref Message msg, Keys keyData) { }

	[EditorBrowsable(2)]
	// RVA: 0x22ECA20 Offset: 0x22EB420 VA: 0x1822ECA20 Slot: 99
	protected override bool ProcessDialogChar(char charCode) { }

	// RVA: 0x22ECAA0 Offset: 0x22EB4A0 VA: 0x1822ECAA0 Slot: 100
	protected override bool ProcessDialogKey(Keys keyData) { }

	// RVA: 0x22ECC60 Offset: 0x22EB660 VA: 0x1822ECC60 Slot: 104
	protected override bool ProcessMnemonic(char charCode) { }

	// RVA: 0x22ECD40 Offset: 0x22EB740 VA: 0x1822ECD40 Slot: 201
	protected virtual bool ProcessTabKey(bool forward) { }

	// RVA: 0x22ED090 Offset: 0x22EBA90 VA: 0x1822ED090 Slot: 107
	protected override void Select(bool directed, bool forward) { }

	[EditorBrowsable(2)]
	// RVA: 0x22ED890 Offset: 0x22EC290 VA: 0x1822ED890 Slot: 114
	protected override void WndProc(ref Message m) { }

	// RVA: 0x22EBE00 Offset: 0x22EA800 VA: 0x1822EBE00
	internal void ChildControlRemoved(Control control) { }

	// RVA: 0x22ECE10 Offset: 0x22EB810 VA: 0x1822ECE10
	private bool RemoveChildrenFromValidation(ArrayList validation_chain, Control c) { }

	// RVA: 0x22ED020 Offset: 0x22EBA20 VA: 0x1822ED020
	private bool RemoveFromValidationChain(ArrayList validation_chain, Control c) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 202
	internal virtual void CheckAcceptButton() { }

	// RVA: 0x22ED530 Offset: 0x22EBF30 VA: 0x1822ED530
	private bool ValidateNestedControls(Control c, ValidationConstraints constraints, bool recurse) { }

	// RVA: 0x22ED7D0 Offset: 0x22EC1D0 VA: 0x1822ED7D0
	private bool ValidateThisControl(Control c, ValidationConstraints constraints) { }

	// RVA: 0x22EC430 Offset: 0x22EAE30 VA: 0x1822EC430 Slot: 171
	protected override void OnParentChanged(EventArgs e) { }

	[EditorBrowsable(2)]
	// RVA: 0x22EC2A0 Offset: 0x22EACA0 VA: 0x1822EC2A0 Slot: 136
	protected override void OnFontChanged(EventArgs e) { }

	// RVA: 0x22EC420 Offset: 0x22EAE20 VA: 0x1822EC420 Slot: 148
	protected override void OnLayout(LayoutEventArgs e) { }
}

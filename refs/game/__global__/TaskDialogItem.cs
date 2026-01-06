public abstract class TaskDialogItem : Component // TypeDefIndex: 17307
{
	// Fields
	private TaskDialog _owner; // 0x28
	private int _id; // 0x30
	private bool _enabled; // 0x34
	private string _text; // 0x38
	private IContainer components; // 0x40

	// Properties
	[Browsable(False)]
	public TaskDialog Owner { get; set; }
	[Localizable(True)]
	[Description("The text of the item.")]
	[DefaultValue("")]
	[Category("Appearance")]
	public string Text { get; set; }
	[Category("Behavior")]
	[Description("Indicates whether the item is enabled.")]
	[DefaultValue(True)]
	public bool Enabled { get; set; }
	[Category("Data")]
	[Description("The id of the item.")]
	[DefaultValue(0)]
	internal virtual int Id { get; set; }
	protected abstract IEnumerable ItemCollection { get; }

	// Methods

	// RVA: 0x1E0DFC0 Offset: 0x1E0C9C0 VA: 0x181E0DFC0
	protected void .ctor() { }

	// RVA: 0x1E0DE20 Offset: 0x1E0C820 VA: 0x181E0DE20
	protected void .ctor(IContainer container) { }

	// RVA: 0x1E0DF00 Offset: 0x1E0C900 VA: 0x181E0DF00
	internal void .ctor(int id) { }

	// RVA: 0x1E0E080 Offset: 0x1E0CA80 VA: 0x181E0E080
	public TaskDialog get_Owner() { }

	// RVA: 0x1E0E140 Offset: 0x1E0CB40 VA: 0x181E0E140
	internal void set_Owner(TaskDialog value) { }

	// RVA: 0x1E0E090 Offset: 0x1E0CA90 VA: 0x181E0E090
	public string get_Text() { }

	// RVA: 0x1E0E180 Offset: 0x1E0CB80 VA: 0x181E0E180
	public void set_Text(string value) { }

	// RVA: 0x1E0E070 Offset: 0x1E0CA70 VA: 0x181E0E070
	public bool get_Enabled() { }

	// RVA: 0x1E0E0E0 Offset: 0x1E0CAE0 VA: 0x181E0E0E0
	public void set_Enabled(bool value) { }

	// RVA: 0x1E0CE80 Offset: 0x1E0B880 VA: 0x181E0CE80 Slot: 14
	internal virtual int get_Id() { }

	// RVA: 0x1E0E100 Offset: 0x1E0CB00 VA: 0x181E0E100 Slot: 15
	internal virtual void set_Id(int value) { }

	// RVA: 0x1E0DB50 Offset: 0x1E0C550 VA: 0x181E0DB50
	public void Click() { }

	// RVA: -1 Offset: -1 Slot: 16
	protected abstract IEnumerable get_ItemCollection();

	// RVA: 0x1E0DE00 Offset: 0x1E0C800 VA: 0x181E0DE00
	protected void UpdateOwner() { }

	// RVA: 0x1E0DB40 Offset: 0x1E0C540 VA: 0x181E0DB40 Slot: 17
	internal virtual void CheckDuplicate(TaskDialogItem itemToExclude) { }

	// RVA: 0x1E0D620 Offset: 0x1E0C020 VA: 0x181E0D620 Slot: 18
	internal virtual void AutoAssignId() { }

	// RVA: 0x1E0D8F0 Offset: 0x1E0C2F0 VA: 0x181E0D8F0
	private void CheckDuplicateId(TaskDialogItem itemToExclude, int id) { }

	// RVA: 0x1E0DCE0 Offset: 0x1E0C6E0 VA: 0x181E0DCE0 Slot: 12
	protected override void Dispose(bool disposing) { }

	// RVA: 0x1E0DDA0 Offset: 0x1E0C7A0 VA: 0x181E0DDA0
	private void InitializeComponent() { }
}

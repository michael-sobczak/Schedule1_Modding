internal class LabelEditTextBox : FixedSizeTextBox // TypeDefIndex: 5437
{
	// Fields
	private static object EditingCancelledEvent; // 0x0
	private static object EditingFinishedEvent; // 0x8

	// Methods

	// RVA: 0x234EB20 Offset: 0x234D520 VA: 0x18234EB20
	public void .ctor() { }

	// RVA: 0x234EA60 Offset: 0x234D460 VA: 0x18234EA60
	private static void .cctor() { }

	// RVA: 0x234EB30 Offset: 0x234D530 VA: 0x18234EB30
	public void add_EditingCancelled(EventHandler value) { }

	// RVA: 0x234EC50 Offset: 0x234D650 VA: 0x18234EC50
	public void remove_EditingCancelled(EventHandler value) { }

	// RVA: 0x234EBC0 Offset: 0x234D5C0 VA: 0x18234EBC0
	public void add_EditingFinished(EventHandler value) { }

	// RVA: 0x234ECE0 Offset: 0x234D6E0 VA: 0x18234ECE0
	public void remove_EditingFinished(EventHandler value) { }

	// RVA: 0x234E6E0 Offset: 0x234D0E0 VA: 0x18234E6E0 Slot: 96
	protected override bool IsInputKey(Keys key_data) { }

	// RVA: 0x234E8B0 Offset: 0x234D2B0 VA: 0x18234E8B0 Slot: 145
	protected override void OnKeyDown(KeyEventArgs e) { }

	// RVA: 0x234EA20 Offset: 0x234D420 VA: 0x18234EA20 Slot: 151
	protected override void OnLostFocus(EventArgs e) { }

	// RVA: 0x234E700 Offset: 0x234D100 VA: 0x18234E700
	protected void OnEditingCancelled(EventArgs e) { }

	// RVA: 0x234E7D0 Offset: 0x234D1D0 VA: 0x18234E7D0
	protected void OnEditingFinished(EventArgs e) { }
}

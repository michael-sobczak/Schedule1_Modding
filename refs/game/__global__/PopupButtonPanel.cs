internal class PopupButtonPanel : Control, IUpdateFolder // TypeDefIndex: 5332
{
	// Fields
	private PopupButtonPanel.PopupButton recentlyusedButton; // 0x1D8
	private PopupButtonPanel.PopupButton desktopButton; // 0x1E0
	private PopupButtonPanel.PopupButton personalButton; // 0x1E8
	private PopupButtonPanel.PopupButton mycomputerButton; // 0x1F0
	private PopupButtonPanel.PopupButton networkButton; // 0x1F8
	private PopupButtonPanel.PopupButton lastPopupButton; // 0x200
	private PopupButtonPanel.PopupButton focusButton; // 0x208
	private string currentPath; // 0x210
	private int currentFocusIndex; // 0x218
	private static object UIAFocusedItemChangedEvent; // 0x0
	private static object PDirectoryChangedEvent; // 0x8

	// Properties
	public string CurrentFolder { get; set; }

	// Methods

	// RVA: 0x231DC20 Offset: 0x231C620 VA: 0x18231DC20
	public void .ctor() { }

	// RVA: 0x231DB60 Offset: 0x231C560 VA: 0x18231DB60
	private static void .cctor() { }

	// RVA: 0x231EA40 Offset: 0x231D440 VA: 0x18231EA40
	public void add_DirectoryChanged(EventHandler value) { }

	// RVA: 0x231EAD0 Offset: 0x231D4D0 VA: 0x18231EAD0
	public void remove_DirectoryChanged(EventHandler value) { }

	// RVA: 0x231D510 Offset: 0x231BF10 VA: 0x18231D510
	private void OnClickButton(object sender, EventArgs e) { }

	// RVA: 0x231D940 Offset: 0x231C340 VA: 0x18231D940
	internal void OnUIAFocusedItemChanged() { }

	// RVA: 0x231EB60 Offset: 0x231D560 VA: 0x18231EB60 Slot: 193
	public void set_CurrentFolder(string value) { }

	// RVA: 0x640D80 Offset: 0x63F780 VA: 0x180640D80 Slot: 194
	public string get_CurrentFolder() { }

	// RVA: 0x231D860 Offset: 0x231C260 VA: 0x18231D860 Slot: 139
	protected override void OnGotFocus(EventArgs e) { }

	// RVA: 0x231D8E0 Offset: 0x231C2E0 VA: 0x18231D8E0 Slot: 151
	protected override void OnLostFocus(EventArgs e) { }

	// RVA: 0x231D270 Offset: 0x231BC70 VA: 0x18231D270 Slot: 96
	protected override bool IsInputKey(Keys key) { }

	// RVA: 0x231D2A0 Offset: 0x231BCA0 VA: 0x18231D2A0
	private void Key_Down(object sender, KeyEventArgs e) { }

	// RVA: 0x231DA40 Offset: 0x231C440 VA: 0x18231DA40
	internal void SetFocusButton(PopupButtonPanel.PopupButton button) { }
}

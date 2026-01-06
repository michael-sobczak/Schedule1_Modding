public class LabelEditEventArgs : EventArgs // TypeDefIndex: 5436
{
	// Fields
	private int item; // 0x10
	private string label; // 0x18
	private bool cancelEdit; // 0x20

	// Properties
	public bool CancelEdit { get; set; }
	public int Item { get; }
	public string Label { get; }

	// Methods

	// RVA: 0x234E600 Offset: 0x234D000 VA: 0x18234E600
	public void .ctor(int item) { }

	// RVA: 0x234E660 Offset: 0x234D060 VA: 0x18234E660
	public void .ctor(int item, string label) { }

	// RVA: 0x4945E0 Offset: 0x492FE0 VA: 0x1804945E0
	public bool get_CancelEdit() { }

	// RVA: 0x494600 Offset: 0x493000 VA: 0x180494600
	public void set_CancelEdit(bool value) { }

	// RVA: 0x43C220 Offset: 0x43AC20 VA: 0x18043C220
	public int get_Item() { }

	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	public string get_Label() { }

	// RVA: 0x43EFE0 Offset: 0x43D9E0 VA: 0x18043EFE0
	internal void SetLabel(string label) { }
}

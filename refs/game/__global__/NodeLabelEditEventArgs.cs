public class NodeLabelEditEventArgs : EventArgs // TypeDefIndex: 5521
{
	// Fields
	private TreeNode node; // 0x10
	private string label; // 0x18
	private bool cancel; // 0x20

	// Properties
	public bool CancelEdit { get; set; }
	public TreeNode Node { get; }
	public string Label { get; }

	// Methods

	// RVA: 0x239A450 Offset: 0x2398E50 VA: 0x18239A450
	public void .ctor(TreeNode node) { }

	// RVA: 0x239A4C0 Offset: 0x2398EC0 VA: 0x18239A4C0
	public void .ctor(TreeNode node, string label) { }

	// RVA: 0x4945E0 Offset: 0x492FE0 VA: 0x1804945E0
	public bool get_CancelEdit() { }

	// RVA: 0x239A550 Offset: 0x2398F50 VA: 0x18239A550
	public void set_CancelEdit(bool value) { }

	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	public TreeNode get_Node() { }

	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	public string get_Label() { }

	// RVA: 0x43EFE0 Offset: 0x43D9E0 VA: 0x18043EFE0
	internal void SetLabel(string label) { }
}

public class TreeViewEventArgs : EventArgs // TypeDefIndex: 5673
{
	// Fields
	private TreeNode node; // 0x10
	private TreeViewAction action; // 0x18

	// Properties
	public TreeNode Node { get; }

	// Methods

	// RVA: 0x226CF20 Offset: 0x226B920 VA: 0x18226CF20
	public void .ctor(TreeNode node) { }

	// RVA: 0x226CEA0 Offset: 0x226B8A0 VA: 0x18226CEA0
	public void .ctor(TreeNode node, TreeViewAction action) { }

	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	public TreeNode get_Node() { }
}

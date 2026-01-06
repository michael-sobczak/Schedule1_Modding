public class TreeViewCancelEventArgs : CancelEventArgs // TypeDefIndex: 5671
{
	// Fields
	private TreeNode node; // 0x18
	private TreeViewAction action; // 0x20

	// Properties
	public TreeNode Node { get; }

	// Methods

	// RVA: 0x226CE50 Offset: 0x226B850 VA: 0x18226CE50
	public void .ctor(TreeNode node, bool cancel, TreeViewAction action) { }

	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	public TreeNode get_Node() { }
}

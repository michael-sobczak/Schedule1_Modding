public class DrawTreeNodeEventArgs : EventArgs // TypeDefIndex: 5325
{
	// Fields
	private Rectangle bounds; // 0x10
	private bool draw_default; // 0x20
	private Graphics graphics; // 0x28
	private TreeNode node; // 0x30
	private TreeNodeStates state; // 0x38

	// Properties
	public bool DrawDefault { get; }

	// Methods

	// RVA: 0x23162B0 Offset: 0x2314CB0 VA: 0x1823162B0
	public void .ctor(Graphics graphics, TreeNode node, Rectangle bounds, TreeNodeStates state) { }

	// RVA: 0x4945E0 Offset: 0x492FE0 VA: 0x1804945E0
	public bool get_DrawDefault() { }
}

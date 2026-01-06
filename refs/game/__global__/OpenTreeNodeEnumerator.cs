internal class OpenTreeNodeEnumerator : IEnumerator // TypeDefIndex: 5524
{
	// Fields
	private TreeNode start; // 0x10
	private TreeNode current; // 0x18
	private bool started; // 0x20

	// Properties
	public object Current { get; }
	public TreeNode CurrentNode { get; }

	// Methods

	// RVA: 0x470220 Offset: 0x46EC20 VA: 0x180470220
	public void .ctor(TreeNode start) { }

	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0 Slot: 5
	public object get_Current() { }

	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	public TreeNode get_CurrentNode() { }

	// RVA: 0x239AB00 Offset: 0x2399500 VA: 0x18239AB00 Slot: 4
	public bool MoveNext() { }

	// RVA: 0x239AC10 Offset: 0x2399610 VA: 0x18239AC10
	public bool MovePrevious() { }

	// RVA: 0x77D410 Offset: 0x77BE10 VA: 0x18077D410 Slot: 6
	public void Reset() { }
}

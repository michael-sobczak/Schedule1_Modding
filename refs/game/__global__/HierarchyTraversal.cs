internal abstract class HierarchyTraversal // TypeDefIndex: 7157
{
	// Methods

	// RVA: 0x2E2EEF0 Offset: 0x2E2D8F0 VA: 0x182E2EEF0 Slot: 4
	public virtual void Traverse(VisualElement element) { }

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void TraverseRecursive(VisualElement element, int depth);

	// RVA: 0x2E2EE20 Offset: 0x2E2D820 VA: 0x182E2EE20
	protected void Recurse(VisualElement element, int depth) { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	protected void .ctor() { }
}

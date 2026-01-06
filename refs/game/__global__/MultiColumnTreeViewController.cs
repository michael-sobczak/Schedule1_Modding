public abstract class MultiColumnTreeViewController : BaseTreeViewController // TypeDefIndex: 6190
{
	// Fields
	private MultiColumnController m_ColumnController; // 0x58

	// Properties
	public MultiColumnController columnController { get; }
	internal MultiColumnCollectionHeader header { get; }

	// Methods

	// RVA: 0x4993C0 Offset: 0x497DC0 VA: 0x1804993C0
	public MultiColumnController get_columnController() { }

	// RVA: 0x2DB8F60 Offset: 0x2DB7960 VA: 0x182DB8F60
	internal MultiColumnCollectionHeader get_header() { }

	// RVA: 0x2DB8EA0 Offset: 0x2DB78A0 VA: 0x182DB8EA0
	protected void .ctor(Columns columns, SortColumnDescriptions sortDescriptions, List<SortColumnDescription> sortedColumns) { }

	// RVA: 0x2DB8CF0 Offset: 0x2DB76F0 VA: 0x182DB8CF0 Slot: 14
	internal override void InvokeMakeItem(ReusableCollectionItem reusableItem) { }

	// RVA: 0x2DB8E30 Offset: 0x2DB7830 VA: 0x182DB8E30 Slot: 18
	protected override VisualElement MakeItem() { }

	// RVA: 0x2DB8BC0 Offset: 0x2DB75C0 VA: 0x182DB8BC0 Slot: 19
	protected override void BindItem(VisualElement element, int index) { }

	// RVA: 0x2DB8E80 Offset: 0x2DB7880 VA: 0x182DB8E80 Slot: 20
	protected override void UnbindItem(VisualElement element, int index) { }

	// RVA: 0x2DB8C60 Offset: 0x2DB7660 VA: 0x182DB8C60 Slot: 21
	protected override void DestroyItem(VisualElement element) { }

	// RVA: 0x2DB8E50 Offset: 0x2DB7850 VA: 0x182DB8E50 Slot: 7
	protected override void PrepareView() { }

	// RVA: 0x2DB8C80 Offset: 0x2DB7680 VA: 0x182DB8C80 Slot: 8
	public override void Dispose() { }
}

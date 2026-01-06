public class MultiColumnListViewController : BaseListViewController // TypeDefIndex: 6189
{
	// Fields
	private MultiColumnController m_ColumnController; // 0x48

	// Properties
	public MultiColumnController columnController { get; }
	internal MultiColumnCollectionHeader header { get; }

	// Methods

	// RVA: 0x4C1D80 Offset: 0x4C0780 VA: 0x1804C1D80
	public MultiColumnController get_columnController() { }

	// RVA: 0x2DB8BB0 Offset: 0x2DB75B0 VA: 0x182DB8BB0
	internal MultiColumnCollectionHeader get_header() { }

	// RVA: 0x2DB8B10 Offset: 0x2DB7510 VA: 0x182DB8B10
	public void .ctor(Columns columns, SortColumnDescriptions sortDescriptions, List<SortColumnDescription> sortedColumns) { }

	// RVA: 0x2DB8660 Offset: 0x2DB7060 VA: 0x182DB8660 Slot: 14
	internal override void InvokeMakeItem(ReusableCollectionItem reusableItem) { }

	// RVA: 0x2DB88D0 Offset: 0x2DB72D0 VA: 0x182DB88D0 Slot: 18
	protected override VisualElement MakeItem() { }

	// RVA: 0x2DB8430 Offset: 0x2DB6E30 VA: 0x182DB8430 Slot: 19
	protected override void BindItem(VisualElement element, int index) { }

	// RVA: 0x2DB8A20 Offset: 0x2DB7420 VA: 0x182DB8A20 Slot: 20
	protected override void UnbindItem(VisualElement element, int index) { }

	// RVA: 0x2DB84D0 Offset: 0x2DB6ED0 VA: 0x182DB84D0 Slot: 21
	protected override void DestroyItem(VisualElement element) { }

	// RVA: 0x2DB88F0 Offset: 0x2DB72F0 VA: 0x182DB88F0 Slot: 7
	protected override void PrepareView() { }

	// RVA: 0x2DB84F0 Offset: 0x2DB6EF0 VA: 0x182DB84F0 Slot: 8
	public override void Dispose() { }

	// RVA: 0x2DB8A40 Offset: 0x2DB7440 VA: 0x182DB8A40
	private void UpdateReorderClassList() { }
}

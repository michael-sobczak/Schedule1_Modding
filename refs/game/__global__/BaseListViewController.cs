public abstract class BaseListViewController : CollectionViewController // TypeDefIndex: 6182
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private Action itemsSourceSizeChanged; // 0x30
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private Action<IEnumerable<int>> itemsAdded; // 0x38
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private Action<IEnumerable<int>> itemsRemoved; // 0x40

	// Properties
	protected BaseListView baseListView { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x2DAC290 Offset: 0x2DAAC90 VA: 0x182DAC290
	public void add_itemsSourceSizeChanged(Action value) { }

	[CompilerGenerated]
	// RVA: 0x2DAC510 Offset: 0x2DAAF10 VA: 0x182DAC510
	public void remove_itemsSourceSizeChanged(Action value) { }

	[CompilerGenerated]
	// RVA: 0x2DAC130 Offset: 0x2DAAB30 VA: 0x182DAC130
	public void add_itemsAdded(Action<IEnumerable<int>> value) { }

	[CompilerGenerated]
	// RVA: 0x2DAC3B0 Offset: 0x2DAADB0 VA: 0x182DAC3B0
	public void remove_itemsAdded(Action<IEnumerable<int>> value) { }

	[CompilerGenerated]
	// RVA: 0x2DAC1E0 Offset: 0x2DAABE0 VA: 0x182DAC1E0
	public void add_itemsRemoved(Action<IEnumerable<int>> value) { }

	[CompilerGenerated]
	// RVA: 0x2DAC460 Offset: 0x2DAAE60 VA: 0x182DAC460
	public void remove_itemsRemoved(Action<IEnumerable<int>> value) { }

	// RVA: 0x2DAC330 Offset: 0x2DAAD30 VA: 0x182DAC330
	protected BaseListView get_baseListView() { }

	// RVA: 0x2DAAF10 Offset: 0x2DA9910 VA: 0x182DAAF10 Slot: 14
	internal override void InvokeMakeItem(ReusableCollectionItem reusableItem) { }

	// RVA: 0x2DAB300 Offset: 0x2DA9D00 VA: 0x182DAB300
	internal void PostInitRegistration(ReusableListViewItem listItem) { }

	// RVA: 0x2DAAC80 Offset: 0x2DA9680 VA: 0x182DAAC80 Slot: 15
	internal override void InvokeBindItem(ReusableCollectionItem reusableItem, int index) { }

	// RVA: 0x1366110 Offset: 0x1364B10 VA: 0x181366110 Slot: 22
	public virtual bool NeedsDragHandle(int index) { }

	// RVA: 0x2DAA220 Offset: 0x2DA8C20 VA: 0x182DAA220 Slot: 23
	public virtual void AddItems(int itemCount) { }

	// RVA: 0x2DAB0C0 Offset: 0x2DA9AC0 VA: 0x182DAB0C0 Slot: 24
	public virtual void Move(int index, int newIndex) { }

	// RVA: 0x2DAB9B0 Offset: 0x2DAA3B0 VA: 0x182DAB9B0 Slot: 25
	public virtual void RemoveItem(int index) { }

	// RVA: 0x2DABCC0 Offset: 0x2DAA6C0 VA: 0x182DABCC0 Slot: 26
	public virtual void RemoveItems(List<int> indices) { }

	// RVA: 0x2DABB20 Offset: 0x2DAA520 VA: 0x182DABB20 Slot: 27
	internal virtual void RemoveItems(int itemCount) { }

	// RVA: 0x2DAAA40 Offset: 0x2DA9440 VA: 0x182DAAA40 Slot: 28
	public virtual void ClearItems() { }

	// RVA: 0x2DAB7F0 Offset: 0x2DAA1F0 VA: 0x182DAB7F0
	protected void RaiseOnSizeChanged() { }

	// RVA: 0x2DAB7D0 Offset: 0x2DAA1D0 VA: 0x182DAB7D0
	protected void RaiseItemsAdded(IEnumerable<int> indices) { }

	// RVA: 0xD3EE10 Offset: 0xD3D810 VA: 0x180D3EE10
	protected void RaiseItemsRemoved(IEnumerable<int> indices) { }

	// RVA: 0x2DAA910 Offset: 0x2DA9310 VA: 0x182DAA910
	private static Array AddToArray(Array source, int itemCount) { }

	// RVA: 0x2DAB810 Offset: 0x2DAA210 VA: 0x182DAB810
	private static Array RemoveFromArray(Array source, List<int> indicesToRemove) { }

	// RVA: 0x2DABF30 Offset: 0x2DAA930 VA: 0x182DABF30
	private void Swap(int lhs, int rhs) { }

	// RVA: 0x2DAAB60 Offset: 0x2DA9560 VA: 0x182DAAB60
	private void EnsureItemSourceCanBeResized() { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	protected void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x2DAC070 Offset: 0x2DAAA70 VA: 0x182DAC070
	internal static bool <AddItems>g__IsGenericList|15_0(Type t) { }
}

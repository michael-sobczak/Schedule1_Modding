public abstract class CollectionViewController : IDisposable // TypeDefIndex: 6185
{
	// Fields
	private BaseVerticalCollectionView m_View; // 0x10
	private IList m_ItemsSource; // 0x18
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private Action itemsSourceChanged; // 0x20
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private Action<int, int> itemIndexChanged; // 0x28

	// Properties
	public virtual IList itemsSource { get; set; }
	protected BaseVerticalCollectionView view { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x2DB5CB0 Offset: 0x2DB46B0 VA: 0x182DB5CB0
	public void add_itemsSourceChanged(Action value) { }

	[CompilerGenerated]
	// RVA: 0x2DB5E00 Offset: 0x2DB4800 VA: 0x182DB5E00
	public void remove_itemsSourceChanged(Action value) { }

	[CompilerGenerated]
	// RVA: 0x2DB5C00 Offset: 0x2DB4600 VA: 0x182DB5C00
	public void add_itemIndexChanged(Action<int, int> value) { }

	[CompilerGenerated]
	// RVA: 0x2DB5D50 Offset: 0x2DB4750 VA: 0x182DB5D50
	public void remove_itemIndexChanged(Action<int, int> value) { }

	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0 Slot: 5
	public virtual IList get_itemsSource() { }

	// RVA: 0x2DB5EA0 Offset: 0x2DB48A0 VA: 0x182DB5EA0 Slot: 6
	public virtual void set_itemsSource(IList value) { }

	// RVA: 0x43EFE0 Offset: 0x43D9E0 VA: 0x18043EFE0
	protected void SetItemsSourceWithoutNotify(IList source) { }

	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	protected BaseVerticalCollectionView get_view() { }

	// RVA: 0x2DB5B50 Offset: 0x2DB4550 VA: 0x182DB5B50
	public void SetView(BaseVerticalCollectionView collectionView) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 7
	protected virtual void PrepareView() { }

	// RVA: 0x2DB5830 Offset: 0x2DB4230 VA: 0x182DB5830 Slot: 8
	public virtual void Dispose() { }

	// RVA: 0x2DB5930 Offset: 0x2DB4330 VA: 0x182DB5930 Slot: 9
	public virtual int GetItemsCount() { }

	// RVA: 0x4BC030 Offset: 0x4BAA30 VA: 0x1804BC030 Slot: 10
	internal virtual int GetItemsMinCount() { }

	// RVA: 0x2DB5880 Offset: 0x2DB4280 VA: 0x182DB5880 Slot: 11
	public virtual int GetIndexForId(int id) { }

	// RVA: 0x2DB5880 Offset: 0x2DB4280 VA: 0x182DB5880 Slot: 12
	public virtual int GetIdForIndex(int index) { }

	// RVA: 0x2DB5890 Offset: 0x2DB4290 VA: 0x182DB5890 Slot: 13
	public virtual object GetItemForIndex(int index) { }

	// RVA: 0x2DB5AA0 Offset: 0x2DB44A0 VA: 0x182DB5AA0 Slot: 14
	internal virtual void InvokeMakeItem(ReusableCollectionItem reusableItem) { }

	// RVA: 0x2DB5980 Offset: 0x2DB4380 VA: 0x182DB5980 Slot: 15
	internal virtual void InvokeBindItem(ReusableCollectionItem reusableItem, int index) { }

	// RVA: 0x2DB5AF0 Offset: 0x2DB44F0 VA: 0x182DB5AF0 Slot: 16
	internal virtual void InvokeUnbindItem(ReusableCollectionItem reusableItem, int index) { }

	// RVA: 0x2DB5A70 Offset: 0x2DB4470 VA: 0x182DB5A70 Slot: 17
	internal virtual void InvokeDestroyItem(ReusableCollectionItem reusableItem) { }

	// RVA: -1 Offset: -1 Slot: 18
	protected abstract VisualElement MakeItem();

	// RVA: -1 Offset: -1 Slot: 19
	protected abstract void BindItem(VisualElement element, int index);

	// RVA: -1 Offset: -1 Slot: 20
	protected abstract void UnbindItem(VisualElement element, int index);

	// RVA: -1 Offset: -1 Slot: 21
	protected abstract void DestroyItem(VisualElement element);

	// RVA: 0x2DB5B30 Offset: 0x2DB4530 VA: 0x182DB5B30
	protected void RaiseItemsSourceChanged() { }

	// RVA: 0x2DB1CC0 Offset: 0x2DB06C0 VA: 0x182DB1CC0
	protected void RaiseItemIndexChanged(int srcIndex, int dstIndex) { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	protected void .ctor() { }
}

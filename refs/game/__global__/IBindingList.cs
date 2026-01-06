public interface IBindingList : IList, ICollection, IEnumerable // TypeDefIndex: 9720
{
	// Properties
	public abstract bool AllowNew { get; }
	public abstract bool AllowEdit { get; }
	public abstract bool AllowRemove { get; }
	public abstract bool SupportsChangeNotification { get; }
	public abstract bool SupportsSearching { get; }
	public abstract bool SupportsSorting { get; }
	public abstract bool IsSorted { get; }
	public abstract PropertyDescriptor SortProperty { get; }
	public abstract ListSortDirection SortDirection { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool get_AllowNew();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract object AddNew();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract bool get_AllowEdit();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract bool get_AllowRemove();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract bool get_SupportsChangeNotification();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract bool get_SupportsSearching();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract bool get_SupportsSorting();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract bool get_IsSorted();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract PropertyDescriptor get_SortProperty();

	// RVA: -1 Offset: -1 Slot: 9
	public abstract ListSortDirection get_SortDirection();

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 10
	public abstract void add_ListChanged(ListChangedEventHandler value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 11
	public abstract void remove_ListChanged(ListChangedEventHandler value);

	// RVA: -1 Offset: -1 Slot: 12
	public abstract void AddIndex(PropertyDescriptor property);

	// RVA: -1 Offset: -1 Slot: 13
	public abstract void ApplySort(PropertyDescriptor property, ListSortDirection direction);

	// RVA: -1 Offset: -1 Slot: 14
	public abstract int Find(PropertyDescriptor property, object key);

	// RVA: -1 Offset: -1 Slot: 15
	public abstract void RemoveIndex(PropertyDescriptor property);

	// RVA: -1 Offset: -1 Slot: 16
	public abstract void RemoveSort();
}

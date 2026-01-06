public abstract class DataRelationCollection : InternalDataCollectionBase // TypeDefIndex: 12896
{
	// Fields
	private DataRelation _inTransition; // 0x10
	private int _defaultNameIndex; // 0x18
	private CollectionChangeEventHandler _onCollectionChangedDelegate; // 0x20
	private CollectionChangeEventHandler _onCollectionChangingDelegate; // 0x28
	private static int s_objectTypeCount; // 0x0
	private readonly int _objectID; // 0x30

	// Properties
	internal int ObjectID { get; }
	public abstract DataRelation Item { get; }
	public abstract DataRelation Item { get; }

	// Methods

	// RVA: 0x4A7D90 Offset: 0x4A6790 VA: 0x1804A7D90
	internal int get_ObjectID() { }

	// RVA: -1 Offset: -1 Slot: 13
	public abstract DataRelation get_Item(int index);

	// RVA: -1 Offset: -1 Slot: 14
	public abstract DataRelation get_Item(string name);

	// RVA: 0x206ED20 Offset: 0x206D720 VA: 0x18206ED20
	public void Add(DataRelation relation) { }

	// RVA: 0x206EA00 Offset: 0x206D400 VA: 0x18206EA00 Slot: 15
	protected virtual void AddCore(DataRelation relation) { }

	// RVA: 0x206FE80 Offset: 0x206E880 VA: 0x18206FE80
	public void add_CollectionChanged(CollectionChangeEventHandler value) { }

	// RVA: 0x206FF90 Offset: 0x206E990 VA: 0x18206FF90
	public void remove_CollectionChanged(CollectionChangeEventHandler value) { }

	// RVA: 0x206EFD0 Offset: 0x206D9D0 VA: 0x18206EFD0
	internal string AssignName() { }

	// RVA: 0x206EFF0 Offset: 0x206D9F0 VA: 0x18206EFF0 Slot: 16
	public virtual void Clear() { }

	// RVA: 0x206F220 Offset: 0x206DC20 VA: 0x18206F220 Slot: 17
	public virtual bool Contains(string name) { }

	// RVA: 0x206F240 Offset: 0x206DC40 VA: 0x18206F240
	internal int InternalIndexOf(string name) { }

	// RVA: -1 Offset: -1 Slot: 18
	protected abstract DataSet GetDataSet();

	// RVA: 0x206F450 Offset: 0x206DE50 VA: 0x18206F450
	private string MakeName(int index) { }

	// RVA: 0x206F4F0 Offset: 0x206DEF0 VA: 0x18206F4F0 Slot: 19
	protected virtual void OnCollectionChanged(CollectionChangeEventArgs ccevent) { }

	// RVA: 0x206F5B0 Offset: 0x206DFB0 VA: 0x18206F5B0 Slot: 20
	protected virtual void OnCollectionChanging(CollectionChangeEventArgs ccevent) { }

	// RVA: 0x206F670 Offset: 0x206E070 VA: 0x18206F670
	internal void RegisterName(string name) { }

	// RVA: 0x206FAE0 Offset: 0x206E4E0 VA: 0x18206FAE0
	public void Remove(DataRelation relation) { }

	// RVA: 0x206F850 Offset: 0x206E250 VA: 0x18206F850
	public void RemoveAt(int index) { }

	// RVA: 0x206F8E0 Offset: 0x206E2E0 VA: 0x18206F8E0 Slot: 21
	protected virtual void RemoveCore(DataRelation relation) { }

	// RVA: 0x206FCC0 Offset: 0x206E6C0 VA: 0x18206FCC0
	internal void UnregisterName(string name) { }

	// RVA: 0x206FE00 Offset: 0x206E800 VA: 0x18206FE00
	protected void .ctor() { }
}

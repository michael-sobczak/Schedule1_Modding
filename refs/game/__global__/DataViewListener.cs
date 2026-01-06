internal sealed class DataViewListener // TypeDefIndex: 12921
{
	// Fields
	private readonly WeakReference _dvWeak; // 0x10
	private DataTable _table; // 0x18
	private Index _index; // 0x20
	internal readonly int _objectID; // 0x28

	// Methods

	// RVA: 0x208A220 Offset: 0x2088C20 VA: 0x18208A220
	internal void .ctor(DataView dv) { }

	// RVA: 0x2089460 Offset: 0x2087E60 VA: 0x182089460
	private void ChildRelationCollectionChanged(object sender, CollectionChangeEventArgs e) { }

	// RVA: 0x20898C0 Offset: 0x20882C0 VA: 0x1820898C0
	private void ParentRelationCollectionChanged(object sender, CollectionChangeEventArgs e) { }

	// RVA: 0x2089560 Offset: 0x2087F60 VA: 0x182089560
	private void ColumnCollectionChanged(object sender, CollectionChangeEventArgs e) { }

	// RVA: 0x20897D0 Offset: 0x20881D0 VA: 0x1820897D0
	internal void MaintainDataView(ListChangedType changedType, DataRow row, bool trackAddRemove) { }

	// RVA: 0x2089650 Offset: 0x2088050 VA: 0x182089650
	internal void IndexListChanged(ListChangedEventArgs e) { }

	// RVA: 0x2089C60 Offset: 0x2088660 VA: 0x182089C60
	internal void RegisterMetaDataEvents(DataTable table) { }

	// RVA: 0x208A210 Offset: 0x2088C10 VA: 0x18208A210
	internal void UnregisterMetaDataEvents() { }

	// RVA: 0x2089F60 Offset: 0x2088960 VA: 0x182089F60
	private void UnregisterMetaDataEvents(bool updateListeners) { }

	// RVA: 0x20899A0 Offset: 0x20883A0 VA: 0x1820899A0
	internal void RegisterListChangedEvent(Index index) { }

	// RVA: 0x2089E80 Offset: 0x2088880 VA: 0x182089E80
	internal void UnregisterListChangedEvent() { }

	// RVA: 0x2089540 Offset: 0x2087F40 VA: 0x182089540
	private void CleanUp(bool updateListeners) { }

	// RVA: 0x2089A60 Offset: 0x2088460 VA: 0x182089A60
	private void RegisterListener(DataTable table) { }
}

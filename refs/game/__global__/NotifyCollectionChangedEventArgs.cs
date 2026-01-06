public class NotifyCollectionChangedEventArgs : EventArgs // TypeDefIndex: 9863
{
	// Fields
	private NotifyCollectionChangedAction _action; // 0x10
	private IList _newItems; // 0x18
	private IList _oldItems; // 0x20
	private int _newStartingIndex; // 0x28
	private int _oldStartingIndex; // 0x2C

	// Methods

	// RVA: 0x26B20B0 Offset: 0x26B0AB0 VA: 0x1826B20B0
	public void .ctor(NotifyCollectionChangedAction action) { }

	// RVA: 0x26B1D70 Offset: 0x26B0770 VA: 0x1826B1D70
	public void .ctor(NotifyCollectionChangedAction action, object changedItem, int index) { }

	// RVA: 0x26B23C0 Offset: 0x26B0DC0 VA: 0x1826B23C0
	public void .ctor(NotifyCollectionChangedAction action, object newItem, object oldItem, int index) { }

	// RVA: 0x26B21E0 Offset: 0x26B0BE0 VA: 0x1826B21E0
	public void .ctor(NotifyCollectionChangedAction action, IList newItems, IList oldItems, int startingIndex) { }

	// RVA: 0x26B1A10 Offset: 0x26B0410 VA: 0x1826B1A10
	private void InitializeAddOrRemove(NotifyCollectionChangedAction action, IList changedItems, int startingIndex) { }

	// RVA: 0x26B1B20 Offset: 0x26B0520 VA: 0x1826B1B20
	private void InitializeAdd(NotifyCollectionChangedAction action, IList newItems, int newStartingIndex) { }

	// RVA: 0x26B1CD0 Offset: 0x26B06D0 VA: 0x1826B1CD0
	private void InitializeRemove(NotifyCollectionChangedAction action, IList oldItems, int oldStartingIndex) { }

	// RVA: 0x26B1BC0 Offset: 0x26B05C0 VA: 0x1826B1BC0
	private void InitializeMoveOrReplace(NotifyCollectionChangedAction action, IList newItems, IList oldItems, int startingIndex, int oldStartingIndex) { }
}

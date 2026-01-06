public sealed class EventHandlerList : IDisposable // TypeDefIndex: 9667
{
	// Fields
	private EventHandlerList.ListEntry _head; // 0x10
	private Component _parent; // 0x18

	// Properties
	public Delegate Item { get; set; }

	// Methods

	// RVA: 0x7E2C80 Offset: 0x7E1680 VA: 0x1807E2C80
	internal void .ctor(Component parent) { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }

	// RVA: 0x26476F0 Offset: 0x26460F0 VA: 0x1826476F0
	public Delegate get_Item(object key) { }

	// RVA: 0x2647750 Offset: 0x2646150 VA: 0x182647750
	public void set_Item(object key, Delegate value) { }

	// RVA: 0x2647570 Offset: 0x2645F70 VA: 0x182647570
	public void AddHandler(object key, Delegate value) { }

	// RVA: 0xAFE5A0 Offset: 0xAFCFA0 VA: 0x180AFE5A0 Slot: 4
	public void Dispose() { }

	// RVA: 0x2647670 Offset: 0x2646070 VA: 0x182647670
	private EventHandlerList.ListEntry Find(object key) { }

	// RVA: 0x2647690 Offset: 0x2646090 VA: 0x182647690
	public void RemoveHandler(object key, Delegate value) { }
}

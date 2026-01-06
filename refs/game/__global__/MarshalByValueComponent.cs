public class MarshalByValueComponent : IComponent, IDisposable, IServiceProvider // TypeDefIndex: 9738
{
	// Fields
	private static readonly object s_eventDisposed; // 0x0
	private ISite _site; // 0x10
	private EventHandlerList _events; // 0x18

	// Properties
	[Browsable(False)]
	[DesignerSerializationVisibility(0)]
	public virtual ISite Site { get; set; }

	// Methods

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }

	// RVA: 0x1AB3AF0 Offset: 0x1AB24F0 VA: 0x181AB3AF0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0 Slot: 8
	public virtual ISite get_Site() { }

	// RVA: 0x49CBB0 Offset: 0x49B5B0 VA: 0x18049CBB0 Slot: 9
	public virtual void set_Site(ISite value) { }

	// RVA: 0x2669FE0 Offset: 0x26689E0 VA: 0x182669FE0 Slot: 6
	public void Dispose() { }

	// RVA: 0x266A050 Offset: 0x2668A50 VA: 0x18266A050 Slot: 10
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x266A230 Offset: 0x2668C30 VA: 0x18266A230 Slot: 11
	public virtual object GetService(Type service) { }

	// RVA: 0x266A290 Offset: 0x2668C90 VA: 0x18266A290 Slot: 3
	public override string ToString() { }

	// RVA: 0x266A380 Offset: 0x2668D80 VA: 0x18266A380
	private static void .cctor() { }
}

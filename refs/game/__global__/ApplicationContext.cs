public class ApplicationContext : IDisposable // TypeDefIndex: 5227
{
	// Fields
	private Form main_form; // 0x10
	private object tag; // 0x18
	private bool thread_exit_raised; // 0x20
	private EventHandler ThreadExit; // 0x28

	// Properties
	public Form MainForm { get; set; }

	// Methods

	// RVA: 0x21C05C0 Offset: 0x21BEFC0 VA: 0x1821C05C0
	public void .ctor() { }

	// RVA: 0x21C05F0 Offset: 0x21BEFF0 VA: 0x1821C05F0
	public void .ctor(Form mainForm) { }

	// RVA: 0x4D8670 Offset: 0x4D7070 VA: 0x1804D8670 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	public Form get_MainForm() { }

	// RVA: 0x21C0620 Offset: 0x21BF020 VA: 0x1821C0620
	public void set_MainForm(Form value) { }

	// RVA: 0x21C03E0 Offset: 0x21BEDE0 VA: 0x1821C03E0 Slot: 4
	public void Dispose() { }

	// RVA: 0x5FF4F0 Offset: 0x5FDEF0 VA: 0x1805FF4F0
	public void ExitThread() { }

	// RVA: 0x21C0450 Offset: 0x21BEE50 VA: 0x1821C0450 Slot: 5
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x21C0480 Offset: 0x21BEE80 VA: 0x1821C0480 Slot: 6
	protected virtual void ExitThreadCore() { }

	// RVA: 0x21C0580 Offset: 0x21BEF80 VA: 0x1821C0580 Slot: 7
	protected virtual void OnMainFormClosed(object sender, EventArgs e) { }
}

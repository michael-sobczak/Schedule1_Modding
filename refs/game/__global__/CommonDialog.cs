public abstract class CommonDialog : Component // TypeDefIndex: 5280
{
	// Fields
	internal CommonDialog.DialogForm form; // 0x28
	private static object HelpRequestEvent; // 0x0

	// Methods

	// RVA: 0x22EBA20 Offset: 0x22EA420 VA: 0x1822EBA20
	public void .ctor() { }

	// RVA: 0x22EB9A0 Offset: 0x22EA3A0 VA: 0x1822EB9A0
	private static void .cctor() { }

	// RVA: 0x22EBA70 Offset: 0x22EA470 VA: 0x1822EBA70
	public void add_HelpRequest(EventHandler value) { }

	// RVA: 0x22EBB00 Offset: 0x22EA500 VA: 0x1822EBB00
	public void remove_HelpRequest(EventHandler value) { }

	// RVA: -1 Offset: -1 Slot: 14
	public abstract void Reset();

	// RVA: 0x22EB870 Offset: 0x22EA270 VA: 0x1822EB870
	public DialogResult ShowDialog(IWin32Window owner) { }

	// RVA: 0x22EB7A0 Offset: 0x22EA1A0 VA: 0x1822EB7A0 Slot: 15
	protected virtual void OnHelpRequest(EventArgs e) { }

	// RVA: -1 Offset: -1 Slot: 16
	protected abstract bool RunDialog(IntPtr hwndOwner);
}

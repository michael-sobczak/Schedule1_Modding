public class DropdownMenu // TypeDefIndex: 6490
{
	// Fields
	private List<DropdownMenuItem> m_MenuItems; // 0x10
	private DropdownMenuEventInfo m_DropdownMenuEventInfo; // 0x18

	// Methods

	// RVA: 0x180D270 Offset: 0x180BC70 VA: 0x18180D270
	public List<DropdownMenuItem> MenuItems() { }

	// RVA: 0x2E8B110 Offset: 0x2E89B10 VA: 0x182E8B110
	public void AppendAction(string actionName, Action<DropdownMenuAction> action, Func<DropdownMenuAction, DropdownMenuAction.Status> actionStatusCallback, object userData) { }

	// RVA: 0x2E8AFF0 Offset: 0x2E899F0 VA: 0x182E8AFF0
	public void AppendAction(string actionName, Action<DropdownMenuAction> action, DropdownMenuAction.Status status = 1) { }

	// RVA: 0x2E8B240 Offset: 0x2E89C40 VA: 0x182E8B240
	public void AppendSeparator(string subMenuPath) { }

	// RVA: 0x2E8B380 Offset: 0x2E89D80 VA: 0x182E8B380
	public void InsertSeparator(string subMenuPath, int atIndex) { }

	// RVA: 0x2E8B4D0 Offset: 0x2E89ED0 VA: 0x182E8B4D0
	public void PrepareForDisplay(EventBase e) { }

	// RVA: 0x2E8B730 Offset: 0x2E8A130 VA: 0x182E8B730
	public void .ctor() { }
}

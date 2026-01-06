public class SearchForVirtualItemEventArgs : EventArgs // TypeDefIndex: 5564
{
	// Fields
	private SearchDirectionHint direction; // 0x10
	private bool include_sub_items_in_search; // 0x14
	private int index; // 0x18
	private bool is_prefix_search; // 0x1C
	private bool is_text_search; // 0x1D
	private int start_index; // 0x20
	private Point starting_point; // 0x24
	private string text; // 0x30

	// Properties
	public int Index { get; }

	// Methods

	// RVA: 0x21E3AB0 Offset: 0x21E24B0 VA: 0x1821E3AB0
	public void .ctor(bool isTextSearch, bool isPrefixSearch, bool includeSubItemsInSearch, string text, Point startingPoint, SearchDirectionHint direction, int startIndex) { }

	// RVA: 0x456E90 Offset: 0x455890 VA: 0x180456E90
	public int get_Index() { }
}

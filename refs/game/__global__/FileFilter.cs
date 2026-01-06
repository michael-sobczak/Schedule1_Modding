internal class FileFilter // TypeDefIndex: 5336
{
	// Fields
	private ArrayList filterArrayList; // 0x10
	private string filter; // 0x18

	// Properties
	public ArrayList FilterArrayList { get; }

	// Methods

	// RVA: 0x2323E00 Offset: 0x2322800 VA: 0x182323E00
	public void .ctor() { }

	// RVA: 0x2323E70 Offset: 0x2322870 VA: 0x182323E70
	public void .ctor(string filter) { }

	// RVA: 0x2323B70 Offset: 0x2322570 VA: 0x182323B70
	public static bool CheckFilter(string val) { }

	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	public ArrayList get_FilterArrayList() { }

	// RVA: 0x2323C00 Offset: 0x2322600 VA: 0x182323C00
	private void SplitFilter() { }
}

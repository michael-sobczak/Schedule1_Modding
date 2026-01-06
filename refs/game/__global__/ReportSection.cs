public class ReportSection // TypeDefIndex: 17987
{
	// Fields
	public string Title; // 0x10
	public int SortOrder; // 0x18
	private StringBuilder sectionText; // 0x20

	// Methods

	// RVA: 0x440AF0 Offset: 0x43F4F0 VA: 0x180440AF0
	public void .ctor(string title, int sortOrder = 0) { }

	// RVA: 0x440B80 Offset: 0x43F580 VA: 0x180440B80
	public void .ctor(string title, string text) { }

	// RVA: 0x4409A0 Offset: 0x43F3A0 VA: 0x1804409A0
	public void Append(string text) { }

	// RVA: 0x440980 Offset: 0x43F380 VA: 0x180440980
	public void AppendLine(string line) { }

	// RVA: 0x4409C0 Offset: 0x43F3C0 VA: 0x1804409C0
	public void SetText(string text) { }

	// RVA: 0x440A30 Offset: 0x43F430 VA: 0x180440A30 Slot: 3
	public override string ToString() { }
}

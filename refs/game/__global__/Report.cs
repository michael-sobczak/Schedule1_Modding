public class Report // TypeDefIndex: 17986
{
	// Fields
	private const int MAX_ATTACHMENTS = 99;
	public readonly List<Label> Labels; // 0x10
	private readonly Dictionary<string, ReportSection> info; // 0x18
	public List List; // 0x20
	public string Title; // 0x48
	[CompilerGenerated]
	private readonly List<FileAttachment> <Attachments>k__BackingField; // 0x50

	// Properties
	public List<FileAttachment> Attachments { get; }
	public ReportSection Item { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x441BA0 Offset: 0x4405A0 VA: 0x180441BA0
	public List<FileAttachment> get_Attachments() { }

	// RVA: 0x441BB0 Offset: 0x4405B0 VA: 0x180441BB0
	public ReportSection get_Item(string sectionTitle) { }

	// RVA: 0x441CA0 Offset: 0x4406A0 VA: 0x180441CA0
	public void set_Item(string sectionTitle, ReportSection value) { }

	// RVA: 0x441A90 Offset: 0x440490 VA: 0x180441A90
	public void .ctor() { }

	// RVA: 0x440E60 Offset: 0x43F860 VA: 0x180440E60
	public void AddSection(string title, int sortOrder = 0) { }

	// RVA: 0x440FF0 Offset: 0x43F9F0 VA: 0x180440FF0
	public void AddSection(ReportSection section) { }

	// RVA: 0x4416F0 Offset: 0x4400F0 VA: 0x1804416F0
	public void RemoveSection(string title) { }

	// RVA: 0x441690 Offset: 0x440090 VA: 0x180441690
	public bool HasSection(string title) { }

	// RVA: 0x4417E0 Offset: 0x4401E0 VA: 0x1804417E0 Slot: 3
	public override string ToString() { }

	// RVA: 0x4413B0 Offset: 0x43FDB0 VA: 0x1804413B0
	public string GetLocalFileText() { }

	// RVA: 0x4411B0 Offset: 0x43FBB0 VA: 0x1804411B0
	public void AttachFile(FileAttachment file) { }

	// RVA: 0x4410F0 Offset: 0x43FAF0 VA: 0x1804410F0
	public void AttachFile(string name, string filePath) { }

	// RVA: 0x441300 Offset: 0x43FD00 VA: 0x180441300
	public void AttachFile(string name, byte[] data) { }

	// RVA: 0x440CA0 Offset: 0x43F6A0 VA: 0x180440CA0
	public void AddLabel(Label label) { }

	// RVA: 0x441610 Offset: 0x440010 VA: 0x180441610
	public bool HasLabel(Label label) { }
}

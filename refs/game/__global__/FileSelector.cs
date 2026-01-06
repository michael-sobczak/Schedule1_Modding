public class FileSelector // TypeDefIndex: 16605
{
	// Fields
	internal SelectionCriterion _Criterion; // 0x10
	[CompilerGenerated]
	private bool <TraverseReparsePoints>k__BackingField; // 0x18
	[CompilerGenerated]
	private static Dictionary<string, int> <>f__switch$map0; // 0x0

	// Properties
	public string SelectionCriteria { get; set; }
	public bool TraverseReparsePoints { get; set; }

	// Methods

	// RVA: 0x1E34040 Offset: 0x1E32A40 VA: 0x181E34040
	public void .ctor(string selectionCriteria) { }

	// RVA: 0x1E33FE0 Offset: 0x1E329E0 VA: 0x181E33FE0
	public void .ctor(string selectionCriteria, bool traverseDirectoryReparsePoints) { }

	// RVA: 0x1E34090 Offset: 0x1E32A90 VA: 0x181E34090
	public string get_SelectionCriteria() { }

	// RVA: 0x1E340C0 Offset: 0x1E32AC0 VA: 0x181E340C0
	public void set_SelectionCriteria(string value) { }

	[CompilerGenerated]
	// RVA: 0x4971B0 Offset: 0x495BB0 VA: 0x1804971B0
	public bool get_TraverseReparsePoints() { }

	[CompilerGenerated]
	// RVA: 0x698000 Offset: 0x696A00 VA: 0x180698000
	public void set_TraverseReparsePoints(bool value) { }

	// RVA: 0x1E314A0 Offset: 0x1E2FEA0 VA: 0x181E314A0
	private static string NormalizeCriteriaExpression(string source) { }

	// RVA: 0x1E32710 Offset: 0x1E31110 VA: 0x181E32710
	private static SelectionCriterion _ParseCriterion(string s) { }

	// RVA: 0x1E32690 Offset: 0x1E31090 VA: 0x181E32690 Slot: 3
	public override string ToString() { }

	// RVA: 0x1B6B160 Offset: 0x1B69B60 VA: 0x181B6B160
	private bool Evaluate(string filename) { }

	[Conditional("SelectorTrace")]
	// RVA: 0x1E32600 Offset: 0x1E31000 VA: 0x181E32600
	private void SelectorTrace(string format, object[] args) { }

	// RVA: 0x1E32350 Offset: 0x1E30D50 VA: 0x181E32350
	public ICollection<string> SelectFiles(string directory) { }

	// RVA: 0x1E32360 Offset: 0x1E30D60 VA: 0x181E32360
	public ReadOnlyCollection<string> SelectFiles(string directory, bool recurseDirectories) { }

	// RVA: 0x1E31470 Offset: 0x1E2FE70 VA: 0x181E31470
	private bool Evaluate(ZipEntry entry) { }

	// RVA: 0x1E31CA0 Offset: 0x1E306A0 VA: 0x181E31CA0
	public ICollection<ZipEntry> SelectEntries(ZipFile zip) { }

	// RVA: 0x1E31F20 Offset: 0x1E30920 VA: 0x181E31F20
	public ICollection<ZipEntry> SelectEntries(ZipFile zip, string directoryPathInArchive) { }
}

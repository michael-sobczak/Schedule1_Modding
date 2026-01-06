public class EnumerationOptions // TypeDefIndex: 5080
{
	// Fields
	[CompilerGenerated]
	private static readonly EnumerationOptions <Compatible>k__BackingField; // 0x0
	[CompilerGenerated]
	private static readonly EnumerationOptions <CompatibleRecursive>k__BackingField; // 0x8
	[CompilerGenerated]
	private static readonly EnumerationOptions <Default>k__BackingField; // 0x10
	[CompilerGenerated]
	private bool <RecurseSubdirectories>k__BackingField; // 0x10
	[CompilerGenerated]
	private bool <IgnoreInaccessible>k__BackingField; // 0x11
	[CompilerGenerated]
	private int <BufferSize>k__BackingField; // 0x14
	[CompilerGenerated]
	private FileAttributes <AttributesToSkip>k__BackingField; // 0x18
	[CompilerGenerated]
	private MatchType <MatchType>k__BackingField; // 0x1C
	[CompilerGenerated]
	private MatchCasing <MatchCasing>k__BackingField; // 0x20
	[CompilerGenerated]
	private bool <ReturnSpecialDirectories>k__BackingField; // 0x24

	// Properties
	internal static EnumerationOptions Compatible { get; }
	private static EnumerationOptions CompatibleRecursive { get; }
	internal static EnumerationOptions Default { get; }
	public bool RecurseSubdirectories { get; set; }
	public bool IgnoreInaccessible { get; set; }
	public int BufferSize { get; }
	public FileAttributes AttributesToSkip { get; set; }
	public MatchType MatchType { get; set; }
	public MatchCasing MatchCasing { get; }
	public bool ReturnSpecialDirectories { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1C29630 Offset: 0x1C28030 VA: 0x181C29630
	internal static EnumerationOptions get_Compatible() { }

	[CompilerGenerated]
	// RVA: 0x1C295E0 Offset: 0x1C27FE0 VA: 0x181C295E0
	private static EnumerationOptions get_CompatibleRecursive() { }

	[CompilerGenerated]
	// RVA: 0x1C29680 Offset: 0x1C28080 VA: 0x181C29680
	internal static EnumerationOptions get_Default() { }

	// RVA: 0x1C295B0 Offset: 0x1C27FB0 VA: 0x181C295B0
	public void .ctor() { }

	// RVA: 0x1C29330 Offset: 0x1C27D30 VA: 0x181C29330
	internal static EnumerationOptions FromSearchOption(SearchOption searchOption) { }

	[CompilerGenerated]
	// RVA: 0x498A40 Offset: 0x497440 VA: 0x180498A40
	public bool get_RecurseSubdirectories() { }

	[CompilerGenerated]
	// RVA: 0x498A80 Offset: 0x497480 VA: 0x180498A80
	public void set_RecurseSubdirectories(bool value) { }

	[CompilerGenerated]
	// RVA: 0x498A50 Offset: 0x497450 VA: 0x180498A50
	public bool get_IgnoreInaccessible() { }

	[CompilerGenerated]
	// RVA: 0x498A90 Offset: 0x497490 VA: 0x180498A90
	public void set_IgnoreInaccessible(bool value) { }

	[CompilerGenerated]
	// RVA: 0x498A70 Offset: 0x497470 VA: 0x180498A70
	public int get_BufferSize() { }

	[CompilerGenerated]
	// RVA: 0x456E90 Offset: 0x455890 VA: 0x180456E90
	public FileAttributes get_AttributesToSkip() { }

	[CompilerGenerated]
	// RVA: 0x49D810 Offset: 0x49C210 VA: 0x18049D810
	public void set_AttributesToSkip(FileAttributes value) { }

	[CompilerGenerated]
	// RVA: 0x4A1F70 Offset: 0x4A0970 VA: 0x1804A1F70
	public MatchType get_MatchType() { }

	[CompilerGenerated]
	// RVA: 0x4A1F80 Offset: 0x4A0980 VA: 0x1804A1F80
	public void set_MatchType(MatchType value) { }

	[CompilerGenerated]
	// RVA: 0x494440 Offset: 0x492E40 VA: 0x180494440
	public MatchCasing get_MatchCasing() { }

	[CompilerGenerated]
	// RVA: 0x563D90 Offset: 0x562790 VA: 0x180563D90
	public bool get_ReturnSpecialDirectories() { }

	// RVA: 0x1C29480 Offset: 0x1C27E80 VA: 0x181C29480
	private static void .cctor() { }
}

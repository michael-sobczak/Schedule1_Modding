internal class FSEntry // TypeDefIndex: 5351
{
	// Fields
	private MasterMount.FsTypes fsType; // 0x10
	private string device_short; // 0x18
	private string fullName; // 0x20
	private string name; // 0x28
	private string realName; // 0x30
	private FileAttributes attributes; // 0x38
	private long fileSize; // 0x40
	private FSEntry.FSEntryType fileType; // 0x48
	private DateTime lastAccessTime; // 0x50
	private FSEntry mainTopNode; // 0x58
	private int iconIndex; // 0x60
	private string parent; // 0x68

	// Properties
	public MasterMount.FsTypes FsType { set; }
	public string DeviceShort { set; }
	public string FullName { get; set; }
	public string Name { get; set; }
	public string RealName { get; set; }
	public FileAttributes Attributes { get; set; }
	public long FileSize { get; set; }
	public FSEntry.FSEntryType FileType { get; set; }
	public DateTime LastAccessTime { get; set; }
	public int IconIndex { get; set; }
	public FSEntry MainTopNode { get; set; }
	public string Parent { get; }

	// Methods

	// RVA: 0x2323AF0 Offset: 0x23224F0 VA: 0x182323AF0
	public void .ctor() { }

	// RVA: 0x48C850 Offset: 0x48B250 VA: 0x18048C850
	public void set_FsType(MasterMount.FsTypes value) { }

	// RVA: 0x43EFE0 Offset: 0x43D9E0 VA: 0x18043EFE0
	public void set_DeviceShort(string value) { }

	// RVA: 0x43EFF0 Offset: 0x43D9F0 VA: 0x18043EFF0
	public void set_FullName(string value) { }

	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	public string get_FullName() { }

	// RVA: 0x4513F0 Offset: 0x44FDF0 VA: 0x1804513F0
	public void set_Name(string value) { }

	// RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0
	public string get_Name() { }

	// RVA: 0x4513D0 Offset: 0x44FDD0 VA: 0x1804513D0
	public void set_RealName(string value) { }

	// RVA: 0x4513A0 Offset: 0x44FDA0 VA: 0x1804513A0
	public string get_RealName() { }

	// RVA: 0x4E2930 Offset: 0x4E1330 VA: 0x1804E2930
	public void set_Attributes(FileAttributes value) { }

	// RVA: 0x495F50 Offset: 0x494950 VA: 0x180495F50
	public FileAttributes get_Attributes() { }

	// RVA: 0x54D020 Offset: 0x54BA20 VA: 0x18054D020
	public void set_FileSize(long value) { }

	// RVA: 0x4945F0 Offset: 0x492FF0 VA: 0x1804945F0
	public long get_FileSize() { }

	// RVA: 0x4E28C0 Offset: 0x4E12C0 VA: 0x1804E28C0
	public void set_FileType(FSEntry.FSEntryType value) { }

	// RVA: 0x4B61C0 Offset: 0x4B4BC0 VA: 0x1804B61C0
	public FSEntry.FSEntryType get_FileType() { }

	// RVA: 0xCC6420 Offset: 0xCC4E20 VA: 0x180CC6420
	public void set_LastAccessTime(DateTime value) { }

	// RVA: 0x441BA0 Offset: 0x4405A0 VA: 0x180441BA0
	public DateTime get_LastAccessTime() { }

	// RVA: 0x4E2900 Offset: 0x4E1300 VA: 0x1804E2900
	public void set_IconIndex(int value) { }

	// RVA: 0x4E2410 Offset: 0x4E0E10 VA: 0x1804E2410
	public int get_IconIndex() { }

	// RVA: 0x4993E0 Offset: 0x497DE0 VA: 0x1804993E0
	public void set_MainTopNode(FSEntry value) { }

	// RVA: 0x4993C0 Offset: 0x497DC0 VA: 0x1804993C0
	public FSEntry get_MainTopNode() { }

	// RVA: 0x2323B00 Offset: 0x2322500 VA: 0x182323B00
	public string get_Parent() { }

	// RVA: 0x2323320 Offset: 0x2321D20 VA: 0x182323320
	private string GetParent() { }
}

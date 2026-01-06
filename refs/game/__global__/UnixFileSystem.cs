internal class UnixFileSystem : FileSystem // TypeDefIndex: 5348
{
	// Fields
	private MasterMount masterMount; // 0x38
	private FSEntry desktopFSEntry; // 0x40
	private FSEntry recentlyusedFSEntry; // 0x48
	private FSEntry personalFSEntry; // 0x50
	private FSEntry mycomputerpersonalFSEntry; // 0x58
	private FSEntry mycomputerFSEntry; // 0x60
	private FSEntry mynetworkFSEntry; // 0x68
	private string personal_folder; // 0x70
	private string recently_used_path; // 0x78
	private string full_kde_recent_document_dir; // 0x80

	// Methods

	// RVA: 0x233E9E0 Offset: 0x233D3E0 VA: 0x18233E9E0
	public void .ctor() { }

	// RVA: 0x233DE10 Offset: 0x233C810 VA: 0x18233DE10 Slot: 12
	public override void WriteRecentlyUsedFiles(string fileToAdd) { }

	// RVA: 0x233D8E0 Offset: 0x233C2E0 VA: 0x18233D8E0 Slot: 13
	public override ArrayList GetRecentlyUsedFiles() { }

	// RVA: 0x233C6C0 Offset: 0x233B0C0 VA: 0x18233C6C0 Slot: 14
	public override ArrayList GetMyComputerContent() { }

	// RVA: 0x233D270 Offset: 0x233BC70 VA: 0x18233D270 Slot: 15
	public override ArrayList GetMyNetworkContent() { }

	// RVA: 0x4945F0 Offset: 0x492FF0 VA: 0x1804945F0 Slot: 6
	protected override FSEntry GetDesktopFSEntry() { }

	// RVA: 0x4C1D80 Offset: 0x4C0780 VA: 0x1804C1D80 Slot: 7
	protected override FSEntry GetRecentlyUsedFSEntry() { }

	// RVA: 0x441BA0 Offset: 0x4405A0 VA: 0x180441BA0 Slot: 8
	protected override FSEntry GetPersonalFSEntry() { }

	// RVA: 0x4993C0 Offset: 0x497DC0 VA: 0x1804993C0 Slot: 9
	protected override FSEntry GetMyComputerPersonalFSEntry() { }

	// RVA: 0x4C4BF0 Offset: 0x4C35F0 VA: 0x1804C4BF0 Slot: 10
	protected override FSEntry GetMyComputerFSEntry() { }

	// RVA: 0x4663D0 Offset: 0x464DD0 VA: 0x1804663D0 Slot: 11
	protected override FSEntry GetMyNetworkFSEntry() { }
}

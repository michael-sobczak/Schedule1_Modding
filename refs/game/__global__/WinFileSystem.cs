internal class WinFileSystem : FileSystem // TypeDefIndex: 5349
{
	// Fields
	private FSEntry desktopFSEntry; // 0x38
	private FSEntry recentlyusedFSEntry; // 0x40
	private FSEntry personalFSEntry; // 0x48
	private FSEntry mycomputerpersonalFSEntry; // 0x50
	private FSEntry mycomputerFSEntry; // 0x58
	private FSEntry mynetworkFSEntry; // 0x60

	// Methods

	// RVA: 0x233F910 Offset: 0x233E310 VA: 0x18233F910
	public void .ctor() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 12
	public override void WriteRecentlyUsedFiles(string fileToAdd) { }

	// RVA: 0x233F7E0 Offset: 0x233E1E0 VA: 0x18233F7E0 Slot: 13
	public override ArrayList GetRecentlyUsedFiles() { }

	// RVA: 0x233F4F0 Offset: 0x233DEF0 VA: 0x18233F4F0 Slot: 14
	public override ArrayList GetMyComputerContent() { }

	// RVA: 0x233F790 Offset: 0x233E190 VA: 0x18233F790 Slot: 15
	public override ArrayList GetMyNetworkContent() { }

	// RVA: 0x4513B0 Offset: 0x44FDB0 VA: 0x1804513B0 Slot: 6
	protected override FSEntry GetDesktopFSEntry() { }

	// RVA: 0x4945F0 Offset: 0x492FF0 VA: 0x1804945F0 Slot: 7
	protected override FSEntry GetRecentlyUsedFSEntry() { }

	// RVA: 0x4C1D80 Offset: 0x4C0780 VA: 0x1804C1D80 Slot: 8
	protected override FSEntry GetPersonalFSEntry() { }

	// RVA: 0x441BA0 Offset: 0x4405A0 VA: 0x180441BA0 Slot: 9
	protected override FSEntry GetMyComputerPersonalFSEntry() { }

	// RVA: 0x4993C0 Offset: 0x497DC0 VA: 0x1804993C0 Slot: 10
	protected override FSEntry GetMyComputerFSEntry() { }

	// RVA: 0x4C4BF0 Offset: 0x4C35F0 VA: 0x1804C4BF0 Slot: 11
	protected override FSEntry GetMyNetworkFSEntry() { }
}

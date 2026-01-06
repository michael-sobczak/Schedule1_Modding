internal class MasterMount // TypeDefIndex: 5355
{
	// Fields
	private bool proc_mount_available; // 0x10
	private ArrayList block_devices; // 0x18
	private ArrayList network_devices; // 0x20
	private ArrayList removable_devices; // 0x28
	private MasterMount.MountComparer mountComparer; // 0x30

	// Properties
	public ArrayList Block_devices { get; }
	public ArrayList Network_devices { get; }
	public ArrayList Removable_devices { get; }
	public bool ProcMountAvailable { get; }

	// Methods

	// RVA: 0x233B620 Offset: 0x233A020 VA: 0x18233B620
	public void .ctor() { }

	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	public ArrayList get_Block_devices() { }

	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	public ArrayList get_Network_devices() { }

	// RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0
	public ArrayList get_Removable_devices() { }

	// RVA: 0x498A40 Offset: 0x497440 VA: 0x180498A40
	public bool get_ProcMountAvailable() { }

	// RVA: 0x233AC90 Offset: 0x2339690 VA: 0x18233AC90
	public void GetMounts() { }

	// RVA: 0x233AED0 Offset: 0x23398D0 VA: 0x18233AED0
	private void ProcessProcMountLine(string line) { }
}

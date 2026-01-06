internal class FDOMimeConfigReader // TypeDefIndex: 5505
{
	// Fields
	private bool fdo_mime_available; // 0x10
	private StringCollection shared_mime_paths; // 0x18
	private BinaryReader br; // 0x20
	private int max_offset_and_range; // 0x28

	// Methods

	// RVA: 0x2383B80 Offset: 0x2382580 VA: 0x182383B80
	public void .ctor() { }

	// RVA: 0x2381FB0 Offset: 0x23809B0 VA: 0x182381FB0
	public int Init() { }

	// RVA: 0x2381D90 Offset: 0x2380790 VA: 0x182381D90
	private void CheckFDOMimePaths() { }

	// RVA: 0x2383380 Offset: 0x2381D80 VA: 0x182383380
	private void ReadMagicData() { }

	// RVA: 0x2382160 Offset: 0x2380B60 VA: 0x182382160
	private void MakeMatches() { }

	// RVA: 0x2382DE0 Offset: 0x23817E0 VA: 0x182382DE0
	private void ReadGlobsData() { }

	// RVA: 0x2383750 Offset: 0x2382150 VA: 0x182383750
	private void ReadSubclasses() { }

	// RVA: 0x2382AD0 Offset: 0x23814D0 VA: 0x182382AD0
	private void ReadAliases() { }

	// RVA: 0x2383A60 Offset: 0x2382460 VA: 0x182383A60
	private int ReadValue() { }

	// RVA: 0x2383590 Offset: 0x2381F90 VA: 0x182383590
	private string ReadPriorityAndMimeType(ref int priority) { }

	// RVA: 0x2381EE0 Offset: 0x23808E0 VA: 0x182381EE0
	private bool CheckMagicHeader() { }
}

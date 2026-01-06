public class AuthenticodeBase // TypeDefIndex: 17557
{
	// Fields
	private byte[] fileblock; // 0x10
	private Stream fs; // 0x18
	private int blockNo; // 0x20
	private int blockLength; // 0x24
	private int peOffset; // 0x28
	private int dirSecurityOffset; // 0x2C
	private int dirSecuritySize; // 0x30
	private int coffSymbolTableOffset; // 0x34
	private bool pe64; // 0x38

	// Properties
	internal int PEOffset { get; }

	// Methods

	// RVA: 0x1A6F650 Offset: 0x1A6E050 VA: 0x181A6F650
	public void .ctor() { }

	// RVA: 0x1A6F6B0 Offset: 0x1A6E0B0 VA: 0x181A6F6B0
	internal int get_PEOffset() { }

	// RVA: 0x1A6F170 Offset: 0x1A6DB70 VA: 0x181A6F170
	internal void Open(string filename) { }

	// RVA: 0x1A6F230 Offset: 0x1A6DC30 VA: 0x181A6F230
	internal void Open(byte[] rawdata) { }

	// RVA: 0x1A6EB60 Offset: 0x1A6D560 VA: 0x181A6EB60
	internal void Close() { }

	// RVA: 0x1A6F570 Offset: 0x1A6DF70 VA: 0x181A6F570
	internal void ReadFirstBlock() { }

	// RVA: 0x1A6F2E0 Offset: 0x1A6DCE0 VA: 0x181A6F2E0
	internal int ProcessFirstBlock() { }

	// RVA: 0x1A6F0A0 Offset: 0x1A6DAA0 VA: 0x181A6F0A0
	internal byte[] GetSecurityEntry() { }

	// RVA: 0x1A6EBB0 Offset: 0x1A6D5B0 VA: 0x181A6EBB0
	internal byte[] GetHash(HashAlgorithm hash) { }
}

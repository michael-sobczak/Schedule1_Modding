public struct STATSTG // TypeDefIndex: 4570
{
	// Fields
	public string pwcsName; // 0x0
	public int type; // 0x8
	public long cbSize; // 0x10
	public FILETIME mtime; // 0x18
	public FILETIME ctime; // 0x20
	public FILETIME atime; // 0x28
	public int grfMode; // 0x30
	public int grfLocksSupported; // 0x34
	public Guid clsid; // 0x38
	public int grfStateBits; // 0x48
	public int reserved; // 0x4C
}

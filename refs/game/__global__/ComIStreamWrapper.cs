internal sealed class ComIStreamWrapper : IStream // TypeDefIndex: 17138
{
	// Fields
	private readonly Stream baseStream; // 0x10
	private long position; // 0x18

	// Methods

	// RVA: 0x2137660 Offset: 0x2136060 VA: 0x182137660
	internal void .ctor(Stream stream) { }

	// RVA: 0x2137420 Offset: 0x2135E20 VA: 0x182137420
	private void SetSizeToPosition() { }

	// RVA: 0x2137170 Offset: 0x2135B70 VA: 0x182137170 Slot: 4
	public void Read(byte[] pv, int cb, IntPtr pcbRead) { }

	// RVA: 0x2137590 Offset: 0x2135F90 VA: 0x182137590 Slot: 5
	public void Write(byte[] pv, int cb, IntPtr pcbWritten) { }

	// RVA: 0x21372A0 Offset: 0x2135CA0 VA: 0x1821372A0 Slot: 6
	public void Seek(long dlibMove, int dwOrigin, IntPtr plibNewPosition) { }

	// RVA: 0x21374C0 Offset: 0x2135EC0 VA: 0x1821374C0 Slot: 7
	public void SetSize(long libNewSize) { }

	// RVA: 0x2136F00 Offset: 0x2135900 VA: 0x182136F00 Slot: 8
	public void CopyTo(IStream pstm, long cb, IntPtr pcbRead, IntPtr pcbWritten) { }

	// RVA: 0x2136EC0 Offset: 0x21358C0 VA: 0x182136EC0 Slot: 9
	public void Commit(int grfCommitFlags) { }

	// RVA: 0x2137250 Offset: 0x2135C50 VA: 0x182137250 Slot: 10
	public void Revert() { }

	// RVA: 0x2137120 Offset: 0x2135B20 VA: 0x182137120 Slot: 11
	public void LockRegion(long libOffset, long cb, int dwLockType) { }

	// RVA: 0x2137540 Offset: 0x2135F40 VA: 0x182137540 Slot: 12
	public void UnlockRegion(long libOffset, long cb, int dwLockType) { }

	// RVA: 0x21374F0 Offset: 0x2135EF0 VA: 0x1821374F0 Slot: 13
	public void Stat(out STATSTG pstatstg, int grfStatFlag) { }

	// RVA: 0x2136E60 Offset: 0x2135860 VA: 0x182136E60 Slot: 14
	public void Clone(out IStream ppstm) { }
}

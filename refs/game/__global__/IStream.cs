public interface IStream // TypeDefIndex: 4571
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Read([Out] byte[] pv, int cb, IntPtr pcbRead);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void Write(byte[] pv, int cb, IntPtr pcbWritten);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void Seek(long dlibMove, int dwOrigin, IntPtr plibNewPosition);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void SetSize(long libNewSize);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void CopyTo(IStream pstm, long cb, IntPtr pcbRead, IntPtr pcbWritten);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void Commit(int grfCommitFlags);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void Revert();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void LockRegion(long libOffset, long cb, int dwLockType);

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void UnlockRegion(long libOffset, long cb, int dwLockType);

	// RVA: -1 Offset: -1 Slot: 9
	public abstract void Stat(out STATSTG pstatstg, int grfStatFlag);

	// RVA: -1 Offset: -1 Slot: 10
	public abstract void Clone(out IStream ppstm);
}

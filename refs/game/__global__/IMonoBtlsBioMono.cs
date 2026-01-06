internal interface IMonoBtlsBioMono // TypeDefIndex: 9422
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract int Read(byte[] buffer, int offset, int size, out bool wantMore);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool Write(byte[] buffer, int offset, int size);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void Flush();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void Close();
}

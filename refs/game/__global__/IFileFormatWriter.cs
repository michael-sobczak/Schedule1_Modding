internal interface IFileFormatWriter // TypeDefIndex: 17644
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract byte[] GetHeader();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void UpdateWithBytesRead(byte[] buffer, int offset, int bytesToCopy);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract byte[] GetFooter();
}

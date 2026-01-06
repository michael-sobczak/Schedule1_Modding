internal interface IFileFormatReader // TypeDefIndex: 17645
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool ReadHeader(InputBuffer input);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool ReadFooter(InputBuffer input);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void UpdateWithBytesRead(byte[] buffer, int offset, int bytesToCopy);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void Validate();
}

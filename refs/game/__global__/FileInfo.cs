public sealed class FileInfo : FileSystemInfo // TypeDefIndex: 5082
{
	// Properties
	public long Length { get; }
	public override string Name { get; }

	// Methods

	// RVA: 0x1C29AA0 Offset: 0x1C284A0 VA: 0x181C29AA0
	private void .ctor() { }

	// RVA: 0x1C297C0 Offset: 0x1C281C0 VA: 0x181C297C0
	public void .ctor(string fileName) { }

	// RVA: 0x1C29910 Offset: 0x1C28310 VA: 0x181C29910
	internal void .ctor(string originalPath, string fullPath, string fileName, bool isNormalized = False) { }

	// RVA: 0x1C29AB0 Offset: 0x1C284B0 VA: 0x181C29AB0
	public long get_Length() { }

	// RVA: 0x1C29740 Offset: 0x1C28140 VA: 0x181C29740
	public StreamWriter CreateText() { }

	// RVA: 0x1C296D0 Offset: 0x1C280D0 VA: 0x181C296D0
	public StreamWriter AppendText() { }

	// RVA: 0x1C297B0 Offset: 0x1C281B0 VA: 0x181C297B0 Slot: 11
	public override void Delete() { }

	// RVA: 0x1C27F50 Offset: 0x1C26950 VA: 0x181C27F50
	private void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x441BA0 Offset: 0x4405A0 VA: 0x180441BA0 Slot: 9
	public override string get_Name() { }
}

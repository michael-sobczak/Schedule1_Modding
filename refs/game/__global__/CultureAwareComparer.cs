public sealed class CultureAwareComparer : StringComparer, ISerializable // TypeDefIndex: 3726
{
	// Fields
	private readonly CompareInfo _compareInfo; // 0x10
	private CompareOptions _options; // 0x18

	// Methods

	// RVA: 0x1C7FD60 Offset: 0x1C7E760 VA: 0x181C7FD60
	internal void .ctor(CultureInfo culture, CompareOptions options) { }

	// RVA: 0x1C80120 Offset: 0x1C7EB20 VA: 0x181C80120
	internal void .ctor(CompareInfo compareInfo, CompareOptions options) { }

	// RVA: 0x1C7FE70 Offset: 0x1C7E870 VA: 0x181C7FE70
	private void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1C7FA70 Offset: 0x1C7E470 VA: 0x181C7FA70 Slot: 10
	public override int Compare(string x, string y) { }

	// RVA: 0x1C7FAE0 Offset: 0x1C7E4E0 VA: 0x181C7FAE0 Slot: 11
	public override bool Equals(string x, string y) { }

	// RVA: 0x1C7FC10 Offset: 0x1C7E610 VA: 0x181C7FC10 Slot: 12
	public override int GetHashCode(string obj) { }

	// RVA: 0x1C7FB40 Offset: 0x1C7E540 VA: 0x181C7FB40 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1C7FBD0 Offset: 0x1C7E5D0 VA: 0x181C7FBD0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1C7FC90 Offset: 0x1C7E690 VA: 0x181C7FC90 Slot: 13
	public void GetObjectData(SerializationInfo info, StreamingContext context) { }
}

internal class BsonArray : BsonToken, IEnumerable<BsonToken>, IEnumerable // TypeDefIndex: 11438
{
	// Fields
	private readonly List<BsonToken> _children; // 0x20

	// Properties
	public override BsonType Type { get; }

	// Methods

	// RVA: 0x1DEB0D0 Offset: 0x1DE9AD0 VA: 0x181DEB0D0
	public void Add(BsonToken token) { }

	// RVA: 0x1DEB2A0 Offset: 0x1DE9CA0 VA: 0x181DEB2A0 Slot: 4
	public override BsonType get_Type() { }

	// RVA: 0x1DEB190 Offset: 0x1DE9B90 VA: 0x181DEB190 Slot: 5
	public IEnumerator<BsonToken> GetEnumerator() { }

	// RVA: 0x1DEB210 Offset: 0x1DE9C10 VA: 0x181DEB210 Slot: 6
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x1DEB220 Offset: 0x1DE9C20 VA: 0x181DEB220
	public void .ctor() { }
}

internal class BsonObject : BsonToken, IEnumerable<BsonProperty>, IEnumerable // TypeDefIndex: 11437
{
	// Fields
	private readonly List<BsonProperty> _children; // 0x20

	// Properties
	public override BsonType Type { get; }

	// Methods

	// RVA: 0x1DED050 Offset: 0x1DEBA50 VA: 0x181DED050
	public void Add(string name, BsonToken token) { }

	// RVA: 0x1DED2D0 Offset: 0x1DEBCD0 VA: 0x181DED2D0 Slot: 4
	public override BsonType get_Type() { }

	// RVA: 0x1DED1C0 Offset: 0x1DEBBC0 VA: 0x181DED1C0 Slot: 5
	public IEnumerator<BsonProperty> GetEnumerator() { }

	// RVA: 0x1DED240 Offset: 0x1DEBC40 VA: 0x181DED240 Slot: 6
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x1DED250 Offset: 0x1DEBC50 VA: 0x181DED250
	public void .ctor() { }
}

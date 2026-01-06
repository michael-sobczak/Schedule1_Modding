public class ASN1 // TypeDefIndex: 17477
{
	// Fields
	private byte m_nTag; // 0x10
	private byte[] m_aValue; // 0x18
	private ArrayList elist; // 0x20

	// Properties
	public int Count { get; }
	public byte Tag { get; }
	public int Length { get; }
	public byte[] Value { get; set; }
	public ASN1 Item { get; }

	// Methods

	// RVA: 0x1A55B90 Offset: 0x1A54590 VA: 0x181A55B90
	public void .ctor(byte tag) { }

	// RVA: 0x1A55BD0 Offset: 0x1A545D0 VA: 0x181A55BD0
	public void .ctor(byte tag, byte[] data) { }

	// RVA: 0x1A55A00 Offset: 0x1A54400 VA: 0x181A55A00
	public void .ctor(byte[] data) { }

	// RVA: 0x1A55C20 Offset: 0x1A54620 VA: 0x181A55C20
	public int get_Count() { }

	// RVA: 0x498A40 Offset: 0x497440 VA: 0x180498A40
	public byte get_Tag() { }

	// RVA: 0x1A55D20 Offset: 0x1A54720 VA: 0x181A55D20
	public int get_Length() { }

	// RVA: 0x1A55D40 Offset: 0x1A54740 VA: 0x181A55D40
	public byte[] get_Value() { }

	// RVA: 0x1A55DE0 Offset: 0x1A547E0 VA: 0x181A55DE0
	public void set_Value(byte[] value) { }

	// RVA: 0x1A54BC0 Offset: 0x1A535C0 VA: 0x181A54BC0
	private bool CompareArray(byte[] array1, byte[] array2) { }

	// RVA: 0x1A54C40 Offset: 0x1A53640 VA: 0x181A54C40
	public bool CompareValue(byte[] value) { }

	// RVA: 0x1A54B20 Offset: 0x1A53520 VA: 0x181A54B20
	public ASN1 Add(ASN1 asn1) { }

	// RVA: 0x1A550B0 Offset: 0x1A53AB0 VA: 0x181A550B0 Slot: 4
	public virtual byte[] GetBytes() { }

	// RVA: 0x1A54DE0 Offset: 0x1A537E0 VA: 0x181A54DE0
	protected void Decode(byte[] asn1, ref int anPos, int anLength) { }

	// RVA: 0x1A54CC0 Offset: 0x1A536C0 VA: 0x181A54CC0
	protected void DecodeTLV(byte[] asn1, ref int pos, out byte tag, out int length, out byte[] content) { }

	// RVA: 0x1A55C50 Offset: 0x1A54650 VA: 0x181A55C50
	public ASN1 get_Item(int index) { }

	// RVA: 0x1A54FC0 Offset: 0x1A539C0 VA: 0x181A54FC0
	public ASN1 Element(int index, byte anTag) { }

	// RVA: 0x1A556E0 Offset: 0x1A540E0 VA: 0x181A556E0 Slot: 3
	public override string ToString() { }
}

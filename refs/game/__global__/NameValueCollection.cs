public class NameValueCollection : NameObjectCollectionBase // TypeDefIndex: 9854
{
	// Fields
	private string[] _all; // 0x50
	private string[] _allKeys; // 0x58

	// Properties
	public string Item { get; set; }
	public string Item { get; }
	public virtual string[] AllKeys { get; }

	// Methods

	// RVA: 0x26AF1A0 Offset: 0x26ADBA0 VA: 0x1826AF1A0
	public void .ctor() { }

	// RVA: 0x26AF0D0 Offset: 0x26ADAD0 VA: 0x1826AF0D0
	public void .ctor(IEqualityComparer equalityComparer) { }

	// RVA: 0x26AF050 Offset: 0x26ADA50 VA: 0x1826AF050
	public void .ctor(int capacity, IEqualityComparer equalityComparer) { }

	// RVA: 0x26AF130 Offset: 0x26ADB30 VA: 0x1826AF130
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x26AEE10 Offset: 0x26AD810 VA: 0x1826AEE10
	protected void InvalidateCachedArrays() { }

	// RVA: 0x26AE8D0 Offset: 0x26AD2D0 VA: 0x1826AE8D0
	private static string GetAsOneString(ArrayList list) { }

	// RVA: 0x26AEAD0 Offset: 0x26AD4D0 VA: 0x1826AEAD0
	private static string[] GetAsStringArray(ArrayList list) { }

	// RVA: 0x26AE740 Offset: 0x26AD140 VA: 0x1826AE740 Slot: 15
	public virtual void Add(string name, string value) { }

	// RVA: 0x26AED70 Offset: 0x26AD770 VA: 0x1826AED70 Slot: 16
	public virtual string Get(string name) { }

	// RVA: 0x26AEB90 Offset: 0x26AD590 VA: 0x1826AEB90 Slot: 17
	public virtual string[] GetValues(string name) { }

	// RVA: 0x26AEEA0 Offset: 0x26AD8A0 VA: 0x1826AEEA0 Slot: 18
	public virtual void Set(string name, string value) { }

	// RVA: 0x26AEE50 Offset: 0x26AD850 VA: 0x1826AEE50 Slot: 19
	public virtual void Remove(string name) { }

	// RVA: 0x1FB7A60 Offset: 0x1FB6460 VA: 0x181FB7A60
	public string get_Item(string name) { }

	// RVA: 0x26AF400 Offset: 0x26ADE00 VA: 0x1826AF400
	public void set_Item(string name, string value) { }

	// RVA: 0x26AECD0 Offset: 0x26AD6D0 VA: 0x1826AECD0 Slot: 20
	public virtual string Get(int index) { }

	// RVA: 0x26AEC30 Offset: 0x26AD630 VA: 0x1826AEC30 Slot: 21
	public virtual string[] GetValues(int index) { }

	// RVA: 0x26AEB80 Offset: 0x26AD580 VA: 0x1826AEB80 Slot: 22
	public virtual string GetKey(int index) { }

	// RVA: 0xD53E50 Offset: 0xD52850 VA: 0x180D53E50
	public string get_Item(int index) { }

	// RVA: 0x26AF280 Offset: 0x26ADC80 VA: 0x1826AF280 Slot: 23
	public virtual string[] get_AllKeys() { }

	// RVA: 0x26AF230 Offset: 0x26ADC30 VA: 0x1826AF230
	internal void .ctor(DBNull dummy) { }
}

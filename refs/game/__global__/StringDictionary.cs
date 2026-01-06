public class StringDictionary : IEnumerable // TypeDefIndex: 9860
{
	// Fields
	internal Hashtable contents; // 0x10

	// Properties
	public virtual int Count { get; }
	public virtual string Item { get; }

	// Methods

	// RVA: 0x26B51B0 Offset: 0x26B3BB0 VA: 0x1826B51B0
	public void .ctor() { }

	// RVA: 0x21C3E50 Offset: 0x21C2850 VA: 0x1821C3E50 Slot: 5
	public virtual int get_Count() { }

	// RVA: 0x26B5220 Offset: 0x26B3C20 VA: 0x1826B5220 Slot: 6
	public virtual string get_Item(string key) { }

	// RVA: 0x26B4FF0 Offset: 0x26B39F0 VA: 0x1826B4FF0 Slot: 7
	public virtual void Add(string key, string value) { }

	// RVA: 0x1B565B0 Offset: 0x1B54FB0 VA: 0x181B565B0 Slot: 8
	public virtual void Clear() { }

	// RVA: 0x26B5090 Offset: 0x26B3A90 VA: 0x1826B5090 Slot: 9
	public virtual bool ContainsKey(string key) { }

	// RVA: 0x1ABB2C0 Offset: 0x1AB9CC0 VA: 0x181ABB2C0 Slot: 10
	public virtual IEnumerator GetEnumerator() { }

	// RVA: 0x26B5120 Offset: 0x26B3B20 VA: 0x1826B5120 Slot: 11
	public virtual void Remove(string key) { }
}

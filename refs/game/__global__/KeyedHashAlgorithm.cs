public abstract class KeyedHashAlgorithm : HashAlgorithm // TypeDefIndex: 4206
{
	// Fields
	protected byte[] KeyValue; // 0x28

	// Properties
	public virtual byte[] Key { get; set; }

	// Methods

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	protected void .ctor() { }

	// RVA: 0x1AE70C0 Offset: 0x1AE5AC0 VA: 0x181AE70C0 Slot: 12
	protected override void Dispose(bool disposing) { }

	// RVA: 0x1AE7110 Offset: 0x1AE5B10 VA: 0x181AE7110 Slot: 19
	public virtual byte[] get_Key() { }

	// RVA: 0x1AE7190 Offset: 0x1AE5B90 VA: 0x181AE7190 Slot: 20
	public virtual void set_Key(byte[] value) { }
}

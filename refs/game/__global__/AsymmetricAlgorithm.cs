public abstract class AsymmetricAlgorithm : IDisposable // TypeDefIndex: 4182
{
	// Fields
	protected int KeySizeValue; // 0x10
	protected KeySizes[] LegalKeySizesValue; // 0x18

	// Properties
	public virtual int KeySize { get; set; }

	// Methods

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	protected void .ctor() { }

	// RVA: 0x1AE2530 Offset: 0x1AE0F30 VA: 0x181AE2530 Slot: 4
	public void Dispose() { }

	// RVA: 0x1AE2530 Offset: 0x1AE0F30 VA: 0x181AE2530
	public void Clear() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 5
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x43C220 Offset: 0x43AC20 VA: 0x18043C220 Slot: 6
	public virtual int get_KeySize() { }

	// RVA: 0x1AE2620 Offset: 0x1AE1020 VA: 0x181AE2620 Slot: 7
	public virtual void set_KeySize(int value) { }

	// RVA: 0x1AE25A0 Offset: 0x1AE0FA0 VA: 0x181AE25A0 Slot: 8
	public virtual void FromXmlString(string xmlString) { }

	// RVA: 0x1AE25E0 Offset: 0x1AE0FE0 VA: 0x181AE25E0 Slot: 9
	public virtual string ToXmlString(bool includePrivateParameters) { }
}

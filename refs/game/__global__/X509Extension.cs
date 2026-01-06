public class X509Extension // TypeDefIndex: 17496
{
	// Fields
	protected string extnOid; // 0x10
	protected bool extnCritical; // 0x18
	protected ASN1 extnValue; // 0x20

	// Properties
	public string Oid { get; }
	public bool Critical { get; }
	public ASN1 Value { get; }

	// Methods

	// RVA: 0x1A6CD50 Offset: 0x1A6B750 VA: 0x181A6CD50
	public void .ctor(ASN1 asn1) { }

	// RVA: 0x1A6D080 Offset: 0x1A6BA80 VA: 0x181A6D080
	public void .ctor(X509Extension extension) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 4
	protected virtual void Decode() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 5
	protected virtual void Encode() { }

	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	public string get_Oid() { }

	// RVA: 0x4971B0 Offset: 0x495BB0 VA: 0x1804971B0
	public bool get_Critical() { }

	// RVA: 0x1A6D210 Offset: 0x1A6BC10 VA: 0x181A6D210
	public ASN1 get_Value() { }

	// RVA: 0x1A6C890 Offset: 0x1A6B290 VA: 0x181A6C890 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1A67980 Offset: 0x1A66380 VA: 0x181A67980 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1A6CB10 Offset: 0x1A6B510 VA: 0x181A6CB10
	private void WriteLine(StringBuilder sb, int n, int pos) { }

	// RVA: 0x1A6C9F0 Offset: 0x1A6B3F0 VA: 0x181A6C9F0 Slot: 3
	public override string ToString() { }
}

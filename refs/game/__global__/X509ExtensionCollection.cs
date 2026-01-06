public sealed class X509ExtensionCollection : CollectionBase, IEnumerable // TypeDefIndex: 17497
{
	// Fields
	private bool readOnly; // 0x18

	// Properties
	public X509Extension Item { get; }

	// Methods

	// RVA: 0x1A67BB0 Offset: 0x1A665B0 VA: 0x181A67BB0
	public void .ctor() { }

	// RVA: 0x1A6C540 Offset: 0x1A6AF40 VA: 0x181A6C540
	public void .ctor(ASN1 asn1) { }

	// RVA: 0x1A6C3D0 Offset: 0x1A6ADD0 VA: 0x181A6C3D0
	public int IndexOf(string oid) { }

	// RVA: 0x1A67B80 Offset: 0x1A66580 VA: 0x181A67B80 Slot: 19
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x1A6C690 Offset: 0x1A6B090 VA: 0x181A6C690
	public X509Extension get_Item(string oid) { }
}

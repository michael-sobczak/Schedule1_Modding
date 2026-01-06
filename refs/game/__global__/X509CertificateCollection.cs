public class X509CertificateCollection : CollectionBase, IEnumerable // TypeDefIndex: 17493
{
	// Properties
	public X509Certificate Item { get; }

	// Methods

	// RVA: 0x1A67BB0 Offset: 0x1A665B0 VA: 0x181A67BB0
	public void .ctor() { }

	// RVA: 0x1A67BC0 Offset: 0x1A665C0 VA: 0x181A67BC0
	public X509Certificate get_Item(int index) { }

	// RVA: 0x1A677C0 Offset: 0x1A661C0 VA: 0x181A677C0
	public int Add(X509Certificate value) { }

	// RVA: 0x1A67660 Offset: 0x1A66060 VA: 0x181A67660
	public void AddRange(X509CertificateCollection value) { }

	// RVA: 0x1A678C0 Offset: 0x1A662C0 VA: 0x181A678C0
	public bool Contains(X509Certificate value) { }

	// RVA: 0x1A678E0 Offset: 0x1A662E0 VA: 0x181A678E0
	public X509CertificateCollection.X509CertificateEnumerator GetEnumerator() { }

	// RVA: 0x1A67B80 Offset: 0x1A66580 VA: 0x181A67B80 Slot: 19
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x1A67980 Offset: 0x1A66380 VA: 0x181A67980 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1A679B0 Offset: 0x1A663B0 VA: 0x181A679B0
	public int IndexOf(X509Certificate value) { }

	// RVA: 0x1A67850 Offset: 0x1A66250 VA: 0x181A67850
	private bool Compare(byte[] array1, byte[] array2) { }
}

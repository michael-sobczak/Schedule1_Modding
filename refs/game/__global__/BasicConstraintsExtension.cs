public class BasicConstraintsExtension : X509Extension // TypeDefIndex: 17520
{
	// Fields
	private bool cA; // 0x28
	private int pathLenConstraint; // 0x2C

	// Properties
	public bool CertificateAuthority { get; }

	// Methods

	// RVA: 0x1A56810 Offset: 0x1A55210 VA: 0x181A56810
	public void .ctor(X509Extension extension) { }

	// RVA: 0x1A568A0 Offset: 0x1A552A0 VA: 0x181A568A0 Slot: 4
	protected override void Decode() { }

	// RVA: 0x1A569E0 Offset: 0x1A553E0 VA: 0x181A569E0 Slot: 5
	protected override void Encode() { }

	// RVA: 0x493120 Offset: 0x491B20 VA: 0x180493120
	public bool get_CertificateAuthority() { }

	// RVA: 0x1A56BC0 Offset: 0x1A555C0 VA: 0x181A56BC0 Slot: 3
	public override string ToString() { }
}

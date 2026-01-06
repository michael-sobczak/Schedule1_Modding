internal abstract class X509CertificateImpl : IDisposable // TypeDefIndex: 4256
{
	// Properties
	public abstract bool IsValid { get; }
	public abstract string Issuer { get; }
	public abstract string Subject { get; }
	public abstract byte[] RawData { get; }
	public abstract DateTime NotAfter { get; }
	public abstract DateTime NotBefore { get; }
	public abstract byte[] Thumbprint { get; }
	public abstract string KeyAlgorithm { get; }
	public abstract byte[] KeyAlgorithmParameters { get; }
	public abstract byte[] PublicKeyValue { get; }
	public abstract byte[] SerialNumber { get; }
	public abstract bool HasPrivateKey { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 5
	public abstract bool get_IsValid();

	// RVA: 0x1B20DA0 Offset: 0x1B1F7A0 VA: 0x181B20DA0
	protected void ThrowIfContextInvalid() { }

	// RVA: -1 Offset: -1 Slot: 6
	public abstract X509CertificateImpl Clone();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract string get_Issuer();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract string get_Subject();

	// RVA: -1 Offset: -1 Slot: 9
	public abstract byte[] get_RawData();

	// RVA: -1 Offset: -1 Slot: 10
	public abstract DateTime get_NotAfter();

	// RVA: -1 Offset: -1 Slot: 11
	public abstract DateTime get_NotBefore();

	// RVA: -1 Offset: -1 Slot: 12
	public abstract byte[] get_Thumbprint();

	// RVA: 0x1B20D10 Offset: 0x1B1F710 VA: 0x181B20D10 Slot: 2
	public sealed override int GetHashCode() { }

	// RVA: -1 Offset: -1 Slot: 13
	public abstract string get_KeyAlgorithm();

	// RVA: -1 Offset: -1 Slot: 14
	public abstract byte[] get_KeyAlgorithmParameters();

	// RVA: -1 Offset: -1 Slot: 15
	public abstract byte[] get_PublicKeyValue();

	// RVA: -1 Offset: -1 Slot: 16
	public abstract byte[] get_SerialNumber();

	// RVA: -1 Offset: -1 Slot: 17
	public abstract bool get_HasPrivateKey();

	// RVA: -1 Offset: -1 Slot: 18
	public abstract RSA GetRSAPrivateKey();

	// RVA: -1 Offset: -1 Slot: 19
	public abstract DSA GetDSAPrivateKey();

	// RVA: -1 Offset: -1 Slot: 20
	public abstract byte[] Export(X509ContentType contentType, SafePasswordHandle password);

	// RVA: 0x1B20B00 Offset: 0x1B1F500 VA: 0x181B20B00 Slot: 0
	public sealed override bool Equals(object obj) { }

	// RVA: 0x1B20A90 Offset: 0x1B1F490 VA: 0x181B20A90 Slot: 4
	public void Dispose() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 21
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x1B20CA0 Offset: 0x1B1F6A0 VA: 0x181B20CA0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	protected void .ctor() { }
}

public sealed class DSACryptoServiceProvider : DSA // TypeDefIndex: 4243
{
	// Fields
	private KeyPairPersistence store; // 0x20
	private bool persistKey; // 0x28
	private bool persisted; // 0x29
	private bool privateKeyExportable; // 0x2A
	private bool m_disposed; // 0x2B
	private DSAManaged dsa; // 0x30
	private static bool useMachineKeyStore; // 0x0

	// Properties
	public override int KeySize { get; }
	[ComVisible(False)]
	public bool PublicOnly { get; }

	// Methods

	// RVA: 0x1AF6580 Offset: 0x1AF4F80 VA: 0x181AF6580
	public void .ctor() { }

	// RVA: 0x1AF6540 Offset: 0x1AF4F40 VA: 0x181AF6540
	public void .ctor(int dwKeySize) { }

	// RVA: 0x1AF6170 Offset: 0x1AF4B70 VA: 0x181AF6170
	private void Common(int dwKeySize, bool parameters) { }

	// RVA: 0x4D8670 Offset: 0x4D7070 VA: 0x1804D8670 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x1AF65B0 Offset: 0x1AF4FB0 VA: 0x181AF65B0 Slot: 6
	public override int get_KeySize() { }

	// RVA: 0x1AF65E0 Offset: 0x1AF4FE0 VA: 0x181AF65E0
	public bool get_PublicOnly() { }

	// RVA: 0x1AF63B0 Offset: 0x1AF4DB0 VA: 0x181AF63B0 Slot: 11
	public override DSAParameters ExportParameters(bool includePrivateParameters) { }

	// RVA: 0x1AEAFF0 Offset: 0x1AE99F0 VA: 0x181AEAFF0 Slot: 12
	public override void ImportParameters(DSAParameters parameters) { }

	// RVA: 0x1AF6510 Offset: 0x1AF4F10 VA: 0x181AF6510 Slot: 10
	public override bool VerifySignature(byte[] rgbHash, byte[] rgbSignature) { }

	// RVA: 0x1AEAC20 Offset: 0x1AE9620 VA: 0x181AEAC20 Slot: 5
	protected override void Dispose(bool disposing) { }

	// RVA: 0x1AF6480 Offset: 0x1AF4E80 VA: 0x181AF6480
	private void OnKeyGenerated(object sender, EventArgs e) { }
}

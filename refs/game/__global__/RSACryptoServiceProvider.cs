public sealed class RSACryptoServiceProvider : RSA // TypeDefIndex: 4221
{
	// Fields
	private static CspProviderFlags s_UseMachineKeyStore; // 0x0
	private KeyPairPersistence store; // 0x20
	private bool persistKey; // 0x28
	private bool persisted; // 0x29
	private bool privateKeyExportable; // 0x2A
	private bool m_disposed; // 0x2B
	private RSAManaged rsa; // 0x30

	// Properties
	public static bool UseMachineKeyStore { get; }
	public override int KeySize { get; }
	[ComVisible(False)]
	public bool PublicOnly { get; }

	// Methods

	// RVA: 0x1AEB770 Offset: 0x1AEA170 VA: 0x181AEB770
	public static bool get_UseMachineKeyStore() { }

	// RVA: 0x1AEB6F0 Offset: 0x1AEA0F0 VA: 0x181AEB6F0
	public void .ctor() { }

	// RVA: 0x1AEB5A0 Offset: 0x1AE9FA0 VA: 0x181AEB5A0
	public void .ctor(CspParameters parameters) { }

	// RVA: 0x1AEB410 Offset: 0x1AE9E10 VA: 0x181AEB410
	public void .ctor(int dwKeySize) { }

	// RVA: 0x1AEB450 Offset: 0x1AE9E50 VA: 0x181AEB450
	public void .ctor(int dwKeySize, CspParameters parameters) { }

	// RVA: 0x1AEA860 Offset: 0x1AE9260 VA: 0x181AEA860
	private void Common(int dwKeySize, bool parameters) { }

	// RVA: 0x1AEAAF0 Offset: 0x1AE94F0 VA: 0x181AEAAF0
	private void Common(CspParameters p) { }

	// RVA: 0x4D8670 Offset: 0x4D7070 VA: 0x1804D8670 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x1AEB720 Offset: 0x1AEA120 VA: 0x181AEB720 Slot: 6
	public override int get_KeySize() { }

	// RVA: 0x1AEB750 Offset: 0x1AEA150 VA: 0x181AEB750
	public bool get_PublicOnly() { }

	// RVA: 0x1AEAC70 Offset: 0x1AE9670 VA: 0x181AEAC70 Slot: 10
	public override byte[] EncryptValue(byte[] rgb) { }

	// RVA: 0x1AEACA0 Offset: 0x1AE96A0 VA: 0x181AEACA0 Slot: 11
	public override RSAParameters ExportParameters(bool includePrivateParameters) { }

	// RVA: 0x1AEAFF0 Offset: 0x1AE99F0 VA: 0x181AEAFF0 Slot: 12
	public override void ImportParameters(RSAParameters parameters) { }

	// RVA: 0x1AEAE40 Offset: 0x1AE9840 VA: 0x181AEAE40
	private string GetHashNameFromOID(string oid) { }

	// RVA: 0x1AEB0E0 Offset: 0x1AE9AE0 VA: 0x181AEB0E0
	public bool VerifyHash(byte[] rgbHash, string str, byte[] rgbSignature) { }

	// RVA: 0x1AEAC20 Offset: 0x1AE9620 VA: 0x181AEAC20 Slot: 5
	protected override void Dispose(bool disposing) { }

	// RVA: 0x1AEB050 Offset: 0x1AE9A50 VA: 0x181AEB050
	private void OnKeyGenerated(object sender, EventArgs e) { }
}

public sealed class X509EnhancedKeyUsageExtension : X509Extension // TypeDefIndex: 9644
{
	// Fields
	private OidCollection _enhKeyUsage; // 0x28
	private AsnDecodeStatus _status; // 0x30

	// Properties
	public OidCollection EnhancedKeyUsages { get; }

	// Methods

	// RVA: 0x26577F0 Offset: 0x26561F0 VA: 0x1826577F0
	public void .ctor() { }

	// RVA: 0x2657880 Offset: 0x2656280 VA: 0x182657880
	public void .ctor(AsnEncodedData encodedEnhancedKeyUsages, bool critical) { }

	// RVA: 0x2657960 Offset: 0x2656360 VA: 0x182657960
	public void .ctor(OidCollection enhancedKeyUsages, bool critical) { }

	// RVA: 0x2657BC0 Offset: 0x26565C0 VA: 0x182657BC0
	public OidCollection get_EnhancedKeyUsages() { }

	// RVA: 0x26570A0 Offset: 0x2655AA0 VA: 0x1826570A0 Slot: 4
	public override void CopyFrom(AsnEncodedData asnEncodedData) { }

	// RVA: 0x2657280 Offset: 0x2655C80 VA: 0x182657280
	internal AsnDecodeStatus Decode(byte[] extension) { }

	// RVA: 0x2657460 Offset: 0x2655E60 VA: 0x182657460
	internal byte[] Encode() { }

	// RVA: 0x2657530 Offset: 0x2655F30 VA: 0x182657530 Slot: 6
	internal override string ToString(bool multiLine) { }
}

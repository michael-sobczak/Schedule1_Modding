public sealed class X509SubjectKeyIdentifierExtension : X509Extension // TypeDefIndex: 9651
{
	// Fields
	internal const string oid = "2.5.29.14";
	internal const string friendlyName = "Subject Key Identifier";
	private byte[] _subjectKeyIdentifier; // 0x28
	private string _ski; // 0x30
	private AsnDecodeStatus _status; // 0x38

	// Properties
	public string SubjectKeyIdentifier { get; }

	// Methods

	// RVA: 0x265AE30 Offset: 0x2659830 VA: 0x18265AE30
	public void .ctor() { }

	// RVA: 0x265A890 Offset: 0x2659290 VA: 0x18265A890
	public void .ctor(AsnEncodedData encodedSubjectKeyIdentifier, bool critical) { }

	// RVA: 0x265A970 Offset: 0x2659370 VA: 0x18265A970
	public void .ctor(byte[] subjectKeyIdentifier, bool critical) { }

	// RVA: 0x265AB60 Offset: 0x2659560 VA: 0x18265AB60
	public void .ctor(string subjectKeyIdentifier, bool critical) { }

	// RVA: 0x265A870 Offset: 0x2659270 VA: 0x18265A870
	public void .ctor(PublicKey key, bool critical) { }

	// RVA: 0x265A450 Offset: 0x2658E50 VA: 0x18265A450
	public void .ctor(PublicKey key, X509SubjectKeyIdentifierHashAlgorithm algorithm, bool critical) { }

	// RVA: 0x265AEC0 Offset: 0x26598C0 VA: 0x18265AEC0
	public string get_SubjectKeyIdentifier() { }

	// RVA: 0x2659C10 Offset: 0x2658610 VA: 0x182659C10 Slot: 4
	public override void CopyFrom(AsnEncodedData asnEncodedData) { }

	// RVA: 0x2659FC0 Offset: 0x26589C0 VA: 0x182659FC0
	internal static byte FromHexChar(char c) { }

	// RVA: 0x2659FF0 Offset: 0x26589F0 VA: 0x182659FF0
	internal static byte FromHexChars(char c1, char c2) { }

	// RVA: 0x265A070 Offset: 0x2658A70 VA: 0x18265A070
	internal static byte[] FromHex(string hex) { }

	// RVA: 0x2659DF0 Offset: 0x26587F0 VA: 0x182659DF0
	internal AsnDecodeStatus Decode(byte[] extension) { }

	// RVA: 0x2659F40 Offset: 0x2658940 VA: 0x182659F40
	internal byte[] Encode() { }

	// RVA: 0x265A200 Offset: 0x2658C00 VA: 0x18265A200 Slot: 6
	internal override string ToString(bool multiLine) { }
}

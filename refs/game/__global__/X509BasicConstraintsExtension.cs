public sealed class X509BasicConstraintsExtension : X509Extension // TypeDefIndex: 9626
{
	// Fields
	internal const string oid = "2.5.29.19";
	internal const string friendlyName = "Basic Constraints";
	private bool _certificateAuthority; // 0x28
	private bool _hasPathLengthConstraint; // 0x29
	private int _pathLengthConstraint; // 0x2C
	private AsnDecodeStatus _status; // 0x30

	// Properties
	public bool CertificateAuthority { get; }
	public bool HasPathLengthConstraint { get; }
	public int PathLengthConstraint { get; }

	// Methods

	// RVA: 0x264A430 Offset: 0x2648E30 VA: 0x18264A430
	public void .ctor() { }

	// RVA: 0x264A4C0 Offset: 0x2648EC0 VA: 0x18264A4C0
	public void .ctor(AsnEncodedData encodedBasicConstraints, bool critical) { }

	// RVA: 0x264A1C0 Offset: 0x2648BC0 VA: 0x18264A1C0
	public void .ctor(bool certificateAuthority, bool hasPathLengthConstraint, int pathLengthConstraint, bool critical) { }

	// RVA: 0x264A5A0 Offset: 0x2648FA0 VA: 0x18264A5A0
	public bool get_CertificateAuthority() { }

	// RVA: 0x264A610 Offset: 0x2649010 VA: 0x18264A610
	public bool get_HasPathLengthConstraint() { }

	// RVA: 0x264A680 Offset: 0x2649080 VA: 0x18264A680
	public int get_PathLengthConstraint() { }

	// RVA: 0x2649A90 Offset: 0x2648490 VA: 0x182649A90 Slot: 4
	public override void CopyFrom(AsnEncodedData asnEncodedData) { }

	// RVA: 0x2649C70 Offset: 0x2648670 VA: 0x182649C70
	internal AsnDecodeStatus Decode(byte[] extension) { }

	// RVA: 0x2649DE0 Offset: 0x26487E0 VA: 0x182649DE0
	internal byte[] Encode() { }

	// RVA: 0x2649F60 Offset: 0x2648960 VA: 0x182649F60 Slot: 6
	internal override string ToString(bool multiLine) { }
}

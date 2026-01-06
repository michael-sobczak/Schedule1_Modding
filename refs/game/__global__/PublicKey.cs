public sealed class PublicKey // TypeDefIndex: 9624
{
	// Fields
	private AsnEncodedData _keyValue; // 0x10
	private AsnEncodedData _params; // 0x18
	private Oid _oid; // 0x20
	private static byte[] Empty; // 0x0

	// Properties
	public AsnEncodedData EncodedKeyValue { get; }
	public AsnEncodedData EncodedParameters { get; }
	public AsymmetricAlgorithm Key { get; }
	public Oid Oid { get; }

	// Methods

	// RVA: 0x2648970 Offset: 0x2647370 VA: 0x182648970
	public void .ctor(Oid oid, AsnEncodedData parameters, AsnEncodedData keyValue) { }

	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	public AsnEncodedData get_EncodedKeyValue() { }

	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	public AsnEncodedData get_EncodedParameters() { }

	// RVA: 0x2648B60 Offset: 0x2647560 VA: 0x182648B60
	public AsymmetricAlgorithm get_Key() { }

	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	public Oid get_Oid() { }

	// RVA: 0x2648860 Offset: 0x2647260 VA: 0x182648860
	private static byte[] GetUnsignedBigInteger(byte[] integer) { }

	// RVA: 0x2647FF0 Offset: 0x26469F0 VA: 0x182647FF0
	internal static DSA DecodeDSA(byte[] rawPublicKey, byte[] rawParameters) { }

	// RVA: 0x2648500 Offset: 0x2646F00 VA: 0x182648500
	internal static RSA DecodeRSA(byte[] rawPublicKey) { }

	// RVA: 0x2648900 Offset: 0x2647300 VA: 0x182648900
	private static void .cctor() { }
}

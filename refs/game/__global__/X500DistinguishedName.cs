public sealed class X500DistinguishedName : AsnEncodedData // TypeDefIndex: 9625
{
	// Fields
	private string name; // 0x20
	private byte[] canonEncoding; // 0x28

	// Properties
	public string Name { get; }

	// Methods

	// RVA: 0x2649970 Offset: 0x2648370 VA: 0x182649970
	public void .ctor(byte[] encodedDistinguishedName) { }

	// RVA: 0x26496C0 Offset: 0x26480C0 VA: 0x1826496C0
	public void .ctor(string distinguishedName) { }

	// RVA: 0x26496D0 Offset: 0x26480D0 VA: 0x1826496D0
	public void .ctor(string distinguishedName, X500DistinguishedNameFlags flag) { }

	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	public string get_Name() { }

	// RVA: 0x2649420 Offset: 0x2647E20 VA: 0x182649420
	public string Decode(X500DistinguishedNameFlags flag) { }

	// RVA: 0x26495E0 Offset: 0x2647FE0 VA: 0x1826495E0 Slot: 5
	public override string Format(bool multiLine) { }

	// RVA: 0x2649650 Offset: 0x2648050 VA: 0x182649650
	private static string GetSeparator(X500DistinguishedNameFlags flag) { }

	// RVA: 0x2649330 Offset: 0x2647D30 VA: 0x182649330
	private void DecodeRawData() { }

	// RVA: 0x2649160 Offset: 0x2647B60 VA: 0x182649160
	private static string Canonize(string s) { }

	// RVA: 0x2648F40 Offset: 0x2647940 VA: 0x182648F40
	internal static bool AreEqual(X500DistinguishedName name1, X500DistinguishedName name2) { }
}

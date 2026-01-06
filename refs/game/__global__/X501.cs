public sealed class X501 // TypeDefIndex: 17488
{
	// Fields
	private static byte[] countryName; // 0x0
	private static byte[] organizationName; // 0x8
	private static byte[] organizationalUnitName; // 0x10
	private static byte[] commonName; // 0x18
	private static byte[] localityName; // 0x20
	private static byte[] stateOrProvinceName; // 0x28
	private static byte[] streetAddress; // 0x30
	private static byte[] serialNumber; // 0x38
	private static byte[] domainComponent; // 0x40
	private static byte[] userid; // 0x48
	private static byte[] email; // 0x50
	private static byte[] dnQualifier; // 0x58
	private static byte[] title; // 0x60
	private static byte[] surname; // 0x68
	private static byte[] givenName; // 0x70
	private static byte[] initial; // 0x78

	// Methods

	// RVA: 0x1A66EF0 Offset: 0x1A658F0 VA: 0x181A66EF0
	public static string ToString(ASN1 seq) { }

	// RVA: 0x1A66D00 Offset: 0x1A65700 VA: 0x181A66D00
	public static string ToString(ASN1 seq, bool reversed, string separator, bool quotes) { }

	// RVA: 0x1A64970 Offset: 0x1A63370 VA: 0x181A64970
	private static void AppendEntry(StringBuilder sb, ASN1 entry, bool quotes) { }

	// RVA: 0x1A65740 Offset: 0x1A64140 VA: 0x181A65740
	private static X520.AttributeTypeAndValue GetAttributeFromOid(string attributeType) { }

	// RVA: 0x1A662A0 Offset: 0x1A64CA0 VA: 0x181A662A0
	private static bool IsOid(string oid) { }

	// RVA: 0x1A66390 Offset: 0x1A64D90 VA: 0x181A66390
	private static X520.AttributeTypeAndValue ReadAttribute(string value, ref int pos) { }

	// RVA: 0x1A661D0 Offset: 0x1A64BD0 VA: 0x181A661D0
	private static bool IsHex(char c) { }

	// RVA: 0x1A666D0 Offset: 0x1A650D0 VA: 0x181A666D0
	private static string ReadHex(string value, ref int pos) { }

	// RVA: 0x1A66520 Offset: 0x1A64F20 VA: 0x181A66520
	private static int ReadEscaped(StringBuilder sb, string value, int pos) { }

	// RVA: 0x1A66910 Offset: 0x1A65310 VA: 0x181A66910
	private static int ReadQuoted(StringBuilder sb, string value, int pos) { }

	// RVA: 0x1A66A60 Offset: 0x1A65460 VA: 0x181A66A60
	private static string ReadValue(string value, ref int pos) { }

	// RVA: 0x1A652D0 Offset: 0x1A63CD0 VA: 0x181A652D0
	public static ASN1 FromString(string rdn) { }

	// RVA: 0x1A67040 Offset: 0x1A65A40 VA: 0x181A67040
	private static void .cctor() { }
}

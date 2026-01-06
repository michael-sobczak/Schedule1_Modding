internal static class MailAddressParser // TypeDefIndex: 10219
{
	// Methods

	// RVA: 0x25DBBC0 Offset: 0x25DA5C0 VA: 0x1825DBBC0
	internal static MailAddress ParseAddress(string data) { }

	// RVA: 0x25DB670 Offset: 0x25DA070 VA: 0x1825DB670
	private static MailAddress ParseAddress(string data, bool expectMultipleAddresses, ref int index) { }

	// RVA: 0x25DC590 Offset: 0x25DAF90 VA: 0x1825DC590
	private static int ReadCfwsAndThrowIfIncomplete(string data, int index) { }

	// RVA: 0x25DC020 Offset: 0x25DAA20 VA: 0x1825DC020
	private static string ParseDomain(string data, ref int index) { }

	// RVA: 0x25DC1B0 Offset: 0x25DABB0 VA: 0x1825DC1B0
	private static string ParseLocalPart(string data, ref int index, bool expectAngleBracket, bool expectMultipleAddresses) { }

	// RVA: 0x25DBBF0 Offset: 0x25DA5F0 VA: 0x1825DBBF0
	private static string ParseDisplayName(string data, ref int index, bool expectMultipleAddresses) { }

	// RVA: 0x25DB5E0 Offset: 0x25D9FE0 VA: 0x1825DB5E0
	internal static string NormalizeOrThrow(string input) { }
}

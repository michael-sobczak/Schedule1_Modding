internal class FtpMethodInfo // TypeDefIndex: 9950
{
	// Fields
	internal string Method; // 0x10
	internal FtpOperation Operation; // 0x18
	internal FtpMethodFlags Flags; // 0x1C
	internal string HttpCommand; // 0x20
	private static readonly FtpMethodInfo[] s_knownMethodInfo; // 0x0

	// Properties
	internal bool IsCommandOnly { get; }
	internal bool IsUpload { get; }
	internal bool IsDownload { get; }
	internal bool ShouldParseForResponseUri { get; }

	// Methods

	// RVA: 0x26BDC80 Offset: 0x26BC680 VA: 0x1826BDC80
	internal void .ctor(string method, FtpOperation operation, FtpMethodFlags flags, string httpCommand) { }

	// RVA: 0x26BD3B0 Offset: 0x26BBDB0 VA: 0x1826BD3B0
	internal bool HasFlag(FtpMethodFlags flags) { }

	// RVA: 0x26BDCF0 Offset: 0x26BC6F0 VA: 0x1826BDCF0
	internal bool get_IsCommandOnly() { }

	// RVA: 0x26BDD00 Offset: 0x26BC700 VA: 0x1826BDD00
	internal bool get_IsUpload() { }

	// RVA: 0x23AEDE0 Offset: 0x23AD7E0 VA: 0x1823AEDE0
	internal bool get_IsDownload() { }

	// RVA: 0x26BDD10 Offset: 0x26BC710 VA: 0x1826BDD10
	internal bool get_ShouldParseForResponseUri() { }

	// RVA: 0x26BD240 Offset: 0x26BBC40 VA: 0x1826BD240
	internal static FtpMethodInfo GetMethodInfo(string method) { }

	// RVA: 0x26BD3C0 Offset: 0x26BBDC0 VA: 0x1826BD3C0
	private static void .cctor() { }
}

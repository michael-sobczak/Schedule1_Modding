internal class Win32NetworkInterface // TypeDefIndex: 10151
{
	// Fields
	private static Win32_FIXED_INFO fixedInfo; // 0x0
	private static bool initialized; // 0x58

	// Properties
	public static Win32_FIXED_INFO FixedInfo { get; }

	// Methods

	// RVA: 0x25F60D0 Offset: 0x25F4AD0 VA: 0x1825F60D0
	private static extern int GetNetworkParams(IntPtr ptr, ref int size) { }

	// RVA: 0x25F6160 Offset: 0x25F4B60 VA: 0x1825F6160
	private static extern int MultiByteToWideChar(uint CodePage, uint dwFlags, byte* lpMultiByteStr, int cbMultiByte, char* lpWideCharStr, int cchWideChar) { }

	// RVA: 0x25F6330 Offset: 0x25F4D30 VA: 0x1825F6330
	public static Win32_FIXED_INFO get_FixedInfo() { }

	[CompilerGenerated]
	// RVA: 0x25F6230 Offset: 0x25F4C30 VA: 0x1825F6230
	internal static string <get_FixedInfo>g__GetStringFromMultiByte|5_0(byte* bytes) { }
}

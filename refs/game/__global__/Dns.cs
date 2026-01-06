public static class Dns // TypeDefIndex: 10056
{
	// Methods

	// RVA: 0x25AF060 Offset: 0x25ADA60 VA: 0x1825AF060
	public static IAsyncResult BeginGetHostAddresses(string hostNameOrAddress, AsyncCallback requestCallback, object state) { }

	// RVA: 0x25AF280 Offset: 0x25ADC80 VA: 0x1825AF280
	public static IPAddress[] EndGetHostAddresses(IAsyncResult asyncResult) { }

	// RVA: 0x25AF860 Offset: 0x25AE260 VA: 0x1825AF860
	private static bool GetHostByName_icall(string host, out string h_name, out string[] h_aliases, out string[] h_addr_list, int hint) { }

	// RVA: 0x25AF720 Offset: 0x25AE120 VA: 0x1825AF720
	private static bool GetHostByAddr_icall(string addr, out string h_name, out string[] h_aliases, out string[] h_addr_list, int hint) { }

	// RVA: 0x25AFE00 Offset: 0x25AE800 VA: 0x1825AFE00
	private static bool GetHostName_icall(out string h_name) { }

	// RVA: 0x25AF390 Offset: 0x25ADD90 VA: 0x1825AF390
	private static void Error_11001(string hostName) { }

	// RVA: 0x25AFE50 Offset: 0x25AE850 VA: 0x1825AFE50
	private static IPHostEntry hostent_to_IPHostEntry(string originalHostName, string h_name, string[] h_aliases, string[] h_addrlist) { }

	// RVA: 0x25AF730 Offset: 0x25AE130 VA: 0x1825AF730
	private static IPHostEntry GetHostByAddressFromString(string address, bool parse) { }

	// RVA: 0x25AF970 Offset: 0x25AE370 VA: 0x1825AF970
	public static IPHostEntry GetHostEntry(string hostNameOrAddress) { }

	// RVA: 0x25AFCA0 Offset: 0x25AE6A0 VA: 0x1825AFCA0
	public static IPHostEntry GetHostEntry(IPAddress address) { }

	// RVA: 0x25AF510 Offset: 0x25ADF10 VA: 0x1825AF510
	public static IPAddress[] GetHostAddresses(string hostNameOrAddress) { }

	[Obsolete("Use GetHostEntry instead")]
	// RVA: 0x25AF870 Offset: 0x25AE270 VA: 0x1825AF870
	public static IPHostEntry GetHostByName(string hostName) { }

	// RVA: 0x25AFE10 Offset: 0x25AE810 VA: 0x1825AFE10
	public static string GetHostName() { }

	// RVA: 0x25AF400 Offset: 0x25ADE00 VA: 0x1825AF400
	public static Task<IPAddress[]> GetHostAddressesAsync(string hostNameOrAddress) { }
}

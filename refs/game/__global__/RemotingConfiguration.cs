public static class RemotingConfiguration // TypeDefIndex: 4281
{
	// Fields
	private static string applicationID; // 0x0
	private static string applicationName; // 0x8
	private static string processGuid; // 0x10
	private static bool defaultConfigRead; // 0x18
	private static bool defaultDelayedConfigRead; // 0x19
	private static CustomErrorsModes _errorMode; // 0x1C
	private static Hashtable wellKnownClientEntries; // 0x20
	private static Hashtable activatedClientEntries; // 0x28
	private static Hashtable wellKnownServiceEntries; // 0x30
	private static Hashtable activatedServiceEntries; // 0x38
	private static Hashtable channelTemplates; // 0x40
	private static Hashtable clientProviderTemplates; // 0x48
	private static Hashtable serverProviderTemplates; // 0x50

	// Properties
	public static string ApplicationName { get; set; }
	public static string ProcessId { get; }

	// Methods

	// RVA: 0x1B15620 Offset: 0x1B14020 VA: 0x181B15620
	public static string get_ApplicationName() { }

	// RVA: 0x1B15750 Offset: 0x1B14150 VA: 0x181B15750
	public static void set_ApplicationName(string value) { }

	// RVA: 0x1B15670 Offset: 0x1B14070 VA: 0x181B15670
	public static string get_ProcessId() { }

	// RVA: 0x1B137C0 Offset: 0x1B121C0 VA: 0x181B137C0
	internal static void LoadDefaultDelayedChannels() { }

	// RVA: 0x1B13390 Offset: 0x1B11D90 VA: 0x181B13390
	public static bool IsActivationAllowed(Type svrType) { }

	// RVA: 0x1B134C0 Offset: 0x1B11EC0 VA: 0x181B134C0
	public static ActivatedClientTypeEntry IsRemotelyActivatedClientType(Type svrType) { }

	// RVA: 0x1B13640 Offset: 0x1B12040 VA: 0x181B13640
	public static WellKnownClientTypeEntry IsWellKnownClientType(Type svrType) { }

	// RVA: 0x1B13B00 Offset: 0x1B12500 VA: 0x181B13B00
	public static void RegisterActivatedClientType(ActivatedClientTypeEntry entry) { }

	// RVA: 0x1B13D90 Offset: 0x1B12790 VA: 0x181B13D90
	public static void RegisterActivatedServiceType(ActivatedServiceTypeEntry entry) { }

	// RVA: 0x1B14D00 Offset: 0x1B13700 VA: 0x181B14D00
	public static void RegisterWellKnownClientType(WellKnownClientTypeEntry entry) { }

	// RVA: 0x1B14F90 Offset: 0x1B13990 VA: 0x181B14F90
	public static void RegisterWellKnownServiceType(WellKnownServiceTypeEntry entry) { }

	// RVA: 0x1B13EC0 Offset: 0x1B128C0 VA: 0x181B13EC0
	internal static void RegisterChannelTemplate(ChannelData channel) { }

	// RVA: 0x1B147A0 Offset: 0x1B131A0 VA: 0x181B147A0
	internal static void RegisterClientProviderTemplate(ProviderData prov) { }

	// RVA: 0x1B14820 Offset: 0x1B13220 VA: 0x181B14820
	internal static void RegisterServerProviderTemplate(ProviderData prov) { }

	// RVA: 0x1B13F40 Offset: 0x1B12940 VA: 0x181B13F40
	internal static void RegisterChannels(ArrayList channels, bool onlyDelayed) { }

	// RVA: 0x1B148A0 Offset: 0x1B132A0 VA: 0x181B148A0
	internal static void RegisterTypes(ArrayList types) { }

	// RVA: 0x1B13300 Offset: 0x1B11D00 VA: 0x181B13300
	public static bool CustomErrorsEnabled(bool isLocalRequest) { }

	// RVA: 0x1B15110 Offset: 0x1B13B10 VA: 0x181B15110
	internal static void SetCustomErrorsMode(string mode) { }

	// RVA: 0x1B15350 Offset: 0x1B13D50 VA: 0x181B15350
	private static void .cctor() { }
}

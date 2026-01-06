public sealed class ChannelServices // TypeDefIndex: 4331
{
	// Fields
	private static ArrayList registeredChannels; // 0x0
	private static ArrayList delayedClientChannels; // 0x8
	private static CrossContextChannel _crossContextSink; // 0x10
	internal static string CrossContextUrl; // 0x18
	private static IList oldStartModeTypes; // 0x20

	// Properties
	internal static CrossContextChannel CrossContextChannel { get; }

	// Methods

	// RVA: 0x1B2B500 Offset: 0x1B29F00 VA: 0x181B2B500
	internal static CrossContextChannel get_CrossContextChannel() { }

	// RVA: 0x1B290B0 Offset: 0x1B27AB0 VA: 0x181B290B0
	internal static IMessageSink CreateClientChannelSinkChain(string url, object remoteChannelData, out string objectUri) { }

	// RVA: 0x1B28F90 Offset: 0x1B27990 VA: 0x181B28F90
	internal static IMessageSink CreateClientChannelSinkChain(IChannelSender sender, string url, object[] channelDataArray, out string objectUri) { }

	[Obsolete("Use RegisterChannel(IChannel,Boolean)")]
	// RVA: 0x1B2B1E0 Offset: 0x1B29BE0 VA: 0x181B2B1E0
	public static void RegisterChannel(IChannel chnl) { }

	// RVA: 0x1B2ABB0 Offset: 0x1B295B0 VA: 0x181B2ABB0
	public static void RegisterChannel(IChannel chnl, bool ensureSecurity) { }

	// RVA: 0x1B29D30 Offset: 0x1B28730 VA: 0x181B29D30
	internal static void RegisterChannelConfig(ChannelData channel) { }

	// RVA: 0x1B29670 Offset: 0x1B28070 VA: 0x181B29670
	private static object CreateProvider(ProviderData prov) { }

	// RVA: 0x1B2B230 Offset: 0x1B29C30 VA: 0x181B2B230
	public static IMessage SyncDispatchMessage(IMessage msg) { }

	// RVA: 0x1B28C20 Offset: 0x1B27620 VA: 0x181B28C20
	private static ReturnMessage CheckIncomingMessage(IMessage msg) { }

	// RVA: 0x1B28E20 Offset: 0x1B27820 VA: 0x181B28E20
	internal static IMessage CheckReturnMessage(IMessage callMsg, IMessage retMsg) { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0
	private static bool IsLocalCall(IMessage callMsg) { }

	// RVA: 0x1B299B0 Offset: 0x1B283B0 VA: 0x181B299B0
	internal static object[] GetCurrentChannelInfo() { }

	// RVA: 0x1B2B300 Offset: 0x1B29D00 VA: 0x181B2B300
	private static void .cctor() { }
}

public class NetworkTraficStatistics // TypeDefIndex: 12740
{
	// Fields
	[CompilerGenerated]
	private Action<NetworkTrafficArgs> OnClientNetworkTraffic; // 0x10
	[CompilerGenerated]
	private Action<NetworkTrafficArgs> OnServerNetworkTraffic; // 0x18
	[SerializeField]
	[Range(0, 10)]
	[Tooltip("How often to update traffic statistics.")]
	private float _updateInteval; // 0x20
	[SerializeField]
	[Tooltip("True to update client statistics.")]
	private bool _updateClient; // 0x24
	[Tooltip("True to update server statistics.")]
	[SerializeField]
	private bool _updateServer; // 0x25
	private NetworkManager _networkManager; // 0x28
	private ulong _client_toServerBytes; // 0x30
	private ulong _client_fromServerBytes; // 0x38
	private ulong _server_toClientsBytes; // 0x40
	private ulong _server_fromClientsBytes; // 0x48
	private float _nextUpdateTime; // 0x50
	private static readonly string[] _sizeSuffixes; // 0x0

	// Properties
	public bool UpdateClient { get; set; }
	public bool UpdateServer { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0xD636B0 Offset: 0xD620B0 VA: 0x180D636B0
	public void add_OnClientNetworkTraffic(Action<NetworkTrafficArgs> value) { }

	[CompilerGenerated]
	// RVA: 0xD63810 Offset: 0xD62210 VA: 0x180D63810
	public void remove_OnClientNetworkTraffic(Action<NetworkTrafficArgs> value) { }

	[CompilerGenerated]
	// RVA: 0xD63760 Offset: 0xD62160 VA: 0x180D63760
	public void add_OnServerNetworkTraffic(Action<NetworkTrafficArgs> value) { }

	[CompilerGenerated]
	// RVA: 0xD638C0 Offset: 0xD622C0 VA: 0x180D638C0
	public void remove_OnServerNetworkTraffic(Action<NetworkTrafficArgs> value) { }

	// RVA: 0x563D90 Offset: 0x562790 VA: 0x180563D90
	public bool get_UpdateClient() { }

	// RVA: 0x563E00 Offset: 0x562800 VA: 0x180563E00
	private void set_UpdateClient(bool value) { }

	// RVA: 0x563E00 Offset: 0x562800 VA: 0x180563E00
	public void SetUpdateClient(bool update) { }

	// RVA: 0x563D80 Offset: 0x562780 VA: 0x180563D80
	public bool get_UpdateServer() { }

	// RVA: 0xD63380 Offset: 0xD61D80 VA: 0x180D63380
	private void set_UpdateServer(bool value) { }

	// RVA: 0xD63380 Offset: 0xD61D80 VA: 0x180D63380
	public void SetUpdateServer(bool update) { }

	// RVA: 0xD630D0 Offset: 0xD61AD0 VA: 0x180D630D0
	internal void InitializeOnce_Internal(NetworkManager manager) { }

	// RVA: 0xD63390 Offset: 0xD61D90 VA: 0x180D63390
	private void TimeManager_OnPreTick() { }

	// RVA: 0xD63200 Offset: 0xD61C00 VA: 0x180D63200
	internal void LocalClientSentData(ulong dataLength) { }

	// RVA: 0xD63180 Offset: 0xD61B80 VA: 0x180D63180
	public void LocalClientReceivedData(ulong dataLength) { }

	// RVA: 0xD63300 Offset: 0xD61D00 VA: 0x180D63300
	internal void LocalServerSentData(ulong dataLength) { }

	// RVA: 0xD63280 Offset: 0xD61C80 VA: 0x180D63280
	public void LocalServerReceivedData(ulong dataLength) { }

	// RVA: 0xD62D70 Offset: 0xD61770 VA: 0x180D62D70
	public static string FormatBytesToLargest(ulong bytes) { }

	// RVA: 0x49CD20 Offset: 0x49B720 VA: 0x18049CD20
	public void .ctor() { }

	// RVA: 0xD634B0 Offset: 0xD61EB0 VA: 0x180D634B0
	private static void .cctor() { }
}

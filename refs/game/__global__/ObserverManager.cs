public sealed class ObserverManager : MonoBehaviour // TypeDefIndex: 12789
{
	// Fields
	[CompilerGenerated]
	private byte <LevelOfDetailIndex>k__BackingField; // 0x20
	[FormerlySerializedAs("_useNetworkLod")]
	[Tooltip("True to use the NetworkLOD system.")]
	[SerializeField]
	private bool _enableNetworkLod; // 0x21
	[Tooltip("Distance for each level of detal.")]
	[SerializeField]
	private List<float> _levelOfDetailDistances; // 0x28
	private List<float> _singleLevelOfDetailDistances; // 0x30
	[SerializeField]
	[Tooltip("True to update visibility for clientHost based on if they are an observer or not.")]
	[FormerlySerializedAs("_setHostVisibility")]
	private bool _updateHostVisibility; // 0x38
	[Tooltip("Default observer conditions for networked objects.")]
	[SerializeField]
	private List<ObserverCondition> _defaultConditions; // 0x40
	private NetworkManager _networkManager; // 0x48
	private uint[] _levelOfDetailIntervals; // 0x50

	// Properties
	internal byte LevelOfDetailIndex { get; set; }
	public bool UpdateHostVisibility { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4945E0 Offset: 0x492FE0 VA: 0x1804945E0
	internal byte get_LevelOfDetailIndex() { }

	[CompilerGenerated]
	// RVA: 0x494600 Offset: 0x493000 VA: 0x180494600
	private void set_LevelOfDetailIndex(byte value) { }

	// RVA: 0x563D50 Offset: 0x562750 VA: 0x180563D50
	internal bool GetEnableNetworkLod() { }

	// RVA: 0xD7F7D0 Offset: 0xD7E1D0 VA: 0x180D7F7D0
	internal List<float> GetLevelOfDetailDistances() { }

	// RVA: 0x8D2170 Offset: 0x8D0B70 VA: 0x1808D2170
	public bool get_UpdateHostVisibility() { }

	// RVA: 0x91C530 Offset: 0x91AF30 VA: 0x18091C530
	private void set_UpdateHostVisibility(bool value) { }

	// RVA: 0xD7F850 Offset: 0xD7E250 VA: 0x180D7F850
	internal void InitializeOnce_Internal(NetworkManager manager) { }

	// RVA: 0xD7F870 Offset: 0xD7E270 VA: 0x180D7F870
	public void SetUpdateHostVisibility(bool value, HostVisibilityUpdateTypes updateType) { }

	// RVA: 0xD7F530 Offset: 0xD7DF30 VA: 0x180D7F530
	internal NetworkObserver AddDefaultConditions(NetworkObject nob) { }

	// RVA: 0xD7F7E0 Offset: 0xD7E1E0 VA: 0x180D7F7E0
	public static byte GetLevelOfDetailInterval(byte lodIndex) { }

	// RVA: 0x77D410 Offset: 0x77BE10 VA: 0x18077D410
	internal void CalculateLevelOfDetail(uint tick) { }

	// RVA: 0x820C50 Offset: 0x81F650 VA: 0x180820C50
	private void ValidateLevelOfDetails() { }

	// RVA: 0xD7FBA0 Offset: 0xD7E5A0 VA: 0x180D7FBA0
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0xD25F30 Offset: 0xD24930 VA: 0x180D25F30
	internal static bool <SetUpdateHostVisibility>g__HostVisibilityUpdateContains|17_0(HostVisibilityUpdateTypes whole, HostVisibilityUpdateTypes part) { }

	[CompilerGenerated]
	// RVA: 0xD7FAB0 Offset: 0xD7E4B0 VA: 0x180D7FAB0
	private void <AddDefaultConditions>g__AddMissing|18_0(NetworkObserver networkObserver) { }
}

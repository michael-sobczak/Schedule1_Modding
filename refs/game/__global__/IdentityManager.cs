internal class IdentityManager : IIdentityManager // TypeDefIndex: 17933
{
	// Fields
	internal const string k_UnityAnalyticsInstallationIdKey = "UnityAnalyticsInstallationId";
	internal const string k_UnityAnalyticsUserIdKey = "UnityAnalyticsUserId";
	private readonly IPlayerId m_PlayerId; // 0x10
	private readonly IExternalUserId m_ExternalIdProvider; // 0x18
	private readonly IPersistence m_Persistence; // 0x20
	private bool m_Initialized; // 0x28
	[CompilerGenerated]
	private string <UserId>k__BackingField; // 0x30
	[CompilerGenerated]
	private string <InstallId>k__BackingField; // 0x38
	[CompilerGenerated]
	private string <ExternalId>k__BackingField; // 0x40
	[CompilerGenerated]
	private bool <IsNewPlayer>k__BackingField; // 0x48
	[CompilerGenerated]
	private Action OnPlayerChanged; // 0x50

	// Properties
	public string UserId { get; set; }
	public string InstallId { get; set; }
	public string PlayerId { get; }
	public string ExternalId { get; set; }
	public bool IsNewPlayer { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4513A0 Offset: 0x44FDA0 VA: 0x1804513A0 Slot: 4
	public string get_UserId() { }

	[CompilerGenerated]
	// RVA: 0x4513D0 Offset: 0x44FDD0 VA: 0x1804513D0
	private void set_UserId(string value) { }

	[CompilerGenerated]
	// RVA: 0x4513B0 Offset: 0x44FDB0 VA: 0x1804513B0 Slot: 5
	public string get_InstallId() { }

	[CompilerGenerated]
	// RVA: 0x4513E0 Offset: 0x44FDE0 VA: 0x1804513E0
	private void set_InstallId(string value) { }

	// RVA: 0x2B91CE0 Offset: 0x2B906E0 VA: 0x182B91CE0 Slot: 6
	public string get_PlayerId() { }

	[CompilerGenerated]
	// RVA: 0x4945F0 Offset: 0x492FF0 VA: 0x1804945F0 Slot: 7
	public string get_ExternalId() { }

	[CompilerGenerated]
	// RVA: 0x4D36A0 Offset: 0x4D20A0 VA: 0x1804D36A0
	private void set_ExternalId(string value) { }

	[CompilerGenerated]
	// RVA: 0x4D60D0 Offset: 0x4D4AD0 VA: 0x1804D60D0 Slot: 8
	public bool get_IsNewPlayer() { }

	[CompilerGenerated]
	// RVA: 0x4D6480 Offset: 0x4D4E80 VA: 0x1804D6480
	private void set_IsNewPlayer(bool value) { }

	[CompilerGenerated]
	// RVA: 0x2B91C40 Offset: 0x2B90640 VA: 0x182B91C40 Slot: 9
	public void add_OnPlayerChanged(Action value) { }

	[CompilerGenerated]
	// RVA: 0x2B91D30 Offset: 0x2B90730 VA: 0x182B91D30 Slot: 10
	public void remove_OnPlayerChanged(Action value) { }

	// RVA: 0x2B91A60 Offset: 0x2B90460 VA: 0x182B91A60
	public void .ctor(IInstallationId installId, IPlayerId playerId, IExternalUserId externalId, IPersistence persistence) { }

	// RVA: 0x2B918A0 Offset: 0x2B902A0 VA: 0x182B918A0 Slot: 11
	public void Initialize() { }

	// RVA: 0x2B91730 Offset: 0x2B90130 VA: 0x182B91730
	private void ExternalUserIdChanged(string newName) { }
}

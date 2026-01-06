public class DailySummary : NetworkSingleton<DailySummary> // TypeDefIndex: 2584
{
	// Fields
	[CompilerGenerated]
	private bool <IsOpen>k__BackingField; // 0x120
	[Header("References")]
	public Canvas Canvas; // 0x128
	public RectTransform Container; // 0x130
	public Animation Anim; // 0x138
	public TextMeshProUGUI TitleLabel; // 0x140
	public RectTransform[] ProductEntries; // 0x148
	public TextMeshProUGUI PlayerEarningsLabel; // 0x150
	public TextMeshProUGUI DealerEarningsLabel; // 0x158
	public TextMeshProUGUI XPGainedLabel; // 0x160
	public UnityEvent onClosed; // 0x168
	private Dictionary<string, int> itemsSoldByPlayer; // 0x170
	private float moneyEarnedByPlayer; // 0x178
	private float moneyEarnedByDealers; // 0x17C
	[CompilerGenerated]
	private int <xpGained>k__BackingField; // 0x180
	private bool NetworkInitialize___EarlyScheduleOne.UI.DailySummaryAssembly-CSharp.dll_Excuted; // 0x184
	private bool NetworkInitialize__LateScheduleOne.UI.DailySummaryAssembly-CSharp.dll_Excuted; // 0x185

	// Properties
	public bool IsOpen { get; set; }
	public int xpGained { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x513170 Offset: 0x511B70 VA: 0x180513170
	public bool get_IsOpen() { }

	[CompilerGenerated]
	// RVA: 0x5EB2E0 Offset: 0x5E9CE0 VA: 0x1805EB2E0
	private void set_IsOpen(bool value) { }

	[CompilerGenerated]
	// RVA: 0x8DFE50 Offset: 0x8DE850 VA: 0x1808DFE50
	public int get_xpGained() { }

	[CompilerGenerated]
	// RVA: 0x8DFE60 Offset: 0x8DE860 VA: 0x1808DFE60
	private void set_xpGained(int value) { }

	// RVA: 0x8DFC00 Offset: 0x8DE600 VA: 0x1808DFC00 Slot: 19
	protected override void Start() { }

	// RVA: 0x8DEEF0 Offset: 0x8DD8F0 VA: 0x1808DEEF0
	public void Open() { }

	// RVA: 0x8DEC40 Offset: 0x8DD640 VA: 0x1808DEC40
	public void Close() { }

	// RVA: 0x8DEBE0 Offset: 0x8DD5E0 VA: 0x1808DEBE0
	private void SleepEnd() { }

	[ObserversRpc]
	// RVA: 0x8DEA10 Offset: 0x8DD410 VA: 0x1808DEA10
	public void AddSoldItem(string id, int amount) { }

	[ObserversRpc]
	// RVA: 0x8DE8C0 Offset: 0x8DD2C0 VA: 0x1808DE8C0
	public void AddPlayerMoney(float amount) { }

	[ObserversRpc]
	// RVA: 0x8DE770 Offset: 0x8DD170 VA: 0x1808DE770
	public void AddDealerMoney(float amount) { }

	[ObserversRpc]
	// RVA: 0x8DEA20 Offset: 0x8DD420 VA: 0x1808DEA20
	public void AddXP(int xp) { }

	// RVA: 0x8DEBE0 Offset: 0x8DD5E0 VA: 0x1808DEBE0
	private void ClearStats() { }

	// RVA: 0x8DFDC0 Offset: 0x8DE7C0 VA: 0x1808DFDC0
	public void .ctor() { }

	// RVA: 0x8DED80 Offset: 0x8DD780 VA: 0x1808DED80 Slot: 22
	public override void NetworkInitialize___Early() { }

	// RVA: 0x8DED30 Offset: 0x8DD730 VA: 0x1808DED30 Slot: 23
	public override void NetworkInitialize__Late() { }

	// RVA: 0x59EFB0 Offset: 0x59D9B0 VA: 0x18059EFB0 Slot: 14
	public override void NetworkInitializeIfDisabled() { }

	// RVA: 0x8DF9D0 Offset: 0x8DE3D0 VA: 0x1808DF9D0
	private void RpcWriter___Observers_AddSoldItem_3643459082(string id, int amount) { }

	// RVA: 0x8DF680 Offset: 0x8DE080 VA: 0x1808DF680
	public void RpcLogic___AddSoldItem_3643459082(string id, int amount) { }

	// RVA: 0x8DF840 Offset: 0x8DE240 VA: 0x1808DF840
	private void RpcReader___Observers_AddSoldItem_3643459082(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x8DE8C0 Offset: 0x8DD2C0 VA: 0x1808DE8C0
	private void RpcWriter___Observers_AddPlayerMoney_431000436(float amount) { }

	// RVA: 0x8DF660 Offset: 0x8DE060 VA: 0x1808DF660
	public void RpcLogic___AddPlayerMoney_431000436(float amount) { }

	// RVA: 0x8DF7E0 Offset: 0x8DE1E0 VA: 0x1808DF7E0
	private void RpcReader___Observers_AddPlayerMoney_431000436(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x8DE770 Offset: 0x8DD170 VA: 0x1808DE770
	private void RpcWriter___Observers_AddDealerMoney_431000436(float amount) { }

	// RVA: 0x8DF640 Offset: 0x8DE040 VA: 0x1808DF640
	public void RpcLogic___AddDealerMoney_431000436(float amount) { }

	// RVA: 0x8DF780 Offset: 0x8DE180 VA: 0x1808DF780
	private void RpcReader___Observers_AddDealerMoney_431000436(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x8DEA20 Offset: 0x8DD420 VA: 0x1808DEA20
	private void RpcWriter___Observers_AddXP_3316948804(int xp) { }

	// RVA: 0x8DF770 Offset: 0x8DE170 VA: 0x1808DF770
	public void RpcLogic___AddXP_3316948804(int xp) { }

	// RVA: 0x8DF970 Offset: 0x8DE370 VA: 0x1808DF970
	private void RpcReader___Observers_AddXP_3316948804(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x8DEB70 Offset: 0x8DD570 VA: 0x1808DEB70 Slot: 20
	public override void Awake() { }
}

public class Business : Property, ISaveable // TypeDefIndex: 737
{
	// Fields
	public static List<Business> Businesses; // 0x0
	public static List<Business> UnownedBusinesses; // 0x8
	public static List<Business> OwnedBusinesses; // 0x10
	[Header("Settings")]
	public float LaunderCapacity; // 0x250
	public List<LaunderingOperation> LaunderingOperations; // 0x258
	public static Action<LaunderingOperation> onOperationStarted; // 0x18
	public static Action<LaunderingOperation> onOperationFinished; // 0x20
	private BusinessLoader loader; // 0x260
	private bool NetworkInitialize___EarlyScheduleOne.Property.BusinessAssembly-CSharp.dll_Excuted; // 0x268
	private bool NetworkInitialize__LateScheduleOne.Property.BusinessAssembly-CSharp.dll_Excuted; // 0x269

	// Properties
	public float currentLaunderTotal { get; }
	public float appliedLaunderLimit { get; }
	public Loader Loader { get; }

	// Methods

	// RVA: 0xAD0690 Offset: 0xACF090 VA: 0x180AD0690
	public float get_currentLaunderTotal() { }

	// RVA: 0xAD0660 Offset: 0xACF060 VA: 0x180AD0660
	public float get_appliedLaunderLimit() { }

	// RVA: 0x7189F0 Offset: 0x7173F0 VA: 0x1807189F0 Slot: 21
	public Loader get_Loader() { }

	// RVA: 0xACE870 Offset: 0xACD270 VA: 0x180ACE870 Slot: 42
	public override void Awake() { }

	// RVA: 0xAD0210 Offset: 0xACEC10 VA: 0x180AD0210 Slot: 44
	protected override void Start() { }

	// RVA: 0xACF510 Offset: 0xACDF10 VA: 0x180ACF510 Slot: 46
	protected override void OnDestroy() { }

	// RVA: 0xACECE0 Offset: 0xACD6E0 VA: 0x180ACECE0 Slot: 47
	protected override void GetNetworth(MoneyManager.FloatContainer container) { }

	// RVA: 0xACF5E0 Offset: 0xACDFE0 VA: 0x180ACF5E0 Slot: 9
	public override void OnSpawnServer(NetworkConnection connection) { }

	// RVA: 0xACF260 Offset: 0xACDC60 VA: 0x180ACF260 Slot: 59
	protected virtual void MinPass() { }

	// RVA: 0xACF280 Offset: 0xACDC80 VA: 0x180ACF280 Slot: 60
	protected virtual void MinsPass(int mins) { }

	// RVA: 0xAD0430 Offset: 0xACEE30 VA: 0x180AD0430
	private void TimeSkipped(int minsPassed) { }

	// RVA: 0xACED50 Offset: 0xACD750 VA: 0x180ACED50 Slot: 52
	public override string GetSaveString() { }

	// RVA: 0xACF160 Offset: 0xACDB60 VA: 0x180ACF160 Slot: 55
	public override void Load(PropertyData propertyData, string dataString) { }

	// RVA: 0xACF950 Offset: 0xACE350 VA: 0x180ACF950 Slot: 48
	protected override void RecieveOwned() { }

	[ServerRpc(RequireOwnership = False)]
	// RVA: 0xACFF30 Offset: 0xACE930 VA: 0x180ACFF30
	public void StartLaunderingOperation(float amount, int minutesSinceStarted = 0) { }

	[ObserversRpc]
	[TargetRpc]
	// RVA: 0xACF700 Offset: 0xACE100 VA: 0x180ACF700
	private void ReceiveLaunderingOperation(NetworkConnection conn, float amount, int minutesSinceStarted = 0) { }

	// RVA: 0xACE8C0 Offset: 0xACD2C0 VA: 0x180ACE8C0
	protected void CompleteOperation(LaunderingOperation op) { }

	// RVA: 0xAD0570 Offset: 0xACEF70 VA: 0x180AD0570
	public void .ctor() { }

	// RVA: 0xAD0450 Offset: 0xACEE50 VA: 0x180AD0450
	private static void .cctor() { }

	// RVA: 0xACF3E0 Offset: 0xACDDE0 VA: 0x180ACF3E0 Slot: 56
	public override void NetworkInitialize___Early() { }

	// RVA: 0xACF3B0 Offset: 0xACDDB0 VA: 0x180ACF3B0 Slot: 57
	public override void NetworkInitialize__Late() { }

	// RVA: 0x5945C0 Offset: 0x592FC0 VA: 0x1805945C0 Slot: 14
	public override void NetworkInitializeIfDisabled() { }

	// RVA: 0xACFF30 Offset: 0xACE930 VA: 0x180ACFF30
	private void RpcWriter___Server_StartLaunderingOperation_1481775633(float amount, int minutesSinceStarted = 0) { }

	// RVA: 0xACFBE0 Offset: 0xACE5E0 VA: 0x180ACFBE0
	public void RpcLogic___StartLaunderingOperation_1481775633(float amount, int minutesSinceStarted = 0) { }

	// RVA: 0xACFC90 Offset: 0xACE690 VA: 0x180ACFC90
	private void RpcReader___Server_StartLaunderingOperation_1481775633(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0xAD00A0 Offset: 0xACEAA0 VA: 0x180AD00A0
	private void RpcWriter___Target_ReceiveLaunderingOperation_1001022388(NetworkConnection conn, float amount, int minutesSinceStarted = 0) { }

	// RVA: 0xACFA60 Offset: 0xACE460 VA: 0x180ACFA60
	private void RpcLogic___ReceiveLaunderingOperation_1001022388(NetworkConnection conn, float amount, int minutesSinceStarted = 0) { }

	// RVA: 0xACFD20 Offset: 0xACE720 VA: 0x180ACFD20
	private void RpcReader___Target_ReceiveLaunderingOperation_1001022388(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0xACFDB0 Offset: 0xACE7B0 VA: 0x180ACFDB0
	private void RpcWriter___Observers_ReceiveLaunderingOperation_1001022388(NetworkConnection conn, float amount, int minutesSinceStarted = 0) { }

	// RVA: 0xACFC00 Offset: 0xACE600 VA: 0x180ACFC00
	private void RpcReader___Observers_ReceiveLaunderingOperation_1001022388(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0xACE6B0 Offset: 0xACD0B0 VA: 0x180ACE6B0 Slot: 61
	protected override void Awake_UserLogic_ScheduleOne.Property.Business_Assembly-CSharp.dll() { }
}

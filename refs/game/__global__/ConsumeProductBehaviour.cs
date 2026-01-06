public class ConsumeProductBehaviour : Behaviour // TypeDefIndex: 1780
{
	// Fields
	public AvatarEquippable JointPrefab; // 0x168
	public AvatarEquippable PipePrefab; // 0x170
	public AvatarEquippable ShroomPrefab; // 0x178
	[CompilerGenerated]
	private ProductItemInstance <ConsumedProduct>k__BackingField; // 0x180
	private ProductItemInstance product; // 0x188
	private Coroutine consumeRoutine; // 0x190
	public AudioSourceController WeedConsumeSound; // 0x198
	public AudioSourceController MethConsumeSound; // 0x1A0
	public AudioSourceController SnortSound; // 0x1A8
	public AudioSourceController EatSound; // 0x1B0
	public ParticleSystem SmokeExhaleParticles; // 0x1B8
	[Header("Debug")]
	public ProductDefinition TestProduct; // 0x1C0
	public UnityEvent onConsumeDone; // 0x1C8
	private bool NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.ConsumeProductBehaviourAssembly-CSharp.dll_Excuted; // 0x1D0
	private bool NetworkInitialize__LateScheduleOne.NPCs.Behaviour.ConsumeProductBehaviourAssembly-CSharp.dll_Excuted; // 0x1D1

	// Properties
	public ProductItemInstance ConsumedProduct { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x73B370 Offset: 0x739D70 VA: 0x18073B370
	public ProductItemInstance get_ConsumedProduct() { }

	[CompilerGenerated]
	// RVA: 0x73B4D0 Offset: 0x739ED0 VA: 0x18073B4D0
	private void set_ConsumedProduct(ProductItemInstance value) { }

	// RVA: 0x73C620 Offset: 0x73B020 VA: 0x18073C620 Slot: 34
	protected virtual void Start() { }

	[ServerRpc(RequireOwnership = False, RunLocally = True)]
	// RVA: 0x73C4F0 Offset: 0x73AEF0 VA: 0x18073C4F0
	public void SendProduct(ProductItemInstance _product) { }

	[ObserversRpc(RunLocally = True)]
	// RVA: 0x73BE80 Offset: 0x73A880 VA: 0x18073BE80
	private void SetProduct(ProductItemInstance _product) { }

	[ObserversRpc(RunLocally = True)]
	// RVA: 0x73B660 Offset: 0x73A060 VA: 0x18073B660
	public void ClearEffects() { }

	// RVA: 0x73B520 Offset: 0x739F20 VA: 0x18073B520 Slot: 22
	public override void Activate() { }

	// RVA: 0x73BD70 Offset: 0x73A770 VA: 0x18073BD70 Slot: 25
	public override void Resume() { }

	// RVA: 0x73C9B0 Offset: 0x73B3B0 VA: 0x18073C9B0
	private void TryConsume() { }

	// RVA: 0x73BB40 Offset: 0x73A540 VA: 0x18073BB40 Slot: 21
	public override void Disable() { }

	// RVA: 0x73BAA0 Offset: 0x73A4A0 VA: 0x18073BAA0 Slot: 23
	public override void Deactivate() { }

	// RVA: 0x73B9F0 Offset: 0x73A3F0 VA: 0x18073B9F0
	private void ConsumeWeed() { }

	// RVA: 0x73B8D0 Offset: 0x73A2D0 VA: 0x18073B8D0
	private void ConsumeMeth() { }

	// RVA: 0x73B840 Offset: 0x73A240 VA: 0x18073B840
	private void ConsumeCocaine() { }

	// RVA: 0x73B960 Offset: 0x73A360 VA: 0x18073B960
	private void ConsumeShrooms() { }

	[ObserversRpc]
	// RVA: 0x73B540 Offset: 0x739F40 VA: 0x18073B540
	private void ApplyEffects() { }

	// RVA: 0x73B7D0 Offset: 0x73A1D0 VA: 0x18073B7D0
	private void Clear() { }

	// RVA: 0x73BA80 Offset: 0x73A480 VA: 0x18073BA80
	private void DayPass() { }

	// RVA: 0x731510 Offset: 0x72FF10 VA: 0x180731510
	public void .ctor() { }

	[IteratorStateMachine(typeof(ConsumeProductBehaviour.<<ConsumeWeed>g__ConsumeWeedRoutine|25_0>d))]
	[CompilerGenerated]
	// RVA: 0x73CE40 Offset: 0x73B840 VA: 0x18073CE40
	private IEnumerator <ConsumeWeed>g__ConsumeWeedRoutine|25_0() { }

	[IteratorStateMachine(typeof(ConsumeProductBehaviour.<<ConsumeMeth>g__ConsumeWeedRoutine|26_0>d))]
	[CompilerGenerated]
	// RVA: 0x73CD60 Offset: 0x73B760 VA: 0x18073CD60
	private IEnumerator <ConsumeMeth>g__ConsumeWeedRoutine|26_0() { }

	[IteratorStateMachine(typeof(ConsumeProductBehaviour.<<ConsumeCocaine>g__ConsumeWeedRoutine|27_0>d))]
	[CompilerGenerated]
	// RVA: 0x73CCF0 Offset: 0x73B6F0 VA: 0x18073CCF0
	private IEnumerator <ConsumeCocaine>g__ConsumeWeedRoutine|27_0() { }

	[CompilerGenerated]
	[IteratorStateMachine(typeof(ConsumeProductBehaviour.<<ConsumeShrooms>g__ConsumeRoutine|28_0>d))]
	// RVA: 0x73CDD0 Offset: 0x73B7D0 VA: 0x18073CDD0
	private IEnumerator <ConsumeShrooms>g__ConsumeRoutine|28_0() { }

	// RVA: 0x73BC00 Offset: 0x73A600 VA: 0x18073BC00 Slot: 31
	public override void NetworkInitialize___Early() { }

	// RVA: 0x73BBD0 Offset: 0x73A5D0 VA: 0x18073BBD0 Slot: 32
	public override void NetworkInitialize__Late() { }

	// RVA: 0x5980E0 Offset: 0x596AE0 VA: 0x1805980E0 Slot: 14
	public override void NetworkInitializeIfDisabled() { }

	// RVA: 0x73C3C0 Offset: 0x73ADC0 VA: 0x18073C3C0
	private void RpcWriter___Server_SendProduct_2622925554(ProductItemInstance _product) { }

	// RVA: 0x73BE80 Offset: 0x73A880 VA: 0x18073BE80
	public void RpcLogic___SendProduct_2622925554(ProductItemInstance _product) { }

	// RVA: 0x73C0F0 Offset: 0x73AAF0 VA: 0x18073C0F0
	private void RpcReader___Server_SendProduct_2622925554(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0x73C280 Offset: 0x73AC80 VA: 0x18073C280
	private void RpcWriter___Observers_SetProduct_2622925554(ProductItemInstance _product) { }

	// RVA: 0x73B4F0 Offset: 0x739EF0 VA: 0x18073B4F0
	private void RpcLogic___SetProduct_2622925554(ProductItemInstance _product) { }

	// RVA: 0x73C090 Offset: 0x73AA90 VA: 0x18073C090
	private void RpcReader___Observers_SetProduct_2622925554(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x73C160 Offset: 0x73AB60 VA: 0x18073C160
	private void RpcWriter___Observers_ClearEffects_2166136261() { }

	// RVA: 0x73BE10 Offset: 0x73A810 VA: 0x18073BE10
	public void RpcLogic___ClearEffects_2166136261() { }

	// RVA: 0x73C050 Offset: 0x73AA50 VA: 0x18073C050
	private void RpcReader___Observers_ClearEffects_2166136261(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x73B540 Offset: 0x739F40 VA: 0x18073B540
	private void RpcWriter___Observers_ApplyEffects_2166136261() { }

	// RVA: 0x73BD90 Offset: 0x73A790 VA: 0x18073BD90
	private void RpcLogic___ApplyEffects_2166136261() { }

	// RVA: 0x73BFC0 Offset: 0x73A9C0 VA: 0x18073BFC0
	private void RpcReader___Observers_ApplyEffects_2166136261(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x7305E0 Offset: 0x72EFE0 VA: 0x1807305E0 Slot: 19
	public override void Awake() { }
}

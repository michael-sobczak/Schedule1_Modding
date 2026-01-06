public class Toilet : GridItem // TypeDefIndex: 3215
{
	// Fields
	public float InitialDelay; // 0x210
	public float FlushTime; // 0x214
	public InteractableObject IntObj; // 0x218
	public LayerMask ItemLayerMask; // 0x220
	public SphereCollider ItemDetectionCollider; // 0x228
	public UnityEvent OnFlush; // 0x230
	private Coroutine _flushCoroutine; // 0x238
	private bool isFlushing; // 0x240
	private bool NetworkInitialize___EarlyScheduleOne.ObjectScripts.ToiletAssembly-CSharp.dll_Excuted; // 0x241
	private bool NetworkInitialize__LateScheduleOne.ObjectScripts.ToiletAssembly-CSharp.dll_Excuted; // 0x242

	// Methods

	// RVA: 0x9D6920 Offset: 0x9D5320 VA: 0x1809D6920
	public void Hovered() { }

	// RVA: 0x9D69A0 Offset: 0x9D53A0 VA: 0x1809D69A0
	public void Interacted() { }

	[ServerRpc(RequireOwnership = False)]
	// RVA: 0x9D6E20 Offset: 0x9D5820 VA: 0x1809D6E20
	private void SendFlush() { }

	[ObserversRpc]
	// RVA: 0x9D6800 Offset: 0x9D5200 VA: 0x1809D6800
	private void Flush() { }

	// RVA: 0x9D6FA0 Offset: 0x9D59A0 VA: 0x1809D6FA0
	public void .ctor() { }

	[CompilerGenerated]
	[IteratorStateMachine(typeof(Toilet.<<Flush>g__Routine|11_0>d))]
	// RVA: 0x9D6F30 Offset: 0x9D5930 VA: 0x1809D6F30
	private IEnumerator <Flush>g__Routine|11_0() { }

	// RVA: 0x9D6AD0 Offset: 0x9D54D0 VA: 0x1809D6AD0 Slot: 63
	public override void NetworkInitialize___Early() { }

	// RVA: 0x9D6AB0 Offset: 0x9D54B0 VA: 0x1809D6AB0 Slot: 64
	public override void NetworkInitialize__Late() { }

	// RVA: 0x67D360 Offset: 0x67BD60 VA: 0x18067D360 Slot: 14
	public override void NetworkInitializeIfDisabled() { }

	// RVA: 0x9D6E20 Offset: 0x9D5820 VA: 0x1809D6E20
	private void RpcWriter___Server_SendFlush_2166136261() { }

	// RVA: 0x9D6800 Offset: 0x9D5200 VA: 0x1809D6800
	private void RpcLogic___SendFlush_2166136261() { }

	// RVA: 0x9D6CF0 Offset: 0x9D56F0 VA: 0x1809D6CF0
	private void RpcReader___Server_SendFlush_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0x9D6800 Offset: 0x9D5200 VA: 0x1809D6800
	private void RpcWriter___Observers_Flush_2166136261() { }

	// RVA: 0x9D6BC0 Offset: 0x9D55C0 VA: 0x1809D6BC0
	private void RpcLogic___Flush_2166136261() { }

	// RVA: 0x9D6C50 Offset: 0x9D5650 VA: 0x1809D6C50
	private void RpcReader___Observers_Flush_2166136261(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x873B40 Offset: 0x872540 VA: 0x180873B40 Slot: 47
	public override void Awake() { }
}

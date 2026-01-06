public class RollbackVisualizer : NetworkBehaviour // TypeDefIndex: 18110
{
	// Fields
	[SerializeField]
	private GameObject _originalPrefab; // 0x118
	[SerializeField]
	private GameObject _rollbackPrefab; // 0x120
	[SerializeField]
	private TextCanvas _textCanvasPrefab; // 0x128
	private List<float> _accuracyAverage; // 0x130
	private bool NetworkInitialize___EarlyFishNet.Example.ColliderRollbacks.RollbackVisualizerFishNet.Demos.dll_Excuted; // 0x138
	private bool NetworkInitialize__LateFishNet.Example.ColliderRollbacks.RollbackVisualizerFishNet.Demos.dll_Excuted; // 0x139

	// Methods

	// RVA: 0xCEDB90 Offset: 0xCEC590 VA: 0x180CEDB90
	private void OnDisable() { }

	[Server]
	// RVA: 0xCEE440 Offset: 0xCECE40 VA: 0x180CEE440
	public void ShowDifference(NetworkObject clientObject, Vector3 original, Vector3 rolledBack) { }

	[TargetRpc]
	// RVA: 0xCEE670 Offset: 0xCED070 VA: 0x180CEE670
	private void TargetShowDifference(NetworkConnection conn, Vector3 original, Vector3 rollback) { }

	// RVA: 0xCEDBE0 Offset: 0xCEC5E0 VA: 0x180CEDBE0
	private string PrintAverage(bool fromServer, float difference, NetworkManager nm) { }

	// RVA: 0xCEE6C0 Offset: 0xCED0C0 VA: 0x180CEE6C0
	public void .ctor() { }

	// RVA: 0xCEDB00 Offset: 0xCEC500 VA: 0x180CEDB00 Slot: 19
	public override void NetworkInitialize___Early() { }

	// RVA: 0x64BFE0 Offset: 0x64A9E0 VA: 0x18064BFE0 Slot: 20
	public override void NetworkInitialize__Late() { }

	// RVA: 0x5F9760 Offset: 0x5F8160 VA: 0x1805F9760 Slot: 14
	public override void NetworkInitializeIfDisabled() { }

	// RVA: 0xCEE270 Offset: 0xCECC70 VA: 0x180CEE270
	private void RpcWriter___Target_TargetShowDifference_2390343144(NetworkConnection conn, Vector3 original, Vector3 rollback) { }

	// RVA: 0xCEDEB0 Offset: 0xCEC8B0 VA: 0x180CEDEB0
	private void RpcLogic___TargetShowDifference_2390343144(NetworkConnection conn, Vector3 original, Vector3 rollback) { }

	// RVA: 0xCEE110 Offset: 0xCECB10 VA: 0x180CEE110
	private void RpcReader___Target_TargetShowDifference_2390343144(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x5F9760 Offset: 0x5F8160 VA: 0x1805F9760 Slot: 21
	public override void Awake() { }
}

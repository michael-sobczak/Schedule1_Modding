public class ConfigurationReplicator : NetworkBehaviour // TypeDefIndex: 1193
{
	// Fields
	public EntityConfiguration Configuration; // 0x118
	private bool NetworkInitialize___EarlyScheduleOne.Management.ConfigurationReplicatorAssembly-CSharp.dll_Excuted; // 0x120
	private bool NetworkInitialize__LateScheduleOne.Management.ConfigurationReplicatorAssembly-CSharp.dll_Excuted; // 0x121

	// Methods

	// RVA: 0x5FAA40 Offset: 0x5F9440 VA: 0x1805FAA40
	public void ReplicateField(ConfigField field, NetworkConnection conn) { }

	[ServerRpc(RequireOwnership = False)]
	// RVA: 0x5FE030 Offset: 0x5FCA30 VA: 0x1805FE030
	private void SendItemField(int fieldIndex, string value) { }

	[ObserversRpc]
	// RVA: 0x5F9CD0 Offset: 0x5F86D0 VA: 0x1805F9CD0
	private void ReceiveItemField(int fieldIndex, string value) { }

	[ServerRpc(RequireOwnership = False)]
	// RVA: 0x5FE1A0 Offset: 0x5FCBA0 VA: 0x1805FE1A0
	private void SendNPCField(int fieldIndex, NetworkObject npcObject) { }

	[ObserversRpc]
	// RVA: 0x5F9E50 Offset: 0x5F8850 VA: 0x1805F9E50
	private void ReceiveNPCField(int fieldIndex, NetworkObject npcObject) { }

	[ServerRpc(RequireOwnership = False)]
	// RVA: 0x5FE480 Offset: 0x5FCE80 VA: 0x1805FE480
	private void SendObjectField(int fieldIndex, NetworkObject obj) { }

	[ObserversRpc]
	// RVA: 0x5FA150 Offset: 0x5F8B50 VA: 0x1805FA150
	private void ReceiveObjectField(int fieldIndex, NetworkObject obj) { }

	[ServerRpc(RequireOwnership = False)]
	// RVA: 0x5FE5F0 Offset: 0x5FCFF0 VA: 0x1805FE5F0
	private void SendObjectListField(int fieldIndex, List<NetworkObject> objects) { }

	[ObserversRpc]
	// RVA: 0x5FA2D0 Offset: 0x5F8CD0 VA: 0x1805FA2D0
	private void ReceiveObjectListField(int fieldIndex, List<NetworkObject> objects) { }

	[ServerRpc(RequireOwnership = False)]
	// RVA: 0x5FE8D0 Offset: 0x5FD2D0 VA: 0x1805FE8D0
	private void SendRecipeField(int fieldIndex, int recipeIndex) { }

	[ObserversRpc]
	// RVA: 0x5FA5C0 Offset: 0x5F8FC0 VA: 0x1805FA5C0
	private void ReceiveRecipeField(int fieldIndex, int recipeIndex) { }

	[ServerRpc(RequireOwnership = False)]
	// RVA: 0x5FE310 Offset: 0x5FCD10 VA: 0x1805FE310
	private void SendNumberField(int fieldIndex, float value) { }

	[ObserversRpc]
	// RVA: 0x5F9FD0 Offset: 0x5F89D0 VA: 0x1805F9FD0
	private void ReceiveNumberField(int fieldIndex, float value) { }

	[ServerRpc(RequireOwnership = False)]
	// RVA: 0x5FEA50 Offset: 0x5FD450 VA: 0x1805FEA50
	private void SendRouteListField(int fieldIndex, AdvancedTransitRouteData[] value) { }

	[ObserversRpc]
	// RVA: 0x5FA740 Offset: 0x5F9140 VA: 0x1805FA740
	private void ReceiveRouteListField(int fieldIndex, AdvancedTransitRouteData[] value) { }

	[ServerRpc(RequireOwnership = False)]
	// RVA: 0x5FE760 Offset: 0x5FD160 VA: 0x1805FE760
	private void SendQualityField(int fieldIndex, EQuality quality) { }

	[ObserversRpc]
	// RVA: 0x5FA450 Offset: 0x5F8E50 VA: 0x1805FA450
	private void ReceiveQualityField(int fieldIndex, EQuality value) { }

	[ServerRpc(RequireOwnership = False)]
	// RVA: 0x5FEBC0 Offset: 0x5FD5C0 VA: 0x1805FEBC0
	private void SendStringField(int fieldIndex, string value) { }

	[ObserversRpc]
	// RVA: 0x5FA8C0 Offset: 0x5F92C0 VA: 0x1805FA8C0
	private void ReceiveStringField(int fieldIndex, string value) { }

	// RVA: 0x5FED30 Offset: 0x5FD730 VA: 0x1805FED30
	public void .ctor() { }

	// RVA: 0x5F97C0 Offset: 0x5F81C0 VA: 0x1805F97C0 Slot: 19
	public override void NetworkInitialize___Early() { }

	// RVA: 0x5F97A0 Offset: 0x5F81A0 VA: 0x1805F97A0 Slot: 20
	public override void NetworkInitialize__Late() { }

	// RVA: 0x5F9760 Offset: 0x5F8160 VA: 0x1805F9760 Slot: 14
	public override void NetworkInitializeIfDisabled() { }

	// RVA: 0x5FE030 Offset: 0x5FCA30 VA: 0x1805FE030
	private void RpcWriter___Server_SendItemField_2801973956(int fieldIndex, string value) { }

	// RVA: 0x5F9CD0 Offset: 0x5F86D0 VA: 0x1805F9CD0
	private void RpcLogic___SendItemField_2801973956(int fieldIndex, string value) { }

	// RVA: 0x5FD130 Offset: 0x5FBB30 VA: 0x1805FD130
	private void RpcReader___Server_SendItemField_2801973956(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0x5F9CD0 Offset: 0x5F86D0 VA: 0x1805F9CD0
	private void RpcWriter___Observers_ReceiveItemField_2801973956(int fieldIndex, string value) { }

	// RVA: 0x5FBD80 Offset: 0x5FA780 VA: 0x1805FBD80
	private void RpcLogic___ReceiveItemField_2801973956(int fieldIndex, string value) { }

	// RVA: 0x5FCC80 Offset: 0x5FB680 VA: 0x1805FCC80
	private void RpcReader___Observers_ReceiveItemField_2801973956(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x5FE1A0 Offset: 0x5FCBA0 VA: 0x1805FE1A0
	private void RpcWriter___Server_SendNPCField_1687693739(int fieldIndex, NetworkObject npcObject) { }

	// RVA: 0x5F9E50 Offset: 0x5F8850 VA: 0x1805F9E50
	private void RpcLogic___SendNPCField_1687693739(int fieldIndex, NetworkObject npcObject) { }

	// RVA: 0x5FD2D0 Offset: 0x5FBCD0 VA: 0x1805FD2D0
	private void RpcReader___Server_SendNPCField_1687693739(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0x5F9E50 Offset: 0x5F8850 VA: 0x1805F9E50
	private void RpcWriter___Observers_ReceiveNPCField_1687693739(int fieldIndex, NetworkObject npcObject) { }

	// RVA: 0x5FBF30 Offset: 0x5FA930 VA: 0x1805FBF30
	private void RpcLogic___ReceiveNPCField_1687693739(int fieldIndex, NetworkObject npcObject) { }

	// RVA: 0x5FCD00 Offset: 0x5FB700 VA: 0x1805FCD00
	private void RpcReader___Observers_ReceiveNPCField_1687693739(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x5FE480 Offset: 0x5FCE80 VA: 0x1805FE480
	private void RpcWriter___Server_SendObjectField_1687693739(int fieldIndex, NetworkObject obj) { }

	// RVA: 0x5FA150 Offset: 0x5F8B50 VA: 0x1805FA150
	private void RpcLogic___SendObjectField_1687693739(int fieldIndex, NetworkObject obj) { }

	// RVA: 0x5FD630 Offset: 0x5FC030 VA: 0x1805FD630
	private void RpcReader___Server_SendObjectField_1687693739(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0x5FA150 Offset: 0x5F8B50 VA: 0x1805FA150
	private void RpcWriter___Observers_ReceiveObjectField_1687693739(int fieldIndex, NetworkObject obj) { }

	// RVA: 0x5FC280 Offset: 0x5FAC80 VA: 0x1805FC280
	private void RpcLogic___ReceiveObjectField_1687693739(int fieldIndex, NetworkObject obj) { }

	// RVA: 0x5FCE10 Offset: 0x5FB810 VA: 0x1805FCE10
	private void RpcReader___Observers_ReceiveObjectField_1687693739(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x5FE5F0 Offset: 0x5FCFF0 VA: 0x1805FE5F0
	private void RpcWriter___Server_SendObjectListField_690244341(int fieldIndex, List<NetworkObject> objects) { }

	// RVA: 0x5FA2D0 Offset: 0x5F8CD0 VA: 0x1805FA2D0
	private void RpcLogic___SendObjectListField_690244341(int fieldIndex, List<NetworkObject> objects) { }

	// RVA: 0x5FD7F0 Offset: 0x5FC1F0 VA: 0x1805FD7F0
	private void RpcReader___Server_SendObjectListField_690244341(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0x5FA2D0 Offset: 0x5F8CD0 VA: 0x1805FA2D0
	private void RpcWriter___Observers_ReceiveObjectListField_690244341(int fieldIndex, List<NetworkObject> objects) { }

	// RVA: 0x5FC430 Offset: 0x5FAE30 VA: 0x1805FC430
	private void RpcLogic___ReceiveObjectListField_690244341(int fieldIndex, List<NetworkObject> objects) { }

	// RVA: 0x5FCEA0 Offset: 0x5FB8A0 VA: 0x1805FCEA0
	private void RpcReader___Observers_ReceiveObjectListField_690244341(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x5FE8D0 Offset: 0x5FD2D0 VA: 0x1805FE8D0
	private void RpcWriter___Server_SendRecipeField_1692629761(int fieldIndex, int recipeIndex) { }

	// RVA: 0x5FA5C0 Offset: 0x5F8FC0 VA: 0x1805FA5C0
	private void RpcLogic___SendRecipeField_1692629761(int fieldIndex, int recipeIndex) { }

	// RVA: 0x5FDB30 Offset: 0x5FC530 VA: 0x1805FDB30
	private void RpcReader___Server_SendRecipeField_1692629761(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0x5FA5C0 Offset: 0x5F8FC0 VA: 0x1805FA5C0
	private void RpcWriter___Observers_ReceiveRecipeField_1692629761(int fieldIndex, int recipeIndex) { }

	// RVA: 0x5FC780 Offset: 0x5FB180 VA: 0x1805FC780
	private void RpcLogic___ReceiveRecipeField_1692629761(int fieldIndex, int recipeIndex) { }

	// RVA: 0x5FCFA0 Offset: 0x5FB9A0 VA: 0x1805FCFA0
	private void RpcReader___Observers_ReceiveRecipeField_1692629761(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x5FE310 Offset: 0x5FCD10 VA: 0x1805FE310
	private void RpcWriter___Server_SendNumberField_1293284375(int fieldIndex, float value) { }

	// RVA: 0x5F9FD0 Offset: 0x5F89D0 VA: 0x1805F9FD0
	private void RpcLogic___SendNumberField_1293284375(int fieldIndex, float value) { }

	// RVA: 0x5FD490 Offset: 0x5FBE90 VA: 0x1805FD490
	private void RpcReader___Server_SendNumberField_1293284375(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0x5F9FD0 Offset: 0x5F89D0 VA: 0x1805F9FD0
	private void RpcWriter___Observers_ReceiveNumberField_1293284375(int fieldIndex, float value) { }

	// RVA: 0x5FC0E0 Offset: 0x5FAAE0 VA: 0x1805FC0E0
	private void RpcLogic___ReceiveNumberField_1293284375(int fieldIndex, float value) { }

	// RVA: 0x5FCD90 Offset: 0x5FB790 VA: 0x1805FCD90
	private void RpcReader___Observers_ReceiveNumberField_1293284375(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x5FEA50 Offset: 0x5FD450 VA: 0x1805FEA50
	private void RpcWriter___Server_SendRouteListField_3226448297(int fieldIndex, AdvancedTransitRouteData[] value) { }

	// RVA: 0x5FA740 Offset: 0x5F9140 VA: 0x1805FA740
	private void RpcLogic___SendRouteListField_3226448297(int fieldIndex, AdvancedTransitRouteData[] value) { }

	// RVA: 0x5FDCF0 Offset: 0x5FC6F0 VA: 0x1805FDCF0
	private void RpcReader___Server_SendRouteListField_3226448297(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0x5FA740 Offset: 0x5F9140 VA: 0x1805FA740
	private void RpcWriter___Observers_ReceiveRouteListField_3226448297(int fieldIndex, AdvancedTransitRouteData[] value) { }

	// RVA: 0x5FC920 Offset: 0x5FB320 VA: 0x1805FC920
	private void RpcLogic___ReceiveRouteListField_3226448297(int fieldIndex, AdvancedTransitRouteData[] value) { }

	// RVA: 0x5FD030 Offset: 0x5FBA30 VA: 0x1805FD030
	private void RpcReader___Observers_ReceiveRouteListField_3226448297(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x5FE760 Offset: 0x5FD160 VA: 0x1805FE760
	private void RpcWriter___Server_SendQualityField_3536682170(int fieldIndex, EQuality quality) { }

	// RVA: 0x5FA450 Offset: 0x5F8E50 VA: 0x1805FA450
	private void RpcLogic___SendQualityField_3536682170(int fieldIndex, EQuality quality) { }

	// RVA: 0x5FD990 Offset: 0x5FC390 VA: 0x1805FD990
	private void RpcReader___Server_SendQualityField_3536682170(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0x5FA450 Offset: 0x5F8E50 VA: 0x1805FA450
	private void RpcWriter___Observers_ReceiveQualityField_3536682170(int fieldIndex, EQuality value) { }

	// RVA: 0x5FC5E0 Offset: 0x5FAFE0 VA: 0x1805FC5E0
	private void RpcLogic___ReceiveQualityField_3536682170(int fieldIndex, EQuality value) { }

	// RVA: 0x5FCF20 Offset: 0x5FB920 VA: 0x1805FCF20
	private void RpcReader___Observers_ReceiveQualityField_3536682170(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x5FEBC0 Offset: 0x5FD5C0 VA: 0x1805FEBC0
	private void RpcWriter___Server_SendStringField_2801973956(int fieldIndex, string value) { }

	// RVA: 0x5FA8C0 Offset: 0x5F92C0 VA: 0x1805FA8C0
	private void RpcLogic___SendStringField_2801973956(int fieldIndex, string value) { }

	// RVA: 0x5FDE90 Offset: 0x5FC890 VA: 0x1805FDE90
	private void RpcReader___Server_SendStringField_2801973956(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0x5FA8C0 Offset: 0x5F92C0 VA: 0x1805FA8C0
	private void RpcWriter___Observers_ReceiveStringField_2801973956(int fieldIndex, string value) { }

	// RVA: 0x5FCAD0 Offset: 0x5FB4D0 VA: 0x1805FCAD0
	private void RpcLogic___ReceiveStringField_2801973956(int fieldIndex, string value) { }

	// RVA: 0x5FD0B0 Offset: 0x5FBAB0 VA: 0x1805FD0B0
	private void RpcReader___Observers_ReceiveStringField_2801973956(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x5F9760 Offset: 0x5F8160 VA: 0x1805F9760 Slot: 21
	public override void Awake() { }
}

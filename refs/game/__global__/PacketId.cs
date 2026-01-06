public enum PacketId // TypeDefIndex: 12543
{
	// Fields
	public ushort value__; // 0x0
	public const PacketId Unset = 0;
	public const PacketId Authenticated = 1;
	public const PacketId Split = 2;
	public const PacketId ObjectSpawn = 3;
	public const PacketId ObjectDespawn = 4;
	public const PacketId PredictedSpawnResult = 5;
	public const PacketId SyncVar = 7;
	public const PacketId ServerRpc = 8;
	public const PacketId ObserversRpc = 9;
	public const PacketId TargetRpc = 10;
	public const PacketId OwnershipChange = 11;
	public const PacketId Broadcast = 12;
	public const PacketId SyncObject = 13;
	public const PacketId PingPong = 14;
	public const PacketId Replicate = 15;
	public const PacketId Reconcile = 16;
	public const PacketId Disconnect = 17;
	public const PacketId TimingUpdate = 18;
	public const PacketId NetworkLODUpdate = 19;
	public const PacketId StateUpdate = 20;
}

public interface INetSerializable // TypeDefIndex: 12430
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Serialize(NetDataWriter writer);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void Deserialize(NetDataReader reader);
}

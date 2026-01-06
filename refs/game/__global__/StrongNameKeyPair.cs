public class StrongNameKeyPair : ISerializable, IDeserializationCallback // TypeDefIndex: 4768
{
	// Fields
	private byte[] _publicKey; // 0x10
	private string _keyPairContainer; // 0x18
	private bool _keyPairExported; // 0x20
	private byte[] _keyPairArray; // 0x28

	// Methods

	// RVA: 0x1B9B5C0 Offset: 0x1B99FC0 VA: 0x181B9B5C0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1B9B480 Offset: 0x1B99E80 VA: 0x181B9B480 Slot: 4
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 5
	private void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }
}

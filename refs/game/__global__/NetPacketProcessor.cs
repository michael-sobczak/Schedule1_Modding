public class NetPacketProcessor // TypeDefIndex: 12443
{
	// Fields
	private readonly NetSerializer _netSerializer; // 0x10
	private readonly Dictionary<ulong, NetPacketProcessor.SubscribeDelegate> _callbacks; // 0x18
	private readonly NetDataWriter _netDataWriter; // 0x20

	// Methods

	// RVA: 0xD14640 Offset: 0xD13040 VA: 0x180D14640
	public void .ctor() { }

	// RVA: 0xD14540 Offset: 0xD12F40 VA: 0x180D14540
	public void .ctor(int maxStringLength) { }

	// RVA: -1 Offset: -1 Slot: 4
	protected virtual ulong GetHash<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF0E5A0 Offset: 0xF0CFA0 VA: 0x180F0E5A0
	|-NetPacketProcessor.GetHash<object>
	|-NetPacketProcessor.GetHash<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0xD142E0 Offset: 0xD12CE0 VA: 0x180D142E0 Slot: 5
	protected virtual NetPacketProcessor.SubscribeDelegate GetCallbackFromData(NetDataReader reader) { }

	// RVA: -1 Offset: -1 Slot: 6
	protected virtual void WriteHash<T>(NetDataWriter writer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF0F480 Offset: 0xF0DE80 VA: 0x180F0F480
	|-NetPacketProcessor.WriteHash<object>
	|-NetPacketProcessor.WriteHash<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public void RegisterNestedType<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF0E690 Offset: 0xF0D090 VA: 0x180F0E690
	|-NetPacketProcessor.RegisterNestedType<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	public void RegisterNestedType<T>(Action<NetDataWriter, T> writeDelegate, Func<NetDataReader, T> readDelegate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF0E620 Offset: 0xF0D020 VA: 0x180F0E620
	|-NetPacketProcessor.RegisterNestedType<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public void RegisterNestedType<T>(Func<T> constructor) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF0E6E0 Offset: 0xF0D0E0 VA: 0x180F0E6E0
	|-NetPacketProcessor.RegisterNestedType<object>
	*/

	// RVA: 0xD14430 Offset: 0xD12E30 VA: 0x180D14430
	public void ReadAllPackets(NetDataReader reader) { }

	// RVA: 0xD143B0 Offset: 0xD12DB0 VA: 0x180D143B0
	public void ReadAllPackets(NetDataReader reader, object userData) { }

	// RVA: 0xD144F0 Offset: 0xD12EF0 VA: 0x180D144F0
	public void ReadPacket(NetDataReader reader) { }

	// RVA: -1 Offset: -1
	public void Send<T>(NetPeer peer, T packet, DeliveryMethod options) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF0EA80 Offset: 0xF0D480 VA: 0x180F0EA80
	|-NetPacketProcessor.Send<object>
	*/

	// RVA: -1 Offset: -1
	public void SendNetSerializable<T>(NetPeer peer, ref T packet, DeliveryMethod options) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF0E8A0 Offset: 0xF0D2A0 VA: 0x180F0E8A0
	|-NetPacketProcessor.SendNetSerializable<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public void Send<T>(NetManager manager, T packet, DeliveryMethod options) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF0E9E0 Offset: 0xF0D3E0 VA: 0x180F0E9E0
	|-NetPacketProcessor.Send<object>
	*/

	// RVA: -1 Offset: -1
	public void SendNetSerializable<T>(NetManager manager, ref T packet, DeliveryMethod options) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF0E940 Offset: 0xF0D340 VA: 0x180F0E940
	|-NetPacketProcessor.SendNetSerializable<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public void Write<T>(NetDataWriter writer, T packet) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF0F610 Offset: 0xF0E010 VA: 0x180F0F610
	|-NetPacketProcessor.Write<object>
	*/

	// RVA: -1 Offset: -1
	public void WriteNetSerializable<T>(NetDataWriter writer, ref T packet) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF0F500 Offset: 0xF0DF00 VA: 0x180F0F500
	|-NetPacketProcessor.WriteNetSerializable<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0xD144A0 Offset: 0xD12EA0 VA: 0x180D144A0
	public void ReadPacket(NetDataReader reader, object userData) { }

	// RVA: -1 Offset: -1
	public void Subscribe<T>(Action<T> onReceive, Func<T> packetConstructor) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF0F2F0 Offset: 0xF0DCF0 VA: 0x180F0F2F0
	|-NetPacketProcessor.Subscribe<object>
	*/

	// RVA: -1 Offset: -1
	public void Subscribe<T, TUserData>(Action<T, TUserData> onReceive, Func<T> packetConstructor) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF0F160 Offset: 0xF0DB60 VA: 0x180F0F160
	|-NetPacketProcessor.Subscribe<object, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public void SubscribeReusable<T>(Action<T> onReceive) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF0EFD0 Offset: 0xF0D9D0 VA: 0x180F0EFD0
	|-NetPacketProcessor.SubscribeReusable<object>
	*/

	// RVA: -1 Offset: -1
	public void SubscribeReusable<T, TUserData>(Action<T, TUserData> onReceive) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF0EFD0 Offset: 0xF0D9D0 VA: 0x180F0EFD0
	|-NetPacketProcessor.SubscribeReusable<object, object>
	|
	|-RVA: 0xF0EE40 Offset: 0xF0D840 VA: 0x180F0EE40
	|-NetPacketProcessor.SubscribeReusable<object, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public void SubscribeNetSerializable<T, TUserData>(Action<T, TUserData> onReceive, Func<T> packetConstructor) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF0ECF0 Offset: 0xF0D6F0 VA: 0x180F0ECF0
	|-NetPacketProcessor.SubscribeNetSerializable<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public void SubscribeNetSerializable<T>(Action<T> onReceive, Func<T> packetConstructor) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF0ECF0 Offset: 0xF0D6F0 VA: 0x180F0ECF0
	|-NetPacketProcessor.SubscribeNetSerializable<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public void SubscribeNetSerializable<T, TUserData>(Action<T, TUserData> onReceive) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF0EB20 Offset: 0xF0D520 VA: 0x180F0EB20
	|-NetPacketProcessor.SubscribeNetSerializable<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public void SubscribeNetSerializable<T>(Action<T> onReceive) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF0EB20 Offset: 0xF0D520 VA: 0x180F0EB20
	|-NetPacketProcessor.SubscribeNetSerializable<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public bool RemoveSubscription<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF0E800 Offset: 0xF0D200 VA: 0x180F0E800
	|-NetPacketProcessor.RemoveSubscription<__Il2CppFullySharedGenericType>
	*/
}

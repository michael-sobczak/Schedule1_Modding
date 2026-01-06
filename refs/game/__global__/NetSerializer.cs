public class NetSerializer // TypeDefIndex: 12474
{
	// Fields
	private NetDataWriter _writer; // 0x10
	private readonly int _maxStringLength; // 0x18
	private readonly Dictionary<Type, NetSerializer.CustomType> _registeredTypes; // 0x20

	// Methods

	// RVA: -1 Offset: -1
	public void RegisterNestedType<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF11560 Offset: 0xF0FF60 VA: 0x180F11560
	|-NetSerializer.RegisterNestedType<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	public void RegisterNestedType<T>(Func<T> constructor) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF11640 Offset: 0xF10040 VA: 0x180F11640
	|-NetSerializer.RegisterNestedType<object>
	*/

	// RVA: -1 Offset: -1
	public void RegisterNestedType<T>(Action<NetDataWriter, T> writer, Func<NetDataReader, T> reader) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF11460 Offset: 0xF0FE60 VA: 0x180F11460
	|-NetSerializer.RegisterNestedType<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0xD147C0 Offset: 0xD131C0 VA: 0x180D147C0
	public void .ctor() { }

	// RVA: 0xD14730 Offset: 0xD13130 VA: 0x180D14730
	public void .ctor(int maxStringLength) { }

	// RVA: -1 Offset: -1
	private NetSerializer.ClassInfo<T> RegisterInternal<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF10610 Offset: 0xF0F010 VA: 0x180F10610
	|-NetSerializer.RegisterInternal<object>
	|
	|-RVA: 0xF0F7C0 Offset: 0xF0E1C0 VA: 0x180F0F7C0
	|-NetSerializer.RegisterInternal<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public void Register<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF11770 Offset: 0xF10170 VA: 0x180F11770
	|-NetSerializer.Register<object>
	|
	|-RVA: 0xF11730 Offset: 0xF10130 VA: 0x180F11730
	|-NetSerializer.Register<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public T Deserialize<T>(NetDataReader reader) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF0F6B0 Offset: 0xF0E0B0 VA: 0x180F0F6B0
	|-NetSerializer.Deserialize<object>
	*/

	// RVA: -1 Offset: -1
	public bool Deserialize<T>(NetDataReader reader, T target) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF0F740 Offset: 0xF0E140 VA: 0x180F0F740
	|-NetSerializer.Deserialize<object>
	*/

	// RVA: -1 Offset: -1
	public void Serialize<T>(NetDataWriter writer, T obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF11870 Offset: 0xF10270 VA: 0x180F11870
	|-NetSerializer.Serialize<object>
	*/

	// RVA: -1 Offset: -1
	public byte[] Serialize<T>(T obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF117B0 Offset: 0xF101B0 VA: 0x180F117B0
	|-NetSerializer.Serialize<object>
	*/
}

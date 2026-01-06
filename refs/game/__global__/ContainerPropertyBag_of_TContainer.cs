public abstract class ContainerPropertyBag<TContainer> : PropertyBag<TContainer> // TypeDefIndex: 18362
{
	// Fields
	private readonly List<IProperty<TContainer>> m_PropertiesList; // 0x0
	private readonly Dictionary<string, IProperty<TContainer>> m_PropertiesHash; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14DDC70 Offset: 0x14DC670 VA: 0x1814DDC70
	|-ContainerPropertyBag<Bounds>..cctor
	|
	|-RVA: 0x14DDFD0 Offset: 0x14DC9D0 VA: 0x1814DDFD0
	|-ContainerPropertyBag<BoundsInt>..cctor
	|
	|-RVA: 0x14DDB50 Offset: 0x14DC550 VA: 0x1814DDB50
	|-ContainerPropertyBag<Color>..cctor
	|
	|-RVA: 0x14DDD90 Offset: 0x14DC790 VA: 0x1814DDD90
	|-ContainerPropertyBag<object>..cctor
	|
	|-RVA: 0x14DDA30 Offset: 0x14DC430 VA: 0x1814DDA30
	|-ContainerPropertyBag<Rect>..cctor
	|
	|-RVA: 0x14DE210 Offset: 0x14DCC10 VA: 0x1814DE210
	|-ContainerPropertyBag<RectInt>..cctor
	|
	|-RVA: 0x14DE0F0 Offset: 0x14DCAF0 VA: 0x1814DE0F0
	|-ContainerPropertyBag<Vector2>..cctor
	|
	|-RVA: 0x14DE690 Offset: 0x14DD090 VA: 0x1814DE690
	|-ContainerPropertyBag<Vector2Int>..cctor
	|
	|-RVA: 0x14DE330 Offset: 0x14DCD30 VA: 0x1814DE330
	|-ContainerPropertyBag<Vector3>..cctor
	|
	|-RVA: 0x14DE450 Offset: 0x14DCE50 VA: 0x1814DE450
	|-ContainerPropertyBag<Vector3Int>..cctor
	|
	|-RVA: 0x14DE570 Offset: 0x14DCF70 VA: 0x1814DE570
	|-ContainerPropertyBag<Vector4>..cctor
	|
	|-RVA: 0x14DDEB0 Offset: 0x14DC8B0 VA: 0x1814DDEB0
	|-ContainerPropertyBag<__Il2CppFullySharedGenericType>..cctor
	*/

	// RVA: -1 Offset: -1
	protected void AddProperty<TValue>(Property<TContainer, TValue> property) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDC58A0 Offset: 0xDC42A0 VA: 0x180DC58A0
	|-ContainerPropertyBag<Bounds>.AddProperty<Vector3>
	|-ContainerPropertyBag<BoundsInt>.AddProperty<Vector3Int>
	|-ContainerPropertyBag<Color>.AddProperty<float>
	|-ContainerPropertyBag<object>.AddProperty<int>
	|-ContainerPropertyBag<Rect>.AddProperty<float>
	|-ContainerPropertyBag<RectInt>.AddProperty<int>
	|-ContainerPropertyBag<Vector2>.AddProperty<float>
	|-ContainerPropertyBag<Vector2Int>.AddProperty<int>
	|-ContainerPropertyBag<Vector3>.AddProperty<float>
	|-ContainerPropertyBag<Vector3Int>.AddProperty<int>
	|-ContainerPropertyBag<Vector4>.AddProperty<float>
	|
	|-RVA: 0xDC57E0 Offset: 0xDC41E0 VA: 0x180DC57E0
	|-ContainerPropertyBag<__Il2CppFullySharedGenericType>.AddProperty<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public bool TryGetProperty(ref TContainer container, string name, out IProperty<TContainer> property) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14DD990 Offset: 0x14DC390 VA: 0x1814DD990
	|-ContainerPropertyBag<Bounds>.TryGetProperty
	|-ContainerPropertyBag<BoundsInt>.TryGetProperty
	|-ContainerPropertyBag<Color>.TryGetProperty
	|-ContainerPropertyBag<object>.TryGetProperty
	|-ContainerPropertyBag<Rect>.TryGetProperty
	|-ContainerPropertyBag<RectInt>.TryGetProperty
	|-ContainerPropertyBag<Vector2>.TryGetProperty
	|-ContainerPropertyBag<Vector2Int>.TryGetProperty
	|-ContainerPropertyBag<Vector3>.TryGetProperty
	|-ContainerPropertyBag<Vector3Int>.TryGetProperty
	|-ContainerPropertyBag<Vector4>.TryGetProperty
	|
	|-RVA: 0x14DD9D0 Offset: 0x14DC3D0 VA: 0x1814DD9D0
	|-ContainerPropertyBag<__Il2CppFullySharedGenericType>.TryGetProperty
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14DE7B0 Offset: 0x14DD1B0 VA: 0x1814DE7B0
	|-ContainerPropertyBag<Bounds>..ctor
	|-ContainerPropertyBag<BoundsInt>..ctor
	|-ContainerPropertyBag<Color>..ctor
	|-ContainerPropertyBag<object>..ctor
	|-ContainerPropertyBag<Rect>..ctor
	|-ContainerPropertyBag<RectInt>..ctor
	|-ContainerPropertyBag<Vector2>..ctor
	|-ContainerPropertyBag<Vector2Int>..ctor
	|-ContainerPropertyBag<Vector3>..ctor
	|-ContainerPropertyBag<Vector3Int>..ctor
	|-ContainerPropertyBag<Vector4>..ctor
	|
	|-RVA: 0x14DE8C0 Offset: 0x14DD2C0 VA: 0x1814DE8C0
	|-ContainerPropertyBag<__Il2CppFullySharedGenericType>..ctor
	*/
}

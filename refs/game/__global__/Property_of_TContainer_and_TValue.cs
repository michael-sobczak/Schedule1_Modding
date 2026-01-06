public abstract class Property<TContainer, TValue> : IProperty<TContainer>, IProperty, IAttributes // TypeDefIndex: 18352
{
	// Fields
	private List<Attribute> m_Attributes; // 0x0

	// Properties
	public abstract string Name { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 7
	public abstract string get_Name();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-Property<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Name
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public Type DeclaredValueType() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1104930 Offset: 0x1103330 VA: 0x181104930
	|-Property<Bounds, Vector3>.DeclaredValueType
	|
	|-RVA: 0x1104AB0 Offset: 0x11034B0 VA: 0x181104AB0
	|-Property<BoundsInt, Vector3Int>.DeclaredValueType
	|
	|-RVA: 0x1104C90 Offset: 0x1103690 VA: 0x181104C90
	|-Property<Color, float>.DeclaredValueType
	|
	|-RVA: 0x11049F0 Offset: 0x11033F0 VA: 0x1811049F0
	|-Property<object, int>.DeclaredValueType
	|
	|-RVA: 0x1104B10 Offset: 0x1103510 VA: 0x181104B10
	|-Property<Rect, float>.DeclaredValueType
	|
	|-RVA: 0x1104B70 Offset: 0x1103570 VA: 0x181104B70
	|-Property<RectInt, int>.DeclaredValueType
	|
	|-RVA: 0x1104CF0 Offset: 0x11036F0 VA: 0x181104CF0
	|-Property<Vector2, float>.DeclaredValueType
	|
	|-RVA: 0x1104990 Offset: 0x1103390 VA: 0x181104990
	|-Property<Vector2Int, int>.DeclaredValueType
	|
	|-RVA: 0x11048D0 Offset: 0x11032D0 VA: 0x1811048D0
	|-Property<Vector3, float>.DeclaredValueType
	|
	|-RVA: 0x1104C30 Offset: 0x1103630 VA: 0x181104C30
	|-Property<Vector3Int, int>.DeclaredValueType
	|
	|-RVA: 0x1104BD0 Offset: 0x11035D0 VA: 0x181104BD0
	|-Property<Vector4, float>.DeclaredValueType
	|
	|-RVA: 0x1104A50 Offset: 0x1103450 VA: 0x181104A50
	|-Property<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.DeclaredValueType
	*/

	// RVA: -1 Offset: -1
	protected void AddAttribute(Attribute attribute) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1103FD0 Offset: 0x11029D0 VA: 0x181103FD0
	|-Property<Bounds, Vector3>.AddAttribute
	|
	|-RVA: 0x11042D0 Offset: 0x1102CD0 VA: 0x1811042D0
	|-Property<BoundsInt, Vector3Int>.AddAttribute
	|
	|-RVA: 0x1104030 Offset: 0x1102A30 VA: 0x181104030
	|-Property<Color, float>.AddAttribute
	|
	|-RVA: 0x1104270 Offset: 0x1102C70 VA: 0x181104270
	|-Property<object, int>.AddAttribute
	|
	|-RVA: 0x1104090 Offset: 0x1102A90 VA: 0x181104090
	|-Property<Rect, float>.AddAttribute
	|
	|-RVA: 0x1104150 Offset: 0x1102B50 VA: 0x181104150
	|-Property<RectInt, int>.AddAttribute
	|
	|-RVA: 0x11041B0 Offset: 0x1102BB0 VA: 0x1811041B0
	|-Property<Vector2, float>.AddAttribute
	|
	|-RVA: 0x11043F0 Offset: 0x1102DF0 VA: 0x1811043F0
	|-Property<Vector2Int, int>.AddAttribute
	|
	|-RVA: 0x11040F0 Offset: 0x1102AF0 VA: 0x1811040F0
	|-Property<Vector3, float>.AddAttribute
	|
	|-RVA: 0x1104390 Offset: 0x1102D90 VA: 0x181104390
	|-Property<Vector3Int, int>.AddAttribute
	|
	|-RVA: 0x1104330 Offset: 0x1102D30 VA: 0x181104330
	|-Property<Vector4, float>.AddAttribute
	|
	|-RVA: 0x1104210 Offset: 0x1102C10 VA: 0x181104210
	|-Property<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.AddAttribute
	*/

	// RVA: -1 Offset: -1
	protected void AddAttributes(IEnumerable<Attribute> attributes) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1104570 Offset: 0x1102F70 VA: 0x181104570
	|-Property<Bounds, Vector3>.AddAttributes
	|
	|-RVA: 0x1104870 Offset: 0x1103270 VA: 0x181104870
	|-Property<BoundsInt, Vector3Int>.AddAttributes
	|
	|-RVA: 0x11046F0 Offset: 0x11030F0 VA: 0x1811046F0
	|-Property<Color, float>.AddAttributes
	|
	|-RVA: 0x1104510 Offset: 0x1102F10 VA: 0x181104510
	|-Property<object, int>.AddAttributes
	|
	|-RVA: 0x1104630 Offset: 0x1103030 VA: 0x181104630
	|-Property<Rect, float>.AddAttributes
	|
	|-RVA: 0x11047B0 Offset: 0x11031B0 VA: 0x1811047B0
	|-Property<RectInt, int>.AddAttributes
	|
	|-RVA: 0x1104810 Offset: 0x1103210 VA: 0x181104810
	|-Property<Vector2, float>.AddAttributes
	|
	|-RVA: 0x11045D0 Offset: 0x1102FD0 VA: 0x1811045D0
	|-Property<Vector2Int, int>.AddAttributes
	|
	|-RVA: 0x1104750 Offset: 0x1103150 VA: 0x181104750
	|-Property<Vector3, float>.AddAttributes
	|
	|-RVA: 0x1104450 Offset: 0x1102E50 VA: 0x181104450
	|-Property<Vector3Int, int>.AddAttributes
	|
	|-RVA: 0x1104690 Offset: 0x1103090 VA: 0x181104690
	|-Property<Vector4, float>.AddAttributes
	|
	|-RVA: 0x11044B0 Offset: 0x1102EB0 VA: 0x1811044B0
	|-Property<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.AddAttributes
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private void Unity.Properties.Internal.IAttributes.AddAttribute(Attribute attribute) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1104E70 Offset: 0x1103870 VA: 0x181104E70
	|-Property<Bounds, Vector3>.Unity.Properties.Internal.IAttributes.AddAttribute
	|
	|-RVA: 0x1104D50 Offset: 0x1103750 VA: 0x181104D50
	|-Property<BoundsInt, Vector3Int>.Unity.Properties.Internal.IAttributes.AddAttribute
	|
	|-RVA: 0x1105410 Offset: 0x1103E10 VA: 0x181105410
	|-Property<Color, float>.Unity.Properties.Internal.IAttributes.AddAttribute
	|
	|-RVA: 0x1104F90 Offset: 0x1103990 VA: 0x181104F90
	|-Property<object, int>.Unity.Properties.Internal.IAttributes.AddAttribute
	|
	|-RVA: 0x11059B0 Offset: 0x11043B0 VA: 0x1811059B0
	|-Property<Rect, float>.Unity.Properties.Internal.IAttributes.AddAttribute
	|
	|-RVA: 0x11052F0 Offset: 0x1103CF0 VA: 0x1811052F0
	|-Property<RectInt, int>.Unity.Properties.Internal.IAttributes.AddAttribute
	|
	|-RVA: 0x11051D0 Offset: 0x1103BD0 VA: 0x1811051D0
	|-Property<Vector2, float>.Unity.Properties.Internal.IAttributes.AddAttribute
	|
	|-RVA: 0x1105890 Offset: 0x1104290 VA: 0x181105890
	|-Property<Vector2Int, int>.Unity.Properties.Internal.IAttributes.AddAttribute
	|
	|-RVA: 0x1105650 Offset: 0x1104050 VA: 0x181105650
	|-Property<Vector3, float>.Unity.Properties.Internal.IAttributes.AddAttribute
	|
	|-RVA: 0x1105530 Offset: 0x1103F30 VA: 0x181105530
	|-Property<Vector3Int, int>.Unity.Properties.Internal.IAttributes.AddAttribute
	|
	|-RVA: 0x11050B0 Offset: 0x1103AB0 VA: 0x1811050B0
	|-Property<Vector4, float>.Unity.Properties.Internal.IAttributes.AddAttribute
	|
	|-RVA: 0x1105770 Offset: 0x1104170 VA: 0x181105770
	|-Property<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Unity.Properties.Internal.IAttributes.AddAttribute
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private void Unity.Properties.Internal.IAttributes.AddAttributes(IEnumerable<Attribute> attributes) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1106550 Offset: 0x1104F50 VA: 0x181106550
	|-Property<Bounds, Vector3>.Unity.Properties.Internal.IAttributes.AddAttributes
	|
	|-RVA: 0x1106010 Offset: 0x1104A10 VA: 0x181106010
	|-Property<BoundsInt, Vector3Int>.Unity.Properties.Internal.IAttributes.AddAttributes
	|
	|-RVA: 0x1105AD0 Offset: 0x11044D0 VA: 0x181105AD0
	|-Property<Color, float>.Unity.Properties.Internal.IAttributes.AddAttributes
	|
	|-RVA: 0x1105D70 Offset: 0x1104770 VA: 0x181105D70
	|-Property<object, int>.Unity.Properties.Internal.IAttributes.AddAttributes
	|
	|-RVA: 0x11062B0 Offset: 0x1104CB0 VA: 0x1811062B0
	|-Property<Rect, float>.Unity.Properties.Internal.IAttributes.AddAttributes
	|
	|-RVA: 0x11077B0 Offset: 0x11061B0 VA: 0x1811077B0
	|-Property<RectInt, int>.Unity.Properties.Internal.IAttributes.AddAttributes
	|
	|-RVA: 0x1107510 Offset: 0x1105F10 VA: 0x181107510
	|-Property<Vector2, float>.Unity.Properties.Internal.IAttributes.AddAttributes
	|
	|-RVA: 0x1106A90 Offset: 0x1105490 VA: 0x181106A90
	|-Property<Vector2Int, int>.Unity.Properties.Internal.IAttributes.AddAttributes
	|
	|-RVA: 0x1106FD0 Offset: 0x11059D0 VA: 0x181106FD0
	|-Property<Vector3, float>.Unity.Properties.Internal.IAttributes.AddAttributes
	|
	|-RVA: 0x1107270 Offset: 0x1105C70 VA: 0x181107270
	|-Property<Vector3Int, int>.Unity.Properties.Internal.IAttributes.AddAttributes
	|
	|-RVA: 0x11067F0 Offset: 0x11051F0 VA: 0x1811067F0
	|-Property<Vector4, float>.Unity.Properties.Internal.IAttributes.AddAttributes
	|
	|-RVA: 0x1106D30 Offset: 0x1105730 VA: 0x181106D30
	|-Property<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Unity.Properties.Internal.IAttributes.AddAttributes
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public bool HasAttribute<TAttribute>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDC9BD0 Offset: 0xDC85D0 VA: 0x180DC9BD0
	|-Property<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.HasAttribute<object>
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	|-Property<Bounds, Vector3>..ctor
	|-Property<BoundsInt, Vector3Int>..ctor
	|-Property<Color, float>..ctor
	|-Property<object, int>..ctor
	|-Property<Rect, float>..ctor
	|-Property<RectInt, int>..ctor
	|-Property<Vector2, float>..ctor
	|-Property<Vector2Int, int>..ctor
	|-Property<Vector3, float>..ctor
	|-Property<Vector3Int, int>..ctor
	|-Property<Vector4, float>..ctor
	|-Property<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/
}

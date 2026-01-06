public abstract class BaseCompositeField<TValueType, TField, TFieldValue> : BaseField<TValueType> // TypeDefIndex: 6214
{
	// Fields
	private List<TField> m_Fields; // 0x0
	private bool m_ShouldUpdateDisplay; // 0x0
	private bool m_ForceUpdateDisplay; // 0x0
	private int m_PropertyIndex; // 0x0
	public static readonly string ussClassName; // 0x0
	public static readonly string labelUssClassName; // 0x0
	public static readonly string inputUssClassName; // 0x0
	public static readonly string spacerUssClassName; // 0x0
	public static readonly string multilineVariantUssClassName; // 0x0
	public static readonly string fieldGroupUssClassName; // 0x0
	public static readonly string fieldUssClassName; // 0x0
	public static readonly string firstFieldVariantUssClassName; // 0x0
	public static readonly string twoLinesVariantUssClassName; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	private VisualElement GetSpacer() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12B27C0 Offset: 0x12B11C0 VA: 0x1812B27C0
	|-BaseCompositeField<Rect, object, float>.GetSpacer
	|
	|-RVA: 0x12B2520 Offset: 0x12B0F20 VA: 0x1812B2520
	|-BaseCompositeField<RectInt, object, int>.GetSpacer
	|
	|-RVA: 0x12B2600 Offset: 0x12B1000 VA: 0x1812B2600
	|-BaseCompositeField<Vector2, object, float>.GetSpacer
	|
	|-RVA: 0x12B2440 Offset: 0x12B0E40 VA: 0x1812B2440
	|-BaseCompositeField<Vector2Int, object, int>.GetSpacer
	|
	|-RVA: 0x12B26E0 Offset: 0x12B10E0 VA: 0x1812B26E0
	|-BaseCompositeField<Vector3, object, float>.GetSpacer
	|
	|-RVA: 0x13C7F90 Offset: 0x13C6990 VA: 0x1813C7F90
	|-BaseCompositeField<Vector3Int, object, int>.GetSpacer
	|
	|-RVA: 0x13C8070 Offset: 0x13C6A70 VA: 0x1813C8070
	|-BaseCompositeField<Vector4, object, float>.GetSpacer
	|
	|-RVA: 0x13C7EB0 Offset: 0x13C68B0 VA: 0x1813C7EB0
	|-BaseCompositeField<__Il2CppFullySharedGenericType, object, __Il2CppFullySharedGenericType>.GetSpacer
	*/

	// RVA: -1 Offset: -1 Slot: 119
	internal abstract BaseCompositeField.FieldDescription<TValueType, TField, TFieldValue>[] DescribeFields();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-BaseCompositeField<__Il2CppFullySharedGenericType, object, __Il2CppFullySharedGenericType>.DescribeFields
	*/

	// RVA: -1 Offset: -1
	protected void .ctor(string label, int fieldsByLine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12B8990 Offset: 0x12B7390 VA: 0x1812B8990
	|-BaseCompositeField<Rect, object, float>..ctor
	|
	|-RVA: 0x12B7610 Offset: 0x12B6010 VA: 0x1812B7610
	|-BaseCompositeField<RectInt, object, int>..ctor
	|
	|-RVA: 0x12B6290 Offset: 0x12B4C90 VA: 0x1812B6290
	|-BaseCompositeField<Vector2, object, float>..ctor
	|
	|-RVA: 0x12B7FD0 Offset: 0x12B69D0 VA: 0x1812B7FD0
	|-BaseCompositeField<Vector2Int, object, int>..ctor
	|
	|-RVA: 0x12B6C50 Offset: 0x12B5650 VA: 0x1812B6C50
	|-BaseCompositeField<Vector3, object, float>..ctor
	|
	|-RVA: 0x13CA700 Offset: 0x13C9100 VA: 0x1813CA700
	|-BaseCompositeField<Vector3Int, object, int>..ctor
	|
	|-RVA: 0x13CB0C0 Offset: 0x13C9AC0 VA: 0x1813CB0C0
	|-BaseCompositeField<Vector4, object, float>..ctor
	|
	|-RVA: 0x13CBA80 Offset: 0x13CA480 VA: 0x1813CBA80
	|-BaseCompositeField<__Il2CppFullySharedGenericType, object, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	private void UpdateDisplay() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12B3640 Offset: 0x12B2040 VA: 0x1812B3640
	|-BaseCompositeField<Rect, object, float>.UpdateDisplay
	|-BaseCompositeField<Vector4, object, float>.UpdateDisplay
	|
	|-RVA: 0x12B34F0 Offset: 0x12B1EF0 VA: 0x1812B34F0
	|-BaseCompositeField<RectInt, object, int>.UpdateDisplay
	|
	|-RVA: 0x12B33B0 Offset: 0x12B1DB0 VA: 0x1812B33B0
	|-BaseCompositeField<Vector2, object, float>.UpdateDisplay
	|
	|-RVA: 0x12B3790 Offset: 0x12B2190 VA: 0x1812B3790
	|-BaseCompositeField<Vector2Int, object, int>.UpdateDisplay
	|
	|-RVA: 0x12B38D0 Offset: 0x12B22D0 VA: 0x1812B38D0
	|-BaseCompositeField<Vector3, object, float>.UpdateDisplay
	|
	|-RVA: 0x13C8950 Offset: 0x13C7350 VA: 0x1813C8950
	|-BaseCompositeField<Vector3Int, object, int>.UpdateDisplay
	|
	|-RVA: 0x13C8AA0 Offset: 0x13C74A0 VA: 0x1813C8AA0
	|-BaseCompositeField<__Il2CppFullySharedGenericType, object, __Il2CppFullySharedGenericType>.UpdateDisplay
	*/

	// RVA: -1 Offset: -1 Slot: 118
	public override void SetValueWithoutNotify(TValueType newValue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12B3190 Offset: 0x12B1B90 VA: 0x1812B3190
	|-BaseCompositeField<Rect, object, float>.SetValueWithoutNotify
	|
	|-RVA: 0x12B2940 Offset: 0x12B1340 VA: 0x1812B2940
	|-BaseCompositeField<RectInt, object, int>.SetValueWithoutNotify
	|
	|-RVA: 0x12B2B60 Offset: 0x12B1560 VA: 0x1812B2B60
	|-BaseCompositeField<Vector2, object, float>.SetValueWithoutNotify
	|
	|-RVA: 0x12B2D60 Offset: 0x12B1760 VA: 0x1812B2D60
	|-BaseCompositeField<Vector2Int, object, int>.SetValueWithoutNotify
	|
	|-RVA: 0x12B2F50 Offset: 0x12B1950 VA: 0x1812B2F50
	|-BaseCompositeField<Vector3, object, float>.SetValueWithoutNotify
	|
	|-RVA: 0x13C8710 Offset: 0x13C7110 VA: 0x1813C8710
	|-BaseCompositeField<Vector3Int, object, int>.SetValueWithoutNotify
	|
	|-RVA: 0x13C84F0 Offset: 0x13C6EF0 VA: 0x1813C84F0
	|-BaseCompositeField<Vector4, object, float>.SetValueWithoutNotify
	|
	|-RVA: 0x13C8220 Offset: 0x13C6C20 VA: 0x1813C8220
	|-BaseCompositeField<__Il2CppFullySharedGenericType, object, __Il2CppFullySharedGenericType>.SetValueWithoutNotify
	*/

	// RVA: -1 Offset: -1 Slot: 96
	internal override void OnViewDataReady() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12B28C0 Offset: 0x12B12C0 VA: 0x1812B28C0
	|-BaseCompositeField<Rect, object, float>.OnViewDataReady
	|
	|-RVA: 0x12B2920 Offset: 0x12B1320 VA: 0x1812B2920
	|-BaseCompositeField<RectInt, object, int>.OnViewDataReady
	|
	|-RVA: 0x12B28A0 Offset: 0x12B12A0 VA: 0x1812B28A0
	|-BaseCompositeField<Vector2, object, float>.OnViewDataReady
	|
	|-RVA: 0x12B2900 Offset: 0x12B1300 VA: 0x1812B2900
	|-BaseCompositeField<Vector2Int, object, int>.OnViewDataReady
	|
	|-RVA: 0x12B28E0 Offset: 0x12B12E0 VA: 0x1812B28E0
	|-BaseCompositeField<Vector3, object, float>.OnViewDataReady
	|
	|-RVA: 0x13C8150 Offset: 0x13C6B50 VA: 0x1813C8150
	|-BaseCompositeField<Vector3Int, object, int>.OnViewDataReady
	|
	|-RVA: 0x13C8170 Offset: 0x13C6B70 VA: 0x1813C8170
	|-BaseCompositeField<Vector4, object, float>.OnViewDataReady
	|
	|-RVA: 0x13C8190 Offset: 0x13C6B90 VA: 0x1813C8190
	|-BaseCompositeField<__Il2CppFullySharedGenericType, object, __Il2CppFullySharedGenericType>.OnViewDataReady
	*/

	// RVA: -1 Offset: -1 Slot: 117
	protected override void UpdateMixedValueContent() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12B3A20 Offset: 0x12B2420 VA: 0x1812B3A20
	|-BaseCompositeField<Rect, object, float>.UpdateMixedValueContent
	|-BaseCompositeField<RectInt, object, int>.UpdateMixedValueContent
	|-BaseCompositeField<Vector3, object, float>.UpdateMixedValueContent
	|-BaseCompositeField<Vector4, object, float>.UpdateMixedValueContent
	|
	|-RVA: 0x12B3B70 Offset: 0x12B2570 VA: 0x1812B3B70
	|-BaseCompositeField<Vector2, object, float>.UpdateMixedValueContent
	|-BaseCompositeField<Vector2Int, object, int>.UpdateMixedValueContent
	|
	|-RVA: 0x13C8D10 Offset: 0x13C7710 VA: 0x1813C8D10
	|-BaseCompositeField<Vector3Int, object, int>.UpdateMixedValueContent
	|
	|-RVA: 0x13C8EA0 Offset: 0x13C78A0 VA: 0x1813C8EA0
	|-BaseCompositeField<__Il2CppFullySharedGenericType, object, __Il2CppFullySharedGenericType>.UpdateMixedValueContent
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12B4BE0 Offset: 0x12B35E0 VA: 0x1812B4BE0
	|-BaseCompositeField<Rect, object, float>..cctor
	|
	|-RVA: 0x12B5370 Offset: 0x12B3D70 VA: 0x1812B5370
	|-BaseCompositeField<RectInt, object, int>..cctor
	|
	|-RVA: 0x12B4450 Offset: 0x12B2E50 VA: 0x1812B4450
	|-BaseCompositeField<Vector2, object, float>..cctor
	|
	|-RVA: 0x12B5B00 Offset: 0x12B4500 VA: 0x1812B5B00
	|-BaseCompositeField<Vector2Int, object, int>..cctor
	|
	|-RVA: 0x12B3CC0 Offset: 0x12B26C0 VA: 0x1812B3CC0
	|-BaseCompositeField<Vector3, object, float>..cctor
	|
	|-RVA: 0x13C9050 Offset: 0x13C7A50 VA: 0x1813C9050
	|-BaseCompositeField<Vector3Int, object, int>..cctor
	|
	|-RVA: 0x13C9F70 Offset: 0x13C8970 VA: 0x1813C9F70
	|-BaseCompositeField<Vector4, object, float>..cctor
	|
	|-RVA: 0x13C97E0 Offset: 0x13C81E0 VA: 0x1813C97E0
	|-BaseCompositeField<__Il2CppFullySharedGenericType, object, __Il2CppFullySharedGenericType>..cctor
	*/
}

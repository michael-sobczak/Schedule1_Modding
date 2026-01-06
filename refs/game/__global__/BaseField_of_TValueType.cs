public abstract class BaseField<TValueType> : BindableElement, INotifyValueChanged<TValueType>, IEditableElement // TypeDefIndex: 6322
{
	// Fields
	public static readonly string ussClassName; // 0x0
	public static readonly string labelUssClassName; // 0x0
	public static readonly string inputUssClassName; // 0x0
	public static readonly string noLabelVariantUssClassName; // 0x0
	public static readonly string labelDraggerVariantUssClassName; // 0x0
	public static readonly string mixedValueLabelUssClassName; // 0x0
	public static readonly string alignedFieldUssClassName; // 0x0
	private static readonly string inspectorFieldUssClassName; // 0x0
	protected internal static readonly string mixedValueString; // 0x0
	protected internal static readonly PropertyName serializedPropertyCopyName; // 0x0
	private static CustomStyleProperty<float> s_LabelWidthRatioProperty; // 0x0
	private static CustomStyleProperty<float> s_LabelExtraPaddingProperty; // 0x0
	private static CustomStyleProperty<float> s_LabelBaseMinWidthProperty; // 0x0
	private static CustomStyleProperty<float> s_LabelExtraContextWidthProperty; // 0x0
	private float m_LabelWidthRatio; // 0x0
	private float m_LabelExtraPadding; // 0x0
	private float m_LabelBaseMinWidth; // 0x0
	private float m_LabelExtraContextWidth; // 0x0
	private VisualElement m_VisualInput; // 0x0
	internal Action<ExpressionEvaluator.Expression> expressionEvaluated; // 0x0
	[SerializeField]
	private TValueType m_Value; // 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private Func<TValueType, TValueType> onValidateValue; // 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private Label <labelElement>k__BackingField; // 0x0
	private bool m_ShowMixedValue; // 0x0
	private Label m_MixedValueLabel; // 0x0
	private bool m_SkipValidation; // 0x0
	private VisualElement m_CachedContextWidthElement; // 0x0
	private VisualElement m_CachedInspectorElement; // 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private Action <UnityEngine.UIElements.IEditableElement.editingStarted>k__BackingField; // 0x0
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private Action <UnityEngine.UIElements.IEditableElement.editingEnded>k__BackingField; // 0x0

	// Properties
	internal VisualElement visualInput { get; set; }
	protected TValueType rawValue { get; set; }
	public virtual TValueType value { get; set; }
	public Label labelElement { get; set; }
	public string label { get; set; }
	public bool showMixedValue { get; set; }
	internal virtual bool canSwitchToMixedValue { get; }
	protected Label mixedValueLabel { get; }
	private Action UnityEngine.UIElements.IEditableElement.editingStarted { get; }
	private Action UnityEngine.UIElements.IEditableElement.editingEnded { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal VisualElement get_visualInput() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13E3580 Offset: 0x13E1F80 VA: 0x1813E3580
	|-BaseField<bool>.get_visualInput
	|-BaseField<Bounds>.get_visualInput
	|-BaseField<BoundsInt>.get_visualInput
	|-BaseField<double>.get_visualInput
	|-BaseField<Hash128>.get_visualInput
	|-BaseField<int>.get_visualInput
	|-BaseField<long>.get_visualInput
	|-BaseField<object>.get_visualInput
	|-BaseField<Rect>.get_visualInput
	|-BaseField<RectInt>.get_visualInput
	|-BaseField<float>.get_visualInput
	|-BaseField<uint>.get_visualInput
	|-BaseField<ulong>.get_visualInput
	|-BaseField<Vector2>.get_visualInput
	|-BaseField<Vector2Int>.get_visualInput
	|-BaseField<Vector3>.get_visualInput
	|-BaseField<Vector3Int>.get_visualInput
	|-BaseField<Vector4>.get_visualInput
	|
	|-RVA: 0x1411800 Offset: 0x1410200 VA: 0x181411800
	|-BaseField<__Il2CppFullySharedGenericType>.get_visualInput
	*/

	// RVA: -1 Offset: -1
	internal void set_visualInput(VisualElement value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13E5920 Offset: 0x13E4320 VA: 0x1813E5920
	|-BaseField<bool>.set_visualInput
	|
	|-RVA: 0x13E5AA0 Offset: 0x13E44A0 VA: 0x1813E5AA0
	|-BaseField<Bounds>.set_visualInput
	|
	|-RVA: 0x13E5620 Offset: 0x13E4020 VA: 0x1813E5620
	|-BaseField<BoundsInt>.set_visualInput
	|
	|-RVA: 0x13E54A0 Offset: 0x13E3EA0 VA: 0x1813E54A0
	|-BaseField<double>.set_visualInput
	|
	|-RVA: 0x13E5F20 Offset: 0x13E4920 VA: 0x1813E5F20
	|-BaseField<Hash128>.set_visualInput
	|
	|-RVA: 0x13E5320 Offset: 0x13E3D20 VA: 0x1813E5320
	|-BaseField<int>.set_visualInput
	|
	|-RVA: 0x13E5C20 Offset: 0x13E4620 VA: 0x1813E5C20
	|-BaseField<long>.set_visualInput
	|
	|-RVA: 0x13E60A0 Offset: 0x13E4AA0 VA: 0x1813E60A0
	|-BaseField<object>.set_visualInput
	|
	|-RVA: 0x13E5DA0 Offset: 0x13E47A0 VA: 0x1813E5DA0
	|-BaseField<Rect>.set_visualInput
	|
	|-RVA: 0x13E57A0 Offset: 0x13E41A0 VA: 0x1813E57A0
	|-BaseField<RectInt>.set_visualInput
	|
	|-RVA: 0x1413B60 Offset: 0x1412560 VA: 0x181413B60
	|-BaseField<float>.set_visualInput
	|
	|-RVA: 0x1413280 Offset: 0x1411C80 VA: 0x181413280
	|-BaseField<uint>.set_visualInput
	|
	|-RVA: 0x14136E0 Offset: 0x14120E0 VA: 0x1814136E0
	|-BaseField<ulong>.set_visualInput
	|
	|-RVA: 0x14139E0 Offset: 0x14123E0 VA: 0x1814139E0
	|-BaseField<Vector2>.set_visualInput
	|
	|-RVA: 0x1413100 Offset: 0x1411B00 VA: 0x181413100
	|-BaseField<Vector2Int>.set_visualInput
	|
	|-RVA: 0x1413E60 Offset: 0x1412860 VA: 0x181413E60
	|-BaseField<Vector3>.set_visualInput
	|
	|-RVA: 0x1413860 Offset: 0x1412260 VA: 0x181413860
	|-BaseField<Vector3Int>.set_visualInput
	|
	|-RVA: 0x1413CE0 Offset: 0x14126E0 VA: 0x181413CE0
	|-BaseField<Vector4>.set_visualInput
	|
	|-RVA: 0x1413400 Offset: 0x1411E00 VA: 0x181413400
	|-BaseField<__Il2CppFullySharedGenericType>.set_visualInput
	*/

	// RVA: -1 Offset: -1
	protected TValueType get_rawValue() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13E3530 Offset: 0x13E1F30 VA: 0x1813E3530
	|-BaseField<bool>.get_rawValue
	|
	|-RVA: 0x13E3510 Offset: 0x13E1F10 VA: 0x1813E3510
	|-BaseField<Bounds>.get_rawValue
	|-BaseField<BoundsInt>.get_rawValue
	|
	|-RVA: 0x13E3500 Offset: 0x13E1F00 VA: 0x1813E3500
	|-BaseField<double>.get_rawValue
	|
	|-RVA: 0x13E34F0 Offset: 0x13E1EF0 VA: 0x1813E34F0
	|-BaseField<Hash128>.get_rawValue
	|-BaseField<Rect>.get_rawValue
	|-BaseField<RectInt>.get_rawValue
	|-BaseField<Vector4>.get_rawValue
	|
	|-RVA: 0x13E3540 Offset: 0x13E1F40 VA: 0x1813E3540
	|-BaseField<int>.get_rawValue
	|-BaseField<uint>.get_rawValue
	|
	|-RVA: 0x13E34E0 Offset: 0x13E1EE0 VA: 0x1813E34E0
	|-BaseField<long>.get_rawValue
	|-BaseField<object>.get_rawValue
	|-BaseField<ulong>.get_rawValue
	|-BaseField<Vector2Int>.get_rawValue
	|
	|-RVA: 0x14117C0 Offset: 0x14101C0 VA: 0x1814117C0
	|-BaseField<float>.get_rawValue
	|
	|-RVA: 0x14117A0 Offset: 0x14101A0 VA: 0x1814117A0
	|-BaseField<Vector2>.get_rawValue
	|
	|-RVA: 0x1411780 Offset: 0x1410180 VA: 0x181411780
	|-BaseField<Vector3>.get_rawValue
	|-BaseField<Vector3Int>.get_rawValue
	|
	|-RVA: 0x1411670 Offset: 0x1410070 VA: 0x181411670
	|-BaseField<__Il2CppFullySharedGenericType>.get_rawValue
	*/

	// RVA: -1 Offset: -1
	protected void set_rawValue(TValueType value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13E3EB0 Offset: 0x13E28B0 VA: 0x1813E3EB0
	|-BaseField<bool>.set_rawValue
	|
	|-RVA: 0x13E3E40 Offset: 0x13E2840 VA: 0x1813E3E40
	|-BaseField<Bounds>.set_rawValue
	|-BaseField<BoundsInt>.set_rawValue
	|
	|-RVA: 0x13E3EA0 Offset: 0x13E28A0 VA: 0x1813E3EA0
	|-BaseField<double>.set_rawValue
	|
	|-RVA: 0x13E3E60 Offset: 0x13E2860 VA: 0x1813E3E60
	|-BaseField<Hash128>.set_rawValue
	|-BaseField<Rect>.set_rawValue
	|-BaseField<RectInt>.set_rawValue
	|-BaseField<Vector4>.set_rawValue
	|
	|-RVA: 0x13E3E30 Offset: 0x13E2830 VA: 0x1813E3E30
	|-BaseField<int>.set_rawValue
	|-BaseField<uint>.set_rawValue
	|
	|-RVA: 0x13E3E70 Offset: 0x13E2870 VA: 0x1813E3E70
	|-BaseField<long>.set_rawValue
	|-BaseField<ulong>.set_rawValue
	|-BaseField<Vector2>.set_rawValue
	|-BaseField<Vector2Int>.set_rawValue
	|
	|-RVA: 0x13E3E80 Offset: 0x13E2880 VA: 0x1813E3E80
	|-BaseField<object>.set_rawValue
	|
	|-RVA: 0x1411D10 Offset: 0x1410710 VA: 0x181411D10
	|-BaseField<float>.set_rawValue
	|
	|-RVA: 0x1411CF0 Offset: 0x14106F0 VA: 0x181411CF0
	|-BaseField<Vector3>.set_rawValue
	|-BaseField<Vector3Int>.set_rawValue
	|
	|-RVA: 0x1411C30 Offset: 0x1410630 VA: 0x181411C30
	|-BaseField<__Il2CppFullySharedGenericType>.set_rawValue
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	internal void add_onValidateValue(Func<TValueType, TValueType> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13E23B0 Offset: 0x13E0DB0 VA: 0x1813E23B0
	|-BaseField<bool>.add_onValidateValue
	|-BaseField<double>.add_onValidateValue
	|-BaseField<int>.add_onValidateValue
	|-BaseField<long>.add_onValidateValue
	|-BaseField<object>.add_onValidateValue
	|-BaseField<float>.add_onValidateValue
	|-BaseField<uint>.add_onValidateValue
	|-BaseField<ulong>.add_onValidateValue
	|-BaseField<Vector2>.add_onValidateValue
	|-BaseField<Vector2Int>.add_onValidateValue
	|
	|-RVA: 0x13E2210 Offset: 0x13E0C10 VA: 0x1813E2210
	|-BaseField<Bounds>.add_onValidateValue
	|-BaseField<BoundsInt>.add_onValidateValue
	|
	|-RVA: 0x13E22E0 Offset: 0x13E0CE0 VA: 0x1813E22E0
	|-BaseField<Hash128>.add_onValidateValue
	|-BaseField<Rect>.add_onValidateValue
	|-BaseField<RectInt>.add_onValidateValue
	|-BaseField<Vector3>.add_onValidateValue
	|-BaseField<Vector3Int>.add_onValidateValue
	|-BaseField<Vector4>.add_onValidateValue
	|
	|-RVA: 0x1410620 Offset: 0x140F020 VA: 0x181410620
	|-BaseField<__Il2CppFullySharedGenericType>.add_onValidateValue
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	internal void remove_onValidateValue(Func<TValueType, TValueType> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13E3590 Offset: 0x13E1F90 VA: 0x1813E3590
	|-BaseField<bool>.remove_onValidateValue
	|-BaseField<double>.remove_onValidateValue
	|-BaseField<int>.remove_onValidateValue
	|-BaseField<long>.remove_onValidateValue
	|-BaseField<object>.remove_onValidateValue
	|-BaseField<float>.remove_onValidateValue
	|-BaseField<uint>.remove_onValidateValue
	|-BaseField<ulong>.remove_onValidateValue
	|-BaseField<Vector2>.remove_onValidateValue
	|-BaseField<Vector2Int>.remove_onValidateValue
	|
	|-RVA: 0x13E3730 Offset: 0x13E2130 VA: 0x1813E3730
	|-BaseField<Bounds>.remove_onValidateValue
	|-BaseField<BoundsInt>.remove_onValidateValue
	|
	|-RVA: 0x13E3660 Offset: 0x13E2060 VA: 0x1813E3660
	|-BaseField<Hash128>.remove_onValidateValue
	|-BaseField<Rect>.remove_onValidateValue
	|-BaseField<RectInt>.remove_onValidateValue
	|-BaseField<Vector3>.remove_onValidateValue
	|-BaseField<Vector3Int>.remove_onValidateValue
	|-BaseField<Vector4>.remove_onValidateValue
	|
	|-RVA: 0x1411830 Offset: 0x1410230 VA: 0x181411830
	|-BaseField<__Il2CppFullySharedGenericType>.remove_onValidateValue
	*/

	// RVA: -1 Offset: -1 Slot: 107
	public virtual TValueType get_value() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13E3530 Offset: 0x13E1F30 VA: 0x1813E3530
	|-BaseField<bool>.get_value
	|
	|-RVA: 0x13E3510 Offset: 0x13E1F10 VA: 0x1813E3510
	|-BaseField<Bounds>.get_value
	|-BaseField<BoundsInt>.get_value
	|
	|-RVA: 0x13E3500 Offset: 0x13E1F00 VA: 0x1813E3500
	|-BaseField<double>.get_value
	|
	|-RVA: 0x13E34F0 Offset: 0x13E1EF0 VA: 0x1813E34F0
	|-BaseField<Hash128>.get_value
	|-BaseField<Rect>.get_value
	|-BaseField<RectInt>.get_value
	|-BaseField<Vector4>.get_value
	|
	|-RVA: 0x13E3540 Offset: 0x13E1F40 VA: 0x1813E3540
	|-BaseField<int>.get_value
	|-BaseField<uint>.get_value
	|
	|-RVA: 0x13E34E0 Offset: 0x13E1EE0 VA: 0x1813E34E0
	|-BaseField<long>.get_value
	|-BaseField<object>.get_value
	|-BaseField<ulong>.get_value
	|-BaseField<Vector2Int>.get_value
	|
	|-RVA: 0x14117C0 Offset: 0x14101C0 VA: 0x1814117C0
	|-BaseField<float>.get_value
	|
	|-RVA: 0x14117A0 Offset: 0x14101A0 VA: 0x1814117A0
	|-BaseField<Vector2>.get_value
	|
	|-RVA: 0x1411780 Offset: 0x1410180 VA: 0x181411780
	|-BaseField<Vector3>.get_value
	|-BaseField<Vector3Int>.get_value
	|
	|-RVA: 0x1411670 Offset: 0x1410070 VA: 0x181411670
	|-BaseField<__Il2CppFullySharedGenericType>.get_value
	*/

	// RVA: -1 Offset: -1 Slot: 108
	public virtual void set_value(TValueType value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13E4BE0 Offset: 0x13E35E0 VA: 0x1813E4BE0
	|-BaseField<bool>.set_value
	|
	|-RVA: 0x13E49A0 Offset: 0x13E33A0 VA: 0x1813E49A0
	|-BaseField<Bounds>.set_value
	|
	|-RVA: 0x13E4560 Offset: 0x13E2F60 VA: 0x1813E4560
	|-BaseField<BoundsInt>.set_value
	|
	|-RVA: 0x13E43A0 Offset: 0x13E2DA0 VA: 0x1813E43A0
	|-BaseField<double>.set_value
	|
	|-RVA: 0x13E5120 Offset: 0x13E3B20 VA: 0x1813E5120
	|-BaseField<Hash128>.set_value
	|
	|-RVA: 0x13E4DA0 Offset: 0x13E37A0 VA: 0x1813E4DA0
	|-BaseField<int>.set_value
	|
	|-RVA: 0x13E41E0 Offset: 0x13E2BE0 VA: 0x1813E41E0
	|-BaseField<long>.set_value
	|
	|-RVA: 0x13E4F60 Offset: 0x13E3960 VA: 0x1813E4F60
	|-BaseField<object>.set_value
	|
	|-RVA: 0x13E3FE0 Offset: 0x13E29E0 VA: 0x1813E3FE0
	|-BaseField<Rect>.set_value
	|
	|-RVA: 0x13E47A0 Offset: 0x13E31A0 VA: 0x1813E47A0
	|-BaseField<RectInt>.set_value
	|
	|-RVA: 0x1412960 Offset: 0x1411360 VA: 0x181412960
	|-BaseField<float>.set_value
	|
	|-RVA: 0x1411DF0 Offset: 0x14107F0 VA: 0x181411DF0
	|-BaseField<uint>.set_value
	|
	|-RVA: 0x14123D0 Offset: 0x1410DD0 VA: 0x1814123D0
	|-BaseField<ulong>.set_value
	|
	|-RVA: 0x1412590 Offset: 0x1410F90 VA: 0x181412590
	|-BaseField<Vector2>.set_value
	|
	|-RVA: 0x14127A0 Offset: 0x14111A0 VA: 0x1814127A0
	|-BaseField<Vector2Int>.set_value
	|
	|-RVA: 0x1412B20 Offset: 0x1411520 VA: 0x181412B20
	|-BaseField<Vector3>.set_value
	|
	|-RVA: 0x1411FB0 Offset: 0x14109B0 VA: 0x181411FB0
	|-BaseField<Vector3Int>.set_value
	|
	|-RVA: 0x14121D0 Offset: 0x1410BD0 VA: 0x1814121D0
	|-BaseField<Vector4>.set_value
	|
	|-RVA: 0x1412D40 Offset: 0x1411740 VA: 0x181412D40
	|-BaseField<__Il2CppFullySharedGenericType>.set_value
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 109
	public Label get_labelElement() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13E2480 Offset: 0x13E0E80 VA: 0x1813E2480
	|-BaseField<bool>.get_labelElement
	|-BaseField<double>.get_labelElement
	|-BaseField<int>.get_labelElement
	|-BaseField<long>.get_labelElement
	|-BaseField<object>.get_labelElement
	|-BaseField<float>.get_labelElement
	|-BaseField<uint>.get_labelElement
	|-BaseField<ulong>.get_labelElement
	|-BaseField<Vector2>.get_labelElement
	|-BaseField<Vector2Int>.get_labelElement
	|
	|-RVA: 0x13E2490 Offset: 0x13E0E90 VA: 0x1813E2490
	|-BaseField<Bounds>.get_labelElement
	|-BaseField<BoundsInt>.get_labelElement
	|
	|-RVA: 0x13E24A0 Offset: 0x13E0EA0 VA: 0x1813E24A0
	|-BaseField<Hash128>.get_labelElement
	|-BaseField<Rect>.get_labelElement
	|-BaseField<RectInt>.get_labelElement
	|-BaseField<Vector3>.get_labelElement
	|-BaseField<Vector3Int>.get_labelElement
	|-BaseField<Vector4>.get_labelElement
	|
	|-RVA: 0x1410730 Offset: 0x140F130 VA: 0x181410730
	|-BaseField<__Il2CppFullySharedGenericType>.get_labelElement
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	private void set_labelElement(Label value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13E3800 Offset: 0x13E2200 VA: 0x1813E3800
	|-BaseField<bool>.set_labelElement
	|-BaseField<double>.set_labelElement
	|-BaseField<int>.set_labelElement
	|-BaseField<long>.set_labelElement
	|-BaseField<object>.set_labelElement
	|-BaseField<float>.set_labelElement
	|-BaseField<uint>.set_labelElement
	|-BaseField<ulong>.set_labelElement
	|-BaseField<Vector2>.set_labelElement
	|-BaseField<Vector2Int>.set_labelElement
	|
	|-RVA: 0x13E3820 Offset: 0x13E2220 VA: 0x1813E3820
	|-BaseField<Bounds>.set_labelElement
	|-BaseField<BoundsInt>.set_labelElement
	|
	|-RVA: 0x13E3840 Offset: 0x13E2240 VA: 0x1813E3840
	|-BaseField<Hash128>.set_labelElement
	|-BaseField<Rect>.set_labelElement
	|-BaseField<RectInt>.set_labelElement
	|-BaseField<Vector3>.set_labelElement
	|-BaseField<Vector3Int>.set_labelElement
	|-BaseField<Vector4>.set_labelElement
	|
	|-RVA: 0x1411940 Offset: 0x1410340 VA: 0x181411940
	|-BaseField<__Il2CppFullySharedGenericType>.set_labelElement
	*/

	// RVA: -1 Offset: -1 Slot: 110
	public string get_label() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13E24B0 Offset: 0x13E0EB0 VA: 0x1813E24B0
	|-BaseField<bool>.get_label
	|-BaseField<double>.get_label
	|-BaseField<int>.get_label
	|-BaseField<long>.get_label
	|-BaseField<object>.get_label
	|-BaseField<float>.get_label
	|-BaseField<uint>.get_label
	|-BaseField<ulong>.get_label
	|-BaseField<Vector2>.get_label
	|-BaseField<Vector2Int>.get_label
	|
	|-RVA: 0x13E2510 Offset: 0x13E0F10 VA: 0x1813E2510
	|-BaseField<Bounds>.get_label
	|-BaseField<BoundsInt>.get_label
	|
	|-RVA: 0x13E24E0 Offset: 0x13E0EE0 VA: 0x1813E24E0
	|-BaseField<Hash128>.get_label
	|-BaseField<Rect>.get_label
	|-BaseField<RectInt>.get_label
	|-BaseField<Vector3>.get_label
	|-BaseField<Vector3Int>.get_label
	|-BaseField<Vector4>.get_label
	|
	|-RVA: 0x1410760 Offset: 0x140F160 VA: 0x181410760
	|-BaseField<__Il2CppFullySharedGenericType>.get_label
	*/

	// RVA: -1 Offset: -1
	public void set_label(string value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13E3A50 Offset: 0x13E2450 VA: 0x1813E3A50
	|-BaseField<bool>.set_label
	|-BaseField<double>.set_label
	|-BaseField<int>.set_label
	|-BaseField<long>.set_label
	|-BaseField<object>.set_label
	|-BaseField<float>.set_label
	|-BaseField<uint>.set_label
	|-BaseField<ulong>.set_label
	|-BaseField<Vector2>.set_label
	|-BaseField<Vector2Int>.set_label
	|
	|-RVA: 0x13E3C40 Offset: 0x13E2640 VA: 0x1813E3C40
	|-BaseField<Bounds>.set_label
	|-BaseField<BoundsInt>.set_label
	|
	|-RVA: 0x13E3860 Offset: 0x13E2260 VA: 0x1813E3860
	|-BaseField<Hash128>.set_label
	|-BaseField<Rect>.set_label
	|-BaseField<RectInt>.set_label
	|-BaseField<Vector3>.set_label
	|-BaseField<Vector3Int>.set_label
	|-BaseField<Vector4>.set_label
	|
	|-RVA: 0x14119B0 Offset: 0x14103B0 VA: 0x1814119B0
	|-BaseField<__Il2CppFullySharedGenericType>.set_label
	*/

	// RVA: -1 Offset: -1 Slot: 111
	public bool get_showMixedValue() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13E3550 Offset: 0x13E1F50 VA: 0x1813E3550
	|-BaseField<bool>.get_showMixedValue
	|-BaseField<double>.get_showMixedValue
	|-BaseField<int>.get_showMixedValue
	|-BaseField<long>.get_showMixedValue
	|-BaseField<object>.get_showMixedValue
	|-BaseField<float>.get_showMixedValue
	|-BaseField<uint>.get_showMixedValue
	|-BaseField<ulong>.get_showMixedValue
	|-BaseField<Vector2>.get_showMixedValue
	|-BaseField<Vector2Int>.get_showMixedValue
	|
	|-RVA: 0x13E3560 Offset: 0x13E1F60 VA: 0x1813E3560
	|-BaseField<Bounds>.get_showMixedValue
	|-BaseField<BoundsInt>.get_showMixedValue
	|
	|-RVA: 0x13E3570 Offset: 0x13E1F70 VA: 0x1813E3570
	|-BaseField<Hash128>.get_showMixedValue
	|-BaseField<Rect>.get_showMixedValue
	|-BaseField<RectInt>.get_showMixedValue
	|-BaseField<Vector3>.get_showMixedValue
	|-BaseField<Vector3Int>.get_showMixedValue
	|-BaseField<Vector4>.get_showMixedValue
	|
	|-RVA: 0x14117D0 Offset: 0x14101D0 VA: 0x1814117D0
	|-BaseField<__Il2CppFullySharedGenericType>.get_showMixedValue
	*/

	// RVA: -1 Offset: -1 Slot: 112
	public void set_showMixedValue(bool value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13E3F20 Offset: 0x13E2920 VA: 0x1813E3F20
	|-BaseField<bool>.set_showMixedValue
	|-BaseField<double>.set_showMixedValue
	|-BaseField<int>.set_showMixedValue
	|-BaseField<long>.set_showMixedValue
	|-BaseField<object>.set_showMixedValue
	|-BaseField<float>.set_showMixedValue
	|-BaseField<uint>.set_showMixedValue
	|-BaseField<ulong>.set_showMixedValue
	|-BaseField<Vector2>.set_showMixedValue
	|-BaseField<Vector2Int>.set_showMixedValue
	|
	|-RVA: 0x13E3F80 Offset: 0x13E2980 VA: 0x1813E3F80
	|-BaseField<Bounds>.set_showMixedValue
	|-BaseField<BoundsInt>.set_showMixedValue
	|
	|-RVA: 0x13E3EC0 Offset: 0x13E28C0 VA: 0x1813E3EC0
	|-BaseField<Hash128>.set_showMixedValue
	|-BaseField<Rect>.set_showMixedValue
	|-BaseField<RectInt>.set_showMixedValue
	|-BaseField<Vector3>.set_showMixedValue
	|-BaseField<Vector3Int>.set_showMixedValue
	|-BaseField<Vector4>.set_showMixedValue
	|
	|-RVA: 0x1411D20 Offset: 0x1410720 VA: 0x181411D20
	|-BaseField<__Il2CppFullySharedGenericType>.set_showMixedValue
	*/

	// RVA: -1 Offset: -1 Slot: 113
	internal virtual bool get_canSwitchToMixedValue() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0
	|-BaseField<bool>.get_canSwitchToMixedValue
	|-BaseField<Bounds>.get_canSwitchToMixedValue
	|-BaseField<BoundsInt>.get_canSwitchToMixedValue
	|-BaseField<double>.get_canSwitchToMixedValue
	|-BaseField<Hash128>.get_canSwitchToMixedValue
	|-BaseField<int>.get_canSwitchToMixedValue
	|-BaseField<long>.get_canSwitchToMixedValue
	|-BaseField<object>.get_canSwitchToMixedValue
	|-BaseField<Rect>.get_canSwitchToMixedValue
	|-BaseField<RectInt>.get_canSwitchToMixedValue
	|-BaseField<float>.get_canSwitchToMixedValue
	|-BaseField<uint>.get_canSwitchToMixedValue
	|-BaseField<ulong>.get_canSwitchToMixedValue
	|-BaseField<Vector2>.get_canSwitchToMixedValue
	|-BaseField<Vector2Int>.get_canSwitchToMixedValue
	|-BaseField<Vector3>.get_canSwitchToMixedValue
	|-BaseField<Vector3Int>.get_canSwitchToMixedValue
	|-BaseField<Vector4>.get_canSwitchToMixedValue
	|-BaseField<__Il2CppFullySharedGenericType>.get_canSwitchToMixedValue
	*/

	// RVA: -1 Offset: -1
	protected Label get_mixedValueLabel() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13E29F0 Offset: 0x13E13F0 VA: 0x1813E29F0
	|-BaseField<bool>.get_mixedValueLabel
	|
	|-RVA: 0x13E2860 Offset: 0x13E1260 VA: 0x1813E2860
	|-BaseField<Bounds>.get_mixedValueLabel
	|
	|-RVA: 0x13E3350 Offset: 0x13E1D50 VA: 0x1813E3350
	|-BaseField<BoundsInt>.get_mixedValueLabel
	|
	|-RVA: 0x13E2EA0 Offset: 0x13E18A0 VA: 0x1813E2EA0
	|-BaseField<double>.get_mixedValueLabel
	|
	|-RVA: 0x13E2B80 Offset: 0x13E1580 VA: 0x1813E2B80
	|-BaseField<Hash128>.get_mixedValueLabel
	|
	|-RVA: 0x13E26D0 Offset: 0x13E10D0 VA: 0x1813E26D0
	|-BaseField<int>.get_mixedValueLabel
	|
	|-RVA: 0x13E2D10 Offset: 0x13E1710 VA: 0x1813E2D10
	|-BaseField<long>.get_mixedValueLabel
	|
	|-RVA: 0x13E31C0 Offset: 0x13E1BC0 VA: 0x1813E31C0
	|-BaseField<object>.get_mixedValueLabel
	|
	|-RVA: 0x13E2540 Offset: 0x13E0F40 VA: 0x1813E2540
	|-BaseField<Rect>.get_mixedValueLabel
	|
	|-RVA: 0x13E3030 Offset: 0x13E1A30 VA: 0x1813E3030
	|-BaseField<RectInt>.get_mixedValueLabel
	|
	|-RVA: 0x1410C50 Offset: 0x140F650 VA: 0x181410C50
	|-BaseField<float>.get_mixedValueLabel
	|
	|-RVA: 0x1411030 Offset: 0x140FA30 VA: 0x181411030
	|-BaseField<uint>.get_mixedValueLabel
	|
	|-RVA: 0x1411350 Offset: 0x140FD50 VA: 0x181411350
	|-BaseField<ulong>.get_mixedValueLabel
	|
	|-RVA: 0x14107A0 Offset: 0x140F1A0 VA: 0x1814107A0
	|-BaseField<Vector2>.get_mixedValueLabel
	|
	|-RVA: 0x1410930 Offset: 0x140F330 VA: 0x181410930
	|-BaseField<Vector2Int>.get_mixedValueLabel
	|
	|-RVA: 0x14114E0 Offset: 0x140FEE0 VA: 0x1814114E0
	|-BaseField<Vector3>.get_mixedValueLabel
	|
	|-RVA: 0x1410AC0 Offset: 0x140F4C0 VA: 0x181410AC0
	|-BaseField<Vector3Int>.get_mixedValueLabel
	|
	|-RVA: 0x14111C0 Offset: 0x140FBC0 VA: 0x1814111C0
	|-BaseField<Vector4>.get_mixedValueLabel
	|
	|-RVA: 0x1410DE0 Offset: 0x140F7E0 VA: 0x181410DE0
	|-BaseField<__Il2CppFullySharedGenericType>.get_mixedValueLabel
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 105
	private Action UnityEngine.UIElements.IEditableElement.get_editingStarted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13D8030 Offset: 0x13D6A30 VA: 0x1813D8030
	|-BaseField<bool>.UnityEngine.UIElements.IEditableElement.get_editingStarted
	|-BaseField<double>.UnityEngine.UIElements.IEditableElement.get_editingStarted
	|-BaseField<int>.UnityEngine.UIElements.IEditableElement.get_editingStarted
	|-BaseField<long>.UnityEngine.UIElements.IEditableElement.get_editingStarted
	|-BaseField<object>.UnityEngine.UIElements.IEditableElement.get_editingStarted
	|-BaseField<float>.UnityEngine.UIElements.IEditableElement.get_editingStarted
	|-BaseField<uint>.UnityEngine.UIElements.IEditableElement.get_editingStarted
	|-BaseField<ulong>.UnityEngine.UIElements.IEditableElement.get_editingStarted
	|-BaseField<Vector2>.UnityEngine.UIElements.IEditableElement.get_editingStarted
	|-BaseField<Vector2Int>.UnityEngine.UIElements.IEditableElement.get_editingStarted
	|
	|-RVA: 0x13D8020 Offset: 0x13D6A20 VA: 0x1813D8020
	|-BaseField<Bounds>.UnityEngine.UIElements.IEditableElement.get_editingStarted
	|-BaseField<BoundsInt>.UnityEngine.UIElements.IEditableElement.get_editingStarted
	|
	|-RVA: 0x13D8010 Offset: 0x13D6A10 VA: 0x1813D8010
	|-BaseField<Hash128>.UnityEngine.UIElements.IEditableElement.get_editingStarted
	|-BaseField<Rect>.UnityEngine.UIElements.IEditableElement.get_editingStarted
	|-BaseField<RectInt>.UnityEngine.UIElements.IEditableElement.get_editingStarted
	|-BaseField<Vector3>.UnityEngine.UIElements.IEditableElement.get_editingStarted
	|-BaseField<Vector3Int>.UnityEngine.UIElements.IEditableElement.get_editingStarted
	|-BaseField<Vector4>.UnityEngine.UIElements.IEditableElement.get_editingStarted
	|
	|-RVA: 0x1407470 Offset: 0x1405E70 VA: 0x181407470
	|-BaseField<__Il2CppFullySharedGenericType>.UnityEngine.UIElements.IEditableElement.get_editingStarted
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 106
	private Action UnityEngine.UIElements.IEditableElement.get_editingEnded() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13D8010 Offset: 0x13D6A10 VA: 0x1813D8010
	|-BaseField<bool>.UnityEngine.UIElements.IEditableElement.get_editingEnded
	|-BaseField<double>.UnityEngine.UIElements.IEditableElement.get_editingEnded
	|-BaseField<int>.UnityEngine.UIElements.IEditableElement.get_editingEnded
	|-BaseField<long>.UnityEngine.UIElements.IEditableElement.get_editingEnded
	|-BaseField<object>.UnityEngine.UIElements.IEditableElement.get_editingEnded
	|-BaseField<float>.UnityEngine.UIElements.IEditableElement.get_editingEnded
	|-BaseField<uint>.UnityEngine.UIElements.IEditableElement.get_editingEnded
	|-BaseField<ulong>.UnityEngine.UIElements.IEditableElement.get_editingEnded
	|-BaseField<Vector2>.UnityEngine.UIElements.IEditableElement.get_editingEnded
	|-BaseField<Vector2Int>.UnityEngine.UIElements.IEditableElement.get_editingEnded
	|
	|-RVA: 0x1243710 Offset: 0x1242110 VA: 0x181243710
	|-BaseField<Bounds>.UnityEngine.UIElements.IEditableElement.get_editingEnded
	|-BaseField<BoundsInt>.UnityEngine.UIElements.IEditableElement.get_editingEnded
	|
	|-RVA: 0x13D8020 Offset: 0x13D6A20 VA: 0x1813D8020
	|-BaseField<Hash128>.UnityEngine.UIElements.IEditableElement.get_editingEnded
	|-BaseField<Rect>.UnityEngine.UIElements.IEditableElement.get_editingEnded
	|-BaseField<RectInt>.UnityEngine.UIElements.IEditableElement.get_editingEnded
	|-BaseField<Vector3>.UnityEngine.UIElements.IEditableElement.get_editingEnded
	|-BaseField<Vector3Int>.UnityEngine.UIElements.IEditableElement.get_editingEnded
	|-BaseField<Vector4>.UnityEngine.UIElements.IEditableElement.get_editingEnded
	|
	|-RVA: 0x1407440 Offset: 0x1405E40 VA: 0x181407440
	|-BaseField<__Il2CppFullySharedGenericType>.UnityEngine.UIElements.IEditableElement.get_editingEnded
	*/

	// RVA: -1 Offset: -1
	internal void .ctor(string label) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13E1F30 Offset: 0x13E0930 VA: 0x1813E1F30
	|-BaseField<bool>..ctor
	|
	|-RVA: 0x13E11F0 Offset: 0x13DFBF0 VA: 0x1813E11F0
	|-BaseField<Bounds>..ctor
	|
	|-RVA: 0x13E02D0 Offset: 0x13DECD0 VA: 0x1813E02D0
	|-BaseField<BoundsInt>..ctor
	|
	|-RVA: 0x13DF870 Offset: 0x13DE270 VA: 0x1813DF870
	|-BaseField<double>..ctor
	|
	|-RVA: 0x13E1C50 Offset: 0x13E0650 VA: 0x1813E1C50
	|-BaseField<Hash128>..ctor
	|
	|-RVA: 0x13DFB50 Offset: 0x13DE550 VA: 0x1813DFB50
	|-BaseField<int>..ctor
	|
	|-RVA: 0x13DF3D0 Offset: 0x13DDDD0 VA: 0x1813DF3D0
	|-BaseField<long>..ctor
	|
	|-RVA: 0x13E14D0 Offset: 0x13DFED0 VA: 0x1813E14D0
	|-BaseField<object>..ctor
	|
	|-RVA: 0x13DFFF0 Offset: 0x13DE9F0 VA: 0x1813DFFF0
	|-BaseField<Rect>..ctor
	|
	|-RVA: 0x13E1970 Offset: 0x13E0370 VA: 0x1813E1970
	|-BaseField<RectInt>..ctor
	|
	|-RVA: 0x140F760 Offset: 0x140E160 VA: 0x18140F760
	|-BaseField<float>..ctor
	|
	|-RVA: 0x1410340 Offset: 0x140ED40 VA: 0x181410340
	|-BaseField<uint>..ctor
	|
	|-RVA: 0x140EB40 Offset: 0x140D540 VA: 0x18140EB40
	|-BaseField<ulong>..ctor
	|
	|-RVA: 0x1410060 Offset: 0x140EA60 VA: 0x181410060
	|-BaseField<Vector2>..ctor
	|
	|-RVA: 0x140EFE0 Offset: 0x140D9E0 VA: 0x18140EFE0
	|-BaseField<Vector2Int>..ctor
	|
	|-RVA: 0x140FD80 Offset: 0x140E780 VA: 0x18140FD80
	|-BaseField<Vector3>..ctor
	|
	|-RVA: 0x140F480 Offset: 0x140DE80 VA: 0x18140F480
	|-BaseField<Vector3Int>..ctor
	|
	|-RVA: 0x140E480 Offset: 0x140CE80 VA: 0x18140E480
	|-BaseField<Vector4>..ctor
	|
	|-RVA: 0x140FA40 Offset: 0x140E440 VA: 0x18140FA40
	|-BaseField<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	protected void .ctor(string label, VisualElement visualInput) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13E05B0 Offset: 0x13DEFB0 VA: 0x1813E05B0
	|-BaseField<bool>..ctor
	|
	|-RVA: 0x13E0770 Offset: 0x13DF170 VA: 0x1813E0770
	|-BaseField<Bounds>..ctor
	|
	|-RVA: 0x13DF6B0 Offset: 0x13DE0B0 VA: 0x1813DF6B0
	|-BaseField<BoundsInt>..ctor
	|
	|-RVA: 0x13E0930 Offset: 0x13DF330 VA: 0x1813E0930
	|-BaseField<double>..ctor
	|
	|-RVA: 0x13E17B0 Offset: 0x13E01B0 VA: 0x1813E17B0
	|-BaseField<Hash128>..ctor
	|
	|-RVA: 0x13E0CB0 Offset: 0x13DF6B0 VA: 0x1813E0CB0
	|-BaseField<int>..ctor
	|
	|-RVA: 0x13DFE30 Offset: 0x13DE830 VA: 0x1813DFE30
	|-BaseField<long>..ctor
	|
	|-RVA: 0x13E0E70 Offset: 0x13DF870 VA: 0x1813E0E70
	|-BaseField<object>..ctor
	|
	|-RVA: 0x13E0AF0 Offset: 0x13DF4F0 VA: 0x1813E0AF0
	|-BaseField<Rect>..ctor
	|
	|-RVA: 0x13E1030 Offset: 0x13DFA30 VA: 0x1813E1030
	|-BaseField<RectInt>..ctor
	|
	|-RVA: 0x140EE20 Offset: 0x140D820 VA: 0x18140EE20
	|-BaseField<float>..ctor
	|
	|-RVA: 0x140DD80 Offset: 0x140C780 VA: 0x18140DD80
	|-BaseField<uint>..ctor
	|
	|-RVA: 0x140E920 Offset: 0x140D320 VA: 0x18140E920
	|-BaseField<ulong>..ctor
	|
	|-RVA: 0x140E100 Offset: 0x140CB00 VA: 0x18140E100
	|-BaseField<Vector2>..ctor
	|
	|-RVA: 0x140F2C0 Offset: 0x140DCC0 VA: 0x18140F2C0
	|-BaseField<Vector2Int>..ctor
	|
	|-RVA: 0x140E2C0 Offset: 0x140CCC0 VA: 0x18140E2C0
	|-BaseField<Vector3>..ctor
	|
	|-RVA: 0x140DF40 Offset: 0x140C940 VA: 0x18140DF40
	|-BaseField<Vector3Int>..ctor
	|
	|-RVA: 0x140E760 Offset: 0x140D160 VA: 0x18140E760
	|-BaseField<Vector4>..ctor
	|
	|-RVA: 0x140EAE0 Offset: 0x140D4E0 VA: 0x18140EAE0
	|-BaseField<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 114
	internal virtual bool EqualsCurrentValue(TValueType value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13D0B90 Offset: 0x13CF590 VA: 0x1813D0B90
	|-BaseField<bool>.EqualsCurrentValue
	|
	|-RVA: 0x13D0940 Offset: 0x13CF340 VA: 0x1813D0940
	|-BaseField<Bounds>.EqualsCurrentValue
	|
	|-RVA: 0x13D0830 Offset: 0x13CF230 VA: 0x1813D0830
	|-BaseField<BoundsInt>.EqualsCurrentValue
	|
	|-RVA: 0x13D0BF0 Offset: 0x13CF5F0 VA: 0x1813D0BF0
	|-BaseField<double>.EqualsCurrentValue
	|
	|-RVA: 0x13D08C0 Offset: 0x13CF2C0 VA: 0x1813D08C0
	|-BaseField<Hash128>.EqualsCurrentValue
	|
	|-RVA: 0x13D07D0 Offset: 0x13CF1D0 VA: 0x1813D07D0
	|-BaseField<int>.EqualsCurrentValue
	|
	|-RVA: 0x13D0B30 Offset: 0x13CF530 VA: 0x1813D0B30
	|-BaseField<long>.EqualsCurrentValue
	|
	|-RVA: 0x13D09D0 Offset: 0x13CF3D0 VA: 0x1813D09D0
	|-BaseField<object>.EqualsCurrentValue
	|
	|-RVA: 0x13D0AB0 Offset: 0x13CF4B0 VA: 0x1813D0AB0
	|-BaseField<Rect>.EqualsCurrentValue
	|
	|-RVA: 0x13D0A30 Offset: 0x13CF430 VA: 0x1813D0A30
	|-BaseField<RectInt>.EqualsCurrentValue
	|
	|-RVA: 0x1400530 Offset: 0x13FEF30 VA: 0x181400530
	|-BaseField<float>.EqualsCurrentValue
	|
	|-RVA: 0x1400590 Offset: 0x13FEF90 VA: 0x181400590
	|-BaseField<uint>.EqualsCurrentValue
	|
	|-RVA: 0x14003E0 Offset: 0x13FEDE0 VA: 0x1814003E0
	|-BaseField<ulong>.EqualsCurrentValue
	|
	|-RVA: 0x14005F0 Offset: 0x13FEFF0 VA: 0x1814005F0
	|-BaseField<Vector2>.EqualsCurrentValue
	|
	|-RVA: 0x1400440 Offset: 0x13FEE40 VA: 0x181400440
	|-BaseField<Vector2Int>.EqualsCurrentValue
	|
	|-RVA: 0x1400670 Offset: 0x13FF070 VA: 0x181400670
	|-BaseField<Vector3>.EqualsCurrentValue
	|
	|-RVA: 0x14004A0 Offset: 0x13FEEA0 VA: 0x1814004A0
	|-BaseField<Vector3Int>.EqualsCurrentValue
	|
	|-RVA: 0x1400880 Offset: 0x13FF280 VA: 0x181400880
	|-BaseField<Vector4>.EqualsCurrentValue
	|
	|-RVA: 0x1400700 Offset: 0x13FF100 VA: 0x181400700
	|-BaseField<__Il2CppFullySharedGenericType>.EqualsCurrentValue
	*/

	// RVA: -1 Offset: -1
	private void OnAttachToPanel(AttachToPanelEvent e) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13D22D0 Offset: 0x13D0CD0 VA: 0x1813D22D0
	|-BaseField<bool>.OnAttachToPanel
	|
	|-RVA: 0x13D1070 Offset: 0x13CFA70 VA: 0x1813D1070
	|-BaseField<Bounds>.OnAttachToPanel
	|
	|-RVA: 0x13D1D90 Offset: 0x13D0790 VA: 0x1813D1D90
	|-BaseField<BoundsInt>.OnAttachToPanel
	|
	|-RVA: 0x13D1AF0 Offset: 0x13D04F0 VA: 0x1813D1AF0
	|-BaseField<double>.OnAttachToPanel
	|
	|-RVA: 0x13D2570 Offset: 0x13D0F70 VA: 0x1813D2570
	|-BaseField<Hash128>.OnAttachToPanel
	|
	|-RVA: 0x13D1850 Offset: 0x13D0250 VA: 0x1813D1850
	|-BaseField<int>.OnAttachToPanel
	|
	|-RVA: 0x13D1310 Offset: 0x13CFD10 VA: 0x1813D1310
	|-BaseField<long>.OnAttachToPanel
	|
	|-RVA: 0x13D15B0 Offset: 0x13CFFB0 VA: 0x1813D15B0
	|-BaseField<object>.OnAttachToPanel
	|
	|-RVA: 0x13D0DD0 Offset: 0x13CF7D0 VA: 0x1813D0DD0
	|-BaseField<Rect>.OnAttachToPanel
	|
	|-RVA: 0x13D2030 Offset: 0x13D0A30 VA: 0x1813D2030
	|-BaseField<RectInt>.OnAttachToPanel
	|
	|-RVA: 0x1400D20 Offset: 0x13FF720 VA: 0x181400D20
	|-BaseField<float>.OnAttachToPanel
	|
	|-RVA: 0x14017A0 Offset: 0x14001A0 VA: 0x1814017A0
	|-BaseField<uint>.OnAttachToPanel
	|
	|-RVA: 0x1401500 Offset: 0x13FFF00 VA: 0x181401500
	|-BaseField<ulong>.OnAttachToPanel
	|
	|-RVA: 0x1401260 Offset: 0x13FFC60 VA: 0x181401260
	|-BaseField<Vector2>.OnAttachToPanel
	|
	|-RVA: 0x1401F80 Offset: 0x1400980 VA: 0x181401F80
	|-BaseField<Vector2Int>.OnAttachToPanel
	|
	|-RVA: 0x1401A40 Offset: 0x1400440 VA: 0x181401A40
	|-BaseField<Vector3>.OnAttachToPanel
	|
	|-RVA: 0x1401CE0 Offset: 0x14006E0 VA: 0x181401CE0
	|-BaseField<Vector3Int>.OnAttachToPanel
	|
	|-RVA: 0x1400FC0 Offset: 0x13FF9C0 VA: 0x181400FC0
	|-BaseField<Vector4>.OnAttachToPanel
	|
	|-RVA: 0x14009B0 Offset: 0x13FF3B0 VA: 0x1814009B0
	|-BaseField<__Il2CppFullySharedGenericType>.OnAttachToPanel
	*/

	// RVA: -1 Offset: -1
	private void OnDetachFromPanel(DetachFromPanelEvent e) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13D56D0 Offset: 0x13D40D0 VA: 0x1813D56D0
	|-BaseField<bool>.OnDetachFromPanel
	|-BaseField<double>.OnDetachFromPanel
	|-BaseField<int>.OnDetachFromPanel
	|-BaseField<long>.OnDetachFromPanel
	|-BaseField<object>.OnDetachFromPanel
	|-BaseField<float>.OnDetachFromPanel
	|-BaseField<uint>.OnDetachFromPanel
	|-BaseField<ulong>.OnDetachFromPanel
	|-BaseField<Vector2>.OnDetachFromPanel
	|-BaseField<Vector2Int>.OnDetachFromPanel
	|
	|-RVA: 0x13D5650 Offset: 0x13D4050 VA: 0x1813D5650
	|-BaseField<Bounds>.OnDetachFromPanel
	|-BaseField<BoundsInt>.OnDetachFromPanel
	|
	|-RVA: 0x13D5690 Offset: 0x13D4090 VA: 0x1813D5690
	|-BaseField<Hash128>.OnDetachFromPanel
	|-BaseField<Rect>.OnDetachFromPanel
	|-BaseField<RectInt>.OnDetachFromPanel
	|-BaseField<Vector3>.OnDetachFromPanel
	|-BaseField<Vector3Int>.OnDetachFromPanel
	|-BaseField<Vector4>.OnDetachFromPanel
	|
	|-RVA: 0x1404CF0 Offset: 0x14036F0 VA: 0x181404CF0
	|-BaseField<__Il2CppFullySharedGenericType>.OnDetachFromPanel
	*/

	// RVA: -1 Offset: -1 Slot: 115
	internal virtual void RegisterEditingCallbacks() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13D73C0 Offset: 0x13D5DC0 VA: 0x1813D73C0
	|-BaseField<bool>.RegisterEditingCallbacks
	|
	|-RVA: 0x13D72C0 Offset: 0x13D5CC0 VA: 0x1813D72C0
	|-BaseField<Bounds>.RegisterEditingCallbacks
	|
	|-RVA: 0x13D76C0 Offset: 0x13D60C0 VA: 0x1813D76C0
	|-BaseField<BoundsInt>.RegisterEditingCallbacks
	|
	|-RVA: 0x13D70C0 Offset: 0x13D5AC0 VA: 0x1813D70C0
	|-BaseField<double>.RegisterEditingCallbacks
	|
	|-RVA: 0x13D6FC0 Offset: 0x13D59C0 VA: 0x1813D6FC0
	|-BaseField<Hash128>.RegisterEditingCallbacks
	|
	|-RVA: 0x13D75C0 Offset: 0x13D5FC0 VA: 0x1813D75C0
	|-BaseField<int>.RegisterEditingCallbacks
	|
	|-RVA: 0x13D6DC0 Offset: 0x13D57C0 VA: 0x1813D6DC0
	|-BaseField<long>.RegisterEditingCallbacks
	|
	|-RVA: 0x13D74C0 Offset: 0x13D5EC0 VA: 0x1813D74C0
	|-BaseField<object>.RegisterEditingCallbacks
	|
	|-RVA: 0x13D71C0 Offset: 0x13D5BC0 VA: 0x1813D71C0
	|-BaseField<Rect>.RegisterEditingCallbacks
	|
	|-RVA: 0x13D6EC0 Offset: 0x13D58C0 VA: 0x1813D6EC0
	|-BaseField<RectInt>.RegisterEditingCallbacks
	|
	|-RVA: 0x14066D0 Offset: 0x14050D0 VA: 0x1814066D0
	|-BaseField<float>.RegisterEditingCallbacks
	|
	|-RVA: 0x14064D0 Offset: 0x1404ED0 VA: 0x1814064D0
	|-BaseField<uint>.RegisterEditingCallbacks
	|
	|-RVA: 0x1406BD0 Offset: 0x14055D0 VA: 0x181406BD0
	|-BaseField<ulong>.RegisterEditingCallbacks
	|
	|-RVA: 0x14068D0 Offset: 0x14052D0 VA: 0x1814068D0
	|-BaseField<Vector2>.RegisterEditingCallbacks
	|
	|-RVA: 0x14069D0 Offset: 0x14053D0 VA: 0x1814069D0
	|-BaseField<Vector2Int>.RegisterEditingCallbacks
	|
	|-RVA: 0x14063D0 Offset: 0x1404DD0 VA: 0x1814063D0
	|-BaseField<Vector3>.RegisterEditingCallbacks
	|
	|-RVA: 0x14067D0 Offset: 0x14051D0 VA: 0x1814067D0
	|-BaseField<Vector3Int>.RegisterEditingCallbacks
	|
	|-RVA: 0x1406AD0 Offset: 0x14054D0 VA: 0x181406AD0
	|-BaseField<Vector4>.RegisterEditingCallbacks
	|
	|-RVA: 0x14065D0 Offset: 0x1404FD0 VA: 0x1814065D0
	|-BaseField<__Il2CppFullySharedGenericType>.RegisterEditingCallbacks
	*/

	// RVA: -1 Offset: -1 Slot: 116
	internal virtual void UnregisterEditingCallbacks() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13D8940 Offset: 0x13D7340 VA: 0x1813D8940
	|-BaseField<bool>.UnregisterEditingCallbacks
	|
	|-RVA: 0x13D8140 Offset: 0x13D6B40 VA: 0x1813D8140
	|-BaseField<Bounds>.UnregisterEditingCallbacks
	|
	|-RVA: 0x13D8040 Offset: 0x13D6A40 VA: 0x1813D8040
	|-BaseField<BoundsInt>.UnregisterEditingCallbacks
	|
	|-RVA: 0x13D8740 Offset: 0x13D7140 VA: 0x1813D8740
	|-BaseField<double>.UnregisterEditingCallbacks
	|
	|-RVA: 0x13D8240 Offset: 0x13D6C40 VA: 0x1813D8240
	|-BaseField<Hash128>.UnregisterEditingCallbacks
	|
	|-RVA: 0x13D8340 Offset: 0x13D6D40 VA: 0x1813D8340
	|-BaseField<int>.UnregisterEditingCallbacks
	|
	|-RVA: 0x13D8640 Offset: 0x13D7040 VA: 0x1813D8640
	|-BaseField<long>.UnregisterEditingCallbacks
	|
	|-RVA: 0x13D8840 Offset: 0x13D7240 VA: 0x1813D8840
	|-BaseField<object>.UnregisterEditingCallbacks
	|
	|-RVA: 0x13D8540 Offset: 0x13D6F40 VA: 0x1813D8540
	|-BaseField<Rect>.UnregisterEditingCallbacks
	|
	|-RVA: 0x13D8440 Offset: 0x13D6E40 VA: 0x1813D8440
	|-BaseField<RectInt>.UnregisterEditingCallbacks
	|
	|-RVA: 0x14074A0 Offset: 0x1405EA0 VA: 0x1814074A0
	|-BaseField<float>.UnregisterEditingCallbacks
	|
	|-RVA: 0x14079A0 Offset: 0x14063A0 VA: 0x1814079A0
	|-BaseField<uint>.UnregisterEditingCallbacks
	|
	|-RVA: 0x1407CA0 Offset: 0x14066A0 VA: 0x181407CA0
	|-BaseField<ulong>.UnregisterEditingCallbacks
	|
	|-RVA: 0x14075A0 Offset: 0x1405FA0 VA: 0x1814075A0
	|-BaseField<Vector2>.UnregisterEditingCallbacks
	|
	|-RVA: 0x14078A0 Offset: 0x14062A0 VA: 0x1814078A0
	|-BaseField<Vector2Int>.UnregisterEditingCallbacks
	|
	|-RVA: 0x1407BA0 Offset: 0x14065A0 VA: 0x181407BA0
	|-BaseField<Vector3>.UnregisterEditingCallbacks
	|
	|-RVA: 0x14076A0 Offset: 0x14060A0 VA: 0x1814076A0
	|-BaseField<Vector3Int>.UnregisterEditingCallbacks
	|
	|-RVA: 0x14077A0 Offset: 0x14061A0 VA: 0x1814077A0
	|-BaseField<Vector4>.UnregisterEditingCallbacks
	|
	|-RVA: 0x1407AA0 Offset: 0x14064A0 VA: 0x181407AA0
	|-BaseField<__Il2CppFullySharedGenericType>.UnregisterEditingCallbacks
	*/

	// RVA: -1 Offset: -1
	internal void StartEditing(EventBase e) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13D7E90 Offset: 0x13D6890 VA: 0x1813D7E90
	|-BaseField<bool>.StartEditing
	|
	|-RVA: 0x13D7D70 Offset: 0x13D6770 VA: 0x1813D7D70
	|-BaseField<Bounds>.StartEditing
	|
	|-RVA: 0x13D7EF0 Offset: 0x13D68F0 VA: 0x1813D7EF0
	|-BaseField<BoundsInt>.StartEditing
	|
	|-RVA: 0x13D7C50 Offset: 0x13D6650 VA: 0x1813D7C50
	|-BaseField<double>.StartEditing
	|
	|-RVA: 0x13D7E30 Offset: 0x13D6830 VA: 0x1813D7E30
	|-BaseField<Hash128>.StartEditing
	|
	|-RVA: 0x13D7DD0 Offset: 0x13D67D0 VA: 0x1813D7DD0
	|-BaseField<int>.StartEditing
	|
	|-RVA: 0x13D7FB0 Offset: 0x13D69B0 VA: 0x1813D7FB0
	|-BaseField<long>.StartEditing
	|
	|-RVA: 0x13D7CB0 Offset: 0x13D66B0 VA: 0x1813D7CB0
	|-BaseField<object>.StartEditing
	|
	|-RVA: 0x13D7F50 Offset: 0x13D6950 VA: 0x1813D7F50
	|-BaseField<Rect>.StartEditing
	|
	|-RVA: 0x13D7D10 Offset: 0x13D6710 VA: 0x1813D7D10
	|-BaseField<RectInt>.StartEditing
	|
	|-RVA: 0x1407140 Offset: 0x1405B40 VA: 0x181407140
	|-BaseField<float>.StartEditing
	|
	|-RVA: 0x1407260 Offset: 0x1405C60 VA: 0x181407260
	|-BaseField<uint>.StartEditing
	|
	|-RVA: 0x14070E0 Offset: 0x1405AE0 VA: 0x1814070E0
	|-BaseField<ulong>.StartEditing
	|
	|-RVA: 0x14071A0 Offset: 0x1405BA0 VA: 0x1814071A0
	|-BaseField<Vector2>.StartEditing
	|
	|-RVA: 0x1407380 Offset: 0x1405D80 VA: 0x181407380
	|-BaseField<Vector2Int>.StartEditing
	|
	|-RVA: 0x1407200 Offset: 0x1405C00 VA: 0x181407200
	|-BaseField<Vector3>.StartEditing
	|
	|-RVA: 0x14072C0 Offset: 0x1405CC0 VA: 0x1814072C0
	|-BaseField<Vector3Int>.StartEditing
	|
	|-RVA: 0x1407320 Offset: 0x1405D20 VA: 0x181407320
	|-BaseField<Vector4>.StartEditing
	|
	|-RVA: 0x14073E0 Offset: 0x1405DE0 VA: 0x1814073E0
	|-BaseField<__Il2CppFullySharedGenericType>.StartEditing
	*/

	// RVA: -1 Offset: -1
	internal void EndEditing(EventBase e) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13D06F0 Offset: 0x13CF0F0 VA: 0x1813D06F0
	|-BaseField<bool>.EndEditing
	|
	|-RVA: 0x13D05A0 Offset: 0x13CEFA0 VA: 0x1813D05A0
	|-BaseField<Bounds>.EndEditing
	|
	|-RVA: 0x13D0370 Offset: 0x13CED70 VA: 0x1813D0370
	|-BaseField<BoundsInt>.EndEditing
	|
	|-RVA: 0x13D03E0 Offset: 0x13CEDE0 VA: 0x1813D03E0
	|-BaseField<double>.EndEditing
	|
	|-RVA: 0x13D0680 Offset: 0x13CF080 VA: 0x1813D0680
	|-BaseField<Hash128>.EndEditing
	|
	|-RVA: 0x13D0450 Offset: 0x13CEE50 VA: 0x1813D0450
	|-BaseField<int>.EndEditing
	|
	|-RVA: 0x13D0530 Offset: 0x13CEF30 VA: 0x1813D0530
	|-BaseField<long>.EndEditing
	|
	|-RVA: 0x13D0760 Offset: 0x13CF160 VA: 0x1813D0760
	|-BaseField<object>.EndEditing
	|
	|-RVA: 0x13D04C0 Offset: 0x13CEEC0 VA: 0x1813D04C0
	|-BaseField<Rect>.EndEditing
	|
	|-RVA: 0x13D0610 Offset: 0x13CF010 VA: 0x1813D0610
	|-BaseField<RectInt>.EndEditing
	|
	|-RVA: 0x14000D0 Offset: 0x13FEAD0 VA: 0x1814000D0
	|-BaseField<float>.EndEditing
	|
	|-RVA: 0x1400140 Offset: 0x13FEB40 VA: 0x181400140
	|-BaseField<uint>.EndEditing
	|
	|-RVA: 0x13FFFF0 Offset: 0x13FE9F0 VA: 0x1813FFFF0
	|-BaseField<ulong>.EndEditing
	|
	|-RVA: 0x14001B0 Offset: 0x13FEBB0 VA: 0x1814001B0
	|-BaseField<Vector2>.EndEditing
	|
	|-RVA: 0x1400300 Offset: 0x13FED00 VA: 0x181400300
	|-BaseField<Vector2Int>.EndEditing
	|
	|-RVA: 0x1400290 Offset: 0x13FEC90 VA: 0x181400290
	|-BaseField<Vector3>.EndEditing
	|
	|-RVA: 0x1400220 Offset: 0x13FEC20 VA: 0x181400220
	|-BaseField<Vector3Int>.EndEditing
	|
	|-RVA: 0x1400060 Offset: 0x13FEA60 VA: 0x181400060
	|-BaseField<Vector4>.EndEditing
	|
	|-RVA: 0x1400370 Offset: 0x13FED70 VA: 0x181400370
	|-BaseField<__Il2CppFullySharedGenericType>.EndEditing
	*/

	// RVA: -1 Offset: -1
	private void OnCustomStyleResolved(CustomStyleResolvedEvent evt) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13D35F0 Offset: 0x13D1FF0 VA: 0x1813D35F0
	|-BaseField<bool>.OnCustomStyleResolved
	|
	|-RVA: 0x13D4870 Offset: 0x13D3270 VA: 0x1813D4870
	|-BaseField<Bounds>.OnCustomStyleResolved
	|
	|-RVA: 0x13D4D10 Offset: 0x13D3710 VA: 0x1813D4D10
	|-BaseField<BoundsInt>.OnCustomStyleResolved
	|
	|-RVA: 0x13D43D0 Offset: 0x13D2DD0 VA: 0x1813D43D0
	|-BaseField<double>.OnCustomStyleResolved
	|
	|-RVA: 0x13D51B0 Offset: 0x13D3BB0 VA: 0x1813D51B0
	|-BaseField<Hash128>.OnCustomStyleResolved
	|
	|-RVA: 0x13D3A90 Offset: 0x13D2490 VA: 0x1813D3A90
	|-BaseField<int>.OnCustomStyleResolved
	|
	|-RVA: 0x13D2810 Offset: 0x13D1210 VA: 0x1813D2810
	|-BaseField<long>.OnCustomStyleResolved
	|
	|-RVA: 0x13D3F30 Offset: 0x13D2930 VA: 0x1813D3F30
	|-BaseField<object>.OnCustomStyleResolved
	|
	|-RVA: 0x13D2CB0 Offset: 0x13D16B0 VA: 0x1813D2CB0
	|-BaseField<Rect>.OnCustomStyleResolved
	|
	|-RVA: 0x13D3150 Offset: 0x13D1B50 VA: 0x1813D3150
	|-BaseField<RectInt>.OnCustomStyleResolved
	|
	|-RVA: 0x14043B0 Offset: 0x1402DB0 VA: 0x1814043B0
	|-BaseField<float>.OnCustomStyleResolved
	|
	|-RVA: 0x1404850 Offset: 0x1403250 VA: 0x181404850
	|-BaseField<uint>.OnCustomStyleResolved
	|
	|-RVA: 0x1402B60 Offset: 0x1401560 VA: 0x181402B60
	|-BaseField<ulong>.OnCustomStyleResolved
	|
	|-RVA: 0x14026C0 Offset: 0x14010C0 VA: 0x1814026C0
	|-BaseField<Vector2>.OnCustomStyleResolved
	|
	|-RVA: 0x1403A70 Offset: 0x1402470 VA: 0x181403A70
	|-BaseField<Vector2Int>.OnCustomStyleResolved
	|
	|-RVA: 0x1402220 Offset: 0x1400C20 VA: 0x181402220
	|-BaseField<Vector3>.OnCustomStyleResolved
	|
	|-RVA: 0x14035D0 Offset: 0x1401FD0 VA: 0x1814035D0
	|-BaseField<Vector3Int>.OnCustomStyleResolved
	|
	|-RVA: 0x1403F10 Offset: 0x1402910 VA: 0x181403F10
	|-BaseField<Vector4>.OnCustomStyleResolved
	|
	|-RVA: 0x1403000 Offset: 0x1401A00 VA: 0x181403000
	|-BaseField<__Il2CppFullySharedGenericType>.OnCustomStyleResolved
	*/

	// RVA: -1 Offset: -1
	private void OnInspectorFieldGeometryChanged(GeometryChangedEvent e) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13D5770 Offset: 0x13D4170 VA: 0x1813D5770
	|-BaseField<bool>.OnInspectorFieldGeometryChanged
	|
	|-RVA: 0x13D5830 Offset: 0x13D4230 VA: 0x1813D5830
	|-BaseField<Bounds>.OnInspectorFieldGeometryChanged
	|
	|-RVA: 0x13D57F0 Offset: 0x13D41F0 VA: 0x1813D57F0
	|-BaseField<BoundsInt>.OnInspectorFieldGeometryChanged
	|
	|-RVA: 0x13D5730 Offset: 0x13D4130 VA: 0x1813D5730
	|-BaseField<double>.OnInspectorFieldGeometryChanged
	|
	|-RVA: 0x13D5750 Offset: 0x13D4150 VA: 0x1813D5750
	|-BaseField<Hash128>.OnInspectorFieldGeometryChanged
	|
	|-RVA: 0x13D5790 Offset: 0x13D4190 VA: 0x1813D5790
	|-BaseField<int>.OnInspectorFieldGeometryChanged
	|
	|-RVA: 0x13D57D0 Offset: 0x13D41D0 VA: 0x1813D57D0
	|-BaseField<long>.OnInspectorFieldGeometryChanged
	|
	|-RVA: 0x13D5710 Offset: 0x13D4110 VA: 0x1813D5710
	|-BaseField<object>.OnInspectorFieldGeometryChanged
	|
	|-RVA: 0x13D5810 Offset: 0x13D4210 VA: 0x1813D5810
	|-BaseField<Rect>.OnInspectorFieldGeometryChanged
	|
	|-RVA: 0x13D57B0 Offset: 0x13D41B0 VA: 0x1813D57B0
	|-BaseField<RectInt>.OnInspectorFieldGeometryChanged
	|
	|-RVA: 0x1404E50 Offset: 0x1403850 VA: 0x181404E50
	|-BaseField<float>.OnInspectorFieldGeometryChanged
	|
	|-RVA: 0x1404D70 Offset: 0x1403770 VA: 0x181404D70
	|-BaseField<uint>.OnInspectorFieldGeometryChanged
	|
	|-RVA: 0x1404E10 Offset: 0x1403810 VA: 0x181404E10
	|-BaseField<ulong>.OnInspectorFieldGeometryChanged
	|
	|-RVA: 0x1404DF0 Offset: 0x14037F0 VA: 0x181404DF0
	|-BaseField<Vector2>.OnInspectorFieldGeometryChanged
	|
	|-RVA: 0x1404DB0 Offset: 0x14037B0 VA: 0x181404DB0
	|-BaseField<Vector2Int>.OnInspectorFieldGeometryChanged
	|
	|-RVA: 0x1404DD0 Offset: 0x14037D0 VA: 0x181404DD0
	|-BaseField<Vector3>.OnInspectorFieldGeometryChanged
	|
	|-RVA: 0x1404D90 Offset: 0x1403790 VA: 0x181404D90
	|-BaseField<Vector3Int>.OnInspectorFieldGeometryChanged
	|
	|-RVA: 0x1404E30 Offset: 0x1403830 VA: 0x181404E30
	|-BaseField<Vector4>.OnInspectorFieldGeometryChanged
	|
	|-RVA: 0x1404E70 Offset: 0x1403870 VA: 0x181404E70
	|-BaseField<__Il2CppFullySharedGenericType>.OnInspectorFieldGeometryChanged
	*/

	// RVA: -1 Offset: -1
	private void AlignLabel() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13CF680 Offset: 0x13CE080 VA: 0x1813CF680
	|-BaseField<bool>.AlignLabel
	|
	|-RVA: 0x13CFF20 Offset: 0x13CE920 VA: 0x1813CFF20
	|-BaseField<Bounds>.AlignLabel
	|
	|-RVA: 0x13CE990 Offset: 0x13CD390 VA: 0x1813CE990
	|-BaseField<BoundsInt>.AlignLabel
	|
	|-RVA: 0x13CF230 Offset: 0x13CDC30 VA: 0x1813CF230
	|-BaseField<double>.AlignLabel
	|
	|-RVA: 0x13CEDE0 Offset: 0x13CD7E0 VA: 0x1813CEDE0
	|-BaseField<Hash128>.AlignLabel
	|
	|-RVA: 0x13CE540 Offset: 0x13CCF40 VA: 0x1813CE540
	|-BaseField<int>.AlignLabel
	|
	|-RVA: 0x13CFAD0 Offset: 0x13CE4D0 VA: 0x1813CFAD0
	|-BaseField<long>.AlignLabel
	|
	|-RVA: 0x13CE0F0 Offset: 0x13CCAF0 VA: 0x1813CE0F0
	|-BaseField<object>.AlignLabel
	|
	|-RVA: 0x13CDCA0 Offset: 0x13CC6A0 VA: 0x1813CDCA0
	|-BaseField<Rect>.AlignLabel
	|
	|-RVA: 0x13CD850 Offset: 0x13CC250 VA: 0x1813CD850
	|-BaseField<RectInt>.AlignLabel
	|
	|-RVA: 0x13FEA60 Offset: 0x13FD460 VA: 0x1813FEA60
	|-BaseField<float>.AlignLabel
	|
	|-RVA: 0x13FE1C0 Offset: 0x13FCBC0 VA: 0x1813FE1C0
	|-BaseField<uint>.AlignLabel
	|
	|-RVA: 0x13FE610 Offset: 0x13FD010 VA: 0x1813FE610
	|-BaseField<ulong>.AlignLabel
	|
	|-RVA: 0x13FF300 Offset: 0x13FDD00 VA: 0x1813FF300
	|-BaseField<Vector2>.AlignLabel
	|
	|-RVA: 0x13FFBA0 Offset: 0x13FE5A0 VA: 0x1813FFBA0
	|-BaseField<Vector2Int>.AlignLabel
	|
	|-RVA: 0x13FF750 Offset: 0x13FE150 VA: 0x1813FF750
	|-BaseField<Vector3>.AlignLabel
	|
	|-RVA: 0x13FEEB0 Offset: 0x13FD8B0 VA: 0x1813FEEB0
	|-BaseField<Vector3Int>.AlignLabel
	|
	|-RVA: 0x13FD7C0 Offset: 0x13FC1C0 VA: 0x1813FD7C0
	|-BaseField<Vector4>.AlignLabel
	|
	|-RVA: 0x13FDC10 Offset: 0x13FC610 VA: 0x1813FDC10
	|-BaseField<__Il2CppFullySharedGenericType>.AlignLabel
	*/

	// RVA: -1 Offset: -1
	internal TValueType ValidatedValue(TValueType value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13D8B80 Offset: 0x13D7580 VA: 0x1813D8B80
	|-BaseField<bool>.ValidatedValue
	|
	|-RVA: 0x13D8A40 Offset: 0x13D7440 VA: 0x1813D8A40
	|-BaseField<Bounds>.ValidatedValue
	|-BaseField<BoundsInt>.ValidatedValue
	|
	|-RVA: 0x13D8BB0 Offset: 0x13D75B0 VA: 0x1813D8BB0
	|-BaseField<double>.ValidatedValue
	|-BaseField<float>.ValidatedValue
	|
	|-RVA: 0x13D8B10 Offset: 0x13D7510 VA: 0x1813D8B10
	|-BaseField<Hash128>.ValidatedValue
	|-BaseField<Rect>.ValidatedValue
	|-BaseField<RectInt>.ValidatedValue
	|-BaseField<Vector4>.ValidatedValue
	|
	|-RVA: 0x13D8BE0 Offset: 0x13D75E0 VA: 0x1813D8BE0
	|-BaseField<int>.ValidatedValue
	|-BaseField<uint>.ValidatedValue
	|
	|-RVA: 0x13D8AE0 Offset: 0x13D74E0 VA: 0x1813D8AE0
	|-BaseField<long>.ValidatedValue
	|-BaseField<object>.ValidatedValue
	|-BaseField<ulong>.ValidatedValue
	|-BaseField<Vector2>.ValidatedValue
	|-BaseField<Vector2Int>.ValidatedValue
	|
	|-RVA: 0x1407DA0 Offset: 0x14067A0 VA: 0x181407DA0
	|-BaseField<Vector3>.ValidatedValue
	|-BaseField<Vector3Int>.ValidatedValue
	|
	|-RVA: 0x1407E30 Offset: 0x1406830 VA: 0x181407E30
	|-BaseField<__Il2CppFullySharedGenericType>.ValidatedValue
	*/

	// RVA: -1 Offset: -1 Slot: 117
	protected virtual void UpdateMixedValueContent() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10859A0 Offset: 0x10843A0 VA: 0x1810859A0
	|-BaseField<bool>.UpdateMixedValueContent
	|-BaseField<Bounds>.UpdateMixedValueContent
	|-BaseField<BoundsInt>.UpdateMixedValueContent
	|-BaseField<double>.UpdateMixedValueContent
	|-BaseField<Hash128>.UpdateMixedValueContent
	|-BaseField<int>.UpdateMixedValueContent
	|-BaseField<long>.UpdateMixedValueContent
	|-BaseField<object>.UpdateMixedValueContent
	|-BaseField<Rect>.UpdateMixedValueContent
	|-BaseField<RectInt>.UpdateMixedValueContent
	|-BaseField<float>.UpdateMixedValueContent
	|-BaseField<uint>.UpdateMixedValueContent
	|-BaseField<ulong>.UpdateMixedValueContent
	|-BaseField<Vector2>.UpdateMixedValueContent
	|-BaseField<Vector2Int>.UpdateMixedValueContent
	|-BaseField<Vector3>.UpdateMixedValueContent
	|-BaseField<Vector3Int>.UpdateMixedValueContent
	|-BaseField<Vector4>.UpdateMixedValueContent
	|-BaseField<__Il2CppFullySharedGenericType>.UpdateMixedValueContent
	*/

	// RVA: -1 Offset: -1 Slot: 118
	public virtual void SetValueWithoutNotify(TValueType newValue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13D7BC0 Offset: 0x13D65C0 VA: 0x1813D7BC0
	|-BaseField<bool>.SetValueWithoutNotify
	|
	|-RVA: 0x13D7850 Offset: 0x13D6250 VA: 0x1813D7850
	|-BaseField<Bounds>.SetValueWithoutNotify
	|-BaseField<BoundsInt>.SetValueWithoutNotify
	|
	|-RVA: 0x13D7B30 Offset: 0x13D6530 VA: 0x1813D7B30
	|-BaseField<double>.SetValueWithoutNotify
	|
	|-RVA: 0x13D7940 Offset: 0x13D6340 VA: 0x1813D7940
	|-BaseField<Hash128>.SetValueWithoutNotify
	|-BaseField<Rect>.SetValueWithoutNotify
	|-BaseField<RectInt>.SetValueWithoutNotify
	|-BaseField<Vector4>.SetValueWithoutNotify
	|
	|-RVA: 0x13D7AA0 Offset: 0x13D64A0 VA: 0x1813D7AA0
	|-BaseField<int>.SetValueWithoutNotify
	|-BaseField<uint>.SetValueWithoutNotify
	|
	|-RVA: 0x13D77C0 Offset: 0x13D61C0 VA: 0x1813D77C0
	|-BaseField<long>.SetValueWithoutNotify
	|-BaseField<ulong>.SetValueWithoutNotify
	|-BaseField<Vector2Int>.SetValueWithoutNotify
	|
	|-RVA: 0x13D7A00 Offset: 0x13D6400 VA: 0x1813D7A00
	|-BaseField<object>.SetValueWithoutNotify
	|
	|-RVA: 0x1406CD0 Offset: 0x14056D0 VA: 0x181406CD0
	|-BaseField<float>.SetValueWithoutNotify
	|
	|-RVA: 0x1406D60 Offset: 0x1405760 VA: 0x181406D60
	|-BaseField<Vector2>.SetValueWithoutNotify
	|
	|-RVA: 0x1407000 Offset: 0x1405A00 VA: 0x181407000
	|-BaseField<Vector3>.SetValueWithoutNotify
	|-BaseField<Vector3Int>.SetValueWithoutNotify
	|
	|-RVA: 0x1406E20 Offset: 0x1405820 VA: 0x181406E20
	|-BaseField<__Il2CppFullySharedGenericType>.SetValueWithoutNotify
	*/

	// RVA: -1 Offset: -1 Slot: 96
	internal override void OnViewDataReady() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13D6700 Offset: 0x13D5100 VA: 0x1813D6700
	|-BaseField<bool>.OnViewDataReady
	|
	|-RVA: 0x13D68F0 Offset: 0x13D52F0 VA: 0x1813D68F0
	|-BaseField<Bounds>.OnViewDataReady
	|
	|-RVA: 0x13D5850 Offset: 0x13D4250 VA: 0x1813D5850
	|-BaseField<BoundsInt>.OnViewDataReady
	|
	|-RVA: 0x13D5F50 Offset: 0x13D4950 VA: 0x1813D5F50
	|-BaseField<double>.OnViewDataReady
	|
	|-RVA: 0x13D5AF0 Offset: 0x13D44F0 VA: 0x1813D5AF0
	|-BaseField<Hash128>.OnViewDataReady
	|
	|-RVA: 0x13D6140 Offset: 0x13D4B40 VA: 0x1813D6140
	|-BaseField<int>.OnViewDataReady
	|
	|-RVA: 0x13D6320 Offset: 0x13D4D20 VA: 0x1813D6320
	|-BaseField<long>.OnViewDataReady
	|
	|-RVA: 0x13D6510 Offset: 0x13D4F10 VA: 0x1813D6510
	|-BaseField<object>.OnViewDataReady
	|
	|-RVA: 0x13D6B90 Offset: 0x13D5590 VA: 0x1813D6B90
	|-BaseField<Rect>.OnViewDataReady
	|
	|-RVA: 0x13D5D20 Offset: 0x13D4720 VA: 0x1813D5D20
	|-BaseField<RectInt>.OnViewDataReady
	|
	|-RVA: 0x1406000 Offset: 0x1404A00 VA: 0x181406000
	|-BaseField<float>.OnViewDataReady
	|
	|-RVA: 0x14061F0 Offset: 0x1404BF0 VA: 0x1814061F0
	|-BaseField<uint>.OnViewDataReady
	|
	|-RVA: 0x1405790 Offset: 0x1404190 VA: 0x181405790
	|-BaseField<ulong>.OnViewDataReady
	|
	|-RVA: 0x1405980 Offset: 0x1404380 VA: 0x181405980
	|-BaseField<Vector2>.OnViewDataReady
	|
	|-RVA: 0x1404E90 Offset: 0x1403890 VA: 0x181404E90
	|-BaseField<Vector2Int>.OnViewDataReady
	|
	|-RVA: 0x14052B0 Offset: 0x1403CB0 VA: 0x1814052B0
	|-BaseField<Vector3>.OnViewDataReady
	|
	|-RVA: 0x1405520 Offset: 0x1403F20 VA: 0x181405520
	|-BaseField<Vector3Int>.OnViewDataReady
	|
	|-RVA: 0x1405080 Offset: 0x1403A80 VA: 0x181405080
	|-BaseField<Vector4>.OnViewDataReady
	|
	|-RVA: 0x1405BD0 Offset: 0x14045D0 VA: 0x181405BD0
	|-BaseField<__Il2CppFullySharedGenericType>.OnViewDataReady
	*/

	// RVA: -1 Offset: -1 Slot: 95
	internal override Rect GetTooltipRect() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13D0CD0 Offset: 0x13CF6D0 VA: 0x1813D0CD0
	|-BaseField<bool>.GetTooltipRect
	|-BaseField<double>.GetTooltipRect
	|-BaseField<int>.GetTooltipRect
	|-BaseField<long>.GetTooltipRect
	|-BaseField<object>.GetTooltipRect
	|-BaseField<float>.GetTooltipRect
	|-BaseField<uint>.GetTooltipRect
	|-BaseField<ulong>.GetTooltipRect
	|-BaseField<Vector2>.GetTooltipRect
	|-BaseField<Vector2Int>.GetTooltipRect
	|
	|-RVA: 0x13D0D50 Offset: 0x13CF750 VA: 0x1813D0D50
	|-BaseField<Bounds>.GetTooltipRect
	|-BaseField<BoundsInt>.GetTooltipRect
	|
	|-RVA: 0x13D0C50 Offset: 0x13CF650 VA: 0x1813D0C50
	|-BaseField<Hash128>.GetTooltipRect
	|-BaseField<Rect>.GetTooltipRect
	|-BaseField<RectInt>.GetTooltipRect
	|-BaseField<Vector3>.GetTooltipRect
	|-BaseField<Vector3Int>.GetTooltipRect
	|-BaseField<Vector4>.GetTooltipRect
	|
	|-RVA: 0x1400900 Offset: 0x13FF300 VA: 0x181400900
	|-BaseField<__Il2CppFullySharedGenericType>.GetTooltipRect
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13D8C10 Offset: 0x13D7610 VA: 0x1813D8C10
	|-BaseField<bool>..cctor
	|
	|-RVA: 0x13DAB30 Offset: 0x13D9530 VA: 0x1813DAB30
	|-BaseField<Bounds>..cctor
	|
	|-RVA: 0x13DDF10 Offset: 0x13DC910 VA: 0x1813DDF10
	|-BaseField<BoundsInt>..cctor
	|
	|-RVA: 0x13DA0D0 Offset: 0x13D8AD0 VA: 0x1813DA0D0
	|-BaseField<double>..cctor
	|
	|-RVA: 0x13DE970 Offset: 0x13DD370 VA: 0x1813DE970
	|-BaseField<Hash128>..cctor
	|
	|-RVA: 0x13DBFF0 Offset: 0x13DA9F0 VA: 0x1813DBFF0
	|-BaseField<int>..cctor
	|
	|-RVA: 0x13DD4B0 Offset: 0x13DBEB0 VA: 0x1813DD4B0
	|-BaseField<long>..cctor
	|
	|-RVA: 0x13DCA50 Offset: 0x13DB450 VA: 0x1813DCA50
	|-BaseField<object>..cctor
	|
	|-RVA: 0x13D9670 Offset: 0x13D8070 VA: 0x1813D9670
	|-BaseField<Rect>..cctor
	|
	|-RVA: 0x13DB590 Offset: 0x13D9F90 VA: 0x1813DB590
	|-BaseField<RectInt>..cctor
	|
	|-RVA: 0x140A9A0 Offset: 0x14093A0 VA: 0x18140A9A0
	|-BaseField<float>..cctor
	|
	|-RVA: 0x1409F40 Offset: 0x1408940 VA: 0x181409F40
	|-BaseField<uint>..cctor
	|
	|-RVA: 0x140B400 Offset: 0x1409E00 VA: 0x18140B400
	|-BaseField<ulong>..cctor
	|
	|-RVA: 0x140D320 Offset: 0x140BD20 VA: 0x18140D320
	|-BaseField<Vector2>..cctor
	|
	|-RVA: 0x1408A80 Offset: 0x1407480 VA: 0x181408A80
	|-BaseField<Vector2Int>..cctor
	|
	|-RVA: 0x14094E0 Offset: 0x1407EE0 VA: 0x1814094E0
	|-BaseField<Vector3>..cctor
	|
	|-RVA: 0x1408020 Offset: 0x1406A20 VA: 0x181408020
	|-BaseField<Vector3Int>..cctor
	|
	|-RVA: 0x140C8C0 Offset: 0x140B2C0 VA: 0x18140C8C0
	|-BaseField<Vector4>..cctor
	|
	|-RVA: 0x140BE60 Offset: 0x140A860 VA: 0x18140BE60
	|-BaseField<__Il2CppFullySharedGenericType>..cctor
	*/
}

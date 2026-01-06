internal struct StyleDataRef<T> : IEquatable<StyleDataRef<T>> // TypeDefIndex: 6813
{
	// Fields
	private StyleDataRef.RefCounted<T> m_Ref; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public StyleDataRef<T> Acquire() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11E7960 Offset: 0x11E6360 VA: 0x1811E7960
	|-StyleDataRef<InheritedData>.Acquire
	|-StyleDataRef<LayoutData>.Acquire
	|-StyleDataRef<RareData>.Acquire
	|-StyleDataRef<TransformData>.Acquire
	|-StyleDataRef<TransitionData>.Acquire
	|-StyleDataRef<VisualData>.Acquire
	|
	|-RVA: 0x11E79C0 Offset: 0x11E63C0 VA: 0x1811E79C0
	|-StyleDataRef<__Il2CppFullySharedGenericStructType>.Acquire
	*/

	// RVA: -1 Offset: -1
	public void Release() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11E9690 Offset: 0x11E8090 VA: 0x1811E9690
	|-StyleDataRef<InheritedData>.Release
	|-StyleDataRef<LayoutData>.Release
	|-StyleDataRef<RareData>.Release
	|-StyleDataRef<TransformData>.Release
	|-StyleDataRef<TransitionData>.Release
	|-StyleDataRef<VisualData>.Release
	|
	|-RVA: 0x11E96F0 Offset: 0x11E80F0 VA: 0x1811E96F0
	|-StyleDataRef<__Il2CppFullySharedGenericStructType>.Release
	*/

	// RVA: -1 Offset: -1
	public void CopyFrom(StyleDataRef<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11E8050 Offset: 0x11E6A50 VA: 0x1811E8050
	|-StyleDataRef<InheritedData>.CopyFrom
	|
	|-RVA: 0x11E7A50 Offset: 0x11E6450 VA: 0x1811E7A50
	|-StyleDataRef<LayoutData>.CopyFrom
	|
	|-RVA: 0x11E7E10 Offset: 0x11E6810 VA: 0x1811E7E10
	|-StyleDataRef<RareData>.CopyFrom
	|
	|-RVA: 0x11E7F30 Offset: 0x11E6930 VA: 0x1811E7F30
	|-StyleDataRef<TransformData>.CopyFrom
	|
	|-RVA: 0x11E8290 Offset: 0x11E6C90 VA: 0x1811E8290
	|-StyleDataRef<TransitionData>.CopyFrom
	|
	|-RVA: 0x11E8170 Offset: 0x11E6B70 VA: 0x1811E8170
	|-StyleDataRef<VisualData>.CopyFrom
	|
	|-RVA: 0x11E7B70 Offset: 0x11E6570 VA: 0x1811E7B70
	|-StyleDataRef<__Il2CppFullySharedGenericStructType>.CopyFrom
	*/

	// RVA: -1 Offset: -1
	public ref T Read() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11E9610 Offset: 0x11E8010 VA: 0x1811E9610
	|-StyleDataRef<InheritedData>.Read
	|-StyleDataRef<LayoutData>.Read
	|-StyleDataRef<RareData>.Read
	|-StyleDataRef<TransformData>.Read
	|-StyleDataRef<TransitionData>.Read
	|-StyleDataRef<VisualData>.Read
	|
	|-RVA: 0x11E9630 Offset: 0x11E8030 VA: 0x1811E9630
	|-StyleDataRef<__Il2CppFullySharedGenericStructType>.Read
	*/

	// RVA: -1 Offset: -1
	public ref T Write() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11E9860 Offset: 0x11E8260 VA: 0x1811E9860
	|-StyleDataRef<InheritedData>.Write
	|
	|-RVA: 0x11E9D50 Offset: 0x11E8750 VA: 0x1811E9D50
	|-StyleDataRef<LayoutData>.Write
	|
	|-RVA: 0x11E9790 Offset: 0x11E8190 VA: 0x1811E9790
	|-StyleDataRef<RareData>.Write
	|
	|-RVA: 0x11E9BB0 Offset: 0x11E85B0 VA: 0x1811E9BB0
	|-StyleDataRef<TransformData>.Write
	|
	|-RVA: 0x11E9AE0 Offset: 0x11E84E0 VA: 0x1811E9AE0
	|-StyleDataRef<TransitionData>.Write
	|
	|-RVA: 0x11E9C80 Offset: 0x11E8680 VA: 0x1811E9C80
	|-StyleDataRef<VisualData>.Write
	|
	|-RVA: 0x11E9930 Offset: 0x11E8330 VA: 0x1811E9930
	|-StyleDataRef<__Il2CppFullySharedGenericStructType>.Write
	*/

	// RVA: -1 Offset: -1
	public static StyleDataRef<T> Create() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11E83B0 Offset: 0x11E6DB0 VA: 0x1811E83B0
	|-StyleDataRef<InheritedData>.Create
	|-StyleDataRef<LayoutData>.Create
	|-StyleDataRef<RareData>.Create
	|-StyleDataRef<TransformData>.Create
	|-StyleDataRef<TransitionData>.Create
	|-StyleDataRef<VisualData>.Create
	|
	|-RVA: 0x11E8450 Offset: 0x11E6E50 VA: 0x1811E8450
	|-StyleDataRef<__Il2CppFullySharedGenericStructType>.Create
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public override int GetHashCode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11E95C0 Offset: 0x11E7FC0 VA: 0x1811E95C0
	|-StyleDataRef<InheritedData>.GetHashCode
	|
	|-RVA: 0x11E9370 Offset: 0x11E7D70 VA: 0x1811E9370
	|-StyleDataRef<LayoutData>.GetHashCode
	|
	|-RVA: 0x11E9320 Offset: 0x11E7D20 VA: 0x1811E9320
	|-StyleDataRef<RareData>.GetHashCode
	|
	|-RVA: 0x11E9570 Offset: 0x11E7F70 VA: 0x1811E9570
	|-StyleDataRef<TransformData>.GetHashCode
	|
	|-RVA: 0x11E93C0 Offset: 0x11E7DC0 VA: 0x1811E93C0
	|-StyleDataRef<TransitionData>.GetHashCode
	|
	|-RVA: 0x11E92D0 Offset: 0x11E7CD0 VA: 0x1811E92D0
	|-StyleDataRef<VisualData>.GetHashCode
	|
	|-RVA: 0x11E9410 Offset: 0x11E7E10 VA: 0x1811E9410
	|-StyleDataRef<__Il2CppFullySharedGenericStructType>.GetHashCode
	*/

	// RVA: -1 Offset: -1
	public static bool op_Equality(StyleDataRef<T> lhs, StyleDataRef<T> rhs) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11E9FC0 Offset: 0x11E89C0 VA: 0x1811E9FC0
	|-StyleDataRef<InheritedData>.op_Equality
	|
	|-RVA: 0x11EA370 Offset: 0x11E8D70 VA: 0x1811EA370
	|-StyleDataRef<LayoutData>.op_Equality
	|
	|-RVA: 0x11E9E90 Offset: 0x11E8890 VA: 0x1811E9E90
	|-StyleDataRef<RareData>.op_Equality
	|
	|-RVA: 0x11E9F20 Offset: 0x11E8920 VA: 0x1811E9F20
	|-StyleDataRef<TransformData>.op_Equality
	|
	|-RVA: 0x11E9E20 Offset: 0x11E8820 VA: 0x1811E9E20
	|-StyleDataRef<TransitionData>.op_Equality
	|
	|-RVA: 0x11EA090 Offset: 0x11E8A90 VA: 0x1811EA090
	|-StyleDataRef<VisualData>.op_Equality
	|
	|-RVA: 0x11EA180 Offset: 0x11E8B80 VA: 0x1811EA180
	|-StyleDataRef<__Il2CppFullySharedGenericStructType>.op_Equality
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public bool Equals(StyleDataRef<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11E90B0 Offset: 0x11E7AB0 VA: 0x1811E90B0
	|-StyleDataRef<InheritedData>.Equals
	|
	|-RVA: 0x11E8D60 Offset: 0x11E7760 VA: 0x1811E8D60
	|-StyleDataRef<LayoutData>.Equals
	|
	|-RVA: 0x11E87A0 Offset: 0x11E71A0 VA: 0x1811E87A0
	|-StyleDataRef<RareData>.Equals
	|
	|-RVA: 0x11E8510 Offset: 0x11E6F10 VA: 0x1811E8510
	|-StyleDataRef<TransformData>.Equals
	|
	|-RVA: 0x11E8860 Offset: 0x11E7260 VA: 0x1811E8860
	|-StyleDataRef<TransitionData>.Equals
	|
	|-RVA: 0x11E85F0 Offset: 0x11E6FF0 VA: 0x1811E85F0
	|-StyleDataRef<VisualData>.Equals
	|
	|-RVA: 0x11E8720 Offset: 0x11E7120 VA: 0x1811E8720
	|-StyleDataRef<__Il2CppFullySharedGenericStructType>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 0
	public override bool Equals(object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11E8FA0 Offset: 0x11E79A0 VA: 0x1811E8FA0
	|-StyleDataRef<InheritedData>.Equals
	|
	|-RVA: 0x11E91C0 Offset: 0x11E7BC0 VA: 0x1811E91C0
	|-StyleDataRef<LayoutData>.Equals
	|
	|-RVA: 0x11E8900 Offset: 0x11E7300 VA: 0x1811E8900
	|-StyleDataRef<RareData>.Equals
	|
	|-RVA: 0x11E8A10 Offset: 0x11E7410 VA: 0x1811E8A10
	|-StyleDataRef<TransformData>.Equals
	|
	|-RVA: 0x11E8E90 Offset: 0x11E7890 VA: 0x1811E8E90
	|-StyleDataRef<TransitionData>.Equals
	|
	|-RVA: 0x11E8B20 Offset: 0x11E7520 VA: 0x1811E8B20
	|-StyleDataRef<VisualData>.Equals
	|
	|-RVA: 0x11E8C30 Offset: 0x11E7630 VA: 0x1811E8C30
	|-StyleDataRef<__Il2CppFullySharedGenericStructType>.Equals
	*/

	// RVA: -1 Offset: -1
	public bool ReferenceEquals(StyleDataRef<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11E9680 Offset: 0x11E8080 VA: 0x1811E9680
	|-StyleDataRef<InheritedData>.ReferenceEquals
	|-StyleDataRef<LayoutData>.ReferenceEquals
	|-StyleDataRef<RareData>.ReferenceEquals
	|-StyleDataRef<TransformData>.ReferenceEquals
	|-StyleDataRef<TransitionData>.ReferenceEquals
	|-StyleDataRef<VisualData>.ReferenceEquals
	|-StyleDataRef<__Il2CppFullySharedGenericStructType>.ReferenceEquals
	*/
}

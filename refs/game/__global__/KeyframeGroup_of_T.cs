public class KeyframeGroup<T> : IKeyframeGroup // TypeDefIndex: 429
{
	// Fields
	public List<T> keyframes; // 0x0
	[SerializeField]
	private string m_Name; // 0x0
	[SerializeField]
	private string m_Id; // 0x0

	// Properties
	public string name { get; set; }
	public string id { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public string get_name() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	|-KeyframeGroup<object>.get_name
	|-KeyframeGroup<__Il2CppFullySharedGenericType>.get_name
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void set_name(string value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x43EFE0 Offset: 0x43D9E0 VA: 0x18043EFE0
	|-KeyframeGroup<object>.set_name
	|-KeyframeGroup<__Il2CppFullySharedGenericType>.set_name
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public string get_id() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	|-KeyframeGroup<object>.get_id
	|-KeyframeGroup<__Il2CppFullySharedGenericType>.get_id
	*/

	// RVA: -1 Offset: -1
	public void set_id(string value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x43EFF0 Offset: 0x43D9F0 VA: 0x18043EFF0
	|-KeyframeGroup<object>.set_id
	|-KeyframeGroup<__Il2CppFullySharedGenericType>.set_id
	*/

	// RVA: -1 Offset: -1
	public void .ctor(string name) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x18D3430 Offset: 0x18D1E30 VA: 0x1818D3430
	|-KeyframeGroup<object>..ctor
	|
	|-RVA: 0x18D3340 Offset: 0x18D1D40 VA: 0x1818D3340
	|-KeyframeGroup<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void AddKeyFrame(T keyFrame) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x18D1410 Offset: 0x18CFE10 VA: 0x1818D1410
	|-KeyframeGroup<object>.AddKeyFrame
	|
	|-RVA: 0x18D1300 Offset: 0x18CFD00 VA: 0x1818D1300
	|-KeyframeGroup<__Il2CppFullySharedGenericType>.AddKeyFrame
	*/

	// RVA: -1 Offset: -1
	public void RemoveKeyFrame(T keyFrame) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x18D3060 Offset: 0x18D1A60 VA: 0x1818D3060
	|-KeyframeGroup<object>.RemoveKeyFrame
	|
	|-RVA: 0x18D2CB0 Offset: 0x18D16B0 VA: 0x1818D2CB0
	|-KeyframeGroup<__Il2CppFullySharedGenericType>.RemoveKeyFrame
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public void RemoveKeyFrame(IBaseKeyframe keyframe) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x18D2F20 Offset: 0x18D1920 VA: 0x1818D2F20
	|-KeyframeGroup<object>.RemoveKeyFrame
	|
	|-RVA: 0x18D2E40 Offset: 0x18D1840 VA: 0x1818D2E40
	|-KeyframeGroup<__Il2CppFullySharedGenericType>.RemoveKeyFrame
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public int GetKeyFrameCount() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC4AA50 Offset: 0xC49450 VA: 0x180C4AA50
	|-KeyframeGroup<object>.GetKeyFrameCount
	|
	|-RVA: 0x18D1640 Offset: 0x18D0040 VA: 0x1818D1640
	|-KeyframeGroup<__Il2CppFullySharedGenericType>.GetKeyFrameCount
	*/

	// RVA: -1 Offset: -1
	public T GetKeyframe(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11AF3F0 Offset: 0x11ADDF0 VA: 0x1811AF3F0
	|-KeyframeGroup<object>.GetKeyframe
	|
	|-RVA: 0x18D1670 Offset: 0x18D0070 VA: 0x1818D1670
	|-KeyframeGroup<__Il2CppFullySharedGenericType>.GetKeyframe
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public void SortKeyframes() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x18D31F0 Offset: 0x18D1BF0 VA: 0x1818D31F0
	|-KeyframeGroup<object>.SortKeyframes
	|
	|-RVA: 0x18D31C0 Offset: 0x18D1BC0 VA: 0x1818D31C0
	|-KeyframeGroup<__Il2CppFullySharedGenericType>.SortKeyframes
	*/

	// RVA: -1 Offset: -1
	public float CurveAdjustedBlendingTime(InterpolationCurve curve, float t) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x18D1570 Offset: 0x18CFF70 VA: 0x1818D1570
	|-KeyframeGroup<object>.CurveAdjustedBlendingTime
	|-KeyframeGroup<__Il2CppFullySharedGenericType>.CurveAdjustedBlendingTime
	*/

	// RVA: -1 Offset: -1
	public T GetPreviousKeyFrame(float time) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x18D1740 Offset: 0x18D0140 VA: 0x1818D1740
	|-KeyframeGroup<object>.GetPreviousKeyFrame
	|
	|-RVA: 0x18D1850 Offset: 0x18D0250 VA: 0x1818D1850
	|-KeyframeGroup<__Il2CppFullySharedGenericType>.GetPreviousKeyFrame
	*/

	// RVA: -1 Offset: -1
	public bool GetSurroundingKeyFrames(float time, out T beforeKeyframe, out T afterKeyframe) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x18D1C90 Offset: 0x18D0690 VA: 0x1818D1C90
	|-KeyframeGroup<object>.GetSurroundingKeyFrames
	|
	|-RVA: 0x18D1A80 Offset: 0x18D0480 VA: 0x1818D1A80
	|-KeyframeGroup<__Il2CppFullySharedGenericType>.GetSurroundingKeyFrames
	*/

	// RVA: -1 Offset: -1
	public bool GetSurroundingKeyFrames(float time, out int beforeIndex, out int afterIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x18D2210 Offset: 0x18D0C10 VA: 0x1818D2210
	|-KeyframeGroup<object>.GetSurroundingKeyFrames
	|
	|-RVA: 0x18D1D90 Offset: 0x18D0790 VA: 0x1818D1D90
	|-KeyframeGroup<__Il2CppFullySharedGenericType>.GetSurroundingKeyFrames
	*/

	// RVA: -1 Offset: -1
	public static float ProgressBetweenSurroundingKeyframes(float time, BaseKeyframe beforeKey, BaseKeyframe afterKey) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x18D2B70 Offset: 0x18D1570 VA: 0x1818D2B70
	|-KeyframeGroup<object>.ProgressBetweenSurroundingKeyframes
	|
	|-RVA: 0x18D2BF0 Offset: 0x18D15F0 VA: 0x1818D2BF0
	|-KeyframeGroup<__Il2CppFullySharedGenericType>.ProgressBetweenSurroundingKeyframes
	*/

	// RVA: -1 Offset: -1
	public static float ProgressBetweenSurroundingKeyframes(float time, float beforeKeyTime, float afterKeyTime) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x18D2960 Offset: 0x18D1360 VA: 0x1818D2960
	|-KeyframeGroup<object>.ProgressBetweenSurroundingKeyframes
	|
	|-RVA: 0x18D2A50 Offset: 0x18D1450 VA: 0x1818D2A50
	|-KeyframeGroup<__Il2CppFullySharedGenericType>.ProgressBetweenSurroundingKeyframes
	*/

	// RVA: -1 Offset: -1
	public static float WidthBetweenCircularValues(float begin, float end) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x18D3310 Offset: 0x18D1D10 VA: 0x1818D3310
	|-KeyframeGroup<object>.WidthBetweenCircularValues
	|-KeyframeGroup<__Il2CppFullySharedGenericType>.WidthBetweenCircularValues
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public void TrimToSingleKeyframe() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x18D3220 Offset: 0x18D1C20 VA: 0x1818D3220
	|-KeyframeGroup<object>.TrimToSingleKeyframe
	|
	|-RVA: 0x18D3270 Offset: 0x18D1C70 VA: 0x1818D3270
	|-KeyframeGroup<__Il2CppFullySharedGenericType>.TrimToSingleKeyframe
	*/

	// RVA: -1 Offset: -1
	public InterpolationDirection GetShortestInterpolationDirection(float previousKeyValue, float nextKeyValue, float minValue, float maxValue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x18D19C0 Offset: 0x18D03C0 VA: 0x1818D19C0
	|-KeyframeGroup<object>.GetShortestInterpolationDirection
	|
	|-RVA: 0x18D1A10 Offset: 0x18D0410 VA: 0x1818D1A10
	|-KeyframeGroup<__Il2CppFullySharedGenericType>.GetShortestInterpolationDirection
	*/

	// RVA: -1 Offset: -1
	public void CalculateCircularDistances(float previousKeyValue, float nextKeyValue, float minValue, float maxValue, out float forwardDistance, out float reverseDistance) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x18D1520 Offset: 0x18CFF20 VA: 0x1818D1520
	|-KeyframeGroup<object>.CalculateCircularDistances
	|-KeyframeGroup<__Il2CppFullySharedGenericType>.CalculateCircularDistances
	*/

	// RVA: -1 Offset: -1
	public float InterpolateFloat(InterpolationCurve curve, InterpolationDirection direction, float time, float beforeTime, float nextTime, float previousKeyValue, float nextKeyValue, float minValue, float maxValue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x18D23C0 Offset: 0x18D0DC0 VA: 0x1818D23C0
	|-KeyframeGroup<object>.InterpolateFloat
	|
	|-RVA: 0x18D26A0 Offset: 0x18D10A0 VA: 0x1818D26A0
	|-KeyframeGroup<__Il2CppFullySharedGenericType>.InterpolateFloat
	*/

	// RVA: -1 Offset: -1
	public float AutoInterpolation(float curvedTime, float previousValue, float nextValue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x18D14E0 Offset: 0x18CFEE0 VA: 0x1818D14E0
	|-KeyframeGroup<object>.AutoInterpolation
	|-KeyframeGroup<__Il2CppFullySharedGenericType>.AutoInterpolation
	*/

	// RVA: -1 Offset: -1
	public float ForwardInterpolation(float time, float previousKeyValue, float nextKeyValue, float minValue, float maxValue, float distance) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x18D15D0 Offset: 0x18CFFD0 VA: 0x1818D15D0
	|-KeyframeGroup<object>.ForwardInterpolation
	|-KeyframeGroup<__Il2CppFullySharedGenericType>.ForwardInterpolation
	*/

	// RVA: -1 Offset: -1
	public float ReverseInterpolation(float time, float previousKeyValue, float nextKeyValue, float minValue, float maxValue, float distance) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x18D3150 Offset: 0x18D1B50 VA: 0x1818D3150
	|-KeyframeGroup<object>.ReverseInterpolation
	|-KeyframeGroup<__Il2CppFullySharedGenericType>.ReverseInterpolation
	*/
}

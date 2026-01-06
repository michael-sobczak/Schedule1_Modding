public class KeyframeUtility // TypeDefIndex: 13883
{
	// Methods

	// RVA: 0x2A55990 Offset: 0x2A54390 VA: 0x182A55990
	public static void ResetAnimationCurve(AnimationCurve curve) { }

	// RVA: 0x2A55740 Offset: 0x2A54140 VA: 0x182A55740
	private static Keyframe LerpSingleKeyframe(Keyframe lhs, Keyframe rhs, float t) { }

	// RVA: 0x2A54EE0 Offset: 0x2A538E0 VA: 0x182A54EE0
	private static Keyframe GetKeyframeAndClampEdge(NativeArray<Keyframe> keys, int index) { }

	// RVA: 0x2A54D30 Offset: 0x2A53730 VA: 0x182A54D30
	private static Keyframe FetchKeyFromIndexClampEdge(NativeArray<Keyframe> keys, int index, float segmentStartTime, float segmentEndTime) { }

	// RVA: 0x2A549B0 Offset: 0x2A533B0 VA: 0x182A549B0
	private static void EvalCurveSegmentAndDeriv(out float dstValue, out float dstDeriv, Keyframe lhsKey, Keyframe rhsKey, float desiredTime) { }

	// RVA: 0x2A54BB0 Offset: 0x2A535B0 VA: 0x182A54BB0
	private static Keyframe EvalKeyAtTime(NativeArray<Keyframe> keys, int lhsIndex, int rhsIndex, float startTime, float endTime, float currTime) { }

	// RVA: 0x2A55010 Offset: 0x2A53A10 VA: 0x182A55010
	public static void InterpAnimationCurve(ref AnimationCurve lhsAndResultCurve, AnimationCurve rhsCurve, float t) { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }
}

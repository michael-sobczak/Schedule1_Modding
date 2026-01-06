public class Interpolate // TypeDefIndex: 96
{
	// Methods

	// RVA: 0x5762D0 Offset: 0x574CD0 VA: 0x1805762D0
	private static Vector3 Identity(Vector3 v) { }

	// RVA: 0x576CD0 Offset: 0x5756D0 VA: 0x180576CD0
	private static Vector3 TransformDotPosition(Transform t) { }

	[IteratorStateMachine(typeof(Interpolate.<NewTimer>d__3))]
	// RVA: 0x576C60 Offset: 0x575660 VA: 0x180576C60
	private static IEnumerable<float> NewTimer(float duration) { }

	[IteratorStateMachine(typeof(Interpolate.<NewCounter>d__6))]
	// RVA: 0x5768B0 Offset: 0x5752B0 VA: 0x1805768B0
	private static IEnumerable<float> NewCounter(int start, int end, int step) { }

	// RVA: 0x576A70 Offset: 0x575470 VA: 0x180576A70
	public static IEnumerator NewEase(Interpolate.Function ease, Vector3 start, Vector3 end, float duration) { }

	// RVA: 0x576940 Offset: 0x575340 VA: 0x180576940
	public static IEnumerator NewEase(Interpolate.Function ease, Vector3 start, Vector3 end, int slices) { }

	[IteratorStateMachine(typeof(Interpolate.<NewEase>d__9))]
	// RVA: 0x576B90 Offset: 0x575590 VA: 0x180576B90
	private static IEnumerator NewEase(Interpolate.Function ease, Vector3 start, Vector3 end, float total, IEnumerable<float> driver) { }

	// RVA: 0x5761A0 Offset: 0x574BA0 VA: 0x1805761A0
	private static Vector3 Ease(Interpolate.Function ease, Vector3 start, Vector3 distance, float elapsedTime, float duration) { }

	// RVA: 0x575DD0 Offset: 0x5747D0 VA: 0x180575DD0
	public static Interpolate.Function Ease(Interpolate.EaseType type) { }

	// RVA: 0x576530 Offset: 0x574F30 VA: 0x180576530
	public static IEnumerable<Vector3> NewBezier(Interpolate.Function ease, Transform[] nodes, float duration) { }

	// RVA: 0x576630 Offset: 0x575030 VA: 0x180576630
	public static IEnumerable<Vector3> NewBezier(Interpolate.Function ease, Transform[] nodes, int slices) { }

	// RVA: 0x576310 Offset: 0x574D10 VA: 0x180576310
	public static IEnumerable<Vector3> NewBezier(Interpolate.Function ease, Vector3[] points, float duration) { }

	// RVA: 0x576410 Offset: 0x574E10 VA: 0x180576410
	public static IEnumerable<Vector3> NewBezier(Interpolate.Function ease, Vector3[] points, int slices) { }

	[IteratorStateMachine(typeof(Interpolate.<NewBezier>d__16<T>))]
	// RVA: -1 Offset: -1
	private static IEnumerable<Vector3> NewBezier<T>(Interpolate.Function ease, IList nodes, Interpolate.ToVector3<T> toVector3, float maxStep, IEnumerable<float> steps) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEE4100 Offset: 0xEE2B00 VA: 0x180EE4100
	|-Interpolate.NewBezier<object>
	|-Interpolate.NewBezier<Vector3>
	|
	|-RVA: 0xEE4010 Offset: 0xEE2A10 VA: 0x180EE4010
	|-Interpolate.NewBezier<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x5751C0 Offset: 0x573BC0 VA: 0x1805751C0
	private static Vector3 Bezier(Interpolate.Function ease, Vector3[] points, float elapsedTime, float duration) { }

	// RVA: 0x576800 Offset: 0x575200 VA: 0x180576800
	public static IEnumerable<Vector3> NewCatmullRom(Transform[] nodes, int slices, bool loop) { }

	// RVA: 0x576750 Offset: 0x575150 VA: 0x180576750
	public static IEnumerable<Vector3> NewCatmullRom(Vector3[] points, int slices, bool loop) { }

	[IteratorStateMachine(typeof(Interpolate.<NewCatmullRom>d__20<T>))]
	// RVA: -1 Offset: -1
	private static IEnumerable<Vector3> NewCatmullRom<T>(IList nodes, Interpolate.ToVector3<T> toVector3, int slices, bool loop) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEE42C0 Offset: 0xEE2CC0 VA: 0x180EE42C0
	|-Interpolate.NewCatmullRom<object>
	|-Interpolate.NewCatmullRom<Vector3>
	|
	|-RVA: 0xEE41F0 Offset: 0xEE2BF0 VA: 0x180EE41F0
	|-Interpolate.NewCatmullRom<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x575390 Offset: 0x573D90 VA: 0x180575390
	private static Vector3 CatmullRom(Vector3 previous, Vector3 start, Vector3 end, Vector3 next, float elapsedTime, float duration) { }

	// RVA: 0x5762F0 Offset: 0x574CF0 VA: 0x1805762F0
	private static float Linear(float start, float distance, float elapsedTime, float duration) { }

	// RVA: 0x575AA0 Offset: 0x5744A0 VA: 0x180575AA0
	private static float EaseInQuad(float start, float distance, float elapsedTime, float duration) { }

	// RVA: 0x575CC0 Offset: 0x5746C0 VA: 0x180575CC0
	private static float EaseOutQuad(float start, float distance, float elapsedTime, float duration) { }

	// RVA: 0x575860 Offset: 0x574260 VA: 0x180575860
	private static float EaseInOutQuad(float start, float distance, float elapsedTime, float duration) { }

	// RVA: 0x5755D0 Offset: 0x573FD0 VA: 0x1805755D0
	private static float EaseInCubic(float start, float distance, float elapsedTime, float duration) { }

	// RVA: 0x575C20 Offset: 0x574620 VA: 0x180575C20
	private static float EaseOutCubic(float start, float distance, float elapsedTime, float duration) { }

	// RVA: 0x575740 Offset: 0x574140 VA: 0x180575740
	private static float EaseInOutCubic(float start, float distance, float elapsedTime, float duration) { }

	// RVA: 0x575AE0 Offset: 0x5744E0 VA: 0x180575AE0
	private static float EaseInQuart(float start, float distance, float elapsedTime, float duration) { }

	// RVA: 0x575D00 Offset: 0x574700 VA: 0x180575D00
	private static float EaseOutQuart(float start, float distance, float elapsedTime, float duration) { }

	// RVA: 0x575900 Offset: 0x574300 VA: 0x180575900
	private static float EaseInOutQuart(float start, float distance, float elapsedTime, float duration) { }

	// RVA: 0x575B10 Offset: 0x574510 VA: 0x180575B10
	private static float EaseInQuint(float start, float distance, float elapsedTime, float duration) { }

	// RVA: 0x575D40 Offset: 0x574740 VA: 0x180575D40
	private static float EaseOutQuint(float start, float distance, float elapsedTime, float duration) { }

	// RVA: 0x5759A0 Offset: 0x5743A0 VA: 0x1805759A0
	private static float EaseInOutQuint(float start, float distance, float elapsedTime, float duration) { }

	// RVA: 0x575B50 Offset: 0x574550 VA: 0x180575B50
	private static float EaseInSine(float start, float distance, float elapsedTime, float duration) { }

	// RVA: 0x575D80 Offset: 0x574780 VA: 0x180575D80
	private static float EaseOutSine(float start, float distance, float elapsedTime, float duration) { }

	// RVA: 0x575A40 Offset: 0x574440 VA: 0x180575A40
	private static float EaseInOutSine(float start, float distance, float elapsedTime, float duration) { }

	// RVA: 0x575610 Offset: 0x574010 VA: 0x180575610
	private static float EaseInExpo(float start, float distance, float elapsedTime, float duration) { }

	// RVA: 0x575C60 Offset: 0x574660 VA: 0x180575C60
	private static float EaseOutExpo(float start, float distance, float elapsedTime, float duration) { }

	// RVA: 0x5757C0 Offset: 0x5741C0 VA: 0x1805757C0
	private static float EaseInOutExpo(float start, float distance, float elapsedTime, float duration) { }

	// RVA: 0x575550 Offset: 0x573F50 VA: 0x180575550
	private static float EaseInCirc(float start, float distance, float elapsedTime, float duration) { }

	// RVA: 0x575BB0 Offset: 0x5745B0 VA: 0x180575BB0
	private static float EaseOutCirc(float start, float distance, float elapsedTime, float duration) { }

	// RVA: 0x575670 Offset: 0x574070 VA: 0x180575670
	private static float EaseInOutCirc(float start, float distance, float elapsedTime, float duration) { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }
}

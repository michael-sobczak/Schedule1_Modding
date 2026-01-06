public sealed class AnimationClip : Motion // TypeDefIndex: 18285
{
	// Properties
	[NativeProperty("Length", False, 0)]
	public float length { get; }
	[NativeProperty("SampleRate", False, 0)]
	public float frameRate { get; set; }
	[NativeProperty("WrapMode", False, 0)]
	public WrapMode wrapMode { get; set; }
	public bool legacy { get; set; }
	public bool empty { get; }
	public bool hasGenericRootTransform { get; }
	public bool hasMotionCurves { get; }
	public bool hasRootCurves { get; }
	internal bool hasRootMotion { get; }
	public AnimationEvent[] events { get; }

	// Methods

	// RVA: 0x2C727C0 Offset: 0x2C711C0 VA: 0x182C727C0
	public void .ctor() { }

	[FreeFunction("AnimationClipBindings::Internal_CreateAnimationClip")]
	// RVA: 0x2C72610 Offset: 0x2C71010 VA: 0x182C72610
	private static void Internal_CreateAnimationClip(AnimationClip self) { }

	// RVA: 0x2C726C0 Offset: 0x2C710C0 VA: 0x182C726C0
	public void SampleAnimation(GameObject go, float time) { }

	[NativeHeader("Modules/Animation/AnimationUtility.h")]
	[FreeFunction]
	// RVA: 0x2C72650 Offset: 0x2C71050 VA: 0x182C72650
	internal static void SampleAnimation(GameObject go, AnimationClip clip, float inTime, WrapMode wrapMode) { }

	// RVA: 0x2C72A80 Offset: 0x2C71480 VA: 0x182C72A80
	public float get_length() { }

	// RVA: 0x2C72900 Offset: 0x2C71300 VA: 0x182C72900
	public float get_frameRate() { }

	// RVA: 0x2C72B00 Offset: 0x2C71500 VA: 0x182C72B00
	public void set_frameRate(float value) { }

	[FreeFunction("AnimationClipBindings::Internal_SetCurve", HasExplicitThis = True)]
	// RVA: 0x2C72750 Offset: 0x2C71150 VA: 0x182C72750
	public void SetCurve(string relativePath, Type type, string propertyName, AnimationCurve curve) { }

	// RVA: 0x2C72590 Offset: 0x2C70F90 VA: 0x182C72590
	public void EnsureQuaternionContinuity() { }

	// RVA: 0x2C72AC0 Offset: 0x2C714C0 VA: 0x182C72AC0
	public WrapMode get_wrapMode() { }

	// RVA: 0x2C72BA0 Offset: 0x2C715A0 VA: 0x182C72BA0
	public void set_wrapMode(WrapMode value) { }

	[NativeMethod("IsLegacy")]
	// RVA: 0x2C72A40 Offset: 0x2C71440 VA: 0x182C72A40
	public bool get_legacy() { }

	[NativeMethod("SetLegacy")]
	// RVA: 0x2C72B50 Offset: 0x2C71550 VA: 0x182C72B50
	public void set_legacy(bool value) { }

	[NativeMethod("IsEmpty")]
	// RVA: 0x2C72830 Offset: 0x2C71230 VA: 0x182C72830
	public bool get_empty() { }

	[NativeMethod("HasGenericRootTransform")]
	// RVA: 0x2C72940 Offset: 0x2C71340 VA: 0x182C72940
	public bool get_hasGenericRootTransform() { }

	[NativeMethod("HasMotionCurves")]
	// RVA: 0x2C72980 Offset: 0x2C71380 VA: 0x182C72980
	public bool get_hasMotionCurves() { }

	[NativeMethod("HasRootCurves")]
	// RVA: 0x2C729C0 Offset: 0x2C713C0 VA: 0x182C729C0
	public bool get_hasRootCurves() { }

	[FreeFunction(Name = "AnimationClipBindings::Internal_GetHasRootMotion", HasExplicitThis = True)]
	// RVA: 0x2C72A00 Offset: 0x2C71400 VA: 0x182C72A00
	internal bool get_hasRootMotion() { }

	// RVA: 0x2C72870 Offset: 0x2C71270 VA: 0x182C72870
	public AnimationEvent[] get_events() { }

	[FreeFunction(Name = "AnimationClipBindings::GetEventsInternal", HasExplicitThis = True)]
	// RVA: 0x2C725D0 Offset: 0x2C70FD0 VA: 0x182C725D0
	private Array GetEventsInternal() { }
}

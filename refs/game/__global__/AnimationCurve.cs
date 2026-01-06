public class AnimationCurve : IEquatable<AnimationCurve> // TypeDefIndex: 11584
{
	// Fields
	internal IntPtr m_Ptr; // 0x10

	// Properties
	public Keyframe[] keys { get; set; }
	public Keyframe Item { get; }
	public int length { get; }
	public WrapMode preWrapMode { set; }
	public WrapMode postWrapMode { set; }

	// Methods

	[FreeFunction("AnimationCurveBindings::Internal_Destroy", IsThreadSafe = True)]
	// RVA: 0x2C7E780 Offset: 0x2C7D180 VA: 0x182C7E780
	private static void Internal_Destroy(IntPtr ptr) { }

	[FreeFunction("AnimationCurveBindings::Internal_Create", IsThreadSafe = True)]
	// RVA: 0x2C7E740 Offset: 0x2C7D140 VA: 0x182C7E740
	private static IntPtr Internal_Create(Keyframe[] keys) { }

	[FreeFunction("AnimationCurveBindings::Internal_Equals", HasExplicitThis = True, IsThreadSafe = True)]
	// RVA: 0x2C7E7C0 Offset: 0x2C7D1C0 VA: 0x182C7E7C0
	private bool Internal_Equals(IntPtr other) { }

	[FreeFunction("AnimationCurveBindings::Internal_CopyFrom", HasExplicitThis = True, IsThreadSafe = True)]
	// RVA: 0x2C7E6F0 Offset: 0x2C7D0F0 VA: 0x182C7E6F0
	private void Internal_CopyFrom(IntPtr other) { }

	// RVA: 0x2C7E530 Offset: 0x2C7CF30 VA: 0x182C7E530 Slot: 1
	protected override void Finalize() { }

	[ThreadSafe]
	// RVA: 0x2C7E4E0 Offset: 0x2C7CEE0 VA: 0x182C7E4E0
	public float Evaluate(float time) { }

	// RVA: 0x2C7E6B0 Offset: 0x2C7D0B0 VA: 0x182C7E6B0
	public Keyframe[] get_keys() { }

	// RVA: 0x2C7EB00 Offset: 0x2C7D500 VA: 0x182C7EB00
	public void set_keys(Keyframe[] value) { }

	[FreeFunction("AnimationCurveBindings::AddKeySmoothTangents", HasExplicitThis = True, IsThreadSafe = True)]
	// RVA: 0x2C7DF90 Offset: 0x2C7C990 VA: 0x182C7DF90
	public int AddKey(float time, float value) { }

	// RVA: 0x2C7DF30 Offset: 0x2C7C930 VA: 0x182C7DF30
	public int AddKey(Keyframe key) { }

	[NativeMethod("AddKey", IsThreadSafe = True)]
	// RVA: 0x2C7DEE0 Offset: 0x2C7C8E0 VA: 0x182C7DEE0
	private int AddKey_Internal(Keyframe key) { }

	[FreeFunction("AnimationCurveBindings::MoveKey", HasExplicitThis = True, IsThreadSafe = True)]
	[NativeThrows]
	// RVA: 0x2C7EA70 Offset: 0x2C7D470 VA: 0x182C7EA70
	public int MoveKey(int index, Keyframe key) { }

	[FreeFunction("AnimationCurveBindings::ClearKeys", HasExplicitThis = True, IsThreadSafe = True)]
	// RVA: 0x2C7DFF0 Offset: 0x2C7C9F0 VA: 0x182C7DFF0
	public void ClearKeys() { }

	[NativeThrows]
	[FreeFunction("AnimationCurveBindings::RemoveKey", HasExplicitThis = True, IsThreadSafe = True)]
	// RVA: 0x2C7EAC0 Offset: 0x2C7D4C0 VA: 0x182C7EAC0
	public void RemoveKey(int index) { }

	// RVA: 0x2C7EC30 Offset: 0x2C7D630 VA: 0x182C7EC30
	public Keyframe get_Item(int index) { }

	[NativeMethod("GetKeyCount", IsThreadSafe = True)]
	// RVA: 0x2C7ECC0 Offset: 0x2C7D6C0 VA: 0x182C7ECC0
	public int get_length() { }

	[FreeFunction("AnimationCurveBindings::SetKeys", HasExplicitThis = True, IsThreadSafe = True)]
	// RVA: 0x2C7EB00 Offset: 0x2C7D500 VA: 0x182C7EB00
	private void SetKeys(Keyframe[] keys) { }

	[FreeFunction("AnimationCurveBindings::GetKey", HasExplicitThis = True, IsThreadSafe = True)]
	[NativeThrows]
	// RVA: 0x2C7E640 Offset: 0x2C7D040 VA: 0x182C7E640
	private Keyframe GetKey(int index) { }

	[FreeFunction("AnimationCurveBindings::GetKeys", HasExplicitThis = True, IsThreadSafe = True)]
	// RVA: 0x2C7E6B0 Offset: 0x2C7D0B0 VA: 0x182C7E6B0
	private Keyframe[] GetKeys() { }

	[FreeFunction("AnimationCurveBindings::GetHashCode", HasExplicitThis = True, IsThreadSafe = True)]
	// RVA: 0x2C7E5B0 Offset: 0x2C7CFB0 VA: 0x182C7E5B0 Slot: 2
	public override int GetHashCode() { }

	[FreeFunction("AnimationCurveBindings::SmoothTangents", HasExplicitThis = True, IsThreadSafe = True)]
	[NativeThrows]
	// RVA: 0x2C7EB50 Offset: 0x2C7D550 VA: 0x182C7EB50
	public void SmoothTangents(int index, float weight) { }

	// RVA: 0x2C7E810 Offset: 0x2C7D210 VA: 0x182C7E810
	public static AnimationCurve Linear(float timeStart, float valueStart, float timeEnd, float valueEnd) { }

	// RVA: 0x2C7E080 Offset: 0x2C7CA80 VA: 0x182C7E080
	public static AnimationCurve EaseInOut(float timeStart, float valueStart, float timeEnd, float valueEnd) { }

	[NativeMethod("SetPreInfinity", IsThreadSafe = True)]
	// RVA: 0x2C7ED40 Offset: 0x2C7D740 VA: 0x182C7ED40
	public void set_preWrapMode(WrapMode value) { }

	[NativeMethod("SetPostInfinity", IsThreadSafe = True)]
	// RVA: 0x2C7ED00 Offset: 0x2C7D700 VA: 0x182C7ED00
	public void set_postWrapMode(WrapMode value) { }

	// RVA: 0x2C7EBE0 Offset: 0x2C7D5E0 VA: 0x182C7EBE0
	public void .ctor(Keyframe[] keys) { }

	[RequiredByNativeCode]
	// RVA: 0x2C7EBA0 Offset: 0x2C7D5A0 VA: 0x182C7EBA0
	public void .ctor() { }

	// RVA: 0x2C7E340 Offset: 0x2C7CD40 VA: 0x182C7E340 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x2C7E260 Offset: 0x2C7CC60 VA: 0x182C7E260 Slot: 4
	public bool Equals(AnimationCurve other) { }

	// RVA: 0x2C7E030 Offset: 0x2C7CA30 VA: 0x182C7E030
	public void CopyFrom(AnimationCurve other) { }

	// RVA: 0x2C7DE90 Offset: 0x2C7C890 VA: 0x182C7DE90
	private int AddKey_Internal_Injected(ref Keyframe key) { }

	// RVA: 0x2C7EA20 Offset: 0x2C7D420 VA: 0x182C7EA20
	private int MoveKey_Injected(int index, ref Keyframe key) { }

	// RVA: 0x2C7E5F0 Offset: 0x2C7CFF0 VA: 0x182C7E5F0
	private void GetKey_Injected(int index, out Keyframe ret) { }
}

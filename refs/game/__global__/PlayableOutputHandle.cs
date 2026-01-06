public struct PlayableOutputHandle : IEquatable<PlayableOutputHandle> // TypeDefIndex: 12312
{
	// Fields
	internal IntPtr m_Handle; // 0x0
	internal uint m_Version; // 0x8
	private static readonly PlayableOutputHandle m_Null; // 0x0

	// Properties
	public static PlayableOutputHandle Null { get; }

	// Methods

	// RVA: 0x2CF5BE0 Offset: 0x2CF45E0 VA: 0x182CF5BE0
	public static PlayableOutputHandle get_Null() { }

	[VisibleToOtherModules]
	// RVA: -1 Offset: -1
	internal bool IsPlayableOutputOfType<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF24080 Offset: 0xF22A80 VA: 0x180F24080
	|-PlayableOutputHandle.IsPlayableOutputOfType<AnimationPlayableOutput>
	|-PlayableOutputHandle.IsPlayableOutputOfType<AudioPlayableOutput>
	|-PlayableOutputHandle.IsPlayableOutputOfType<ScriptPlayableOutput>
	|-PlayableOutputHandle.IsPlayableOutputOfType<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x2CF3BF0 Offset: 0x2CF25F0 VA: 0x182CF3BF0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2CF5C40 Offset: 0x2CF4640 VA: 0x182CF5C40
	public static bool op_Equality(PlayableOutputHandle lhs, PlayableOutputHandle rhs) { }

	// RVA: 0x2CF52A0 Offset: 0x2CF3CA0 VA: 0x182CF52A0 Slot: 0
	public override bool Equals(object p) { }

	// RVA: 0x2CF53C0 Offset: 0x2CF3DC0 VA: 0x182CF53C0 Slot: 4
	public bool Equals(PlayableOutputHandle other) { }

	// RVA: 0x2CF3870 Offset: 0x2CF2270 VA: 0x182CF3870
	internal static bool CompareVersion(PlayableOutputHandle lhs, PlayableOutputHandle rhs) { }

	[VisibleToOtherModules]
	// RVA: 0x2CF56C0 Offset: 0x2CF40C0 VA: 0x182CF56C0
	internal bool IsValid() { }

	[FreeFunction("PlayableOutputHandleBindings::GetPlayableOutputType", HasExplicitThis = True, ThrowsException = True)]
	// RVA: 0x2CF5490 Offset: 0x2CF3E90 VA: 0x182CF5490
	internal Type GetPlayableOutputType() { }

	[FreeFunction("PlayableOutputHandleBindings::SetReferenceObject", HasExplicitThis = True, ThrowsException = True)]
	// RVA: 0x2CF5890 Offset: 0x2CF4290 VA: 0x182CF5890
	internal void SetReferenceObject(Object target) { }

	[FreeFunction("PlayableOutputHandleBindings::SetUserData", HasExplicitThis = True, ThrowsException = True)]
	// RVA: 0x2CF5A50 Offset: 0x2CF4450 VA: 0x182CF5A50
	internal void SetUserData(Object target) { }

	[FreeFunction("PlayableOutputHandleBindings::GetSourcePlayable", HasExplicitThis = True, ThrowsException = True)]
	// RVA: 0x2CF5600 Offset: 0x2CF4000 VA: 0x182CF5600
	internal PlayableHandle GetSourcePlayable() { }

	[FreeFunction("PlayableOutputHandleBindings::SetSourcePlayable", HasExplicitThis = True, ThrowsException = True)]
	// RVA: 0x2CF5970 Offset: 0x2CF4370 VA: 0x182CF5970
	internal void SetSourcePlayable(PlayableHandle target, int port) { }

	[FreeFunction("PlayableOutputHandleBindings::GetSourceOutputPort", HasExplicitThis = True, ThrowsException = True)]
	// RVA: 0x2CF5540 Offset: 0x2CF3F40 VA: 0x182CF5540
	internal int GetSourceOutputPort() { }

	[FreeFunction("PlayableOutputHandleBindings::SetWeight", HasExplicitThis = True, ThrowsException = True)]
	// RVA: 0x2CF5B20 Offset: 0x2CF4520 VA: 0x182CF5B20
	internal void SetWeight(float weight) { }

	[FreeFunction("PlayableOutputHandleBindings::PushNotification", HasExplicitThis = True, ThrowsException = True)]
	// RVA: 0x2CF57A0 Offset: 0x2CF41A0 VA: 0x182CF57A0
	internal void PushNotification(PlayableHandle origin, INotification notification, object context) { }

	[FreeFunction("PlayableOutputHandleBindings::AddNotificationReceiver", HasExplicitThis = True, ThrowsException = True)]
	// RVA: 0x2CF5220 Offset: 0x2CF3C20 VA: 0x182CF5220
	internal void AddNotificationReceiver(INotificationReceiver receiver) { }

	// RVA: 0x2CF5BA0 Offset: 0x2CF45A0 VA: 0x182CF5BA0
	private static void .cctor() { }

	// RVA: 0x2CF5680 Offset: 0x2CF4080 VA: 0x182CF5680
	private static bool IsValid_Injected(ref PlayableOutputHandle _unity_self) { }

	// RVA: 0x2CF5450 Offset: 0x2CF3E50 VA: 0x182CF5450
	private static Type GetPlayableOutputType_Injected(ref PlayableOutputHandle _unity_self) { }

	// RVA: 0x2CF5840 Offset: 0x2CF4240 VA: 0x182CF5840
	private static void SetReferenceObject_Injected(ref PlayableOutputHandle _unity_self, Object target) { }

	// RVA: 0x2CF5A00 Offset: 0x2CF4400 VA: 0x182CF5A00
	private static void SetUserData_Injected(ref PlayableOutputHandle _unity_self, Object target) { }

	// RVA: 0x2CF55B0 Offset: 0x2CF3FB0 VA: 0x182CF55B0
	private static void GetSourcePlayable_Injected(ref PlayableOutputHandle _unity_self, out PlayableHandle ret) { }

	// RVA: 0x2CF5910 Offset: 0x2CF4310 VA: 0x182CF5910
	private static void SetSourcePlayable_Injected(ref PlayableOutputHandle _unity_self, ref PlayableHandle target, int port) { }

	// RVA: 0x2CF5500 Offset: 0x2CF3F00 VA: 0x182CF5500
	private static int GetSourceOutputPort_Injected(ref PlayableOutputHandle _unity_self) { }

	// RVA: 0x2CF5AD0 Offset: 0x2CF44D0 VA: 0x182CF5AD0
	private static void SetWeight_Injected(ref PlayableOutputHandle _unity_self, float weight) { }

	// RVA: 0x2CF5730 Offset: 0x2CF4130 VA: 0x182CF5730
	private static void PushNotification_Injected(ref PlayableOutputHandle _unity_self, ref PlayableHandle origin, INotification notification, object context) { }

	// RVA: 0x2CF51D0 Offset: 0x2CF3BD0 VA: 0x182CF51D0
	private static void AddNotificationReceiver_Injected(ref PlayableOutputHandle _unity_self, INotificationReceiver receiver) { }
}

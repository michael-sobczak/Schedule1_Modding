public struct PlayableHandle : IEquatable<PlayableHandle> // TypeDefIndex: 12309
{
	// Fields
	internal IntPtr m_Handle; // 0x0
	internal uint m_Version; // 0x8
	private static readonly PlayableHandle m_Null; // 0x0

	// Properties
	public static PlayableHandle Null { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal T GetObject<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF22E10 Offset: 0xF21810 VA: 0x180F22E10
	|-PlayableHandle.GetObject<object>
	*/

	[VisibleToOtherModules]
	// RVA: -1 Offset: -1
	internal bool IsPlayableOfType<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF22EE0 Offset: 0xF218E0 VA: 0x180F22EE0
	|-PlayableHandle.IsPlayableOfType<AnimationClipPlayable>
	|-PlayableHandle.IsPlayableOfType<AnimationLayerMixerPlayable>
	|-PlayableHandle.IsPlayableOfType<AnimationMixerPlayable>
	|-PlayableHandle.IsPlayableOfType<AnimationMotionXToDeltaPlayable>
	|-PlayableHandle.IsPlayableOfType<AnimationOffsetPlayable>
	|-PlayableHandle.IsPlayableOfType<AnimationPosePlayable>
	|-PlayableHandle.IsPlayableOfType<AnimationRemoveScalePlayable>
	|-PlayableHandle.IsPlayableOfType<AnimationScriptPlayable>
	|-PlayableHandle.IsPlayableOfType<AnimatorControllerPlayable>
	|-PlayableHandle.IsPlayableOfType<AudioClipPlayable>
	|-PlayableHandle.IsPlayableOfType<AudioMixerPlayable>
	|-PlayableHandle.IsPlayableOfType<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x2CF50F0 Offset: 0x2CF3AF0 VA: 0x182CF50F0
	public static PlayableHandle get_Null() { }

	// RVA: 0x2CF3F30 Offset: 0x2CF2930 VA: 0x182CF3F30
	internal Playable GetInput(int inputPort) { }

	// RVA: 0x2CF4A80 Offset: 0x2CF3480 VA: 0x182CF4A80
	internal bool SetInputWeight(int inputIndex, float weight) { }

	// RVA: 0x2CF3E70 Offset: 0x2CF2870 VA: 0x182CF3E70
	internal float GetInputWeight(int inputIndex) { }

	// RVA: 0x2CF5150 Offset: 0x2CF3B50 VA: 0x182CF5150
	public static bool op_Equality(PlayableHandle x, PlayableHandle y) { }

	// RVA: 0x2CF38C0 Offset: 0x2CF22C0 VA: 0x182CF38C0 Slot: 0
	public override bool Equals(object p) { }

	// RVA: 0x2CF39E0 Offset: 0x2CF23E0 VA: 0x182CF39E0 Slot: 4
	public bool Equals(PlayableHandle other) { }

	// RVA: 0x2CF3BF0 Offset: 0x2CF25F0 VA: 0x182CF3BF0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2CF3870 Offset: 0x2CF2270 VA: 0x182CF3870
	internal static bool CompareVersion(PlayableHandle lhs, PlayableHandle rhs) { }

	// RVA: 0x2CF35F0 Offset: 0x2CF1FF0 VA: 0x182CF35F0
	internal bool CheckInputBounds(int inputIndex) { }

	// RVA: 0x2CF3650 Offset: 0x2CF2050 VA: 0x182CF3650
	internal bool CheckInputBounds(int inputIndex, bool acceptAny) { }

	[VisibleToOtherModules]
	// RVA: 0x2CF4510 Offset: 0x2CF2F10 VA: 0x182CF4510
	internal bool IsValid() { }

	[VisibleToOtherModules]
	[FreeFunction("PlayableHandleBindings::GetPlayableType", HasExplicitThis = True, ThrowsException = True)]
	// RVA: 0x2CF40F0 Offset: 0x2CF2AF0 VA: 0x182CF40F0
	internal Type GetPlayableType() { }

	[FreeFunction("PlayableHandleBindings::SetScriptInstance", HasExplicitThis = True, ThrowsException = True)]
	[VisibleToOtherModules]
	// RVA: 0x2CF4D10 Offset: 0x2CF3710 VA: 0x182CF4D10
	internal void SetScriptInstance(object scriptInstance) { }

	[VisibleToOtherModules]
	[FreeFunction("PlayableHandleBindings::GetPlayState", HasExplicitThis = True, ThrowsException = True)]
	// RVA: 0x2CF4040 Offset: 0x2CF2A40 VA: 0x182CF4040
	internal PlayState GetPlayState() { }

	[VisibleToOtherModules]
	[FreeFunction("PlayableHandleBindings::Play", HasExplicitThis = True, ThrowsException = True)]
	// RVA: 0x2CF4670 Offset: 0x2CF3070 VA: 0x182CF4670
	internal void Play() { }

	[FreeFunction("PlayableHandleBindings::Pause", HasExplicitThis = True, ThrowsException = True)]
	[VisibleToOtherModules]
	// RVA: 0x2CF45C0 Offset: 0x2CF2FC0 VA: 0x182CF45C0
	internal void Pause() { }

	[FreeFunction("PlayableHandleBindings::SetSpeed", HasExplicitThis = True, ThrowsException = True)]
	[VisibleToOtherModules]
	// RVA: 0x2CF4DE0 Offset: 0x2CF37E0 VA: 0x182CF4DE0
	internal void SetSpeed(double value) { }

	[VisibleToOtherModules]
	[FreeFunction("PlayableHandleBindings::GetTime", HasExplicitThis = True, ThrowsException = True)]
	// RVA: 0x2CF43B0 Offset: 0x2CF2DB0 VA: 0x182CF43B0
	internal double GetTime() { }

	[VisibleToOtherModules]
	[FreeFunction("PlayableHandleBindings::SetTime", HasExplicitThis = True, ThrowsException = True)]
	// RVA: 0x2CF4F70 Offset: 0x2CF3970 VA: 0x182CF4F70
	internal void SetTime(double value) { }

	[FreeFunction("PlayableHandleBindings::IsDone", HasExplicitThis = True, ThrowsException = True)]
	[VisibleToOtherModules]
	// RVA: 0x2CF4460 Offset: 0x2CF2E60 VA: 0x182CF4460
	internal bool IsDone() { }

	[FreeFunction("PlayableHandleBindings::SetDone", HasExplicitThis = True, ThrowsException = True)]
	[VisibleToOtherModules]
	// RVA: 0x2CF4730 Offset: 0x2CF3130 VA: 0x182CF4730
	internal void SetDone(bool value) { }

	[VisibleToOtherModules]
	[FreeFunction("PlayableHandleBindings::GetDuration", HasExplicitThis = True, ThrowsException = True)]
	// RVA: 0x2CF3AB0 Offset: 0x2CF24B0 VA: 0x182CF3AB0
	internal double GetDuration() { }

	[VisibleToOtherModules]
	[FreeFunction("PlayableHandleBindings::SetDuration", HasExplicitThis = True, ThrowsException = True)]
	// RVA: 0x2CF4800 Offset: 0x2CF3200 VA: 0x182CF4800
	internal void SetDuration(double value) { }

	[FreeFunction("PlayableHandleBindings::SetPropagateSetTime", HasExplicitThis = True, ThrowsException = True)]
	[VisibleToOtherModules]
	// RVA: 0x2CF4C40 Offset: 0x2CF3640 VA: 0x182CF4C40
	internal void SetPropagateSetTime(bool value) { }

	[VisibleToOtherModules]
	[FreeFunction("PlayableHandleBindings::GetGraph", HasExplicitThis = True, ThrowsException = True)]
	// RVA: 0x2CF3B70 Offset: 0x2CF2570 VA: 0x182CF3B70
	internal PlayableGraph GetGraph() { }

	[VisibleToOtherModules]
	[FreeFunction("PlayableHandleBindings::GetInputCount", HasExplicitThis = True, ThrowsException = True)]
	// RVA: 0x2CF3C60 Offset: 0x2CF2660 VA: 0x182CF3C60
	internal int GetInputCount() { }

	[FreeFunction("PlayableHandleBindings::SetInputCount", HasExplicitThis = True, ThrowsException = True)]
	[VisibleToOtherModules]
	// RVA: 0x2CF48C0 Offset: 0x2CF32C0 VA: 0x182CF48C0
	internal void SetInputCount(int value) { }

	[VisibleToOtherModules]
	[FreeFunction("PlayableHandleBindings::SetInputWeight", HasExplicitThis = True, ThrowsException = True)]
	// RVA: 0x2CF4B60 Offset: 0x2CF3560 VA: 0x182CF4B60
	internal void SetInputWeight(PlayableHandle input, float weight) { }

	[VisibleToOtherModules]
	[FreeFunction("PlayableHandleBindings::GetPreviousTime", HasExplicitThis = True, ThrowsException = True)]
	// RVA: 0x2CF41A0 Offset: 0x2CF2BA0 VA: 0x182CF41A0
	internal double GetPreviousTime() { }

	[VisibleToOtherModules]
	[FreeFunction("PlayableHandleBindings::SetTraversalMode", HasExplicitThis = True, ThrowsException = True)]
	// RVA: 0x2CF5030 Offset: 0x2CF3A30 VA: 0x182CF5030
	internal void SetTraversalMode(PlayableTraversalMode mode) { }

	[VisibleToOtherModules]
	[FreeFunction("PlayableHandleBindings::GetTimeWrapMode", HasExplicitThis = True, ThrowsException = True)]
	// RVA: 0x2CF4300 Offset: 0x2CF2D00 VA: 0x182CF4300
	internal DirectorWrapMode GetTimeWrapMode() { }

	[FreeFunction("PlayableHandleBindings::SetTimeWrapMode", HasExplicitThis = True, ThrowsException = True)]
	[VisibleToOtherModules]
	// RVA: 0x2CF4EA0 Offset: 0x2CF38A0 VA: 0x182CF4EA0
	internal void SetTimeWrapMode(DirectorWrapMode mode) { }

	[FreeFunction("PlayableHandleBindings::GetScriptInstance", HasExplicitThis = True, ThrowsException = True)]
	// RVA: 0x2CF4250 Offset: 0x2CF2C50 VA: 0x182CF4250
	private object GetScriptInstance() { }

	[FreeFunction("PlayableHandleBindings::GetInputHandle", HasExplicitThis = True, ThrowsException = True)]
	// RVA: 0x2CF3D20 Offset: 0x2CF2720 VA: 0x182CF3D20
	private PlayableHandle GetInputHandle(int index) { }

	[FreeFunction("PlayableHandleBindings::SetInputWeightFromIndex", HasExplicitThis = True, ThrowsException = True)]
	// RVA: 0x2CF4990 Offset: 0x2CF3390 VA: 0x182CF4990
	private void SetInputWeightFromIndex(int index, float weight) { }

	[FreeFunction("PlayableHandleBindings::GetInputWeightFromIndex", HasExplicitThis = True, ThrowsException = True)]
	// RVA: 0x2CF3DF0 Offset: 0x2CF27F0 VA: 0x182CF3DF0
	private float GetInputWeightFromIndex(int index) { }

	// RVA: 0x2CF50B0 Offset: 0x2CF3AB0 VA: 0x182CF50B0
	private static void .cctor() { }

	// RVA: 0x2CF44D0 Offset: 0x2CF2ED0 VA: 0x182CF44D0
	private static bool IsValid_Injected(ref PlayableHandle _unity_self) { }

	// RVA: 0x2CF40B0 Offset: 0x2CF2AB0 VA: 0x182CF40B0
	private static Type GetPlayableType_Injected(ref PlayableHandle _unity_self) { }

	// RVA: 0x2CF4CC0 Offset: 0x2CF36C0 VA: 0x182CF4CC0
	private static void SetScriptInstance_Injected(ref PlayableHandle _unity_self, object scriptInstance) { }

	// RVA: 0x2CF4000 Offset: 0x2CF2A00 VA: 0x182CF4000
	private static PlayState GetPlayState_Injected(ref PlayableHandle _unity_self) { }

	// RVA: 0x2CF4630 Offset: 0x2CF3030 VA: 0x182CF4630
	private static void Play_Injected(ref PlayableHandle _unity_self) { }

	// RVA: 0x2CF4580 Offset: 0x2CF2F80 VA: 0x182CF4580
	private static void Pause_Injected(ref PlayableHandle _unity_self) { }

	// RVA: 0x2CF4D90 Offset: 0x2CF3790 VA: 0x182CF4D90
	private static void SetSpeed_Injected(ref PlayableHandle _unity_self, double value) { }

	// RVA: 0x2CF4370 Offset: 0x2CF2D70 VA: 0x182CF4370
	private static double GetTime_Injected(ref PlayableHandle _unity_self) { }

	// RVA: 0x2CF4F20 Offset: 0x2CF3920 VA: 0x182CF4F20
	private static void SetTime_Injected(ref PlayableHandle _unity_self, double value) { }

	// RVA: 0x2CF4420 Offset: 0x2CF2E20 VA: 0x182CF4420
	private static bool IsDone_Injected(ref PlayableHandle _unity_self) { }

	// RVA: 0x2CF46E0 Offset: 0x2CF30E0 VA: 0x182CF46E0
	private static void SetDone_Injected(ref PlayableHandle _unity_self, bool value) { }

	// RVA: 0x2CF3A70 Offset: 0x2CF2470 VA: 0x182CF3A70
	private static double GetDuration_Injected(ref PlayableHandle _unity_self) { }

	// RVA: 0x2CF47B0 Offset: 0x2CF31B0 VA: 0x182CF47B0
	private static void SetDuration_Injected(ref PlayableHandle _unity_self, double value) { }

	// RVA: 0x2CF4BF0 Offset: 0x2CF35F0 VA: 0x182CF4BF0
	private static void SetPropagateSetTime_Injected(ref PlayableHandle _unity_self, bool value) { }

	// RVA: 0x2CF3B20 Offset: 0x2CF2520 VA: 0x182CF3B20
	private static void GetGraph_Injected(ref PlayableHandle _unity_self, out PlayableGraph ret) { }

	// RVA: 0x2CF3C20 Offset: 0x2CF2620 VA: 0x182CF3C20
	private static int GetInputCount_Injected(ref PlayableHandle _unity_self) { }

	// RVA: 0x2CF4880 Offset: 0x2CF3280 VA: 0x182CF4880
	private static void SetInputCount_Injected(ref PlayableHandle _unity_self, int value) { }

	// RVA: 0x2CF4A20 Offset: 0x2CF3420 VA: 0x182CF4A20
	private static void SetInputWeight_Injected(ref PlayableHandle _unity_self, ref PlayableHandle input, float weight) { }

	// RVA: 0x2CF4160 Offset: 0x2CF2B60 VA: 0x182CF4160
	private static double GetPreviousTime_Injected(ref PlayableHandle _unity_self) { }

	// RVA: 0x2CF4FF0 Offset: 0x2CF39F0 VA: 0x182CF4FF0
	private static void SetTraversalMode_Injected(ref PlayableHandle _unity_self, PlayableTraversalMode mode) { }

	// RVA: 0x2CF42C0 Offset: 0x2CF2CC0 VA: 0x182CF42C0
	private static DirectorWrapMode GetTimeWrapMode_Injected(ref PlayableHandle _unity_self) { }

	// RVA: 0x2CF4E60 Offset: 0x2CF3860 VA: 0x182CF4E60
	private static void SetTimeWrapMode_Injected(ref PlayableHandle _unity_self, DirectorWrapMode mode) { }

	// RVA: 0x2CF4210 Offset: 0x2CF2C10 VA: 0x182CF4210
	private static object GetScriptInstance_Injected(ref PlayableHandle _unity_self) { }

	// RVA: 0x2CF3CD0 Offset: 0x2CF26D0 VA: 0x182CF3CD0
	private static void GetInputHandle_Injected(ref PlayableHandle _unity_self, int index, out PlayableHandle ret) { }

	// RVA: 0x2CF4940 Offset: 0x2CF3340 VA: 0x182CF4940
	private static void SetInputWeightFromIndex_Injected(ref PlayableHandle _unity_self, int index, float weight) { }

	// RVA: 0x2CF3DB0 Offset: 0x2CF27B0 VA: 0x182CF3DB0
	private static float GetInputWeightFromIndex_Injected(ref PlayableHandle _unity_self, int index) { }
}

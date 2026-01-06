public struct PlayableGraph // TypeDefIndex: 12307
{
	// Fields
	internal IntPtr m_Handle; // 0x0
	internal uint m_Version; // 0x8

	// Methods

	// RVA: 0x2CF3420 Offset: 0x2CF1E20 VA: 0x182CF3420
	public Playable GetRootPlayable(int index) { }

	// RVA: -1 Offset: -1
	public bool Connect<U, V>(U source, int sourceOutputPort, V destination, int destinationInputPort) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF22D00 Offset: 0xF21700 VA: 0x180F22D00
	|-PlayableGraph.Connect<Playable, ScriptPlayable<object>>
	|
	|-RVA: 0xF226C0 Offset: 0xF210C0 VA: 0x180F226C0
	|-PlayableGraph.Connect<Playable, AnimationLayerMixerPlayable>
	|
	|-RVA: 0xF227D0 Offset: 0xF211D0 VA: 0x180F227D0
	|-PlayableGraph.Connect<Playable, AnimationMixerPlayable>
	|
	|-RVA: 0xF228E0 Offset: 0xF212E0 VA: 0x180F228E0
	|-PlayableGraph.Connect<Playable, AnimationMotionXToDeltaPlayable>
	|
	|-RVA: 0xF229F0 Offset: 0xF213F0 VA: 0x180F229F0
	|-PlayableGraph.Connect<Playable, AnimationOffsetPlayable>
	|
	|-RVA: 0xF22B00 Offset: 0xF21500 VA: 0x180F22B00
	|-PlayableGraph.Connect<Playable, AnimationRemoveScalePlayable>
	|
	|-RVA: 0xF22C10 Offset: 0xF21610 VA: 0x180F22C10
	|-PlayableGraph.Connect<Playable, AudioMixerPlayable>
	|-PlayableGraph.Connect<Playable, Playable>
	|
	|-RVA: 0xF22520 Offset: 0xF20F20 VA: 0x180F22520
	|-PlayableGraph.Connect<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>
	*/

	// RVA: 0x2CF31D0 Offset: 0x2CF1BD0 VA: 0x182CF31D0
	public void Evaluate() { }

	// RVA: 0x2CF3510 Offset: 0x2CF1F10 VA: 0x182CF3510
	public bool IsValid() { }

	[FreeFunction("PlayableGraphBindings::IsPlaying", HasExplicitThis = True, ThrowsException = True)]
	// RVA: 0x2CF34D0 Offset: 0x2CF1ED0 VA: 0x182CF34D0
	public bool IsPlaying() { }

	[FreeFunction("PlayableGraphBindings::Evaluate", HasExplicitThis = True, ThrowsException = True)]
	// RVA: 0x2CF3180 Offset: 0x2CF1B80 VA: 0x182CF3180
	public void Evaluate(float deltaTime) { }

	[FreeFunction("PlayableGraphBindings::GetResolver", HasExplicitThis = True, ThrowsException = True)]
	// RVA: 0x2CF32F0 Offset: 0x2CF1CF0 VA: 0x182CF32F0
	public IExposedPropertyTable GetResolver() { }

	[FreeFunction("PlayableGraphBindings::GetPlayableCount", HasExplicitThis = True, ThrowsException = True)]
	// RVA: 0x2CF32B0 Offset: 0x2CF1CB0 VA: 0x182CF32B0
	public int GetPlayableCount() { }

	[FreeFunction("PlayableGraphBindings::GetRootPlayableCount", HasExplicitThis = True, ThrowsException = True)]
	// RVA: 0x2CF3330 Offset: 0x2CF1D30 VA: 0x182CF3330
	public int GetRootPlayableCount() { }

	[FreeFunction("PlayableGraphBindings::SynchronizeEvaluation", HasExplicitThis = True, ThrowsException = True)]
	// RVA: 0x2CF35A0 Offset: 0x2CF1FA0 VA: 0x182CF35A0
	internal void SynchronizeEvaluation(PlayableGraph playable) { }

	[FreeFunction("PlayableGraphBindings::CreatePlayableHandle", HasExplicitThis = True, ThrowsException = True)]
	// RVA: 0x2CF30D0 Offset: 0x2CF1AD0 VA: 0x182CF30D0
	internal PlayableHandle CreatePlayableHandle() { }

	[FreeFunction("PlayableGraphBindings::CreateScriptOutputInternal", HasExplicitThis = True, ThrowsException = True)]
	// RVA: 0x2CF3120 Offset: 0x2CF1B20 VA: 0x182CF3120
	internal bool CreateScriptOutputInternal(string name, out PlayableOutputHandle handle) { }

	[FreeFunction("PlayableGraphBindings::GetRootPlayableInternal", HasExplicitThis = True, ThrowsException = True)]
	// RVA: 0x2CF33C0 Offset: 0x2CF1DC0 VA: 0x182CF33C0
	internal PlayableHandle GetRootPlayableInternal(int index) { }

	[FreeFunction("PlayableGraphBindings::IsMatchFrameRateEnabled", HasExplicitThis = True, ThrowsException = True)]
	// RVA: 0x2CF3490 Offset: 0x2CF1E90 VA: 0x182CF3490
	internal bool IsMatchFrameRateEnabled() { }

	[FreeFunction("PlayableGraphBindings::GetFrameRate", HasExplicitThis = True, ThrowsException = True)]
	// RVA: 0x2CF3260 Offset: 0x2CF1C60 VA: 0x182CF3260
	internal FrameRate GetFrameRate() { }

	[FreeFunction("PlayableGraphBindings::ConnectInternal", HasExplicitThis = True, ThrowsException = True)]
	// RVA: 0x2CF3010 Offset: 0x2CF1A10 VA: 0x182CF3010
	private bool ConnectInternal(PlayableHandle source, int sourceOutputPort, PlayableHandle destination, int destinationInputPort) { }

	// RVA: 0x2CF3510 Offset: 0x2CF1F10 VA: 0x182CF3510
	private static bool IsValid_Injected(ref PlayableGraph _unity_self) { }

	// RVA: 0x2CF34D0 Offset: 0x2CF1ED0 VA: 0x182CF34D0
	private static bool IsPlaying_Injected(ref PlayableGraph _unity_self) { }

	// RVA: 0x2CF3180 Offset: 0x2CF1B80 VA: 0x182CF3180
	private static void Evaluate_Injected(ref PlayableGraph _unity_self, float deltaTime) { }

	// RVA: 0x2CF32F0 Offset: 0x2CF1CF0 VA: 0x182CF32F0
	private static IExposedPropertyTable GetResolver_Injected(ref PlayableGraph _unity_self) { }

	// RVA: 0x2CF32B0 Offset: 0x2CF1CB0 VA: 0x182CF32B0
	private static int GetPlayableCount_Injected(ref PlayableGraph _unity_self) { }

	// RVA: 0x2CF3330 Offset: 0x2CF1D30 VA: 0x182CF3330
	private static int GetRootPlayableCount_Injected(ref PlayableGraph _unity_self) { }

	// RVA: 0x2CF3550 Offset: 0x2CF1F50 VA: 0x182CF3550
	private static void SynchronizeEvaluation_Injected(ref PlayableGraph _unity_self, ref PlayableGraph playable) { }

	// RVA: 0x2CF3080 Offset: 0x2CF1A80 VA: 0x182CF3080
	private static void CreatePlayableHandle_Injected(ref PlayableGraph _unity_self, out PlayableHandle ret) { }

	// RVA: 0x2CF3120 Offset: 0x2CF1B20 VA: 0x182CF3120
	private static bool CreateScriptOutputInternal_Injected(ref PlayableGraph _unity_self, string name, out PlayableOutputHandle handle) { }

	// RVA: 0x2CF3370 Offset: 0x2CF1D70 VA: 0x182CF3370
	private static void GetRootPlayableInternal_Injected(ref PlayableGraph _unity_self, int index, out PlayableHandle ret) { }

	// RVA: 0x2CF3490 Offset: 0x2CF1E90 VA: 0x182CF3490
	private static bool IsMatchFrameRateEnabled_Injected(ref PlayableGraph _unity_self) { }

	// RVA: 0x2CF3210 Offset: 0x2CF1C10 VA: 0x182CF3210
	private static void GetFrameRate_Injected(ref PlayableGraph _unity_self, out FrameRate ret) { }

	// RVA: 0x2CF2FA0 Offset: 0x2CF19A0 VA: 0x182CF2FA0
	private static bool ConnectInternal_Injected(ref PlayableGraph _unity_self, ref PlayableHandle source, int sourceOutputPort, ref PlayableHandle destination, int destinationInputPort) { }
}

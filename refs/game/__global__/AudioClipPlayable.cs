public struct AudioClipPlayable : IPlayable, IEquatable<AudioClipPlayable> // TypeDefIndex: 18960
{
	// Fields
	private PlayableHandle m_Handle; // 0x0

	// Methods

	// RVA: 0x2C7A390 Offset: 0x2C78D90 VA: 0x182C7A390
	public static AudioClipPlayable Create(PlayableGraph graph, AudioClip clip, bool looping) { }

	// RVA: 0x2C7A2A0 Offset: 0x2C78CA0 VA: 0x182C7A2A0
	private static PlayableHandle CreateHandle(PlayableGraph graph, AudioClip clip, bool looping) { }

	// RVA: 0x2C7ACE0 Offset: 0x2C796E0 VA: 0x182C7ACE0
	internal void .ctor(PlayableHandle handle) { }

	// RVA: 0x11B2D20 Offset: 0x11B1720 VA: 0x1811B2D20 Slot: 4
	public PlayableHandle GetHandle() { }

	// RVA: 0x2C72550 Offset: 0x2C70F50 VA: 0x182C72550
	public static Playable op_Implicit(AudioClipPlayable playable) { }

	// RVA: 0x2C7ADC0 Offset: 0x2C797C0 VA: 0x182C7ADC0
	public static AudioClipPlayable op_Explicit(Playable playable) { }

	// RVA: 0x2C7A600 Offset: 0x2C79000 VA: 0x182C7A600 Slot: 5
	public bool Equals(AudioClipPlayable other) { }

	// RVA: 0x2C7AC00 Offset: 0x2C79600 VA: 0x182C7AC00
	internal void SetVolume(float value) { }

	// RVA: 0x2C7AAD0 Offset: 0x2C794D0 VA: 0x182C7AAD0
	internal void SetStereoPan(float value) { }

	// RVA: 0x2C7A950 Offset: 0x2C79350 VA: 0x182C7A950
	internal void SetSpatialBlend(float value) { }

	// RVA: 0x2C7A6F0 Offset: 0x2C790F0 VA: 0x182C7A6F0
	public void Seek(double startTime, double startDelay, double duration) { }

	[NativeThrows]
	// RVA: 0x2C7ABB0 Offset: 0x2C795B0 VA: 0x182C7ABB0
	private static void SetVolumeInternal(ref PlayableHandle hdl, float volume) { }

	[NativeThrows]
	// RVA: 0x2C7AA80 Offset: 0x2C79480 VA: 0x182C7AA80
	private static void SetStereoPanInternal(ref PlayableHandle hdl, float stereoPan) { }

	[NativeThrows]
	// RVA: 0x2C7A900 Offset: 0x2C79300 VA: 0x182C7A900
	private static void SetSpatialBlendInternal(ref PlayableHandle hdl, float spatialBlend) { }

	[NativeThrows]
	// RVA: 0x2C7AA30 Offset: 0x2C79430 VA: 0x182C7AA30
	private static void SetStartDelayInternal(ref PlayableHandle hdl, double delay) { }

	[NativeThrows]
	// RVA: 0x2C7A8B0 Offset: 0x2C792B0 VA: 0x182C7A8B0
	private static void SetPauseDelayInternal(ref PlayableHandle hdl, double delay) { }

	[NativeThrows]
	// RVA: 0x2C7A680 Offset: 0x2C79080 VA: 0x182C7A680
	private static bool InternalCreateAudioClipPlayable(ref PlayableGraph graph, AudioClip clip, bool looping, ref PlayableHandle handle) { }
}

public struct AudioMixerPlayable : IPlayable, IEquatable<AudioMixerPlayable> // TypeDefIndex: 18963
{
	// Fields
	private PlayableHandle m_Handle; // 0x0

	// Methods

	// RVA: 0x2C7B270 Offset: 0x2C79C70 VA: 0x182C7B270
	public static AudioMixerPlayable Create(PlayableGraph graph, int inputCount = 0, bool normalizeInputVolumes = False) { }

	// RVA: 0x2C7B160 Offset: 0x2C79B60 VA: 0x182C7B160
	private static PlayableHandle CreateHandle(PlayableGraph graph, int inputCount, bool normalizeInputVolumes) { }

	// RVA: 0x2C7B4C0 Offset: 0x2C79EC0 VA: 0x182C7B4C0
	internal void .ctor(PlayableHandle handle) { }

	// RVA: 0x11B2D20 Offset: 0x11B1720 VA: 0x1811B2D20 Slot: 4
	public PlayableHandle GetHandle() { }

	// RVA: 0x2C72550 Offset: 0x2C70F50 VA: 0x182C72550
	public static Playable op_Implicit(AudioMixerPlayable playable) { }

	// RVA: 0x2C7B440 Offset: 0x2C79E40 VA: 0x182C7B440 Slot: 5
	public bool Equals(AudioMixerPlayable other) { }

	[NativeThrows]
	// RVA: 0x2C7B100 Offset: 0x2C79B00 VA: 0x182C7B100
	private static bool CreateAudioMixerPlayableInternal(ref PlayableGraph graph, bool normalizeInputVolumes, ref PlayableHandle handle) { }
}

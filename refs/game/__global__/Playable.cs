public struct Playable : IPlayable, IEquatable<Playable> // TypeDefIndex: 12299
{
	// Fields
	private PlayableHandle m_Handle; // 0x0
	private static readonly Playable m_NullPlayable; // 0x0

	// Properties
	public static Playable Null { get; }

	// Methods

	// RVA: 0x2CF61C0 Offset: 0x2CF4BC0 VA: 0x182CF61C0
	public static Playable get_Null() { }

	// RVA: 0x2CF5EA0 Offset: 0x2CF48A0 VA: 0x182CF5EA0
	public static Playable Create(PlayableGraph graph, int inputCount = 0) { }

	[VisibleToOtherModules]
	// RVA: 0x4944D0 Offset: 0x492ED0 VA: 0x1804944D0
	internal void .ctor(PlayableHandle handle) { }

	// RVA: 0x11B2D20 Offset: 0x11B1720 VA: 0x1811B2D20 Slot: 4
	public PlayableHandle GetHandle() { }

	// RVA: -1 Offset: -1
	public bool IsPlayableOfType<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF242F0 Offset: 0xF22CF0 VA: 0x180F242F0
	|-Playable.IsPlayableOfType<AudioClipPlayable>
	|-Playable.IsPlayableOfType<AudioMixerPlayable>
	|
	|-RVA: 0xF24410 Offset: 0xF22E10 VA: 0x180F24410
	|-Playable.IsPlayableOfType<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: 0x2CF6050 Offset: 0x2CF4A50 VA: 0x182CF6050
	public Type GetPlayableType() { }

	// RVA: 0x2CF5F70 Offset: 0x2CF4970 VA: 0x182CF5F70 Slot: 5
	public bool Equals(Playable other) { }

	// RVA: 0x2CF6120 Offset: 0x2CF4B20 VA: 0x182CF6120
	private static void .cctor() { }
}

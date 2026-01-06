public struct PlayableOutput : IPlayableOutput, IEquatable<PlayableOutput> // TypeDefIndex: 12310
{
	// Fields
	private PlayableOutputHandle m_Handle; // 0x0
	private static readonly PlayableOutput m_NullPlayableOutput; // 0x0

	// Properties
	public static PlayableOutput Null { get; }

	// Methods

	// RVA: 0x2CF5E40 Offset: 0x2CF4840 VA: 0x182CF5E40
	public static PlayableOutput get_Null() { }

	[VisibleToOtherModules]
	// RVA: 0x4944D0 Offset: 0x492ED0 VA: 0x1804944D0
	internal void .ctor(PlayableOutputHandle handle) { }

	// RVA: 0x11B2D20 Offset: 0x11B1720 VA: 0x1811B2D20 Slot: 4
	public PlayableOutputHandle GetHandle() { }

	// RVA: -1 Offset: -1
	public bool IsPlayableOutputOfType<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF24120 Offset: 0xF22B20 VA: 0x180F24120
	|-PlayableOutput.IsPlayableOutputOfType<AudioPlayableOutput>
	|
	|-RVA: 0xF24240 Offset: 0xF22C40 VA: 0x180F24240
	|-PlayableOutput.IsPlayableOutputOfType<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: 0x2CF5CC0 Offset: 0x2CF46C0 VA: 0x182CF5CC0 Slot: 5
	public bool Equals(PlayableOutput other) { }

	// RVA: 0x2CF5DA0 Offset: 0x2CF47A0 VA: 0x182CF5DA0
	private static void .cctor() { }
}

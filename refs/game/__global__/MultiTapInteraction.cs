public class MultiTapInteraction : IInputInteraction<float>, IInputInteraction // TypeDefIndex: 7790
{
	// Fields
	[Tooltip("The maximum time (in seconds) allowed to elapse between pressing and releasing a control for it to register as a tap.")]
	public float tapTime; // 0x10
	[Tooltip("The maximum delay (in seconds) allowed between each tap. If this time is exceeded, the multi-tap is canceled.")]
	public float tapDelay; // 0x14
	[Tooltip("How many taps need to be performed in succession. Two means double-tap, three means triple-tap, and so on.")]
	public int tapCount; // 0x18
	public float pressPoint; // 0x1C
	private MultiTapInteraction.TapPhase m_CurrentTapPhase; // 0x20
	private int m_CurrentTapCount; // 0x24
	private double m_CurrentTapStartTime; // 0x28
	private double m_LastTapReleaseTime; // 0x30

	// Properties
	private float tapTimeOrDefault { get; }
	internal float tapDelayOrDefault { get; }
	private float pressPointOrDefault { get; }
	private float releasePointOrDefault { get; }

	// Methods

	// RVA: 0x2789CF0 Offset: 0x27886F0 VA: 0x182789CF0
	private float get_tapTimeOrDefault() { }

	// RVA: 0x2789C80 Offset: 0x2788680 VA: 0x182789C80
	internal float get_tapDelayOrDefault() { }

	// RVA: 0x2789BA0 Offset: 0x27885A0 VA: 0x182789BA0
	private float get_pressPointOrDefault() { }

	// RVA: 0x2789C00 Offset: 0x2788600 VA: 0x182789C00
	private float get_releasePointOrDefault() { }

	// RVA: 0x27898F0 Offset: 0x27882F0 VA: 0x1827898F0 Slot: 4
	public void Process(ref InputInteractionContext context) { }

	// RVA: 0x2789B80 Offset: 0x2788580 VA: 0x182789B80 Slot: 5
	public void Reset() { }

	// RVA: 0x2789B90 Offset: 0x2788590 VA: 0x182789B90
	public void .ctor() { }
}

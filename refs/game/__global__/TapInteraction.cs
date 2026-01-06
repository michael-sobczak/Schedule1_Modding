public class TapInteraction : IInputInteraction // TypeDefIndex: 7794
{
	// Fields
	public float duration; // 0x10
	public float pressPoint; // 0x14
	private double m_TapStartTime; // 0x18
	private bool canceledFromTimerExpired; // 0x20

	// Properties
	private float durationOrDefault { get; }
	private float pressPointOrDefault { get; }
	private float releasePointOrDefault { get; }

	// Methods

	// RVA: 0x278ACD0 Offset: 0x27896D0 VA: 0x18278ACD0
	private float get_durationOrDefault() { }

	// RVA: 0x278AD40 Offset: 0x2789740 VA: 0x18278AD40
	private float get_pressPointOrDefault() { }

	// RVA: 0x278ADA0 Offset: 0x27897A0 VA: 0x18278ADA0
	private float get_releasePointOrDefault() { }

	// RVA: 0x278AB50 Offset: 0x2789550 VA: 0x18278AB50 Slot: 4
	public void Process(ref InputInteractionContext context) { }

	// RVA: 0x277B050 Offset: 0x2779A50 VA: 0x18277B050 Slot: 5
	public void Reset() { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }
}

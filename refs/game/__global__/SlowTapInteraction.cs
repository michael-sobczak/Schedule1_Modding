public class SlowTapInteraction : IInputInteraction // TypeDefIndex: 7793
{
	// Fields
	public float duration; // 0x10
	public float pressPoint; // 0x14
	private double m_SlowTapStartTime; // 0x18

	// Properties
	private float durationOrDefault { get; }
	private float pressPointOrDefault { get; }

	// Methods

	// RVA: 0x278A960 Offset: 0x2789360 VA: 0x18278A960
	private float get_durationOrDefault() { }

	// RVA: 0x278A9D0 Offset: 0x27893D0 VA: 0x18278A9D0
	private float get_pressPointOrDefault() { }

	// RVA: 0x278A7B0 Offset: 0x27891B0 VA: 0x18278A7B0 Slot: 4
	public void Process(ref InputInteractionContext context) { }

	// RVA: 0x277B050 Offset: 0x2779A50 VA: 0x18277B050 Slot: 5
	public void Reset() { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }
}

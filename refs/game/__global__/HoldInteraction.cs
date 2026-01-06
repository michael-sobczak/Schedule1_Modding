public class HoldInteraction : IInputInteraction // TypeDefIndex: 7788
{
	// Fields
	public float duration; // 0x10
	public float pressPoint; // 0x14
	private double m_TimePressed; // 0x18

	// Properties
	private float durationOrDefault { get; }
	private float pressPointOrDefault { get; }

	// Methods

	// RVA: 0x277B060 Offset: 0x2779A60 VA: 0x18277B060
	private float get_durationOrDefault() { }

	// RVA: 0x277B0D0 Offset: 0x2779AD0 VA: 0x18277B0D0
	private float get_pressPointOrDefault() { }

	// RVA: 0x277AF10 Offset: 0x2779910 VA: 0x18277AF10 Slot: 4
	public void Process(ref InputInteractionContext context) { }

	// RVA: 0x277B050 Offset: 0x2779A50 VA: 0x18277B050 Slot: 5
	public void Reset() { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }
}

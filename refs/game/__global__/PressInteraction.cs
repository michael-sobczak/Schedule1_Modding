public class PressInteraction : IInputInteraction // TypeDefIndex: 7791
{
	// Fields
	[Tooltip("The amount of actuation a control requires before being considered pressed. If not set, default to 'Default Press Point' in the global input settings.")]
	public float pressPoint; // 0x10
	[Tooltip("Determines how button presses trigger the action. By default (PressOnly), the action is performed on press. With ReleaseOnly, the action is performed on release. With PressAndRelease, the action is performed on press and release.")]
	public PressBehavior behavior; // 0x14
	private bool m_WaitingForRelease; // 0x18

	// Properties
	private float pressPointOrDefault { get; }
	private float releasePointOrDefault { get; }

	// Methods

	// RVA: 0x2789F20 Offset: 0x2788920 VA: 0x182789F20
	private float get_pressPointOrDefault() { }

	// RVA: 0x2789F80 Offset: 0x2788980 VA: 0x182789F80
	private float get_releasePointOrDefault() { }

	// RVA: 0x2789D60 Offset: 0x2788760 VA: 0x182789D60 Slot: 4
	public void Process(ref InputInteractionContext context) { }

	// RVA: 0x4C55E0 Offset: 0x4C3FE0 VA: 0x1804C55E0 Slot: 5
	public void Reset() { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }
}

public struct ScriptPlayableOutput : IPlayableOutput // TypeDefIndex: 12315
{
	// Fields
	private PlayableOutputHandle m_Handle; // 0x0

	// Properties
	public static ScriptPlayableOutput Null { get; }

	// Methods

	// RVA: 0x2CF9160 Offset: 0x2CF7B60 VA: 0x182CF9160
	public static ScriptPlayableOutput Create(PlayableGraph graph, string name) { }

	// RVA: 0x2CF9280 Offset: 0x2CF7C80 VA: 0x182CF9280
	internal void .ctor(PlayableOutputHandle handle) { }

	// RVA: 0x2CF93B0 Offset: 0x2CF7DB0 VA: 0x182CF93B0
	public static ScriptPlayableOutput get_Null() { }

	// RVA: 0x11B2D20 Offset: 0x11B1720 VA: 0x1811B2D20 Slot: 4
	public PlayableOutputHandle GetHandle() { }

	// RVA: 0x2CF9470 Offset: 0x2CF7E70 VA: 0x182CF9470
	public static PlayableOutput op_Implicit(ScriptPlayableOutput output) { }
}

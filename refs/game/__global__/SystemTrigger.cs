public class SystemTrigger // TypeDefIndex: 732
{
	// Fields
	public Conditions Conditions; // 0x10
	[Header("True")]
	public VariableSetter[] onEvaluateTrueVariableSetters; // 0x18
	public QuestStateSetter[] onEvaluateTrueQuestSetters; // 0x20
	public UnityEvent onEvaluateTrue; // 0x28
	[Header("False")]
	public VariableSetter[] onEvaluateFalseVariableSetters; // 0x30
	public QuestStateSetter[] onEvaluateFalseQuestSetters; // 0x38
	public UnityEvent onEvaluateFalse; // 0x40

	// Methods

	// RVA: 0xAE6530 Offset: 0xAE4F30 VA: 0x180AE6530
	public bool Trigger() { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }
}

public class NumberVariable : Variable<float> // TypeDefIndex: 613
{
	// Methods

	// RVA: 0xA9DD80 Offset: 0xA9C780 VA: 0x180A9DD80
	public void .ctor(string name, EVariableReplicationMode replicationMode, bool persistent, EVariableMode mode, Player owner, float value) { }

	// RVA: 0xA9DD30 Offset: 0xA9C730 VA: 0x180A9DD30 Slot: 8
	public override bool TryDeserialize(string valueString, out float value) { }

	// RVA: 0xA9DB50 Offset: 0xA9C550 VA: 0x180A9DB50 Slot: 7
	public override bool EvaluateCondition(Condition.EConditionType operation, string value) { }
}

public class BoolVariable : Variable<bool> // TypeDefIndex: 608
{
	// Methods

	// RVA: 0xA96360 Offset: 0xA94D60 VA: 0x180A96360
	public void .ctor(string name, EVariableReplicationMode replicationMode, bool persistent, EVariableMode mode, Player owner, bool value) { }

	// RVA: 0xA962B0 Offset: 0xA94CB0 VA: 0x180A962B0 Slot: 8
	public override bool TryDeserialize(string valueString, out bool value) { }

	// RVA: 0xA96170 Offset: 0xA94B70 VA: 0x180A96170 Slot: 7
	public override bool EvaluateCondition(Condition.EConditionType operation, string value) { }
}

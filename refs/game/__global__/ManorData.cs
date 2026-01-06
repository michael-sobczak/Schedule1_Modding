public class ManorData : PropertyData // TypeDefIndex: 1052
{
	// Fields
	public Manor.EManorState ManorState; // 0x58
	public int DaysSinceStateChange; // 0x5C
	public bool TunnelDug; // 0x60

	// Methods

	// RVA: 0x5E0AC0 Offset: 0x5DF4C0 VA: 0x1805E0AC0
	public void .ctor(string propertyCode, bool isOwned, bool[] switchStates, bool[] toggleableStates, DynamicSaveData[] employees, DynamicSaveData[] objects, Manor.EManorState state, int daysSinceStateChange, bool tunnelDug) { }
}

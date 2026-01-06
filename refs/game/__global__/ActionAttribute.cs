public class ActionAttribute : DTAttribute // TypeDefIndex: 10383
{
	// Fields
	public ActionAttribute.ActionEnum Action; // 0x20
	public ActionAttribute.ActionPositionEnum Position; // 0x24
	public object ActionData; // 0x28
	private MethodInfo mCallback; // 0x30

	// Methods

	// RVA: 0x4896A0 Offset: 0x4880A0 VA: 0x1804896A0
	protected void .ctor(string actionData, ActionAttribute.ActionEnum action = 7) { }

	// RVA: 0x489470 Offset: 0x487E70 VA: 0x180489470
	public void Callback(object classInstance) { }
}

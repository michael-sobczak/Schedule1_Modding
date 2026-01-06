public class ActionList // TypeDefIndex: 8
{
	// Fields
	private readonly List<Action> list; // 0x10

	// Methods

	// RVA: 0x554CA0 Offset: 0x5536A0 VA: 0x180554CA0
	public void .ctor() { }

	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	public List<Action> GetInvocationList() { }

	// RVA: 0x554BA0 Offset: 0x5535A0 VA: 0x180554BA0
	public void InvokeAll() { }

	// RVA: 0x554B40 Offset: 0x553540 VA: 0x180554B40
	public void Clear() { }

	// RVA: 0x554A90 Offset: 0x553490 VA: 0x180554A90
	private void Add(Action action) { }

	// RVA: 0x554C40 Offset: 0x553640 VA: 0x180554C40
	private void Remove(Action action) { }

	// RVA: 0x554D20 Offset: 0x553720 VA: 0x180554D20
	public static ActionList op_Addition(ActionList list, Action action) { }

	// RVA: 0x554DE0 Offset: 0x5537E0 VA: 0x180554DE0
	public static ActionList op_Subtraction(ActionList list, Action action) { }
}

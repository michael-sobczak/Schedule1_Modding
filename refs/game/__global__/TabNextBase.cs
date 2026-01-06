public abstract class TabNextBase : MonoBehaviour // TypeDefIndex: 18026
{
	// Fields
	public Selectable Next; // 0x20
	public Selectable Previous; // 0x28
	protected IInputField input; // 0x30
	protected IInputField nextInput; // 0x38
	protected IInputField previousInput; // 0x40

	// Methods

	// RVA: 0x443360 Offset: 0x441D60 VA: 0x180443360 Slot: 4
	protected virtual void Start() { }

	// RVA: 0x443190 Offset: 0x441B90 VA: 0x180443190 Slot: 5
	protected virtual void Select(Selectable selectable) { }

	// RVA: 0x443470 Offset: 0x441E70 VA: 0x180443470
	protected bool TryGetInputField(Selectable selectable, out IInputField field) { }

	// RVA: 0x4430C0 Offset: 0x441AC0 VA: 0x1804430C0
	protected IInputField GetInputField(Selectable selectable) { }

	// RVA: 0x443070 Offset: 0x441A70 VA: 0x180443070 Slot: 6
	public virtual void Copy(TabNextBase other) { }

	// RVA: 0x43CCF0 Offset: 0x43B6F0 VA: 0x18043CCF0
	protected void .ctor() { }
}

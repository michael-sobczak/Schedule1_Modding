public abstract class FormElement : MonoBehaviour // TypeDefIndex: 17983
{
	// Fields
	protected FeedbackForm Form; // 0x20

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	protected abstract void FormOpened();

	// RVA: -1 Offset: -1 Slot: 5
	protected abstract void FormSubmitted();

	// RVA: -1 Offset: -1 Slot: 6
	protected abstract void FormClosed();

	// RVA: 0x43F080 Offset: 0x43DA80 VA: 0x18043F080 Slot: 7
	public virtual void Awake() { }

	// RVA: 0x43CCF0 Offset: 0x43B6F0 VA: 0x18043CCF0
	protected void .ctor() { }
}

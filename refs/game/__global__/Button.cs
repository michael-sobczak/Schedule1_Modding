public class Button : Selectable, IPointerClickHandler, IEventSystemHandler, ISubmitHandler // TypeDefIndex: 16372
{
	// Fields
	[SerializeField]
	[FormerlySerializedAs("onClick")]
	private Button.ButtonClickedEvent m_OnClick; // 0x100

	// Properties
	public Button.ButtonClickedEvent onClick { get; set; }

	// Methods

	// RVA: 0x2D8D9D0 Offset: 0x2D8C3D0 VA: 0x182D8D9D0
	protected void .ctor() { }

	// RVA: 0x516250 Offset: 0x514C50 VA: 0x180516250
	public Button.ButtonClickedEvent get_onClick() { }

	// RVA: 0x51DD20 Offset: 0x51C720 VA: 0x18051DD20
	public void set_onClick(Button.ButtonClickedEvent value) { }

	// RVA: 0x2D8D940 Offset: 0x2D8C340 VA: 0x182D8D940
	private void Press() { }

	// RVA: 0x2D8D830 Offset: 0x2D8C230 VA: 0x182D8D830 Slot: 41
	public virtual void OnPointerClick(PointerEventData eventData) { }

	// RVA: 0x2D8D860 Offset: 0x2D8C260 VA: 0x182D8D860 Slot: 42
	public virtual void OnSubmit(BaseEventData eventData) { }

	[IteratorStateMachine(typeof(Button.<OnFinishSubmit>d__9))]
	// RVA: 0x2D8D7C0 Offset: 0x2D8C1C0 VA: 0x182D8D7C0
	private IEnumerator OnFinishSubmit() { }
}

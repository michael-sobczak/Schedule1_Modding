public class SavePoint : MonoBehaviour // TypeDefIndex: 872
{
	// Fields
	public const float SAVE_COOLDOWN = 60;
	public InteractableObject IntObj; // 0x20
	public UnityEvent onSaveStart; // 0x28
	public UnityEvent onSaveComplete; // 0x30

	// Methods

	// RVA: 0x5CA0B0 Offset: 0x5C8AB0 VA: 0x1805CA0B0
	public void Awake() { }

	// RVA: 0x5CA5D0 Offset: 0x5C8FD0 VA: 0x1805CA5D0
	public void Hovered() { }

	// RVA: 0x5CA3F0 Offset: 0x5C8DF0 VA: 0x1805CA3F0
	private bool CanSave(out string reason) { }

	// RVA: 0x5CA790 Offset: 0x5C9190 VA: 0x1805CA790
	public void Interacted() { }

	// RVA: 0x5CA870 Offset: 0x5C9270 VA: 0x1805CA870
	private void Save() { }

	// RVA: 0x5CA850 Offset: 0x5C9250 VA: 0x1805CA850
	public void OnSaveStart() { }

	// RVA: 0x5CA830 Offset: 0x5C9230 VA: 0x1805CA830
	public void OnSaveComplete() { }

	// RVA: 0x43CCF0 Offset: 0x43B6F0 VA: 0x18043CCF0
	public void .ctor() { }
}

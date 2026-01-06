public class BaseCharacterCreatorField : MonoBehaviour // TypeDefIndex: 2975
{
	// Fields
	public string PropertyName; // 0x20
	public CharacterCreator.ECategory Category; // 0x28
	private CharacterCreator Creator; // 0x30

	// Methods

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 4
	protected virtual void Awake() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 5
	protected virtual void Start() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 6
	public virtual void ApplyValue() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 7
	public virtual void WriteValue(bool applyValue = True) { }

	// RVA: 0x43CCF0 Offset: 0x43B6F0 VA: 0x18043CCF0
	public void .ctor() { }
}

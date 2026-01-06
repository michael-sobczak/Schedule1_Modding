public class AvatarEquippable : MonoBehaviour // TypeDefIndex: 3152
{
	// Fields
	[Header("Settings")]
	public Transform AlignmentPoint; // 0x20
	[Range(0, 1)]
	public float Suspiciousness; // 0x28
	public AvatarEquippable.EHand Hand; // 0x2C
	public AvatarEquippable.ETriggerType TriggerType; // 0x30
	public string AnimationTrigger; // 0x38
	public string AssetPath; // 0x40
	protected Avatar avatar; // 0x48

	// Methods

	[Button]
	// RVA: 0x9AE190 Offset: 0x9ACB90 VA: 0x1809AE190
	public void RecalculateAssetPath() { }

	// RVA: 0x9ADA50 Offset: 0x9AC450 VA: 0x1809ADA50 Slot: 4
	protected virtual void Awake() { }

	// RVA: 0x9ADB10 Offset: 0x9AC510 VA: 0x1809ADB10 Slot: 5
	public virtual void Equip(Avatar _avatar) { }

	// RVA: 0x9ADD00 Offset: 0x9AC700 VA: 0x1809ADD00 Slot: 6
	public virtual void InitializeAnimation() { }

	// RVA: 0x9AE670 Offset: 0x9AD070 VA: 0x1809AE670 Slot: 7
	public virtual void Unequip() { }

	// RVA: 0x9ADD70 Offset: 0x9AC770 VA: 0x1809ADD70
	private void PositionAnimationModel() { }

	// RVA: 0x9AE530 Offset: 0x9ACF30 VA: 0x1809AE530
	protected void SetTrigger(string anim) { }

	// RVA: 0x9AE3E0 Offset: 0x9ACDE0 VA: 0x1809AE3E0
	protected void SetBool(string anim, bool val) { }

	// RVA: 0x9AE2A0 Offset: 0x9ACCA0 VA: 0x1809AE2A0
	protected void ResetTrigger(string anim) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 8
	public virtual void ReceiveMessage(string message, object parameter) { }

	// RVA: 0x9AE700 Offset: 0x9AD100 VA: 0x1809AE700
	public void .ctor() { }
}

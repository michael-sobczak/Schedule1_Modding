public class Moveable : Clickable // TypeDefIndex: 775
{
	// Fields
	protected Vector3 clickOffset; // 0x50
	protected float clickDist; // 0x5C
	[Header("Bounds")]
	[SerializeField]
	protected float yMax; // 0x60
	[SerializeField]
	protected float yMin; // 0x64

	// Methods

	// RVA: 0x58F520 Offset: 0x58DF20 VA: 0x18058F520 Slot: 6
	public override void StartClick(RaycastHit hit) { }

	// RVA: 0x58F840 Offset: 0x58E240 VA: 0x18058F840 Slot: 8
	protected virtual void Update() { }

	// RVA: 0x5870D0 Offset: 0x585AD0 VA: 0x1805870D0 Slot: 7
	public override void EndClick() { }

	// RVA: 0x58FB20 Offset: 0x58E520 VA: 0x18058FB20
	public void .ctor() { }
}

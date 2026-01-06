public abstract class ProductVisualsSetter : MonoBehaviour // TypeDefIndex: 2509
{
	// Fields
	public Transform VisualsContainer; // 0x20

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void ApplyVisuals(ProductDefinition productDefinition);

	// RVA: 0x8B8830 Offset: 0x8B7230 VA: 0x1808B8830
	public void ApplyVisuals(ProductItemInstance productInstance) { }

	// RVA: 0x8B8920 Offset: 0x8B7320 VA: 0x1808B8920
	public void ResetVisuals() { }

	// RVA: -1 Offset: -1
	protected bool TryCastProductDefinition<T>(ProductDefinition definition, out T castedDefinition) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF27800 Offset: 0xF26200 VA: 0x180F27800
	|-ProductVisualsSetter.TryCastProductDefinition<object>
	*/

	// RVA: 0x43CCF0 Offset: 0x43B6F0 VA: 0x18043CCF0
	protected void .ctor() { }
}

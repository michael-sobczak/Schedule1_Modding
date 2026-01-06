public class CustomerAffinityData // TypeDefIndex: 1501
{
	// Fields
	[Header("Product Affinities - How much the customer likes each product type. -1 = hates, 0 = neutral, 1 = loves.")]
	public List<ProductTypeAffinity> ProductAffinities; // 0x10

	// Methods

	// RVA: 0x6CFF80 Offset: 0x6CE980 VA: 0x1806CFF80
	public void CopyTo(CustomerAffinityData data) { }

	// RVA: 0x6D0280 Offset: 0x6CEC80 VA: 0x1806D0280
	public float GetAffinity(EDrugType type) { }

	// RVA: 0x6D03F0 Offset: 0x6CEDF0 VA: 0x1806D03F0
	public void .ctor() { }
}

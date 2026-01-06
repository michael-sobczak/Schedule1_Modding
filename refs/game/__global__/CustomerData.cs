public class CustomerData : ScriptableObject // TypeDefIndex: 1502
{
	// Fields
	public CustomerAffinityData DefaultAffinityData; // 0x18
	[Header("Preferred Properties - Properties the customer prefers in a product.")]
	public List<Effect> PreferredProperties; // 0x20
	[Header("Spending Behaviour")]
	public float MinWeeklySpend; // 0x28
	public float MaxWeeklySpend; // 0x2C
	[Range(0, 7)]
	public int MinOrdersPerWeek; // 0x30
	[Range(0, 7)]
	public int MaxOrdersPerWeek; // 0x34
	[Header("Timing Settings")]
	public int OrderTime; // 0x38
	public EDay PreferredOrderDay; // 0x3C
	[Header("Standards")]
	public ECustomerStandard Standards; // 0x40
	[Header("Direct approaching")]
	public bool CanBeDirectlyApproached; // 0x44
	public bool GuaranteeFirstSampleSuccess; // 0x45
	[Tooltip("The average relationship of mutual customers to provide a 50% chance of success")]
	[Range(0, 5)]
	public float MinMutualRelationRequirement; // 0x48
	[Tooltip("The average relationship of mutual customers to provide a 100% chance of success")]
	[Range(0, 5)]
	public float MaxMutualRelationRequirement; // 0x4C
	[Tooltip("If direct approach fails, whats the chance the police will be called?")]
	[Range(0, 1)]
	public float CallPoliceChance; // 0x50
	[Tooltip("How quickly the customer builds dependence")]
	[Range(0, 2)]
	[Header("Dependence")]
	public float DependenceMultiplier; // 0x54
	[Range(0, 1)]
	[Tooltip("The customer's starting (and lowest possible) dependence level")]
	public float BaseAddiction; // 0x58
	public Action onChanged; // 0x60

	// Methods

	// RVA: 0x6D06F0 Offset: 0x6CF0F0 VA: 0x1806D06F0
	public static float GetQualityScalar(EQuality quality) { }

	// RVA: 0x6D0550 Offset: 0x6CEF50 VA: 0x1806D0550
	public List<EDay> GetOrderDays(float dependence, float normalizedRelationship) { }

	// RVA: 0x6D0470 Offset: 0x6CEE70 VA: 0x1806D0470
	public float GetAdjustedWeeklySpend(float normalizedRelationship) { }

	[Button]
	// RVA: 0x6D0730 Offset: 0x6CF130 VA: 0x1806D0730
	public void RandomizeAffinities() { }

	[Button]
	// RVA: 0x6D0A70 Offset: 0x6CF470 VA: 0x1806D0A70
	public void RandomizeFavouriteEffects() { }

	[Button]
	// RVA: 0x6D0D80 Offset: 0x6CF780 VA: 0x1806D0D80
	public void RandomizeTiming() { }

	// RVA: 0x6D0DE0 Offset: 0x6CF7E0 VA: 0x1806D0DE0
	public void .ctor() { }
}

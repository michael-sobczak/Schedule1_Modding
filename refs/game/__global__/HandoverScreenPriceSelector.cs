public class HandoverScreenPriceSelector : MonoBehaviour // TypeDefIndex: 2961
{
	// Fields
	public const float MinPrice = 1;
	public const float MaxPrice = 9999;
	public InputField InputField; // 0x20
	[CompilerGenerated]
	private float <Price>k__BackingField; // 0x28
	public UnityEvent onPriceChanged; // 0x30

	// Properties
	public float Price { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x5260F0 Offset: 0x524AF0 VA: 0x1805260F0
	public float get_Price() { }

	[CompilerGenerated]
	// RVA: 0x54B820 Offset: 0x54A220 VA: 0x18054B820
	private void set_Price(float value) { }

	// RVA: 0x980E50 Offset: 0x97F850 VA: 0x180980E50
	public void SetPrice(float price) { }

	// RVA: 0x980E00 Offset: 0x97F800 VA: 0x180980E00
	public void RefreshPrice() { }

	// RVA: 0x980DC0 Offset: 0x97F7C0 VA: 0x180980DC0
	public void OnPriceInputChanged(string value) { }

	// RVA: 0x980DB0 Offset: 0x97F7B0 VA: 0x180980DB0
	public void ChangeAmount(float change) { }

	// RVA: 0x854AA0 Offset: 0x8534A0 VA: 0x180854AA0
	public void .ctor() { }
}

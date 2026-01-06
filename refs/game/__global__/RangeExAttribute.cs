public class RangeExAttribute : DTPropertyAttribute // TypeDefIndex: 10431
{
	// Fields
	public float MinValue; // 0x30
	public string MinFieldOrPropertyName; // 0x38
	public float MaxValue; // 0x40
	public string MaxFieldOrPropertyName; // 0x48
	public bool Slider; // 0x50

	// Methods

	// RVA: 0x499700 Offset: 0x498100 VA: 0x180499700
	public void .ctor(float minValue, float maxValue, string label = "", string tooltip = "") { }

	// RVA: 0x4995F0 Offset: 0x497FF0 VA: 0x1804995F0
	public void .ctor(string minFieldOrProperty, float maxValue, string label = "", string tooltip = "") { }

	// RVA: 0x499570 Offset: 0x497F70 VA: 0x180499570
	public void .ctor(float minValue, string maxFieldOrProperty, string label = "", string tooltip = "") { }

	// RVA: 0x499670 Offset: 0x498070 VA: 0x180499670
	public void .ctor(string minFieldOrProperty, string maxFieldOrProperty, string label = "", string tooltip = "") { }
}

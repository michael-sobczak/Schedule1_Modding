internal static class ComputedTransitionUtils // TypeDefIndex: 6773
{
	// Fields
	private static List<ComputedTransitionProperty> s_ComputedTransitionsBuffer; // 0x0

	// Methods

	// RVA: 0x2ED6810 Offset: 0x2ED5210 VA: 0x182ED6810
	internal static void UpdateComputedTransitions(ref ComputedStyle computedStyle) { }

	[Extension]
	// RVA: 0x2ED6310 Offset: 0x2ED4D10 VA: 0x182ED6310
	internal static bool HasTransitionProperty(ref ComputedStyle computedStyle, StylePropertyId id) { }

	[Extension]
	// RVA: 0x2ED61D0 Offset: 0x2ED4BD0 VA: 0x182ED61D0
	internal static bool GetTransitionProperty(ref ComputedStyle computedStyle, StylePropertyId id, out ComputedTransitionProperty result) { }

	// RVA: 0x2ED5BA0 Offset: 0x2ED45A0 VA: 0x182ED5BA0
	private static ComputedTransitionProperty[] GetOrComputeTransitionPropertyData(ref ComputedStyle computedStyle) { }

	// RVA: 0x2ED5D60 Offset: 0x2ED4760 VA: 0x182ED5D60
	private static int GetTransitionHashCode(ref ComputedStyle cs) { }

	// RVA: 0x2ED6510 Offset: 0x2ED4F10 VA: 0x182ED6510
	internal static bool SameTransitionProperty(ref ComputedStyle x, ref ComputedStyle y) { }

	// RVA: 0x2ED63F0 Offset: 0x2ED4DF0 VA: 0x182ED63F0
	private static bool SameTransitionProperty(List<StylePropertyName> a, List<StylePropertyName> b) { }

	// RVA: 0x2ED6710 Offset: 0x2ED5110 VA: 0x182ED6710
	private static bool SameTransitionProperty(List<TimeValue> a, List<TimeValue> b) { }

	// RVA: 0x2ED4810 Offset: 0x2ED3210 VA: 0x182ED4810
	private static void ComputeTransitionPropertyData(ref ComputedStyle computedStyle, List<ComputedTransitionProperty> outData) { }

	// RVA: -1 Offset: -1
	private static T GetWrappingTransitionData<T>(List<T> list, int i, T defaultValue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE694C0 Offset: 0xE67EC0 VA: 0x180E694C0
	|-ComputedTransitionUtils.GetWrappingTransitionData<EasingFunction>
	|
	|-RVA: 0xE696E0 Offset: 0xE680E0 VA: 0x180E696E0
	|-ComputedTransitionUtils.GetWrappingTransitionData<TimeValue>
	|
	|-RVA: 0xE69530 Offset: 0xE67F30 VA: 0x180E69530
	|-ComputedTransitionUtils.GetWrappingTransitionData<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x2ED5B70 Offset: 0x2ED4570 VA: 0x182ED5B70
	private static int ConvertTransitionTime(TimeValue time) { }

	// RVA: 0x2ED4B60 Offset: 0x2ED3560 VA: 0x182ED4B60
	private static Func<float, float> ConvertTransitionFunction(EasingMode mode) { }

	// RVA: 0x2ED6A20 Offset: 0x2ED5420 VA: 0x182ED6A20
	private static void .cctor() { }
}

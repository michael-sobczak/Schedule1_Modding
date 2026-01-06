internal static class ShorthandApplicator // TypeDefIndex: 7159
{
	// Fields
	private static List<TimeValue> s_TransitionDelayList; // 0x0
	private static List<TimeValue> s_TransitionDurationList; // 0x8
	private static List<StylePropertyName> s_TransitionPropertyList; // 0x10
	private static List<EasingFunction> s_TransitionTimingFunctionList; // 0x18

	// Methods

	// RVA: 0x2E32890 Offset: 0x2E31290 VA: 0x182E32890
	public static void ApplyBackgroundPosition(StylePropertyReader reader, ref ComputedStyle computedStyle) { }

	// RVA: 0x2E32960 Offset: 0x2E31360 VA: 0x182E32960
	public static void ApplyBorderColor(StylePropertyReader reader, ref ComputedStyle computedStyle) { }

	// RVA: 0x2E32B90 Offset: 0x2E31590 VA: 0x182E32B90
	public static void ApplyBorderRadius(StylePropertyReader reader, ref ComputedStyle computedStyle) { }

	// RVA: 0x2E32D70 Offset: 0x2E31770 VA: 0x182E32D70
	public static void ApplyBorderWidth(StylePropertyReader reader, ref ComputedStyle computedStyle) { }

	// RVA: 0x2E32FB0 Offset: 0x2E319B0 VA: 0x182E32FB0
	public static void ApplyFlex(StylePropertyReader reader, ref ComputedStyle computedStyle) { }

	// RVA: 0x2E33090 Offset: 0x2E31A90 VA: 0x182E33090
	public static void ApplyMargin(StylePropertyReader reader, ref ComputedStyle computedStyle) { }

	// RVA: 0x2E33280 Offset: 0x2E31C80 VA: 0x182E33280
	public static void ApplyPadding(StylePropertyReader reader, ref ComputedStyle computedStyle) { }

	// RVA: 0x2E33470 Offset: 0x2E31E70 VA: 0x182E33470
	public static void ApplyTransition(StylePropertyReader reader, ref ComputedStyle computedStyle) { }

	// RVA: 0x2E335C0 Offset: 0x2E31FC0 VA: 0x182E335C0
	public static void ApplyUnityBackgroundScaleMode(StylePropertyReader reader, ref ComputedStyle computedStyle) { }

	// RVA: 0x2E33730 Offset: 0x2E32130 VA: 0x182E33730
	public static void ApplyUnityTextOutline(StylePropertyReader reader, ref ComputedStyle computedStyle) { }

	// RVA: 0x2E346D0 Offset: 0x2E330D0 VA: 0x182E346D0
	private static bool CompileFlexShorthand(StylePropertyReader reader, out float grow, out float shrink, out Length basis) { }

	// RVA: 0x2E34090 Offset: 0x2E32A90 VA: 0x182E34090
	private static void CompileBorderRadius(StylePropertyReader reader, out Length top, out Length right, out Length bottom, out Length left) { }

	// RVA: 0x2E338B0 Offset: 0x2E322B0 VA: 0x182E338B0
	private static void CompileBackgroundPosition(StylePropertyReader reader, out BackgroundPosition backgroundPositionX, out BackgroundPosition backgroundPositionY) { }

	// RVA: 0x2E35510 Offset: 0x2E33F10 VA: 0x182E35510
	public static void CompileUnityBackgroundScaleMode(StylePropertyReader reader, out BackgroundPosition backgroundPositionX, out BackgroundPosition backgroundPositionY, out BackgroundRepeat backgroundRepeat, out BackgroundSize backgroundSize) { }

	// RVA: 0x2E34560 Offset: 0x2E32F60 VA: 0x182E34560
	private static void CompileBoxArea(StylePropertyReader reader, out Length top, out Length right, out Length bottom, out Length left) { }

	// RVA: 0x2E34380 Offset: 0x2E32D80 VA: 0x182E34380
	private static void CompileBoxArea(StylePropertyReader reader, out float top, out float right, out float bottom, out float left) { }

	// RVA: 0x2E341D0 Offset: 0x2E32BD0 VA: 0x182E341D0
	private static void CompileBoxArea(StylePropertyReader reader, out Color top, out Color right, out Color bottom, out Color left) { }

	// RVA: 0x2E34920 Offset: 0x2E33320 VA: 0x182E34920
	private static void CompileTextOutline(StylePropertyReader reader, out Color outlineColor, out float outlineWidth) { }

	// RVA: 0x2E34A30 Offset: 0x2E33430 VA: 0x182E34A30
	private static void CompileTransition(StylePropertyReader reader, out List<TimeValue> outDelay, out List<TimeValue> outDuration, out List<StylePropertyName> outProperty, out List<EasingFunction> outTimingFunction) { }

	// RVA: 0x2E355D0 Offset: 0x2E33FD0 VA: 0x182E355D0
	private static void .cctor() { }

	[CompilerGenerated]
	// RVA: 0xF00EB0 Offset: 0xEFF8B0 VA: 0x180F00EB0
	internal static void <CompileBackgroundPosition>g__SwapKeyword|16_0(ref BackgroundPositionKeyword a, ref BackgroundPositionKeyword b) { }
}

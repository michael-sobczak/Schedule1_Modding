internal class StylePropertyAnimationSystem : IStylePropertyAnimationSystem // TypeDefIndex: 6879
{
	// Fields
	private long m_CurrentTimeMs; // 0x10
	private StylePropertyAnimationSystem.ValuesFloat m_Floats; // 0x18
	private StylePropertyAnimationSystem.ValuesInt m_Ints; // 0x20
	private StylePropertyAnimationSystem.ValuesLength m_Lengths; // 0x28
	private StylePropertyAnimationSystem.ValuesColor m_Colors; // 0x30
	private StylePropertyAnimationSystem.ValuesBackground m_Backgrounds; // 0x38
	private StylePropertyAnimationSystem.ValuesFontDefinition m_FontDefinitions; // 0x40
	private StylePropertyAnimationSystem.ValuesFont m_Fonts; // 0x48
	private StylePropertyAnimationSystem.ValuesTextShadow m_TextShadows; // 0x50
	private StylePropertyAnimationSystem.ValuesScale m_Scale; // 0x58
	private StylePropertyAnimationSystem.ValuesRotate m_Rotate; // 0x60
	private StylePropertyAnimationSystem.ValuesTranslate m_Translate; // 0x68
	private StylePropertyAnimationSystem.ValuesTransformOrigin m_TransformOrigin; // 0x70
	private StylePropertyAnimationSystem.ValuesBackgroundPosition m_BackgroundPosition; // 0x78
	private StylePropertyAnimationSystem.ValuesBackgroundRepeat m_BackgroundRepeat; // 0x80
	private StylePropertyAnimationSystem.ValuesBackgroundSize m_BackgroundSize; // 0x88
	private readonly List<StylePropertyAnimationSystem.Values> m_AllValues; // 0x90
	private readonly Dictionary<StylePropertyId, StylePropertyAnimationSystem.Values> m_PropertyToValues; // 0x98

	// Methods

	// RVA: 0x2F03090 Offset: 0x2F01A90 VA: 0x182F03090
	public void .ctor() { }

	// RVA: -1 Offset: -1
	private T GetOrCreate<T>(ref T values) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF56560 Offset: 0xF54F60 VA: 0x180F56560
	|-StylePropertyAnimationSystem.GetOrCreate<object>
	|
	|-RVA: 0xF562D0 Offset: 0xF54CD0 VA: 0x180F562D0
	|-StylePropertyAnimationSystem.GetOrCreate<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	private bool StartTransition<T>(VisualElement owner, StylePropertyId prop, T startValue, T endValue, int durationMs, int delayMs, Func<float, float> easingCurve, StylePropertyAnimationSystem.Values<T> values) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF56AE0 Offset: 0xF554E0 VA: 0x180F56AE0
	|-StylePropertyAnimationSystem.StartTransition<Background>
	|
	|-RVA: 0xF565C0 Offset: 0xF54FC0 VA: 0x180F565C0
	|-StylePropertyAnimationSystem.StartTransition<BackgroundPosition>
	|
	|-RVA: 0xF56780 Offset: 0xF55180 VA: 0x180F56780
	|-StylePropertyAnimationSystem.StartTransition<BackgroundRepeat>
	|
	|-RVA: 0xF56910 Offset: 0xF55310 VA: 0x180F56910
	|-StylePropertyAnimationSystem.StartTransition<BackgroundSize>
	|
	|-RVA: 0xF56CB0 Offset: 0xF556B0 VA: 0x180F56CB0
	|-StylePropertyAnimationSystem.StartTransition<Color>
	|
	|-RVA: 0xF56E60 Offset: 0xF55860 VA: 0x180F56E60
	|-StylePropertyAnimationSystem.StartTransition<FontDefinition>
	|
	|-RVA: 0xF57220 Offset: 0xF55C20 VA: 0x180F57220
	|-StylePropertyAnimationSystem.StartTransition<int>
	|
	|-RVA: 0xF573B0 Offset: 0xF55DB0 VA: 0x180F573B0
	|-StylePropertyAnimationSystem.StartTransition<Length>
	|
	|-RVA: 0xF57710 Offset: 0xF56110 VA: 0x180F57710
	|-StylePropertyAnimationSystem.StartTransition<object>
	|
	|-RVA: 0xF57540 Offset: 0xF55F40 VA: 0x180F57540
	|-StylePropertyAnimationSystem.StartTransition<Rotate>
	|
	|-RVA: 0xF578A0 Offset: 0xF562A0 VA: 0x180F578A0
	|-StylePropertyAnimationSystem.StartTransition<Scale>
	|
	|-RVA: 0xF57A50 Offset: 0xF56450 VA: 0x180F57A50
	|-StylePropertyAnimationSystem.StartTransition<float>
	|
	|-RVA: 0xF57BF0 Offset: 0xF565F0 VA: 0x180F57BF0
	|-StylePropertyAnimationSystem.StartTransition<TextShadow>
	|
	|-RVA: 0xF57DD0 Offset: 0xF567D0 VA: 0x180F57DD0
	|-StylePropertyAnimationSystem.StartTransition<TransformOrigin>
	|
	|-RVA: 0xF57FA0 Offset: 0xF569A0 VA: 0x180F57FA0
	|-StylePropertyAnimationSystem.StartTransition<Translate>
	|
	|-RVA: 0xF57010 Offset: 0xF55A10 VA: 0x180F57010
	|-StylePropertyAnimationSystem.StartTransition<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x2F02AC0 Offset: 0x2F014C0 VA: 0x182F02AC0 Slot: 4
	public bool StartTransition(VisualElement owner, StylePropertyId prop, float startValue, float endValue, int durationMs, int delayMs, Func<float, float> easingCurve) { }

	// RVA: 0x2F026F0 Offset: 0x2F010F0 VA: 0x182F026F0 Slot: 5
	public bool StartTransition(VisualElement owner, StylePropertyId prop, int startValue, int endValue, int durationMs, int delayMs, Func<float, float> easingCurve) { }

	// RVA: 0x2F02440 Offset: 0x2F00E40 VA: 0x182F02440 Slot: 6
	public bool StartTransition(VisualElement owner, StylePropertyId prop, Length startValue, Length endValue, int durationMs, int delayMs, Func<float, float> easingCurve) { }

	// RVA: 0x2F02510 Offset: 0x2F00F10 VA: 0x182F02510 Slot: 7
	public bool StartTransition(VisualElement owner, StylePropertyId prop, Color startValue, Color endValue, int durationMs, int delayMs, Func<float, float> easingCurve) { }

	// RVA: 0x2F02260 Offset: 0x2F00C60 VA: 0x182F02260 Slot: 8
	public bool StartTransition(VisualElement owner, StylePropertyId prop, Background startValue, Background endValue, int durationMs, int delayMs, Func<float, float> easingCurve) { }

	// RVA: 0x2F02360 Offset: 0x2F00D60 VA: 0x182F02360 Slot: 9
	public bool StartTransition(VisualElement owner, StylePropertyId prop, FontDefinition startValue, FontDefinition endValue, int durationMs, int delayMs, Func<float, float> easingCurve) { }

	// RVA: 0x2F02C70 Offset: 0x2F01670 VA: 0x182F02C70 Slot: 10
	public bool StartTransition(VisualElement owner, StylePropertyId prop, Font startValue, Font endValue, int durationMs, int delayMs, Func<float, float> easingCurve) { }

	// RVA: 0x2F029B0 Offset: 0x2F013B0 VA: 0x182F029B0 Slot: 11
	public bool StartTransition(VisualElement owner, StylePropertyId prop, TextShadow startValue, TextShadow endValue, int durationMs, int delayMs, Func<float, float> easingCurve) { }

	// RVA: 0x2F02B90 Offset: 0x2F01590 VA: 0x182F02B90 Slot: 12
	public bool StartTransition(VisualElement owner, StylePropertyId prop, Scale startValue, Scale endValue, int durationMs, int delayMs, Func<float, float> easingCurve) { }

	// RVA: 0x2F028B0 Offset: 0x2F012B0 VA: 0x182F028B0 Slot: 15
	public bool StartTransition(VisualElement owner, StylePropertyId prop, Rotate startValue, Rotate endValue, int durationMs, int delayMs, Func<float, float> easingCurve) { }

	// RVA: 0x2F02D40 Offset: 0x2F01740 VA: 0x182F02D40 Slot: 14
	public bool StartTransition(VisualElement owner, StylePropertyId prop, Translate startValue, Translate endValue, int durationMs, int delayMs, Func<float, float> easingCurve) { }

	// RVA: 0x2F025F0 Offset: 0x2F00FF0 VA: 0x182F025F0 Slot: 13
	public bool StartTransition(VisualElement owner, StylePropertyId prop, TransformOrigin startValue, TransformOrigin endValue, int durationMs, int delayMs, Func<float, float> easingCurve) { }

	// RVA: 0x2F02170 Offset: 0x2F00B70 VA: 0x182F02170 Slot: 16
	public bool StartTransition(VisualElement owner, StylePropertyId prop, BackgroundPosition startValue, BackgroundPosition endValue, int durationMs, int delayMs, Func<float, float> easingCurve) { }

	// RVA: 0x2F02E40 Offset: 0x2F01840 VA: 0x182F02E40 Slot: 17
	public bool StartTransition(VisualElement owner, StylePropertyId prop, BackgroundRepeat startValue, BackgroundRepeat endValue, int durationMs, int delayMs, Func<float, float> easingCurve) { }

	// RVA: 0x2F027B0 Offset: 0x2F011B0 VA: 0x182F027B0 Slot: 18
	public bool StartTransition(VisualElement owner, StylePropertyId prop, BackgroundSize startValue, BackgroundSize endValue, int durationMs, int delayMs, Func<float, float> easingCurve) { }

	// RVA: 0x2F01CC0 Offset: 0x2F006C0 VA: 0x182F01CC0 Slot: 19
	public void CancelAllAnimations() { }

	// RVA: 0x2F01DD0 Offset: 0x2F007D0 VA: 0x182F01DD0 Slot: 20
	public void CancelAllAnimations(VisualElement owner) { }

	// RVA: 0x2F01FA0 Offset: 0x2F009A0 VA: 0x182F01FA0 Slot: 21
	public void CancelAnimation(VisualElement owner, StylePropertyId id) { }

	// RVA: 0x2F02F10 Offset: 0x2F01910 VA: 0x182F02F10 Slot: 22
	public void UpdateAnimation(VisualElement owner, StylePropertyId id) { }

	// RVA: 0x2F02040 Offset: 0x2F00A40 VA: 0x182F02040 Slot: 23
	public void GetAllAnimations(VisualElement owner, List<StylePropertyId> propertyIds) { }

	// RVA: -1 Offset: -1
	private void UpdateTracking<T>(StylePropertyAnimationSystem.Values<T> values) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF58170 Offset: 0xF56B70 VA: 0x180F58170
	|-StylePropertyAnimationSystem.UpdateTracking<Background>
	|-StylePropertyAnimationSystem.UpdateTracking<BackgroundPosition>
	|-StylePropertyAnimationSystem.UpdateTracking<BackgroundRepeat>
	|-StylePropertyAnimationSystem.UpdateTracking<BackgroundSize>
	|-StylePropertyAnimationSystem.UpdateTracking<Color>
	|-StylePropertyAnimationSystem.UpdateTracking<FontDefinition>
	|-StylePropertyAnimationSystem.UpdateTracking<int>
	|-StylePropertyAnimationSystem.UpdateTracking<Length>
	|-StylePropertyAnimationSystem.UpdateTracking<object>
	|-StylePropertyAnimationSystem.UpdateTracking<Rotate>
	|-StylePropertyAnimationSystem.UpdateTracking<Scale>
	|-StylePropertyAnimationSystem.UpdateTracking<float>
	|-StylePropertyAnimationSystem.UpdateTracking<TextShadow>
	|-StylePropertyAnimationSystem.UpdateTracking<TransformOrigin>
	|-StylePropertyAnimationSystem.UpdateTracking<Translate>
	|
	|-RVA: 0xF58220 Offset: 0xF56C20 VA: 0x180F58220
	|-StylePropertyAnimationSystem.UpdateTracking<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x180D270 Offset: 0x180BC70 VA: 0x18180D270
	private long CurrentTimeMs() { }

	// RVA: 0x2F02FB0 Offset: 0x2F019B0 VA: 0x182F02FB0 Slot: 24
	public void Update() { }
}

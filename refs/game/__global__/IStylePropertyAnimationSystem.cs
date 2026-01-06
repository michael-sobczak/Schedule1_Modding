internal interface IStylePropertyAnimationSystem // TypeDefIndex: 6851
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool StartTransition(VisualElement owner, StylePropertyId prop, float startValue, float endValue, int durationMs, int delayMs, Func<float, float> easingCurve);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool StartTransition(VisualElement owner, StylePropertyId prop, int startValue, int endValue, int durationMs, int delayMs, Func<float, float> easingCurve);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract bool StartTransition(VisualElement owner, StylePropertyId prop, Length startValue, Length endValue, int durationMs, int delayMs, Func<float, float> easingCurve);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract bool StartTransition(VisualElement owner, StylePropertyId prop, Color startValue, Color endValue, int durationMs, int delayMs, Func<float, float> easingCurve);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract bool StartTransition(VisualElement owner, StylePropertyId prop, Background startValue, Background endValue, int durationMs, int delayMs, Func<float, float> easingCurve);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract bool StartTransition(VisualElement owner, StylePropertyId prop, FontDefinition startValue, FontDefinition endValue, int durationMs, int delayMs, Func<float, float> easingCurve);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract bool StartTransition(VisualElement owner, StylePropertyId prop, Font startValue, Font endValue, int durationMs, int delayMs, Func<float, float> easingCurve);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract bool StartTransition(VisualElement owner, StylePropertyId prop, TextShadow startValue, TextShadow endValue, int durationMs, int delayMs, Func<float, float> easingCurve);

	// RVA: -1 Offset: -1 Slot: 8
	public abstract bool StartTransition(VisualElement owner, StylePropertyId prop, Scale startValue, Scale endValue, int durationMs, int delayMs, Func<float, float> easingCurve);

	// RVA: -1 Offset: -1 Slot: 9
	public abstract bool StartTransition(VisualElement owner, StylePropertyId prop, TransformOrigin startValue, TransformOrigin endValue, int durationMs, int delayMs, Func<float, float> easingCurve);

	// RVA: -1 Offset: -1 Slot: 10
	public abstract bool StartTransition(VisualElement owner, StylePropertyId prop, Translate startValue, Translate endValue, int durationMs, int delayMs, Func<float, float> easingCurve);

	// RVA: -1 Offset: -1 Slot: 11
	public abstract bool StartTransition(VisualElement owner, StylePropertyId prop, Rotate startValue, Rotate endValue, int durationMs, int delayMs, Func<float, float> easingCurve);

	// RVA: -1 Offset: -1 Slot: 12
	public abstract bool StartTransition(VisualElement owner, StylePropertyId prop, BackgroundPosition startValue, BackgroundPosition endValue, int durationMs, int delayMs, Func<float, float> easingCurve);

	// RVA: -1 Offset: -1 Slot: 13
	public abstract bool StartTransition(VisualElement owner, StylePropertyId prop, BackgroundRepeat startValue, BackgroundRepeat endValue, int durationMs, int delayMs, Func<float, float> easingCurve);

	// RVA: -1 Offset: -1 Slot: 14
	public abstract bool StartTransition(VisualElement owner, StylePropertyId prop, BackgroundSize startValue, BackgroundSize endValue, int durationMs, int delayMs, Func<float, float> easingCurve);

	// RVA: -1 Offset: -1 Slot: 15
	public abstract void CancelAllAnimations();

	// RVA: -1 Offset: -1 Slot: 16
	public abstract void CancelAllAnimations(VisualElement owner);

	// RVA: -1 Offset: -1 Slot: 17
	public abstract void CancelAnimation(VisualElement owner, StylePropertyId id);

	// RVA: -1 Offset: -1 Slot: 18
	public abstract void UpdateAnimation(VisualElement owner, StylePropertyId id);

	// RVA: -1 Offset: -1 Slot: 19
	public abstract void GetAllAnimations(VisualElement owner, List<StylePropertyId> propertyIds);

	// RVA: -1 Offset: -1 Slot: 20
	public abstract void Update();
}

internal interface IStylePropertyAnimations // TypeDefIndex: 6850
{
	// Properties
	public abstract int runningAnimationCount { get; set; }
	public abstract int completedAnimationCount { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool Start(StylePropertyId id, float from, float to, int durationMs, int delayMs, Func<float, float> easingCurve);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool Start(StylePropertyId id, int from, int to, int durationMs, int delayMs, Func<float, float> easingCurve);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract bool Start(StylePropertyId id, Length from, Length to, int durationMs, int delayMs, Func<float, float> easingCurve);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract bool Start(StylePropertyId id, Color from, Color to, int durationMs, int delayMs, Func<float, float> easingCurve);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract bool StartEnum(StylePropertyId id, int from, int to, int durationMs, int delayMs, Func<float, float> easingCurve);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract bool Start(StylePropertyId id, Background from, Background to, int durationMs, int delayMs, Func<float, float> easingCurve);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract bool Start(StylePropertyId id, FontDefinition from, FontDefinition to, int durationMs, int delayMs, Func<float, float> easingCurve);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract bool Start(StylePropertyId id, Font from, Font to, int durationMs, int delayMs, Func<float, float> easingCurve);

	// RVA: -1 Offset: -1 Slot: 8
	public abstract bool Start(StylePropertyId id, TextShadow from, TextShadow to, int durationMs, int delayMs, Func<float, float> easingCurve);

	// RVA: -1 Offset: -1 Slot: 9
	public abstract bool Start(StylePropertyId id, Scale from, Scale to, int durationMs, int delayMs, Func<float, float> easingCurve);

	// RVA: -1 Offset: -1 Slot: 10
	public abstract bool Start(StylePropertyId id, Translate from, Translate to, int durationMs, int delayMs, Func<float, float> easingCurve);

	// RVA: -1 Offset: -1 Slot: 11
	public abstract bool Start(StylePropertyId id, Rotate from, Rotate to, int durationMs, int delayMs, Func<float, float> easingCurve);

	// RVA: -1 Offset: -1 Slot: 12
	public abstract bool Start(StylePropertyId id, TransformOrigin from, TransformOrigin to, int durationMs, int delayMs, Func<float, float> easingCurve);

	// RVA: -1 Offset: -1 Slot: 13
	public abstract bool Start(StylePropertyId id, BackgroundPosition from, BackgroundPosition to, int durationMs, int delayMs, Func<float, float> easingCurve);

	// RVA: -1 Offset: -1 Slot: 14
	public abstract bool Start(StylePropertyId id, BackgroundRepeat from, BackgroundRepeat to, int durationMs, int delayMs, Func<float, float> easingCurve);

	// RVA: -1 Offset: -1 Slot: 15
	public abstract bool Start(StylePropertyId id, BackgroundSize from, BackgroundSize to, int durationMs, int delayMs, Func<float, float> easingCurve);

	// RVA: -1 Offset: -1 Slot: 16
	public abstract void UpdateAnimation(StylePropertyId id);

	// RVA: -1 Offset: -1 Slot: 17
	public abstract void GetAllAnimations(List<StylePropertyId> outPropertyIds);

	// RVA: -1 Offset: -1 Slot: 18
	public abstract void CancelAnimation(StylePropertyId id);

	// RVA: -1 Offset: -1 Slot: 19
	public abstract void CancelAllAnimations();

	// RVA: -1 Offset: -1 Slot: 20
	public abstract int get_runningAnimationCount();

	// RVA: -1 Offset: -1 Slot: 21
	public abstract void set_runningAnimationCount(int value);

	// RVA: -1 Offset: -1 Slot: 22
	public abstract int get_completedAnimationCount();

	// RVA: -1 Offset: -1 Slot: 23
	public abstract void set_completedAnimationCount(int value);
}

public class NumberKeyframeGroup : KeyframeGroup<NumberKeyframe> // TypeDefIndex: 430
{
	// Fields
	public float minValue; // 0x28
	public float maxValue; // 0x2C

	// Methods

	// RVA: 0x9DFD50 Offset: 0x9DE750 VA: 0x1809DFD50
	public void .ctor(string name, float min, float max) { }

	// RVA: 0x9DFDC0 Offset: 0x9DE7C0 VA: 0x1809DFDC0
	public void .ctor(string name, float min, float max, NumberKeyframe frame) { }

	// RVA: 0x9DFA50 Offset: 0x9DE450 VA: 0x1809DFA50
	public float GetFirstValue() { }

	// RVA: 0x9DFD30 Offset: 0x9DE730 VA: 0x1809DFD30
	public float ValueToPercent(float value) { }

	// RVA: 0x9DFCF0 Offset: 0x9DE6F0 VA: 0x1809DFCF0
	public float ValuePercentAtTime(float time) { }

	// RVA: 0x9DFCC0 Offset: 0x9DE6C0 VA: 0x1809DFCC0
	public float PercentToValue(float percent) { }

	// RVA: 0x9DFAA0 Offset: 0x9DE4A0 VA: 0x1809DFAA0
	public float NumericValueAtTime(float time) { }
}

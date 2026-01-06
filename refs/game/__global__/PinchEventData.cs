public class PinchEventData // TypeDefIndex: 19172
{
	// Fields
	public PointerEventData targetPointerData; // 0x10
	public PointerEventData unchangedPointerData; // 0x18
	public float distanceDelta; // 0x20

	// Properties
	public Vector2 midPoint { get; }

	// Methods

	// RVA: 0x1A4EB10 Offset: 0x1A4D510 VA: 0x181A4EB10
	public Vector2 get_midPoint() { }

	// RVA: 0x1A4EAA0 Offset: 0x1A4D4A0 VA: 0x181A4EAA0
	public void .ctor(PointerEventData target, PointerEventData unchanged, float distanceDelta = 0) { }
}

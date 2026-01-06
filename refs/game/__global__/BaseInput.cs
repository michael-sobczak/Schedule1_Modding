public class BaseInput : UIBehaviour // TypeDefIndex: 16550
{
	// Properties
	public virtual string compositionString { get; }
	public virtual IMECompositionMode imeCompositionMode { get; set; }
	public virtual Vector2 compositionCursorPos { get; set; }
	public virtual bool mousePresent { get; }
	public virtual Vector2 mousePosition { get; }
	public virtual Vector2 mouseScrollDelta { get; }
	public virtual bool touchSupported { get; }
	public virtual int touchCount { get; }

	// Methods

	// RVA: 0x2F45A70 Offset: 0x2F44470 VA: 0x182F45A70 Slot: 17
	public virtual string get_compositionString() { }

	// RVA: 0x2F45A80 Offset: 0x2F44480 VA: 0x182F45A80 Slot: 18
	public virtual IMECompositionMode get_imeCompositionMode() { }

	// RVA: 0x2F45B00 Offset: 0x2F44500 VA: 0x182F45B00 Slot: 19
	public virtual void set_imeCompositionMode(IMECompositionMode value) { }

	// RVA: 0x2F45A60 Offset: 0x2F44460 VA: 0x182F45A60 Slot: 20
	public virtual Vector2 get_compositionCursorPos() { }

	// RVA: 0x2F45AE0 Offset: 0x2F444E0 VA: 0x182F45AE0 Slot: 21
	public virtual void set_compositionCursorPos(Vector2 value) { }

	// RVA: 0x2E92550 Offset: 0x2E90F50 VA: 0x182E92550 Slot: 22
	public virtual bool get_mousePresent() { }

	// RVA: 0x2E924B0 Offset: 0x2E90EB0 VA: 0x182E924B0 Slot: 23
	public virtual bool GetMouseButtonDown(int button) { }

	// RVA: 0x2E924C0 Offset: 0x2E90EC0 VA: 0x182E924C0 Slot: 24
	public virtual bool GetMouseButtonUp(int button) { }

	// RVA: 0x2F45A50 Offset: 0x2F44450 VA: 0x182F45A50 Slot: 25
	public virtual bool GetMouseButton(int button) { }

	// RVA: 0x2F45A90 Offset: 0x2F44490 VA: 0x182F45A90 Slot: 26
	public virtual Vector2 get_mousePosition() { }

	// RVA: 0x2F45AC0 Offset: 0x2F444C0 VA: 0x182F45AC0 Slot: 27
	public virtual Vector2 get_mouseScrollDelta() { }

	// RVA: 0x2F45AD0 Offset: 0x2F444D0 VA: 0x182F45AD0 Slot: 28
	public virtual bool get_touchSupported() { }

	// RVA: 0x2E92560 Offset: 0x2E90F60 VA: 0x182E92560 Slot: 29
	public virtual int get_touchCount() { }

	// RVA: 0x2E924D0 Offset: 0x2E90ED0 VA: 0x182E924D0 Slot: 30
	public virtual Touch GetTouch(int index) { }

	// RVA: 0x2F45A40 Offset: 0x2F44440 VA: 0x182F45A40 Slot: 31
	public virtual float GetAxisRaw(string axisName) { }

	// RVA: 0x2E92460 Offset: 0x2E90E60 VA: 0x182E92460 Slot: 32
	public virtual bool GetButtonDown(string buttonName) { }

	// RVA: 0x43CCF0 Offset: 0x43B6F0 VA: 0x18043CCF0
	public void .ctor() { }
}

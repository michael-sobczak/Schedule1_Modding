public struct InputInteractionContext // TypeDefIndex: 7335
{
	// Fields
	internal InputActionState m_State; // 0x0
	internal InputInteractionContext.Flags m_Flags; // 0x8
	internal InputActionState.TriggerState m_TriggerState; // 0xC

	// Properties
	public InputAction action { get; }
	public InputControl control { get; }
	public InputActionPhase phase { get; }
	public double time { get; }
	public double startTime { get; }
	public bool timerHasExpired { get; set; }
	public bool isWaiting { get; }
	public bool isStarted { get; }
	internal int mapIndex { get; }
	internal int controlIndex { get; }
	internal int bindingIndex { get; }
	internal int interactionIndex { get; }

	// Methods

	// RVA: 0x27A6AA0 Offset: 0x27A54A0 VA: 0x1827A6AA0
	public InputAction get_action() { }

	// RVA: 0x27A6AE0 Offset: 0x27A54E0 VA: 0x1827A6AE0
	public InputControl get_control() { }

	// RVA: 0x27A6B50 Offset: 0x27A5550 VA: 0x1827A6B50
	public InputActionPhase get_phase() { }

	// RVA: 0x27A6B70 Offset: 0x27A5570 VA: 0x1827A6B70
	public double get_time() { }

	// RVA: 0x27A6B60 Offset: 0x27A5560 VA: 0x1827A6B60
	public double get_startTime() { }

	// RVA: 0x2798D30 Offset: 0x2797730 VA: 0x182798D30
	public bool get_timerHasExpired() { }

	// RVA: 0x2798E40 Offset: 0x2797840 VA: 0x182798E40
	internal void set_timerHasExpired(bool value) { }

	// RVA: 0x27A6B30 Offset: 0x27A5530 VA: 0x1827A6B30
	public bool get_isWaiting() { }

	// RVA: 0x27A6B20 Offset: 0x27A5520 VA: 0x1827A6B20
	public bool get_isStarted() { }

	// RVA: 0x5260F0 Offset: 0x524AF0 VA: 0x1805260F0
	public float ComputeMagnitude() { }

	// RVA: 0x27A67C0 Offset: 0x27A51C0 VA: 0x1827A67C0
	public bool ControlIsActuated(float threshold = 0) { }

	// RVA: 0x27A6A00 Offset: 0x27A5400 VA: 0x1827A6A00
	public void Started() { }

	// RVA: 0x27A68D0 Offset: 0x27A52D0 VA: 0x1827A68D0
	public void Performed() { }

	// RVA: 0x27A6870 Offset: 0x27A5270 VA: 0x1827A6870
	public void PerformedAndStayStarted() { }

	// RVA: 0x27A6820 Offset: 0x27A5220 VA: 0x1827A6820
	public void PerformedAndStayPerformed() { }

	// RVA: 0x27A6770 Offset: 0x27A5170 VA: 0x1827A6770
	public void Canceled() { }

	// RVA: 0x27A6A50 Offset: 0x27A5450 VA: 0x1827A6A50
	public void Waiting() { }

	// RVA: 0x27A6930 Offset: 0x27A5330 VA: 0x1827A6930
	public void SetTimeout(float seconds) { }

	// RVA: 0x27A6960 Offset: 0x27A5360 VA: 0x1827A6960
	public void SetTotalTimeoutCompletionTime(float seconds) { }

	// RVA: -1 Offset: -1
	public TValue ReadValue<TValue>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEDF030 Offset: 0xEDDA30 VA: 0x180EDF030
	|-InputInteractionContext.ReadValue<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: 0x27A6B40 Offset: 0x27A5540 VA: 0x1827A6B40
	internal int get_mapIndex() { }

	// RVA: 0x27A6AD0 Offset: 0x27A54D0 VA: 0x1827A6AD0
	internal int get_controlIndex() { }

	// RVA: 0x1DA37B0 Offset: 0x1DA21B0 VA: 0x181DA37B0
	internal int get_bindingIndex() { }

	// RVA: 0x27A6B10 Offset: 0x27A5510 VA: 0x1827A6B10
	internal int get_interactionIndex() { }
}

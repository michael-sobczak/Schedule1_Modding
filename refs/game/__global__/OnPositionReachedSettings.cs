public class OnPositionReachedSettings : ISerializationCallbackReceiver // TypeDefIndex: 10591
{
	// Fields
	public string Name; // 0x10
	public CurvySplineMoveEvent Event; // 0x18
	public float Position; // 0x20
	public CurvyPositionMode PositionMode; // 0x24
	public TriggeringDirections TriggeringDirections; // 0x28
	public Color GizmoColor; // 0x2C
	[SerializeField]
	[HideInInspector]
	private bool initialized; // 0x3C

	// Methods

	// RVA: 0x4E3F20 Offset: 0x4E2920 VA: 0x1804E3F20
	public void .ctor() { }

	// RVA: 0x4E3E50 Offset: 0x4E2850 VA: 0x1804E3E50
	private void InitializeFieldsWithDefaultValue() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 4
	public void OnBeforeSerialize() { }

	// RVA: 0x4E3EB0 Offset: 0x4E28B0 VA: 0x1804E3EB0 Slot: 5
	public void OnAfterDeserialize() { }

	// RVA: 0x4E3DD0 Offset: 0x4E27D0 VA: 0x1804E3DD0
	public OnPositionReachedSettings Clone() { }
}

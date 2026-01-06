public class WaterContainerVisualizer : MonoBehaviour // TypeDefIndex: 2340
{
	// Fields
	[SerializeField]
	private TransformLerp[] _waterTransformLerps; // 0x20
	private WaterContainerInstance _assignedWaterContainer; // 0x28

	// Methods

	// RVA: 0x86F3D0 Offset: 0x86DDD0 VA: 0x18086F3D0
	public void AssignWaterContainer(WaterContainerInstance waterContainer) { }

	// RVA: 0x86F950 Offset: 0x86E350 VA: 0x18086F950
	public void UnassignWaterContainer() { }

	// RVA: 0x86FA60 Offset: 0x86E460 VA: 0x18086FA60
	private void WaterContainerChanged() { }

	// RVA: 0x86F5F0 Offset: 0x86DFF0 VA: 0x18086F5F0
	private void SetFillLevel(float normalizedFillLevel) { }

	// RVA: 0x43CCF0 Offset: 0x43B6F0 VA: 0x18043CCF0
	public void .ctor() { }
}

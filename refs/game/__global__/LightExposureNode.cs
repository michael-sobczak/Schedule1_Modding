public class LightExposureNode : MonoBehaviour // TypeDefIndex: 1265
{
	// Fields
	public float ambientExposure; // 0x20
	public Dictionary<UsableLightSource, float> sources; // 0x28

	// Methods

	// RVA: 0x618250 Offset: 0x616C50 VA: 0x180618250
	public float GetTotalExposure(out float growSpeedMultiplier) { }

	// RVA: 0x618190 Offset: 0x616B90 VA: 0x180618190
	public void AddSource(UsableLightSource source, float lightAmount) { }

	// RVA: 0x618520 Offset: 0x616F20 VA: 0x180618520
	public void RemoveSource(UsableLightSource source) { }

	// RVA: 0x618480 Offset: 0x616E80 VA: 0x180618480
	private void OnDrawGizmos() { }

	// RVA: 0x618580 Offset: 0x616F80 VA: 0x180618580
	public void .ctor() { }
}

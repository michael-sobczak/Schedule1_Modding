public class SteerPID // TypeDefIndex: 2223
{
	// Fields
	private float error_old; // 0x10
	private float error_sum; // 0x14

	// Methods

	// RVA: 0x829E50 Offset: 0x828850 VA: 0x180829E50
	public float GetNewValue(float error, PID_Parameters pid_parameters) { }

	// RVA: 0x829E30 Offset: 0x828830 VA: 0x180829E30
	public static float AddValueToAverage(float oldAverage, float valueToAdd, float count) { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }
}

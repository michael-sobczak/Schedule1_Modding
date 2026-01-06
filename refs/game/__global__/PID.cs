public class PID // TypeDefIndex: 1927
{
	// Fields
	public float pFactor; // 0x10
	public float iFactor; // 0x14
	public float dFactor; // 0x18
	private float integral; // 0x1C
	private float lastError; // 0x20

	// Methods

	// RVA: 0x79D2B0 Offset: 0x79BCB0 VA: 0x18079D2B0
	public void .ctor(float pFactor, float iFactor, float dFactor) { }

	// RVA: 0x79D270 Offset: 0x79BC70 VA: 0x18079D270
	public float Update(float setpoint, float actual, float timeFrame) { }
}

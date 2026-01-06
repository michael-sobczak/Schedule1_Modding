public class TimedOperation // TypeDefIndex: 18204
{
	// Fields
	private readonly float _interval; // 0x10
	private readonly bool _scaledTime; // 0x14
	private Dictionary<string, float> _operationTimes; // 0x18
	private float _lastGlobalTime; // 0x20

	// Methods

	// RVA: 0xDAA540 Offset: 0xDA8F40 VA: 0x180DAA540
	public void .ctor(float interval, bool scaledTime = False) { }

	// RVA: 0xDAA4F0 Offset: 0xDA8EF0 VA: 0x180DAA4F0
	public bool TryUseOperation() { }

	// RVA: 0xDAA410 Offset: 0xDA8E10 VA: 0x180DAA410
	public bool TryUseOperation(string key) { }
}

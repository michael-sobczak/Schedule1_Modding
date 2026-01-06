public class StaggeredCallbackUtility : Singleton<StaggeredCallbackUtility> // TypeDefIndex: 1939
{
	// Methods

	// RVA: 0x7A6E50 Offset: 0x7A5850 VA: 0x1807A6E50
	public void InvokeStaggered(int totalCalls, float totalTime, Action<int> callback, Action onComplete) { }

	// RVA: 0x7A6FA0 Offset: 0x7A59A0 VA: 0x1807A6FA0
	public void InvokeStaggered(int totalCalls, int callsPerSecond, Action<int> callback, Action onComplete) { }

	// RVA: 0x7A70B0 Offset: 0x7A5AB0 VA: 0x1807A70B0
	public void .ctor() { }
}

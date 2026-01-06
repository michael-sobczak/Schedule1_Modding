public class PlayerData : SaveData // TypeDefIndex: 1093
{
	// Fields
	public string PlayerCode; // 0x28
	public Vector3 Position; // 0x30
	public float Rotation; // 0x3C
	public bool IntroCompleted; // 0x40

	// Methods

	// RVA: 0x5E8720 Offset: 0x5E7120 VA: 0x1805E8720
	public void .ctor(string playerCode, Vector3 playerPos, float playerRot, bool introCompleted) { }

	// RVA: 0x5E86C0 Offset: 0x5E70C0 VA: 0x1805E86C0
	public void .ctor() { }
}

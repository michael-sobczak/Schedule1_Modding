public class CasinoGamePlayerData // TypeDefIndex: 2026
{
	// Fields
	[CompilerGenerated]
	private CasinoGamePlayers <Parent>k__BackingField; // 0x10
	[CompilerGenerated]
	private Player <Player>k__BackingField; // 0x18
	protected Dictionary<string, bool> bools; // 0x20
	protected Dictionary<string, float> floats; // 0x28

	// Properties
	public CasinoGamePlayers Parent { get; set; }
	public Player Player { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	public CasinoGamePlayers get_Parent() { }

	[CompilerGenerated]
	// RVA: 0x49CBB0 Offset: 0x49B5B0 VA: 0x18049CBB0
	private void set_Parent(CasinoGamePlayers value) { }

	[CompilerGenerated]
	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	public Player get_Player() { }

	[CompilerGenerated]
	// RVA: 0x43EFE0 Offset: 0x43D9E0 VA: 0x18043EFE0
	private void set_Player(Player value) { }

	// RVA: 0x7CA770 Offset: 0x7C9170 VA: 0x1807CA770
	public void .ctor(CasinoGamePlayers parent, Player player) { }

	// RVA: -1 Offset: -1
	public T GetData<T>(string key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE5DEA0 Offset: 0xE5C8A0 VA: 0x180E5DEA0
	|-CasinoGamePlayerData.GetData<bool>
	|
	|-RVA: 0xE5E400 Offset: 0xE5CE00 VA: 0x180E5E400
	|-CasinoGamePlayerData.GetData<float>
	|
	|-RVA: 0xE5E140 Offset: 0xE5CB40 VA: 0x180E5E140
	|-CasinoGamePlayerData.GetData<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public void SetData<T>(string key, T value, bool network = True) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE5E6A0 Offset: 0xE5D0A0 VA: 0x180E5E6A0
	|-CasinoGamePlayerData.SetData<bool>
	|
	|-RVA: 0xE5F1B0 Offset: 0xE5DBB0 VA: 0x180E5F1B0
	|-CasinoGamePlayerData.SetData<float>
	|
	|-RVA: 0xE5EBD0 Offset: 0xE5D5D0 VA: 0x180E5EBD0
	|-CasinoGamePlayerData.SetData<__Il2CppFullySharedGenericType>
	*/
}

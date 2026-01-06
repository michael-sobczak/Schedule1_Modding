public sealed class PostProcessProfile : ScriptableObject // TypeDefIndex: 17051
{
	// Fields
	[Tooltip("A list of all settings currently stored in this profile.")]
	public List<PostProcessEffectSettings> settings; // 0x18
	public bool isDirty; // 0x20

	// Methods

	// RVA: 0x29B93F0 Offset: 0x29B7DF0 VA: 0x1829B93F0
	private void OnEnable() { }

	// RVA: -1 Offset: -1
	public T AddSettings<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF25F90 Offset: 0xF24990 VA: 0x180F25F90
	|-PostProcessProfile.AddSettings<object>
	*/

	// RVA: 0x29B9020 Offset: 0x29B7A20 VA: 0x1829B9020
	public PostProcessEffectSettings AddSettings(Type type) { }

	// RVA: 0x29B91A0 Offset: 0x29B7BA0 VA: 0x1829B91A0
	public PostProcessEffectSettings AddSettings(PostProcessEffectSettings effect) { }

	// RVA: -1 Offset: -1
	public void RemoveSettings<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF26290 Offset: 0xF24C90 VA: 0x180F26290
	|-PostProcessProfile.RemoveSettings<object>
	*/

	// RVA: 0x29B9510 Offset: 0x29B7F10 VA: 0x1829B9510
	public void RemoveSettings(Type type) { }

	// RVA: -1 Offset: -1
	public bool HasSettings<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF26220 Offset: 0xF24C20 VA: 0x180F26220
	|-PostProcessProfile.HasSettings<object>
	*/

	// RVA: 0x29B9270 Offset: 0x29B7C70 VA: 0x1829B9270
	public bool HasSettings(Type type) { }

	// RVA: -1 Offset: -1
	public T GetSetting<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF26050 Offset: 0xF24A50 VA: 0x180F26050
	|-PostProcessProfile.GetSetting<object>
	*/

	// RVA: -1 Offset: -1
	public bool TryGetSettings<T>(out T outSetting) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF26300 Offset: 0xF24D00 VA: 0x180F26300
	|-PostProcessProfile.TryGetSettings<object>
	*/

	// RVA: 0x29B9680 Offset: 0x29B8080 VA: 0x1829B9680
	public void .ctor() { }
}

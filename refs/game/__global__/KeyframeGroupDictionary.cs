public class KeyframeGroupDictionary : ISerializationCallbackReceiver, IEnumerable<string>, IEnumerable // TypeDefIndex: 476
{
	// Fields
	private Dictionary<string, IKeyframeGroup> m_Groups; // 0x10
	[SerializeField]
	private ColorGroupDictionary m_ColorGroup; // 0x18
	[SerializeField]
	private NumberGroupDictionary m_NumberGroup; // 0x20
	[SerializeField]
	private TextureGroupDictionary m_TextureGroup; // 0x28
	[SerializeField]
	private SpherePointGroupDictionary m_SpherePointGroup; // 0x30
	[SerializeField]
	private BoolGroupDictionary m_BoolGroup; // 0x38

	// Properties
	public IKeyframeGroup Item { get; set; }

	// Methods

	// RVA: 0xA87070 Offset: 0xA85A70 VA: 0x180A87070
	public IKeyframeGroup get_Item(string aKey) { }

	// RVA: 0xA870D0 Offset: 0xA85AD0 VA: 0x180A870D0
	public void set_Item(string aKey, IKeyframeGroup value) { }

	// RVA: 0xA86130 Offset: 0xA84B30 VA: 0x180A86130
	public bool ContainsKey(string key) { }

	// RVA: 0xA860E0 Offset: 0xA84AE0 VA: 0x180A860E0
	public void Clear() { }

	// RVA: -1 Offset: -1
	public T GetGroup<T>(string propertyName) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEE8A20 Offset: 0xEE7420 VA: 0x180EE8A20
	|-KeyframeGroupDictionary.GetGroup<object>
	*/

	// RVA: 0xA869D0 Offset: 0xA853D0 VA: 0x180A869D0 Slot: 4
	public void OnBeforeSerialize() { }

	// RVA: 0xA86230 Offset: 0xA84C30 VA: 0x180A86230 Slot: 5
	public void OnAfterDeserialize() { }

	// RVA: 0xA86190 Offset: 0xA84B90 VA: 0x180A86190 Slot: 6
	public IEnumerator<string> GetEnumerator() { }

	// RVA: 0xA86190 Offset: 0xA84B90 VA: 0x180A86190 Slot: 7
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0xA86EF0 Offset: 0xA858F0 VA: 0x180A86EF0
	public void .ctor() { }
}

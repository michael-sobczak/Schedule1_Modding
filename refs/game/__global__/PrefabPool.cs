public class PrefabPool : UnityObjectPool<GameObject> // TypeDefIndex: 10461
{
	// Fields
	[SerializeField]
	[FieldCondition("m_Identifier", "", False, 5, "Please enter an identifier! (Select a prefab to set automatically)", 1)]
	private string m_Identifier; // 0x50
	[SerializeField]
	private List<GameObject> m_Prefabs; // 0x58

	// Properties
	public override string Identifier { get; set; }
	public List<GameObject> Prefabs { get; set; }

	// Methods

	// RVA: 0x441BA0 Offset: 0x4405A0 VA: 0x180441BA0 Slot: 18
	public override string get_Identifier() { }

	// RVA: 0x4993D0 Offset: 0x497DD0 VA: 0x1804993D0 Slot: 19
	public override void set_Identifier(string value) { }

	// RVA: 0x4993C0 Offset: 0x497DC0 VA: 0x1804993C0
	public List<GameObject> get_Prefabs() { }

	// RVA: 0x4993E0 Offset: 0x497DE0 VA: 0x1804993E0
	public void set_Prefabs(List<GameObject> value) { }

	// RVA: 0x499140 Offset: 0x497B40 VA: 0x180499140 Slot: 7
	protected override void OnValidate() { }

	// RVA: 0x499070 Offset: 0x497A70 VA: 0x180499070
	public void Initialize(string identifier, PoolSettings settings, GameObject[] prefabs) { }

	// RVA: 0x498B50 Offset: 0x497550 VA: 0x180498B50 Slot: 23
	protected override GameObject CreateObject() { }

	// RVA: 0x499060 Offset: 0x497A60 VA: 0x180499060 Slot: 24
	protected override GameObject GetItemGameObject(GameObject item) { }

	// RVA: 0x499300 Offset: 0x497D00 VA: 0x180499300
	public void .ctor() { }
}

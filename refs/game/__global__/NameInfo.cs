internal sealed class NameInfo // TypeDefIndex: 4512
{
	// Fields
	internal string NIFullName; // 0x10
	internal long NIobjectId; // 0x18
	internal long NIassemId; // 0x20
	internal InternalPrimitiveTypeE NIprimitiveTypeEnum; // 0x28
	internal Type NItype; // 0x30
	internal bool NIisSealed; // 0x38
	internal bool NIisArray; // 0x39
	internal bool NIisArrayItem; // 0x3A
	internal bool NItransmitTypeOnObject; // 0x3B
	internal bool NItransmitTypeOnMember; // 0x3C
	internal bool NIisParentTypeOnObject; // 0x3D
	internal InternalArrayTypeE NIarrayEnum; // 0x40
	private bool NIsealedStatusChecked; // 0x44

	// Properties
	public bool IsSealed { get; }
	public string NIname { get; set; }

	// Methods

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	internal void .ctor() { }

	// RVA: 0x1B699F0 Offset: 0x1B683F0 VA: 0x181B699F0
	internal void Init() { }

	// RVA: 0x1B69A50 Offset: 0x1B68450 VA: 0x181B69A50
	public bool get_IsSealed() { }

	// RVA: 0x1B69A90 Offset: 0x1B68490 VA: 0x181B69A90
	public string get_NIname() { }

	// RVA: 0x49CBB0 Offset: 0x49B5B0 VA: 0x18049CBB0
	public void set_NIname(string value) { }
}

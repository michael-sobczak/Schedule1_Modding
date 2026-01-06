public class EmployeeData : NPCData // TypeDefIndex: 1063
{
	// Fields
	public string AssignedProperty; // 0x30
	public string FirstName; // 0x38
	public string LastName; // 0x40
	public bool IsMale; // 0x48
	public int AppearanceIndex; // 0x4C
	public Vector3 Position; // 0x50
	public Quaternion Rotation; // 0x5C
	public string GUID; // 0x70
	public bool PaidForToday; // 0x78

	// Methods

	// RVA: 0x5DA230 Offset: 0x5D8C30 VA: 0x1805DA230
	public void .ctor(string id, string assignedProperty, string firstName, string lastName, bool isMale, int appearanceIndex, Vector3 position, Quaternion rotation, Guid guid, bool paidForToday) { }
}

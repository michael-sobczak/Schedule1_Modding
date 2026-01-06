public abstract class Quest_Employees : Quest // TypeDefIndex: 708
{
	// Fields
	public EEmployeeType EmployeeType; // 0x138
	public QuestEntry AssignBedEntry; // 0x140
	public QuestEntry PayEntry; // 0x148

	// Methods

	// RVA: -1 Offset: -1 Slot: 56
	public abstract List<Employee> GetEmployees();

	// RVA: 0xAE2580 Offset: 0xAE0F80 VA: 0x180AE2580 Slot: 43
	protected override void MinPass() { }

	// RVA: 0xAE22B0 Offset: 0xAE0CB0 VA: 0x180AE22B0
	protected bool AreAnyEmployeesAssignedBeds() { }

	// RVA: 0xAE2440 Offset: 0xAE0E40 VA: 0x180AE2440
	protected bool AreAnyEmployeesPaid() { }

	// RVA: 0xAE03F0 Offset: 0xADEDF0 VA: 0x180AE03F0
	protected void .ctor() { }
}

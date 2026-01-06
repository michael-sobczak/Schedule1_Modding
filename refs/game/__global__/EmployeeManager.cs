public class EmployeeManager : NetworkSingleton<EmployeeManager> // TypeDefIndex: 1427
{
	// Fields
	public const float MALE_EMPLOYEE_CHANCE = 0.67;
	public List<Employee> AllEmployees; // 0x120
	public Quest_Employees[] EmployeeQuests; // 0x128
	[Header("Prefabs")]
	public Botanist BotanistPrefab; // 0x130
	public Packager PackagerPrefab; // 0x138
	public Chemist ChemistPrefab; // 0x140
	public Cleaner CleanerPrefab; // 0x148
	[Header("Appearances")]
	public List<EmployeeManager.EmployeeAppearance> MaleAppearances; // 0x150
	public List<EmployeeManager.EmployeeAppearance> FemaleAppearances; // 0x158
	[Header("Voices")]
	public VODatabase[] MaleVoices; // 0x160
	public VODatabase[] FemaleVoices; // 0x168
	[Header("Names")]
	public string[] MaleFirstNames; // 0x170
	public string[] FemaleFirstNames; // 0x178
	public string[] LastNames; // 0x180
	private List<string> takenNames; // 0x188
	private List<int> takenMaleAppearances; // 0x190
	private List<int> takenFemaleAppearances; // 0x198
	private bool NetworkInitialize___EarlyScheduleOne.Employees.EmployeeManagerAssembly-CSharp.dll_Excuted; // 0x1A0
	private bool NetworkInitialize__LateScheduleOne.Employees.EmployeeManagerAssembly-CSharp.dll_Excuted; // 0x1A1

	// Methods

	// RVA: 0x6C2690 Offset: 0x6C1090 VA: 0x1806C2690
	public void CreateNewEmployee(Property property, EEmployeeType type) { }

	[ServerRpc(RequireOwnership = False)]
	// RVA: 0x6C25F0 Offset: 0x6C0FF0 VA: 0x1806C25F0
	public void CreateEmployee(Property property, EEmployeeType type, string firstName, string lastName, string id, bool male, int appearanceIndex, Vector3 position, Quaternion rotation, string guid = "") { }

	// RVA: 0x6C1FA0 Offset: 0x6C09A0 VA: 0x1806C1FA0
	public Employee CreateEmployee_Server(Property property, EEmployeeType type, string firstName, string lastName, string id, bool male, int appearanceIndex, Vector3 position, Quaternion rotation, string guid) { }

	// RVA: 0x6C3130 Offset: 0x6C1B30 VA: 0x1806C3130
	private bool IsPositionValid(Vector3 position) { }

	// RVA: 0x6C31A0 Offset: 0x6C1BA0 VA: 0x1806C31A0
	private bool IsRotationValid(Quaternion rotation) { }

	// RVA: 0x6C3100 Offset: 0x6C1B00 VA: 0x1806C3100
	private bool IsFloatValid(float value) { }

	// RVA: 0x6C3420 Offset: 0x6C1E20 VA: 0x1806C3420
	public void RegisterName(string name) { }

	// RVA: 0x6C3320 Offset: 0x6C1D20 VA: 0x1806C3320
	public void RegisterAppearance(bool male, int index) { }

	// RVA: 0x6C2AB0 Offset: 0x6C14B0 VA: 0x1806C2AB0
	public void GenerateRandomName(bool male, out string firstName, out string lastName) { }

	// RVA: 0x6C2C20 Offset: 0x6C1620 VA: 0x1806C2C20
	public EmployeeManager.EmployeeAppearance GetAppearance(bool male, int index) { }

	// RVA: 0x6C30A0 Offset: 0x6C1AA0 VA: 0x1806C30A0
	public VODatabase GetVoice(bool male, int index) { }

	// RVA: 0x6C2F50 Offset: 0x6C1950 VA: 0x1806C2F50
	public void GetRandomAppearance(bool male, out int index, out AvatarSettings settings) { }

	// RVA: 0x6C2CA0 Offset: 0x6C16A0 VA: 0x1806C2CA0
	public Employee GetEmployeePrefab(EEmployeeType type) { }

	// RVA: 0x6C2DC0 Offset: 0x6C17C0 VA: 0x1806C2DC0
	public List<Employee> GetEmployeesByType(EEmployeeType type) { }

	// RVA: 0x6C3A90 Offset: 0x6C2490 VA: 0x1806C3A90
	public void .ctor() { }

	// RVA: 0x6C3280 Offset: 0x6C1C80 VA: 0x1806C3280 Slot: 22
	public override void NetworkInitialize___Early() { }

	// RVA: 0x6C3230 Offset: 0x6C1C30 VA: 0x1806C3230 Slot: 23
	public override void NetworkInitialize__Late() { }

	// RVA: 0x59EFB0 Offset: 0x59D9B0 VA: 0x18059EFB0 Slot: 14
	public override void NetworkInitializeIfDisabled() { }

	// RVA: 0x6C3760 Offset: 0x6C2160 VA: 0x1806C3760
	private void RpcWriter___Server_CreateEmployee_311954683(Property property, EEmployeeType type, string firstName, string lastName, string id, bool male, int appearanceIndex, Vector3 position, Quaternion rotation, string guid = "") { }

	// RVA: 0x6C34D0 Offset: 0x6C1ED0 VA: 0x1806C34D0
	public void RpcLogic___CreateEmployee_311954683(Property property, EEmployeeType type, string firstName, string lastName, string id, bool male, int appearanceIndex, Vector3 position, Quaternion rotation, string guid = "") { }

	// RVA: 0x6C3570 Offset: 0x6C1F70 VA: 0x1806C3570
	private void RpcReader___Server_CreateEmployee_311954683(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0x6C1F30 Offset: 0x6C0930 VA: 0x1806C1F30 Slot: 20
	public override void Awake() { }
}

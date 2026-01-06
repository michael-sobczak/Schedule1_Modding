public static class TMP_TextUtilities // TypeDefIndex: 15007
{
	// Fields
	private static Vector3[] m_rectWorldCorners; // 0x0
	private const string k_lookupStringL = "-------------------------------- !-#$%&-()*+,-./0123456789:;<=>?@abcdefghijklmnopqrstuvwxyz[-]^_`abcdefghijklmnopqrstuvwxyz{|}~-";
	private const string k_lookupStringU = "-------------------------------- !-#$%&-()*+,-./0123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[-]^_`ABCDEFGHIJKLMNOPQRSTUVWXYZ{|}~-";

	// Methods

	// RVA: 0x2C36C50 Offset: 0x2C35650 VA: 0x182C36C50
	public static int GetCursorIndexFromPosition(TMP_Text textComponent, Vector3 position, Camera camera) { }

	// RVA: 0x2C36E30 Offset: 0x2C35830 VA: 0x182C36E30
	public static int GetCursorIndexFromPosition(TMP_Text textComponent, Vector3 position, Camera camera, out CaretPosition cursor) { }

	// RVA: 0x2C34CD0 Offset: 0x2C336D0 VA: 0x182C34CD0
	public static int FindNearestLine(TMP_Text text, Vector3 position, Camera camera) { }

	// RVA: 0x2C340C0 Offset: 0x2C32AC0 VA: 0x182C340C0
	public static int FindNearestCharacterOnLine(TMP_Text text, Vector3 position, int line, Camera camera, bool visibleOnly) { }

	// RVA: 0x2C37690 Offset: 0x2C36090 VA: 0x182C37690
	public static bool IsIntersectingRectTransform(RectTransform rectTransform, Vector3 position, Camera camera) { }

	// RVA: 0x2C32A00 Offset: 0x2C31400 VA: 0x182C32A00
	public static int FindIntersectingCharacter(TMP_Text text, Vector3 position, Camera camera, bool visibleOnly) { }

	// RVA: 0x2C34700 Offset: 0x2C33100 VA: 0x182C34700
	public static int FindNearestCharacter(TMP_Text text, Vector3 position, Camera camera, bool visibleOnly) { }

	// RVA: 0x2C33880 Offset: 0x2C32280 VA: 0x182C33880
	public static int FindIntersectingWord(TMP_Text text, Vector3 position, Camera camera) { }

	// RVA: 0x2C35DE0 Offset: 0x2C347E0 VA: 0x182C35DE0
	public static int FindNearestWord(TMP_Text text, Vector3 position, Camera camera) { }

	// RVA: 0x2C32E20 Offset: 0x2C31820 VA: 0x182C32E20
	public static int FindIntersectingLine(TMP_Text text, Vector3 position, Camera camera) { }

	// RVA: 0x2C33020 Offset: 0x2C31A20 VA: 0x182C33020
	public static int FindIntersectingLink(TMP_Text text, Vector3 position, Camera camera) { }

	// RVA: 0x2C34FB0 Offset: 0x2C339B0 VA: 0x182C34FB0
	public static int FindNearestLink(TMP_Text text, Vector3 position, Camera camera) { }

	// RVA: 0x2C37930 Offset: 0x2C36330 VA: 0x182C37930
	private static bool PointIntersectRectangle(Vector3 m, Vector3 a, Vector3 b, Vector3 c, Vector3 d) { }

	// RVA: 0x2C37AB0 Offset: 0x2C364B0 VA: 0x182C37AB0
	public static bool ScreenPointToWorldPointInRectangle(Transform transform, Vector2 screenPoint, Camera cam, out Vector3 worldPoint) { }

	// RVA: 0x2C374B0 Offset: 0x2C35EB0 VA: 0x182C374B0
	private static bool IntersectLinePlane(TMP_TextUtilities.LineSegment line, Vector3 point, Vector3 normal, out Vector3 intersectingPoint) { }

	// RVA: 0x2C32810 Offset: 0x2C31210 VA: 0x182C32810
	public static float DistanceToLine(Vector3 a, Vector3 b, Vector3 point) { }

	// RVA: 0x2C38070 Offset: 0x2C36A70 VA: 0x182C38070
	public static char ToLowerFast(char c) { }

	// RVA: 0x2C38130 Offset: 0x2C36B30 VA: 0x182C38130
	public static char ToUpperFast(char c) { }

	// RVA: 0x2C380D0 Offset: 0x2C36AD0 VA: 0x182C380D0
	internal static uint ToUpperASCIIFast(uint c) { }

	// RVA: 0x2C371C0 Offset: 0x2C35BC0 VA: 0x182C371C0
	public static int GetHashCode(string s) { }

	// RVA: 0x2C300B0 Offset: 0x2C2EAB0 VA: 0x182C300B0
	public static int GetSimpleHashCode(string s) { }

	// RVA: 0x2C372B0 Offset: 0x2C35CB0 VA: 0x182C372B0
	public static uint GetSimpleHashCodeLowercase(string s) { }

	// RVA: 0x2C370E0 Offset: 0x2C35AE0 VA: 0x182C370E0
	public static uint GetHashCodeCaseInSensitive(string s) { }

	// RVA: 0x2C37390 Offset: 0x2C35D90 VA: 0x182C37390
	public static int HexToInt(char hex) { }

	// RVA: 0x2C37E70 Offset: 0x2C36870 VA: 0x182C37E70
	public static int StringHexToInt(string s) { }

	// RVA: 0x2C38190 Offset: 0x2C36B90 VA: 0x182C38190
	private static void .cctor() { }
}

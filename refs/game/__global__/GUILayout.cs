public class GUILayout // TypeDefIndex: 17597
{
	// Methods

	// RVA: 0x2D0B920 Offset: 0x2D0A320 VA: 0x182D0B920
	public static void Label(string text, GUILayoutOption[] options) { }

	// RVA: 0x2D0B9D0 Offset: 0x2D0A3D0 VA: 0x182D0B9D0
	public static void Label(string text, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x2D0B9C0 Offset: 0x2D0A3C0 VA: 0x182D0B9C0
	public static void Label(GUIContent content, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x2D0ADA0 Offset: 0x2D097A0 VA: 0x182D0ADA0
	private static void DoLabel(GUIContent content, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x2D0AA50 Offset: 0x2D09450 VA: 0x182D0AA50
	public static bool Button(string text, GUILayoutOption[] options) { }

	// RVA: 0x2D0AA40 Offset: 0x2D09440 VA: 0x182D0AA40
	public static bool Button(GUIContent content, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x2D0AAF0 Offset: 0x2D094F0 VA: 0x182D0AAF0
	private static bool DoButton(GUIContent content, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x2D0C240 Offset: 0x2D0AC40 VA: 0x182D0C240
	public static bool Toggle(bool value, string text, GUILayoutOption[] options) { }

	// RVA: 0x2D0C300 Offset: 0x2D0AD00 VA: 0x182D0C300
	public static bool Toggle(bool value, string text, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x2D0AEF0 Offset: 0x2D098F0 VA: 0x182D0AEF0
	private static bool DoToggle(bool value, GUIContent content, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x2D0BAF0 Offset: 0x2D0A4F0 VA: 0x182D0BAF0
	public static int SelectionGrid(int selected, string[] texts, int xCount, GUILayoutOption[] options) { }

	// RVA: 0x2D0BDD0 Offset: 0x2D0A7D0 VA: 0x182D0BDD0
	public static int SelectionGrid(int selected, GUIContent[] contents, int xCount, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x2D0B6D0 Offset: 0x2D0A0D0 VA: 0x182D0B6D0
	public static float HorizontalSlider(float value, float leftValue, float rightValue, GUILayoutOption[] options) { }

	// RVA: 0x2D0ABE0 Offset: 0x2D095E0 VA: 0x182D0ABE0
	private static float DoHorizontalSlider(float value, float leftValue, float rightValue, GUIStyle slider, GUIStyle thumb, GUILayoutOption[] options) { }

	// RVA: 0x2D0BF30 Offset: 0x2D0A930 VA: 0x182D0BF30
	public static void Space(float pixels) { }

	// RVA: 0x2D0B290 Offset: 0x2D09C90 VA: 0x182D0B290
	public static void FlexibleSpace() { }

	// RVA: 0x2D0A160 Offset: 0x2D08B60 VA: 0x182D0A160
	public static void BeginHorizontal(GUILayoutOption[] options) { }

	// RVA: 0x2D0A380 Offset: 0x2D08D80 VA: 0x182D0A380
	public static void BeginHorizontal(GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x2D0A200 Offset: 0x2D08C00 VA: 0x182D0A200
	public static void BeginHorizontal(GUIContent content, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x2D0B000 Offset: 0x2D09A00 VA: 0x182D0B000
	public static void EndHorizontal() { }

	// RVA: 0x2D0A930 Offset: 0x2D09330 VA: 0x182D0A930
	public static void BeginVertical(GUILayoutOption[] options) { }

	// RVA: 0x2D0A9D0 Offset: 0x2D093D0 VA: 0x182D0A9D0
	public static void BeginVertical(GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x2D0A7B0 Offset: 0x2D091B0 VA: 0x182D0A7B0
	public static void BeginVertical(GUIContent content, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x2D0B130 Offset: 0x2D09B30 VA: 0x182D0B130
	public static void EndVertical() { }

	// RVA: 0x2D09D10 Offset: 0x2D08710 VA: 0x182D09D10
	public static void BeginArea(Rect screenRect) { }

	// RVA: 0x2D09DC0 Offset: 0x2D087C0 VA: 0x182D09DC0
	public static void BeginArea(Rect screenRect, GUIStyle style) { }

	// RVA: 0x2D0A0E0 Offset: 0x2D08AE0 VA: 0x182D0A0E0
	public static void BeginArea(Rect screenRect, string text, GUIStyle style) { }

	// RVA: 0x2D09E40 Offset: 0x2D08840 VA: 0x182D09E40
	public static void BeginArea(Rect screenRect, GUIContent content, GUIStyle style) { }

	// RVA: 0x2D00D10 Offset: 0x2CFF710 VA: 0x182D00D10
	public static void EndArea() { }

	// RVA: 0x2D0A3F0 Offset: 0x2D08DF0 VA: 0x182D0A3F0
	public static Vector2 BeginScrollView(Vector2 scrollPosition, GUILayoutOption[] options) { }

	// RVA: 0x2D0A4C0 Offset: 0x2D08EC0 VA: 0x182D0A4C0
	public static Vector2 BeginScrollView(Vector2 scrollPosition, bool alwaysShowHorizontal, bool alwaysShowVertical, GUIStyle horizontalScrollbar, GUIStyle verticalScrollbar, GUIStyle background, GUILayoutOption[] options) { }

	// RVA: 0x2D0B040 Offset: 0x2D09A40 VA: 0x182D0B040
	public static void EndScrollView() { }

	// RVA: 0x2D0B0B0 Offset: 0x2D09AB0 VA: 0x182D0B0B0
	internal static void EndScrollView(bool handleScrollWheel) { }

	// RVA: 0x2D0C390 Offset: 0x2D0AD90 VA: 0x182D0C390
	public static GUILayoutOption Width(float width) { }

	// RVA: 0x2D0BA50 Offset: 0x2D0A450 VA: 0x182D0BA50
	public static GUILayoutOption MaxWidth(float maxWidth) { }

	// RVA: 0x2D0B630 Offset: 0x2D0A030 VA: 0x182D0B630
	public static GUILayoutOption Height(float height) { }

	// RVA: 0x2D0B200 Offset: 0x2D09C00 VA: 0x182D0B200
	public static GUILayoutOption ExpandWidth(bool expand) { }

	// RVA: 0x2D0B170 Offset: 0x2D09B70 VA: 0x182D0B170
	public static GUILayoutOption ExpandHeight(bool expand) { }
}

using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace S1API.UI;

public static class UIFactory
{
	private static Sprite roundedSprite;

	public static GameObject Panel(string name, Transform parent, Color bgColor, Vector2? anchorMin = null, Vector2? anchorMax = null, bool fullAnchor = false)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected O, but got Unknown
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		GameObject val = new GameObject(name);
		val.transform.SetParent(parent, false);
		RectTransform val2 = val.AddComponent<RectTransform>();
		if (fullAnchor)
		{
			val2.anchorMin = Vector2.zero;
			val2.anchorMax = Vector2.one;
			val2.offsetMin = Vector2.zero;
			val2.offsetMax = Vector2.zero;
		}
		else
		{
			val2.anchorMin = (Vector2)(((_003F?)anchorMin) ?? new Vector2(0.5f, 0.5f));
			val2.anchorMax = (Vector2)(((_003F?)anchorMax) ?? new Vector2(0.5f, 0.5f));
		}
		Image val3 = val.AddComponent<Image>();
		((Graphic)val3).color = bgColor;
		return val;
	}

	public static Text Text(string name, string content, Transform parent, int fontSize = 14, TextAnchor anchor = (TextAnchor)0, FontStyle style = (FontStyle)0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected O, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		GameObject val = new GameObject(name);
		val.transform.SetParent(parent, false);
		RectTransform val2 = val.AddComponent<RectTransform>();
		Text val3 = val.AddComponent<Text>();
		val3.text = content;
		val3.fontSize = fontSize;
		val3.alignment = anchor;
		val3.fontStyle = style;
		val3.font = Resources.GetBuiltinResource<Font>("Arial.ttf");
		((Graphic)val3).color = Color.white;
		val3.horizontalOverflow = (HorizontalWrapMode)0;
		val3.verticalOverflow = (VerticalWrapMode)1;
		return val3;
	}

	public static RectTransform ScrollableVerticalList(string name, Transform parent, out ScrollRect scrollRect)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected O, but got Unknown
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Expected O, but got Unknown
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_017c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0186: Expected O, but got Unknown
		GameObject val = new GameObject(name);
		val.transform.SetParent(parent, false);
		RectTransform val2 = val.AddComponent<RectTransform>();
		val2.anchorMin = Vector2.zero;
		val2.anchorMax = Vector2.one;
		val2.offsetMin = Vector2.zero;
		val2.offsetMax = Vector2.zero;
		scrollRect = val.AddComponent<ScrollRect>();
		scrollRect.horizontal = false;
		GameObject val3 = new GameObject("Viewport");
		val3.transform.SetParent(val.transform, false);
		RectTransform val4 = val3.AddComponent<RectTransform>();
		val4.anchorMin = Vector2.zero;
		val4.anchorMax = Vector2.one;
		val4.offsetMin = Vector2.zero;
		val4.offsetMax = Vector2.zero;
		((Graphic)val3.AddComponent<Image>()).color = new Color(0f, 0f, 0f, 0.05f);
		val3.AddComponent<Mask>().showMaskGraphic = false;
		scrollRect.viewport = val4;
		GameObject val5 = new GameObject("Content");
		val5.transform.SetParent(val3.transform, false);
		RectTransform val6 = val5.AddComponent<RectTransform>();
		val6.anchorMin = new Vector2(0f, 1f);
		val6.anchorMax = new Vector2(1f, 1f);
		val6.pivot = new Vector2(0.5f, 1f);
		VerticalLayoutGroup val7 = val5.AddComponent<VerticalLayoutGroup>();
		((HorizontalOrVerticalLayoutGroup)val7).spacing = 10f;
		((LayoutGroup)val7).padding = new RectOffset(10, 10, 10, 10);
		((HorizontalOrVerticalLayoutGroup)val7).childControlHeight = true;
		((HorizontalOrVerticalLayoutGroup)val7).childForceExpandHeight = false;
		val5.AddComponent<ContentSizeFitter>().verticalFit = (FitMode)2;
		scrollRect.content = val6;
		return val6;
	}

	public static void FitContentHeight(RectTransform content)
	{
		ContentSizeFitter val = ((Component)content).gameObject.GetComponent<ContentSizeFitter>();
		if ((Object)(object)val == (Object)null)
		{
			val = ((Component)content).gameObject.AddComponent<ContentSizeFitter>();
		}
		val.verticalFit = (FitMode)2;
	}

	public static (GameObject, Button, Text) RoundedButtonWithLabel(string name, string label, Transform parent, Color bgColor, float width, float height, int fontSize, Color textColor)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Expected O, but got Unknown
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Expected O, but got Unknown
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
		GameObject val = new GameObject(name + "_RoundedMask");
		val.transform.SetParent(parent, false);
		RectTransform val2 = val.AddComponent<RectTransform>();
		val2.sizeDelta = new Vector2(width, height);
		LayoutElement val3 = val.AddComponent<LayoutElement>();
		val3.preferredWidth = width;
		val3.preferredHeight = height;
		Image val4 = val.AddComponent<Image>();
		val4.sprite = GetRoundedSprite();
		val4.type = (Type)1;
		((Graphic)val4).color = Color.white;
		Mask val5 = val.AddComponent<Mask>();
		val5.showMaskGraphic = true;
		GameObject val6 = new GameObject(name);
		val6.transform.SetParent(val.transform, false);
		RectTransform val7 = val6.AddComponent<RectTransform>();
		val7.anchorMin = Vector2.zero;
		val7.anchorMax = Vector2.one;
		val7.offsetMin = Vector2.zero;
		val7.offsetMax = Vector2.zero;
		Image val8 = val6.AddComponent<Image>();
		((Graphic)val8).color = bgColor;
		val8.sprite = GetRoundedSprite();
		val8.type = (Type)1;
		Button val9 = val6.AddComponent<Button>();
		((Selectable)val9).targetGraphic = (Graphic)(object)val8;
		GameObject val10 = new GameObject("Label");
		val10.transform.SetParent(val6.transform, false);
		RectTransform val11 = val10.AddComponent<RectTransform>();
		val11.anchorMin = Vector2.zero;
		val11.anchorMax = Vector2.one;
		val11.offsetMin = Vector2.zero;
		val11.offsetMax = Vector2.zero;
		Text val12 = val10.AddComponent<Text>();
		val12.text = label;
		val12.alignment = (TextAnchor)4;
		val12.fontSize = fontSize;
		val12.fontStyle = (FontStyle)1;
		((Graphic)val12).color = textColor;
		val12.font = Resources.GetBuiltinResource<Font>("Arial.ttf");
		return (val, val9, val12);
	}

	private static Sprite GetRoundedSprite()
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected O, but got Unknown
		//IL_01df: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_0178: Unknown result type (might be due to invalid IL or missing references)
		//IL_0175: Unknown result type (might be due to invalid IL or missing references)
		//IL_0179: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)roundedSprite != (Object)null)
		{
			return roundedSprite;
		}
		int num = 32;
		Texture2D val = new Texture2D(num, num, (TextureFormat)5, false);
		Color32 val2 = default(Color32);
		((Color32)(ref val2))._002Ector((byte)0, (byte)0, (byte)0, (byte)0);
		Color32 val3 = default(Color32);
		((Color32)(ref val3))._002Ector(byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue);
		float num2 = 6f;
		for (int i = 0; i < num; i++)
		{
			for (int j = 0; j < num; j++)
			{
				bool flag = ((float)j < num2 && (float)i < num2 && Vector2.Distance(new Vector2((float)j, (float)i), new Vector2(num2, num2)) > num2) || ((float)j > (float)num - num2 - 1f && (float)i < num2 && Vector2.Distance(new Vector2((float)j, (float)i), new Vector2((float)num - num2 - 1f, num2)) > num2) || ((float)j < num2 && (float)i > (float)num - num2 - 1f && Vector2.Distance(new Vector2((float)j, (float)i), new Vector2(num2, (float)num - num2 - 1f)) > num2) || ((float)j > (float)num - num2 - 1f && (float)i > (float)num - num2 - 1f && Vector2.Distance(new Vector2((float)j, (float)i), new Vector2((float)num - num2 - 1f, (float)num - num2 - 1f)) > num2);
				val.SetPixel(j, i, Color32.op_Implicit(flag ? val2 : val3));
			}
		}
		val.Apply();
		Vector4 val4 = default(Vector4);
		((Vector4)(ref val4))._002Ector(8f, 8f, 8f, 8f);
		roundedSprite = Sprite.Create(val, new Rect(0f, 0f, (float)num, (float)num), new Vector2(0.5f, 0.5f), 100f, 0u, (SpriteMeshType)0, val4);
		return roundedSprite;
	}

	public static GameObject ButtonRow(string name, Transform parent, float spacing = 12f, TextAnchor alignment = (TextAnchor)4)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		GameObject val = new GameObject(name);
		val.transform.SetParent(parent, false);
		RectTransform val2 = val.AddComponent<RectTransform>();
		HorizontalLayoutGroup val3 = val.AddComponent<HorizontalLayoutGroup>();
		((HorizontalOrVerticalLayoutGroup)val3).spacing = spacing;
		((LayoutGroup)val3).childAlignment = alignment;
		((HorizontalOrVerticalLayoutGroup)val3).childControlWidth = false;
		((HorizontalOrVerticalLayoutGroup)val3).childControlHeight = false;
		((HorizontalOrVerticalLayoutGroup)val3).childForceExpandWidth = false;
		((HorizontalOrVerticalLayoutGroup)val3).childForceExpandHeight = false;
		return val;
	}

	public static (GameObject, Button, Text) ButtonWithLabel(string name, string label, Transform parent, Color bgColor, float Width, float Height)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Expected O, but got Unknown
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		GameObject val = new GameObject(name);
		val.transform.SetParent(parent, false);
		RectTransform val2 = val.AddComponent<RectTransform>();
		val2.sizeDelta = new Vector2(Height, Width);
		Image val3 = val.AddComponent<Image>();
		((Graphic)val3).color = bgColor;
		val3.sprite = Resources.GetBuiltinResource<Sprite>("UI/Skin/UISprite.psd");
		val3.type = (Type)1;
		Button val4 = val.AddComponent<Button>();
		((Selectable)val4).targetGraphic = (Graphic)(object)val3;
		GameObject val5 = new GameObject("Label");
		val5.transform.SetParent(val.transform, false);
		RectTransform val6 = val5.AddComponent<RectTransform>();
		val6.anchorMin = Vector2.zero;
		val6.anchorMax = Vector2.one;
		val6.offsetMin = Vector2.zero;
		val6.offsetMax = Vector2.zero;
		Text val7 = val5.AddComponent<Text>();
		val7.text = label;
		val7.alignment = (TextAnchor)4;
		val7.fontSize = 16;
		val7.fontStyle = (FontStyle)1;
		((Graphic)val7).color = Color.white;
		val7.font = Resources.GetBuiltinResource<Font>("Arial.ttf");
		return (val, val4, val7);
	}

	public static void SetIcon(Sprite sprite, Transform parent)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		GameObject val = new GameObject("Icon");
		val.transform.SetParent(parent, false);
		RectTransform val2 = val.AddComponent<RectTransform>();
		val2.anchorMin = Vector2.zero;
		val2.anchorMax = Vector2.one;
		val2.offsetMin = Vector2.zero;
		val2.offsetMax = Vector2.zero;
		Image val3 = val.AddComponent<Image>();
		val3.sprite = sprite;
		val3.preserveAspect = true;
	}

	public static void CreateTextBlock(Transform parent, string title, string subtitle, bool isCompleted)
	{
		Text(((Object)parent).name + "Title", title, parent, 16, (TextAnchor)3, (FontStyle)1);
		Text(((Object)parent).name + "Subtitle", subtitle, parent, 14, (TextAnchor)0, (FontStyle)0);
		if (isCompleted)
		{
			Text("CompletedLabel", "<color=#888888><i>Already Delivered</i></color>", parent, 12, (TextAnchor)0, (FontStyle)0);
		}
	}

	public static void CreateRowButton(GameObject go, UnityAction clickHandler, bool enabled)
	{
		Button val = go.AddComponent<Button>();
		Image component = go.GetComponent<Image>();
		((Selectable)val).targetGraphic = (Graphic)(object)component;
		((Selectable)val).interactable = enabled;
		((UnityEvent)val.onClick).AddListener(clickHandler);
	}

	public static void ClearChildren(Transform parent)
	{
		for (int num = parent.childCount - 1; num >= 0; num--)
		{
			Transform child = parent.GetChild(num);
			Object.Destroy((Object)(object)((Component)child).gameObject);
		}
	}

	public static void VerticalLayoutOnGO(GameObject go, int spacing = 10, RectOffset? padding = null)
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		VerticalLayoutGroup val = go.AddComponent<VerticalLayoutGroup>();
		((HorizontalOrVerticalLayoutGroup)val).spacing = spacing;
		((LayoutGroup)val).padding = (RectOffset)(((object)padding) ?? ((object)new RectOffset(10, 10, 10, 10)));
	}

	public static GameObject CreateQuestRow(string name, Transform parent, out GameObject iconPanel, out GameObject textPanel)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Expected O, but got Unknown
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f1: Unknown result type (might be due to invalid IL or missing references)
		GameObject val = new GameObject("Row_" + name);
		val.transform.SetParent(parent, false);
		RectTransform val2 = val.AddComponent<RectTransform>();
		val2.sizeDelta = new Vector2(0f, 90f);
		val.AddComponent<LayoutElement>().minHeight = 50f;
		((Shadow)val.AddComponent<Outline>()).effectColor = new Color(0f, 0f, 0f, 0.2f);
		GameObject val3 = Panel("Separator", val.transform, new Color(1f, 1f, 1f, 0.05f));
		val3.GetComponent<RectTransform>().sizeDelta = new Vector2(300f, 1f);
		Image val4 = val.AddComponent<Image>();
		((Graphic)val4).color = new Color(0.12f, 0.12f, 0.12f);
		Button val5 = val.AddComponent<Button>();
		((Selectable)val5).targetGraphic = (Graphic)(object)val4;
		HorizontalLayoutGroup val6 = val.AddComponent<HorizontalLayoutGroup>();
		((HorizontalOrVerticalLayoutGroup)val6).spacing = 20f;
		((LayoutGroup)val6).padding = new RectOffset(75, 10, 10, 10);
		((LayoutGroup)val6).childAlignment = (TextAnchor)3;
		((HorizontalOrVerticalLayoutGroup)val6).childForceExpandWidth = false;
		((HorizontalOrVerticalLayoutGroup)val6).childForceExpandHeight = false;
		LayoutElement val7 = val.AddComponent<LayoutElement>();
		val7.minHeight = 90f;
		val7.flexibleWidth = 1f;
		iconPanel = Panel("IconPanel", val.transform, new Color(0.12f, 0.12f, 0.12f));
		RectTransform component = iconPanel.GetComponent<RectTransform>();
		component.sizeDelta = new Vector2(80f, 80f);
		LayoutElement val8 = iconPanel.AddComponent<LayoutElement>();
		val8.preferredWidth = 80f;
		val8.preferredHeight = 80f;
		textPanel = Panel("TextPanel", val.transform, Color.clear);
		VerticalLayoutOnGO(textPanel, 2);
		LayoutElement val9 = textPanel.AddComponent<LayoutElement>();
		val9.minWidth = 200f;
		val9.flexibleWidth = 1f;
		return val;
	}

	public static GameObject TopBar(string name, Transform parent, string title, float topbarSize, int paddingLeft, int paddingRight, int paddingTop, int paddingBottom)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Expected O, but got Unknown
		GameObject val = Panel(name, parent, new Color(0.15f, 0.15f, 0.15f), (Vector2?)new Vector2(0f, topbarSize), (Vector2?)new Vector2(1f, 1f), fullAnchor: false);
		HorizontalLayoutGroup val2 = val.AddComponent<HorizontalLayoutGroup>();
		((LayoutGroup)val2).padding = new RectOffset(paddingLeft, paddingRight, paddingTop, paddingBottom);
		((HorizontalOrVerticalLayoutGroup)val2).spacing = 20f;
		((LayoutGroup)val2).childAlignment = (TextAnchor)4;
		((HorizontalOrVerticalLayoutGroup)val2).childForceExpandWidth = false;
		((HorizontalOrVerticalLayoutGroup)val2).childForceExpandHeight = true;
		Text val3 = Text("TopBarTitle", title, val.transform, 26, (TextAnchor)3, (FontStyle)1);
		LayoutElement val4 = ((Component)val3).gameObject.AddComponent<LayoutElement>();
		val4.minWidth = 300f;
		val4.flexibleWidth = 1f;
		return val;
	}

	public static void HorizontalLayoutOnGO(GameObject go, int spacing = 10, int padLeft = 0, int padRight = 0, int padTop = 0, int padBottom = 0, TextAnchor alignment = (TextAnchor)4)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got Unknown
		HorizontalLayoutGroup val = go.AddComponent<HorizontalLayoutGroup>();
		((HorizontalOrVerticalLayoutGroup)val).spacing = spacing;
		((LayoutGroup)val).childAlignment = alignment;
		((HorizontalOrVerticalLayoutGroup)val).childForceExpandWidth = false;
		((HorizontalOrVerticalLayoutGroup)val).childForceExpandHeight = false;
		((LayoutGroup)val).padding = new RectOffset(padLeft, padRight, padTop, padBottom);
	}

	public static void SetLayoutGroupPadding(LayoutGroup layoutGroup, int left, int right, int top, int bottom)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		layoutGroup.padding = new RectOffset(left, right, top, bottom);
	}

	public static void BindAcceptButton(Button btn, Text label, string text, UnityAction callback)
	{
		label.text = text;
		((UnityEventBase)btn.onClick).RemoveAllListeners();
		((UnityEvent)btn.onClick).AddListener(callback);
	}
}

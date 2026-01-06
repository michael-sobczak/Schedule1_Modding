using System;
using System.IO;
using MelonLoader.Utils;
using S1API.Internal.Abstraction;
using S1API.Internal.Patches;
using S1API.Logging;
using ScheduleOne;
using ScheduleOne.DevUtilities;
using ScheduleOne.UI.Phone;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace S1API.PhoneApp;

public abstract class PhoneApp : Registerable
{
	public enum EOrientation
	{
		Horizontal,
		Vertical
	}

	protected static readonly Log Logger = new Log("PhoneApp");

	private GameObject? _appPanel;

	private bool _appCreated;

	private bool _iconModified;

	private Image? _iconImage;

	private Sprite? _pendingIconSprite;

	private HomeScreen? _homeScreenInstance;

	private Action? _closeAppAction;

	private ExitDelegate? _exitDelegate;

	private Action? _onPhoneClosedAction;

	protected abstract string AppName { get; }

	protected abstract string AppTitle { get; }

	protected abstract string IconLabel { get; }

	protected abstract string IconFileName { get; }

	protected virtual Sprite? IconSprite => null;

	protected virtual EOrientation Orientation => EOrientation.Horizontal;

	protected abstract void OnCreatedUI(GameObject container);

	protected override void OnCreated()
	{
		PhoneAppRegistry.Register(this);
	}

	protected override void OnDestroyed()
	{
		if ((Object)(object)_appPanel != (Object)null)
		{
			Object.Destroy((Object)(object)_appPanel);
			_appPanel = null;
		}
		_appCreated = false;
		_iconModified = false;
		_iconImage = null;
		_pendingIconSprite = null;
		if (PlayerSingleton<Phone>.InstanceExists && _closeAppAction != null)
		{
			Phone instance = PlayerSingleton<Phone>.Instance;
			instance.closeApps = (Action)Delegate.Remove(instance.closeApps, _closeAppAction);
			_closeAppAction = null;
		}
		if (_exitDelegate != null)
		{
			GameInput.DeregisterExitListener(_exitDelegate);
			_exitDelegate = null;
		}
		if (PlayerSingleton<Phone>.InstanceExists && _onPhoneClosedAction != null)
		{
			Phone instance2 = PlayerSingleton<Phone>.Instance;
			instance2.onPhoneClosed = (Action)Delegate.Remove(instance2.onPhoneClosed, _onPhoneClosedAction);
			_onPhoneClosedAction = null;
		}
	}

	public virtual void Exit(ExitAction exit)
	{
		if (!exit.Used && IsOpen() && PlayerSingleton<Phone>.InstanceExists && PlayerSingleton<Phone>.Instance.IsOpen)
		{
			exit.Used = true;
			CloseApp();
		}
	}

	protected virtual void OnPhoneClosed()
	{
	}

	public bool IsOpen()
	{
		return (Object)(object)_appPanel != (Object)null && _appPanel.activeInHierarchy && (Object)(object)Phone.ActiveApp == (Object)(object)_appPanel;
	}

	internal void SpawnUI(HomeScreen homeScreenInstance)
	{
		//IL_01b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c2: Expected O, but got Unknown
		_homeScreenInstance = homeScreenInstance;
		Transform obj = ((Component)homeScreenInstance).transform.parent.Find("AppsCanvas");
		GameObject val = ((obj != null) ? ((Component)obj).gameObject : null);
		if ((Object)(object)val == (Object)null)
		{
			Logger.Error("AppsCanvas not found.");
			return;
		}
		Transform val2 = val.transform.Find(AppName);
		if ((Object)(object)val2 != (Object)null)
		{
			_appPanel = ((Component)val2).gameObject;
			SetupExistingAppPanel(_appPanel);
		}
		else
		{
			Transform val3 = val.transform.Find("ProductManagerApp");
			if ((Object)(object)val3 == (Object)null)
			{
				Logger.Error("Template ProductManagerApp not found.");
				return;
			}
			_appPanel = Object.Instantiate<GameObject>(((Component)val3).gameObject, val.transform);
			((Object)_appPanel).name = AppName;
			Transform val4 = _appPanel.transform.Find("Container");
			if ((Object)(object)val4 != (Object)null)
			{
				GameObject gameObject = ((Component)val4).gameObject;
				ClearContainer(gameObject);
				OnCreatedUI(gameObject);
			}
			_appCreated = true;
		}
		_appPanel.SetActive(true);
		if ((Object)(object)_appPanel.GetComponent<PhoneAppButtonHandler>() == (Object)null)
		{
			PhoneAppButtonHandler phoneAppButtonHandler = _appPanel.AddComponent<PhoneAppButtonHandler>();
			phoneAppButtonHandler.phoneApp = this;
		}
		if (PlayerSingleton<Phone>.InstanceExists)
		{
			_closeAppAction = CloseApp;
			Phone instance = PlayerSingleton<Phone>.Instance;
			instance.closeApps = (Action)Delegate.Combine(instance.closeApps, _closeAppAction);
			_exitDelegate = new ExitDelegate(Exit);
			GameInput.RegisterExitListener(_exitDelegate, 1);
			_onPhoneClosedAction = OnPhoneClosed;
			Phone instance2 = PlayerSingleton<Phone>.Instance;
			instance2.onPhoneClosed = (Action)Delegate.Combine(instance2.onPhoneClosed, _onPhoneClosedAction);
		}
	}

	internal void SpawnIcon(HomeScreen homeScreenInstance)
	{
		if (_iconModified)
		{
			return;
		}
		Transform obj = ((Component)homeScreenInstance).transform.Find("AppIcons");
		GameObject val = ((obj != null) ? ((Component)obj).gameObject : null);
		if ((Object)(object)val == (Object)null)
		{
			Logger.Error("AppIcons not found under HomeScreen.");
			return;
		}
		Transform val2 = ((val.transform.childCount > 0) ? val.transform.GetChild(val.transform.childCount - 1) : null);
		if ((Object)(object)val2 == (Object)null)
		{
			Logger.Error("No icons found in AppIcons.");
			return;
		}
		GameObject gameObject = ((Component)val2).gameObject;
		((Object)gameObject).name = AppName;
		Transform val3 = gameObject.transform.Find("Mask/Image");
		_iconImage = (((Object)(object)val3 != (Object)null) ? ((Component)val3).GetComponent<Image>() : null);
		Transform val4 = gameObject.transform.Find("Label");
		Text val5 = ((val4 != null) ? ((Component)val4).GetComponent<Text>() : null);
		if ((Object)(object)val5 != (Object)null)
		{
			val5.text = IconLabel;
		}
		if ((Object)(object)_iconImage != (Object)null)
		{
			Sprite val6 = (((Object)(object)_pendingIconSprite != (Object)null) ? _pendingIconSprite : IconSprite);
			if ((Object)(object)val6 != (Object)null)
			{
				_iconImage.sprite = val6;
				_iconModified = true;
				_pendingIconSprite = null;
			}
			else
			{
				_iconModified = ChangeAppIconImage(gameObject, IconFileName);
			}
		}
		else
		{
			_iconModified = ChangeAppIconImage(gameObject, IconFileName);
		}
		Button component = gameObject.GetComponent<Button>();
		if ((Object)(object)component != (Object)null)
		{
			((UnityEventBase)component.onClick).RemoveAllListeners();
			EventHelper.AddListener(OpenApp, (UnityEvent)(object)component.onClick);
		}
	}

	public void OpenApp()
	{
		try
		{
			if ((Object)(object)Phone.ActiveApp != (Object)null && (Object)(object)Phone.ActiveApp != (Object)(object)_appPanel)
			{
				PlayerSingleton<Phone>.Instance.RequestCloseApp();
			}
			SetAppOpen(open: true);
			Logger.Msg("Opened phone app: " + AppName);
		}
		catch (Exception ex)
		{
			Logger.Error("Failed to open phone app " + AppName + ": " + ex.Message);
		}
	}

	public void CloseApp()
	{
		try
		{
			if (IsOpen())
			{
				SetAppOpen(open: false);
			}
			Logger.Msg("Closed phone app: " + AppName);
		}
		catch (Exception ex)
		{
			Logger.Error("Failed to close phone app " + AppName + ": " + ex.Message);
		}
	}

	private void SetAppOpen(bool open)
	{
		if (open && (Object)(object)Phone.ActiveApp != (Object)null && (Object)(object)Phone.ActiveApp != (Object)(object)_appPanel)
		{
			Logger.Warning(((Object)Phone.ActiveApp).name + " is already open");
			return;
		}
		if (PlayerSingleton<AppsCanvas>.InstanceExists)
		{
			PlayerSingleton<AppsCanvas>.Instance.SetIsOpen(open);
		}
		if (PlayerSingleton<HomeScreen>.InstanceExists)
		{
			PlayerSingleton<HomeScreen>.Instance.SetIsOpen(!open);
		}
		if (open)
		{
			if (Orientation == EOrientation.Horizontal)
			{
				if (PlayerSingleton<Phone>.InstanceExists)
				{
					PlayerSingleton<Phone>.Instance.SetIsHorizontal(true);
					PlayerSingleton<Phone>.Instance.SetLookOffsetMultiplier(0.6f);
				}
			}
			else if (PlayerSingleton<Phone>.InstanceExists)
			{
				PlayerSingleton<Phone>.Instance.SetLookOffsetMultiplier(1f);
			}
			Phone.ActiveApp = _appPanel;
			if ((Object)(object)_appPanel != (Object)null)
			{
				Transform val = _appPanel.transform.Find("Container");
				GameObject val2 = (((Object)(object)val != (Object)null) ? ((Component)val).gameObject : null);
				if ((Object)(object)val2 != (Object)null)
				{
					val2.SetActive(true);
				}
			}
			return;
		}
		if ((Object)(object)Phone.ActiveApp == (Object)(object)_appPanel)
		{
			Phone.ActiveApp = null;
		}
		if (PlayerSingleton<Phone>.InstanceExists)
		{
			PlayerSingleton<Phone>.Instance.SetIsHorizontal(false);
			PlayerSingleton<Phone>.Instance.SetLookOffsetMultiplier(1f);
		}
		if ((Object)(object)_appPanel != (Object)null)
		{
			Transform val3 = _appPanel.transform.Find("Container");
			GameObject val4 = (((Object)(object)val3 != (Object)null) ? ((Component)val3).gameObject : null);
			if ((Object)(object)val4 != (Object)null)
			{
				val4.SetActive(false);
			}
		}
	}

	private void SetupExistingAppPanel(GameObject panel)
	{
		Transform val = panel.transform.Find("Container");
		if ((Object)(object)val != (Object)null)
		{
			GameObject gameObject = ((Component)val).gameObject;
			if (gameObject.transform.childCount < 2)
			{
				ClearContainer(gameObject);
				OnCreatedUI(gameObject);
			}
		}
		_appCreated = true;
	}

	private void ClearContainer(GameObject container)
	{
		for (int num = container.transform.childCount - 1; num >= 0; num--)
		{
			Object.Destroy((Object)(object)((Component)container.transform.GetChild(num)).gameObject);
		}
		container.SetActive(false);
	}

	private bool ChangeAppIconImage(GameObject iconObj, string filename)
	{
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Expected O, but got Unknown
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		Transform val = iconObj.transform.Find("Mask/Image");
		Image val2 = ((val != null) ? ((Component)val).GetComponent<Image>() : null);
		if ((Object)(object)val2 == (Object)null)
		{
			Logger.Error("Image component not found in icon.");
			return false;
		}
		string text = Path.Combine(MelonEnvironment.ModsDirectory, filename);
		if (!File.Exists(text))
		{
			Logger.Error("Icon file not found: " + text);
			return false;
		}
		try
		{
			byte[] array = File.ReadAllBytes(text);
			Texture2D val3 = new Texture2D(2, 2);
			if (ImageConversion.LoadImage(val3, array))
			{
				val2.sprite = Sprite.Create(val3, new Rect(0f, 0f, (float)((Texture)val3).width, (float)((Texture)val3).height), new Vector2(0.5f, 0.5f));
				return true;
			}
			Object.Destroy((Object)(object)val3);
		}
		catch (Exception ex)
		{
			Logger.Error("Failed to load image: " + ex.Message);
		}
		return false;
	}

	public bool SetIconSprite(Sprite sprite)
	{
		if ((Object)(object)sprite == (Object)null)
		{
			return false;
		}
		if ((Object)(object)_iconImage != (Object)null)
		{
			_iconImage.sprite = sprite;
			_iconModified = true;
			_pendingIconSprite = null;
			return true;
		}
		_pendingIconSprite = sprite;
		return true;
	}

	public bool SetIconTexture(Texture2D texture)
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)texture == (Object)null)
		{
			return false;
		}
		Sprite iconSprite = Sprite.Create(texture, new Rect(0f, 0f, (float)((Texture)texture).width, (float)((Texture)texture).height), new Vector2(0.5f, 0.5f));
		return SetIconSprite(iconSprite);
	}
}

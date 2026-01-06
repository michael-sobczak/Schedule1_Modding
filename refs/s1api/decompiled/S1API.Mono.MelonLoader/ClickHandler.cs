using UnityEngine.Events;

public class ClickHandler
{
	private readonly UnityAction _callback;

	public ClickHandler(UnityAction callback)
	{
		_callback = callback;
	}

	public void OnClick()
	{
		_callback.Invoke();
	}
}

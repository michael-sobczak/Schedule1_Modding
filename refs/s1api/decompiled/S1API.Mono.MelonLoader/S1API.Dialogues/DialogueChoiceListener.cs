using System;
using ScheduleOne.Dialogue;
using UnityEngine;
using UnityEngine.Events;

namespace S1API.Dialogues;

public static class DialogueChoiceListener
{
	private static string? _expectedChoiceLabel;

	private static Action? _callback;

	public static void Register(DialogueHandler handlerRef, string label, Action action)
	{
		_expectedChoiceLabel = label;
		_callback = action;
		if (!((Object)(object)handlerRef != (Object)null))
		{
			return;
		}
		handlerRef.onDialogueChoiceChosen.AddListener((UnityAction<string>)delegate(string choice)
		{
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			if (choice == _expectedChoiceLabel)
			{
				new UnityAction(ForwardCall).Invoke();
			}
		});
		static void ForwardCall()
		{
			OnChoice();
		}
	}

	private static void OnChoice()
	{
		_callback?.Invoke();
		_callback = null;
	}
}

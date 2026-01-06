using System;
using Il2CppScheduleOne.Dialogue;
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
		handlerRef.onDialogueChoiceChosen.AddListener(UnityAction<string>.op_Implicit((Action<string>)delegate(string choice)
		{
			if (choice == _expectedChoiceLabel)
			{
				UnityAction.op_Implicit((Action)ForwardCall).Invoke();
			}
		}));
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

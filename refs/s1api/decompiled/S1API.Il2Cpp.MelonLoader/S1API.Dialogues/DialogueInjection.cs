using System;
using S1API.Entities;

namespace S1API.Dialogues;

public class DialogueInjection
{
	public Predicate<NPC> AppliesTo;

	public string ContainerName;

	public string FromNodeGuid;

	public string ToNodeGuid;

	public string ChoiceLabel;

	public string ChoiceText;

	public Action OnConfirmed;

	public DialogueInjection(Predicate<NPC> appliesToNpc, string container, string from, string to, string label, string text, Action onConfirmed)
	{
		AppliesTo = appliesToNpc;
		ContainerName = container;
		FromNodeGuid = from;
		ToNodeGuid = to;
		ChoiceLabel = label;
		ChoiceText = text;
		OnConfirmed = onConfirmed;
	}

	public DialogueInjection(string npc, string container, string from, string to, string label, string text, Action onConfirmed)
		: this((NPC x) => x.ID.Equals(npc), container, from, to, label, text, onConfirmed)
	{
	}
}

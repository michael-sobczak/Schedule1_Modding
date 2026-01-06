using System;
using S1API.Internal.Abstraction;
using S1API.Internal.Utils;
using S1API.PhoneCalls.Constants;
using S1API.Quests;
using S1API.Quests.Constants;
using ScheduleOne.Quests;
using ScheduleOne.Variables;

namespace S1API.Conditions;

public class SystemTriggerEntry
{
	internal readonly SystemTrigger S1SystemTrigger;

	public event Action OnEvaluateTrue
	{
		add
		{
			EventHelper.AddListener(value, S1SystemTrigger.onEvaluateTrue);
		}
		remove
		{
			EventHelper.RemoveListener(value, S1SystemTrigger.onEvaluateTrue);
		}
	}

	public event Action OnEvaluateFalse
	{
		add
		{
			EventHelper.AddListener(value, S1SystemTrigger.onEvaluateFalse);
		}
		remove
		{
			EventHelper.RemoveListener(value, S1SystemTrigger.onEvaluateFalse);
		}
	}

	internal SystemTriggerEntry(SystemTrigger systemTrigger)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected O, but got Unknown
		S1SystemTrigger = systemTrigger;
		S1SystemTrigger.Conditions = new Conditions();
		Conditions conditions = S1SystemTrigger.Conditions;
		if (conditions.ConditionList == null)
		{
			conditions.ConditionList = Array.Empty<Condition>();
		}
		conditions = S1SystemTrigger.Conditions;
		if (conditions.QuestConditionList == null)
		{
			conditions.QuestConditionList = Array.Empty<QuestCondition>();
		}
		SystemTrigger s1SystemTrigger = S1SystemTrigger;
		if (s1SystemTrigger.onEvaluateTrueVariableSetters == null)
		{
			s1SystemTrigger.onEvaluateTrueVariableSetters = Array.Empty<VariableSetter>();
		}
		s1SystemTrigger = S1SystemTrigger;
		if (s1SystemTrigger.onEvaluateFalseVariableSetters == null)
		{
			s1SystemTrigger.onEvaluateFalseVariableSetters = Array.Empty<VariableSetter>();
		}
		s1SystemTrigger = S1SystemTrigger;
		if (s1SystemTrigger.onEvaluateTrueQuestSetters == null)
		{
			s1SystemTrigger.onEvaluateTrueQuestSetters = Array.Empty<QuestStateSetter>();
		}
		s1SystemTrigger = S1SystemTrigger;
		if (s1SystemTrigger.onEvaluateFalseQuestSetters == null)
		{
			s1SystemTrigger.onEvaluateFalseQuestSetters = Array.Empty<QuestStateSetter>();
		}
	}

	public void AddVariableSetter(EvaluationType evaluation, string variableName, string newValue)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		VariableSetter item = new VariableSetter
		{
			VariableName = variableName,
			NewValue = newValue
		};
		switch (evaluation)
		{
		case EvaluationType.PassOnTrue:
			S1SystemTrigger.onEvaluateTrueVariableSetters = S1SystemTrigger.onEvaluateTrueVariableSetters.AddItemToArray(item);
			break;
		case EvaluationType.PassOnFalse:
			S1SystemTrigger.onEvaluateFalseVariableSetters = S1SystemTrigger.onEvaluateFalseVariableSetters.AddItemToArray(item);
			break;
		}
	}

	public void AddQuestSetter(EvaluationType evaluation, Quest questData, QuestAction? questAction = null, Tuple<int, QuestState>? questEntryState = null)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		QuestStateSetter val = new QuestStateSetter
		{
			QuestName = questData.S1Quest.Title
		};
		if (questAction.HasValue)
		{
			val.SetQuestState = true;
			val.QuestState = (EQuestAction)questAction.Value;
		}
		if (questEntryState != null)
		{
			val.SetQuestEntryState = true;
			val.QuestEntryIndex = questEntryState.Item1;
			val.QuestEntryState = (EQuestState)questEntryState.Item2;
		}
		switch (evaluation)
		{
		case EvaluationType.PassOnTrue:
			S1SystemTrigger.onEvaluateTrueQuestSetters = S1SystemTrigger.onEvaluateTrueQuestSetters.AddItemToArray(val);
			break;
		case EvaluationType.PassOnFalse:
			S1SystemTrigger.onEvaluateFalseQuestSetters = S1SystemTrigger.onEvaluateFalseQuestSetters.AddItemToArray(val);
			break;
		}
	}

	public void Trigger()
	{
		S1SystemTrigger.Trigger();
	}
}

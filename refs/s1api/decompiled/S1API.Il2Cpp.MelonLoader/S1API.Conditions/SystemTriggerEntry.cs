using System;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppScheduleOne.Quests;
using Il2CppScheduleOne.Variables;
using S1API.Internal.Abstraction;
using S1API.Internal.Utils;
using S1API.PhoneCalls.Constants;
using S1API.Quests;
using S1API.Quests.Constants;

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
			Il2CppReferenceArray<Condition> val = (conditions.ConditionList = Il2CppReferenceArray<Condition>.op_Implicit(Array.Empty<Condition>()));
		}
		conditions = S1SystemTrigger.Conditions;
		if (conditions.QuestConditionList == null)
		{
			Il2CppReferenceArray<QuestCondition> val3 = (conditions.QuestConditionList = Il2CppReferenceArray<QuestCondition>.op_Implicit(Array.Empty<QuestCondition>()));
		}
		SystemTrigger s1SystemTrigger = S1SystemTrigger;
		if (s1SystemTrigger.onEvaluateTrueVariableSetters == null)
		{
			Il2CppReferenceArray<VariableSetter> val5 = (s1SystemTrigger.onEvaluateTrueVariableSetters = Il2CppReferenceArray<VariableSetter>.op_Implicit(Array.Empty<VariableSetter>()));
		}
		s1SystemTrigger = S1SystemTrigger;
		if (s1SystemTrigger.onEvaluateFalseVariableSetters == null)
		{
			Il2CppReferenceArray<VariableSetter> val5 = (s1SystemTrigger.onEvaluateFalseVariableSetters = Il2CppReferenceArray<VariableSetter>.op_Implicit(Array.Empty<VariableSetter>()));
		}
		s1SystemTrigger = S1SystemTrigger;
		if (s1SystemTrigger.onEvaluateTrueQuestSetters == null)
		{
			Il2CppReferenceArray<QuestStateSetter> val8 = (s1SystemTrigger.onEvaluateTrueQuestSetters = Il2CppReferenceArray<QuestStateSetter>.op_Implicit(Array.Empty<QuestStateSetter>()));
		}
		s1SystemTrigger = S1SystemTrigger;
		if (s1SystemTrigger.onEvaluateFalseQuestSetters == null)
		{
			Il2CppReferenceArray<QuestStateSetter> val8 = (s1SystemTrigger.onEvaluateFalseQuestSetters = Il2CppReferenceArray<QuestStateSetter>.op_Implicit(Array.Empty<QuestStateSetter>()));
		}
	}

	public void AddVariableSetter(EvaluationType evaluation, string variableName, string newValue)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected O, but got Unknown
		VariableSetter val = new VariableSetter
		{
			VariableName = variableName,
			NewValue = newValue
		};
		switch (evaluation)
		{
		case EvaluationType.PassOnTrue:
			S1SystemTrigger.onEvaluateTrueVariableSetters = S1SystemTrigger.onEvaluateTrueVariableSetters.AddItemToArray<VariableSetter>((VariableSetter[]?)(object)new VariableSetter[1] { val });
			break;
		case EvaluationType.PassOnFalse:
			S1SystemTrigger.onEvaluateFalseVariableSetters = S1SystemTrigger.onEvaluateFalseVariableSetters.AddItemToArray<VariableSetter>((VariableSetter[]?)(object)new VariableSetter[1] { val });
			break;
		}
	}

	public void AddQuestSetter(EvaluationType evaluation, Quest questData, QuestAction? questAction = null, Tuple<int, QuestState>? questEntryState = null)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
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
			S1SystemTrigger.onEvaluateTrueQuestSetters = S1SystemTrigger.onEvaluateTrueQuestSetters.AddItemToArray<QuestStateSetter>((QuestStateSetter[]?)(object)new QuestStateSetter[1] { val });
			break;
		case EvaluationType.PassOnFalse:
			S1SystemTrigger.onEvaluateFalseQuestSetters = S1SystemTrigger.onEvaluateFalseQuestSetters.AddItemToArray<QuestStateSetter>((QuestStateSetter[]?)(object)new QuestStateSetter[1] { val });
			break;
		}
	}

	public void Trigger()
	{
		S1SystemTrigger.Trigger();
	}
}

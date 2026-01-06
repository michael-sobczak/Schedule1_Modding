using System;
using System.Collections.Generic;
using System.Reflection;
using ScheduleOne.Dialogue;
using UnityEngine;

namespace S1API.Entities.Dialogue;

public sealed class DialogueContainerBuilder
{
	public sealed class ChoiceList
	{
		private readonly NodeSpec _node;

		private ChoiceList(NodeSpec node)
		{
			_node = node;
		}

		public ChoiceList Add(string choiceLabel, string shownText, string targetNodeLabel = null)
		{
			if (string.IsNullOrEmpty(choiceLabel))
			{
				return this;
			}
			ChoiceSpec choiceSpec = _node.AddChoice(choiceLabel, shownText ?? string.Empty);
			if (!string.IsNullOrEmpty(targetNodeLabel))
			{
				_node.Builder._links.Add(new LinkSpec(_node.Label, choiceSpec.Label, targetNodeLabel));
			}
			return this;
		}
	}

	private sealed class NodeSpec
	{
		internal readonly string Guid = System.Guid.NewGuid().ToString();

		internal readonly DialogueContainerBuilder Builder;

		internal readonly List<ChoiceSpec> Choices = new List<ChoiceSpec>();

		internal string Label;

		internal string Text;

		internal NodeSpec(DialogueContainerBuilder builder, string label, string text)
		{
			Builder = builder;
			Label = label;
			Text = text;
		}

		internal ChoiceSpec AddChoice(string label, string text)
		{
			ChoiceSpec choiceSpec = new ChoiceSpec(label, text);
			Choices.Add(choiceSpec);
			return choiceSpec;
		}

		internal ChoiceSpec GetChoice(string label)
		{
			return Choices.Find((ChoiceSpec x) => string.Equals(x.Label, label, StringComparison.OrdinalIgnoreCase));
		}
	}

	private sealed class ChoiceSpec
	{
		internal readonly string Guid = System.Guid.NewGuid().ToString();

		internal readonly string Label;

		internal readonly string Text;

		internal ChoiceSpec(string label, string text)
		{
			Label = label;
			Text = text;
		}
	}

	private readonly struct LinkSpec
	{
		internal readonly string FromNodeLabel;

		internal readonly string ChoiceLabel;

		internal readonly string ToNodeLabel;

		internal LinkSpec(string from, string choice, string to)
		{
			FromNodeLabel = from;
			ChoiceLabel = choice;
			ToNodeLabel = to;
		}
	}

	private readonly Dictionary<string, NodeSpec> _nodes = new Dictionary<string, NodeSpec>(StringComparer.OrdinalIgnoreCase);

	private readonly List<LinkSpec> _links = new List<LinkSpec>();

	private bool _allowExit = true;

	public DialogueContainerBuilder AddNode(string nodeLabel, string text, Action<ChoiceList> choices = null)
	{
		if (string.IsNullOrEmpty(nodeLabel))
		{
			return this;
		}
		if (!_nodes.TryGetValue(nodeLabel, out NodeSpec value))
		{
			value = new NodeSpec(this, nodeLabel, text ?? string.Empty);
			_nodes[nodeLabel] = value;
		}
		else
		{
			value.Text = text ?? string.Empty;
		}
		if (choices != null)
		{
			ChoiceList obj = (ChoiceList)typeof(ChoiceList).GetConstructor(BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[1] { typeof(NodeSpec) }, null).Invoke(new object[1] { value });
			choices(obj);
		}
		return this;
	}

	public DialogueContainerBuilder SetAllowExit(bool allow)
	{
		_allowExit = allow;
		return this;
	}

	internal DialogueContainer Build(string containerName)
	{
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Expected O, but got Unknown
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_014d: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_016c: Expected O, but got Unknown
		DialogueContainer val = ScriptableObject.CreateInstance<DialogueContainer>();
		((Object)val).name = (string.IsNullOrEmpty(containerName) ? "CustomContainer" : containerName);
		List<DialogueNodeData> list = new List<DialogueNodeData>();
		foreach (KeyValuePair<string, NodeSpec> node in _nodes)
		{
			NodeSpec value = node.Value;
			DialogueNodeData item = new DialogueNodeData
			{
				Guid = value.Guid,
				DialogueNodeLabel = value.Label,
				DialogueText = value.Text,
				Position = Vector2.zero,
				choices = BuildChoices(value)
			};
			list.Add(item);
		}
		val.DialogueNodeData = ToIl2CppList(list);
		List<NodeLinkData> list2 = new List<NodeLinkData>();
		foreach (LinkSpec link in _links)
		{
			if (_nodes.TryGetValue(link.FromNodeLabel, out NodeSpec value2))
			{
				ChoiceSpec choice = value2.GetChoice(link.ChoiceLabel);
				if (choice != null && _nodes.TryGetValue(link.ToNodeLabel, out NodeSpec value3))
				{
					list2.Add(new NodeLinkData
					{
						BaseDialogueOrBranchNodeGuid = value2.Guid,
						BaseChoiceOrOptionGUID = choice.Guid,
						TargetNodeGuid = value3.Guid
					});
				}
			}
		}
		val.NodeLinks = ToIl2CppList(list2);
		val.SetAllowExit(_allowExit);
		return val;
	}

	private static DialogueChoiceData[] BuildChoices(NodeSpec node)
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected O, but got Unknown
		List<DialogueChoiceData> list = new List<DialogueChoiceData>();
		foreach (ChoiceSpec choice in node.Choices)
		{
			list.Add(new DialogueChoiceData
			{
				Guid = choice.Guid,
				ChoiceLabel = choice.Label,
				ChoiceText = choice.Text,
				ShowWorldspaceDialogue = true
			});
		}
		return list.ToArray();
	}

	private static List<T> ToIl2CppList<T>(List<T> source)
	{
		return source;
	}
}

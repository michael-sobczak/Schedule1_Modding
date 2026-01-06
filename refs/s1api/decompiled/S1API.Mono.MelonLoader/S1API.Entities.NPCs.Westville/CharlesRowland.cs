using System.Linq;
using ScheduleOne.NPCs;

namespace S1API.Entities.NPCs.Westville;

public class CharlesRowland : NPC
{
	public new static string NPCId => "charles_rowland";

	internal CharlesRowland()
		: base(NPCManager.NPCRegistry.ToArray().First((NPC n) => n.ID == "charles_rowland"))
	{
	}
}

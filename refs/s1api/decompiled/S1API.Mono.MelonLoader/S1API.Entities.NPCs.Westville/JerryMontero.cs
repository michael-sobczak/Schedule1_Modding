using System.Linq;
using ScheduleOne.NPCs;

namespace S1API.Entities.NPCs.Westville;

public class JerryMontero : NPC
{
	public new static string NPCId => "jerry_montero";

	internal JerryMontero()
		: base(NPCManager.NPCRegistry.ToArray().First((NPC n) => n.ID == "jerry_montero"))
	{
	}
}

using System.Linq;
using ScheduleOne.NPCs;

namespace S1API.Entities.NPCs.Docks;

public class JaneLucero : NPC
{
	public new static string NPCId => "jane_lucero";

	internal JaneLucero()
		: base(NPCManager.NPCRegistry.ToArray().First((NPC n) => n.ID == "jane_lucero"))
	{
	}
}

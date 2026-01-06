using System.Linq;
using ScheduleOne.NPCs;

namespace S1API.Entities.NPCs.Northtown;

public class KyleCooley : NPC
{
	public new static string NPCId => "kyle_cooley";

	internal KyleCooley()
		: base(NPCManager.NPCRegistry.ToArray().First((NPC n) => n.ID == "kyle_cooley"))
	{
	}
}

using System.Linq;
using ScheduleOne.NPCs;

namespace S1API.Entities.NPCs.Uptown;

public class PearlMoore : NPC
{
	public new static string NPCId => "pearl_moore";

	internal PearlMoore()
		: base(NPCManager.NPCRegistry.ToArray().First((NPC n) => n.ID == "pearl_moore"))
	{
	}
}

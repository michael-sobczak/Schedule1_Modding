using System.Linq;
using ScheduleOne.NPCs;

namespace S1API.Entities.NPCs.Northtown;

public class AustinSteiner : NPC
{
	public new static string NPCId => "austin_steiner";

	internal AustinSteiner()
		: base(NPCManager.NPCRegistry.ToArray().First((NPC n) => n.ID == "austin_steiner"))
	{
	}
}

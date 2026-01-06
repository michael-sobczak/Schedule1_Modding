using System.Linq;
using ScheduleOne.NPCs;

namespace S1API.Entities.NPCs.Docks;

public class JavierPerez : NPC
{
	public new static string NPCId => "javier_perez";

	internal JavierPerez()
		: base(NPCManager.NPCRegistry.ToArray().First((NPC n) => n.ID == "javier_perez"))
	{
	}
}

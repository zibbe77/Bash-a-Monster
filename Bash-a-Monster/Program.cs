using System;
#region Start
Player hero = new Player();
Text.Start();
Text.Continue();
#endregion

#region Game
Combat.TurnCombat(hero);

#endregion
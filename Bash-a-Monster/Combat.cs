using System;
public class Combat
{
    int turn = 1;
    public List<Figther> Figthers = new List<Figther>();
    public void TurnCombat(Figther h)
    {
        Figthers.Add(h);
        Slime slime = new Slime();
        slime.CreatSlime();
        
        Text.Continue();
    }
}

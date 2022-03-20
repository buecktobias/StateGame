﻿namespace Application;

public class QuitTransition : AbstractTransition
{
    public override bool Matches(string input, IGameInformation gameInformation)
    {
        return input == "quit";
    }

    public override IGameInformation Execute(string input, IGameInformation gameInformation)
    {
        return gameInformation;
    }

    public override IState GetTargetState()
    {
        return this.StateFactory.GetQuitState();
    }

    public override string GetOutput()
    {
        return "Quit";
    }
}
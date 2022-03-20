﻿namespace Application;

public class StartState : AbstractState
{
    public override void CreateTransitions()
    {
    }

    public override string GetIntroOutput()
    {
        return "Game Has Started";
    }
    

    public override string GetOutroOutput()
    {
        return "";
    }

    public override bool IsEndState()
    {
        return false;
    }

    public override IGameInformation Execute(IGameInformation gameInformation)
    {
        return gameInformation;
    }
}
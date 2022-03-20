﻿using Application.States;

namespace Application.StateFactory;

public class StateFactory : IStateFactory
{
    private static IStateFactory? _instance;
    private IState? _gameOpponentTurn;
    private IState? _gameStartState;
    private IState? _quitState;

    private StateFactory()
    {
    }

    public IState GetQuitState()
    {
        if (_quitState == null) _quitState = new QuitState();
        return _quitState;
    }

    public IState GetOpponentsTurnState()
    {
        if (_gameOpponentTurn == null) _gameOpponentTurn = new OpponentsTurnState();
        return _gameOpponentTurn;
    }

    public IState GetGameStartState()
    {
        if (_gameStartState == null) _gameStartState = new RockPaperScissorGameStart();
        return _gameStartState;
    }
    

    public static IStateFactory GetInstance()
    {
        if (_instance == null) _instance = new StateFactory();

        return _instance;
    }
}
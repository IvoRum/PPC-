using System;
namespace Zad2;

public class Context
{
    private State _state = null;
    private int stateCounter;
    private int teamApoints;
    private int teamBpoints;

    public int StateCounter1
    {
        get => stateCounter;
        set => stateCounter = value;
    }

    public int TeamApoints1
    {
        get => teamApoints;
        set => teamApoints = value;
    }

    public int TeamBpoints1
    {
        get => teamBpoints;
        set => teamBpoints = value;
    }

    public Context(State state)
    {
        this.TransitionTo(state);
    }

    public void TransitionTo(State state)
    {
        Console.WriteLine($"Context: Transition to {state.GetType().Name}.");
        this._state = state;
        this._state.SetContext(this);
    }
    

    public void score()
    {
        _state.score();
    }

    public void miss()
    {
        _state.miss();
    }
}
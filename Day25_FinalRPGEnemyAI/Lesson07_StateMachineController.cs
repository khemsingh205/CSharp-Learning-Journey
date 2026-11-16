
using System;

public interface IState
{
    void Enter();
    void Update();
    void Exit();
}


public class IdleState : IState
{
    public void Enter()
    {
        Console.WriteLine("Enemy entered Idle State.");
    }

    public void Update()
    {
        Console.WriteLine("Enemy is waiting for player...");
    }

    public void Exit()
    {
        Console.WriteLine("Enemy exited Idle State.");
    }
}


public class ChaseState : IState
{
    public void Enter()
    {
        Console.WriteLine("Enemy started chasing player.");
    }

    public void Update()
    {
        Console.WriteLine("Enemy is chasing player...");
    }

    public void Exit()
    {
        Console.WriteLine("Enemy stopped chasing player.");
    }
}


public class StateMachine
{
    private IState currentState;

    public void ChangeState(IState newState)
    {
        if (currentState != null)
        {
            currentState.Exit();
        }

        currentState = newState;

        if (currentState != null)
        {
            currentState.Enter();
        }
    }

    public void Update()
    {
        if (currentState != null)
        {
            currentState.Update();
        }
    }
}

class Program
{
    static void Main()
    {
        StateMachine enemyAI = new StateMachine();

        IdleState idle = new IdleState();
        ChaseState chase = new ChaseState();

   
        enemyAI.ChangeState(idle);

        enemyAI.Update();

        Console.WriteLine();

      
        enemyAI.ChangeState(chase);

        enemyAI.Update();

        Console.ReadKey();
    }
}

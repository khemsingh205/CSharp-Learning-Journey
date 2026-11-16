

using System;

public interface ILesson08State
{
    void Enter();
    void Update();
    void Exit();
}


public class Lesson08_IdleState : ILesson08State
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

public class Lesson08_ChaseState : ILesson08State
{
    public void Enter()
    {
        Console.WriteLine("Enemy entered Chase State.");
    }

    public void Update()
    {
        Console.WriteLine("Enemy is chasing player...");
    }

    public void Exit()
    {
        Console.WriteLine("Enemy exited Chase State.");
    }
}

// Step 4: Attack State
public class Lesson08_AttackState : ILesson08State
{
    public void Enter()
    {
        Console.WriteLine("Enemy entered Attack State.");
    }

    public void Update()
    {
        Console.WriteLine("Enemy is attacking player!");
    }

    public void Exit()
    {
        Console.WriteLine("Enemy exited Attack State.");
    }
}


public class Lesson08_StateMachine
{
    private ILesson08State currentState;

  
    public event Action<ILesson08State, ILesson08State>
        OnStateChanged;

    public void ChangeState(ILesson08State newState)
    {
        if (currentState == newState)
            return;

        ILesson08State oldState = currentState;

        if (currentState != null)
        {
            currentState.Exit();
        }

        currentState = newState;

        if (currentState != null)
        {
            currentState.Enter();
        }

      
        OnStateChanged?.Invoke(oldState, currentState);
    }

    public void Update()
    {
        if (currentState != null)
        {
            currentState.Update();
        }
    }
}


public class Lesson08_GameManager
{
    public void HandleStateChange(
        ILesson08State oldState,
        ILesson08State newState)
    {
        string oldName = oldState == null
            ? "None"
            : oldState.GetType().Name;

        string newName = newState == null
            ? "None"
            : newState.GetType().Name;

        Console.WriteLine(
            "EVENT: " + oldName + " -> " + newName
        );
    }
}
public class Lesson08_Program
{
    public static void Main()
    {
        Lesson08_StateMachine enemyAI =
            new Lesson08_StateMachine();

        Lesson08_GameManager gameManager =
            new Lesson08_GameManager();

    
        enemyAI.OnStateChanged +=
            gameManager.HandleStateChange;

      
        ILesson08State idle =
            new Lesson08_IdleState();

        ILesson08State chase =
            new Lesson08_ChaseState();

        ILesson08State attack =
            new Lesson08_AttackState();

    
        enemyAI.ChangeState(idle);
        enemyAI.Update();

        Console.WriteLine();

    
        enemyAI.ChangeState(chase);
        enemyAI.Update();

        Console.WriteLine();

      
        enemyAI.ChangeState(attack);
        enemyAI.Update();

        Console.ReadKey();
    }
}

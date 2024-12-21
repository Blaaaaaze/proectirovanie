using System;

class ControlUnit
{
    private List<Command> commands = new List<Command>();

    private int current = 0;

    public void StoreCommand(Command command)
    {
        commands.Add(command);
    }

    public void ExecuteCommand()
    {
        commands[current].Execute();
        current++;
    }

    public void Undo()
    {
        commands[current - 1].UnExecute();
    }

    public void Redo()
    {
        commands[current -1].Execute();
    }

    public void Undo(int levels)
    {
        for (int i = 0; i < levels && current > 0; i++)
        {
            Undo();
        }
    }

    public void Redo(int levels)
    {
        for (int i = 0; i < levels && current < commands.Count; i++)
        {
            Redo();
        }
    }
}
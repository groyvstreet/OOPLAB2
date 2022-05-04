namespace Lab2.Commands
{
    internal class CommandManager
    {
        public delegate void CommandManagerHandler();
        public event CommandManagerHandler Changed;
        private Stack<ICommand> undoStack;
        private Stack<ICommand> redoStack;
        public bool CanUndo
        { 
            get 
            {
                return undoStack.Any(); 
            } 
        }
        public bool CanRedo 
        { 
            get
            { 
                return redoStack.Any();
            } 
        }

        public CommandManager()
        {
            Changed = delegate { };
            undoStack = new Stack<ICommand>();
            redoStack = new Stack<ICommand>();
        }

        public void Undo()
        {
            if (CanUndo)
            {
                var command = undoStack.Pop();
                command.UnExecute();
                redoStack.Push(command);
                Changed();
            }
        }

        public void Redo()
        {
            if (CanRedo)
            {
                var command = redoStack.Pop();
                command.Execute();
                undoStack.Push(command);
                Changed();
            }
        }

        public void Execute(ICommand command)
        {
            command.Execute();
            undoStack.Push(command);
            redoStack.Clear();
            Changed();
        }

        public void UndoAll()
        {
            while(CanUndo)
            {
                Undo();
            }
        }

        public void RedoAll()
        {
            while(CanRedo)
            {
                Redo();
            }
        }
    }
}

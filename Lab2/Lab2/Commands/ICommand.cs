namespace Lab2.Commands
{
    internal interface ICommand
    {
        void Execute();
        void UnExecute();
    }
}

namespace MementoGame.Classes
{
    public class Checkpoint
    {
        private Stack<JogadorMemento> _estados = new Stack<JogadorMemento>();

        public void Salvar(JogadorMemento memento)
        {
            _estados.Push(memento);
        }

        public JogadorMemento Restaurar()
        {
            if (_estados.Count > 0)
            {
                return _estados.Pop();
            }

            Console.WriteLine("Nenhum checkpoint disponível.");
            return null;
        }
    }
}

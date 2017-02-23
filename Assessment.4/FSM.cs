using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment._4
{
    class FSM<T>
    {
        private T m_CurrentState;

        public T CurrentState { get { return m_CurrentState; } }

        List<T> States;
        List<string> Trasnsitions;

        public FSM()
        {
            States = new List<T>();
            Trasnsitions = new List<string>();
            AddStates();
        }

        private void AddStates()
        {
            foreach (var value in Enum.GetValues(typeof(T)))
            {
                States.Add((T)value);
            }
        }
        public void AddTransition(T start, T end, bool CanTraverseBack)
        {
            string transition = CreateTransition(start, end);
            if (States.Contains(start) &&
                States.Contains(end) &&
                !Trasnsitions.Contains(transition))
            {
                Trasnsitions.Add(transition);
                if (CanTraverseBack)
                {
                    transition = CreateTransition(end, start);
                    if (!Trasnsitions.Contains(transition))
                    {
                        Trasnsitions.Add(transition);
                    }
                }
            }
        }

        public void TryTransition(T end)
        {
            string transition = CreateTransition(m_CurrentState, end);
            if (Trasnsitions.Contains(transition))
            {
                m_CurrentState = end;
            }
        }

        private string CreateTransition(T start, T end)
        {
            return start.ToString() + ">" + end.ToString();
        }
    }
}

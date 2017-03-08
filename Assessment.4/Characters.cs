using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment._4
{
    public enum StateManager
    {
        START = 1,
        IDLE = 2,
        CHOOSECHARACTERS = 3,
        ATKORDEF = 4,
        BATTLE = 5,
        END = 6,
    }


    public class Heros
    {
        enum PlayerStates
        {
            INIT, IDLE, ATTACK, DEFEND, DEAD, EXIT
        }

        private string m_Name;
        private int m_Attack;
        private int m_Defense;
        private bool m_Alive;
        private FSM<PlayerStates> HeroFSM;

        public string Name
        {
            get { return m_Name; }
            set { m_Name = value; }
        }
        public int Attack
        {
            get { return m_Attack; }
            set { m_Attack = value; }
        }
        public int Defense
        {
            get { return m_Defense; }
            set { m_Defense = value; }
        }
        public bool Alive
        {
            get { return m_Alive; }
            set { m_Alive = value; }
        }

        public Heros()
        {
            m_Attack = 10;
            m_Defense = 5;
            m_Name = Name;
            m_Alive = true;
            HeroFSM = new FSM<PlayerStates>();
            DefineStateTransitions();

        }

        public Heros(int attack, int defense, string name)
        {
            m_Name = name;
            m_Attack = attack;
            m_Defense = defense;
            m_Alive = true;
            HeroFSM = new FSM<PlayerStates>();
            DefineStateTransitions();
        }

        private void DefineStateTransitions()
        {
            HeroFSM.AddTransition(PlayerStates.INIT, PlayerStates.IDLE, false);
            HeroFSM.AddTransition(PlayerStates.IDLE, PlayerStates.ATTACK, true);
            HeroFSM.AddTransition(PlayerStates.IDLE, PlayerStates.DEFEND, true);
            HeroFSM.AddTransition(PlayerStates.ATTACK, PlayerStates.DEAD, false);
            HeroFSM.AddTransition(PlayerStates.DEFEND, PlayerStates.DEAD, false);
            HeroFSM.AddTransition(PlayerStates.DEAD, PlayerStates.EXIT, false);
        }
    }

    public class Enemy
    {
        int m_Attack;
        bool m_Alive;
        private string m_Name;
        
        public string Name
        {
            get { return m_Name; }
            set { m_Name = value; }
        }
        public int Attack
        {
            get { return m_Attack; }
            set { m_Attack = value; }
        }
        public bool Alive
        {
            get { return m_Alive; }
            set { m_Alive = value; }
        }

        public Enemy()
        {
            m_Name = Name;
            m_Attack = 10;
            m_Alive = true;
        }

        public Enemy(int attack, string name)
        {
            m_Name = name;
            m_Attack = attack;
            m_Alive = true;
        }
    }
}

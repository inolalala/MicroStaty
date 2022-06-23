using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Microstaty
{
    public abstract class AbstractStateContext
    {
        private IState m_state;
        public IState State
        {
            set{ m_state = value; }
            get{ return m_state; }
        }
        
        private Stack<IState> m_statesStack = new Stack<IState>();
        public IState PreviosState
        {
            get
            {
                return m_statesStack.Peek();
            }
        }
    
        public IState[] states;
        public void Initialize()
        {
            m_state = states[0];
            m_statesStack.Push(m_state);
            m_state.OnEnter(0);
        }
    
        public void ChangeState(IState state, params int[] p)
        {
            Debug.Log("ChangeState");
            m_state.OnExit(p);
            m_statesStack.Pop();
            m_statesStack.Push(m_state);
            m_state = state;
            m_state.OnEnter(p);
        }
    }
}

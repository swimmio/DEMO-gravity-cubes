using System;
using System.Collections.Generic;
using UnityEngine;

namespace gamerunner
{
    public class Dispatcher : MonoBehaviour
    {
        private List<IUpdatable> _updatables;
        
        private void Awake()
        {
            _updatables = new List<IUpdatable>();
        }

        private void Update()
        {
            foreach (var updatable in _updatables)
            {
                updatable.Update();
            }
        }
        
        public void addUpdatable(IUpdatable updatable)
        {
            _updatables.Add(updatable);
        }
    }
}
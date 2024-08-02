using System.Collections;
using System.Collections.Generic;
using game.logic.EventQueue;
using network.user;
using UnityEngine;
using UnityEngine.EventSystems;

public class LoginButton : MonoBehaviour
{
    private EventQueue _eventQueue;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
        
    public void Link(EventQueue eventQueue)
    {
        _eventQueue = eventQueue;
    }
    
    public void OnClick()
    {
        UserService userService = new UserService();
        var userName = userService.GetUserName();
        _eventQueue.Enqueue(new UserLoginEvent(this, userName));
    }
}

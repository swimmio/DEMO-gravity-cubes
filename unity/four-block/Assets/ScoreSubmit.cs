using System.Collections;
using System.Collections.Generic;
using game.logic.EventQueue;
using network.score;
using network.user;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ScoreSubmit : MonoBehaviour
{
    [SerializeField] private TMP_InputField _inputField;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void Win()
    {
        var score = int.Parse(_inputField.text);
        ScoreService scoreService = new ScoreService();
        scoreService.SubmitScore(score);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;


[RequireComponent (typeof(BirdMove))]
public class Character : MonoBehaviour
{
    private BirdMove _move;
    private int _score;
    public event UnityAction GameOver;
    public event UnityAction<int>ScoreChanged;
    
    private void Start()
    {
        _move = GetComponent<BirdMove>();
        
    }
    public void ResetGame()
    {
        _score = 0;
        ScoreChanged.Invoke(_score);
        _move.Reset();
    }
    public void DeadInside()
    {
        GameOver.Invoke();
    }
    public void Score()
    {
        _score++;
        ScoreChanged.Invoke(_score);
    }
}

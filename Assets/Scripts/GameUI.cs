using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameUI : MonoBehaviour
{
    [SerializeField] private Character _character;
    [SerializeField] private Generitar _generitar;
    [SerializeField] private StartScreen _startscreen;
    [SerializeField] private GameScreen _gameScreen;

    private void Start()
    {
        Time.timeScale = 0;
        _startscreen.Open();    
    }

    private void OnEnable()
    {
        _startscreen.PlayButtonClick += OnPlayClick;
        _gameScreen.RestartButtonClick += OnRestartClick;
        _character.GameOver += GameOverOn;
    }
    private void OnDisable()
    {
        _startscreen.PlayButtonClick -= OnPlayClick;
        _gameScreen.RestartButtonClick -= OnRestartClick;
        _character.GameOver -= GameOverOn;

    }
    private void OnPlayClick()
    {
        _startscreen.Close();
        StartGame();
    }
    private void OnRestartClick()
    {
        _gameScreen.Close();
        _generitar.ResetPool();
        StartGame();
    }
    private void StartGame()
    {
        Time.timeScale = 1;
        _character.ResetGame(); 
    }

    public void GameOverOn()
    {
        Time.timeScale = 0;
        _gameScreen.Open();
    }
}

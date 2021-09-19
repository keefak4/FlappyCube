using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    [SerializeField] private Character Character;
    [SerializeField] private TMP_Text _score;
    private void OnEnable()
    {
        Character.ScoreChanged += OnScoreChange;
    }
    private void OnDisable()
    {
        Character.ScoreChanged -= OnScoreChange;

    }
    private void OnScoreChange(int score)

    {
        _score.text = score.ToString();
    }
}

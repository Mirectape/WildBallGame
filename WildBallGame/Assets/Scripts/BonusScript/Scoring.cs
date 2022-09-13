using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scoring : MonoBehaviour
{

    public GameObject[] gates;
    private int score;
    public int[] scoresToGain;
    
    private void SetDefaultValues()
    {
        scoresToGain = new int[gates.Length];
        int increment = 30;
        score = 0;
        for (int i = 0; i < gates.Length; i++)
        {
            scoresToGain[i] = increment;
            increment += 30;
        }
    }

    private void Awake()
    {
        SetDefaultValues();
    }

    public void ScoreUp()
    {
        score += 10;
        this.GetComponent<Text>().text = $"Score:\n{score.ToString()}";
        CheckScoringConditions();
    }

    private void CheckScoringConditions()
    {
        for (int i = 0; i < gates.Length; i++)
        {
            if (score == scoresToGain[i]) gates[i].GetComponent<Animator>().SetBool("NeededButtonIsPressed", true);
        }
    }
}

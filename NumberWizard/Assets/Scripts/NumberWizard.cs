using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Diagnostics;
using UnityEngine;
using TMPro;

public class NumberWizard : MonoBehaviour
{
    [SerializeField] int min;
    [SerializeField] int max;
    [SerializeField] TextMeshProUGUI guessText;
    int guess;

    void Start()
    {
        NextGuess();
    }

    public void OnPressHigher()
    {
        if(guess + 1 <= max && min < max)
        {
            min = guess + 1;
        }
        
        NextGuess();
    }

    public void OnPressLower()
    {
        max = guess - 1;
        NextGuess();
    }

    void NextGuess()
    {
        guess = Random.Range(min, max);
        guessText.text = guess.ToString();
    }
}

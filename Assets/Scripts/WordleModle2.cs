using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordleModle2 : MonoBehaviour
{
    [SerializeField] TextAsset myPossibleText;
    [SerializeField] TextAsset myAllowedText;
    [SerializeField] public int HealthPoints = 6;
    string correctAnswer;
    public string uGuess;

    string[,] cells = new string[6, 5];

    public string[] possible;
    public string[] allowed;
    // Start is called before the first frame update
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {

    }
    public void SetUp()
    {
        HealthPoints = 6;
        uGuess = "";
        possible = myPossibleText.text.Split('\n');
        allowed = myAllowedText.text.Split('\n');
        int answerRandom = Random.Range(0, possible.Length);
        correctAnswer = possible[answerRandom];
        Debug.Log(correctAnswer);
    }

    public bool IsValidGuess(string guess)
    {
        Debug.Log("IsValidGuess Called");
        uGuess = guess;
        bool isValid = false;

        if (guess.Length != 5 || HealthPoints < 0)
        {
            Debug.Log("IsValidGuess First Length or Hp Failed");
            isValid = false;
            return isValid;
        }
        else
        {
            for (int i = 0; i < allowed.Length; i++)
            {
                if (uGuess == allowed[i].Trim())
                {
                    Debug.Log("IsValidGuess Valid Allowed");
                    HealthPoints--;
                    isValid = true;
                    GetComponent<WordleView>().update_cells();
                    return isValid;
                }
            }
            for (int i = 0; i < possible.Length; i++)
            {
                if (uGuess == possible[i].Trim())
                {
                    Debug.Log("IsValidGuess Valid Possible");
                    HealthPoints--;
                    isValid = true;
                    GetComponent<WordleView>().update_cells();
                    return isValid;
                }
            }

            Debug.Log("Wrong answer");
            HealthPoints--;
            GetComponent<WordleView>().update_cells();
            return isValid;
        }
    }
    public void UpdateCells()
    {

    }
}

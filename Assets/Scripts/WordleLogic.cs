using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;
public class WordleLogic: MonoBehaviour
{
    [SerializeField] TMP_InputField userGuess;
    //[SerializeField] WordleModel WordleObject;

    // Start is called before the first frame update
    void Start()
    {
        GameSetUp();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    void GameSetUp()
    {
        GetComponent<WordleModle2>().SetUp();
    }
    public void SubmitGuess()
    {
        GetComponent<WordleModle2>().IsValidGuess(userGuess.text);
    }
    void WinGame()
    {

    }
    void LoseGame()
    {

    }
}

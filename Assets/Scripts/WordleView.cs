using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Windows;
using UnityEngine.UI;
using UnityEditor.U2D.Aseprite;

public class WordleView : MonoBehaviour
{
    [SerializeField] Button[] row0;
    [SerializeField] Button[] row1;
    [SerializeField] Button[] row2;
    [SerializeField] Button[] row3;
    [SerializeField] Button[] row4;
    [SerializeField] Button[] row5;

    //[SerializeField] WordleModel WordleObjectView;
    int count = 0;

    [SerializeField] TMP_InputField userGuess;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void update_cells()
    {
        string word = userGuess.text;
        Debug.Log(word + " View Update called");
        switch (count)
        {
            case 0:
                for (int r = 0; r < row0.Length; r++)
                { 
                    row0[r].GetComponentInChildren<TMP_Text>().text = word[r].ToString();
                }
                break;
            case 1:
                for (int r = 0; r < row1.Length; r++)
                {
                    row1[r].GetComponentInChildren<TMP_Text>().text = word[r].ToString();
                }
                break;
            case 2:
                for (int r = 0; r < row2.Length; r++)
                {
                    row2[r].GetComponentInChildren<TMP_Text>().text = word[r].ToString();
                }
                break;
            case 3:
                for (int r = 0; r < row3.Length; r++)
                {
                    row3[r].GetComponentInChildren<TMP_Text>().text = word[r].ToString();
                }
                break;
            case 4:
                for (int r = 0; r < row4.Length; r++)
                {
                    row4[r].GetComponentInChildren<TMP_Text>().text = word[r].ToString();
                }
                break;
            case 5:
                for (int r = 0; r < row5.Length; r++)
                {
                    row5[r].GetComponentInChildren<TMP_Text>().text = word[r].ToString();
                }
                break;
        }
        count += 1;
        
    }

    public void SetUp()
    {

    }
    public void UpdateView()
    {

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using TMPro;

public class GameManager : MonoBehaviour
{
    public TMP_InputField letterInput;

    public string[] wordList;
    public List<string> solvedList = new List<string>();

    public List<TMP_Text> letterHolderlist = new List<TMP_Text>();

    public GameObject textPrefab;
    public Transform letterHolder;
    // Start is called before the first frame update
    void Start()
    {
        Initialize();
    }

    void Initialize()
    {
        int index = Random.Range(0, wordList.Length);
        string tempWord = wordList[index];

        string[] splittedWord = tempWord.Split();
        foreach (string letter in splittedWord)
        {
            solvedList.Add(letter);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

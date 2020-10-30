using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DifficultyButton : MonoBehaviour
{
    Button button;
    [SerializeField]int difficulty;

    GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        button = GetComponent<Button>();
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        button.onClick.AddListener(SetDifficylty);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SetDifficylty()
    {
        Debug.Log(button.gameObject.name + " was clicked!");
        gameManager.StartGame(difficulty);
    }
}

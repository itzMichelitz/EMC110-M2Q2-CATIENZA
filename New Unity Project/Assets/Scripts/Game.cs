using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Game : MonoBehaviour
{
    public Button left;
    public Button right;
    public Button up;
    public Button down;
    private Button correctButton;

    void Start()
    {
        StartNewRound();

        left.onClick.AddListener(() => CheckAnswer(left));
        right.onClick.AddListener(() => CheckAnswer(right));
        up.onClick.AddListener(() => CheckAnswer(up));
        down.onClick.AddListener(() => CheckAnswer(down));
    }

    void StartNewRound()
    {
        int randomIndex = Random.Range(0, 4);
        correctButton = randomIndex switch
        {
            0 => left,
            1 => right,
            2 => up,
            _ => down,
        };
    }

    void CheckAnswer(Button pressedButton)
    {
        if (pressedButton == correctButton)
        {
            SceneManager.LoadScene(2);
        }
        else
        {
            SceneManager.LoadScene(3);
        }

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    private static int score;
    [SerializeField]
    Text text = default;
    
    private void Awake() {
        score = 0;
    }

    void Update()
    {
        text.text = score.ToString();
    }

    public static void AddPoints(int x) {
        int pointsToAdd = 0;
        switch(x) {
            case 1:
                pointsToAdd = 100;
                break;
            case 2:
                pointsToAdd = 400;
                break;
            case 3:
                pointsToAdd = 1000;
                break;
            case 4:
                pointsToAdd = 3000;
                break;
            default:
                pointsToAdd = 0;
                break;
        } 

        score += pointsToAdd;
    }
}

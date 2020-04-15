using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoringScript : MonoBehaviour
{
    public TextMeshProUGUI scoringtext1, scoringtext2;

    public static int score1 = 0, score2 = 0;
    // Start is called before the first frame update
    void Start()
    {
        scoringtext1.text = score1.ToString();
        scoringtext2.text = score2.ToString();
    }

    public void UpdateScore(string namaWall){
        if (namaWall == "Kiri"){
            score1 += 1;
            scoringtext1.text = score1.ToString();
        }else if (namaWall == "Kanan"){
            score2 += 1;
            scoringtext2.text = score2.ToString();
        }
    }

}

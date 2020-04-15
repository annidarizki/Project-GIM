using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndingScript : MonoBehaviour
{
    public Text endingtext;
    // Start is called before the first frame update
    void Start()
    {
        if(ScoringScript.score1 > ScoringScript.score2){
            endingtext.text = "Player 1 menang";
        }else if (ScoringScript.score1 < ScoringScript.score2){
            endingtext.text = "Player 2 menang";
        }else{
            endingtext.text = " Keduanya menang";
        }
    }

}

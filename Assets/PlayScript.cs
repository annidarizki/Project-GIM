using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayScript : MonoBehaviour
{
    public void Mulai(){ //dibuat public agar bisa diakses dari luar
        SceneManager.LoadScene("latihanpong");
    }
}

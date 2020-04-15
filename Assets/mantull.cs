using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mantull : MonoBehaviour
{

    // Start is called before the first frame update

	//public int speed= 30;
    public Rigidbody2D sesuatu;

    public Animator animtr;

    public GameObject masterScript;

    void Start()
    {
        int x = Random.Range(0, 2)*2 - 1; //nilai x bisa bernilai -1 atau 1
        int y = Random.Range(0, 2)*2 - 1; //nilai y bisa bernilai -1 atau 1
        int speed = Random.Range(20, 26); //nilai speed bisa bernilai 20 sampai 25
    	sesuatu.velocity = new Vector2(x, y)*speed;
        sesuatu.GetComponent<Transform>().position = Vector2.zero;
        animtr.SetBool("IsMove", true);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(sesuatu.velocity.x > 0){ //bola bergerak ke kanan
            sesuatu.GetComponent<Transform>().localScale = new Vector3(1, 1, 1);
        }else{
            sesuatu.GetComponent<Transform>().localScale = new Vector3(-1, 1, 1);
        }
        
    }
    //Mengecek apakah ada tabrakan
    void OnCollisionEnter2D(Collision2D other){
    	if(other.collider.name == "Kanan" || other.collider.name=="Kiri"){
            masterScript.GetComponent<ScoringScript>().UpdateScore(other.collider.name);
            StartCoroutine(jeda()); //Untuk pindah ke tengah
    	}
    }
    IEnumerator jeda(){ 
        sesuatu.velocity = Vector2.zero; //Menghentikan bola
        animtr.SetBool("IsMove", false); //Mengubah animasi ke api berhenti
        sesuatu.GetComponent<Transform>().position = Vector2.zero;//bola pindah ke tengah setelah menabrak dinding

        yield return new WaitForSeconds(1);

        int x = Random.Range(0, 2)*2 - 1; //nilai x bisa bernilai -1 atau 1
        int y = Random.Range(0, 2)*2 - 1; //nilai y bisa bernilai -1 atau 1
        int speed = Random.Range(20, 26); //nilai speed bisa bernilai 20 sampai 25
        sesuatu.velocity = new Vector2(x, y)*speed;//Mengatur kecepatan
         animtr.SetBool("IsMove", true); //Mengubah animasi ke api bergerak
    }      
    
}

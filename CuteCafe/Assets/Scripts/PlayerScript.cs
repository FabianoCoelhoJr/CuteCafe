using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerScript : MonoBehaviour
{
    public GameObject youWin;
    public GameObject youLose;

    private bool gameStarted = false;
    private bool movement = true;

    // Start is called before the first frame update
    void Start()
    {
        movement = true;
        gameStarted = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    /*private void OnCollisionEnter2D(Collision2D collision){
        if(!gameEnded){
            if(collision.collider.tag == "Espinhos"){
                youLose.SetActive(true);
                gameEnded = true;
                movement = false;
            }

            if(collision.collider.tag == "Landing"){
                youWin.SetActive(true);
                gameEnded = true;
                movement = false;
            }
        }
    }*/

    public void PlayAgain(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}

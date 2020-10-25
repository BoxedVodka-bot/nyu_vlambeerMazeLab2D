using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Restart : MonoBehaviour
{
    public GameObject instructions;
    public GameObject floorMaker;
    bool toggle = false;
    void Update()
    {
        if ( Input.GetKeyDown(KeyCode.R) ) {
            SceneManager.LoadScene( SceneManager.GetActiveScene().name );
			
        }

        if ( Input.GetKeyDown(KeyCode.A) ) {
            floorMaker.SetActive(true);
        }

        /*
        if( Input.GetKeyDown (KeyCode.Space) && toggle == false){
            instructions.SetActive(false);
            toggle = true;
        }else if(Input.GetKeyDown(KeyCode.Space) && toggle == true){
            instructions.SetActive(true);
            toggle = false;
        }
        */
    }
    
    public void ShowText()
    {
        instructions.SetActive(true);
    }

    public void DisableText(){
        instructions.SetActive(false);
    }

    public void StartGen(){
         floorMaker.SetActive(true);
    }

    
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
 //Once the gameobject tagged as player collides with the trigger, which is just tagged as the default other, the game checks to see if the gameobject it collided with was tagged as player. If 
 //yes, it runs the code below which takes the player to the next scene, marked Exit. Make sure the scene is in your build settings. 
        {
        if (other.gameObject.tag == "Player")
            SceneManager.LoadScene("Exit");
        }
 }
   


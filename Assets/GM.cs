using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GM : MonoBehaviour
{
    // Start is called before the first frame update
   public void OnStartGame(){
       SceneManager.LoadScene("New Scene");

   }
}

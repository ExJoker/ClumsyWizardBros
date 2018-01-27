using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;
 

public class ClickCounter : MonoBehaviour {

 private int counter = 0;
 public int changeText = 0;
 public int changeScene = 0;
 public int sceneIndex = 0;
  public  Text   buttonText ; 

	public void RaiseCounter(){
		counter = counter +1;

		if(counter == 2){
			buttonText.text = "Start";
		}else if (counter >= 3){
			SceneManager.LoadScene (sceneIndex);
		}
	}
}

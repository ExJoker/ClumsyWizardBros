using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;
 

public class ClickCounter : MonoBehaviour {

 private int counter = 0;
 public int changeText = 0;
 public int changeScene = 0;
 public int sceneIndex = 0;
  public  GameObject nextButton;
 public GameObject startButton;
 public GameObject skipButton;

	public void RaiseCounter(){
		counter = counter +1;

		if(counter == changeText){
      nextButton.SetActive(false);
      startButton.SetActive(true);
      skipButton.SetActive(false);
		}else if (counter >= changeScene){
			SceneManager.LoadScene (sceneIndex);
		}
	}
}

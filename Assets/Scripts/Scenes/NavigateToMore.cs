using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NavigateToMore : MonoBehaviour
{
    // Start is called before the first frame update
    public string firstScene;
    public string secondScene;
    public string thirdScene;
    public string fourthScene;
    public GameObject buttonAudio;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     public void GoToScene1() {
        ButtonPressed(firstScene);
    }

    public void GoToScene2() {
        ButtonPressed(secondScene);
    }
    public void GoToScene3() {
        ButtonPressed(thirdScene);
    }

    public void GoToScene4() {
        ButtonPressed(fourthScene);
    }
    public void ButtonPressed(string name)
    {
        AudioSource audioSource = buttonAudio.GetComponent<AudioSource>();
        AudioClip audioClip = audioSource.clip;
        //audioSource.Play();
        // Debug.Log("Break 1");
        StartCoroutine(HandleButtonClick(audioClip, audioSource, name));
        // Debug.Log("Break 3");

    }
     IEnumerator HandleButtonClick(AudioClip clickSound, AudioSource source, string name)
    {  
        source.Play();
        Debug.Log("Break 2");
        yield return new WaitForSeconds(clickSound.length + 0.2f);
        SceneManager.LoadScene(name);
    }

}

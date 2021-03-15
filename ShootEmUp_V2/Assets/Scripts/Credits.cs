using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Credits : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake()
    {
        StartCoroutine(goToMainMenu());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator goToMainMenu(){
        // Wait for 5 seconds
        Debug.Log("In ienumerator");
        yield return new WaitForSeconds (5);
        Debug.Log("5 seconds has passed");
        SceneManager.LoadScene (sceneName:"MainMenu");
    }
}

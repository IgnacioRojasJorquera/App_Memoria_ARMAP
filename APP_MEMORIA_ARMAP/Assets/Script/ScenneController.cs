using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenneController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
      
    }

    public void changeScene(string scene)
    {
        SceneManager.LoadSceneAsync(scene);
    }

    // Update is called once per frame
    public void Quit()
    {
        Application.Quit();
    }
}

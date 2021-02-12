using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenneController : MonoBehaviour
{
   // public GameObject mover;
    Vector2 starPosicion;
    
    private void Awake()
    {
        
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void changeScene(string scene)
    {
        
        //starPosicion = mover.transform.position;
        SceneManager.LoadSceneAsync(scene);

        /*
        if (scene != "Test")
        {
            Mover();
        }
       else
        {
       
            print("ok");
            Mover_inicial();
            
        }
       */
    }

    // Update is called once per frame
    public void Quit()
    {
        Application.Quit();
    }
    /*
    public void Mover()
    {
        //mover.transform.position = new Vector3(x: -850,y:-50);
        mover.transform.position = new Vector2(x:-778,y:0);
    }

    public void Mover_inicial()
    {
        mover.transform.position = new Vector2(x: 0, y: 0);
        //mover.transform.position = starPosicion;
    }
    */
}

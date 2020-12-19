using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainKeyPress : MonoBehaviour
{

    public string newStartScene;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        bool isKeyDown = Input.GetKeyDown(KeyCode.L);
        if (isKeyDown)
        {
            SceneManager.LoadScene(newStartScene);
        }
    }

    
}

using UnityEngine;
using System.Collections;

public class CoffeeScript : MonoBehaviour
{

    float wait = 3.0f;
    bool init = false;

    void Awake()
    {
        // You must initialize Dialoguer before using it!
        Dialoguer.Initialize();
    }

    void OnGUI()
    {
        wait -= Time.deltaTime;
        if (wait < 0 && !init)
        {
            init = true;
            Dialoguer.StartDialogue(4);
        }

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
            Application.Quit();
    }
}

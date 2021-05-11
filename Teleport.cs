using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Teleport : MonoBehaviour
{

    public GameObject Player;
    public GameObject Portal;
    public GameObject GoToStart;

    void Start()
    {
        
    }
    void Update()
    {
       

    }
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            StartCoroutine(Teleport2D ());
            StartCoroutine(GTS2D());
        }
    }
    IEnumerator Teleport2D()
    {
        yield return new WaitForSeconds(1);
        Player.transform.position = new Vector2(Portal.transform.position.x, Portal.transform.position.y);

      
    }

    IEnumerator GTS2D()
    {
        yield return new WaitForSeconds(1);
        Player.transform.position = new Vector2(Portal.transform.position.x, Portal.transform.position.y);
        TimerController.instance.ResetTimer();
    }
}

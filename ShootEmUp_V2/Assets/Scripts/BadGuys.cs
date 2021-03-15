using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BadGuys : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject enemyBullet;
    public ScoreManager scoreManager;

    public Transform shottingOffset;

    void Start()
    {
        //InvokeRepeating("e1", 1f, 1f);
    }
    void Update()
    {
    }

    void e1(){
        GameObject shot = Instantiate(enemyBullet, shottingOffset.position, Quaternion.identity);
        Debug.Log("Bang!");
        Destroy(shot, 3f);
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
      if(collision.gameObject.tag == "Bullet")
      {
        if(this.tag == "EA2")
        {
            scoreManager.refresh(10);
        }

        if(this.tag == "EA")
        {
            scoreManager.refresh(25);
        }

        if(this.tag == "DogheadBoss")
        {
            scoreManager.refresh(50);
        }

        if(this.tag == "HeadBoss")
        {
            scoreManager.refresh(100);
        }
        GetComponent<Animator>().SetTrigger("Hit");
        Destroy(collision.gameObject); // destroy bullet
        Debug.Log("Ouch!");
      }
    }

}

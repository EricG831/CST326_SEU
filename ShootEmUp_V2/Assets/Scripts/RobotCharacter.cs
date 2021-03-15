using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


[RequireComponent(typeof(Animator))]
public class RobotCharacter : MonoBehaviour
{
    private Animator animator;
    
    public GameObject bullet;

    public Transform shottingOffset;

    public int speed;

    void Awake(){
       animator =  GetComponent<Animator>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetTrigger("isFired");
            GameObject shot = Instantiate(bullet, shottingOffset.position, Quaternion.identity);
            Debug.Log("Bang!");
            Destroy(shot, 3f);
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            speed = -1;
        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            speed = 1;
        }
      
        transform.position = transform.position + new Vector3(0, (Time.deltaTime * speed), 0);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
      if(collision.gameObject.tag == "EnemyBullet")
      {
        GetComponent<Animator>().SetTrigger("Hit");
        Destroy(collision.gameObject); // destroy bullet
        // End game and go to credits 
        //SceneManager.LoadScene (sceneName:"MainMenu");
      }
    }
}

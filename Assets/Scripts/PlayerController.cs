using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public Transform[] waypoints;
    public float moveSpeed;
    public int waypointIndex = 0;

    private Animator animator;
    private float extraSpeed = 0.005f;
    private float lowSpeed = 0.05f;
    private bool ex;
    private bool low;
    private Events ev;

    public string name { get; set; }
    public int activeWaypointIndex { get; set; }
    public float distanceToWaypoint { get; set; }

    public static bool gameOver;
    public GameObject gameOverPanel;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        transform.position = waypoints[waypointIndex].transform.position;
        ex = false;
        low=false;
        gameOver = false;
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(GameStart());

        if (gameOver)
        {
            Time.timeScale = 0;
            gameOverPanel.SetActive(true);
            
        }
    }
    private void Move()
    {
        moveSpeed = Random.Range(2.0f, 2.5f);
        if( waypointIndex <= waypoints.Length - 1){
            transform.position = Vector3.MoveTowards(transform.position, waypoints[waypointIndex].transform.position, moveSpeed * Time.deltaTime);
            if(ex == true)
            {
                transform.position = Vector3.MoveTowards(transform.position, waypoints[waypointIndex].transform.position, moveSpeed * Time.deltaTime + extraSpeed);
            }
            if(low == true)
            {
                transform.position = Vector3.MoveTowards(transform.position, waypoints[waypointIndex].transform.position, moveSpeed * Time.deltaTime - lowSpeed);
            }

            if(transform.position == waypoints[waypointIndex].transform.position)
            {
                waypointIndex += 1;
            }
        }
    }
    public IEnumerator GameStart()
    {
        yield return new WaitForSeconds(3);
        Move();
    }
    public void OnTriggerEnter(Collider colliderOne)
      {
          if (colliderOne.tag == "trigger1"){
              animator.SetBool("tr1", true);
          }
          if (colliderOne.tag == "trigger2"){
              animator.SetBool("tr2", true);
          }
          if (colliderOne.tag == "trigger3"){
              animator.SetBool("tr3", true);
          }
          if (colliderOne.tag == "trigger4"){
              animator.SetBool("tr4", true);
          }
          if (colliderOne.tag == "speedup"){
              ex=true;
              low=false;
            //   Debug.Log("UP");
          }
          if (colliderOne.tag == "speeddown"){
              ex=false;
              low=true;
            //   Debug.Log("Down");
          }
          if (colliderOne.tag == "end"){
              Time.timeScale = 0;
            gameOver = true;
            
        }      
      }

}

using UnityEngine;
using System.Collections;

public class ZombieMove_Script : MonoBehaviour {

    NavMeshAgent Agent;
    public int AwareRange = 150;
    Transform Player;
    Vector3 Dest;

	void Start () 
    {
        Agent = GetComponent<NavMeshAgent>();
        Player = GameObject.Find("Player").transform;
        Dest = Vector3.zero;
		Agent.SetDestination (transform.position);
	}
	
	void Update ()
	{
		/*test
		Agent.SetDestination(Player.position);*/

        
		//Player in range?
		float PlayerDist = Vector3.Distance(transform.position, Player.position);
        if (PlayerDist < AwareRange && PlayerDist > 1.5f)
        {
            //Cast ray to find player
            Vector3 PlayerAngle = Player.position - transform.position;
            Ray ray = new Ray(transform.position,PlayerAngle);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, AwareRange))
            {
                if (hit.collider.tag == "Player")
                {
                    //Found Player
                    Agent.SetDestination(Player.position);
					Dest = Player.position;
                }
            }
		}

		else
		{

//			Agent.Stop ();
			Agent.SetDestination (transform.position);
			return;
		}
	}
}

using UnityEngine;
using System.Collections;

public class Interactable : MonoBehaviour {
    [HideInInspector]
    public NavMeshAgent playerAgent;
    private bool hasInteracted;
    bool isEnemy;

    public virtual void MoveToInteraction(NavMeshAgent playerAgent)
    {
        if (gameObject.tag == "Enemy")
        {
            isEnemy = true;
        }
        hasInteracted = false;
        this.playerAgent = playerAgent;
        playerAgent.stoppingDistance = 3f;
        playerAgent.destination = transform.position;
    }

    void Update()
    {
        if (!hasInteracted && playerAgent != null && !playerAgent.pathPending)
        {
            if (playerAgent.remainingDistance <= playerAgent.stoppingDistance)
            {
                if (!isEnemy)
                    Interact();
                EnsureLookDirection();
                hasInteracted = true;
            }
        }
    }

    void EnsureLookDirection()
    {
        playerAgent.updateRotation = false;
        Vector3 lookDirection = new Vector3(transform.position.x, playerAgent.transform.position.y, transform.position.z);
        playerAgent.transform.LookAt(lookDirection);
        playerAgent.updateRotation = true;
    }

    public virtual void Interact()
    {
        Debug.Log("Interacting with base class.");
    }
}

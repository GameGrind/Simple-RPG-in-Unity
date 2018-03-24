using UnityEngine;
using System.Collections;

public class Interactable : MonoBehaviour {
    [HideInInspector]
    public UnityEngine.AI.NavMeshAgent playerAgent;
    private bool hasInteracted;
    bool isEnemy;

    public virtual void MoveToInteraction(UnityEngine.AI.NavMeshAgent playerAgent)
    {
        isEnemy = gameObject.tag == "Enemy";
        hasInteracted = false;
        this.playerAgent = playerAgent;
        playerAgent.stoppingDistance = 3f;
        playerAgent.destination = GetTargetPosition();
        EnsureLookDirection();
    }

    void Update()
    {
        if (!hasInteracted && playerAgent != null && !playerAgent.pathPending)
        {
            playerAgent.destination = GetTargetPosition();
            EnsureLookDirection();
            if (playerAgent.remainingDistance <= playerAgent.stoppingDistance)
            {
                if (!isEnemy)
                    Interact();
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

    private Vector3 GetTargetPosition()
    {
        return transform.position;
    }
}

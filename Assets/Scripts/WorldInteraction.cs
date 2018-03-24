using UnityEngine;
using System.Collections;

public class WorldInteraction : MonoBehaviour {
    UnityEngine.AI.NavMeshAgent playerAgent;
    [SerializeField]
    private LayerMask interactLayer;

    void Start()
    {
        playerAgent = GetComponent<UnityEngine.AI.NavMeshAgent>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && !UnityEngine.EventSystems.EventSystem.current.IsPointerOverGameObject())
            GetInteraction();

        Debug.DrawRay(transform.position, transform.forward * 5f, Color.red);
    }

    void GetInteraction()
    {
        Ray interactionRay = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit interactionInfo;
        if (Physics.SphereCast(interactionRay, 1f, out interactionInfo, Mathf.Infinity, interactLayer))
        {
            playerAgent.updateRotation = true;
            GameObject interactedObject = interactionInfo.collider.gameObject;
            if (interactedObject.tag == "Enemy")
            {
                Debug.Log("move to enemy");
                interactedObject.GetComponent<Interactable>().MoveToInteraction(playerAgent);
            }
            else if (interactedObject.tag == "Interactable Object")
                interactedObject.GetComponent<Interactable>().MoveToInteraction(playerAgent);
            else
            {
                playerAgent.stoppingDistance = 0;
                playerAgent.destination = interactionInfo.point;
            }
        }
    }
}

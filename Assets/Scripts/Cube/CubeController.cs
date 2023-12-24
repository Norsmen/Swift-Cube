using UnityEngine;

public class CubeController : MonoBehaviour
{
    [SerializeField] private HeroStackController heroStackController;
    private RaycastHit hit;
    private bool isStack = false;
    private Vector3 direction = Vector3.back;
    void Start()
    {
        heroStackController = GameObject.FindObjectOfType<HeroStackController>();
    }


    void FixedUpdate()
    {
        SetCubeRayCast();
    }
    
    private void SetCubeRayCast()
    {
        if (Physics.Raycast(transform.position, direction, out hit, 1f))
        {
            if (!isStack)
            {
                isStack = true;
                heroStackController.IncreaseBlockStack(gameObject);
                SetDirection();
            }
            if (hit.transform.name == "ObstackleCube") 
            {
                heroStackController.DecreaseBlock(gameObject);
            }
        }
    }
    private void SetDirection()
    {
        direction = Vector3.forward;
    }
}

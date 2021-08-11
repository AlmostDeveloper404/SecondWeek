using UnityEngine;

public class PickUp : MonoBehaviour
{
    [SerializeField] float radius = 2f;
    [SerializeField] LayerMask playerMask;
    [SerializeField] GameObject collectPart;

    CoinPickUpManager coinPickUpManager;

    bool hasPicked = false;

    private void Start()
    {
        coinPickUpManager = CoinPickUpManager.instance;
        
    }
    private void Update()
    {
        if (Physics.CheckSphere(transform.position,radius,playerMask)&& !hasPicked)
        {
            PickUpCoin();
            hasPicked = true;
        }
    }

    void PickUpCoin()
    {
        coinPickUpManager.PickUp();

        GameObject collectParticleGO = Instantiate(collectPart,transform.position,transform.rotation);
        Destroy(collectParticleGO,1f);
        Destroy(gameObject);
    }
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.black;
        Gizmos.DrawWireSphere(transform.position,radius);
    }
}

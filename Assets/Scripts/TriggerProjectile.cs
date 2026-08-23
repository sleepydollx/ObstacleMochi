using UnityEngine;

public class TriggerProjectile : MonoBehaviour
{
    [SerializeField] GameObject projectile;
    [SerializeField] GameObject projectile1;
    [SerializeField] GameObject projectile2;
    [SerializeField] GameObject projectile3;
    [SerializeField] GameObject projectile4;
    [SerializeField] GameObject projectile5;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("player"))
        {
            ActivateProjectile(projectile);
            ActivateProjectile(projectile1);
            ActivateProjectile(projectile2);
            ActivateProjectile(projectile3);
            ActivateProjectile(projectile4);
            ActivateProjectile(projectile5);
        }
    }

    private void ActivateProjectile(GameObject proj)
    {
        if (proj != null)
        {
            proj.SetActive(true);
        }
    }
}
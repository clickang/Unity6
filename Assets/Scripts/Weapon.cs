using System.Runtime.CompilerServices;
using StarterAssets;
using Unity.VisualScripting;
using UnityEngine;

public class Weapon : MonoBehaviour
{    
    [SerializeField] int damageAmount = 1;
    StarterAssetsInputs starterAssetsInputs;

    void Awake()
    {
        starterAssetsInputs = GetComponentInParent<StarterAssetsInputs>();
    }

    void Update()
    {
        HandleShoot();

    }

    bool HandleShoot()
    {
        if (!starterAssetsInputs.shoot) return false;

        RaycastHit hit;


        if (Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out hit, Mathf.Infinity))
        {
            EnemyHealth enemyHealth = hit.collider.GetComponent<EnemyHealth>();
            enemyHealth?.TakeDamage(damageAmount);   // 여기서 enemyHealth가 존재하면 함수 실행 / 바로 아래 if문과 동일한 동작


            // if(enemyHealth)
            // {
            //     enemyHealth.TakeDamage(damageAmount);
            // }

            starterAssetsInputs.ShootInput(false);
        }

        return true;
    }
}

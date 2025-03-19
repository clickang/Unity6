using StarterAssets;
using UnityEngine;
using UnityEngine.AI;

public class Robot : MonoBehaviour
{
    FirstPersonController player;
    NavMeshAgent agent;

    // 게임 오브젝트에 직접 연결된 의존성은 Awake에서 가져오는 것이 좋은 규칙
    void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
    }
    // 장면의 다른 게임 오브젝트에 의존성이 있는 의존성은 start에서 가져오는 것이 좋다
    void Start()
    {
        player = FindFirstObjectByType<FirstPersonController>();
    }

    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(player.transform.position);
    }
}

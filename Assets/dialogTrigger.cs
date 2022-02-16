using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dialogTrigger : MonoBehaviour
{
    bool near = false;

    [SerializeField]
    [Range (0, 10)]
    private float range;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        near = false;
        
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, range);
    }
}

using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;


public class Projectile : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] float damage = 1f;
    [SerializeField] public string SourceTag;
    

    void Start()
    {

    }

    private void OnTrigerEnter2D(Collider2D other)
        {
            if(!other.gameObject.CompareTag(SourceTag))
            {
                Entity entity = other.GetComponent<Entity>();
                if(entity)
                {
                    entity.TakeDamage(damage);
                }
                Destroy(gameObject);
            }
        }

    void Update()
    {

    }
    // Update is called once per frame
}

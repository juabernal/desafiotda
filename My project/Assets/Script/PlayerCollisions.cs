using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollisions : MonoBehaviour
{
    // para poder agregar a la lista. (toma el otro script).
    [SerializeField] Weapons weaponsmanager;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Si toco un Trigger, primero lo elimino de la escena y luego lo agrega a la lista.
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("weapon"))
        {
            other.gameObject.SetActive(false);
            weaponsmanager.WeaponList.Add(other.gameObject);

            // Dicionario
            weaponsmanager.WeaponDirectory.Add(other.gameObject.name, other.gameObject);
            Debug.Log(weaponsmanager.WeaponDirectory[other.gameObject.name]);
        }
    }
}

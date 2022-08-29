using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapons : MonoBehaviour
{
    //ARRAY FIJO - CAMBIA DE ARMA CON F1,F2,F3 Y F4
    [SerializeField] GameObject[] weapons;
    [SerializeField] Transform posicionMano;

    // ENCAPSULO - LISTA DE ARMAS
    [SerializeField] List<GameObject> weaponList;
    public List<GameObject> WeaponList { get => weaponList; set => weaponList = value; }
    
    // DICCIONARIO
    private Dictionary<string, GameObject> weaponDirectory;
    public Dictionary<string, GameObject> WeaponDirectory { get => weaponDirectory; set => weaponDirectory = value; }

    
    void Start()
    {
            //   DesactivoArmas();
            
        // LISTAS
          WeaponList = new List<GameObject>();

        //Dicionario
        weaponDirectory = new Dictionary<string, GameObject>();
        
    }

    // Update is called once per frame
    void Update()
    {
        //ARRAY FIJO - CAMBIA DE ARMA CON F1,F2,F3 Y F4 (Y LA POSICIONA EN MI MANO)
        if (Input.GetKeyDown(KeyCode.F1))
        {
            weapons[0].SetActive(true);
            weapons[0].transform.parent = posicionMano;
            weapons[0].transform.localPosition = Vector3.zero;
            weapons[1].SetActive(false);
            weapons[2].SetActive(false);
            weapons[3].SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.F2))
        {
            weapons[0].SetActive(false);
            weapons[1].SetActive(true);
            weapons[1].transform.parent = posicionMano;
            weapons[1].transform.localPosition = Vector3.zero;
            weapons[2].SetActive(false);
            weapons[3].SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.F3))
        {
            weapons[0].SetActive(false);
            weapons[1].SetActive(false);
            weapons[2].SetActive(true);
            weapons[2].transform.parent = posicionMano;
            weapons[2].transform.localPosition = Vector3.zero;
            weapons[3].SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.F4))
        {
            weapons[0].SetActive(false);
            weapons[1].SetActive(false);
            weapons[2].SetActive(false);
            weapons[3].SetActive(true);
            weapons[3].transform.parent = posicionMano;
            weapons[3].transform.localPosition = Vector3.zero;
        }

        // DICCIONARIO - vuelve a activar 
        if (Input.GetKeyDown(KeyCode.Alpha1)) { weaponDirectory["blasterA"].SetActive(true); }
        if (Input.GetKeyDown(KeyCode.Alpha2)) { weaponDirectory["blasterB"].SetActive(true); }
        if (Input.GetKeyDown(KeyCode.Alpha3)) { weaponDirectory["blasterC"].SetActive(true); }
        if (Input.GetKeyDown(KeyCode.Alpha4)) { weaponDirectory["blasterD"].SetActive(true); }

        //Reinicio de nuevo todas las Armas con la tecla "R"
        if (Input.GetKey(KeyCode.R))
        {
            ActivoArmas();
        }
    }
    /* void DesactivoArmas()
    {

        for (int i = 0; i<4; i++)
        {
            weapons[i].SetActive(false);
        }
    } */
   
    //para Activar nuevamente las Armas de la lista una vez que las tomé todas.
    void ActivoArmas()
    {
        foreach (GameObject weapon in weaponList)
        {
            weapon.SetActive(true);
        }
    }
    
}

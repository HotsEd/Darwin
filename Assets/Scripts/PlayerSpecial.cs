using UnityEngine;

public class PlayerSpecial : MonoBehaviour
{
    public KeyCode key;
    public GameObject obj;

    void Update()
    {
        if (Input.GetKeyDown(key)){
            GameObject clone = Instantiate(obj, transform.position, transform.rotation);
            Destroy(clone,0.3f);
        }
        

    }
}

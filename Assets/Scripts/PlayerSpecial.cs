using UnityEngine;

public class PlayerSpecial : MonoBehaviour 
{
    public KeyCode key;
    public GameObject obj;
    public GameController Game;

    void Update()
    {
        /*
        if(Game.especial > 0) { 
            if (Input.GetKeyDown(key)){
                GameObject clone = Instantiate(obj, transform.position, transform.rotation);
                Destroy(clone,0.3f);
                Game.setEspecial();
            }
        }*/

    }
}

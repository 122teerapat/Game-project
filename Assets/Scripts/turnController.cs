using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;

public class turnController : MonoBehaviour
{
    public Transform player;
    public List<Transform> possiblePlayer;
    public int whichPlayer;
    public CinemachineVirtualCamera cam;
    void Start()
    {
        possiblePlayer.RemoveAll(item => item == null);
        if (player == null && possiblePlayer.Count >= 1)
        {
            player = possiblePlayer[0];
        }
        
        SwitchPlayer();

    }
    // Update is called once per frame
    void Update()
    {
        

    }

    public void SwitchPlayer()
    {
        possiblePlayer.RemoveAll(item => item == null);
        if (whichPlayer == possiblePlayer.Count - 1)
        {
            whichPlayer = 0;
        }
        else
        {
            whichPlayer += 1;
        }

        player = possiblePlayer[whichPlayer];
        StartCoroutine(WaitAndSwitch(1f, player));
        for (int i = 0; i < possiblePlayer.Count; i++)
        {
            if (possiblePlayer[i] != player)
            {
                possiblePlayer[i].GetComponent<playController>().enabled = false;
                possiblePlayer[i].GetComponent<playController>().gun.enabled = false;
                possiblePlayer[i].GetComponent<playController>().gun.gunDisplay.enabled = false;
            }
            
        }
        cam.Follow = player;
        
    }

    private IEnumerator WaitAndSwitch(float waitTime, Transform player)
    {
        yield return new WaitForSeconds(waitTime);
        player.GetComponent<playController>().enabled = true;
        player.GetComponent<playController>().gun.enabled = true;
        player.GetComponent<playController>().gun.gunDisplay.enabled = true;

    }
    
}

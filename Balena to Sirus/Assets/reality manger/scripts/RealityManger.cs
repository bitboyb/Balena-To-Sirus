using UnityEngine;

public class RealityManger : MonoBehaviour
{
    public enum Cworld
    {
        World1,
        World2
    }

    [SerializeField] PlayerController trackedPlayer;
    [SerializeField] Camera trackedPlayerCamera;
    [SerializeField] Transform shadowPlayer;
    [SerializeField]  Camera shadowPlayerCamera;

    [SerializeField]  Transform world1Point;
    [SerializeField]  Transform world2Point;

    [field: SerializeField] public Cworld CurrentWorld { get; private set; } = Cworld.World1;

    public Vector3 CurrentWorldpoint => CurrentWorld == Cworld.World1 ? world1Point.position : world2Point.position;
    public Vector3 OtherWorldpoint => CurrentWorld == Cworld.World2 ? world2Point.position : world1Point.position;
  
  

    // Update is called once per frame
    void Update()
    {
        {
            SychroniseShadow();
            Sychroniseplayer();
        }
    }

    public void FlipWorld()
    {
        // update the shadow player loction
        trackedPlayer.transform.position = shadowPlayer.transform.position;
        CurrentWorld = CurrentWorld == Cworld.World1 ? Cworld.World2 : Cworld.World1;
        
        SychroniseShadow();
    }

    
    void SychroniseShadow()
    {
        if (Input.GetKeyDown(KeyCode.E)   /* if world 1 */)
        {
            shadowPlayer.position = trackedPlayer.transform.position - CurrentWorldpoint + OtherWorldpoint;
            shadowPlayer.rotation = trackedPlayerCamera.transform.rotation;
            
            shadowPlayerCamera.transform.position = trackedPlayerCamera.transform.position - CurrentWorldpoint + OtherWorldpoint;
            shadowPlayerCamera.transform.rotation = trackedPlayerCamera.transform.rotation;
        }
        
    }

    public void flipbackworld()
    
    {///updates main character location 
        shadowPlayer.transform.position = trackedPlayer.transform.position;
        CurrentWorld = CurrentWorld == Cworld.World2 ? Cworld.World1 : Cworld.World2;
        Sychroniseplayer();
    }

    void Sychroniseplayer()
        // flips back to main level  
    {
        trackedPlayer.transform.position = shadowPlayer.position - CurrentWorldpoint + OtherWorldpoint;
        trackedPlayer.transform.rotation = shadowPlayerCamera.transform.rotation;

        trackedPlayerCamera.transform.position =
            shadowPlayerCamera.transform.position - CurrentWorldpoint + OtherWorldpoint;
        trackedPlayerCamera.transform.rotation = shadowPlayerCamera.transform.rotation;
        Debug.Log("test2");
    }


}

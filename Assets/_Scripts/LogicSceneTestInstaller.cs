using System.Linq;
using UnityEngine;
using Zenject;

public class LogicSceneTestInstaller : MonoInstaller<LogicSceneTestInstaller>
{    
    public override void InstallBindings()
    {        
        Debug.Log("[LogicSceneInstaller] InstallBindings");                
    }    
}
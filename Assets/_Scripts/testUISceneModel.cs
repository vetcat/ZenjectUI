using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class testUISceneModel : IInitializable
{
	private UiControllerUiSampleWindow _gameUiControllerUiSampleWindow;		
	public testUISceneModel(UiControllerUiSampleWindow gameUiControllerUiSampleWindow)		
	{
		_gameUiControllerUiSampleWindow = gameUiControllerUiSampleWindow;
	}
	
	public void Initialize()
	{		
		//_gameController.Test();			
	}
}

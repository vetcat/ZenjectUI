using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class testUISceneModel : IInitializable
{
	private ControllerUISampleWindow _gameControllerUiSampleWindow;		
	public testUISceneModel(ControllerUISampleWindow gameControllerUiSampleWindow)		
	{
		_gameControllerUiSampleWindow = gameControllerUiSampleWindow;
	}
	
	public void Initialize()
	{		
		//_gameController.Test();			
	}
}

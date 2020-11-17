using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Wiloka
{
	[DisallowMultipleComponent]
	[AddComponentMenu("Managers"+ nameof(GameManager))]
	public class GameManager : MonoBehaviour, IDisposable
    {
		#region fields
		private bool _isInited;
		private bool _isPaused;
		#endregion

		#region events
		public event Action<GameManager> onInited;
		public event Action<GameManager, string> onInitFailed;
		#endregion

		#region properties
		public StoryManager storyManager { get; set; }
		public SoundManager soundManager { get; set; }
		public UIManager uiManager { get; set; }
		public CameraManager cameraManager { get; set; }
		#endregion

		#region methods
		void Start()
		{
			Init();
		}

		void Init()
		{

		}
		#endregion

		#region IDisposable
		public void Dispose()
		{
			Destroy(gameObject);
		}
		#endregion
	}

}

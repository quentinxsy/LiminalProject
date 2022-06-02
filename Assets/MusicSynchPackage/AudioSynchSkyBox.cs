using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Rendering;



public class AudioSynchSkyBox : AudioSyncer
{
    /*private IEnumerator MoveToColor(Color _target)
	{
		Color _curr = rend.material.color;
		Color _initial = _curr;
		float _timer = 0;

		while (_curr != _target)
		{
			_curr = Color.Lerp(_initial, _target, _timer / timeToBeat);
			_timer += Time.deltaTime;

			rend.material.color = _curr;

			yield return null;
		}

		m_isBeat = false;
	}*/

	

    private void Update()
    {
		Debug.Log(rend);
    }

    private IEnumerator MoveToColor(Color _target)
	{
		Color _curr = rend;
		Color _initial = _curr;
		float _timer = 0;

		while (_curr != _target)
		{
			_curr = Color.Lerp(_initial, _target, _timer / timeToBeat);
			_timer += Time.deltaTime;

			rend = _curr;

			yield return null;
		}

		m_isBeat = false;
	}

	private Color RandomMaterialColor()
	{
		if (beatColors == null || beatColors.Length == 0) return Color.white;
		m_randomIndx = Random.Range(0, beatColors.Length);
		return beatColors[m_randomIndx];
		
	}

	public override void OnUpdate()
	{
		base.OnUpdate();

		if (m_isBeat) return;

		rend = Color.Lerp(rend, restColor, restSmoothTime * Time.deltaTime);
	}

	public override void OnBeat()
	{
		base.OnBeat();

		Color _m = RandomMaterialColor();
		
		StopCoroutine("MoveToColor");
		StartCoroutine("MoveToColor", _m);
		DynamicGI.UpdateEnvironment();
	}

	private void Start()
	{
		renderSettings = FindObjectOfType<RenderSettings>();
		
		rend = RenderSettings.ambientSkyColor; //Material Conversion
						//Material Conversion
		DynamicGI.UpdateEnvironment();
	}

	public Color[] beatColors;
	public Color restColor;

	private int m_randomIndx;
	private Color rend;
	private RenderSettings renderSettings;
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Rendering;


[RequireComponent(typeof(Renderer))]
public class AudioSyncMaterial : AudioSyncer
{ 
	private IEnumerator MoveToColor(Color _target)
	{
		Color _curr = rend.material.color;
		Color _initial = _curr;
		float _timer = 0;

		while (_curr != _target)
		{
			_curr = Color.Lerp(_initial, _target, _timer / timeToBeat);
			//_curr = rend.material.Lerp(_initial, _target, _timer / timeToBeat);
			_timer += Time.deltaTime;

			rend.material.color = _curr;

			yield return null;
		}

		m_isBeat = false;
	}

	private Color RandomMaterialColor()
	{
		if (beatColors == null || beatColors.Length == 0) return Color.white;
		m_randomIndx = Random.Range(0, beatColors.Length);
		return beatColors [m_randomIndx];
	}

	public override void OnUpdate()
	{
		base.OnUpdate();

		if (m_isBeat) return;		

		rend.material.color = Color.Lerp(rend.material.color, restColor, restSmoothTime * Time.deltaTime);
		//rend.material = rend.material.Lerp(rend.material, restMaterial, restSmoothTime * Time.deltaTime);
	}

	public override void OnBeat()
	{
		base.OnBeat();

		Color _m = RandomMaterialColor();

		StopCoroutine("MoveToColor");
		StartCoroutine("MoveToColor", _m);
	}

	private void Start()
	{
		//m_img = GetComponent<Image>(); //Original Code
		rend = GetComponent<Renderer>(); //Material Conversion
	}

	public Color[] beatColors; //Original Code
	public Color restColor; //Original Code

	//public Material[] beatMaterials; //Material Conversion
	//public Material restMaterial; //Material Conversion

	private int m_randomIndx;
	//private Image m_img; //Original Code
	private Material m_mat; //Material Conversion
	private Renderer rend;
}

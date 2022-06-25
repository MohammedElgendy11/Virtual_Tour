using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VirtualTourViewer : MonoBehaviour
{
    public GameObject NextHotspot;
    public GameObject PrevHotspot;

    public int _CurrentIndex;
    public Renderer _render;
    public Texture[] _texture;
    // Start is called before the first frame update
    void Start()
    {
        _render.material.mainTexture = _texture[0];
    }

    public void SetTextureView(int index)
    {
       
       _render.material.mainTexture = _texture[index];
        _CurrentIndex = index;


    }
    public void SetNext()
    {
        PrevHotspot.GetComponent<SphereCollider>().enabled = true;
        if (_CurrentIndex >= 0 && _CurrentIndex <_texture.Length-1)
        {
            _CurrentIndex++;
            // _render.material.mainTexture = _texture[_CurrentIndex];
            SetTextureView(_CurrentIndex);
           
        }
        if (_CurrentIndex == _texture.Length - 1)
        {
            NextHotspot.GetComponent<SphereCollider>().enabled = false; 
        }

    }
    public void SetPrev()
    {
        NextHotspot.GetComponent<SphereCollider>().enabled = true;
        if (_CurrentIndex > 0)
        {
            _CurrentIndex--;
            // _render.material.mainTexture = _texture[_CurrentIndex];
            SetTextureView(_CurrentIndex);

        }
        if (_CurrentIndex == 0)
        {
            PrevHotspot.GetComponent<SphereCollider>().enabled = false;
        }
    }

}





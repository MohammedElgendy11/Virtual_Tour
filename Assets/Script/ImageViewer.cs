using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ImageViewer : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] _images;
    public GameObject tnext, tprev;
    public Button m;
    int _activeImageIndex;
    public void SetActiveImage(int index)
    {
        if (index >= 0 && index < _images.Length)
        {
            for (int i = 0; i < _images.Length; i++)
            {
                _images[i].SetActive(false);
            }

            _images[index].SetActive(true);
        }
    }

    private void Start()
    {
        gameObject.GetComponent<VirtualTourViewer>().SetTextureView(1);

       /* SetActiveImage(0);
        _activeImageIndex = 0;*/
    }

    public void Next()
    {
        if (_activeImageIndex == _images.Length - 1)
        {
            // non-interactible
            // tnext.SetActive(false);
          //  gameObject.GetComponent<VirtualTourViewer>().SetTextureView(2);

            return;
        }
     //   _activeImageIndex++;
      //  SetActiveImage(_activeImageIndex);
        tprev.SetActive(true);
        gameObject.GetComponent<VirtualTourViewer>().SetTextureView(1);

    }

    public void Prev()
    {
        if (_activeImageIndex == 0)
        {
           // tprev.SetActive(false);
            return;
        }
        _activeImageIndex--;
      //  SetActiveImage(_activeImageIndex);
        tnext.SetActive(true);
        gameObject.GetComponent<VirtualTourViewer>().SetTextureView(_activeImageIndex);
        

    }
    


}

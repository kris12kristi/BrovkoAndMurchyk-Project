using UnityEngine;
using System.Collections;

public class ReadBook : MonoBehaviour {

	public void ChooseBook(int book){
		switch (book) {
		default:
		case(0): 
			Application.OpenURL ("https://drive.google.com/file/d/10qD9k1eLAQtrl-mnfAEMfyuaIncO3nGJ/view?usp=sharing");
			break;
		case (1):
			Application.OpenURL ("https://drive.google.com/file/d/1H20m0-pKRcTUuL_k0-qPzJzviId2-KNb/view?usp=sharing");
			break;
		case (2):
			Application.OpenURL ("https://drive.google.com/file/d/1PWMcgX3VnP9vnMALbMUs7BBX__LlexTV/view?usp=sharing");
			break;
		case (3):
			Application.OpenURL ("https://drive.google.com/file/d/1mpcqwdSrqDeyKyvAECKWn8w0wRfcP5p8/view?usp=sharing");
			break;
		case (4):
			Application.OpenURL ("https://drive.google.com/file/d/1qd7jXJRgu_jWt_JND2pry8ze_55M3vLt/view?usp=sharing");
			break;
		case (5):
			Application.OpenURL ("https://drive.google.com/file/d/1Ek985xXzJLm6MF2jeGsxQVAiXGY1reVO/view?usp=sharing");
			break;
		case (6):
			Application.OpenURL ("https://drive.google.com/file/d/1qd7jXJRgu_jWt_JND2pry8ze_55M3vLt/view?usp=sharing");
			break;
		case (7):
			Application.OpenURL ("https://drive.google.com/file/d/1vRvpVjRcwxXlf-zqyxmaiipoZiPBcMZr/view?usp=sharing");
			break;
		case (8):
			Application.OpenURL ("https://drive.google.com/file/d/1jUMAogBIDCy2Jk1v4wxP0rI2IPPIxErG/view?usp=sharing");
			break;
		case(9):
			Application.OpenURL ("https://drive.google.com/file/d/1oteHhtLlg4gar9nuJeIsMmFiPXbNTzLl/view?usp=sharing");
			break;
		}

			
	}
	

}

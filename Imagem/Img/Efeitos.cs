using System;
using System.Drawing;

public class Efeitos {
	public Bitmap gride(Bitmap tempBm){

		Bitmap bm = new Bitmap(tempBm);

        int intervaloVertical = 0;
        int intervaloHorizontal = 0;

		Color c = new Color();
		c = Color.FromArgb(0,0,0);
  
        for (int i = 0; i < bm.Width; i+=1){

            if (intervaloHorizontal < 10) {

                for (int j = 0 ; j < bm.Height ; j += 1) {

                    if (intervaloVertical < 10) {
                        bm.SetPixel (i,j,c);
                    }

                    if (intervaloVertical == 20) {

                        intervaloVertical = 0;
                    }
                    intervaloVertical++;
                }
            }

            if(intervaloHorizontal == 20) {
                intervaloHorizontal = 0;
            }

            intervaloHorizontal++;
		}

		return bm;
	}

	public Bitmap vermelho(Bitmap tempBm){

		Bitmap bm = new Bitmap(tempBm);
		Color colorPx ;

		for (int i = 160; i < 220; i++){

			for (int j = 160; j < 220; j++){

				colorPx = bm.GetPixel(i,j);

				int pixelR = 255;
				int pixelG = 0;
				int pixelB = 0;



				if (colorPx.R <= 60 && colorPx.G <= 60 && colorPx.B <= 60 ) {
					bm.SetPixel(i, j, Color.FromArgb((byte)pixelR, (byte)pixelG, (byte)pixelB));
				}
					
			}
				
		}

		return bm;
	}

	public Bitmap verde(Bitmap tempBm){

		Bitmap bm = new Bitmap(tempBm);
		Color colorPx ;

		for (int i = 0; i < bm.Width; i++){

			for (int j = 0; j < bm.Height; j++){

				colorPx = bm.GetPixel(i,j);
				int pixelR = 0;
				int pixelG = 0;
				int pixelB = 0;

                pixelR = (colorPx.R + colorPx.G + colorPx.B) / 3;

               // pixelG = colorPx.G ;
			//	pixelB = colorPx.B - 255;

				bm.SetPixel(i,j,Color.FromArgb((byte)pixelR, (byte)pixelR, (byte)pixelR));
			}
		}			

		return bm;
	}

	public Bitmap azul(Bitmap tempBm){

		Bitmap bm = new Bitmap(tempBm);
		Color colorPx ;

		for (int i = 0; i < bm.Width; i++){

			for (int j = 0; j < bm.Height; j++){

				colorPx = bm.GetPixel(i,j);
				int pixelR = 0;
				int pixelG = 0;
				int pixelB = 0;

				pixelR = colorPx.R - 255;
				pixelG = colorPx.G - 255;
				pixelB = colorPx.B;

				pixelR = Math.Max(pixelR, 0);
				pixelR = Math.Min(255, pixelR);

				pixelG = Math.Max(pixelG, 0);
				pixelG = Math.Min(255, pixelG);

				pixelB = Math.Max(pixelB, 0);
				pixelB = Math.Min(255, pixelB);					

				bm.SetPixel(i,j,Color.FromArgb((byte)pixelR, (byte)pixelG, (byte)pixelB));
			}
		}
		
		return bm;
	}
}

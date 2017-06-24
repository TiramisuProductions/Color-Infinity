using UnityEngine;
using System.Collections.Generic;

public class UpperBorder : MonoBehaviour {

	// Use this for initialization
	public Renderer rnleft ;
	public Renderer rnright;
	public Renderer rntop;
    public Renderer lowerrnleft;
    public Renderer lowerrnright;
    public Renderer lowerrntop;
    public GameController gamecontroller;
    private GameObject gameControllerObject;
    public  GameObject LowerBorderObject;
   private  Color colorborder;
   public GameObject loadingbar;
    private Color currentcolor;
    public float colorchange;

	public Color nextcolor;
	public string color;
	public Color Brown = new Color(0.2F, 0.3F, 0.4F, 0.5F);
	public Color Yellow = new Color(0.2F, 0.3F, 0.4F, 0.5F);
	public Color Red = new Color(0.2F, 0.3F, 0.4F, 0.5F);
	public Color Orange = new Color(0.2F, 0.3F, 0.4F, 0.5F);
	public Color Pink = new Color (0.2F, 0.3F, 0.4F, 0.5F);
    public Color Purple = new Color(0.2F, 0.3F, 0.4F, 0.5F);
    public Color White = new Color(0.2F, 0.3F, 0.4F, 0.5F);
    public Color Green = new Color(0.2F, 0.3F, 0.4F, 0.5F);

    Queue<Color> colorstack = new Queue<Color>();
    public int l;
	// Use this for initialization
	void Start () {
        l = 1;
        colorchange = 0;
        gameControllerObject = GameObject.FindGameObjectWithTag("GameController");
        LowerBorderObject = GameObject.FindGameObjectWithTag("lowborder");

        loadingbar = GameObject.FindGameObjectWithTag("LoadingBar");

        int j = Random.Range(0, 3);
        colorstack.Enqueue(colorPickerlevel1(j));
        loadingbar.GetComponent<LoadingBar>().nextcolor(colorstack.Peek());
        currentcolor = colorstack.Peek();
        rnleft.material.color = rnright.material.color = rntop.material.color = colorstack.Peek();
        LowerBorderObject.GetComponent<LowerBorder>().rnleft.material.color = LowerBorderObject.GetComponent<LowerBorder>().rnright.material.color = LowerBorderObject.GetComponent<LowerBorder>().rnbottom.material.color = rnleft.material.color;
		InvokeRepeating("colorRandom", 10, 10.0f);
        
       

        

         
	}

    void Update()
    {
        l =  gameControllerObject.GetComponent<GameController>().level;
        colorchange = Time.deltaTime + colorchange;
      // Debug.Log("colorchange" + colorchange);
    }
	
	public 	string colorshow()
	{
        Debug.Log("yoyo"+currentcolor.ToString());
        if (currentcolor == Red)
        {
            return "red";
        }
        else if(currentcolor == Yellow)
        {
            return "yellow";
        }
        else if (currentcolor == Green)
        {
            return "green";
        }
        else if (currentcolor == Purple)
        {
            return "purple";
        }
        else if (currentcolor == Orange)
        {
            return "orange";
        }
        else if (currentcolor == Pink)
        {
            return "pink";
        }
        else if (currentcolor == White)
        {
            return "white";
        }
        else if (currentcolor == Brown)
        {
            return "brown";
        }
        else
        {
            return "red";
        }

	}
	Color colorPickerlevel1(int i)
	{
		if (i ==0)
		{

			color ="red";
			return Red;


			
		}
        else if (i == 1)
        {

            color = "brown";
            return Brown;
        }
        else
        {
            color = "orange";
            return Orange;
        }
		

	}



    Color colorPickerlevel2(int i)
    {
        if (i == 0)
        {

            color = "red";
            return Red;



        }
        else if (i == 1)
        {

            color = "yellow";
            return Yellow;
        }
        else
        {
            color = "orange";
            return Orange;
        }
    }


    Color colorPickerlevel3(int i)
    {
        if (i == 0)
        {

            color = "pink";
            return Pink;



        }
        else if (i == 1)
        {

            color = "yellow";
            return Yellow;
        }
        else if (i == 2)
        {
            color = "orange";
            return Orange;
        }

        else if (i == 3)
        {
            color = "red";
            return Red;
        }

        else
        {
            color = "brown";
            return Brown;
        }
    }


    Color colorPickerlevel4(int i)
    {
        if (i == 0)
        {

            color = "pink";
            return Pink;



        }
        else if (i == 1)
        {

            color = "yellow";
            return Yellow;
        }
        

        else if (i == 2)
        {
            color = "white";
			return White;
        }

        else
        {
            color = "brown";
            return Brown;
        }
    }



    Color colorPickerlevel5(int i)
    {
        if (i == 0)
        {

            color = "pink";
            return Pink;



        }
        else if (i == 1)
        {

            color = "yellow";
            return Yellow;
        }


        else if (i == 2)
        {
            color = "purple";
            return Purple;
        }

        else
        {
            color = "brown";
            return Brown;
        }
    }



    Color colorPickerlevel6(int i)
    {
        if (i == 0)
        {

            color = "pink";
            return Pink;



        }
        else if (i == 1)
        {

            color = "yellow";
            return Yellow;
        }


        else if (i == 2)
        {
            color = "purple";
            return Purple;
        }

        else if (i == 3)
        {
            color = "brown";
            return Brown;
        }

        else
        {
            color = "white";
            return White;
        }
    }


    Color colorPickerlevel7(int i)
    {
		if (i == 0) {

			color = "pink";
			return Pink;



		} else if (i == 1) {

			color = "yellow";
			return Yellow;
		} else if (i == 2) {
			color = "purple";
			return Purple;
		} else if (i == 3) {
			color = "brown";
			return Brown;
		} else if (i == 4) {
			color = "red";
			return Red;
		} else {
			color = "white";
			return White;
		}
    }


    Color colorPickerlevel8(int i)
    {
        if (i == 0)
        {

            color = "green";
            return Green;



        }
        else if (i == 1)
        {

            color = "yellow";
            return Yellow;
        }


        else if (i == 2)
        {
            color = "purple";
            return Purple;
        }

        else if (i == 3)
        {
            color = "brown";
            return Brown;
        }

        else if (i == 4)
        {
            color = "orange";
            return Orange;
        }

        else
        {
            color = "red";
            return Red;
        }
    }



    Color colorPickerlevel9(int i)
    {
        if (i == 0)
        {

            color = "green";
            return Green;



        }
        else if (i == 1)
        {

            color = "yellow";
            return Yellow;
        }


        else if (i == 2)
        {
            color = "purple";
            return Purple;
        }

        else if (i == 3)
        {
            color = "brown";
            return Brown;
        }

        else if (i == 4)
        {
            color = "orange";
            return Orange;
        }

        else
        {
            color = "red";
            return Red;
        }
    }



    Color colorPickerlevel10(int i)
    {
        if (i == 0)
        {

            color = "green";
            return Green;



        }
        else if (i == 1)
        {

            color = "yellow";
            return Yellow;
        }


        else if (i == 2)
        {
            color = "purple";
            return Purple;
        }

        else if (i == 3)
        {
            color = "brown";
            return Brown;
        }

        else if (i == 4)
        {
            color = "orange";
            return Orange;
        }

        else 
        {
            color = "pink";
            return Pink;
        }
    }






   public void colorch()
    {
        colorchange = Time.deltaTime + colorchange;
        Debug.Log("ColorChange" + colorchange);
    }


	void colorRandom()
	{
        colorchange = 0;
        

     currentcolor =   colorstack.Peek();
        rnleft.material.color = rnright.material.color = rntop.material.color = colorstack.Peek();
        LowerBorderObject.GetComponent<LowerBorder>().rnleft.material.color = LowerBorderObject.GetComponent<LowerBorder>().rnright.material.color = LowerBorderObject.GetComponent<LowerBorder>().rnbottom.material.color = rnleft.material.color;
        
		int j = Random.Range (0 ,3);
        if (l == 1)
        {
             
            Debug.Log("Im in Level 1 ");
            colorstack.Dequeue();

			do{
				j = Random.Range(0, 3);
				nextcolor = colorPickerlevel2(j);
			}while(nextcolor==currentcolor);

				colorstack.Enqueue(nextcolor);

           loadingbar.GetComponent<LoadingBar>().nextcolor(colorstack.Peek());
            
            
            
        }
        else if( l  == 2)
        {
            j = Random.Range(0, 5);
            colorstack.Dequeue();
			do{
				j = Random.Range(0, 3);
				nextcolor = colorPickerlevel3(j);
			}while(nextcolor==currentcolor);

			colorstack.Enqueue(nextcolor);

            loadingbar.GetComponent<LoadingBar>().nextcolor(colorstack.Peek());
        }
        else if (l == 3)
        {
           
            colorstack.Dequeue();
			do{
				j = Random.Range(0, 4);
				nextcolor = colorPickerlevel4(j);
			}while(nextcolor==currentcolor);

			colorstack.Enqueue(nextcolor);

            loadingbar.GetComponent<LoadingBar>().nextcolor(colorstack.Peek());
        }

        else if (l == 4)
        {
          
            colorstack.Dequeue();
			do{
				j = Random.Range(0, 3);
				nextcolor = colorPickerlevel5(j);
			}while(nextcolor==currentcolor);

			colorstack.Enqueue(nextcolor);

            loadingbar.GetComponent<LoadingBar>().nextcolor(colorstack.Peek());
        }

        else if (l == 5)
        {
            
            colorstack.Dequeue();
			do{
				j = Random.Range(0, 4);
				nextcolor = colorPickerlevel6(j);
			}while(nextcolor==currentcolor);

			colorstack.Enqueue(nextcolor);

            loadingbar.GetComponent<LoadingBar>().nextcolor(colorstack.Peek());
        }

        else if (l == 6)
        {
           // j = Random.Range(0, 4);
            colorstack.Dequeue();
			do{
				j = Random.Range(0, 4);
				nextcolor = colorPickerlevel7(j);
			}while(nextcolor==currentcolor);

			colorstack.Enqueue(nextcolor);

            loadingbar.GetComponent<LoadingBar>().nextcolor(colorstack.Peek());
        }

        else if (l == 7)
        {
            
            colorstack.Dequeue();
			do{
				j = Random.Range(0, 5);
				nextcolor = colorPickerlevel8(j);
			}while(nextcolor==currentcolor);

			colorstack.Enqueue(nextcolor);

            loadingbar.GetComponent<LoadingBar>().nextcolor(colorstack.Peek());
        }

        else if (l == 8)
        {
           
            colorstack.Dequeue();
			do{
				j = Random.Range(0, 3);
				nextcolor = colorPickerlevel9(j);
			}while(nextcolor==currentcolor);

			colorstack.Enqueue(nextcolor);

            loadingbar.GetComponent<LoadingBar>().nextcolor(colorstack.Peek());
        }

        else if (l == 9)
        {
            
            colorstack.Dequeue();
			do{
				j = Random.Range(0, 5);
				nextcolor = colorPickerlevel10(j);
			}while(nextcolor==currentcolor);

			colorstack.Enqueue(nextcolor);

            loadingbar.GetComponent<LoadingBar>().nextcolor(colorstack.Peek());
        }

        else if (l == 10)
        {
            
            colorstack.Dequeue();
			do{
				j = Random.Range(0, 3);
				nextcolor = colorPickerlevel4(j);
			}while(nextcolor==currentcolor);

			colorstack.Enqueue(nextcolor);

            loadingbar.GetComponent<LoadingBar>().nextcolor(colorstack.Peek());
        }



       
	}
	
	
	
}



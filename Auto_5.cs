using System;

public class Auto	//5.1
{
	public string Marke { get; set; }   //5.1
    public int Baujahr { get; set; }	//5.1
	public int Geschwindigkeit { get; set; }    //5.4

    public Auto(string marke, int baujahr)   //5.1
	{
		Marke = marke;		//5.1
		Baujahr = baujahr;  //5.1
		Geschwindigkeit = 0; //5.4
	}

	public void Anzeigen()   //5.2
	{
		Console.WriteLine($"Marke: {Marke}\t Baujahr: {Baujahr}");  //5.2
	}

	public void Fahren(int geschwindigkeit)
	{
		Geschwindigkeit = geschwindigkeit;
			Console.WriteLine($"Du fährst mit deinem {Marke} aktuell {Geschwindigkeit} km/h."); //5.5
	}

	public void Info()
	{
        Console.WriteLine($"Marke: {Marke}\t Baujahr: {Baujahr}");
    }
	
}

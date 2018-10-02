using System;
[Serializable]

public class Persona{
	private string nombre;
	private string apellido;
	private int edad;

	public Persona(string nombre, string apellido, int edad){
		this.nombre = nombre;
		this.apellido = apellido;
		this.edad = edad;
	}

	public Persona(){}

	public string Nombre{
		get{
			return nombre;
		}
		set{
			nombre = value;
		}
	}
	public string Apellido{
		get{
			return apellido;
		}
		set{
			apellido = value;
		}
	}	
	public int Edad{
		get{
			return edad;
		}
		set{
			edad = value;
		}
	}
}
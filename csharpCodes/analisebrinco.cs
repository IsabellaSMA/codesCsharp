Cliente brinco= new Cliente();
		Console.Writeline("Seja bem vindo a Análise de tipo de brinco");
		Console.WriteLine("Aguarde a inspeção......");
		Console.ReadLine();
		Console.WriteLine("Inspeção Concluída. Aperte Enter para continuar");
		Console.ReadLine();
		Console.Clear();
		Console.WriteLine("Tipo de Brinco: "+ brinco.nome);
		
	

public class Cliente 
{
	public string nome;
	public int idade;
	
	public void Consultar (string obj){
		nome=obj;
}
}

namespace TP01;
// John Demétrio CB3021718 e Kayky Santos CB3021157
public partial class MainPage : ContentPage
{
	public Login login = new("admin", "senha@dmin");
	
	public MainPage()
	{
		InitializeComponent();
	}
	
	void LimparClickButton(object sender, EventArgs e)
	{
		idEntry.Text = "";
		senhaEntry.Text = "";
	}
	void OkClickButton(object sender, EventArgs e)
	{
		if((idEntry.Text == login.Id) && (senhaEntry.Text == login.Senha))
		{
			DisplayAlert("Login", "Logado com sucesso", "Ok");
		}
		else
		{
			DisplayAlert("Login", "Login incorreto. Tente Novamente", "Ok");
		}
	}
	void CreditosClickButton(object sender, EventArgs e)
	{
		DisplayAlert("Creditos", "John Demétrio CB3021718 e Kayky Santos CB3021157", "Ok");
	}
}

public class Login
{
	public string Id { get; set; }
	public string Senha { get; set; }
	public Login(string id, string senha)
	{
		Id = id;
		Senha = senha;
	}
}


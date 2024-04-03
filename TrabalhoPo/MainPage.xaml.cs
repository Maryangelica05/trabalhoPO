namespace TrabalhoPo;

public partial class MainPage : ContentPage
{
	firefly vagalume;
	koala coalhada;
	duck donald;
	Bear withhalf;
	Personagem atual;

	//--------------------------------------------------------------------------------

	public MainPage()
	{
		InitializeComponent();
		vagalume = new firefly();
		coalhada = new koala();
		donald   = new duck();
		withhalf = new Bear();

		atual = vagalume;

		AtualizaPersonagem();
		
		var timer=Application.Current.Dispatcher.CreateTimer();
		timer.Interval=TimeSpan.FromSeconds(3);
		timer.Tick += (s,e) => PassouTempo();
		timer.Start();

	}

	//--------------------------------------------------------------------------------
    void PassouTempo()
	{
		atual.SetFome(atual.GetFome()-0.1);
		atual.SetSede(atual.GetSede()-0.1);
		atual.SetBanho(atual.GetBanho()-0.1);
        AtualizaPersonagem();
	}


	void TrocaPersonagem(object sender, EventArgs args)
	{
		if (atual == vagalume)
			atual = coalhada;
		else if (atual == coalhada)
			atual = donald;
		else if (atual == donald)
		    atual = withhalf;
		else if  (atual == withhalf)
		    atual = vagalume;

		AtualizaPersonagem();
	}
         void VoltaPersonagem(object sender, EventArgs args)
	{
		if (atual == vagalume)
			atual = withhalf;
		else if (atual == withhalf)
			atual = donald;
		else if (atual == donald)
		    atual = coalhada;
		else if (atual == coalhada)
			atual = vagalume;


		AtualizaPersonagem();
	}
	//--------------------------------------------------------------------------------

	void AtualizaPersonagem()
	{
		ImgPersonagem.Source = atual.GetArquivo();
		Sede.Progress = atual.GetSede();
		Fome.Progress = atual.GetFome();
		Banho.Progress = atual.GetBanho();
	}
	void SedePersonagem(object sender, EventArgs args)
	{
		atual.SetSede(atual.GetSede()+0.1);
		AtualizaPersonagem();
	}
	void FomePersonagem(object sender, EventArgs args)
	{
		atual.SetFome(atual.GetFome()+0.1);
         AtualizaPersonagem();
	}
	void BanhoPersonagem(object sender, EventArgs args)
	{
		atual.SetBanho(atual.GetBanho() +0.1);
         AtualizaPersonagem();
	}
	
}




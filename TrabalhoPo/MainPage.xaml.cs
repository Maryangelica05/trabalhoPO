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
		vagalume.SetFome(vagalume.GetFome()-0.1);
		vagalume.SetSede(vagalume.GetSede()-0.1);
		vagalume.SetBanho(vagalume.GetBanho()-0.1);
        

		coalhada.SetFome(coalhada.GetFome()-0.1);
		coalhada.SetSede(coalhada.GetSede()-0.1);
		coalhada.SetBanho(coalhada.GetBanho()-0.1);
        

		donald.SetFome(donald.GetFome()-0.1);
		donald.SetSede(donald.GetSede()-0.1);
		donald.SetBanho(donald.GetBanho()-0.1);
       
		withhalf.SetFome(withhalf.GetFome()-0.1);
		withhalf.SetSede(withhalf.GetSede()-0.1);
		withhalf.SetBanho(withhalf.GetBanho()-0.1);
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
		ImgPersonagem.Source = atual.GetArquivo();
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
		atual.SetBanho(atual.GetBanho()+0.1);
         AtualizaPersonagem();
	}
 void StartButtonClicked(object sender, EventArgs args)
  {
    
  }
	
}





namespace TrabalhoPo;

public class Personagem
{

  int sede;
  int fome;
  int banho;



public Personagem()
{
   sede=0;
  
   fome=0;

   banho=0;
}

public void SetFome(int f)
{
    if (f<=1 || f>=0)
       fome=f;
    else if(f > 1)
       fome=1;
    else 
       fome=0;
}

public int GetFome()
{
    return fome;
}

}
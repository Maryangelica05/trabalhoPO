
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
public void SetSede(int s)
{
    if (s<=1 || s>=0)
       sede=s;
    else if(s > 1)
       sede=1;
    else 
       sede=0;
}

public int GetSede()
{
    return sede;
}
public void SetBanho(int b)
{
    if (b<=1 || b>=0)
       banho=b;
    else if(s > 1)
       sede=1;
    else 
       banho=0;
}

public int GetBanho()
{
    return banho;
}
}